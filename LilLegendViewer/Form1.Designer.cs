
namespace LilLegendViewer
{
    partial class YIM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YIM));
            this.cB_Character = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Character = new System.Windows.Forms.Label();
            this.label_Skin = new System.Windows.Forms.Label();
            this.rb_LL = new System.Windows.Forms.RadioButton();
            this.Label_HTTPFail = new System.Windows.Forms.Label();
            this.Button_Load = new System.Windows.Forms.Button();
            this.cB_Skin = new System.Windows.Forms.CheckedListBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lB_Images = new System.Windows.Forms.ListBox();
            this.label_Images = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Display = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.pB_Image = new System.Windows.Forms.PictureBox();
            this.label_NoSelectImage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_Character
            // 
            this.cB_Character.FormattingEnabled = true;
            this.cB_Character.Location = new System.Drawing.Point(12, 103);
            this.cB_Character.Name = "cB_Character";
            this.cB_Character.Size = new System.Drawing.Size(182, 21);
            this.cB_Character.TabIndex = 1;
            this.cB_Character.Visible = false;
            this.cB_Character.SelectedIndexChanged += new System.EventHandler(this.cB_Character_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Category";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_Character
            // 
            this.label_Character.AutoSize = true;
            this.label_Character.Location = new System.Drawing.Point(9, 87);
            this.label_Character.Name = "label_Character";
            this.label_Character.Size = new System.Drawing.Size(53, 13);
            this.label_Character.TabIndex = 4;
            this.label_Character.Text = "Character";
            this.label_Character.Visible = false;
            // 
            // label_Skin
            // 
            this.label_Skin.AutoSize = true;
            this.label_Skin.Location = new System.Drawing.Point(9, 140);
            this.label_Skin.Name = "label_Skin";
            this.label_Skin.Size = new System.Drawing.Size(28, 13);
            this.label_Skin.TabIndex = 5;
            this.label_Skin.Text = "Skin";
            this.label_Skin.Visible = false;
            this.label_Skin.Click += new System.EventHandler(this.label3_Click);
            // 
            // rb_LL
            // 
            this.rb_LL.AutoSize = true;
            this.rb_LL.Checked = true;
            this.rb_LL.Location = new System.Drawing.Point(12, 29);
            this.rb_LL.Name = "rb_LL";
            this.rb_LL.Size = new System.Drawing.Size(91, 17);
            this.rb_LL.TabIndex = 6;
            this.rb_LL.TabStop = true;
            this.rb_LL.Text = "Little Legends";
            this.rb_LL.UseVisualStyleBackColor = true;
            this.rb_LL.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Label_HTTPFail
            // 
            this.Label_HTTPFail.AutoSize = true;
            this.Label_HTTPFail.ForeColor = System.Drawing.Color.Red;
            this.Label_HTTPFail.Location = new System.Drawing.Point(333, 133);
            this.Label_HTTPFail.Name = "Label_HTTPFail";
            this.Label_HTTPFail.Size = new System.Drawing.Size(196, 13);
            this.Label_HTTPFail.TabIndex = 7;
            this.Label_HTTPFail.Text = "HTTP Request Failed. Please Try Again";
            this.Label_HTTPFail.Visible = false;
            // 
            // Button_Load
            // 
            this.Button_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Load.Location = new System.Drawing.Point(12, 52);
            this.Button_Load.Name = "Button_Load";
            this.Button_Load.Size = new System.Drawing.Size(91, 23);
            this.Button_Load.TabIndex = 8;
            this.Button_Load.Text = "Load";
            this.Button_Load.UseVisualStyleBackColor = true;
            this.Button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // cB_Skin
            // 
            this.cB_Skin.CheckOnClick = true;
            this.cB_Skin.FormattingEnabled = true;
            this.cB_Skin.Location = new System.Drawing.Point(12, 158);
            this.cB_Skin.Name = "cB_Skin";
            this.cB_Skin.Size = new System.Drawing.Size(182, 724);
            this.cB_Skin.Sorted = true;
            this.cB_Skin.TabIndex = 9;
            this.cB_Skin.Visible = false;
            this.cB_Skin.SelectedIndexChanged += new System.EventHandler(this.cB_Skin_SelectedIndexChanged_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lB_Images
            // 
            this.lB_Images.FormattingEnabled = true;
            this.lB_Images.Location = new System.Drawing.Point(214, 29);
            this.lB_Images.MultiColumn = true;
            this.lB_Images.Name = "lB_Images";
            this.lB_Images.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lB_Images.Size = new System.Drawing.Size(920, 95);
            this.lB_Images.Sorted = true;
            this.lB_Images.TabIndex = 10;
            // 
            // label_Images
            // 
            this.label_Images.AutoSize = true;
            this.label_Images.Location = new System.Drawing.Point(211, 9);
            this.label_Images.Name = "label_Images";
            this.label_Images.Size = new System.Drawing.Size(80, 13);
            this.label_Images.TabIndex = 11;
            this.label_Images.Text = "Loaded Images";
            this.label_Images.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(1035, 129);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(99, 23);
            this.button_Clear.TabIndex = 12;
            this.button_Clear.Text = "Clear List";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Display
            // 
            this.button_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Display.Location = new System.Drawing.Point(214, 129);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(99, 23);
            this.button_Display.TabIndex = 13;
            this.button_Display.Text = "Display Image";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Remove.Location = new System.Drawing.Point(623, 129);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(99, 23);
            this.button_Remove.TabIndex = 14;
            this.button_Remove.Text = "Remove Image";
            this.button_Remove.UseVisualStyleBackColor = true;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // pB_Image
            // 
            this.pB_Image.Image = ((System.Drawing.Image)(resources.GetObject("pB_Image.Image")));
            this.pB_Image.InitialImage = ((System.Drawing.Image)(resources.GetObject("pB_Image.InitialImage")));
            this.pB_Image.Location = new System.Drawing.Point(214, 158);
            this.pB_Image.Name = "pB_Image";
            this.pB_Image.Size = new System.Drawing.Size(920, 729);
            this.pB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pB_Image.TabIndex = 15;
            this.pB_Image.TabStop = false;
            // 
            // label_NoSelectImage
            // 
            this.label_NoSelectImage.AutoSize = true;
            this.label_NoSelectImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NoSelectImage.ForeColor = System.Drawing.Color.Red;
            this.label_NoSelectImage.Location = new System.Drawing.Point(344, 136);
            this.label_NoSelectImage.Name = "label_NoSelectImage";
            this.label_NoSelectImage.Size = new System.Drawing.Size(147, 13);
            this.label_NoSelectImage.TabIndex = 16;
            this.label_NoSelectImage.Text = "Error: Please Select an Image";
            this.label_NoSelectImage.Visible = false;
            // 
            // YIM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1155, 891);
            this.Controls.Add(this.label_NoSelectImage);
            this.Controls.Add(this.pB_Image);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label_Images);
            this.Controls.Add(this.lB_Images);
            this.Controls.Add(this.cB_Skin);
            this.Controls.Add(this.Button_Load);
            this.Controls.Add(this.Label_HTTPFail);
            this.Controls.Add(this.rb_LL);
            this.Controls.Add(this.label_Skin);
            this.Controls.Add(this.label_Character);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cB_Character);
            this.Name = "YIM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lil Legend Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pB_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cB_Character;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Character;
        private System.Windows.Forms.Label label_Skin;
        private System.Windows.Forms.RadioButton rb_LL;
        private System.Windows.Forms.Label Label_HTTPFail;
        private System.Windows.Forms.Button Button_Load;
        private System.Windows.Forms.CheckedListBox cB_Skin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lB_Images;
        private System.Windows.Forms.Label label_Images;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.PictureBox pB_Image;
        private System.Windows.Forms.Label label_NoSelectImage;
    }
}

