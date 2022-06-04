namespace WPEXAMEN
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
            this.dataGridViewdatos = new System.Windows.Forms.DataGridView();
            this.buttondatos = new System.Windows.Forms.Button();
            this.buttonnuevo = new System.Windows.Forms.Button();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.buttonbuscar = new System.Windows.Forms.Button();
            this.textBoxbusc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewdatos
            // 
            this.dataGridViewdatos.BackgroundColor = System.Drawing.Color.Navy;
            this.dataGridViewdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewdatos.Location = new System.Drawing.Point(12, 220);
            this.dataGridViewdatos.Name = "dataGridViewdatos";
            this.dataGridViewdatos.Size = new System.Drawing.Size(941, 226);
            this.dataGridViewdatos.TabIndex = 0;
            // 
            // buttondatos
            // 
            this.buttondatos.Location = new System.Drawing.Point(870, 191);
            this.buttondatos.Name = "buttondatos";
            this.buttondatos.Size = new System.Drawing.Size(73, 23);
            this.buttondatos.TabIndex = 1;
            this.buttondatos.Text = "OBTENER DATOS";
            this.buttondatos.UseVisualStyleBackColor = true;
            this.buttondatos.Click += new System.EventHandler(this.buttondatos_Click);
            // 
            // buttonnuevo
            // 
            this.buttonnuevo.BackColor = System.Drawing.Color.Navy;
            this.buttonnuevo.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonnuevo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonnuevo.Location = new System.Drawing.Point(38, 91);
            this.buttonnuevo.Name = "buttonnuevo";
            this.buttonnuevo.Size = new System.Drawing.Size(113, 42);
            this.buttonnuevo.TabIndex = 14;
            this.buttonnuevo.Text = "NUEVO";
            this.buttonnuevo.UseVisualStyleBackColor = false;
            this.buttonnuevo.Click += new System.EventHandler(this.buttonnuevo_Click);
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.BackColor = System.Drawing.Color.Navy;
            this.buttoneliminar.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoneliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttoneliminar.Location = new System.Drawing.Point(38, 159);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(145, 42);
            this.buttoneliminar.TabIndex = 15;
            this.buttoneliminar.Text = "ELIMINAR";
            this.buttoneliminar.UseVisualStyleBackColor = false;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // buttonbuscar
            // 
            this.buttonbuscar.BackColor = System.Drawing.Color.Navy;
            this.buttonbuscar.Font = new System.Drawing.Font("Segoe Print", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonbuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonbuscar.Location = new System.Drawing.Point(248, 97);
            this.buttonbuscar.Name = "buttonbuscar";
            this.buttonbuscar.Size = new System.Drawing.Size(251, 42);
            this.buttonbuscar.TabIndex = 16;
            this.buttonbuscar.Text = "BUSCAR POR ID";
            this.buttonbuscar.UseVisualStyleBackColor = false;
            this.buttonbuscar.Click += new System.EventHandler(this.buttonbuscar_Click);
            // 
            // textBoxbusc
            // 
            this.textBoxbusc.Location = new System.Drawing.Point(282, 145);
            this.textBoxbusc.Name = "textBoxbusc";
            this.textBoxbusc.Size = new System.Drawing.Size(183, 20);
            this.textBoxbusc.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 46);
            this.label1.TabIndex = 18;
            this.label1.Text = "PLANTILLA FC BARCELONA 2021-2022";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(749, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(334, 177);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 450);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(590, 287);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1129, 749);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxbusc);
            this.Controls.Add(this.buttonbuscar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.buttonnuevo);
            this.Controls.Add(this.buttondatos);
            this.Controls.Add(this.dataGridViewdatos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewdatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewdatos;
        private System.Windows.Forms.Button buttondatos;
        private System.Windows.Forms.Button buttonnuevo;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.Button buttonbuscar;
        private System.Windows.Forms.TextBox textBoxbusc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

