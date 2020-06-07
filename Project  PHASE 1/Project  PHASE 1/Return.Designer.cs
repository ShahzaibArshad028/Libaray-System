namespace Project__PHASE_1
{
    partial class Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return));
            this.ReturnPanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.ReturnBtn = new System.Windows.Forms.Button();
            this.CnfPsdtxt = new System.Windows.Forms.TextBox();
            this.NewPsdTxt = new System.Windows.Forms.TextBox();
            this.OldPsdTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReturnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnPanel
            // 
            this.ReturnPanel.Controls.Add(this.exit);
            this.ReturnPanel.Controls.Add(this.ReturnBtn);
            this.ReturnPanel.Controls.Add(this.CnfPsdtxt);
            this.ReturnPanel.Controls.Add(this.NewPsdTxt);
            this.ReturnPanel.Controls.Add(this.OldPsdTxt);
            this.ReturnPanel.Controls.Add(this.label4);
            this.ReturnPanel.Controls.Add(this.label3);
            this.ReturnPanel.Controls.Add(this.label2);
            this.ReturnPanel.Controls.Add(this.label1);
            this.ReturnPanel.Location = new System.Drawing.Point(256, 126);
            this.ReturnPanel.Name = "ReturnPanel";
            this.ReturnPanel.Size = new System.Drawing.Size(464, 456);
            this.ReturnPanel.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(397, 49);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 35);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ReturnBtn
            // 
            this.ReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReturnBtn.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnBtn.Location = new System.Drawing.Point(188, 366);
            this.ReturnBtn.Name = "ReturnBtn";
            this.ReturnBtn.Size = new System.Drawing.Size(91, 32);
            this.ReturnBtn.TabIndex = 7;
            this.ReturnBtn.Text = "Return";
            this.ReturnBtn.UseVisualStyleBackColor = true;
            // 
            // CnfPsdtxt
            // 
            this.CnfPsdtxt.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CnfPsdtxt.Location = new System.Drawing.Point(103, 302);
            this.CnfPsdtxt.Name = "CnfPsdtxt";
            this.CnfPsdtxt.Size = new System.Drawing.Size(266, 30);
            this.CnfPsdtxt.TabIndex = 6;
            // 
            // NewPsdTxt
            // 
            this.NewPsdTxt.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPsdTxt.Location = new System.Drawing.Point(103, 223);
            this.NewPsdTxt.Name = "NewPsdTxt";
            this.NewPsdTxt.Size = new System.Drawing.Size(266, 30);
            this.NewPsdTxt.TabIndex = 5;
            // 
            // OldPsdTxt
            // 
            this.OldPsdTxt.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OldPsdTxt.Location = new System.Drawing.Point(103, 151);
            this.OldPsdTxt.Name = "OldPsdTxt";
            this.OldPsdTxt.Size = new System.Drawing.Size(266, 30);
            this.OldPsdTxt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Book";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(716, 492);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 747);
            this.Controls.Add(this.ReturnPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.ReturnPanel.ResumeLayout(false);
            this.ReturnPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ReturnPanel;
        private System.Windows.Forms.Button ReturnBtn;
        private System.Windows.Forms.TextBox NewPsdTxt;
        private System.Windows.Forms.TextBox OldPsdTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CnfPsdtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
    }
}