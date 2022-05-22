using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zad6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openImage_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Images|*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;
                
                var filePath = openFileDialog.FileName;
                    
                var image = Image.FromFile(filePath);
                var pictureBox = new PictureBox()
                {
                    Name = filePath,
                    Size = image.Size,
                    Image = image,
                    SizeMode = PictureBoxSizeMode.AutoSize
                };
                        
                var imageForm = new Form();
                imageForm.MdiParent = this;
                imageForm.Controls.Add(pictureBox);
                imageForm.Size = pictureBox.Size;
                imageForm.Show();
            }
        }
    }
}