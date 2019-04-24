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
            this.btnStep1 = new System.Windows.Forms.Button();
            this.btnStep2 = new System.Windows.Forms.Button();
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
            // btnStep1
            // 
            this.btnStep1.Location = new System.Drawing.Point(698, 41);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(195, 58);
            this.btnStep1.TabIndex = 7;
            this.btnStep1.Text = "STEP 1";
            this.btnStep1.UseVisualStyleBackColor = true;
            this.btnStep1.Click += new System.EventHandler(this.btnStep1_Click);
            // 
            // btnStep2
            // 
            this.btnStep2.Location = new System.Drawing.Point(698, 105);
            this.btnStep2.Name = "btnStep2";
            this.btnStep2.Size = new System.Drawing.Size(195, 58);
            this.btnStep2.TabIndex = 8;
            this.btnStep2.Text = "STEP 2";
            this.btnStep2.UseVisualStyleBackColor = true;
            this.btnStep2.Click += new System.EventHandler(this.btnStep2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 565);
            this.Controls.Add(this.btnStep2);
            this.Controls.Add(this.btnStep1);
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
        private System.Windows.Forms.Button btnStep1;
        private System.Windows.Forms.Button btnStep2;
    }
}

