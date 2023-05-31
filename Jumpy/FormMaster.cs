using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Jumpy
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;

            COButton.Enabled = false;
            DAButton.Enabled = false;
            DLButton.Enabled = false;


            SizeList.Add(new Size());
            SizeList.Add(new Size());

            timer1.Start();
        }

        public static Bitmap OpenDialog(string Title)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.png; *.jpeg; *.gif; *.bmp)|*.png; *.jpeg; *.gif; *.bmp ";
            open.Title = Title;

            if (open.ShowDialog() != DialogResult.OK)
            {
                return Properties.Resources.Tnk;
            }

            return new Bitmap(open.FileName);
        }

        private void FILButton_Click(object sender, EventArgs e)
        {
            BitmapL = OpenDialog("FIND IMAGE LEFT");
            FILImage.BackgroundImage = BitmapL;
        }

        private void FIRButton_Click(object sender, EventArgs e)
        {
            BitmapR = OpenDialog("FIND IMAGE RIGHT");
            FIRImage.BackgroundImage = BitmapR;
        }

        public Bitmap BitmapL, BitmapR;
        List<Form> FormList = new List<Form>();
        int SpawnedNum;

        private void COButton_Click(object sender, EventArgs e)
        {
            FormMovement CreatedForm = new FormMovement();
            CreatedForm.BitmapR = (Bitmap)FIRImage.BackgroundImage;
            CreatedForm.BitmapL = (Bitmap)FILImage.BackgroundImage;
            CreatedForm.pomeraj = trackBar1.Value;

            SpawnedNum++;
            CreatedForm.Text += SpawnedNum;

            CreatedForm.Show();
            CreatedForm.Activate();

            FormList.Add(CreatedForm);
        }

        private void DAButton_Click(object sender, EventArgs e)
        {
            foreach (FormMovement item in FormList)
            {
                item.Close();
            }

            FormList.Clear();

            DAButton.Enabled = false;
            DLButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FormList.Count > 0)
            {
                DAButton.Enabled = true;
                DLButton.Enabled = true;
            }

            if (FILImage.BackgroundImage != null && FIRImage.BackgroundImage != null)
            {
                COButton.Enabled = true;
            }
            else
            {
                COButton.Enabled = false;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            SpeedLabel.Text = "Speed (pix):" + trackBar1.Value;
        }

        public List<Size> SizeList = new List<Size>();

        private void DLButton_Click(object sender, EventArgs e)
        {
            if (FormList.Count > 0)
            {
                FormList[FormList.Count - 1].Close();
                FormList.RemoveAt(FormList.Count - 1);
            }
            else
            {
                DAButton.Enabled = false;
                DLButton.Enabled = false;
            }

        }
    }
}
