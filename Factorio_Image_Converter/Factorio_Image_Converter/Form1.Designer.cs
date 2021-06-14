
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
            this.tb_ImageWidth = new System.Windows.Forms.TextBox();
            this.tb_ImageHeight = new System.Windows.Forms.TextBox();
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
            this.pb_Image.Location = new System.Drawing.Point(12, 12);
            this.pb_Image.MinimumSize = new System.Drawing.Size(264, 268);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(654, 522);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Image.TabIndex = 0;
            this.pb_Image.TabStop = false;
            // 
            // rb_Original
            // 
            this.rb_Original.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rb_Original.AutoSize = true;
            this.rb_Original.Checked = true;
            this.rb_Original.Location = new System.Drawing.Point(12, 557);
            this.rb_Original.Name = "rb_Original";
            this.rb_Original.Size = new System.Drawing.Size(134, 24);
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
            this.rb_Result.Location = new System.Drawing.Point(347, 557);
            this.rb_Result.Name = "rb_Result";
            this.rb_Result.Size = new System.Drawing.Size(127, 24);
            this.rb_Result.TabIndex = 2;
            this.rb_Result.Text = "Result image";
            this.rb_Result.UseVisualStyleBackColor = true;
            this.rb_Result.Click += new System.EventHandler(this.Switch_Image);
            // 
            // cb_size
            // 
            this.cb_size.FormattingEnabled = true;
            this.cb_size.Items.AddRange(new object[] {
            "1px",
            "4px",
            "16px"});
            this.cb_size.Location = new System.Drawing.Point(21, 26);
            this.cb_size.Name = "cb_size";
            this.cb_size.Size = new System.Drawing.Size(126, 28);
            this.cb_size.TabIndex = 3;
            this.cb_size.Text = "Brush Size";
            // 
            // Group_Tools
            // 
            this.Group_Tools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Tools.Controls.Add(this.btn_color);
            this.Group_Tools.Controls.Add(this.cb_size);
            this.Group_Tools.Controls.Add(this.btn_palette);
            this.Group_Tools.Location = new System.Drawing.Point(688, 62);
            this.Group_Tools.Name = "Group_Tools";
            this.Group_Tools.Size = new System.Drawing.Size(488, 69);
            this.Group_Tools.TabIndex = 4;
            this.Group_Tools.TabStop = false;
            this.Group_Tools.Text = "Tools";
            // 
            // btn_color
            // 
            this.btn_color.Location = new System.Drawing.Point(338, 25);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(126, 35);
            this.btn_color.TabIndex = 6;
            this.btn_color.Text = "Color";
            this.btn_color.UseVisualStyleBackColor = true;
            // 
            // btn_palette
            // 
            this.btn_palette.Location = new System.Drawing.Point(180, 25);
            this.btn_palette.Name = "btn_palette";
            this.btn_palette.Size = new System.Drawing.Size(126, 35);
            this.btn_palette.TabIndex = 5;
            this.btn_palette.Text = "Palette";
            this.btn_palette.UseVisualStyleBackColor = true;
            // 
            // Group_Resolution
            // 
            this.Group_Resolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Resolution.Controls.Add(this.chk_LockRatio);
            this.Group_Resolution.Controls.Add(this.tb_ImageWidth);
            this.Group_Resolution.Controls.Add(this.tb_ImageHeight);
            this.Group_Resolution.Controls.Add(this.label1);
            this.Group_Resolution.Controls.Add(this.lb_Width);
            this.Group_Resolution.Location = new System.Drawing.Point(688, 137);
            this.Group_Resolution.Name = "Group_Resolution";
            this.Group_Resolution.Size = new System.Drawing.Size(488, 69);
            this.Group_Resolution.TabIndex = 5;
            this.Group_Resolution.TabStop = false;
            this.Group_Resolution.Text = "Resolution";
            // 
            // chk_LockRatio
            // 
            this.chk_LockRatio.AutoSize = true;
            this.chk_LockRatio.Checked = true;
            this.chk_LockRatio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_LockRatio.Location = new System.Drawing.Point(328, 37);
            this.chk_LockRatio.Name = "chk_LockRatio";
            this.chk_LockRatio.Size = new System.Drawing.Size(111, 24);
            this.chk_LockRatio.TabIndex = 12;
            this.chk_LockRatio.Text = "Lock Ratio";
            this.chk_LockRatio.UseVisualStyleBackColor = true;
            this.chk_LockRatio.CheckedChanged += new System.EventHandler(this.chk_LockRatio_CheckedChanged);
            // 
            // tb_ImageWidth
            // 
            this.tb_ImageWidth.Location = new System.Drawing.Point(44, 26);
            this.tb_ImageWidth.Name = "tb_ImageWidth";
            this.tb_ImageWidth.Size = new System.Drawing.Size(104, 26);
            this.tb_ImageWidth.TabIndex = 2;
            // 
            // tb_ImageHeight
            // 
            this.tb_ImageHeight.Location = new System.Drawing.Point(200, 26);
            this.tb_ImageHeight.Name = "tb_ImageHeight";
            this.tb_ImageHeight.Size = new System.Drawing.Size(104, 26);
            this.tb_ImageHeight.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "H:";
            // 
            // lb_Width
            // 
            this.lb_Width.AutoSize = true;
            this.lb_Width.Location = new System.Drawing.Point(16, 29);
            this.lb_Width.Name = "lb_Width";
            this.lb_Width.Size = new System.Drawing.Size(28, 20);
            this.lb_Width.TabIndex = 0;
            this.lb_Width.Text = "W:";
            // 
            // Group_Automation
            // 
            this.Group_Automation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Group_Automation.Controls.Add(this.cb_Pixel);
            this.Group_Automation.Controls.Add(this.btn_AutoResolution);
            this.Group_Automation.Controls.Add(this.btn_AutoPalette);
            this.Group_Automation.Location = new System.Drawing.Point(688, 212);
            this.Group_Automation.Name = "Group_Automation";
            this.Group_Automation.Size = new System.Drawing.Size(488, 69);
            this.Group_Automation.TabIndex = 6;
            this.Group_Automation.TabStop = false;
            this.Group_Automation.Text = "Automation";
            // 
            // cb_Pixel
            // 
            this.cb_Pixel.FormattingEnabled = true;
            this.cb_Pixel.Items.AddRange(new object[] {
            "1x",
            "4x",
            "16x"});
            this.cb_Pixel.Location = new System.Drawing.Point(286, 26);
            this.cb_Pixel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Pixel.Name = "cb_Pixel";
            this.cb_Pixel.Size = new System.Drawing.Size(175, 28);
            this.cb_Pixel.TabIndex = 9;
            this.cb_Pixel.Text = "Compression Rate";
            this.cb_Pixel.SelectedIndexChanged += new System.EventHandler(this.cb_Pixel_SelectedIndexChanged);
            // 
            // btn_AutoResolution
            // 
            this.btn_AutoResolution.Location = new System.Drawing.Point(21, 25);
            this.btn_AutoResolution.Name = "btn_AutoResolution";
            this.btn_AutoResolution.Size = new System.Drawing.Size(126, 35);
            this.btn_AutoResolution.TabIndex = 8;
            this.btn_AutoResolution.Text = "Resolution";
            this.btn_AutoResolution.UseVisualStyleBackColor = true;
            // 
            // btn_AutoPalette
            // 
            this.btn_AutoPalette.Location = new System.Drawing.Point(153, 25);
            this.btn_AutoPalette.Name = "btn_AutoPalette";
            this.btn_AutoPalette.Size = new System.Drawing.Size(126, 35);
            this.btn_AutoPalette.TabIndex = 7;
            this.btn_AutoPalette.Text = "Palette";
            this.btn_AutoPalette.UseVisualStyleBackColor = true;
            // 
            // btn_Import
            // 
            this.btn_Import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Import.Location = new System.Drawing.Point(688, 552);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(208, 43);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Export.Location = new System.Drawing.Point(968, 552);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(208, 43);
            this.btn_Export.TabIndex = 8;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_About
            // 
            this.btn_About.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_About.Location = new System.Drawing.Point(1148, 12);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(28, 26);
            this.btn_About.TabIndex = 9;
            this.btn_About.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 612);
            this.Controls.Add(this.btn_About);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.Group_Automation);
            this.Controls.Add(this.Group_Resolution);
            this.Controls.Add(this.Group_Tools);
            this.Controls.Add(this.rb_Result);
            this.Controls.Add(this.rb_Original);
            this.Controls.Add(this.pb_Image);
            this.MinimumSize = new System.Drawing.Size(829, 405);
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
        private System.Windows.Forms.TextBox tb_ImageWidth;
        private System.Windows.Forms.Label lb_Width;
        private System.Windows.Forms.CheckBox chk_LockRatio;
        private System.Windows.Forms.TextBox tb_ImageHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Pixel;
    }
}

