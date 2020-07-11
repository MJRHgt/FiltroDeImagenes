namespace ProyectoImagenes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metodo_10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_1 = new System.Windows.Forms.TextBox();
            this.m_2 = new System.Windows.Forms.TextBox();
            this.m_3 = new System.Windows.Forms.TextBox();
            this.m_4 = new System.Windows.Forms.TextBox();
            this.m_5 = new System.Windows.Forms.TextBox();
            this.m_6 = new System.Windows.Forms.TextBox();
            this.m_7 = new System.Windows.Forms.TextBox();
            this.m_8 = new System.Windows.Forms.TextBox();
            this.m_9 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.path = new System.Windows.Forms.TextBox();
            this.metodo1 = new System.Windows.Forms.Button();
            this.metodo_2 = new System.Windows.Forms.Button();
            this.metodo_3 = new System.Windows.Forms.Button();
            this.metodo_4 = new System.Windows.Forms.Button();
            this.metodo_5 = new System.Windows.Forms.Button();
            this.metodo_6 = new System.Windows.Forms.Button();
            this.metodo_7 = new System.Windows.Forms.Button();
            this.metodo_8 = new System.Windows.Forms.Button();
            this.metodo_9 = new System.Windows.Forms.Button();
            this.vistadialogo = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(83, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(465, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(325, 444);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // metodo_10
            // 
            this.metodo_10.Location = new System.Drawing.Point(693, 520);
            this.metodo_10.Name = "metodo_10";
            this.metodo_10.Size = new System.Drawing.Size(97, 77);
            this.metodo_10.TabIndex = 2;
            this.metodo_10.Text = "Generar imagen";
            this.metodo_10.UseVisualStyleBackColor = true;
            this.metodo_10.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Original";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 4;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // m_1
            // 
            this.m_1.Location = new System.Drawing.Point(465, 520);
            this.m_1.Name = "m_1";
            this.m_1.Size = new System.Drawing.Size(70, 22);
            this.m_1.TabIndex = 5;
            this.m_1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // m_2
            // 
            this.m_2.Location = new System.Drawing.Point(465, 548);
            this.m_2.Name = "m_2";
            this.m_2.Size = new System.Drawing.Size(70, 22);
            this.m_2.TabIndex = 6;
            // 
            // m_3
            // 
            this.m_3.Location = new System.Drawing.Point(465, 575);
            this.m_3.Name = "m_3";
            this.m_3.Size = new System.Drawing.Size(70, 22);
            this.m_3.TabIndex = 7;
            // 
            // m_4
            // 
            this.m_4.Location = new System.Drawing.Point(541, 520);
            this.m_4.Name = "m_4";
            this.m_4.Size = new System.Drawing.Size(70, 22);
            this.m_4.TabIndex = 8;
            // 
            // m_5
            // 
            this.m_5.Location = new System.Drawing.Point(541, 548);
            this.m_5.Name = "m_5";
            this.m_5.Size = new System.Drawing.Size(70, 22);
            this.m_5.TabIndex = 9;
            // 
            // m_6
            // 
            this.m_6.Location = new System.Drawing.Point(541, 575);
            this.m_6.Name = "m_6";
            this.m_6.Size = new System.Drawing.Size(70, 22);
            this.m_6.TabIndex = 10;
            // 
            // m_7
            // 
            this.m_7.Location = new System.Drawing.Point(617, 520);
            this.m_7.Name = "m_7";
            this.m_7.Size = new System.Drawing.Size(70, 22);
            this.m_7.TabIndex = 11;
            // 
            // m_8
            // 
            this.m_8.Location = new System.Drawing.Point(617, 547);
            this.m_8.Name = "m_8";
            this.m_8.Size = new System.Drawing.Size(70, 22);
            this.m_8.TabIndex = 12;
            // 
            // m_9
            // 
            this.m_9.Location = new System.Drawing.Point(617, 575);
            this.m_9.Name = "m_9";
            this.m_9.Size = new System.Drawing.Size(70, 22);
            this.m_9.TabIndex = 13;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 49);
            this.button2.TabIndex = 15;
            this.button2.Text = "abrir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(83, 575);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(338, 22);
            this.path.TabIndex = 16;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // metodo1
            // 
            this.metodo1.Location = new System.Drawing.Point(816, 70);
            this.metodo1.Name = "metodo1";
            this.metodo1.Size = new System.Drawing.Size(140, 53);
            this.metodo1.TabIndex = 17;
            this.metodo1.Text = "Difuminado";
            this.metodo1.UseVisualStyleBackColor = true;
            this.metodo1.Click += new System.EventHandler(this.Met1_Click);
            // 
            // metodo_2
            // 
            this.metodo_2.Location = new System.Drawing.Point(816, 129);
            this.metodo_2.Name = "metodo_2";
            this.metodo_2.Size = new System.Drawing.Size(140, 53);
            this.metodo_2.TabIndex = 18;
            this.metodo_2.Text = "Realzar";
            this.metodo_2.UseVisualStyleBackColor = true;
            this.metodo_2.Click += new System.EventHandler(this.metodo_2_Click);
            // 
            // metodo_3
            // 
            this.metodo_3.Location = new System.Drawing.Point(816, 188);
            this.metodo_3.Name = "metodo_3";
            this.metodo_3.Size = new System.Drawing.Size(140, 53);
            this.metodo_3.TabIndex = 19;
            this.metodo_3.Text = "Sobel Inferior";
            this.metodo_3.UseVisualStyleBackColor = true;
            this.metodo_3.Click += new System.EventHandler(this.metodo_3_Click);
            // 
            // metodo_4
            // 
            this.metodo_4.Location = new System.Drawing.Point(816, 247);
            this.metodo_4.Name = "metodo_4";
            this.metodo_4.Size = new System.Drawing.Size(140, 53);
            this.metodo_4.TabIndex = 20;
            this.metodo_4.Text = "Sobel Superior";
            this.metodo_4.UseVisualStyleBackColor = true;
            this.metodo_4.Click += new System.EventHandler(this.metodo_4_Click);
            // 
            // metodo_5
            // 
            this.metodo_5.Location = new System.Drawing.Point(816, 306);
            this.metodo_5.Name = "metodo_5";
            this.metodo_5.Size = new System.Drawing.Size(140, 53);
            this.metodo_5.TabIndex = 21;
            this.metodo_5.Text = "Sobel Izquierdo";
            this.metodo_5.UseVisualStyleBackColor = true;
            this.metodo_5.Click += new System.EventHandler(this.metodo_5_Click);
            // 
            // metodo_6
            // 
            this.metodo_6.Location = new System.Drawing.Point(816, 365);
            this.metodo_6.Name = "metodo_6";
            this.metodo_6.Size = new System.Drawing.Size(140, 53);
            this.metodo_6.TabIndex = 22;
            this.metodo_6.Text = "Sobel Derecho";
            this.metodo_6.UseVisualStyleBackColor = true;
            this.metodo_6.Click += new System.EventHandler(this.metodo_6_Click);
            // 
            // metodo_7
            // 
            this.metodo_7.Location = new System.Drawing.Point(816, 424);
            this.metodo_7.Name = "metodo_7";
            this.metodo_7.Size = new System.Drawing.Size(140, 53);
            this.metodo_7.TabIndex = 23;
            this.metodo_7.Text = "Contorno";
            this.metodo_7.UseVisualStyleBackColor = true;
            this.metodo_7.Click += new System.EventHandler(this.button4_Click);
            // 
            // metodo_8
            // 
            this.metodo_8.Location = new System.Drawing.Point(816, 483);
            this.metodo_8.Name = "metodo_8";
            this.metodo_8.Size = new System.Drawing.Size(140, 53);
            this.metodo_8.TabIndex = 24;
            this.metodo_8.Text = "Afilar";
            this.metodo_8.UseVisualStyleBackColor = true;
            this.metodo_8.Click += new System.EventHandler(this.metodo_8_Click);
            // 
            // metodo_9
            // 
            this.metodo_9.Location = new System.Drawing.Point(816, 542);
            this.metodo_9.Name = "metodo_9";
            this.metodo_9.Size = new System.Drawing.Size(140, 53);
            this.metodo_9.TabIndex = 25;
            this.metodo_9.Text = "Original";
            this.metodo_9.UseVisualStyleBackColor = true;
            this.metodo_9.Click += new System.EventHandler(this.metodo_9_Click);
            // 
            // vistadialogo
            // 
            this.vistadialogo.FileName = "vistadialo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Generado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 546);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nombre de la imagen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(981, 631);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.metodo_9);
            this.Controls.Add(this.metodo_8);
            this.Controls.Add(this.metodo_7);
            this.Controls.Add(this.metodo_6);
            this.Controls.Add(this.metodo_5);
            this.Controls.Add(this.metodo_4);
            this.Controls.Add(this.metodo_3);
            this.Controls.Add(this.metodo_2);
            this.Controls.Add(this.metodo1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_9);
            this.Controls.Add(this.m_8);
            this.Controls.Add(this.m_7);
            this.Controls.Add(this.m_6);
            this.Controls.Add(this.m_5);
            this.Controls.Add(this.m_4);
            this.Controls.Add(this.m_3);
            this.Controls.Add(this.m_2);
            this.Controls.Add(this.m_1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metodo_10);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " Proyecto De filtros";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button metodo_10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_1;
        private System.Windows.Forms.TextBox m_2;
        private System.Windows.Forms.TextBox m_3;
        private System.Windows.Forms.TextBox m_4;
        private System.Windows.Forms.TextBox m_5;
        private System.Windows.Forms.TextBox m_6;
        private System.Windows.Forms.TextBox m_7;
        private System.Windows.Forms.TextBox m_8;
        private System.Windows.Forms.TextBox m_9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button metodo1;
        private System.Windows.Forms.Button metodo_2;
        private System.Windows.Forms.Button metodo_3;
        private System.Windows.Forms.Button metodo_4;
        private System.Windows.Forms.Button metodo_5;
        private System.Windows.Forms.Button metodo_6;
        private System.Windows.Forms.Button metodo_7;
        private System.Windows.Forms.Button metodo_8;
        private System.Windows.Forms.Button metodo_9;
        private System.Windows.Forms.OpenFileDialog vistadialogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

