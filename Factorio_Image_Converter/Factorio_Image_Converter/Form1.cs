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
        string ImagePath = "";
        int DefaultPBWidth;
        int DefaultPBHeight;
        int DefaultFormWidth;
        int DefaultFormHeight;
        Image OriginalImage;
        Image ResultImage;
        List<Block> AvailableBlocks;
        List<Block> ImageBlocks;

        public Form1()
        {
            InitializeComponent();
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
                    ImagePath = openFileDialog.FileName;

                    //Save the image
                    OriginalImage = Image.FromFile(ImagePath);
                }
            }
            //TODO: Image too big warning

            Switch_Image(null,null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load file with all usable blocks
            //TODO: Create this file
            DefaultPBWidth = pb_Image.Width;
            DefaultPBHeight = pb_Image.Height;
            DefaultFormWidth = this.Width;
            DefaultFormHeight = this.Height;
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
                //This is temporary
                //TODO: Create a more modular solution
                if (ImageToSet.Width > 800 || ImageToSet.Height > 500)
                {
                    this.Size = new Size(DefaultFormWidth-DefaultPBWidth + OriginalImage.Width/2, DefaultFormHeight - DefaultPBHeight + OriginalImage.Height/2);
                }
                else
                {
                    this.Size = new Size(DefaultFormWidth - DefaultPBWidth + ImageToSet.Width, DefaultFormHeight - DefaultPBHeight + ImageToSet.Height);
                }
                pb_Image.Image = ImageToSet;
            }
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
    }
}
