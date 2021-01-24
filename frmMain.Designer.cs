
namespace Net_TresEnRaya {
    partial class frmMain {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.pnlPuntuaciones = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.pnlJ2 = new System.Windows.Forms.Panel();
            this.rbCPU2 = new System.Windows.Forms.RadioButton();
            this.rbHumano2 = new System.Windows.Forms.RadioButton();
            this.lblTipoJ2 = new System.Windows.Forms.Label();
            this.txtNombreJ2 = new System.Windows.Forms.TextBox();
            this.lblNombreJ2 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.pnlJ1 = new System.Windows.Forms.Panel();
            this.rbCPU1 = new System.Windows.Forms.RadioButton();
            this.rbHumano1 = new System.Windows.Forms.RadioButton();
            this.lblTipoJ1 = new System.Windows.Forms.Label();
            this.txtNombreJ1 = new System.Windows.Forms.TextBox();
            this.lblNombreJ1 = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.panelTablero = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlPuntuaciones.SuspendLayout();
            this.pnlJ2.SuspendLayout();
            this.pnlJ1.SuspendLayout();
            this.panelTablero.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPuntuaciones
            // 
            this.pnlPuntuaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlPuntuaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPuntuaciones.Controls.Add(this.lblMensaje);
            this.pnlPuntuaciones.Controls.Add(this.pnlJ2);
            this.pnlPuntuaciones.Controls.Add(this.pnlJ1);
            this.pnlPuntuaciones.Controls.Add(this.btnJugar);
            this.pnlPuntuaciones.Location = new System.Drawing.Point(412, 12);
            this.pnlPuntuaciones.Name = "pnlPuntuaciones";
            this.pnlPuntuaciones.Size = new System.Drawing.Size(360, 360);
            this.pnlPuntuaciones.TabIndex = 1;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMensaje.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(6, 38);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(315, 14);
            this.lblMensaje.TabIndex = 7;
            this.lblMensaje.Text = "Presione Nueva Partida para empezar a jugar.";
            // 
            // pnlJ2
            // 
            this.pnlJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJ2.Controls.Add(this.rbCPU2);
            this.pnlJ2.Controls.Add(this.rbHumano2);
            this.pnlJ2.Controls.Add(this.lblTipoJ2);
            this.pnlJ2.Controls.Add(this.txtNombreJ2);
            this.pnlJ2.Controls.Add(this.lblNombreJ2);
            this.pnlJ2.Controls.Add(this.lblJ2);
            this.pnlJ2.Location = new System.Drawing.Point(3, 209);
            this.pnlJ2.Name = "pnlJ2";
            this.pnlJ2.Size = new System.Drawing.Size(352, 146);
            this.pnlJ2.TabIndex = 6;
            // 
            // rbCPU2
            // 
            this.rbCPU2.AutoSize = true;
            this.rbCPU2.Location = new System.Drawing.Point(153, 97);
            this.rbCPU2.Name = "rbCPU2";
            this.rbCPU2.Size = new System.Drawing.Size(47, 17);
            this.rbCPU2.TabIndex = 5;
            this.rbCPU2.TabStop = true;
            this.rbCPU2.Text = "CPU";
            this.rbCPU2.UseVisualStyleBackColor = true;
            // 
            // rbHumano2
            // 
            this.rbHumano2.AutoSize = true;
            this.rbHumano2.Location = new System.Drawing.Point(59, 97);
            this.rbHumano2.Name = "rbHumano2";
            this.rbHumano2.Size = new System.Drawing.Size(65, 17);
            this.rbHumano2.TabIndex = 4;
            this.rbHumano2.TabStop = true;
            this.rbHumano2.Text = "Humano";
            this.rbHumano2.UseVisualStyleBackColor = true;
            // 
            // lblTipoJ2
            // 
            this.lblTipoJ2.AutoSize = true;
            this.lblTipoJ2.Location = new System.Drawing.Point(3, 99);
            this.lblTipoJ2.Name = "lblTipoJ2";
            this.lblTipoJ2.Size = new System.Drawing.Size(34, 13);
            this.lblTipoJ2.TabIndex = 3;
            this.lblTipoJ2.Text = "Tipo: ";
            // 
            // txtNombreJ2
            // 
            this.txtNombreJ2.Location = new System.Drawing.Point(59, 45);
            this.txtNombreJ2.Name = "txtNombreJ2";
            this.txtNombreJ2.Size = new System.Drawing.Size(288, 20);
            this.txtNombreJ2.TabIndex = 2;
            this.txtNombreJ2.Text = "Pepe";
            // 
            // lblNombreJ2
            // 
            this.lblNombreJ2.AutoSize = true;
            this.lblNombreJ2.Location = new System.Drawing.Point(3, 48);
            this.lblNombreJ2.Name = "lblNombreJ2";
            this.lblNombreJ2.Size = new System.Drawing.Size(50, 13);
            this.lblNombreJ2.TabIndex = 1;
            this.lblNombreJ2.Text = "Nombre: ";
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.Location = new System.Drawing.Point(3, 9);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(54, 13);
            this.lblJ2.TabIndex = 0;
            this.lblJ2.Text = "Jugador 2";
            // 
            // pnlJ1
            // 
            this.pnlJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJ1.Controls.Add(this.rbCPU1);
            this.pnlJ1.Controls.Add(this.rbHumano1);
            this.pnlJ1.Controls.Add(this.lblTipoJ1);
            this.pnlJ1.Controls.Add(this.txtNombreJ1);
            this.pnlJ1.Controls.Add(this.lblNombreJ1);
            this.pnlJ1.Controls.Add(this.lblJ1);
            this.pnlJ1.Location = new System.Drawing.Point(3, 57);
            this.pnlJ1.Name = "pnlJ1";
            this.pnlJ1.Size = new System.Drawing.Size(352, 146);
            this.pnlJ1.TabIndex = 1;
            // 
            // rbCPU1
            // 
            this.rbCPU1.AutoSize = true;
            this.rbCPU1.Location = new System.Drawing.Point(153, 97);
            this.rbCPU1.Name = "rbCPU1";
            this.rbCPU1.Size = new System.Drawing.Size(47, 17);
            this.rbCPU1.TabIndex = 5;
            this.rbCPU1.TabStop = true;
            this.rbCPU1.Text = "CPU";
            this.rbCPU1.UseVisualStyleBackColor = true;
            // 
            // rbHumano1
            // 
            this.rbHumano1.AutoSize = true;
            this.rbHumano1.Location = new System.Drawing.Point(59, 97);
            this.rbHumano1.Name = "rbHumano1";
            this.rbHumano1.Size = new System.Drawing.Size(65, 17);
            this.rbHumano1.TabIndex = 4;
            this.rbHumano1.TabStop = true;
            this.rbHumano1.Text = "Humano";
            this.rbHumano1.UseVisualStyleBackColor = true;
            // 
            // lblTipoJ1
            // 
            this.lblTipoJ1.AutoSize = true;
            this.lblTipoJ1.Location = new System.Drawing.Point(3, 99);
            this.lblTipoJ1.Name = "lblTipoJ1";
            this.lblTipoJ1.Size = new System.Drawing.Size(34, 13);
            this.lblTipoJ1.TabIndex = 3;
            this.lblTipoJ1.Text = "Tipo: ";
            // 
            // txtNombreJ1
            // 
            this.txtNombreJ1.Location = new System.Drawing.Point(59, 45);
            this.txtNombreJ1.Name = "txtNombreJ1";
            this.txtNombreJ1.Size = new System.Drawing.Size(288, 20);
            this.txtNombreJ1.TabIndex = 2;
            this.txtNombreJ1.Text = "Iago";
            // 
            // lblNombreJ1
            // 
            this.lblNombreJ1.AutoSize = true;
            this.lblNombreJ1.Location = new System.Drawing.Point(3, 48);
            this.lblNombreJ1.Name = "lblNombreJ1";
            this.lblNombreJ1.Size = new System.Drawing.Size(50, 13);
            this.lblNombreJ1.TabIndex = 1;
            this.lblNombreJ1.Text = "Nombre: ";
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.Location = new System.Drawing.Point(3, 9);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(54, 13);
            this.lblJ1.TabIndex = 0;
            this.lblJ1.Text = "Jugador 1";
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(140, 3);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(91, 23);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Nueva partida";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // panelTablero
            // 
            this.panelTablero.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.panelTablero.ColumnCount = 3;
            this.panelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.panelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.panelTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.panelTablero.Controls.Add(this.label9, 2, 2);
            this.panelTablero.Controls.Add(this.label1, 0, 0);
            this.panelTablero.Controls.Add(this.label8, 1, 2);
            this.panelTablero.Controls.Add(this.label2, 1, 0);
            this.panelTablero.Controls.Add(this.label3, 2, 0);
            this.panelTablero.Controls.Add(this.label7, 0, 2);
            this.panelTablero.Controls.Add(this.label4, 0, 1);
            this.panelTablero.Controls.Add(this.label6, 2, 1);
            this.panelTablero.Controls.Add(this.label5, 1, 1);
            this.panelTablero.Location = new System.Drawing.Point(12, 12);
            this.panelTablero.Name = "panelTablero";
            this.panelTablero.RowCount = 3;
            this.panelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.panelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.panelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124F));
            this.panelTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelTablero.Size = new System.Drawing.Size(360, 360);
            this.panelTablero.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 117);
            this.label9.TabIndex = 7;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.Jugar);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 117);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Jugar);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(125, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 117);
            this.label8.TabIndex = 6;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.Jugar);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 117);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Jugar);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 117);
            this.label3.TabIndex = 2;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.Jugar);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 117);
            this.label7.TabIndex = 5;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.Jugar);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 117);
            this.label4.TabIndex = 3;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.Jugar);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(243, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 117);
            this.label6.TabIndex = 4;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.Jugar);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(125, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 117);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.Jugar);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 381);
            this.Controls.Add(this.panelTablero);
            this.Controls.Add(this.pnlPuntuaciones);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 420);
            this.Name = "frmMain";
            this.Text = "Tres en Raya";
            this.pnlPuntuaciones.ResumeLayout(false);
            this.pnlPuntuaciones.PerformLayout();
            this.pnlJ2.ResumeLayout(false);
            this.pnlJ2.PerformLayout();
            this.pnlJ1.ResumeLayout(false);
            this.pnlJ1.PerformLayout();
            this.panelTablero.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlPuntuaciones;
        private System.Windows.Forms.TableLayoutPanel panelTablero;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Panel pnlJ1;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblNombreJ1;
        private System.Windows.Forms.TextBox txtNombreJ1;
        private System.Windows.Forms.Label lblTipoJ1;
        private System.Windows.Forms.RadioButton rbHumano1;
        private System.Windows.Forms.RadioButton rbCPU1;
        private System.Windows.Forms.Panel pnlJ2;
        private System.Windows.Forms.RadioButton rbCPU2;
        private System.Windows.Forms.RadioButton rbHumano2;
        private System.Windows.Forms.Label lblTipoJ2;
        private System.Windows.Forms.TextBox txtNombreJ2;
        private System.Windows.Forms.Label lblNombreJ2;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

