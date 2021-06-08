
namespace Factorio_Image_Converter
{
    partial class Form1
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
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.rb_Original = new System.Windows.Forms.RadioButton();
            this.rb_Result = new System.Windows.Forms.RadioButton();
            this.cb_size = new System.Windows.Forms.ComboBox();
            this.Group_Tools = new System.Windows.Forms.GroupBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.btn_palette = new System.Windows.Forms.Button();
            this.Group_Resolution = new System.Windows.Forms.GroupBox();
            this.chk_LockRatio = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Width = new System.Windows.Forms.Label();
            this.Group_Automation = new System.Windows.Forms.GroupBox();
            this.cb_Pixel = new System.Windows.Forms.ComboBox();
            this.btn_AutoResolution = new System.Windows.Forms.Button();
            this.btn_AutoPalette = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.Group_Tools.SuspendLayout();
            this.Group_Resolution.SuspendLayout();
            this.Group_Automation.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_Image
            // 
            this.pb_Image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.Location = new System.Drawing.Point(8, 8);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(369, 343);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // rb_Original
            // 
            this.rb_Original.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb_Original.AutoSize = true;
            this.rb_Original.Checked = true;
            this.rb_Original.Location = new System.Drawing.Point(42, 364);
            this.rb_Original.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Original.Name = "rb_Original";
            this.rb_Original.Size = new System.Drawing.Size(91, 17);
            this.rb_Original.TabIndex = 1;
            this.rb_Original.TabStop = true;
            this.rb_Original.Text = "Original image";
            this.rb_Original.UseVisualStyleBackColor = true;
            this.rb_Original.Click += new System.EventHandler(this.Switch_Image);
            // 
            // rb_Result
            // 
            this.rb_Result.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rb_Result.AutoSize = true;
            this.rb_Result.Location = new System.Drawing.Point(225, 364);
            this.rb_Result.Margin = new System.Windows.Forms.Padding(2);
            this.rb_Result.Name = "rb_Result";
            this.rb_Result.Size = new System.Drawing.Size(86, 17);
            this.rb_Result.TabIndex = 2;
            this.rb_Result.Text = "Result image";
            this.rb_Result.UseVisualStyleBackColor = true;
            this.rb_Result.Click += new System.EventHandler(this.Switch_Image);
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Location = new System.Drawing.Point(14, 17);
            this.cb_size.Margin = new System.Windows.Forms.Padding(2);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(85, 21);
            this.cb_size.TabIndex = 3;
            this.cb_size.Text = "Brush Size";
            // 
            // Group_Tools
            // 
            this.Group_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Tools.Controls.Add(this.btn_color);
            this.Group_Tools.Controls.Add(this.cb_size);
            this.Group_Tools.Controls.Add(this.btn_palette);
            this.Group_Tools.Location = new System.Drawing.Point(391, 40);
            this.Group_Tools.Margin = new System.Windows.Forms.Padding(2);
            this.Group_Tools.Name = "Group_Tools";
            this.Group_Tools.Padding = new System.Windows.Forms.Padding(2);
            this.Group_Tools.Size = new System.Drawing.Size(325, 45);
            this.Group_Tools.TabIndex = 4;
            this.Group_Tools.TabStop = false;
            this.Group_Tools.Text = "Tools";
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(225, 16);
            this.btn_color.Margin = new System.Windows.Forms.Padding(2);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(84, 23);
            this.btn_color.TabIndex = 6;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            // 
            // btn_palette
            // 
            this.btn_palette.Location = new System.Drawing.Point(120, 16);
            this.btn_palette.Margin = new System.Windows.Forms.Padding(2);
            this.btn_palette.Name = "btn_palette";
            this.btn_palette.Size = new System.Drawing.Size(84, 23);
            this.btn_palette.TabIndex = 5;
            this.btn_palette.Text = "Palette";
            this.btn_palette.UseVisualStyleBackColor = true;
            // 
            // Group_Resolution
            // 
            this.Group_Resolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Resolution.Controls.Add(this.chk_LockRatio);
            this.Group_Resolution.Controls.Add(this.textBox1);
            this.Group_Resolution.Controls.Add(this.textBox2);
            this.Group_Resolution.Controls.Add(this.label1);
            this.Group_Resolution.Controls.Add(this.lb_Width);
            this.Group_Resolution.Location = new System.Drawing.Point(391, 89);
            this.Group_Resolution.Margin = new System.Windows.Forms.Padding(2);
            this.Group_Resolution.Name = "Group_Resolution";
            this.Group_Resolution.Padding = new System.Windows.Forms.Padding(2);
            this.Group_Resolution.Size = new System.Drawing.Size(325, 45);
            this.Group_Resolution.TabIndex = 5;
            this.Group_Resolution.TabStop = false;
            this.Group_Resolution.Text = "Resolution";
            // 
            // chk_LockRatio
            // 
            this.chk_LockRatio.AutoSize = true;
            this.chk_LockRatio.Location = new System.Drawing.Point(219, 24);
            this.chk_LockRatio.Margin = new System.Windows.Forms.Padding(2);
            this.chk_LockRatio.Name = "chk_LockRatio";
            this.chk_LockRatio.Size = new System.Drawing.Size(78, 17);
            this.chk_LockRatio.TabIndex = 12;
            this.chk_LockRatio.Text = "Lock Ratio";
            this.chk_LockRatio.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(133, 17);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(71, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "H:";
            // 
            // lb_Width
            // 
            this.lb_Width.AutoSize = true;
            this.lb_Width.Location = new System.Drawing.Point(11, 19);
            this.lb_Width.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Width.Name = "lb_Width";
            this.lb_Width.Size = new System.Drawing.Size(21, 13);
            this.lb_Width.TabIndex = 0;
            this.lb_Width.Text = "W:";
            // 
            // Group_Automation
            // 
            this.Group_Automation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Automation.Controls.Add(this.cb_Pixel);
            this.Group_Automation.Controls.Add(this.btn_AutoResolution);
            this.Group_Automation.Controls.Add(this.btn_AutoPalette);
            this.Group_Automation.Location = new System.Drawing.Point(391, 138);
            this.Group_Automation.Margin = new System.Windows.Forms.Padding(2);
            this.Group_Automation.Name = "Group_Automation";
            this.Group_Automation.Padding = new System.Windows.Forms.Padding(2);
            this.Group_Automation.Size = new System.Drawing.Size(325, 45);
            this.Group_Automation.TabIndex = 6;
            this.Group_Automation.TabStop = false;
            this.Group_Automation.Text = "Automation";
            // 
            // cb_Pixel
            // 
            this.cb_Pixel.FormattingEnabled = true;
            this.cb_Pixel.Location = new System.Drawing.Point(191, 17);
            this.cb_Pixel.Name = "cb_Pixel";
            this.cb_Pixel.Size = new System.Drawing.Size(118, 21);
            this.cb_Pixel.TabIndex = 9;
            this.cb_Pixel.Text = "Pixel To Blocks";
            // 
            // btn_AutoResolution
            // 
            this.btn_AutoResolution.Location = new System.Drawing.Point(14, 16);
            this.btn_AutoResolution.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AutoResolution.Name = "btn_AutoResolution";
            this.btn_AutoResolution.Size = new System.Drawing.Size(84, 23);
            this.btn_AutoResolution.TabIndex = 8;
            this.btn_AutoResolution.Text = "Resolution";
            this.btn_AutoResolution.UseVisualStyleBackColor = true;
            // 
            // btn_AutoPalette
            // 
            this.btn_AutoPalette.Location = new System.Drawing.Point(102, 16);
            this.btn_AutoPalette.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AutoPalette.Name = "btn_AutoPalette";
            this.btn_AutoPalette.Size = new System.Drawing.Size(84, 23);
            this.btn_AutoPalette.TabIndex = 7;
            this.btn_AutoPalette.Text = "Palette";
            this.btn_AutoPalette.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import.Location = new System.Drawing.Point(391, 362);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(139, 28);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(577, 362);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(139, 28);
            this.btn_Export.TabIndex = 8;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            // 
            // btn_About
            // 
            this.btn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About.Location = new System.Drawing.Point(697, 8);
            this.btn_About.Margin = new System.Windows.Forms.Padding(2);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(19, 17);
            this.btn_About.TabIndex = 9;
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 401);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.Group_Automation);
            this.Controls.Add(this.Group_Resolution);
            this.Controls.Add(this.Group_Tools);
            this.Controls.Add(this.rb_Result);
            this.Controls.Add(this.rb_Original);
            this.Controls.Add(this.pb_Image);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(744, 274);
            this.Name = "Form1";
            this.Text = "Factorio Image Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.Group_Tools.ResumeLayout(false);
            this.Group_Resolution.ResumeLayout(false);
            this.Group_Resolution.PerformLayout();
            this.Group_Automation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.RadioButton rb_Original;
        private System.Windows.Forms.RadioButton rb_Result;
        private System.Windows.Forms.ComboBox cb_size;
        private System.Windows.Forms.GroupBox Group_Tools;
        private System.Windows.Forms.Button btn_palette;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.GroupBox Group_Resolution;
        private System.Windows.Forms.GroupBox Group_Automation;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_AutoPalette;
        private System.Windows.Forms.Button btn_AutoResolution;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lb_Width;
        private System.Windows.Forms.CheckBox chk_LockRatio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Pixel;
    }
}

