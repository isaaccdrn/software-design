namespace Task4
{
    partial class Task4Form
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
            panel2 = new Panel();
            btnSort = new Button();
            listBoxResults = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSort);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 450);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(listBoxResults);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(583, 450);
            panel2.TabIndex = 1;
            // 
            // btnSort
            // 
            btnSort.Dock = DockStyle.Top;
            btnSort.Location = new Point(0, 0);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(217, 46);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += this.btnSort_Click;
            // 
            // listBoxResults
            // 
            listBoxResults.Dock = DockStyle.Fill;
            listBoxResults.FormattingEnabled = true;
            listBoxResults.Location = new Point(0, 0);
            listBoxResults.Name = "listBoxResults";
            listBoxResults.Size = new Size(583, 450);
            listBoxResults.TabIndex = 0;
            // 
            // Task4Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Task4Form";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnSort;
        private ListBox listBoxResults;
    }
}
