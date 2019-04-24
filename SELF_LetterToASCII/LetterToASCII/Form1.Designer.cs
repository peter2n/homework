namespace LetterToASCII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOut1 = new System.Windows.Forms.Label();
            this.txtIN1 = new System.Windows.Forms.TextBox();
            this.txtIN2 = new System.Windows.Forms.TextBox();
            this.lblOut2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOut1
            // 
            this.lblOut1.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOut1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut1.Location = new System.Drawing.Point(27, 89);
            this.lblOut1.Name = "lblOut1";
            this.lblOut1.Size = new System.Drawing.Size(1461, 37);
            this.lblOut1.TabIndex = 1;
            this.lblOut1.Text = "Код на буквите";
            this.lblOut1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIN1
            // 
            this.txtIN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIN1.Location = new System.Drawing.Point(27, 32);
            this.txtIN1.Name = "txtIN1";
            this.txtIN1.Size = new System.Drawing.Size(1461, 24);
            this.txtIN1.TabIndex = 2;
            this.txtIN1.Text = "Въведи текст";
            this.txtIN1.TextChanged += new System.EventHandler(this.txtIN_TextChanged);
            // 
            // txtIN2
            // 
            this.txtIN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtIN2.Location = new System.Drawing.Point(27, 207);
            this.txtIN2.Name = "txtIN2";
            this.txtIN2.Size = new System.Drawing.Size(1461, 24);
            this.txtIN2.TabIndex = 4;
            this.txtIN2.TextChanged += new System.EventHandler(this.txtIN2_TextChanged);
            // 
            // lblOut2
            // 
            this.lblOut2.BackColor = System.Drawing.Color.BurlyWood;
            this.lblOut2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOut2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOut2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOut2.Location = new System.Drawing.Point(27, 264);
            this.lblOut2.Name = "lblOut2";
            this.lblOut2.Size = new System.Drawing.Size(1461, 37);
            this.lblOut2.TabIndex = 3;
            this.lblOut2.Text = "Код на буквите";
            this.lblOut2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Moccasin;
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(27, 59);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(1461, 30);
            this.lbl1.TabIndex = 7;
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Moccasin;
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl2.Location = new System.Drawing.Point(27, 234);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(1461, 30);
            this.lbl2.TabIndex = 8;
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1515, 357);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtIN2);
            this.Controls.Add(this.lblOut2);
            this.Controls.Add(this.txtIN1);
            this.Controls.Add(this.lblOut1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Текст към Unicode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOut1;
        private System.Windows.Forms.TextBox txtIN1;
        private System.Windows.Forms.TextBox txtIN2;
        private System.Windows.Forms.Label lblOut2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
    }
}

