using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zlib;

namespace Factorio_Image_Converter
{
    public partial class Form1 : Form
    {
        bool IsRatioLocked;
        bool imageCompressed;
        string imagePath = "";
        int defaultPBWidth;
        int defaultPBHeight;
        int defaultFormWidth;
        int defaultFormHeight;
        int compressionRatio;
        int previousWidth;
        int previousHeight;
        string Blueprint;
        Image OriginalImage;
        Image ResultImage;
        List<UBlock> AvailableBlocks;
        List<UTile> AvailableTiles;
        List<Color> AvailableColors;
        List<Color> ImageColors;
        //TODO: Dictionary that ties image colors with factorio blocks
        Root FactorioBlueprint;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            AvailableBlocks = new List<UBlock>();
            AvailableTiles = new List<UTile>();
            AvailableColors = new List<Color>();
            ImageColors = new List<Color>();
            FactorioBlueprint = new Root();
            LoadAvailableBlocks();
            LoadAvailableColors();

            compressionRatio = 1;

            chk_LockRatio_CheckedChanged(null, null);
            defaultPBWidth = pb_Image.Width;
            defaultPBHeight = pb_Image.Height;
            defaultFormWidth = this.Width;
            defaultFormHeight = this.Height;
        }

        private void btn_Import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.png;*.jpg)|*.png;*.jpg";    //Add more image formats
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;     //Opens up where the user chose the last file

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;

                    //Save the image
                    OriginalImage = Image.FromFile(imagePath);
                    ResultImage = Image.FromFile(imagePath);
                    imageCompressed = false;
                }
            }
            //TODO: Image too big warning

            Switch_Image(null,null);
        }

        private void Switch_Image(object sender, EventArgs e)
        {
            //Debug.WriteLine("Image compressed > " + imageCompressed);
            Image ImageToSet;
            if (rb_Original.Checked)
            {
                ImageToSet = OriginalImage;
                Debug.WriteLine("RB - orig");
            }
            else
            {
                ImageToSet = ResultImage;
                Debug.WriteLine("RB - result");
            }

            if (ImageToSet != null)
            {
                if(ImageToSet == OriginalImage || pb_Image.Image!=OriginalImage)
                {
                    //This is temporary
                    //TODO: Create a more modular solution
                    Debug.WriteLine("Set Orig");
                    if (ImageToSet.Width > 800 || ImageToSet.Height > 500)
                    {
                        this.Size = new Size(defaultFormWidth - defaultPBWidth + OriginalImage.Width / 2, defaultFormHeight - defaultPBHeight + OriginalImage.Height / 2);
                    }
                    else
                    {
                        this.Size = new Size(defaultFormWidth - defaultPBWidth + ImageToSet.Width, defaultFormHeight - defaultPBHeight + ImageToSet.Height);
                    }
                }
                else if (ImageToSet == ResultImage)
                {
                    Debug.WriteLine("Set the Result");
                    if (!imageCompressed)
                    {
                        Debug.WriteLine("Compress the Result");
                        //GetAllImageColors();
                        //ConvertImageColors();                 //Will make this work later, when I have time and no deadline.
                        //CompressImage();                      //Currently abandoned resizing in pursue of deadline, most probably will be added later

                    }
                }
                pb_Image.Image = ImageToSet;
            }
        }
        private void GetAllImageColors()
        {
            //TODO: Get all colors from the image (maybe with some range that represents 1 color?) and save them into List
        }
        private void ConvertImageColors()
        {
            //TODO: Convert pixels to avaliable colors

        }
        private void ConvertImageToBlocks(Image inputImage) //1px = 4 blocks
        {
            InstantiateRoot();
            //TODO: Convert pixels of image to blocks
            int index = 1;
            int found = 0;
            int totalPixels = 0;
            Bitmap bitmap = (Bitmap)inputImage;
            for (int y = 0; y < bitmap.Height; y++)
            {   
                for (int x = 0; x < bitmap.Width; x++)
                {
                    //Debug.WriteLine("x > "+x+" y > "+y);
                    Color pixelColor = bitmap.GetPixel(x, y);
                    string pixelColorHex = ColorTranslator.ToHtml(pixelColor).ToLower();
                    if (pixelColorHex != "#000000") //transparent
                    {
                        totalPixels++;
                        foreach (UBlock block in AvailableBlocks)
                        {
                            //Debug.WriteLine("pixel > " + pixelColorHex + " block > " + block.color);
                            if (pixelColorHex == block.color)
                            {
                                found++;
                                //Debug.WriteLine("block");
                                //All positions must be 0.5 because of rails, rails are 0.0
                                //Coordinates are based on mathematics, not IT
                                //Entities are listed through in pairs of 4, so top left, top right, bottom left, bottom right
                                int sizeX = Convert.ToInt32(block.occupied_space[0].ToString());
                                int sizeY = Convert.ToInt32(block.occupied_space[2].ToString());
                                //Debug.WriteLine("orig > " + block.occupied_space + " x > " + sizeX + " y > " + sizeY);

                                List<Entity> entityList = new List<Entity>();
                                //TODO: Finish and optimize this
                                //Maybe use some "equation" to determine the position and entity amount based on size?
                                if (sizeX == 1 && sizeY == 1)
                                {
                                    Entity entity1 = new Entity();
                                    Entity entity2 = new Entity();
                                    Entity entity3 = new Entity();
                                    Entity entity4 = new Entity();
                                    Position pos1 = new Position();
                                    Position pos2 = new Position();
                                    Position pos3 = new Position();
                                    Position pos4 = new Position();
                                    pos1.x = x + x - 1.5;
                                    pos1.y = y + y - 1.5;
                                    pos2.x = x + x - 0.5;
                                    pos2.y = y + y - 1.5;
                                    pos3.x = x + x - 1.5;
                                    pos3.y = y + y - 0.5;
                                    pos4.x = x + x - 0.5;
                                    pos4.y = y + y - 0.5;

                                    entity1.position = pos1;
                                    entity2.position = pos2;
                                    entity3.position = pos3;
                                    entity4.position = pos4;
                                    entityList.Add(entity1);
                                    entityList.Add(entity2);
                                    entityList.Add(entity3);
                                    entityList.Add(entity4);
                                }
                                else if (sizeX == 2 && sizeY == 1)
                                {
                                    Entity entity1 = new Entity();
                                    Entity entity2 = new Entity();
                                    Position pos1 = new Position();
                                    Position pos2 = new Position();
                                    pos1.x = x + x - 1;
                                    pos1.y = y + y - 1.5;
                                    pos2.x = x + x - 1;
                                    pos2.y = y + y - 0.5;

                                    entity1.position = pos1;
                                    entity2.position = pos2;
                                    entityList.Add(entity1);
                                    entityList.Add(entity2);
                                }
                                else if (sizeX == 1 && sizeY == 2)
                                {
                                    Entity entity1 = new Entity();
                                    Entity entity2 = new Entity();
                                    Position pos1 = new Position();
                                    Position pos2 = new Position();
                                    pos1.x = x + x - 1.5;
                                    pos1.y = y + y - 1;
                                    pos2.x = x + x - 0.5;
                                    pos2.y = y + y - 1;

                                    entity1.position = pos1;
                                    entity2.position = pos2;
                                    entityList.Add(entity1);
                                    entityList.Add(entity2);
                                }
                                else if (sizeX == 2 && sizeY == 2)
                                {
                                    Entity entity1 = new Entity();
                                    Position pos = new Position();
                                    pos.x = x + x - 1;
                                    pos.y = y + y - 1;
                                    entity1.position = pos;
                                    entityList.Add(entity1);
                                }
                                foreach(Entity entity in entityList)
                                {
                                    entity.entity_number = index++;
                                    entity.name = block.name;
                                    if (block.name.Contains("underground"))
                                    {
                                        entity.type = "input";
                                        entity.SType = true;
                                    }
                                    if (block.has_direction)
                                    {
                                        entity.direction = 4;
                                        entity.SDirection = true;
                                    }
                                    FactorioBlueprint.blueprint.entities.Add(entity);
                                }
                                break;
                            }
                        }
                        //TODO: only iterate through if we haven't found a block, otherwise it just slows the app down
                        foreach(UTile tile in AvailableTiles)
                        {
                            //Debug.WriteLine("pixel > " + pixelColorHex + " tile > " + tile.color);
                            if (pixelColorHex == tile.color)
                            {
                                //Debug.WriteLine("tile");
                                found++;
                                Tile tile1 = new Tile();
                                Tile tile2 = new Tile();
                                Tile tile3 = new Tile();
                                Tile tile4 = new Tile();
                                Position pos1 = new Position();
                                Position pos2 = new Position();
                                Position pos3 = new Position();
                                Position pos4 = new Position();
                                tile1.name = tile.name;
                                tile2.name = tile.name;
                                tile3.name = tile.name;
                                tile4.name = tile.name;
                                pos1.x = x + x - 2;
                                pos1.y = y + y - 2;
                                pos2.x = x + x - 1;
                                pos2.y = y + y - 2;
                                pos3.x = x + x - 2;
                                pos3.y = y + y - 1;
                                pos4.x = x + x - 1;
                                pos4.y = y + y - 1;
                                tile1.position = pos1;
                                tile2.position = pos2;
                                tile3.position = pos3;
                                tile4.position = pos4;
                                FactorioBlueprint.blueprint.tiles.Add(tile1);
                                FactorioBlueprint.blueprint.tiles.Add(tile2);
                                FactorioBlueprint.blueprint.tiles.Add(tile3);
                                FactorioBlueprint.blueprint.tiles.Add(tile4);

                                break;
                            }
                        }
                    }
                }
            }
            Debug.WriteLine("total normal pixels > " + totalPixels + " pixels recognized > "+ found);
        }
        private void InstantiateRoot()
        {
            FactorioBlueprint = new Root();
            FactorioBlueprint.blueprint = new Blueprint();
            FactorioBlueprint.blueprint.description = "The result image made by Zapper's Factorio Image Converter";
            FactorioBlueprint.blueprint.icons = new List<Icon>();
            FactorioBlueprint.blueprint.entities = new List<Entity>();
            FactorioBlueprint.blueprint.tiles = new List<Tile>();
            FactorioBlueprint.blueprint.item = "blueprint";
            FactorioBlueprint.blueprint.label = "Image";
            FactorioBlueprint.blueprint.version = 281479273906176;     //Factorio map version number, not sure how to get it so I harcoded the current version
            Icon defaultIcon = new Icon();
            defaultIcon.signal = new Signal();
            defaultIcon.signal.type = "item";
            defaultIcon.signal.name = "wooden-chest";
            defaultIcon.index = 1;
            FactorioBlueprint.blueprint.icons.Add(defaultIcon);
        }
        public void ConvertBlocksToJSON(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                JsonSerializer jsonSerializer = new JsonSerializer();
                jsonSerializer.Serialize(sw, FactorioBlueprint);
            }
            Debug.WriteLine("saved JSON to \""+path+"\"");
        }
        private void CompressAndEncodeJSON(string path)
        {
            //compress the JSON file using zlib deflate compression level 9, then convert to base64 and put '0' at the start
            string json;
            StreamReader streamReader = new StreamReader(path);
            json = streamReader.ReadToEnd();
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] jsonArray = encoding.GetBytes(json);
            byte[] compressedArray;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (ZOutputStream zOutput = new ZOutputStream(memoryStream, zlibConst.Z_DEFAULT_COMPRESSION))
                {
                    using(Stream stream = new MemoryStream(jsonArray))
                    {
                        byte[] buffer = new byte[2000];
                        int len;
                        while ((len = stream.Read(buffer, 0, 2000)) > 0)
                        {
                            zOutput.Write(buffer, 0, len);
                        }
                        zOutput.Flush();
                        zOutput.finish();
                        compressedArray = memoryStream.ToArray();
                    }
                }
            }
            Blueprint = "0" + Convert.ToBase64String(compressedArray);
            Debug.WriteLine("\n\n Blueprint \n" + Blueprint);
            /*
            using (FileStream jsonFileStream = File.OpenRead(path))
            {
                using (DeflateStream decompressionStream = new DeflateStream(jsonFileStream, CompressionLevel.))
                {

                }
            }
            */
        }
        private void LoadAvailableBlocks()
        {
            //Loads Factorio Blocks and their colors from a JSON file into a List
            StreamReader sr = new StreamReader(@"..\..\Usable-Blocks.json");
            string jsonString = sr.ReadToEnd();
            URoot uRoot = JsonConvert.DeserializeObject<URoot>(jsonString); //Populate the C# structure with JSON data
            foreach (UBlock block in uRoot.UsableBlocks.UBlocks)
            {
                AvailableBlocks.Add(block);
            }
            foreach (UTile tile in uRoot.UsableBlocks.UTiles)
            {
                AvailableTiles.Add(tile);
            }
        }
        private void LoadAvailableColors()
        {
            //Reads all colors from available blocks and puts them into a list
            foreach(UBlock block in AvailableBlocks)
            {
                Color newColor = ColorTranslator.FromHtml(block.color);
                AvailableColors.Add(newColor);
            }
            foreach(UTile tile in AvailableTiles)
            {
                Color newColor = ColorTranslator.FromHtml(tile.color);
                AvailableColors.Add(newColor);
            }
        }

        private void chk_LockRatio_CheckedChanged(object sender, EventArgs e)
        {
            IsRatioLocked = chk_LockRatio.Checked;
        }

        private void Resolution_TextChanged(object sender, EventArgs e)
        {
            int x, y;
            x = y = 0;
            TextBox SenderTB = (TextBox)sender;
            if (pb_Image.Image != null)
            {
                if (IsRatioLocked)
                {
                    if (SenderTB.Name.ToLower().Contains("width"))
                    {
                        x = Convert.ToInt32(SenderTB.Text);
                    }
                    else
                    {
                        y = Convert.ToInt32(SenderTB.Text);
                    }
                }
            }

            //ResizeImage();
            imageCompressed = false;
        }
        private int ChangeResolutionWithRatio(int changedValue, int valueToAdjust)
        {
            int result = 0;
            

            return result;
        }

        private void cb_Pixel_SelectedIndexChanged(object sender, EventArgs e)
        {
            compressionRatio = Convert.ToInt32(cb_Pixel.Text.Substring(0,cb_Pixel.Text.IndexOf("x")));

            //FIX: Crashes if no image is loaded
            tb_ImageWidth.Text = (OriginalImage.Width / compressionRatio).ToString();
            tb_ImageHeight.Text = (OriginalImage.Height / compressionRatio).ToString();

            imageCompressed = false;
        }
        /*
        private void CompressImage()
        {
            //FIX: Crashes if no compression rate given

            //temp code for testing purposes
            //Go through all pixels
            //Take average of {compressionRatio} neighbouring pixels
            //Write the average to a new image

            imageCompressed = true;
        }
        */
        
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            //Will be most probably replaced
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighSpeed;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.None;
                graphics.PixelOffsetMode = PixelOffsetMode.None;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            destImage.Save("output.bmp");
            return destImage;
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            ConvertImageToBlocks(ResultImage);       //This will convert only available colors in the image to blocks, so for now input can be only made from those colors
            ConvertBlocksToJSON(@"..\..\Blueprint.json");
            CompressAndEncodeJSON(@"..\..\Blueprint.json");

            
        }
        private void FeatureNotImplemented(object sender, EventArgs e)
        {
            MessageBox.Show("I'm sorry but this feature is not yet implemented");  
        }
    }
}
