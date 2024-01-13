namespace WindowsFormsApp1
{
    partial class ListaDiscos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaDiscos));
            this.dataGridView_Lista = new System.Windows.Forms.DataGridView();
            this.button1VerLista = new System.Windows.Forms.Button();
            this.pictureBox1Imagen = new System.Windows.Forms.PictureBox();
            this.button2Agregar = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Lista
            // 
            this.dataGridView_Lista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Lista.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_Lista.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Lista.Name = "dataGridView_Lista";
            this.dataGridView_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Lista.Size = new System.Drawing.Size(484, 292);
            this.dataGridView_Lista.TabIndex = 0;
            this.dataGridView_Lista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Lista_CellContentClick);
            this.dataGridView_Lista.SelectionChanged += new System.EventHandler(this.dataGridView_Lista_SelectionChanged);
            // 
            // button1VerLista
            // 
            this.button1VerLista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1VerLista.Location = new System.Drawing.Point(54, 340);
            this.button1VerLista.Name = "button1VerLista";
            this.button1VerLista.Size = new System.Drawing.Size(99, 51);
            this.button1VerLista.TabIndex = 1;
            this.button1VerLista.Text = "Ver Lista";
            this.button1VerLista.UseVisualStyleBackColor = false;
            this.button1VerLista.Click += new System.EventHandler(this.button1VerLista_Click);
            // 
            // pictureBox1Imagen
            // 
            this.pictureBox1Imagen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1Imagen.Location = new System.Drawing.Point(518, 12);
            this.pictureBox1Imagen.Name = "pictureBox1Imagen";
            this.pictureBox1Imagen.Size = new System.Drawing.Size(357, 292);
            this.pictureBox1Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1Imagen.TabIndex = 2;
            this.pictureBox1Imagen.TabStop = false;
            this.pictureBox1Imagen.Click += new System.EventHandler(this.pictureBox1Imagen_Click);
            // 
            // button2Agregar
            // 
            this.button2Agregar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2Agregar.Location = new System.Drawing.Point(170, 340);
            this.button2Agregar.Name = "button2Agregar";
            this.button2Agregar.Size = new System.Drawing.Size(99, 51);
            this.button2Agregar.TabIndex = 3;
            this.button2Agregar.Text = "Agregar";
            this.button2Agregar.UseVisualStyleBackColor = false;
            this.button2Agregar.Click += new System.EventHandler(this.button2Agregar_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonModificar.Location = new System.Drawing.Point(293, 340);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(99, 51);
            this.buttonModificar.TabIndex = 4;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonEliminar.Location = new System.Drawing.Point(418, 340);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(99, 51);
            this.buttonEliminar.TabIndex = 5;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ListaDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.button2Agregar);
            this.Controls.Add(this.pictureBox1Imagen);
            this.Controls.Add(this.button1VerLista);
            this.Controls.Add(this.dataGridView_Lista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaDiscos";
            this.Load += new System.EventHandler(this.ListaDiscos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1Imagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Lista;
        private System.Windows.Forms.Button button1VerLista;
        private System.Windows.Forms.PictureBox pictureBox1Imagen;
        private System.Windows.Forms.Button button2Agregar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Button buttonEliminar;
    }
}