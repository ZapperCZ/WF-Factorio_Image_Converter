using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
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
        string imagePath = "";
        int defaultPBWidth;
        int defaultPBHeight;
        int defaultFormWidth;
        int defaultFormHeight;
        int compressionRate;
        int previousWidth;
        int previousHeight;
        Image OriginalImage;
        Image ResultImage;
        List<Block> AvailableBlocks;
        List<Block> ImageBlocks;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAvailableBlocks();      //Doesn't do anything atm

            compressionRate = 1;

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
                openFileDialog.Filter = "Image files (*.jpg;*.png)|*.jpg;*.png";    //Add more image formats
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;     //Opens up where the user chose the last file

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;

                    //Save the image
                    OriginalImage = Image.FromFile(imagePath);
                }
            }
            //TODO: Image too big warning

            Switch_Image(null,null);
        }

        private void Switch_Image(object sender, EventArgs e)
        {
            Image ImageToSet;
            if (rb_Original.Checked)
            {
                ImageToSet = OriginalImage;
            }
            else
            {
                ImageToSet = ResultImage;
            }

            if (ImageToSet != null)
            {
                if(ImageToSet == OriginalImage && pb_Image.Image!=OriginalImage)
                {
                    //This is temporary
                    //TODO: Create a more modular solution
                    if (ImageToSet.Width > 800 || ImageToSet.Height > 500)
                    {
                        this.Size = new Size(defaultFormWidth - defaultPBWidth + OriginalImage.Width / 2, defaultFormHeight - defaultPBHeight + OriginalImage.Height / 2);
                    }
                    else
                    {
                        this.Size = new Size(defaultFormWidth - defaultPBWidth + ImageToSet.Width, defaultFormHeight - defaultPBHeight + ImageToSet.Height);
                    }
                }
                pb_Image.Image = ImageToSet;
            }
        }
        private void ResizeImage(int x = 0, int y = 0)
        {
            //Resizes the image, if ratio is locked only 1 value has to be specified
        }
        private void ConvertImageToBlocks(Image ImageToConvert, int ratio)
        {
            //TODO: Convert pixels of image based on the ratio specified to blocks
            //Ratio specifies how many pixels make up 1 Factorio "pixel" - a ratio of 4 will mean that 1 Factorio "pixel" is made of 4 image pixels

        }
        private void ConvertBlocksToString(List<Block> BlockList)
        {
            //TODO: Find out how to do this (maybe reverse engineer Miditorio?)
        }
        private void LoadAvailableBlocks()
        {
            //Loads Factorio Blocks and their colors from a JSON file into a List
            //TODO: Create this file
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


            ResizeImage();
        }
        private int ChangeResolutionWithRatio(int changedValue, int valueToAdjust)
        {
            int result = 0;
            

            return result;
        }

        private void cb_Pixel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
