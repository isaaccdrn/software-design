namespace lab6
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxBooks = new MaterialSkin.Controls.MaterialListBox();
            btnFetchBooks = new MaterialSkin.Controls.MaterialButton();
            txtAuthorName = new MaterialSkin.Controls.MaterialTextBox();
            txtBookTitle = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnAddBook = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            txtBookId = new MaterialSkin.Controls.MaterialTextBox();
            btnUpdateBook = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            progressBar = new MaterialSkin.Controls.MaterialProgressBar();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = Color.White;
            listBoxBooks.BorderColor = Color.LightGray;
            listBoxBooks.Depth = 0;
            listBoxBooks.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxBooks.Location = new Point(284, 67);
            listBoxBooks.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.SelectedIndex = -1;
            listBoxBooks.SelectedItem = null;
            listBoxBooks.Size = new Size(510, 377);
            listBoxBooks.TabIndex = 0;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFetchBooks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFetchBooks.Depth = 0;
            btnFetchBooks.HighEmphasis = true;
            btnFetchBooks.Icon = null;
            btnFetchBooks.Location = new Point(107, 248);
            btnFetchBooks.Margin = new Padding(4, 6, 4, 6);
            btnFetchBooks.MouseState = MaterialSkin.MouseState.HOVER;
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.NoAccentTextColor = Color.Empty;
            btnFetchBooks.Size = new Size(118, 36);
            btnFetchBooks.TabIndex = 1;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFetchBooks.UseAccentColor = false;
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // txtAuthorName
            // 
            txtAuthorName.AnimateReadOnly = false;
            txtAuthorName.BorderStyle = BorderStyle.None;
            txtAuthorName.Depth = 0;
            txtAuthorName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAuthorName.LeadingIcon = null;
            txtAuthorName.Location = new Point(6, 189);
            txtAuthorName.MaxLength = 50;
            txtAuthorName.MouseState = MaterialSkin.MouseState.OUT;
            txtAuthorName.Multiline = false;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(125, 50);
            txtAuthorName.TabIndex = 2;
            txtAuthorName.Text = "";
            txtAuthorName.TrailingIcon = null;
            // 
            // txtBookTitle
            // 
            txtBookTitle.AnimateReadOnly = false;
            txtBookTitle.BorderStyle = BorderStyle.None;
            txtBookTitle.Depth = 0;
            txtBookTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBookTitle.LeadingIcon = null;
            txtBookTitle.Location = new Point(137, 189);
            txtBookTitle.MaxLength = 50;
            txtBookTitle.MouseState = MaterialSkin.MouseState.OUT;
            txtBookTitle.Multiline = false;
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(125, 50);
            txtBookTitle.TabIndex = 3;
            txtBookTitle.Text = "";
            txtBookTitle.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(6, 167);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(48, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Author";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(137, 167);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(32, 19);
            materialLabel2.TabIndex = 5;
            materialLabel2.Text = "Title";
            // 
            // btnAddBook
            // 
            btnAddBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddBook.Depth = 0;
            btnAddBook.HighEmphasis = true;
            btnAddBook.Icon = null;
            btnAddBook.Location = new Point(6, 248);
            btnAddBook.Margin = new Padding(4, 6, 4, 6);
            btnAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddBook.Name = "btnAddBook";
            btnAddBook.NoAccentTextColor = Color.Empty;
            btnAddBook.Size = new Size(93, 36);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Add Book";
            btnAddBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddBook.UseAccentColor = false;
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(6, 299);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(56, 19);
            materialLabel3.TabIndex = 8;
            materialLabel3.Text = "Book ID";
            // 
            // txtBookId
            // 
            txtBookId.AnimateReadOnly = false;
            txtBookId.BorderStyle = BorderStyle.None;
            txtBookId.Depth = 0;
            txtBookId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBookId.LeadingIcon = null;
            txtBookId.Location = new Point(6, 321);
            txtBookId.MaxLength = 50;
            txtBookId.MouseState = MaterialSkin.MouseState.OUT;
            txtBookId.Multiline = false;
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(125, 50);
            txtBookId.TabIndex = 7;
            txtBookId.Text = "";
            txtBookId.TrailingIcon = null;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateBook.Depth = 0;
            btnUpdateBook.HighEmphasis = true;
            btnUpdateBook.Icon = null;
            btnUpdateBook.Location = new Point(6, 380);
            btnUpdateBook.Margin = new Padding(4, 6, 4, 6);
            btnUpdateBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.NoAccentTextColor = Color.Empty;
            btnUpdateBook.Size = new Size(120, 36);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateBook.UseAccentColor = false;
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(6, 102);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(183, 50);
            txtSearch.TabIndex = 10;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(196, 102);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(81, 50);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(6, 80);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(106, 19);
            materialLabel4.TabIndex = 12;
            materialLabel4.Text = "Search by Title";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteBook.Depth = 0;
            btnDeleteBook.HighEmphasis = true;
            btnDeleteBook.Icon = null;
            btnDeleteBook.Location = new Point(134, 380);
            btnDeleteBook.Margin = new Padding(4, 6, 4, 6);
            btnDeleteBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.NoAccentTextColor = Color.Empty;
            btnDeleteBook.Size = new Size(116, 36);
            btnDeleteBook.TabIndex = 13;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDeleteBook.UseAccentColor = false;
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // progressBar
            // 
            progressBar.Depth = 0;
            progressBar.Location = new Point(6, 425);
            progressBar.MouseState = MaterialSkin.MouseState.HOVER;
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(271, 5);
            progressBar.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(btnDeleteBook);
            Controls.Add(materialLabel4);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdateBook);
            Controls.Add(materialLabel3);
            Controls.Add(txtBookId);
            Controls.Add(btnAddBook);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(txtBookTitle);
            Controls.Add(txtAuthorName);
            Controls.Add(btnFetchBooks);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Bookstore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox listBoxBooks;
        private MaterialSkin.Controls.MaterialButton btnFetchBooks;
        private MaterialSkin.Controls.MaterialTextBox txtAuthorName;
        private MaterialSkin.Controls.MaterialTextBox txtBookTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnAddBook;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtBookId;
        private MaterialSkin.Controls.MaterialButton btnUpdateBook;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnDeleteBook;
        private MaterialSkin.Controls.MaterialProgressBar progressBar;
    }
}
