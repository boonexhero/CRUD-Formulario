namespace Ejercicio_2
{
    partial class Mantenimiento_Numeros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Numeros));
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.btn_agregar_n = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_or_as = new System.Windows.Forms.Button();
            this.btn_or_des = new System.Windows.Forms.Button();
            this.btn_busca_n = new System.Windows.Forms.Button();
            this.btn_eliminar_b = new System.Windows.Forms.Button();
            this.txt_buscar_n = new System.Windows.Forms.TextBox();
            this.lsb_num = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(201, 84);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(177, 26);
            this.txtnumero.TabIndex = 1;
            // 
            // btn_agregar_n
            // 
            this.btn_agregar_n.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_agregar_n.Location = new System.Drawing.Point(395, 81);
            this.btn_agregar_n.Name = "btn_agregar_n";
            this.btn_agregar_n.Size = new System.Drawing.Size(153, 36);
            this.btn_agregar_n.TabIndex = 2;
            this.btn_agregar_n.Text = "Agregar";
            this.btn_agregar_n.UseVisualStyleBackColor = false;
            this.btn_agregar_n.Click += new System.EventHandler(this.btn_agregar_n_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese Numeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "MANTENIMIENTO NÚMEROS";
            // 
            // btn_or_as
            // 
            this.btn_or_as.BackColor = System.Drawing.Color.Red;
            this.btn_or_as.Location = new System.Drawing.Point(12, 137);
            this.btn_or_as.Name = "btn_or_as";
            this.btn_or_as.Size = new System.Drawing.Size(246, 40);
            this.btn_or_as.TabIndex = 5;
            this.btn_or_as.Text = "Ordenar Ascendente";
            this.btn_or_as.UseVisualStyleBackColor = false;
            this.btn_or_as.Click += new System.EventHandler(this.btn_or_as_Click);
            // 
            // btn_or_des
            // 
            this.btn_or_des.BackColor = System.Drawing.Color.Lime;
            this.btn_or_des.Location = new System.Drawing.Point(278, 137);
            this.btn_or_des.Name = "btn_or_des";
            this.btn_or_des.Size = new System.Drawing.Size(285, 40);
            this.btn_or_des.TabIndex = 6;
            this.btn_or_des.Text = "Ordenar Descendente";
            this.btn_or_des.UseVisualStyleBackColor = false;
            this.btn_or_des.Click += new System.EventHandler(this.btn_or_des_Click);
            // 
            // btn_busca_n
            // 
            this.btn_busca_n.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_busca_n.Location = new System.Drawing.Point(849, 102);
            this.btn_busca_n.Name = "btn_busca_n";
            this.btn_busca_n.Size = new System.Drawing.Size(191, 44);
            this.btn_busca_n.TabIndex = 7;
            this.btn_busca_n.Text = "Buscar Número";
            this.btn_busca_n.UseVisualStyleBackColor = false;
            this.btn_busca_n.Click += new System.EventHandler(this.btn_busca_n_Click);
            // 
            // btn_eliminar_b
            // 
            this.btn_eliminar_b.BackColor = System.Drawing.SystemColors.Info;
            this.btn_eliminar_b.Location = new System.Drawing.Point(849, 152);
            this.btn_eliminar_b.Name = "btn_eliminar_b";
            this.btn_eliminar_b.Size = new System.Drawing.Size(191, 40);
            this.btn_eliminar_b.TabIndex = 8;
            this.btn_eliminar_b.Text = "Eliminar Número";
            this.btn_eliminar_b.UseVisualStyleBackColor = false;
            this.btn_eliminar_b.Click += new System.EventHandler(this.btn_eliminar_b_Click);
            // 
            // txt_buscar_n
            // 
            this.txt_buscar_n.Location = new System.Drawing.Point(849, 70);
            this.txt_buscar_n.Name = "txt_buscar_n";
            this.txt_buscar_n.Size = new System.Drawing.Size(191, 26);
            this.txt_buscar_n.TabIndex = 9;
            // 
            // lsb_num
            // 
            this.lsb_num.FormattingEnabled = true;
            this.lsb_num.ItemHeight = 20;
            this.lsb_num.Location = new System.Drawing.Point(408, 217);
            this.lsb_num.Name = "lsb_num";
            this.lsb_num.Size = new System.Drawing.Size(493, 204);
            this.lsb_num.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(812, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ingrese Numero para Buscar / Eliminar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 196);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(920, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 187);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Mantenimiento_Numeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1217, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsb_num);
            this.Controls.Add(this.txt_buscar_n);
            this.Controls.Add(this.btn_eliminar_b);
            this.Controls.Add(this.btn_busca_n);
            this.Controls.Add(this.btn_or_des);
            this.Controls.Add(this.btn_or_as);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_agregar_n);
            this.Controls.Add(this.txtnumero);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Mantenimiento_Numeros";
            this.Text = "Numero Ordenar - Buscar - Eliminar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Button btn_agregar_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_or_as;
        private System.Windows.Forms.Button btn_or_des;
        private System.Windows.Forms.Button btn_busca_n;
        private System.Windows.Forms.Button btn_eliminar_b;
        private System.Windows.Forms.TextBox txt_buscar_n;
        private System.Windows.Forms.ListBox lsb_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

