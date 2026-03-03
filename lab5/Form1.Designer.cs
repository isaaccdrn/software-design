namespace lab5
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
            btnAddBook = new MaterialSkin.Controls.MaterialButton();
            listBoxBooks = new MaterialSkin.Controls.MaterialListBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtBookTitle = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtAuthorName = new MaterialSkin.Controls.MaterialTextBox();
            btnShowBooks = new MaterialSkin.Controls.MaterialButton();
            btnUpdateBook = new MaterialSkin.Controls.MaterialButton();
            txtBookID = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            btnDeleteBook = new MaterialSkin.Controls.MaterialButton();
            txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddBook.Depth = 0;
            btnAddBook.HighEmphasis = true;
            btnAddBook.Icon = null;
            btnAddBook.Location = new Point(7, 239);
            btnAddBook.Margin = new Padding(4, 6, 4, 6);
            btnAddBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddBook.Name = "btnAddBook";
            btnAddBook.NoAccentTextColor = Color.Empty;
            btnAddBook.Size = new Size(93, 36);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add Book";
            btnAddBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddBook.UseAccentColor = false;
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.BackColor = Color.White;
            listBoxBooks.BorderColor = Color.LightGray;
            listBoxBooks.Depth = 0;
            listBoxBooks.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxBooks.Location = new Point(288, 67);
            listBoxBooks.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.SelectedIndex = -1;
            listBoxBooks.SelectedItem = null;
            listBoxBooks.Size = new Size(506, 377);
            listBoxBooks.TabIndex = 2;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(150, 158);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(32, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Title";
            // 
            // txtBookTitle
            // 
            txtBookTitle.AnimateReadOnly = false;
            txtBookTitle.BorderStyle = BorderStyle.None;
            txtBookTitle.Depth = 0;
            txtBookTitle.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBookTitle.LeadingIcon = null;
            txtBookTitle.Location = new Point(150, 180);
            txtBookTitle.MaxLength = 50;
            txtBookTitle.MouseState = MaterialSkin.MouseState.OUT;
            txtBookTitle.Multiline = false;
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(131, 50);
            txtBookTitle.TabIndex = 5;
            txtBookTitle.Text = "";
            txtBookTitle.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(7, 158);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(48, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Author";
            // 
            // txtAuthorName
            // 
            txtAuthorName.AnimateReadOnly = false;
            txtAuthorName.BorderStyle = BorderStyle.None;
            txtAuthorName.Depth = 0;
            txtAuthorName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAuthorName.LeadingIcon = null;
            txtAuthorName.Location = new Point(7, 180);
            txtAuthorName.MaxLength = 50;
            txtAuthorName.MouseState = MaterialSkin.MouseState.OUT;
            txtAuthorName.Multiline = false;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(137, 50);
            txtAuthorName.TabIndex = 7;
            txtAuthorName.Text = "";
            txtAuthorName.TrailingIcon = null;
            // 
            // btnShowBooks
            // 
            btnShowBooks.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowBooks.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnShowBooks.Depth = 0;
            btnShowBooks.HighEmphasis = true;
            btnShowBooks.Icon = null;
            btnShowBooks.Location = new Point(108, 239);
            btnShowBooks.Margin = new Padding(4, 6, 4, 6);
            btnShowBooks.MouseState = MaterialSkin.MouseState.HOVER;
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.NoAccentTextColor = Color.Empty;
            btnShowBooks.Size = new Size(115, 36);
            btnShowBooks.TabIndex = 9;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShowBooks.UseAccentColor = false;
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnUpdateBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnUpdateBook.Depth = 0;
            btnUpdateBook.HighEmphasis = true;
            btnUpdateBook.Icon = null;
            btnUpdateBook.Location = new Point(6, 375);
            btnUpdateBook.Margin = new Padding(4, 6, 4, 6);
            btnUpdateBook.MouseState = MaterialSkin.MouseState.HOVER;
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.NoAccentTextColor = Color.Empty;
            btnUpdateBook.Size = new Size(120, 36);
            btnUpdateBook.TabIndex = 10;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnUpdateBook.UseAccentColor = false;
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // txtBookID
            // 
            txtBookID.AnimateReadOnly = false;
            txtBookID.BorderStyle = BorderStyle.None;
            txtBookID.Depth = 0;
            txtBookID.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBookID.LeadingIcon = null;
            txtBookID.Location = new Point(7, 316);
            txtBookID.MaxLength = 50;
            txtBookID.MouseState = MaterialSkin.MouseState.OUT;
            txtBookID.Multiline = false;
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(137, 50);
            txtBookID.TabIndex = 11;
            txtBookID.Text = "";
            txtBookID.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(6, 294);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(56, 19);
            materialLabel3.TabIndex = 12;
            materialLabel3.Text = "Book ID";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDeleteBook.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDeleteBook.Depth = 0;
            btnDeleteBook.HighEmphasis = true;
            btnDeleteBook.Icon = null;
            btnDeleteBook.Location = new Point(134, 375);
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
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.LeadingIcon = null;
            txtSearch.Location = new Point(7, 95);
            txtSearch.MaxLength = 50;
            txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            txtSearch.Multiline = false;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(189, 50);
            txtSearch.TabIndex = 14;
            txtSearch.Text = "";
            txtSearch.TrailingIcon = null;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(7, 73);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(122, 19);
            materialLabel4.TabIndex = 15;
            materialLabel4.Text = "Search by Author";
            // 
            // btnSearch
            // 
            btnSearch.AutoSize = false;
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(203, 95);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(78, 50);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSearch);
            Controls.Add(materialLabel4);
            Controls.Add(txtSearch);
            Controls.Add(btnDeleteBook);
            Controls.Add(materialLabel3);
            Controls.Add(txtBookID);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnShowBooks);
            Controls.Add(materialLabel2);
            Controls.Add(txtAuthorName);
            Controls.Add(materialLabel1);
            Controls.Add(txtBookTitle);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Name = "Form1";
            Text = "Bookstore";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnAddBook;
        private MaterialSkin.Controls.MaterialListBox listBoxBooks;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBookTitle;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtAuthorName;
        private MaterialSkin.Controls.MaterialButton btnShowBooks;
        private MaterialSkin.Controls.MaterialButton btnUpdateBook;
        private MaterialSkin.Controls.MaterialTextBox txtBookID;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btnDeleteBook;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialButton btnSearch;
    }
}
