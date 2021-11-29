using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LilLegendViewer
{
    public partial class YIM : Form
    {
        // Instantiate our HTTP Client
        WebClient webClient = new WebClient();

        // The URLs skimmed from the main targetted page, with their
        // relevant names as keys
        Dictionary<string, string> urls = new Dictionary<string, string>();

        // Contains the naming scheme of all identified valid skins 
        // Key values are the little legends
        // Values are the skin name and the associated tier
        // e.g. Furyhorn, Furyhorn_Victorious_Tier_1.png
        Dictionary<string, List<string>> skinName = new Dictionary<string, List<string>>();


        // Dictionary to store the temporarily loaded images
        Dictionary<string, Image> imageDict = new Dictionary<string, Image>();

        Boolean LL_Loaded = false;

        public YIM()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            


        }

        // Check the selected radiobuttons under "Category" and send that request
        // to GetUrl. It will then make that information available in the 
        // Dictionary skinName. 
        private void Button_Load_Click(object sender, EventArgs e)
        {
            // Avoid loading everything if we have loaded it already
            if (LL_Loaded)
            {
                return;
            }

            // This always gets changed
            string url = "Empty";
            Label_HTTPFail.Visible = false;

            // Determine the current radiobutton 
            if (rb_LL.Checked)
            {
                url = "https://leagueoflegends.fandom.com/wiki/Little_Legend_(Teamfight_Tactics)";
                string results;
                try
                {
                    // Get the information from the Little Legends site
                    results = webClient.DownloadString(url); // Catch the output
                }
                catch (WebException exception)
                {
                    Label_HTTPFail.Visible = true;
                    Console.WriteLine("\nException Caught!\nMessage :{0} ", exception.Message);
                    return;
                }
                Console.WriteLine("GotHere");

                // Read line by line, eliminate line if failed criteria, recombinate into
                // final string for regex matching
                var sr = new StringReader(results);
                string line;
                string newResults = "";

                Console.WriteLine(results.ToString());

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Contains("href") && line.Contains("base egg") && line.Contains("variants"))
                    {
                        newResults += line;
                        Console.WriteLine(line.ToString());
                    }
                }

                // Run the regex to isolate the names of little legends
                Regex rxNames = new Regex(@"/wiki/(.+?)_\(Teamfight_Tactics\)");
                MatchCollection matches = rxNames.Matches(newResults);

                string previous = "";
                // Iterate through each match and extract the name
                foreach (Match match in matches)
                {
                    string result = match.Value;
                    string text = result.Replace("/wiki/", "").Replace("_(Teamfight_Tactics)", "");

                    if (text.Contains("_(Little_Legend)"))
                    {
                        text = text.Replace("_(Little_Legend)", "");
                    }

                    if (!text.Equals(previous))
                    {
                        // Add to the dictionary of urls to download
                        urls.Add(text, ("https://leagueoflegends.fandom.com" + result));

                        // Add to names in the Character comboBox
                        if (!cB_Character.Items.Contains(text))
                        {
                            cB_Character.Items.Add(text);
                        }
                        
                    }
                    previous = text;
                }

                // Regex for pulling skin names out of the little legends pages
                Regex rxSkins = new Regex(@"/(\w+)_(\w+)_Tier_(.).png");

                // Download the contents from each url and add it to the combo boxes
                foreach (KeyValuePair<string, string> name_url in urls)
                {
                    // Grab the contents so we skim it for skins
                    results = webClient.DownloadString(name_url.Value);

                    matches = rxSkins.Matches(results);

                    List<string> skins = new List<string>();

                    foreach (Match match in matches)
                    {
                        string skinName = match.Value.Replace("/" + name_url.Key + "_", "");

                        if (!skins.Contains(skinName))
                        {
                            // Eliminate incorrectly skimmed skins (skins not specifically for the little legend in question)
                            if (match.Value.Contains(name_url.Key))
                            {
                                skins.Add(skinName);
                            }
                        }
                    }
                    skinName[name_url.Key] = skins;
                }
            }
            label_Character.Visible = true;
            cB_Character.Visible = true;
            LL_Loaded = true;
        }

        private void cB_Character_SelectedIndexChanged(object sender, EventArgs e)
        {

            cB_Skin.Items.Clear();

            // Get the corresponding skin names for the selected Little Legend
            string name = cB_Character.SelectedItem.ToString();
            List<string> results = skinName[name];

            foreach (string skin in results)
            {
                // Add to skin collection
                char[] trimChars = { '_' };
                string skinTrimmed = skin.Replace("Tier_", "").Replace(".png", "").Trim(trimChars);

                cB_Skin.Items.Add(skinTrimmed);
            }

            // Now that we've add the skins, we need to check if any of them should be checked
            // i.e. they exist in the listbox of images
            //foreach (object item in lB_Images.Items){ }

            label_Skin.Visible = true;
            cB_Skin.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cB_Skin_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selected = cB_Skin.SelectedIndex;
            string item =  cB_Skin.Items[selected].ToString();
            string name = cB_Character.SelectedItem.ToString() + "_" + item;

            // If the selected item is checked, we add it to the listBox
            if (cB_Skin.CheckedItems.Contains(item))
            {
                // Ensure it's not already there (LAZY BUG FIX)
                if (!lB_Images.Items.Contains(name))
                {
                    lB_Images.Items.Add(name);


                    // Check if we don't already have the image downloaded
                    if (imageDict.ContainsKey(name))
                    {
                        return;
                    }

                    // Now the fun stuff, we download the image and add it to the imagelist
                    // Our current name is, for example:
                    //  Featherknight_Pengu_1
                    // We need it to be"
                    //  ?file=Featherknight_Pengu_Tier_1.png

                    // So we'll split first on the underscore
                    string tier = item.Substring(item.Length - 1);
                    string skin = item.Substring(0, item.Length -2);
                    string[] pieces = { cB_Character.SelectedItem.ToString(), skin, tier };

                    // Now we recombinate the pieces
                    string fileName = pieces[0] + "_" + pieces[1] + "_Tier_" + pieces[2] + ".png";
                    string url = urls[pieces[0]] + @"?file=" + fileName;

                    // Okay so we messed up and literally need to download the file not 
                    // from what we thought but instead a url like this:
                    // https://static.wikia.nocookie.net/leagueoflegends/images/d/d6/Featherknight_Pengu_Tier_1.png/revision/latest/scale-to-width-down/1000?cb=20190612162426

                    // To do that we need to redownload the html and locate the, say, above url
                    string results = webClient.DownloadString(urls[pieces[0]]);

                    Regex getImageURL = new Regex("\"{1}" + @"https://static.wikia.nocookie.net/leagueoflegends/images/\w{1}/\w{2}/" + fileName + @"/revision/latest\?cb=\d{1,}?" + "\"{1}");

                    char[] toTrim = { '"' };
                    string imageURL = getImageURL.Match(results).Value;
                    imageURL = imageURL.Trim(toTrim);

                    // Download the file and attach to imagelist
                    Byte[] data = webClient.DownloadData(imageURL);

                    Image image = (Bitmap)((new ImageConverter()).ConvertFrom(data));
                    imageDict[name] = image;


                }
            }
            // Else we remove it from the listBox
            else
            {
                // Ensure it's actually there
                if (lB_Images.Items.Contains(name))
                {
                    lB_Images.Items.Remove(name);
                }
            }
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lB_Images.SelectedIndex.Equals(-1))
            {
                label_NoSelectImage.Visible = true;
                return;
            }

            label_NoSelectImage.Visible = false;

            // An item is selected, so grab the image from the imageDict
            pB_Image.Image = imageDict[lB_Images.SelectedItem.ToString()];
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            // Check if an item is selected
            if (lB_Images.SelectedIndex.Equals(-1))
            {
                label_NoSelectImage.Visible = true;
                return;
            }

            label_NoSelectImage.Visible = false;

            // Remove the selected item from the collection
            lB_Images.Items.Remove(lB_Images.SelectedItem);
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            lB_Images.Items.Clear();
        }
    }
}
