namespace PA6 {
    partial class UpsertBook {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtCopiesAvailable = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnUpsert = new System.Windows.Forms.Button();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblCopiesAvailable = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picBx = new System.Windows.Forms.PictureBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(12, 242);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(173, 20);
            this.txtLength.TabIndex = 32;
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(12, 199);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(173, 20);
            this.txtISBN.TabIndex = 31;
            // 
            // txtCopiesAvailable
            // 
            this.txtCopiesAvailable.Location = new System.Drawing.Point(12, 156);
            this.txtCopiesAvailable.Name = "txtCopiesAvailable";
            this.txtCopiesAvailable.Size = new System.Drawing.Size(173, 20);
            this.txtCopiesAvailable.TabIndex = 30;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(12, 113);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(173, 20);
            this.txtGenre.TabIndex = 29;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(12, 70);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(173, 20);
            this.txtAuthor.TabIndex = 28;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(173, 20);
            this.txtTitle.TabIndex = 27;
            // 
            // btnUpsert
            // 
            this.btnUpsert.Location = new System.Drawing.Point(12, 277);
            this.btnUpsert.Name = "btnUpsert";
            this.btnUpsert.Size = new System.Drawing.Size(75, 23);
            this.btnUpsert.TabIndex = 26;
            this.btnUpsert.UseVisualStyleBackColor = true;
            this.btnUpsert.Click += new System.EventHandler(this.btnUpsert_Click);
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(9, 226);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(40, 13);
            this.lblLength.TabIndex = 25;
            this.lblLength.Text = "Length";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(9, 183);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 24;
            this.lblISBN.Text = "ISBN";
            // 
            // lblCopiesAvailable
            // 
            this.lblCopiesAvailable.AutoSize = true;
            this.lblCopiesAvailable.Location = new System.Drawing.Point(9, 140);
            this.lblCopiesAvailable.Name = "lblCopiesAvailable";
            this.lblCopiesAvailable.Size = new System.Drawing.Size(88, 13);
            this.lblCopiesAvailable.TabIndex = 23;
            this.lblCopiesAvailable.Text = "Copies Available ";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(9, 97);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 22;
            this.lblGenre.Text = "Genre";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(9, 54);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(38, 13);
            this.lblAuthor.TabIndex = 21;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Title";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(108, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picBx
            // 
            this.picBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBx.Location = new System.Drawing.Point(221, 11);
            this.picBx.Name = "picBx";
            this.picBx.Size = new System.Drawing.Size(160, 185);
            this.picBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx.TabIndex = 34;
            this.picBx.TabStop = false;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(221, 223);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(160, 23);
            this.btnPreview.TabIndex = 35;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(244, 199);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(137, 20);
            this.txtUrl.TabIndex = 36;
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(219, 202);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(23, 13);
            this.lblUrl.TabIndex = 37;
            this.lblUrl.Text = "Url:";
            // 
            // UpsertBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 323);
            this.ControlBox = false;
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.picBx);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.txtCopiesAvailable);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnUpsert);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblCopiesAvailable);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpsertBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtCopiesAvailable;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnUpsert;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblCopiesAvailable;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picBx;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label lblUrl;
    }
}