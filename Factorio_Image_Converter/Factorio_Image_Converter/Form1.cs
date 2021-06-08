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
        Image OriginalImage;
        Image ResultImage;

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
            Debug.WriteLine(ImagePath);
            Switch_Image(null,null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load file with all usable blocks
            //TODO: Create this file
            DefaultPBWidth = pb_Image.Width;
            DefaultPBHeight = pb_Image.Height;
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
                if (ImageToSet.Width > 800 && ImageToSet.Height > 800)
                {
                    //Not like this, add difference between image size and default pb size
                    this.Size = new Size(ImageToSet.Width / 2, ImageToSet.Height / 2);
                }
                else
                {
                    
                }
                pb_Image.Image = ImageToSet;
            }
        }
    }
}
