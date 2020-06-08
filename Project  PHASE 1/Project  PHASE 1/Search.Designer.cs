namespace Project__PHASE_1
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.PictureBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.CategoryTxt = new System.Windows.Forms.TextBox();
            this.Booktxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchBook = new System.Windows.Forms.DataGridView();
            this.empty = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.searchConfirm = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBook)).BeginInit();
            this.empty.SuspendLayout();
            this.searchConfirm.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Controls.Add(this.searchConfirm);
            this.SearchPanel.Controls.Add(this.exit);
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.CategoryTxt);
            this.SearchPanel.Controls.Add(this.Booktxt);
            this.SearchPanel.Controls.Add(this.label3);
            this.SearchPanel.Controls.Add(this.label2);
            this.SearchPanel.Controls.Add(this.label1);
            this.SearchPanel.Location = new System.Drawing.Point(267, 38);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(464, 347);
            this.SearchPanel.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(377, 39);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 35);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 3;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(191, 264);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(91, 32);
            this.SearchBtn.TabIndex = 7;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.Confirmbtn_Click);
            // 
            // CategoryTxt
            // 
            this.CategoryTxt.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryTxt.Location = new System.Drawing.Point(100, 211);
            this.CategoryTxt.Name = "CategoryTxt";
            this.CategoryTxt.Size = new System.Drawing.Size(266, 30);
            this.CategoryTxt.TabIndex = 5;
            // 
            // Booktxt
            // 
            this.Booktxt.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Booktxt.Location = new System.Drawing.Point(100, 139);
            this.Booktxt.Name = "Booktxt";
            this.Booktxt.Size = new System.Drawing.Size(266, 30);
            this.Booktxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category (Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Raleway", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raleway", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Book";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(711, 465);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SearchBook
            // 
            this.SearchBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SearchBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SearchBook.BackgroundColor = System.Drawing.SystemColors.Control;
            this.SearchBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBook.CausesValidation = false;
            this.SearchBook.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.SearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBook.GridColor = System.Drawing.Color.Black;
            this.SearchBook.Location = new System.Drawing.Point(293, 465);
            this.SearchBook.Name = "SearchBook";
            this.SearchBook.Size = new System.Drawing.Size(412, 175);
            this.SearchBook.TabIndex = 3;
            // 
            // empty
            // 
            this.empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.empty.Controls.Add(this.label7);
            this.empty.Controls.Add(this.button2);
            this.empty.Location = new System.Drawing.Point(267, 115);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(464, 194);
            this.empty.TabIndex = 19;
            this.empty.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(119, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Some Input Boxes are Unfilled";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(170, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 32);
            this.button2.TabIndex = 16;
            this.button2.Text = "Enter Again";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchConfirm
            // 
            this.searchConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(81)))));
            this.searchConfirm.Controls.Add(this.label);
            this.searchConfirm.Controls.Add(this.button3);
            this.searchConfirm.Location = new System.Drawing.Point(0, 77);
            this.searchConfirm.Name = "searchConfirm";
            this.searchConfirm.Size = new System.Drawing.Size(464, 194);
            this.searchConfirm.TabIndex = 8;
            this.searchConfirm.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(141, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(211, 19);
            this.label.TabIndex = 17;
            this.label.Text = "Books Search Successfully";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(81)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(191, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 32);
            this.button3.TabIndex = 16;
            this.button3.Text = "Done";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 747);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.SearchBook);
            this.Controls.Add(this.SearchPanel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBook)).EndInit();
            this.empty.ResumeLayout(false);
            this.empty.PerformLayout();
            this.searchConfirm.ResumeLayout(false);
            this.searchConfirm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SearchPanel;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox CategoryTxt;
        private System.Windows.Forms.TextBox Booktxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.DataGridView SearchBook;
        private System.Windows.Forms.Panel empty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel searchConfirm;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button3;
    }
}