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
            this.listviewImages = new System.Windows.Forms.ListView();
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
            // 
            // listviewImages
            // 
            this.listviewImages.HideSelection = false;
            this.listviewImages.Location = new System.Drawing.Point(154, 22);
            this.listviewImages.Name = "listviewImages";
            this.listviewImages.Size = new System.Drawing.Size(433, 485);
            this.listviewImages.TabIndex = 1;
            this.listviewImages.UseCompatibleStateImageBehavior = false;
            // 
            // frmPredict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.listviewImages);
            this.Controls.Add(this.btnSelectimage);
            this.Name = "frmPredict";
            this.RightToLeftLayout = true;
            this.Text = "Predict";
            this.Load += new System.EventHandler(this.frmPredict_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelectimage;
        private System.Windows.Forms.ListView listviewImages;
    }
}