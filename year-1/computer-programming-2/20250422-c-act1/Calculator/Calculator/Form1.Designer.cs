namespace Calculator
{
    partial class CalculatorApp
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
            this.btnContainer = new System.Windows.Forms.TableLayoutPanel();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.subractBtn = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPeriod = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.btnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContainer
            // 
            this.btnContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnContainer.ColumnCount = 4;
            this.btnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.btnContainer.Controls.Add(this.multiplyBtn, 3, 2);
            this.btnContainer.Controls.Add(this.divideBtn, 3, 1);
            this.btnContainer.Controls.Add(this.num9, 2, 1);
            this.btnContainer.Controls.Add(this.num8, 1, 1);
            this.btnContainer.Controls.Add(this.num7, 0, 1);
            this.btnContainer.Controls.Add(this.num5, 1, 2);
            this.btnContainer.Controls.Add(this.num6, 2, 2);
            this.btnContainer.Controls.Add(this.num1, 0, 3);
            this.btnContainer.Controls.Add(this.num2, 1, 3);
            this.btnContainer.Controls.Add(this.num3, 2, 3);
            this.btnContainer.Controls.Add(this.num0, 0, 4);
            this.btnContainer.Controls.Add(this.subractBtn, 3, 3);
            this.btnContainer.Controls.Add(this.num4, 0, 2);
            this.btnContainer.Controls.Add(this.btnClear, 3, 0);
            this.btnContainer.Controls.Add(this.btnPeriod, 1, 4);
            this.btnContainer.Controls.Add(this.addBtn, 2, 4);
            this.btnContainer.Controls.Add(this.btnEqual, 3, 4);
            this.btnContainer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContainer.Location = new System.Drawing.Point(15, 146);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.RowCount = 5;
            this.btnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnContainer.Size = new System.Drawing.Size(390, 303);
            this.btnContainer.TabIndex = 0;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplyBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.multiplyBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.multiplyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.multiplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.Location = new System.Drawing.Point(294, 123);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(93, 54);
            this.multiplyBtn.TabIndex = 11;
            this.multiplyBtn.Text = "×";
            this.multiplyBtn.UseVisualStyleBackColor = false;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.divideBtn.AutoSize = true;
            this.divideBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.divideBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.divideBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.divideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.divideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(294, 63);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(93, 54);
            this.divideBtn.TabIndex = 10;
            this.divideBtn.Text = "÷";
            this.divideBtn.UseVisualStyleBackColor = false;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // num9
            // 
            this.num9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(197, 63);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(91, 54);
            this.num9.TabIndex = 2;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num8
            // 
            this.num8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(100, 63);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(91, 54);
            this.num8.TabIndex = 1;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num7
            // 
            this.num7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(3, 63);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(91, 54);
            this.num7.TabIndex = 0;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num5
            // 
            this.num5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(100, 123);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(91, 54);
            this.num5.TabIndex = 4;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(197, 123);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(91, 54);
            this.num6.TabIndex = 5;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(3, 183);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(91, 54);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(100, 183);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(91, 54);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(197, 183);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(91, 54);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num0
            // 
            this.num0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num0.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(3, 243);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(91, 57);
            this.num0.TabIndex = 9;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // subractBtn
            // 
            this.subractBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subractBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subractBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.subractBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.subractBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.subractBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subractBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subractBtn.Location = new System.Drawing.Point(294, 183);
            this.subractBtn.Name = "subractBtn";
            this.subractBtn.Size = new System.Drawing.Size(93, 54);
            this.subractBtn.TabIndex = 12;
            this.subractBtn.Text = "–";
            this.subractBtn.UseVisualStyleBackColor = false;
            this.subractBtn.Click += new System.EventHandler(this.subractBtn_Click);
            // 
            // num4
            // 
            this.num4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.num4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.num4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.num4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.num4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(3, 123);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(91, 54);
            this.num4.TabIndex = 3;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(294, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 54);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPeriod
            // 
            this.btnPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPeriod.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPeriod.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPeriod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPeriod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeriod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeriod.Location = new System.Drawing.Point(100, 243);
            this.btnPeriod.Name = "btnPeriod";
            this.btnPeriod.Size = new System.Drawing.Size(91, 57);
            this.btnPeriod.TabIndex = 14;
            this.btnPeriod.Text = ".";
            this.btnPeriod.UseVisualStyleBackColor = false;
            this.btnPeriod.Click += new System.EventHandler(this.btnPeriod_Click);
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(197, 243);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(91, 57);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEqual.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEqual.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btnEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnEqual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(294, 243);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(93, 57);
            this.btnEqual.TabIndex = 16;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtBox
            // 
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(18, 49);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.ReadOnly = true;
            this.txtBox.Size = new System.Drawing.Size(384, 91);
            this.txtBox.TabIndex = 1;
            this.txtBox.Text = "0";
            this.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lblBasic.Location = new System.Drawing.Point(12, 9);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(79, 37);
            this.lblBasic.TabIndex = 2;
            this.lblBasic.Text = "Basic";
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(420, 462);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.btnContainer);
            this.Name = "CalculatorApp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnContainer.ResumeLayout(false);
            this.btnContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel btnContainer;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button subractBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnPeriod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label lblBasic;
    }
}

