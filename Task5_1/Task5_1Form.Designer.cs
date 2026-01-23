namespace Task5_1
{
    partial class Task5_1Form
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
            panel1 = new Panel();
            btnSort = new MaterialSkin.Controls.MaterialButton();
            btnGenerate = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            listBoxResults = new MaterialSkin.Controls.MaterialListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSort);
            panel1.Controls.Add(btnGenerate);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(217, 383);
            panel1.TabIndex = 0;
            // 
            // btnSort
            // 
            btnSort.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSort.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSort.Depth = 0;
            btnSort.Dock = DockStyle.Top;
            btnSort.HighEmphasis = true;
            btnSort.Icon = null;
            btnSort.Location = new Point(0, 46);
            btnSort.Margin = new Padding(4, 6, 4, 6);
            btnSort.MouseState = MaterialSkin.MouseState.HOVER;
            btnSort.Name = "btnSort";
            btnSort.NoAccentTextColor = Color.Empty;
            btnSort.Size = new Size(217, 36);
            btnSort.TabIndex = 1;
            btnSort.Text = "Sort";
            btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSort.UseAccentColor = false;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnGenerate
            // 
            btnGenerate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGenerate.Depth = 0;
            btnGenerate.Dock = DockStyle.Top;
            btnGenerate.HighEmphasis = true;
            btnGenerate.Icon = null;
            btnGenerate.Location = new Point(0, 10);
            btnGenerate.Margin = new Padding(4, 6, 4, 6);
            btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            btnGenerate.Name = "btnGenerate";
            btnGenerate.NoAccentTextColor = Color.Empty;
            btnGenerate.Size = new Size(217, 36);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGenerate.UseAccentColor = false;
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxResults);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(220, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(577, 383);
            panel2.TabIndex = 1;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.White;
            listBoxResults.BorderColor = Color.LightGray;
            listBoxResults.Depth = 0;
            listBoxResults.Dock = DockStyle.Fill;
            listBoxResults.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxResults.Location = new Point(0, 0);
            listBoxResults.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxResults.Name = "listBoxResults";
            listBoxResults.SelectedIndex = -1;
            listBoxResults.SelectedItem = null;
            listBoxResults.Size = new Size(577, 383);
            listBoxResults.TabIndex = 0;
            // 
            // Task5_1Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Task5_1Form";
            Text = "Bubble Sort (Procedural)";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnSort;
        private MaterialSkin.Controls.MaterialButton btnGenerate;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialListBox listBoxResults;
    }
}
