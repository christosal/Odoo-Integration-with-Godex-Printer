namespace Odoo_Barcode_Printer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBarcode = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.product_name = new System.Windows.Forms.Label();
            this.product_price = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textAddPerfume = new System.Windows.Forms.TextBox();
            this.buttonAddPerfume = new System.Windows.Forms.Button();
            this.buttonRemovePerfume = new System.Windows.Forms.Button();
            this.checkPrinter = new System.Windows.Forms.CheckBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBarcode
            // 
            this.textBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBarcode.Location = new System.Drawing.Point(80, 84);
            this.textBarcode.Name = "textBarcode";
            this.textBarcode.Size = new System.Drawing.Size(313, 26);
            this.textBarcode.TabIndex = 0;
            this.textBarcode.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("The Futura", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(196, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Εκτύπωση";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_name
            // 
            this.product_name.AutoSize = true;
            this.product_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_name.Location = new System.Drawing.Point(178, 150);
            this.product_name.Name = "product_name";
            this.product_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.product_name.Size = new System.Drawing.Size(60, 24);
            this.product_name.TabIndex = 3;
            this.product_name.Text = "label2";
            this.product_name.Visible = false;
            this.product_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // product_price
            // 
            this.product_price.AutoSize = true;
            this.product_price.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.product_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_price.Location = new System.Drawing.Point(179, 184);
            this.product_price.Name = "product_price";
            this.product_price.Size = new System.Drawing.Size(60, 24);
            this.product_price.TabIndex = 4;
            this.product_price.Text = "label3";
            this.product_price.Visible = false;
            this.product_price.Click += new System.EventHandler(this.product_price_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("The Futura", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(140, 279);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(50, 30);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(131, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 24);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Barcode";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(247, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.Text = "Άρωμα";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Aqua Di Gio",
            "Armani Code",
            "Creed"});
            this.comboBox1.Location = new System.Drawing.Point(80, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(313, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Visible = false;
            // 
            // textAddPerfume
            // 
            this.textAddPerfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAddPerfume.Location = new System.Drawing.Point(80, 117);
            this.textAddPerfume.Name = "textAddPerfume";
            this.textAddPerfume.Size = new System.Drawing.Size(170, 23);
            this.textAddPerfume.TabIndex = 9;
            this.textAddPerfume.Visible = false;
            this.textAddPerfume.TextChanged += new System.EventHandler(this.textAddPerfume_TextChanged);
            // 
            // buttonAddPerfume
            // 
            this.buttonAddPerfume.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonAddPerfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPerfume.Location = new System.Drawing.Point(256, 115);
            this.buttonAddPerfume.Name = "buttonAddPerfume";
            this.buttonAddPerfume.Size = new System.Drawing.Size(77, 30);
            this.buttonAddPerfume.TabIndex = 10;
            this.buttonAddPerfume.Text = "Προσθήκη";
            this.buttonAddPerfume.UseVisualStyleBackColor = false;
            this.buttonAddPerfume.Visible = false;
            this.buttonAddPerfume.Click += new System.EventHandler(this.buttonAddPerfume_Click);
            // 
            // buttonRemovePerfume
            // 
            this.buttonRemovePerfume.BackColor = System.Drawing.Color.LightCoral;
            this.buttonRemovePerfume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemovePerfume.Location = new System.Drawing.Point(339, 115);
            this.buttonRemovePerfume.Name = "buttonRemovePerfume";
            this.buttonRemovePerfume.Size = new System.Drawing.Size(77, 30);
            this.buttonRemovePerfume.TabIndex = 11;
            this.buttonRemovePerfume.Text = "Διαγραφή";
            this.buttonRemovePerfume.UseVisualStyleBackColor = false;
            this.buttonRemovePerfume.Visible = false;
            this.buttonRemovePerfume.Click += new System.EventHandler(this.buttonRemovePerfume_Click);
            // 
            // checkPrinter
            // 
            this.checkPrinter.AutoSize = true;
            this.checkPrinter.Location = new System.Drawing.Point(196, 319);
            this.checkPrinter.Name = "checkPrinter";
            this.checkPrinter.Size = new System.Drawing.Size(141, 17);
            this.checkPrinter.TabIndex = 12;
            this.checkPrinter.Text = "Διαθέσιμος εκτυπωτής";
            this.checkPrinter.UseVisualStyleBackColor = true;
            this.checkPrinter.CheckedChanged += new System.EventHandler(this.checkPrinter_CheckedChanged);
            // 
            // buttonRandom
            // 
            this.buttonRandom.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRandom.Location = new System.Drawing.Point(399, 84);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(53, 26);
            this.buttonRandom.TabIndex = 13;
            this.buttonRandom.Text = "#";
            this.buttonRandom.UseVisualStyleBackColor = false;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 373);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.checkPrinter);
            this.Controls.Add(this.buttonRemovePerfume);
            this.Controls.Add(this.buttonAddPerfume);
            this.Controls.Add(this.textAddPerfume);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.product_price);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBarcode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magazi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBarcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label product_name;
        private System.Windows.Forms.Label product_price;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textAddPerfume;
        private System.Windows.Forms.Button buttonAddPerfume;
        private System.Windows.Forms.Button buttonRemovePerfume;
        private System.Windows.Forms.CheckBox checkPrinter;
        private System.Windows.Forms.Button buttonRandom;
    }
}

