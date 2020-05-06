using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumanRecognition
{
    public partial class frmPredict : Form
    {
        List<string> imagePath = new List<string>();
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
                        imagePath.Add(file);
                        PictureBox pb = new PictureBox();
                        pb.BackgroundImageLayout = ImageLayout.Stretch;
                        pb.SizeMode = PictureBoxSizeMode.AutoSize;
                        Image loadedImage = Image.FromFile(file);
                        loadedImage = this.ResizeImage(loadedImage, 500, 500);
                        pb.Height = loadedImage.Height;
                        pb.Width = loadedImage.Width;
                        pb.Image = (Image)loadedImage;
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
        public  Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://192.168.1.109:8000/predict");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "multipart/form-data");
            foreach(String path in imagePath)
            {
                request.AddFile("file", path);
            }
            IRestResponse response = client.Execute(request);
            txbResult.Text = response.Content;
            //dynamic stuff = JObject.Parse(response.Content);
        }
    }
}
