namespace _2_Task3
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
            panel1 = new Panel();
            label1 = new Label();
            fibResTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnCalcFib = new MaterialSkin.Controls.MaterialButton();
            fibTextBox = new MaterialSkin.Controls.MaterialTextBox();
            panel2 = new Panel();
            label2 = new Label();
            powResTextBox = new MaterialSkin.Controls.MaterialTextBox();
            baseTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            btnCalcPow = new MaterialSkin.Controls.MaterialButton();
            expTextBox = new MaterialSkin.Controls.MaterialTextBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(fibResTextBox);
            panel1.Controls.Add(materialLabel1);
            panel1.Controls.Add(btnCalcFib);
            panel1.Controls.Add(fibTextBox);
            panel1.Location = new Point(6, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 377);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 15);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 5;
            label1.Text = "Fibonacci";
            // 
            // fibResTextBox
            // 
            fibResTextBox.AnimateReadOnly = false;
            fibResTextBox.BorderStyle = BorderStyle.None;
            fibResTextBox.Depth = 0;
            fibResTextBox.Enabled = false;
            fibResTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fibResTextBox.LeadingIcon = null;
            fibResTextBox.Location = new Point(102, 239);
            fibResTextBox.MaxLength = 50;
            fibResTextBox.MouseState = MaterialSkin.MouseState.OUT;
            fibResTextBox.Multiline = false;
            fibResTextBox.Name = "fibResTextBox";
            fibResTextBox.ReadOnly = true;
            fibResTextBox.Size = new Size(156, 50);
            fibResTextBox.TabIndex = 4;
            fibResTextBox.Text = "";
            fibResTextBox.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(102, 217);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(45, 19);
            materialLabel1.TabIndex = 3;
            materialLabel1.Text = "Result";
            // 
            // btnCalcFib
            // 
            btnCalcFib.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalcFib.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCalcFib.Depth = 0;
            btnCalcFib.Enabled = false;
            btnCalcFib.HighEmphasis = true;
            btnCalcFib.Icon = null;
            btnCalcFib.Location = new Point(124, 145);
            btnCalcFib.Margin = new Padding(4, 6, 4, 6);
            btnCalcFib.MouseState = MaterialSkin.MouseState.HOVER;
            btnCalcFib.Name = "btnCalcFib";
            btnCalcFib.NoAccentTextColor = Color.Empty;
            btnCalcFib.Size = new Size(103, 36);
            btnCalcFib.TabIndex = 2;
            btnCalcFib.Text = "Calculate";
            btnCalcFib.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCalcFib.UseAccentColor = false;
            btnCalcFib.UseVisualStyleBackColor = true;
            btnCalcFib.Click += btnCalcFib_Click;
            // 
            // fibTextBox
            // 
            fibTextBox.AnimateReadOnly = false;
            fibTextBox.BorderStyle = BorderStyle.None;
            fibTextBox.Depth = 0;
            fibTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fibTextBox.LeadingIcon = null;
            fibTextBox.Location = new Point(102, 74);
            fibTextBox.MaxLength = 50;
            fibTextBox.MouseState = MaterialSkin.MouseState.OUT;
            fibTextBox.Multiline = false;
            fibTextBox.Name = "fibTextBox";
            fibTextBox.Size = new Size(156, 50);
            fibTextBox.TabIndex = 1;
            fibTextBox.Text = "";
            fibTextBox.TrailingIcon = null;
            fibTextBox.TextChanged += fibTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(materialLabel4);
            panel2.Controls.Add(materialLabel3);
            panel2.Controls.Add(expTextBox);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(powResTextBox);
            panel2.Controls.Add(baseTextBox);
            panel2.Controls.Add(materialLabel2);
            panel2.Controls.Add(btnCalcPow);
            panel2.Location = new Point(399, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(395, 377);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 15);
            label2.Name = "label2";
            label2.Size = new Size(223, 41);
            label2.TabIndex = 6;
            label2.Text = "Power Function";
            // 
            // powResTextBox
            // 
            powResTextBox.AnimateReadOnly = false;
            powResTextBox.BorderStyle = BorderStyle.None;
            powResTextBox.Depth = 0;
            powResTextBox.Enabled = false;
            powResTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            powResTextBox.LeadingIcon = null;
            powResTextBox.Location = new Point(120, 293);
            powResTextBox.MaxLength = 50;
            powResTextBox.MouseState = MaterialSkin.MouseState.OUT;
            powResTextBox.Multiline = false;
            powResTextBox.Name = "powResTextBox";
            powResTextBox.ReadOnly = true;
            powResTextBox.Size = new Size(156, 50);
            powResTextBox.TabIndex = 8;
            powResTextBox.Text = "";
            powResTextBox.TrailingIcon = null;
            // 
            // baseTextBox
            // 
            baseTextBox.AnimateReadOnly = false;
            baseTextBox.BorderStyle = BorderStyle.None;
            baseTextBox.Depth = 0;
            baseTextBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            baseTextBox.LeadingIcon = null;
            baseTextBox.Location = new Point(120, 73);
            baseTextBox.MaxLength = 50;
            baseTextBox.MouseState = MaterialSkin.MouseState.OUT;
            baseTextBox.Multiline = false;
            baseTextBox.Name = "baseTextBox";
            baseTextBox.Size = new Size(156, 50);
            baseTextBox.TabIndex = 5;
            baseTextBox.Text = "";
            baseTextBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(120, 271);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(45, 19);
            materialLabel2.TabIndex = 7;
            materialLabel2.Text = "Result";
            // 
            // btnCalcPow
            // 
            btnCalcPow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCalcPow.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCalcPow.Depth = 0;
            btnCalcPow.Enabled = false;
            btnCalcPow.HighEmphasis = true;
            btnCalcPow.Icon = null;
            btnCalcPow.Location = new Point(145, 200);
            btnCalcPow.Margin = new Padding(4, 6, 4, 6);
            btnCalcPow.MouseState = MaterialSkin.MouseState.HOVER;
            btnCalcPow.Name = "btnCalcPow";
            btnCalcPow.NoAccentTextColor = Color.Empty;
            btnCalcPow.Size = new Size(103, 36);
            btnCalcPow.TabIndex = 6;
            btnCalcPow.Text = "Calculate";
            btnCalcPow.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCalcPow.UseAccentColor = false;
            btnCalcPow.UseVisualStyleBackColor = true;
            btnCalcPow.Click += btnCalcPow_Click;
            // 
            // expTextBox
            // 
            expTextBox.AnimateReadOnly = false;
            expTextBox.BorderStyle = BorderStyle.None;
            expTextBox.Depth = 0;
            expTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            expTextBox.LeadingIcon = null;
            expTextBox.Location = new Point(120, 131);
            expTextBox.MaxLength = 50;
            expTextBox.MouseState = MaterialSkin.MouseState.OUT;
            expTextBox.Multiline = false;
            expTextBox.Name = "expTextBox";
            expTextBox.Size = new Size(156, 50);
            expTextBox.TabIndex = 9;
            expTextBox.Text = "";
            expTextBox.TrailingIcon = null;
            expTextBox.TextChanged += expTextBox_TextChanged;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(55, 87);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(40, 19);
            materialLabel3.TabIndex = 10;
            materialLabel3.Text = "Base:";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(24, 145);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(71, 19);
            materialLabel4.TabIndex = 11;
            materialLabel4.Text = "Exponent:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Fibonacci + Power Calculation";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnCalcFib;
        private MaterialSkin.Controls.MaterialTextBox fibTextBox;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox fibResTextBox;
        private MaterialSkin.Controls.MaterialTextBox powResTextBox;
        private MaterialSkin.Controls.MaterialTextBox baseTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btnCalcPow;
        private Label label1;
        private Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox expTextBox;
    }
}
