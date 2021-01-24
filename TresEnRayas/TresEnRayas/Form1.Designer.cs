
namespace TresEnRayas
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
            this.ControlTablero = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picGanador = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.j1Nombre = new System.Windows.Forms.TextBox();
            this.j2Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.j2Humano = new System.Windows.Forms.RadioButton();
            this.j2Cpu = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlTablero
            // 
            this.ControlTablero.BackColor = System.Drawing.Color.Transparent;
            this.ControlTablero.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.ControlTablero.ColumnCount = 3;
            this.ControlTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ControlTablero.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ControlTablero.ForeColor = System.Drawing.Color.Red;
            this.ControlTablero.Location = new System.Drawing.Point(36, 36);
            this.ControlTablero.Name = "ControlTablero";
            this.ControlTablero.RowCount = 3;
            this.ControlTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlTablero.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ControlTablero.Size = new System.Drawing.Size(413, 394);
            this.ControlTablero.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(639, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // picGanador
            // 
            this.picGanador.BackColor = System.Drawing.Color.Transparent;
            this.picGanador.Image = ((System.Drawing.Image)(resources.GetObject("picGanador.Image")));
            this.picGanador.Location = new System.Drawing.Point(497, 164);
            this.picGanador.Name = "picGanador";
            this.picGanador.Size = new System.Drawing.Size(270, 270);
            this.picGanador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGanador.TabIndex = 3;
            this.picGanador.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nueva partida";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // j1Nombre
            // 
            this.j1Nombre.Location = new System.Drawing.Point(498, 128);
            this.j1Nombre.Name = "j1Nombre";
            this.j1Nombre.Size = new System.Drawing.Size(125, 27);
            this.j1Nombre.TabIndex = 5;
            // 
            // j2Nombre
            // 
            this.j2Nombre.Location = new System.Drawing.Point(639, 128);
            this.j2Nombre.Name = "j2Nombre";
            this.j2Nombre.Size = new System.Drawing.Size(125, 27);
            this.j2Nombre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Es el turno de:";
            this.label1.Visible = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(140, 9);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(0, 20);
            this.lblTurno.TabIndex = 8;
            this.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTurno.Visible = false;
            // 
            // j2Humano
            // 
            this.j2Humano.AutoSize = true;
            this.j2Humano.Checked = true;
            this.j2Humano.Location = new System.Drawing.Point(780, 24);
            this.j2Humano.Name = "j2Humano";
            this.j2Humano.Size = new System.Drawing.Size(87, 24);
            this.j2Humano.TabIndex = 9;
            this.j2Humano.TabStop = true;
            this.j2Humano.Text = "Humano";
            this.j2Humano.UseVisualStyleBackColor = true;
            // 
            // j2Cpu
            // 
            this.j2Cpu.AutoSize = true;
            this.j2Cpu.Location = new System.Drawing.Point(780, 49);
            this.j2Cpu.Name = "j2Cpu";
            this.j2Cpu.Size = new System.Drawing.Size(57, 24);
            this.j2Cpu.TabIndex = 10;
            this.j2Cpu.Text = "CPU";
            this.j2Cpu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(770, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Jugador 2 es:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 478);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.j2Cpu);
            this.Controls.Add(this.j2Humano);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.j2Nombre);
            this.Controls.Add(this.j1Nombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGanador);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ControlTablero);
            this.Name = "Form1";
            this.Text = "Tres en rayas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ControlTablero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picGanador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox j1Nombre;
        private System.Windows.Forms.TextBox j2Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.RadioButton j2Humano;
        private System.Windows.Forms.RadioButton j2Cpu;
        private System.Windows.Forms.Label label2;
    }
}

