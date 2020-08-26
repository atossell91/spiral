namespace spiral
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nud_MaxThickness = new System.Windows.Forms.NumericUpDown();
            this.nud_MinThickness = new System.Windows.Forms.NumericUpDown();
            this.nud_VertSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nud_HorzSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_LineThickness = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_VertSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HorzSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LineThickness)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Make a Spiral";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.nud_LineThickness, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nud_MaxThickness, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.nud_MinThickness, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nud_VertSize, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.nud_HorzSize, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 210);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // nud_MaxThickness
            // 
            this.nud_MaxThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_MaxThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_MaxThickness.Location = new System.Drawing.Point(228, 143);
            this.nud_MaxThickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_MaxThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MaxThickness.Name = "nud_MaxThickness";
            this.nud_MaxThickness.Size = new System.Drawing.Size(220, 29);
            this.nud_MaxThickness.TabIndex = 9;
            this.nud_MaxThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_MaxThickness.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_MaxThickness.ValueChanged += new System.EventHandler(this.Nud_MaxThickness_ValueChanged);
            // 
            // nud_MinThickness
            // 
            this.nud_MinThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_MinThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_MinThickness.Location = new System.Drawing.Point(228, 108);
            this.nud_MinThickness.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_MinThickness.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MinThickness.Name = "nud_MinThickness";
            this.nud_MinThickness.Size = new System.Drawing.Size(220, 29);
            this.nud_MinThickness.TabIndex = 8;
            this.nud_MinThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_MinThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MinThickness.ValueChanged += new System.EventHandler(this.Nud_MinThickness_ValueChanged);
            // 
            // nud_VertSize
            // 
            this.nud_VertSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_VertSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_VertSize.Location = new System.Drawing.Point(228, 38);
            this.nud_VertSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_VertSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_VertSize.Name = "nud_VertSize";
            this.nud_VertSize.Size = new System.Drawing.Size(220, 29);
            this.nud_VertSize.TabIndex = 7;
            this.nud_VertSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_VertSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_VertSize.ValueChanged += new System.EventHandler(this.Nud_VertSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horizontal Size:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vertical Size:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum thickness:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maximum thickness:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Color:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(228, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 29);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // nud_HorzSize
            // 
            this.nud_HorzSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_HorzSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_HorzSize.Location = new System.Drawing.Point(228, 3);
            this.nud_HorzSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_HorzSize.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nud_HorzSize.Name = "nud_HorzSize";
            this.nud_HorzSize.Size = new System.Drawing.Size(220, 29);
            this.nud_HorzSize.TabIndex = 6;
            this.nud_HorzSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_HorzSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_HorzSize.ValueChanged += new System.EventHandler(this.Nud_HorzSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Line thickness:";
            // 
            // nud_LineThickness
            // 
            this.nud_LineThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_LineThickness.DecimalPlaces = 3;
            this.nud_LineThickness.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_LineThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_LineThickness.Location = new System.Drawing.Point(228, 73);
            this.nud_LineThickness.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_LineThickness.Name = "nud_LineThickness";
            this.nud_LineThickness.Size = new System.Drawing.Size(220, 29);
            this.nud_LineThickness.TabIndex = 11;
            this.nud_LineThickness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_LineThickness.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_LineThickness.ValueChanged += new System.EventHandler(this.Nud_LineThickness_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 285);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_VertSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_HorzSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LineThickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nud_MaxThickness;
        private System.Windows.Forms.NumericUpDown nud_MinThickness;
        private System.Windows.Forms.NumericUpDown nud_VertSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nud_HorzSize;
        private System.Windows.Forms.NumericUpDown nud_LineThickness;
        private System.Windows.Forms.Label label6;
    }
}

