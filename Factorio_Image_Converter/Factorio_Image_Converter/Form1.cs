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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Image OriginalImage;
        Image ResultImage;
        List<UBlock> AvailableBlocks;
        List<UTile> AvailableTiles;
        List<Color> AvailableColors;
        List<UBlock> ImageBlocks;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAvailableBlocks();      //Doesn't do anything atm

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
            Debug.WriteLine("Image compressed > " + imageCompressed);
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
                    Debug.WriteLine("Set Result");
                    if (!imageCompressed)
                    {
                        Debug.WriteLine("Compress Result");
                        //Currently abandoned resizing in pursue of deadline, most probably will be added later
                        ImageToSet = OriginalImage;//ResizeImage(ResultImage, OriginalImage.Width / 4, OriginalImage.Height / 4); 
                    }
                }
                pb_Image.Image = ImageToSet;
            }
        }

        private void ConvertImageToBlocks(Image ImageToConvert, int ratio)
        {
            //TODO: Convert pixels of image based on the ratio specified to blocks
            //Ratio specifies how many pixels make up 1 Factorio "pixel" - a ratio of 4 will mean that 1 Factorio "pixel" is made of 4 image pixels

        }
        private void ConvertBlocksToString(List<UBlock> BlockList)
        {
            //TODO: Find out how to do this (maybe reverse engineer Miditorio?)
        }
        private void LoadAvailableBlocks()
        {
            //Loads Factorio Blocks and their colors from a JSON file into a List
            StreamReader sr = new StreamReader(@"..\..\Usable-Blocks.json");
            string jsonString = sr.ReadToEnd();
            URoot uRoot = JsonConvert.DeserializeObject<URoot>(jsonString);
            foreach (UBlock block in uRoot.UsableBlocks.UBlocks)
            {
                AvailableBlocks.Add(block);
            }
            foreach (UTile tile in uRoot.UsableBlocks.UTiles)
            {
                AvailableTiles.Add(tile);
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
    }
}
