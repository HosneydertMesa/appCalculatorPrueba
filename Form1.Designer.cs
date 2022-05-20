namespace appCalculatorPrueba
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btRest = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btMasM = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btProd = new System.Windows.Forms.Button();
            this.brResta = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 47);
            this.textBox1.TabIndex = 1;
            // 
            // btRest
            // 
            this.btRest.BackColor = System.Drawing.Color.White;
            this.btRest.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btRest.Location = new System.Drawing.Point(12, 94);
            this.btRest.Name = "btRest";
            this.btRest.Size = new System.Drawing.Size(104, 44);
            this.btRest.TabIndex = 2;
            this.btRest.Text = "%";
            this.btRest.UseVisualStyleBackColor = false;
            this.btRest.Click += new System.EventHandler(this.btRest_Click);
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.White;
            this.btDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDelete.Location = new System.Drawing.Point(177, 95);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(102, 44);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "C";
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btMasM
            // 
            this.btMasM.BackColor = System.Drawing.Color.White;
            this.btMasM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btMasM.Location = new System.Drawing.Point(232, 141);
            this.btMasM.Name = "btMasM";
            this.btMasM.Size = new System.Drawing.Size(49, 44);
            this.btMasM.TabIndex = 2;
            this.btMasM.Text = "+/-";
            this.btMasM.UseVisualStyleBackColor = false;
            this.btMasM.Click += new System.EventHandler(this.btMasM_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // bt4
            // 
            this.bt4.BackColor = System.Drawing.Color.White;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt4.Location = new System.Drawing.Point(12, 194);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(49, 44);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = false;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // bt1
            // 
            this.bt1.BackColor = System.Drawing.Color.White;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt1.Location = new System.Drawing.Point(12, 244);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(49, 44);
            this.bt1.TabIndex = 2;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // bt0
            // 
            this.bt0.BackColor = System.Drawing.Color.White;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt0.Location = new System.Drawing.Point(12, 294);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(104, 44);
            this.bt0.TabIndex = 2;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = false;
            this.bt0.Click += new System.EventHandler(this.bt0_Click);
            // 
            // bt7
            // 
            this.bt7.BackColor = System.Drawing.Color.White;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt7.Location = new System.Drawing.Point(12, 144);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(49, 44);
            this.bt7.TabIndex = 2;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = false;
            this.bt7.Click += new System.EventHandler(this.bt7_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(67, 144);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 44);
            this.button10.TabIndex = 2;
            this.button10.Text = "button1";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // bt8
            // 
            this.bt8.BackColor = System.Drawing.Color.White;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt8.Location = new System.Drawing.Point(67, 144);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(49, 44);
            this.bt8.TabIndex = 2;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = false;
            this.bt8.Click += new System.EventHandler(this.bt8_Click);
            // 
            // bt5
            // 
            this.bt5.BackColor = System.Drawing.Color.White;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt5.Location = new System.Drawing.Point(67, 194);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(49, 44);
            this.bt5.TabIndex = 2;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = false;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // bt2
            // 
            this.bt2.BackColor = System.Drawing.Color.White;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt2.Location = new System.Drawing.Point(67, 244);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(49, 44);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = false;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(122, 144);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(49, 44);
            this.button15.TabIndex = 2;
            this.button15.Text = "button1";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // bt9
            // 
            this.bt9.BackColor = System.Drawing.Color.White;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt9.Location = new System.Drawing.Point(122, 144);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(49, 44);
            this.bt9.TabIndex = 2;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = false;
            this.bt9.Click += new System.EventHandler(this.bt9_Click);
            // 
            // bt6
            // 
            this.bt6.BackColor = System.Drawing.Color.White;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt6.Location = new System.Drawing.Point(122, 194);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(49, 44);
            this.bt6.TabIndex = 2;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = false;
            this.bt6.Click += new System.EventHandler(this.bt6_Click);
            // 
            // bt3
            // 
            this.bt3.BackColor = System.Drawing.Color.White;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt3.Location = new System.Drawing.Point(122, 244);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(49, 44);
            this.bt3.TabIndex = 2;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = false;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // btPunto
            // 
            this.btPunto.BackColor = System.Drawing.Color.White;
            this.btPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPunto.Location = new System.Drawing.Point(122, 294);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(49, 44);
            this.btPunto.TabIndex = 2;
            this.btPunto.Text = ".";
            this.btPunto.UseVisualStyleBackColor = false;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.Color.White;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btDiv.Location = new System.Drawing.Point(177, 144);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(49, 44);
            this.btDiv.TabIndex = 2;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btProd
            // 
            this.btProd.BackColor = System.Drawing.Color.White;
            this.btProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btProd.Location = new System.Drawing.Point(177, 194);
            this.btProd.Name = "btProd";
            this.btProd.Size = new System.Drawing.Size(49, 44);
            this.btProd.TabIndex = 2;
            this.btProd.Text = "*";
            this.btProd.UseVisualStyleBackColor = false;
            this.btProd.Click += new System.EventHandler(this.btProd_Click);
            // 
            // brResta
            // 
            this.brResta.BackColor = System.Drawing.Color.White;
            this.brResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brResta.Location = new System.Drawing.Point(177, 244);
            this.brResta.Name = "brResta";
            this.brResta.Size = new System.Drawing.Size(49, 44);
            this.brResta.TabIndex = 2;
            this.brResta.Text = "-";
            this.brResta.UseVisualStyleBackColor = false;
            this.brResta.Click += new System.EventHandler(this.brResta_Click);
            // 
            // btSuma
            // 
            this.btSuma.BackColor = System.Drawing.Color.White;
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSuma.Location = new System.Drawing.Point(177, 294);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(49, 44);
            this.btSuma.TabIndex = 2;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = false;
            this.btSuma.Click += new System.EventHandler(this.btSuma_Click);
            // 
            // btResultado
            // 
            this.btResultado.BackColor = System.Drawing.Color.White;
            this.btResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btResultado.Location = new System.Drawing.Point(230, 194);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(49, 144);
            this.btResultado.TabIndex = 2;
            this.btResultado.Text = "=";
            this.btResultado.UseVisualStyleBackColor = false;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(291, 368);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.brResta);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.btProd);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btMasM);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btRest);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem ediciónToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private TextBox textBox1;
        private Button btRest;
        private Button btDelete;
        private Button btMasM;
        private Button button2;
        private Button bt4;
        private Button bt1;
        private Button bt0;
        private Button bt7;
        private Button button10;
        private Button bt8;
        private Button bt5;
        private Button bt2;
        private Button button15;
        private Button bt9;
        private Button bt6;
        private Button bt3;
        private Button btPunto;
        private Button btDiv;
        private Button btProd;
        private Button brResta;
        private Button btSuma;
        private Button btResultado;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
    }
}