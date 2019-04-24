namespace INK
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
            this.lblSourcePDF = new System.Windows.Forms.Label();
            this.picPageImg = new System.Windows.Forms.PictureBox();
            this.lblPageImg = new System.Windows.Forms.Label();
            this.btnSelectPdfCreatePage = new System.Windows.Forms.Button();
            this.btnPdfProperties = new System.Windows.Forms.Button();
            this.btnPdfSize = new System.Windows.Forms.Button();
            this.btnPdfLinks = new System.Windows.Forms.Button();
            this.btnModifiPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPageImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSourcePDF
            // 
            this.lblSourcePDF.AllowDrop = true;
            this.lblSourcePDF.BackColor = System.Drawing.Color.SandyBrown;
            this.lblSourcePDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSourcePDF.Location = new System.Drawing.Point(12, 9);
            this.lblSourcePDF.Name = "lblSourcePDF";
            this.lblSourcePDF.Size = new System.Drawing.Size(495, 41);
            this.lblSourcePDF.TabIndex = 0;
            this.lblSourcePDF.Text = "Довлачи pdf-а с мастилата";
            this.lblSourcePDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSourcePDF.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblSourcePDF_DragDrop);
            this.lblSourcePDF.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblSourcePDF_DragEnter);
            // 
            // picPageImg
            // 
            this.picPageImg.Location = new System.Drawing.Point(43, 89);
            this.picPageImg.Name = "picPageImg";
            this.picPageImg.Size = new System.Drawing.Size(280, 200);
            this.picPageImg.TabIndex = 1;
            this.picPageImg.TabStop = false;
            // 
            // lblPageImg
            // 
            this.lblPageImg.Location = new System.Drawing.Point(387, 94);
            this.lblPageImg.Name = "lblPageImg";
            this.lblPageImg.Size = new System.Drawing.Size(204, 195);
            this.lblPageImg.TabIndex = 2;
            this.lblPageImg.Text = "label1";
            // 
            // btnSelectPdfCreatePage
            // 
            this.btnSelectPdfCreatePage.Location = new System.Drawing.Point(688, 37);
            this.btnSelectPdfCreatePage.Name = "btnSelectPdfCreatePage";
            this.btnSelectPdfCreatePage.Size = new System.Drawing.Size(195, 58);
            this.btnSelectPdfCreatePage.TabIndex = 3;
            this.btnSelectPdfCreatePage.Text = "selectPDF";
            this.btnSelectPdfCreatePage.UseVisualStyleBackColor = true;
            this.btnSelectPdfCreatePage.Click += new System.EventHandler(this.btnSelectPdfCreatePage_Click);
            // 
            // btnPdfProperties
            // 
            this.btnPdfProperties.Location = new System.Drawing.Point(688, 123);
            this.btnPdfProperties.Name = "btnPdfProperties";
            this.btnPdfProperties.Size = new System.Drawing.Size(195, 58);
            this.btnPdfProperties.TabIndex = 4;
            this.btnPdfProperties.Text = "selectPDF";
            this.btnPdfProperties.UseVisualStyleBackColor = true;
            this.btnPdfProperties.Click += new System.EventHandler(this.btnPdfProperties_Click);
            // 
            // btnPdfSize
            // 
            this.btnPdfSize.Location = new System.Drawing.Point(688, 197);
            this.btnPdfSize.Name = "btnPdfSize";
            this.btnPdfSize.Size = new System.Drawing.Size(195, 58);
            this.btnPdfSize.TabIndex = 5;
            this.btnPdfSize.Text = "selectPDF";
            this.btnPdfSize.UseVisualStyleBackColor = true;
            this.btnPdfSize.Click += new System.EventHandler(this.btnPdfSize_Click);
            // 
            // btnPdfLinks
            // 
            this.btnPdfLinks.Location = new System.Drawing.Point(688, 271);
            this.btnPdfLinks.Name = "btnPdfLinks";
            this.btnPdfLinks.Size = new System.Drawing.Size(195, 58);
            this.btnPdfLinks.TabIndex = 6;
            this.btnPdfLinks.Text = "selectPDF";
            this.btnPdfLinks.UseVisualStyleBackColor = true;
            this.btnPdfLinks.Click += new System.EventHandler(this.btnPdfLinks_Click);
            // 
            // btnModifiPdf
            // 
            this.btnModifiPdf.Location = new System.Drawing.Point(688, 335);
            this.btnModifiPdf.Name = "btnModifiPdf";
            this.btnModifiPdf.Size = new System.Drawing.Size(195, 58);
            this.btnModifiPdf.TabIndex = 7;
            this.btnModifiPdf.Text = "modify";
            this.btnModifiPdf.UseVisualStyleBackColor = true;
            this.btnModifiPdf.Click += new System.EventHandler(this.btnModifiPdf_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 565);
            this.Controls.Add(this.btnModifiPdf);
            this.Controls.Add(this.btnPdfLinks);
            this.Controls.Add(this.btnPdfSize);
            this.Controls.Add(this.btnPdfProperties);
            this.Controls.Add(this.btnSelectPdfCreatePage);
            this.Controls.Add(this.lblPageImg);
            this.Controls.Add(this.picPageImg);
            this.Controls.Add(this.lblSourcePDF);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picPageImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSourcePDF;
        private System.Windows.Forms.PictureBox picPageImg;
        private System.Windows.Forms.Label lblPageImg;
        private System.Windows.Forms.Button btnSelectPdfCreatePage;
        private System.Windows.Forms.Button btnPdfProperties;
        private System.Windows.Forms.Button btnPdfSize;
        private System.Windows.Forms.Button btnPdfLinks;
        private System.Windows.Forms.Button btnModifiPdf;
    }
}

