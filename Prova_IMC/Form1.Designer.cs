namespace Prova_IMC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            lblResultImc = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtImc = new TextBox();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            button13 = new Button();
            btnDelete = new Button();
            button11 = new Button();
            btnVirgula = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblResultImc);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtImc);
            panel1.Controls.Add(txtAltura);
            panel1.Controls.Add(txtPeso);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 204);
            panel1.TabIndex = 0;
            // 
            // lblResultImc
            // 
            lblResultImc.AutoSize = true;
            lblResultImc.Font = new Font("Calibri", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultImc.ForeColor = SystemColors.ControlDarkDark;
            lblResultImc.Location = new Point(19, 179);
            lblResultImc.Name = "lblResultImc";
            lblResultImc.Size = new Size(0, 23);
            lblResultImc.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Cursor = Cursors.Help;
            pictureBox2.Location = new Point(45, 98);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 38);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Help;
            pictureBox1.Location = new Point(45, 52);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(105, 161);
            label5.Name = "label5";
            label5.Size = new Size(52, 23);
            label5.TabIndex = 7;
            label5.Text = "IMC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(89, 113);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 6;
            label4.Text = "Altura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(105, 68);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 5;
            label3.Text = "Peso";
            // 
            // txtImc
            // 
            txtImc.Cursor = Cursors.No;
            txtImc.Enabled = false;
            txtImc.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtImc.Location = new Point(169, 158);
            txtImc.Name = "txtImc";
            txtImc.Size = new Size(73, 31);
            txtImc.TabIndex = 4;
            txtImc.Tag = "AdicionarNumeros";
            // 
            // txtAltura
            // 
            txtAltura.Cursor = Cursors.IBeam;
            txtAltura.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtAltura.Location = new Point(169, 110);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(73, 31);
            txtAltura.TabIndex = 3;
            txtAltura.Enter += txtAltura_Enter;
            // 
            // txtPeso
            // 
            txtPeso.Cursor = Cursors.IBeam;
            txtPeso.Font = new Font("Verdana", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(169, 64);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(73, 31);
            txtPeso.TabIndex = 2;
            txtPeso.Enter += txtPeso_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(55, 31);
            label2.Name = "label2";
            label2.Size = new Size(199, 21);
            label2.TabIndex = 1;
            label2.Text = "Informe seu Peso e Altura";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 2);
            label1.Name = "label1";
            label1.Size = new Size(185, 25);
            label1.TabIndex = 0;
            label1.Text = "Cálculo de IMC";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(button13);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(button11);
            panel2.Controls.Add(btnVirgula);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button9);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(6, 217);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 283);
            panel2.TabIndex = 1;
            // 
            // button13
            // 
            button13.BackColor = Color.Gold;
            button13.Cursor = Cursors.NoMove2D;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Location = new Point(36, 245);
            button13.Name = "button13";
            button13.Size = new Size(248, 23);
            button13.TabIndex = 12;
            button13.Text = "Calcular Índice de Massa Corporal";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Gold;
            btnDelete.Cursor = Cursors.PanSE;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(217, 186);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(67, 53);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Del";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Gold;
            button11.Cursor = Cursors.PanSouth;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Location = new Point(127, 186);
            button11.Name = "button11";
            button11.Size = new Size(69, 53);
            button11.TabIndex = 10;
            button11.Tag = "AdicionarNumeros";
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += AdicionarNumeros1;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.Gold;
            btnVirgula.Cursor = Cursors.PanSW;
            btnVirgula.FlatStyle = FlatStyle.Flat;
            btnVirgula.Location = new Point(36, 186);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(69, 53);
            btnVirgula.TabIndex = 9;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += AdicionarNumeros1;
            // 
            // button7
            // 
            button7.BackColor = Color.Gold;
            button7.Cursor = Cursors.PanEast;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(217, 126);
            button7.Name = "button7";
            button7.Size = new Size(67, 53);
            button7.TabIndex = 8;
            button7.Tag = "AdicionarNumeros";
            button7.Text = "3";
            button7.UseVisualStyleBackColor = false;
            button7.Click += AdicionarNumeros1;
            // 
            // button8
            // 
            button8.BackColor = Color.Gold;
            button8.Cursor = Cursors.NoMove2D;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(127, 126);
            button8.Name = "button8";
            button8.Size = new Size(69, 53);
            button8.TabIndex = 7;
            button8.Tag = "AdicionarNumeros";
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.UseWaitCursor = true;
            button8.Click += AdicionarNumeros1;
            // 
            // button9
            // 
            button9.BackColor = Color.Gold;
            button9.Cursor = Cursors.PanWest;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Location = new Point(36, 126);
            button9.Name = "button9";
            button9.Size = new Size(69, 53);
            button9.TabIndex = 6;
            button9.Tag = "AdicionarNumeros";
            button9.Text = "1";
            button9.UseVisualStyleBackColor = false;
            button9.Click += AdicionarNumeros1;
            // 
            // button4
            // 
            button4.BackColor = Color.Gold;
            button4.Cursor = Cursors.PanEast;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(217, 66);
            button4.Name = "button4";
            button4.Size = new Size(67, 53);
            button4.TabIndex = 5;
            button4.Tag = "AdicionarNumeros";
            button4.Text = "6";
            button4.UseVisualStyleBackColor = false;
            button4.Click += AdicionarNumeros1;
            // 
            // button5
            // 
            button5.BackColor = Color.Gold;
            button5.Cursor = Cursors.NoMove2D;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(127, 66);
            button5.Name = "button5";
            button5.Size = new Size(69, 53);
            button5.TabIndex = 4;
            button5.Tag = "AdicionarNumeros";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += AdicionarNumeros1;
            // 
            // button6
            // 
            button6.BackColor = Color.Gold;
            button6.Cursor = Cursors.PanWest;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(36, 66);
            button6.Name = "button6";
            button6.Size = new Size(69, 53);
            button6.TabIndex = 3;
            button6.Tag = "AdicionarNumeros";
            button6.Text = "4";
            button6.UseVisualStyleBackColor = false;
            button6.Click += AdicionarNumeros1;
            // 
            // button3
            // 
            button3.BackColor = Color.Gold;
            button3.Cursor = Cursors.PanNE;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(217, 6);
            button3.Name = "button3";
            button3.Size = new Size(67, 53);
            button3.TabIndex = 2;
            button3.Tag = "AdicionarNumeros";
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += AdicionarNumeros1;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Cursor = Cursors.PanNorth;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(127, 6);
            button2.Name = "button2";
            button2.Size = new Size(69, 53);
            button2.TabIndex = 1;
            button2.Tag = "AdicionarNumeros";
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += AdicionarNumeros1;
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Cursor = Cursors.PanNW;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(36, 6);
            button1.Name = "button1";
            button1.Size = new Size(69, 53);
            button1.TabIndex = 0;
            button1.Tag = "AdicionarNumeros";
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AdicionarNumeros1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(338, 512);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Click += AdicionarNumeros1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtImc;
        private TextBox txtAltura;
        private TextBox txtPeso;
        public PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button13;
        private Button btnDelete;
        private Button button11;
        private Button btnVirgula;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblResultImc;
    }
}
