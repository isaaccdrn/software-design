namespace lab3
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
            booksLBox = new MaterialSkin.Controls.MaterialListBox();
            btnShowInfo = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // booksLBox
            // 
            booksLBox.BackColor = Color.White;
            booksLBox.BorderColor = Color.LightGray;
            booksLBox.Depth = 0;
            booksLBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            booksLBox.Location = new Point(265, 67);
            booksLBox.MouseState = MaterialSkin.MouseState.HOVER;
            booksLBox.Name = "booksLBox";
            booksLBox.SelectedIndex = -1;
            booksLBox.SelectedItem = null;
            booksLBox.Size = new Size(529, 377);
            booksLBox.TabIndex = 0;
            // 
            // btnShowInfo
            // 
            btnShowInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnShowInfo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnShowInfo.Depth = 0;
            btnShowInfo.HighEmphasis = true;
            btnShowInfo.Icon = null;
            btnShowInfo.Location = new Point(61, 168);
            btnShowInfo.Margin = new Padding(4, 6, 4, 6);
            btnShowInfo.MouseState = MaterialSkin.MouseState.HOVER;
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.NoAccentTextColor = Color.Empty;
            btnShowInfo.Size = new Size(158, 36);
            btnShowInfo.TabIndex = 1;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnShowInfo.UseAccentColor = false;
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowInfo);
            Controls.Add(booksLBox);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookstore System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox booksLBox;
        private MaterialSkin.Controls.MaterialButton btnShowInfo;
    }
}
