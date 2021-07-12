using System;

namespace VideoRental
{
    partial class Mainform
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
            this.LoadButton = new System.Windows.Forms.Button();
            this.LoadMov = new System.Windows.Forms.Button();
            this.LoadRenMovie = new System.Windows.Forms.Button();
            this.IssueMovieBtn = new System.Windows.Forms.Button();
            this.RetMovieBtn = new System.Windows.Forms.Button();
            this.PopMovieBtn = new System.Windows.Forms.Button();
            this.PopularcustBtn = new System.Windows.Forms.Button();
            this.MainGrid = new System.Windows.Forms.DataGridView();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DltBtn = new System.Windows.Forms.Button();
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.UpdMovieButton = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.Custbtn = new System.Windows.Forms.TextBox();
            this.FNBtn = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.MovIDBtn = new System.Windows.Forms.TextBox();
            this.PhBtn = new System.Windows.Forms.TextBox();
            this.AddressBtn = new System.Windows.Forms.TextBox();
            this.LNBtn = new System.Windows.Forms.TextBox();
            this.CustIDLabel = new System.Windows.Forms.Label();
            this.FNLabel = new System.Windows.Forms.Label();
            this.LNLabel = new System.Windows.Forms.Label();
            this.AdLabel = new System.Windows.Forms.Label();
            this.PhLabel = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.MovieIDLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.RCLabel = new System.Windows.Forms.Label();
            this.CopiesLabel = new System.Windows.Forms.Label();
            this.PlotLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(13, 13);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(109, 66);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load Customer";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // LoadMov
            // 
            this.LoadMov.Location = new System.Drawing.Point(145, 13);
            this.LoadMov.Margin = new System.Windows.Forms.Padding(4);
            this.LoadMov.Name = "LoadMov";
            this.LoadMov.Size = new System.Drawing.Size(109, 66);
            this.LoadMov.TabIndex = 3;
            this.LoadMov.Text = "Load Movies";
            this.LoadMov.UseVisualStyleBackColor = true;
            this.LoadMov.Click += new System.EventHandler(this.LoadMov_Click);
            // 
            // LoadRenMovie
            // 
            this.LoadRenMovie.Location = new System.Drawing.Point(277, 13);
            this.LoadRenMovie.Margin = new System.Windows.Forms.Padding(4);
            this.LoadRenMovie.Name = "LoadRenMovie";
            this.LoadRenMovie.Size = new System.Drawing.Size(109, 66);
            this.LoadRenMovie.TabIndex = 36;
            this.LoadRenMovie.Text = "Load Rented Movies";
            this.LoadRenMovie.UseVisualStyleBackColor = true;
            // 
            // IssueMovieBtn
            // 
            this.IssueMovieBtn.Location = new System.Drawing.Point(406, 13);
            this.IssueMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.IssueMovieBtn.Name = "IssueMovieBtn";
            this.IssueMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.IssueMovieBtn.TabIndex = 37;
            this.IssueMovieBtn.Text = "Issue Movie";
            this.IssueMovieBtn.UseVisualStyleBackColor = true;
            // 
            // RetMovieBtn
            // 
            this.RetMovieBtn.Location = new System.Drawing.Point(535, 13);
            this.RetMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RetMovieBtn.Name = "RetMovieBtn";
            this.RetMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.RetMovieBtn.TabIndex = 38;
            this.RetMovieBtn.Text = "Return Movie";
            this.RetMovieBtn.UseVisualStyleBackColor = true;
            // 
            // PopMovieBtn
            // 
            this.PopMovieBtn.Location = new System.Drawing.Point(703, 13);
            this.PopMovieBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PopMovieBtn.Name = "PopMovieBtn";
            this.PopMovieBtn.Size = new System.Drawing.Size(109, 66);
            this.PopMovieBtn.TabIndex = 39;
            this.PopMovieBtn.Text = "Popular Movie";
            this.PopMovieBtn.UseVisualStyleBackColor = true;
            // 
            // PopularcustBtn
            // 
            this.PopularcustBtn.Location = new System.Drawing.Point(843, 13);
            this.PopularcustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PopularcustBtn.Name = "PopularcustBtn";
            this.PopularcustBtn.Size = new System.Drawing.Size(109, 66);
            this.PopularcustBtn.TabIndex = 40;
            this.PopularcustBtn.Text = "Popular Customer";
            this.PopularcustBtn.UseVisualStyleBackColor = true;
            // 
            // MainGrid
            // 
            this.MainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainGrid.Location = new System.Drawing.Point(13, 99);
            this.MainGrid.Margin = new System.Windows.Forms.Padding(4);
            this.MainGrid.Name = "MainGrid";
            this.MainGrid.RowHeadersWidth = 62;
            this.MainGrid.Size = new System.Drawing.Size(872, 361);
            this.MainGrid.TabIndex = 41;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(13, 499);
            this.AddCustomerButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(83, 66);
            this.AddCustomerButton.TabIndex = 42;
            this.AddCustomerButton.Text = "Add Customer";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(126, 499);
            this.UpdateBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(96, 66);
            this.UpdateBtn.TabIndex = 43;
            this.UpdateBtn.Text = "Update Customer";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DltBtn
            // 
            this.DltBtn.Location = new System.Drawing.Point(256, 499);
            this.DltBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DltBtn.Name = "DltBtn";
            this.DltBtn.Size = new System.Drawing.Size(83, 66);
            this.DltBtn.TabIndex = 44;
            this.DltBtn.Text = "Delete Customer";
            this.DltBtn.UseVisualStyleBackColor = true;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(13, 620);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(83, 66);
            this.AddMovieButton.TabIndex = 45;
            this.AddMovieButton.Text = "Add Movie";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            // 
            // UpdMovieButton
            // 
            this.UpdMovieButton.Location = new System.Drawing.Point(126, 620);
            this.UpdMovieButton.Margin = new System.Windows.Forms.Padding(4);
            this.UpdMovieButton.Name = "UpdMovieButton";
            this.UpdMovieButton.Size = new System.Drawing.Size(83, 66);
            this.UpdMovieButton.TabIndex = 46;
            this.UpdMovieButton.Text = "Update Movie";
            this.UpdMovieButton.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(256, 620);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(83, 66);
            this.DeleteBtn.TabIndex = 47;
            this.DeleteBtn.Text = "Delete Movie";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            // 
            // Custbtn
            // 
            this.Custbtn.Enabled = false;
            this.Custbtn.Location = new System.Drawing.Point(383, 521);
            this.Custbtn.Margin = new System.Windows.Forms.Padding(4);
            this.Custbtn.Name = "Custbtn";
            this.Custbtn.Size = new System.Drawing.Size(132, 22);
            this.Custbtn.TabIndex = 48;
            // 
            // FNBtn
            // 
            this.FNBtn.Enabled = false;
            this.FNBtn.Location = new System.Drawing.Point(535, 521);
            this.FNBtn.Margin = new System.Windows.Forms.Padding(4);
            this.FNBtn.Name = "FNBtn";
            this.FNBtn.Size = new System.Drawing.Size(132, 22);
            this.FNBtn.TabIndex = 49;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(680, 701);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 50;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(525, 701);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 51;
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(374, 701);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 52;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(843, 642);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 53;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(680, 642);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 54;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(525, 642);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 22);
            this.textBox7.TabIndex = 55;
            // 
            // MovIDBtn
            // 
            this.MovIDBtn.Enabled = false;
            this.MovIDBtn.Location = new System.Drawing.Point(374, 642);
            this.MovIDBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MovIDBtn.Name = "MovIDBtn";
            this.MovIDBtn.Size = new System.Drawing.Size(132, 22);
            this.MovIDBtn.TabIndex = 56;
            // 
            // PhBtn
            // 
            this.PhBtn.Enabled = false;
            this.PhBtn.Location = new System.Drawing.Point(690, 588);
            this.PhBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PhBtn.Name = "PhBtn";
            this.PhBtn.Size = new System.Drawing.Size(132, 22);
            this.PhBtn.TabIndex = 57;
            // 
            // AddressBtn
            // 
            this.AddressBtn.Enabled = false;
            this.AddressBtn.Location = new System.Drawing.Point(525, 588);
            this.AddressBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AddressBtn.Name = "AddressBtn";
            this.AddressBtn.Size = new System.Drawing.Size(132, 22);
            this.AddressBtn.TabIndex = 58;
            // 
            // LNBtn
            // 
            this.LNBtn.Enabled = false;
            this.LNBtn.Location = new System.Drawing.Point(374, 588);
            this.LNBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LNBtn.Name = "LNBtn";
            this.LNBtn.Size = new System.Drawing.Size(132, 22);
            this.LNBtn.TabIndex = 59;
            // 
            // CustIDLabel
            // 
            this.CustIDLabel.AutoSize = true;
            this.CustIDLabel.Location = new System.Drawing.Point(403, 499);
            this.CustIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustIDLabel.Name = "CustIDLabel";
            this.CustIDLabel.Size = new System.Drawing.Size(85, 17);
            this.CustIDLabel.TabIndex = 60;
            this.CustIDLabel.Text = "Customer ID";
            // 
            // FNLabel
            // 
            this.FNLabel.AutoSize = true;
            this.FNLabel.Location = new System.Drawing.Point(547, 499);
            this.FNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNLabel.Name = "FNLabel";
            this.FNLabel.Size = new System.Drawing.Size(76, 17);
            this.FNLabel.TabIndex = 61;
            this.FNLabel.Text = "First Name";
            // 
            // LNLabel
            // 
            this.LNLabel.AutoSize = true;
            this.LNLabel.Location = new System.Drawing.Point(403, 567);
            this.LNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNLabel.Name = "LNLabel";
            this.LNLabel.Size = new System.Drawing.Size(76, 17);
            this.LNLabel.TabIndex = 62;
            this.LNLabel.Text = "Last Name";
            // 
            // AdLabel
            // 
            this.AdLabel.AutoSize = true;
            this.AdLabel.Location = new System.Drawing.Point(547, 567);
            this.AdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AdLabel.Name = "AdLabel";
            this.AdLabel.Size = new System.Drawing.Size(60, 17);
            this.AdLabel.TabIndex = 63;
            this.AdLabel.Text = "Address";
            // 
            // PhLabel
            // 
            this.PhLabel.AutoSize = true;
            this.PhLabel.Location = new System.Drawing.Point(728, 567);
            this.PhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhLabel.Name = "PhLabel";
            this.PhLabel.Size = new System.Drawing.Size(49, 17);
            this.PhLabel.TabIndex = 64;
            this.PhLabel.Text = "Phone";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(843, 701);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(132, 22);
            this.textBox12.TabIndex = 65;
            // 
            // MovieIDLabel
            // 
            this.MovieIDLabel.AutoSize = true;
            this.MovieIDLabel.Location = new System.Drawing.Point(403, 621);
            this.MovieIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MovieIDLabel.Name = "MovieIDLabel";
            this.MovieIDLabel.Size = new System.Drawing.Size(62, 17);
            this.MovieIDLabel.TabIndex = 66;
            this.MovieIDLabel.Text = "Movie ID";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(558, 621);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 17);
            this.RatingLabel.TabIndex = 67;
            this.RatingLabel.Text = "Rating";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(715, 621);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(35, 17);
            this.TitleLabel.TabIndex = 68;
            this.TitleLabel.Text = "Title";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(871, 620);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(38, 17);
            this.YearLabel.TabIndex = 69;
            this.YearLabel.Text = "Year";
            // 
            // RCLabel
            // 
            this.RCLabel.AutoSize = true;
            this.RCLabel.Location = new System.Drawing.Point(394, 680);
            this.RCLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RCLabel.Name = "RCLabel";
            this.RCLabel.Size = new System.Drawing.Size(85, 17);
            this.RCLabel.TabIndex = 70;
            this.RCLabel.Text = "Rental_Cost";
            // 
            // CopiesLabel
            // 
            this.CopiesLabel.AutoSize = true;
            this.CopiesLabel.Location = new System.Drawing.Point(558, 680);
            this.CopiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CopiesLabel.Name = "CopiesLabel";
            this.CopiesLabel.Size = new System.Drawing.Size(51, 17);
            this.CopiesLabel.TabIndex = 71;
            this.CopiesLabel.Text = "Copies";
            // 
            // PlotLabel
            // 
            this.PlotLabel.AutoSize = true;
            this.PlotLabel.Location = new System.Drawing.Point(718, 680);
            this.PlotLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlotLabel.Name = "PlotLabel";
            this.PlotLabel.Size = new System.Drawing.Size(32, 17);
            this.PlotLabel.TabIndex = 72;
            this.PlotLabel.Text = "Plot";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(880, 680);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(48, 17);
            this.GenreLabel.TabIndex = 73;
            this.GenreLabel.Text = "Genre";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 736);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.PlotLabel);
            this.Controls.Add(this.CopiesLabel);
            this.Controls.Add(this.RCLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.MovieIDLabel);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.PhLabel);
            this.Controls.Add(this.AdLabel);
            this.Controls.Add(this.LNLabel);
            this.Controls.Add(this.FNLabel);
            this.Controls.Add(this.CustIDLabel);
            this.Controls.Add(this.LNBtn);
            this.Controls.Add(this.AddressBtn);
            this.Controls.Add(this.PhBtn);
            this.Controls.Add(this.MovIDBtn);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FNBtn);
            this.Controls.Add(this.Custbtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdMovieButton);
            this.Controls.Add(this.AddMovieButton);
            this.Controls.Add(this.DltBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.MainGrid);
            this.Controls.Add(this.PopularcustBtn);
            this.Controls.Add(this.PopMovieBtn);
            this.Controls.Add(this.RetMovieBtn);
            this.Controls.Add(this.IssueMovieBtn);
            this.Controls.Add(this.LoadRenMovie);
            this.Controls.Add(this.LoadMov);
            this.Controls.Add(this.LoadButton);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button LoadMov;
        private System.Windows.Forms.Button LoadRenMovie;
        private System.Windows.Forms.Button IssueMovieBtn;
        private System.Windows.Forms.Button RetMovieBtn;
        private System.Windows.Forms.Button PopMovieBtn;
        private System.Windows.Forms.Button PopularcustBtn;
        private System.Windows.Forms.DataGridView MainGrid;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DltBtn;
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button UpdMovieButton;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.TextBox Custbtn;
        private System.Windows.Forms.TextBox FNBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox MovIDBtn;
        private System.Windows.Forms.TextBox PhBtn;
        private System.Windows.Forms.TextBox AddressBtn;
        private System.Windows.Forms.TextBox LNBtn;
        private System.Windows.Forms.Label CustIDLabel;
        private System.Windows.Forms.Label FNLabel;
        private System.Windows.Forms.Label LNLabel;
        private System.Windows.Forms.Label AdLabel;
        private System.Windows.Forms.Label PhLabel;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label MovieIDLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label RCLabel;
        private System.Windows.Forms.Label CopiesLabel;
        private System.Windows.Forms.Label PlotLabel;
        private System.Windows.Forms.Label GenreLabel;
    }
}

