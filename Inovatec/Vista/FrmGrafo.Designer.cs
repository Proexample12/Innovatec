namespace Inovatec.Vista
{
    partial class FrmGrafo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Conexid = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEdificio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbA = new System.Windows.Forms.ComboBox();
            this.cbB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lbEdificios = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.btnBuscarRuta = new System.Windows.Forms.Button();
            this.lbRuta = new System.Windows.Forms.ListBox();
            this.lbConexiones = new System.Windows.Forms.ListBox();
            this.btnConexidad = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Conexid.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.tbEdificio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(30, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Edificio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRuta);
            this.groupBox2.Controls.Add(this.btnBuscarRuta);
            this.groupBox2.Controls.Add(this.cbDestino);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbOrigen);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(423, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Ruta";
            // 
            // Conexid
            // 
            this.Conexid.Controls.Add(this.btnConexidad);
            this.Conexid.Location = new System.Drawing.Point(423, 332);
            this.Conexid.Name = "Conexid";
            this.Conexid.Size = new System.Drawing.Size(215, 103);
            this.Conexid.TabIndex = 2;
            this.Conexid.TabStop = false;
            this.Conexid.Text = "Conexidad";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnConectar);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cbB);
            this.groupBox4.Controls.Add(this.cbA);
            this.groupBox4.Location = new System.Drawing.Point(12, 150);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(342, 99);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar Conexion";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbEdificios);
            this.groupBox5.Location = new System.Drawing.Point(12, 255);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(342, 391);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edificios";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbConexiones);
            this.groupBox6.Location = new System.Drawing.Point(703, 311);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 331);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Conexiones (Adyacencias)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(347, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sistema de rutas del parque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            // 
            // tbEdificio
            // 
            this.tbEdificio.Location = new System.Drawing.Point(78, 30);
            this.tbEdificio.Name = "tbEdificio";
            this.tbEdificio.Size = new System.Drawing.Size(220, 22);
            this.tbEdificio.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(196, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(82, 36);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cbA
            // 
            this.cbA.FormattingEnabled = true;
            this.cbA.Location = new System.Drawing.Point(28, 22);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(121, 24);
            this.cbA.TabIndex = 0;
            // 
            // cbB
            // 
            this.cbB.FormattingEnabled = true;
            this.cbB.Location = new System.Drawing.Point(186, 22);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(130, 24);
            this.cbB.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "A;";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "B:";
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(114, 57);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(82, 36);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // lbEdificios
            // 
            this.lbEdificios.FormattingEnabled = true;
            this.lbEdificios.ItemHeight = 16;
            this.lbEdificios.Location = new System.Drawing.Point(9, 22);
            this.lbEdificios.Name = "lbEdificios";
            this.lbEdificios.Size = new System.Drawing.Size(292, 340);
            this.lbEdificios.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Origen";
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(68, 24);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(147, 24);
            this.cbOrigen.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Destino";
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Location = new System.Drawing.Point(280, 24);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(151, 24);
            this.cbDestino.TabIndex = 7;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btnBuscarRuta
            // 
            this.btnBuscarRuta.Location = new System.Drawing.Point(165, 65);
            this.btnBuscarRuta.Name = "btnBuscarRuta";
            this.btnBuscarRuta.Size = new System.Drawing.Size(109, 23);
            this.btnBuscarRuta.TabIndex = 8;
            this.btnBuscarRuta.Text = "Buscar Ruta";
            this.btnBuscarRuta.UseVisualStyleBackColor = true;
            // 
            // lbRuta
            // 
            this.lbRuta.FormattingEnabled = true;
            this.lbRuta.ItemHeight = 16;
            this.lbRuta.Location = new System.Drawing.Point(18, 105);
            this.lbRuta.Name = "lbRuta";
            this.lbRuta.Size = new System.Drawing.Size(400, 148);
            this.lbRuta.TabIndex = 1;
            // 
            // lbConexiones
            // 
            this.lbConexiones.FormattingEnabled = true;
            this.lbConexiones.ItemHeight = 16;
            this.lbConexiones.Location = new System.Drawing.Point(6, 21);
            this.lbConexiones.Name = "lbConexiones";
            this.lbConexiones.Size = new System.Drawing.Size(189, 308);
            this.lbConexiones.TabIndex = 1;
            // 
            // btnConexidad
            // 
            this.btnConexidad.Location = new System.Drawing.Point(18, 21);
            this.btnConexidad.Name = "btnConexidad";
            this.btnConexidad.Size = new System.Drawing.Size(177, 62);
            this.btnConexidad.TabIndex = 1;
            this.btnConexidad.Text = "Validar Conexidad";
            this.btnConexidad.UseVisualStyleBackColor = true;
            // 
            // FrmGrafo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 750);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Conexid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGrafo";
            this.Text = "FrmGrafo";
            this.Load += new System.EventHandler(this.FrmGrafo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Conexid.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox Conexid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEdificio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbB;
        private System.Windows.Forms.ComboBox cbA;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox lbEdificios;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscarRuta;
        private System.Windows.Forms.ListBox lbRuta;
        private System.Windows.Forms.ListBox lbConexiones;
        private System.Windows.Forms.Button btnConexidad;
    }
}