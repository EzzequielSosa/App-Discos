namespace WindowsFormsApp1
{
    partial class FormAlta
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
            this.label1Titulo = new System.Windows.Forms.Label();
            this.label2CantCan = new System.Windows.Forms.Label();
            this.textBox1Titulo = new System.Windows.Forms.TextBox();
            this.textBox2CantCan = new System.Windows.Forms.TextBox();
            this.button1Aceptar = new System.Windows.Forms.Button();
            this.button2Cancelar = new System.Windows.Forms.Button();
            this.labelRitmo = new System.Windows.Forms.Label();
            this.comboBox1Ritmo = new System.Windows.Forms.ComboBox();
            this.textBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.labelUrlImagen = new System.Windows.Forms.Label();
            this.pictureBoxImagenAlta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAlta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1Titulo
            // 
            this.label1Titulo.AutoSize = true;
            this.label1Titulo.Location = new System.Drawing.Point(72, 56);
            this.label1Titulo.Name = "label1Titulo";
            this.label1Titulo.Size = new System.Drawing.Size(36, 13);
            this.label1Titulo.TabIndex = 0;
            this.label1Titulo.Text = "Titulo:";
            // 
            // label2CantCan
            // 
            this.label2CantCan.AutoSize = true;
            this.label2CantCan.Location = new System.Drawing.Point(3, 92);
            this.label2CantCan.Name = "label2CantCan";
            this.label2CantCan.Size = new System.Drawing.Size(105, 13);
            this.label2CantCan.TabIndex = 1;
            this.label2CantCan.Text = "Cantidad Canciones:";
            // 
            // textBox1Titulo
            // 
            this.textBox1Titulo.Location = new System.Drawing.Point(114, 49);
            this.textBox1Titulo.Name = "textBox1Titulo";
            this.textBox1Titulo.Size = new System.Drawing.Size(146, 20);
            this.textBox1Titulo.TabIndex = 0;
            // 
            // textBox2CantCan
            // 
            this.textBox2CantCan.Location = new System.Drawing.Point(114, 89);
            this.textBox2CantCan.Name = "textBox2CantCan";
            this.textBox2CantCan.Size = new System.Drawing.Size(146, 20);
            this.textBox2CantCan.TabIndex = 1;
            this.textBox2CantCan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1Aceptar
            // 
            this.button1Aceptar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Aceptar.Location = new System.Drawing.Point(151, 266);
            this.button1Aceptar.Name = "button1Aceptar";
            this.button1Aceptar.Size = new System.Drawing.Size(109, 58);
            this.button1Aceptar.TabIndex = 4;
            this.button1Aceptar.Text = "Aceptar";
            this.button1Aceptar.UseVisualStyleBackColor = false;
            this.button1Aceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Cancelar
            // 
            this.button2Cancelar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button2Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Cancelar.Location = new System.Drawing.Point(285, 266);
            this.button2Cancelar.Name = "button2Cancelar";
            this.button2Cancelar.Size = new System.Drawing.Size(109, 58);
            this.button2Cancelar.TabIndex = 5;
            this.button2Cancelar.Text = "Cancelar";
            this.button2Cancelar.UseVisualStyleBackColor = false;
            this.button2Cancelar.Click += new System.EventHandler(this.button2Cancelar_Click);
            // 
            // labelRitmo
            // 
            this.labelRitmo.AutoSize = true;
            this.labelRitmo.Location = new System.Drawing.Point(71, 168);
            this.labelRitmo.Name = "labelRitmo";
            this.labelRitmo.Size = new System.Drawing.Size(37, 13);
            this.labelRitmo.TabIndex = 8;
            this.labelRitmo.Text = "Ritmo:";
            // 
            // comboBox1Ritmo
            // 
            this.comboBox1Ritmo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1Ritmo.FormattingEnabled = true;
            this.comboBox1Ritmo.Location = new System.Drawing.Point(114, 165);
            this.comboBox1Ritmo.Name = "comboBox1Ritmo";
            this.comboBox1Ritmo.Size = new System.Drawing.Size(146, 21);
            this.comboBox1Ritmo.TabIndex = 3;
            this.comboBox1Ritmo.SelectedIndexChanged += new System.EventHandler(this.comboBox1Ritmo_SelectedIndexChanged);
            // 
            // textBoxUrlImagen
            // 
            this.textBoxUrlImagen.Location = new System.Drawing.Point(114, 128);
            this.textBoxUrlImagen.Name = "textBoxUrlImagen";
            this.textBoxUrlImagen.Size = new System.Drawing.Size(146, 20);
            this.textBoxUrlImagen.TabIndex = 2;
            this.textBoxUrlImagen.TextChanged += new System.EventHandler(this.textBoxUrlImagen_TextChanged);
            this.textBoxUrlImagen.Leave += new System.EventHandler(this.textBoxUrlImagen_Leave);
            // 
            // labelUrlImagen
            // 
            this.labelUrlImagen.AutoSize = true;
            this.labelUrlImagen.Location = new System.Drawing.Point(47, 135);
            this.labelUrlImagen.Name = "labelUrlImagen";
            this.labelUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.labelUrlImagen.TabIndex = 10;
            this.labelUrlImagen.Text = "Url Imagen:";
            // 
            // pictureBoxImagenAlta
            // 
            this.pictureBoxImagenAlta.Location = new System.Drawing.Point(302, 24);
            this.pictureBoxImagenAlta.Name = "pictureBoxImagenAlta";
            this.pictureBoxImagenAlta.Size = new System.Drawing.Size(265, 226);
            this.pictureBoxImagenAlta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImagenAlta.TabIndex = 11;
            this.pictureBoxImagenAlta.TabStop = false;
            // 
            // FormAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(615, 357);
            this.Controls.Add(this.pictureBoxImagenAlta);
            this.Controls.Add(this.textBoxUrlImagen);
            this.Controls.Add(this.labelUrlImagen);
            this.Controls.Add(this.comboBox1Ritmo);
            this.Controls.Add(this.labelRitmo);
            this.Controls.Add(this.button2Cancelar);
            this.Controls.Add(this.button1Aceptar);
            this.Controls.Add(this.textBox2CantCan);
            this.Controls.Add(this.textBox1Titulo);
            this.Controls.Add(this.label2CantCan);
            this.Controls.Add(this.label1Titulo);
            this.Name = "FormAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo DISCO";
            this.Load += new System.EventHandler(this.FormAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImagenAlta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Titulo;
        private System.Windows.Forms.Label label2CantCan;
        private System.Windows.Forms.TextBox textBox1Titulo;
        private System.Windows.Forms.TextBox textBox2CantCan;
        private System.Windows.Forms.Button button1Aceptar;
        private System.Windows.Forms.Button button2Cancelar;
        private System.Windows.Forms.Label labelRitmo;
        private System.Windows.Forms.ComboBox comboBox1Ritmo;
        private System.Windows.Forms.TextBox textBoxUrlImagen;
        private System.Windows.Forms.Label labelUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxImagenAlta;
    }
}