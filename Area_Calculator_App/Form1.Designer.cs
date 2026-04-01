namespace Area_Calculator_App
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.rdbCircle = new System.Windows.Forms.RadioButton();
            this.rdbTriangle = new System.Windows.Forms.RadioButton();
            this.rdbRectangle = new System.Windows.Forms.RadioButton();
            this.rdbSquare = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtSideLength = new System.Windows.Forms.TextBox();
            this.cmbRadius = new System.Windows.Forms.ComboBox();
            this.cmbBase = new System.Windows.Forms.ComboBox();
            this.cmbHeight = new System.Windows.Forms.ComboBox();
            this.cmbLength = new System.Windows.Forms.ComboBox();
            this.cmbWidth = new System.Windows.Forms.ComboBox();
            this.cmbSideLength = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.BackgroundImage = global::Area_Calculator_App.Properties.Resources.Area_pic;
            this.listView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(473, 488);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // rdbCircle
            // 
            this.rdbCircle.AutoSize = true;
            this.rdbCircle.BackColor = System.Drawing.SystemColors.GrayText;
            this.rdbCircle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCircle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbCircle.Location = new System.Drawing.Point(36, 91);
            this.rdbCircle.Name = "rdbCircle";
            this.rdbCircle.Size = new System.Drawing.Size(73, 26);
            this.rdbCircle.TabIndex = 2;
            this.rdbCircle.TabStop = true;
            this.rdbCircle.Text = "Circle";
            this.rdbCircle.UseVisualStyleBackColor = false;
            // 
            // rdbTriangle
            // 
            this.rdbTriangle.AutoSize = true;
            this.rdbTriangle.BackColor = System.Drawing.SystemColors.GrayText;
            this.rdbTriangle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbTriangle.Location = new System.Drawing.Point(36, 150);
            this.rdbTriangle.Name = "rdbTriangle";
            this.rdbTriangle.Size = new System.Drawing.Size(94, 26);
            this.rdbTriangle.TabIndex = 3;
            this.rdbTriangle.TabStop = true;
            this.rdbTriangle.Text = "Triangle";
            this.rdbTriangle.UseVisualStyleBackColor = false;
            // 
            // rdbRectangle
            // 
            this.rdbRectangle.AutoSize = true;
            this.rdbRectangle.BackColor = System.Drawing.SystemColors.GrayText;
            this.rdbRectangle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRectangle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbRectangle.Location = new System.Drawing.Point(36, 239);
            this.rdbRectangle.Name = "rdbRectangle";
            this.rdbRectangle.Size = new System.Drawing.Size(107, 26);
            this.rdbRectangle.TabIndex = 4;
            this.rdbRectangle.TabStop = true;
            this.rdbRectangle.Text = "Rectangle";
            this.rdbRectangle.UseVisualStyleBackColor = false;
            // 
            // rdbSquare
            // 
            this.rdbSquare.AutoSize = true;
            this.rdbSquare.BackColor = System.Drawing.SystemColors.GrayText;
            this.rdbSquare.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSquare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbSquare.Location = new System.Drawing.Point(36, 340);
            this.rdbSquare.Name = "rdbSquare";
            this.rdbSquare.Size = new System.Drawing.Size(84, 26);
            this.rdbSquare.TabIndex = 5;
            this.rdbSquare.TabStop = true;
            this.rdbSquare.Text = "Square";
            this.rdbSquare.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Red;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalculate.Location = new System.Drawing.Point(121, 429);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(113, 49);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(227, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "INPUT NUMBER ▼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(173, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Radius";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(173, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(191, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(146, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Length (L)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(144, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Width (W)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GrayText;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(132, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Side Length";
            // 
            // txtRadius
            // 
            this.txtRadius.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtRadius.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadius.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtRadius.Location = new System.Drawing.Point(254, 90);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 29);
            this.txtRadius.TabIndex = 15;
            // 
            // txtBase
            // 
            this.txtBase.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtBase.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBase.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtBase.Location = new System.Drawing.Point(254, 135);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 29);
            this.txtBase.TabIndex = 16;
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHeight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeight.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtHeight.Location = new System.Drawing.Point(254, 172);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 29);
            this.txtHeight.TabIndex = 17;
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtLength.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtLength.Location = new System.Drawing.Point(254, 233);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 29);
            this.txtLength.TabIndex = 19;
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtWidth.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtWidth.Location = new System.Drawing.Point(254, 273);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 29);
            this.txtWidth.TabIndex = 20;
            // 
            // txtSideLength
            // 
            this.txtSideLength.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSideLength.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideLength.ForeColor = System.Drawing.SystemColors.Window;
            this.txtSideLength.Location = new System.Drawing.Point(254, 339);
            this.txtSideLength.Name = "txtSideLength";
            this.txtSideLength.Size = new System.Drawing.Size(100, 29);
            this.txtSideLength.TabIndex = 21;
            // 
            // cmbRadius
            // 
            this.cmbRadius.BackColor = System.Drawing.Color.Yellow;
            this.cmbRadius.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRadius.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRadius.ForeColor = System.Drawing.Color.Red;
            this.cmbRadius.FormattingEnabled = true;
            this.cmbRadius.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbRadius.Location = new System.Drawing.Point(360, 90);
            this.cmbRadius.Name = "cmbRadius";
            this.cmbRadius.Size = new System.Drawing.Size(121, 30);
            this.cmbRadius.TabIndex = 22;
            // 
            // cmbBase
            // 
            this.cmbBase.BackColor = System.Drawing.Color.Yellow;
            this.cmbBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBase.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBase.ForeColor = System.Drawing.Color.Red;
            this.cmbBase.FormattingEnabled = true;
            this.cmbBase.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbBase.Location = new System.Drawing.Point(360, 134);
            this.cmbBase.Name = "cmbBase";
            this.cmbBase.Size = new System.Drawing.Size(121, 30);
            this.cmbBase.TabIndex = 23;
            this.cmbBase.SelectedIndexChanged += new System.EventHandler(this.cmbBase_SelectedIndexChanged);
            // 
            // cmbHeight
            // 
            this.cmbHeight.BackColor = System.Drawing.Color.Yellow;
            this.cmbHeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHeight.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHeight.ForeColor = System.Drawing.Color.Red;
            this.cmbHeight.FormattingEnabled = true;
            this.cmbHeight.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbHeight.Location = new System.Drawing.Point(360, 175);
            this.cmbHeight.Name = "cmbHeight";
            this.cmbHeight.Size = new System.Drawing.Size(121, 30);
            this.cmbHeight.TabIndex = 24;
            // 
            // cmbLength
            // 
            this.cmbLength.BackColor = System.Drawing.Color.Yellow;
            this.cmbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLength.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLength.ForeColor = System.Drawing.Color.Red;
            this.cmbLength.FormattingEnabled = true;
            this.cmbLength.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbLength.Location = new System.Drawing.Point(360, 231);
            this.cmbLength.Name = "cmbLength";
            this.cmbLength.Size = new System.Drawing.Size(121, 30);
            this.cmbLength.TabIndex = 26;
            this.cmbLength.SelectedIndexChanged += new System.EventHandler(this.cmbLength_SelectedIndexChanged);
            // 
            // cmbWidth
            // 
            this.cmbWidth.BackColor = System.Drawing.Color.Yellow;
            this.cmbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWidth.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWidth.ForeColor = System.Drawing.Color.Red;
            this.cmbWidth.FormattingEnabled = true;
            this.cmbWidth.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbWidth.Location = new System.Drawing.Point(360, 273);
            this.cmbWidth.Name = "cmbWidth";
            this.cmbWidth.Size = new System.Drawing.Size(121, 30);
            this.cmbWidth.TabIndex = 27;
            // 
            // cmbSideLength
            // 
            this.cmbSideLength.BackColor = System.Drawing.Color.Yellow;
            this.cmbSideLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSideLength.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSideLength.ForeColor = System.Drawing.Color.Red;
            this.cmbSideLength.FormattingEnabled = true;
            this.cmbSideLength.Items.AddRange(new object[] {
            "Yard",
            "Feet",
            "Miles",
            "Kilometers",
            "Meters",
            "Centimeters",
            "Millimeters"});
            this.cmbSideLength.Location = new System.Drawing.Point(360, 338);
            this.cmbSideLength.Name = "cmbSideLength";
            this.cmbSideLength.Size = new System.Drawing.Size(121, 30);
            this.cmbSideLength.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(505, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 22);
            this.label9.TabIndex = 29;
            this.label9.Text = "Answer Display Unit";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Red;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(240, 429);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 49);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(321, 429);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 49);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Yellow;
            this.lblResult.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(504, 146);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 26);
            this.lblResult.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(181, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 22);
            this.label8.TabIndex = 33;
            this.label8.Text = "Area Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = global::Area_Calculator_App.Properties.Resources.Area_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 558);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbSideLength);
            this.Controls.Add(this.cmbWidth);
            this.Controls.Add(this.cmbLength);
            this.Controls.Add(this.cmbHeight);
            this.Controls.Add(this.cmbBase);
            this.Controls.Add(this.cmbRadius);
            this.Controls.Add(this.txtSideLength);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdbSquare);
            this.Controls.Add(this.rdbRectangle);
            this.Controls.Add(this.rdbTriangle);
            this.Controls.Add(this.rdbCircle);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Area Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.RadioButton rdbCircle;
        private System.Windows.Forms.RadioButton rdbTriangle;
        private System.Windows.Forms.RadioButton rdbRectangle;
        private System.Windows.Forms.RadioButton rdbSquare;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtSideLength;
        private System.Windows.Forms.ComboBox cmbRadius;
        private System.Windows.Forms.ComboBox cmbBase;
        private System.Windows.Forms.ComboBox cmbHeight;
        private System.Windows.Forms.ComboBox cmbLength;
        private System.Windows.Forms.ComboBox cmbWidth;
        private System.Windows.Forms.ComboBox cmbSideLength;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label8;
    }
}

