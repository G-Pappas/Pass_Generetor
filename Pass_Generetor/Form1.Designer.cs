namespace Pass_Generetor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.small_letters__Box = new System.Windows.Forms.CheckBox();
            this.capital_letters__Box = new System.Windows.Forms.CheckBox();
            this.numbers_Box = new System.Windows.Forms.CheckBox();
            this.symbols_Box = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password Length:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(163, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // small_letters__Box
            // 
            this.small_letters__Box.AutoSize = true;
            this.small_letters__Box.Location = new System.Drawing.Point(38, 56);
            this.small_letters__Box.Name = "small_letters__Box";
            this.small_letters__Box.Size = new System.Drawing.Size(86, 17);
            this.small_letters__Box.TabIndex = 4;
            this.small_letters__Box.Text = "Small Letters";
            this.small_letters__Box.UseVisualStyleBackColor = true;
            // 
            // capital_letters__Box
            // 
            this.capital_letters__Box.AutoSize = true;
            this.capital_letters__Box.Location = new System.Drawing.Point(163, 56);
            this.capital_letters__Box.Name = "capital_letters__Box";
            this.capital_letters__Box.Size = new System.Drawing.Size(93, 17);
            this.capital_letters__Box.TabIndex = 5;
            this.capital_letters__Box.Text = "Capital Letters";
            this.capital_letters__Box.UseVisualStyleBackColor = true;
            // 
            // numbers_Box
            // 
            this.numbers_Box.AutoSize = true;
            this.numbers_Box.Location = new System.Drawing.Point(38, 79);
            this.numbers_Box.Name = "numbers_Box";
            this.numbers_Box.Size = new System.Drawing.Size(68, 17);
            this.numbers_Box.TabIndex = 6;
            this.numbers_Box.Text = "Numbers";
            this.numbers_Box.UseVisualStyleBackColor = true;
            // 
            // symbols_Box
            // 
            this.symbols_Box.AutoSize = true;
            this.symbols_Box.Location = new System.Drawing.Point(163, 79);
            this.symbols_Box.Name = "symbols_Box";
            this.symbols_Box.Size = new System.Drawing.Size(65, 17);
            this.symbols_Box.TabIndex = 7;
            this.symbols_Box.Text = "Symbols";
            this.symbols_Box.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Pass_Generetor.Properties.Resources.info;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(252, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 29);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.symbols_Box);
            this.Controls.Add(this.numbers_Box);
            this.Controls.Add(this.capital_letters__Box);
            this.Controls.Add(this.small_letters__Box);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox small_letters__Box;
        private System.Windows.Forms.CheckBox capital_letters__Box;
        private System.Windows.Forms.CheckBox numbers_Box;
        private System.Windows.Forms.CheckBox symbols_Box;
        private System.Windows.Forms.Button button2;
    }
}

