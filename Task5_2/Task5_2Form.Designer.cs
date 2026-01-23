namespace Task5_2
{
    partial class Task5_2Form
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
            btnGen = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            listBoxResults = new MaterialSkin.Controls.MaterialListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSort);
            panel1.Controls.Add(btnGen);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 64);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(0, 10, 0, 0);
            panel1.Size = new Size(177, 383);
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
            btnSort.Size = new Size(177, 36);
            btnSort.TabIndex = 3;
            btnSort.Text = "Sort";
            btnSort.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSort.UseAccentColor = false;
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnGen
            // 
            btnGen.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnGen.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnGen.Depth = 0;
            btnGen.Dock = DockStyle.Top;
            btnGen.HighEmphasis = true;
            btnGen.Icon = null;
            btnGen.Location = new Point(0, 10);
            btnGen.Margin = new Padding(4, 6, 4, 6);
            btnGen.MouseState = MaterialSkin.MouseState.HOVER;
            btnGen.Name = "btnGen";
            btnGen.NoAccentTextColor = Color.Empty;
            btnGen.Size = new Size(177, 36);
            btnGen.TabIndex = 2;
            btnGen.Text = "Generate";
            btnGen.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnGen.UseAccentColor = false;
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxResults);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(180, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(617, 383);
            panel2.TabIndex = 1;
            // 
            // listBoxResults
            // 
            listBoxResults.BackColor = Color.White;
            listBoxResults.BorderColor = Color.LightGray;
            listBoxResults.Depth = 0;
            listBoxResults.Dock = DockStyle.Fill;
            listBoxResults.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            listBoxResults.Location = new Point(0, 0);
            listBoxResults.MouseState = MaterialSkin.MouseState.HOVER;
            listBoxResults.Name = "listBoxResults";
            listBoxResults.SelectedIndex = -1;
            listBoxResults.SelectedItem = null;
            listBoxResults.Size = new Size(617, 383);
            listBoxResults.TabIndex = 0;
            // 
            // Task5_2Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Task5_2Form";
            Text = "Descending Sort Using OOP";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialButton btnSort;
        private MaterialSkin.Controls.MaterialButton btnGen;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialListBox listBoxResults;
    }
}
