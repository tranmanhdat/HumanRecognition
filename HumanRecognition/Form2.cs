using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanRecognition
{
    public partial class frmPredict : Form
    {
        public frmPredict()
        {
            InitializeComponent();
        }
        private void frmPredict_Load(object sender, EventArgs e)
        {
        }

        private void btnSelectimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
                "Images (*.JPG;*.PNG;*.jpg;*.png)|*.JPG;*.PNG;*.jpg;*.png|" +
                "All files (*.*)|*.*";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "select images";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach(String file in openFileDialog.FileNames)
                {
                    try
                    {
                        PictureBox pb = new PictureBox();
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        pb.SizeMode = PictureBoxSizeMode.AutoSize;
                        Image loadedImage = Image.FromFile(file);
                        pb.Height = loadedImage.Height;
                        //pb.Height = 500;
                        pb.Width = loadedImage.Width;
                        //pb.Width = 500;
                        pb.Image = loadedImage;
                        flowLayoutImages.Controls.Add(pb);
                    }
                    catch (SecurityException ex)
                    {
                        // The user lacks appropriate permissions to read files, discover paths, etc.
                        MessageBox.Show("Security error. Please contact your administrator for details.\n\n" +
                            "Error message: " + ex.Message + "\n\n" +
                            "Details (send to Support):\n\n" + ex.StackTrace
                        );
                    }
                    catch (Exception ex)
                    {
                        // Could not load the image - probably related to Windows file system permissions.
                        MessageBox.Show("Cannot display the image: " + file.Substring(file.LastIndexOf('\\'))
                            + ". You may not have permission to read the file, or " +
                            "it may be corrupt.\n\nReported error: " + ex.Message);
                    }
                }
            }
        }
    }
}
