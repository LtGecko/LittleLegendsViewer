# LittleLegendsViewer
Program that loads a list of keywords from the website leagueoflegends.fandom.com/wiki/Little_Legend_(Teamfight_Tactics) that correspond to images, then allows you to download and view them as you like from the list. Sorted by little legend into each of their skin pools.

Works by looking for important markers that are consistent with the Little Legends and no others. First whittle down valid lines to those containing the term 'href', then use specific keywords that mark out Little Legends uniquely, specifically 'variants' and 'base egg'. Then remove all duplicates.

For each, construct a url for that Little Legends wiki page and scan for each of its skins, so as to create a list of the skins unique to that Little Legends.
When a skin is checkmarked, the url to download it is fetched and the image downloaded into memory. This way we do not attempt to download dozens or hundreds of images on every run.
