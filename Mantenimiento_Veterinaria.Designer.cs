namespace T2_FUNPRO
{
    partial class Mantenimiento_Veterinaria
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
            this.label1 = new System.Windows.Forms.Label();
            this.lsb_dueño = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_nomape = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_registrar_m = new System.Windows.Forms.Button();
            this.btn_buscar_m = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.data_mascota = new System.Windows.Forms.DataGridView();
            this.txt_mascota_b = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_dueño = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_limpiar_m = new System.Windows.Forms.Button();
            this.txt_raza_m = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_edad_m = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nom_mas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mascota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Dueño";
            // 
            // lsb_dueño
            // 
            this.lsb_dueño.FormattingEnabled = true;
            this.lsb_dueño.ItemHeight = 20;
            this.lsb_dueño.Location = new System.Drawing.Point(617, 63);
            this.lsb_dueño.Name = "lsb_dueño";
            this.lsb_dueño.Size = new System.Drawing.Size(494, 144);
            this.lsb_dueño.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btn_limpiar);
            this.groupBox1.Controls.Add(this.lsb_dueño);
            this.groupBox1.Controls.Add(this.btn_registrar);
            this.groupBox1.Controls.Add(this.txt_telefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_nomape);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(85, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1178, 228);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dueño";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(612, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 26);
            this.label12.TabIndex = 9;
            this.label12.Text = "Lista de Dueños Registrados";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(186, 171);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(125, 37);
            this.btn_limpiar.TabIndex = 8;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(47, 171);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(125, 37);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_telefono
            // 
            this.txt_telefono.Location = new System.Drawing.Point(160, 127);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(151, 26);
            this.txt_telefono.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono";
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(160, 95);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(207, 26);
            this.txt_direccion.TabIndex = 6;
            // 
            // txt_nomape
            // 
            this.txt_nomape.Location = new System.Drawing.Point(160, 63);
            this.txt_nomape.Name = "txt_nomape";
            this.txt_nomape.Size = new System.Drawing.Size(255, 26);
            this.txt_nomape.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dirección";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre y Apellidos";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.btn_registrar_m);
            this.groupBox2.Controls.Add(this.btn_buscar_m);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.data_mascota);
            this.groupBox2.Controls.Add(this.txt_mascota_b);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cbo_dueño);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.btn_limpiar_m);
            this.groupBox2.Controls.Add(this.txt_raza_m);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_edad_m);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_nom_mas);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(85, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1178, 289);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mascota";
            // 
            // btn_registrar_m
            // 
            this.btn_registrar_m.Location = new System.Drawing.Point(47, 201);
            this.btn_registrar_m.Name = "btn_registrar_m";
            this.btn_registrar_m.Size = new System.Drawing.Size(125, 37);
            this.btn_registrar_m.TabIndex = 17;
            this.btn_registrar_m.Text = "Registrar";
            this.btn_registrar_m.UseVisualStyleBackColor = true;
            this.btn_registrar_m.Click += new System.EventHandler(this.btn_registrar_m_Click);
            // 
            // btn_buscar_m
            // 
            this.btn_buscar_m.Location = new System.Drawing.Point(982, 54);
            this.btn_buscar_m.Name = "btn_buscar_m";
            this.btn_buscar_m.Size = new System.Drawing.Size(103, 32);
            this.btn_buscar_m.TabIndex = 16;
            this.btn_buscar_m.Text = "Buscar";
            this.btn_buscar_m.UseVisualStyleBackColor = true;
            this.btn_buscar_m.Click += new System.EventHandler(this.btn_buscar_m_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(764, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Buscar Mascota";
            // 
            // data_mascota
            // 
            this.data_mascota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_mascota.Location = new System.Drawing.Point(486, 95);
            this.data_mascota.Name = "data_mascota";
            this.data_mascota.RowHeadersWidth = 62;
            this.data_mascota.RowTemplate.Height = 28;
            this.data_mascota.Size = new System.Drawing.Size(686, 180);
            this.data_mascota.TabIndex = 14;
            // 
            // txt_mascota_b
            // 
            this.txt_mascota_b.Location = new System.Drawing.Point(750, 57);
            this.txt_mascota_b.Name = "txt_mascota_b";
            this.txt_mascota_b.Size = new System.Drawing.Size(215, 26);
            this.txt_mascota_b.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Nombre Mascota";
            // 
            // cbo_dueño
            // 
            this.cbo_dueño.FormattingEnabled = true;
            this.cbo_dueño.Location = new System.Drawing.Point(160, 163);
            this.cbo_dueño.Name = "cbo_dueño";
            this.cbo_dueño.Size = new System.Drawing.Size(214, 28);
            this.cbo_dueño.TabIndex = 10;
            this.cbo_dueño.Text = "-- Seleccione Dueño --";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Dueño";
            // 
            // btn_limpiar_m
            // 
            this.btn_limpiar_m.Location = new System.Drawing.Point(186, 201);
            this.btn_limpiar_m.Name = "btn_limpiar_m";
            this.btn_limpiar_m.Size = new System.Drawing.Size(125, 37);
            this.btn_limpiar_m.TabIndex = 8;
            this.btn_limpiar_m.Text = "Limpiar";
            this.btn_limpiar_m.UseVisualStyleBackColor = true;
            this.btn_limpiar_m.Click += new System.EventHandler(this.btn_limpiar_m_Click);
            // 
            // txt_raza_m
            // 
            this.txt_raza_m.Location = new System.Drawing.Point(160, 127);
            this.txt_raza_m.Name = "txt_raza_m";
            this.txt_raza_m.Size = new System.Drawing.Size(151, 26);
            this.txt_raza_m.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Raza";
            // 
            // txt_edad_m
            // 
            this.txt_edad_m.Location = new System.Drawing.Point(160, 95);
            this.txt_edad_m.Name = "txt_edad_m";
            this.txt_edad_m.Size = new System.Drawing.Size(207, 26);
            this.txt_edad_m.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Registrar Mascota";
            // 
            // txt_nom_mas
            // 
            this.txt_nom_mas.Location = new System.Drawing.Point(160, 63);
            this.txt_nom_mas.Name = "txt_nom_mas";
            this.txt_nom_mas.Size = new System.Drawing.Size(255, 26);
            this.txt_nom_mas.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Edad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre Mascota";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::T2_FUNPRO.Properties.Resources.hacer_frente_urgencias_veterinarias;
            this.pictureBox1.Location = new System.Drawing.Point(340, 571);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Mantenimiento_Veterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mantenimiento_Veterinaria";
            this.Text = "Mantenimiento Veterinaria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Mantenimiento_Veterinaria_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_mascota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsb_dueño;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_nomape;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_dueño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_limpiar_m;
        private System.Windows.Forms.TextBox txt_raza_m;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_edad_m;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nom_mas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView data_mascota;
        private System.Windows.Forms.TextBox txt_mascota_b;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_buscar_m;
        private System.Windows.Forms.Button btn_registrar_m;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}