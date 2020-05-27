namespace HumanRecognition
{
    partial class frmPredict
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
            this.btnSelectimage = new System.Windows.Forms.Button();
            this.flowLayoutImages = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPredict = new System.Windows.Forms.Button();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSelectimage
            // 
            this.btnSelectimage.Location = new System.Drawing.Point(12, 12);
            this.btnSelectimage.Name = "btnSelectimage";
            this.btnSelectimage.Size = new System.Drawing.Size(116, 39);
            this.btnSelectimage.TabIndex = 0;
            this.btnSelectimage.Text = "Select image";
            this.btnSelectimage.UseVisualStyleBackColor = true;
            this.btnSelectimage.Click += new System.EventHandler(this.btnSelectimage_Click);
            // 
            // flowLayoutImages
            // 
            this.flowLayoutImages.AutoScroll = true;
            this.flowLayoutImages.Location = new System.Drawing.Point(12, 57);
            this.flowLayoutImages.Name = "flowLayoutImages";
            this.flowLayoutImages.Size = new System.Drawing.Size(500, 453);
            this.flowLayoutImages.TabIndex = 1;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(674, 12);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(116, 39);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // txbResult
            // 
            this.txbResult.Enabled = false;
            this.txbResult.Location = new System.Drawing.Point(517, 57);
            this.txbResult.Margin = new System.Windows.Forms.Padding(2);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbResult.Size = new System.Drawing.Size(659, 454);
            this.txbResult.TabIndex = 3;
            // 
            // frmPredict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 522);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.flowLayoutImages);
            this.Controls.Add(this.btnSelectimage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPredict";
            this.RightToLeftLayout = true;
            this.Text = "Predict";
            this.Load += new System.EventHandler(this.frmPredict_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectimage;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutImages;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.TextBox txbResult;
    }
}