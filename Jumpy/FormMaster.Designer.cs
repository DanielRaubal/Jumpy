
using System;

namespace Jumpy
{
    partial class FormMaster
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DAButton = new System.Windows.Forms.Button();
            this.COButton = new System.Windows.Forms.Button();
            this.DLButton = new System.Windows.Forms.Button();
            this.FILButton = new System.Windows.Forms.Button();
            this.FIRButton = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.FIRImage = new System.Windows.Forms.PictureBox();
            this.FILImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIRImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FILImage)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DAButton
            // 
            this.DAButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DAButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DAButton.Location = new System.Drawing.Point(12, 209);
            this.DAButton.Name = "DAButton";
            this.DAButton.Size = new System.Drawing.Size(269, 23);
            this.DAButton.TabIndex = 0;
            this.DAButton.Text = "DESTROY ALL";
            this.DAButton.UseVisualStyleBackColor = false;
            this.DAButton.Click += new System.EventHandler(this.DAButton_Click);
            // 
            // COButton
            // 
            this.COButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.COButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.COButton.Location = new System.Drawing.Point(12, 180);
            this.COButton.Name = "COButton";
            this.COButton.Size = new System.Drawing.Size(269, 23);
            this.COButton.TabIndex = 1;
            this.COButton.Text = "CREATE OBJECT";
            this.COButton.UseVisualStyleBackColor = false;
            this.COButton.Click += new System.EventHandler(this.COButton_Click);
            // 
            // DLButton
            // 
            this.DLButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DLButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DLButton.Location = new System.Drawing.Point(12, 238);
            this.DLButton.Name = "DLButton";
            this.DLButton.Size = new System.Drawing.Size(269, 23);
            this.DLButton.TabIndex = 2;
            this.DLButton.Text = "DESTROY LAST";
            this.DLButton.UseVisualStyleBackColor = false;
            this.DLButton.Click += new System.EventHandler(this.DLButton_Click);
            // 
            // FILButton
            // 
            this.FILButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FILButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FILButton.Location = new System.Drawing.Point(13, 151);
            this.FILButton.Name = "FILButton";
            this.FILButton.Size = new System.Drawing.Size(132, 23);
            this.FILButton.TabIndex = 3;
            this.FILButton.Text = "FIND IMAGE LEFT";
            this.FILButton.UseVisualStyleBackColor = false;
            this.FILButton.Click += new System.EventHandler(this.FILButton_Click);
            // 
            // FIRButton
            // 
            this.FIRButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FIRButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FIRButton.Location = new System.Drawing.Point(149, 151);
            this.FIRButton.Name = "FIRButton";
            this.FIRButton.Size = new System.Drawing.Size(132, 23);
            this.FIRButton.TabIndex = 4;
            this.FIRButton.Text = "FIND IMAGE RIGHT";
            this.FIRButton.UseVisualStyleBackColor = false;
            this.FIRButton.Click += new System.EventHandler(this.FIRButton_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(97, 267);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SpeedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpeedLabel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.Location = new System.Drawing.Point(12, 267);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(79, 45);
            this.SpeedLabel.TabIndex = 10;
            this.SpeedLabel.Text = "Speed (pix): 1";
            this.SpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FIRImage
            // 
            this.FIRImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FIRImage.BackgroundImage = global::Jumpy.Properties.Resources.Tnk;
            this.FIRImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FIRImage.Location = new System.Drawing.Point(149, 13);
            this.FIRImage.Name = "FIRImage";
            this.FIRImage.Size = new System.Drawing.Size(132, 132);
            this.FIRImage.TabIndex = 6;
            this.FIRImage.TabStop = false;
            // 
            // FILImage
            // 
            this.FILImage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.FILImage.BackgroundImage = global::Jumpy.Properties.Resources.TnkL;
            this.FILImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FILImage.Location = new System.Drawing.Point(13, 13);
            this.FILImage.Name = "FILImage";
            this.FILImage.Size = new System.Drawing.Size(132, 132);
            this.FILImage.TabIndex = 5;
            this.FILImage.TabStop = false;
            // 
            // FormMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(294, 320);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.FIRImage);
            this.Controls.Add(this.FILImage);
            this.Controls.Add(this.FIRButton);
            this.Controls.Add(this.FILButton);
            this.Controls.Add(this.DLButton);
            this.Controls.Add(this.COButton);
            this.Controls.Add(this.DAButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMaster";
            this.Text = "Jumpy";
            this.Load += new System.EventHandler(this.FormMaster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FIRImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FILImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button DAButton;
        private System.Windows.Forms.Button COButton;
        private System.Windows.Forms.Button DLButton;
        private System.Windows.Forms.Button FILButton;
        private System.Windows.Forms.Button FIRButton;
        private System.Windows.Forms.PictureBox FILImage;
        private System.Windows.Forms.PictureBox FIRImage;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label SpeedLabel;
    }
}

