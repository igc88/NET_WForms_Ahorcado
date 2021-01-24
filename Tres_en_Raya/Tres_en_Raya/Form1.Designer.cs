
namespace Tres_en_Raya
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
            this.juego = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.newgame = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nombreJ1 = new System.Windows.Forms.TextBox();
            this.nJ1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cpuJ2 = new System.Windows.Forms.RadioButton();
            this.humanoJ2 = new System.Windows.Forms.RadioButton();
            this.nombreJ2 = new System.Windows.Forms.TextBox();
            this.tipoJ2 = new System.Windows.Forms.Label();
            this.nJ2 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.juego.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // juego
            // 
            this.juego.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.juego.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.juego.ColumnCount = 3;
            this.juego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.juego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.juego.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.juego.Controls.Add(this.button9, 2, 2);
            this.juego.Controls.Add(this.button8, 1, 2);
            this.juego.Controls.Add(this.button7, 0, 2);
            this.juego.Controls.Add(this.button6, 2, 1);
            this.juego.Controls.Add(this.button5, 1, 1);
            this.juego.Controls.Add(this.button4, 0, 1);
            this.juego.Controls.Add(this.button3, 2, 0);
            this.juego.Controls.Add(this.button2, 1, 0);
            this.juego.Controls.Add(this.button1, 0, 0);
            this.juego.Location = new System.Drawing.Point(12, 12);
            this.juego.Name = "juego";
            this.juego.RowCount = 3;
            this.juego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.39853F));
            this.juego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.60147F));
            this.juego.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.juego.Size = new System.Drawing.Size(391, 405);
            this.juego.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(258, 277);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(126, 122);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.press);
            this.button9.MouseEnter += new System.EventHandler(this.bEnter);
            this.button9.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(127, 277);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 122);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.press);
            this.button8.MouseEnter += new System.EventHandler(this.bEnter);
            this.button8.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(6, 277);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 122);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.press);
            this.button7.MouseEnter += new System.EventHandler(this.bEnter);
            this.button7.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(258, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 120);
            this.button6.TabIndex = 5;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.press);
            this.button6.MouseEnter += new System.EventHandler(this.bEnter);
            this.button6.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(127, 148);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 120);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.press);
            this.button5.MouseEnter += new System.EventHandler(this.bEnter);
            this.button5.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(6, 148);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 120);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.press);
            this.button4.MouseEnter += new System.EventHandler(this.bEnter);
            this.button4.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(258, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 133);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.press);
            this.button3.MouseEnter += new System.EventHandler(this.bEnter);
            this.button3.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(127, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 133);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.press);
            this.button2.MouseEnter += new System.EventHandler(this.bEnter);
            this.button2.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 133);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.press);
            this.button1.MouseEnter += new System.EventHandler(this.bEnter);
            this.button1.MouseLeave += new System.EventHandler(this.bLeave);
            // 
            // newgame
            // 
            this.newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newgame.Image = ((System.Drawing.Image)(resources.GetObject("newgame.Image")));
            this.newgame.Location = new System.Drawing.Point(436, 12);
            this.newgame.Name = "newgame";
            this.newgame.Size = new System.Drawing.Size(309, 103);
            this.newgame.TabIndex = 3;
            this.newgame.Text = "New Game";
            this.newgame.UseVisualStyleBackColor = true;
            this.newgame.Click += new System.EventHandler(this.newgame_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nombreJ1);
            this.panel1.Controls.Add(this.nJ1);
            this.panel1.Controls.Add(this.p1);
            this.panel1.Location = new System.Drawing.Point(436, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 80);
            this.panel1.TabIndex = 4;
            // 
            // nombreJ1
            // 
            this.nombreJ1.Location = new System.Drawing.Point(78, 43);
            this.nombreJ1.Name = "nombreJ1";
            this.nombreJ1.Size = new System.Drawing.Size(169, 20);
            this.nombreJ1.TabIndex = 3;
            // 
            // nJ1
            // 
            this.nJ1.AutoSize = true;
            this.nJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nJ1.Location = new System.Drawing.Point(3, 48);
            this.nJ1.Name = "nJ1";
            this.nJ1.Size = new System.Drawing.Size(66, 15);
            this.nJ1.TabIndex = 1;
            this.nJ1.Text = "Nombre: ";
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1.ForeColor = System.Drawing.Color.Maroon;
            this.p1.Location = new System.Drawing.Point(3, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(79, 18);
            this.p1.TabIndex = 0;
            this.p1.Text = "Jugador 1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cpuJ2);
            this.panel2.Controls.Add(this.humanoJ2);
            this.panel2.Controls.Add(this.nombreJ2);
            this.panel2.Controls.Add(this.tipoJ2);
            this.panel2.Controls.Add(this.nJ2);
            this.panel2.Controls.Add(this.p2);
            this.panel2.Location = new System.Drawing.Point(436, 295);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 122);
            this.panel2.TabIndex = 5;
            // 
            // cpuJ2
            // 
            this.cpuJ2.AutoSize = true;
            this.cpuJ2.Location = new System.Drawing.Point(200, 87);
            this.cpuJ2.Name = "cpuJ2";
            this.cpuJ2.Size = new System.Drawing.Size(47, 17);
            this.cpuJ2.TabIndex = 5;
            this.cpuJ2.TabStop = true;
            this.cpuJ2.Text = "CPU";
            this.cpuJ2.UseVisualStyleBackColor = true;
            this.cpuJ2.Click += new System.EventHandler(this.cpu);
            // 
            // humanoJ2
            // 
            this.humanoJ2.AutoSize = true;
            this.humanoJ2.Location = new System.Drawing.Point(108, 87);
            this.humanoJ2.Name = "humanoJ2";
            this.humanoJ2.Size = new System.Drawing.Size(65, 17);
            this.humanoJ2.TabIndex = 4;
            this.humanoJ2.TabStop = true;
            this.humanoJ2.Text = "Humano";
            this.humanoJ2.UseVisualStyleBackColor = true;
            // 
            // nombreJ2
            // 
            this.nombreJ2.Location = new System.Drawing.Point(78, 37);
            this.nombreJ2.Name = "nombreJ2";
            this.nombreJ2.Size = new System.Drawing.Size(169, 20);
            this.nombreJ2.TabIndex = 3;
            // 
            // tipoJ2
            // 
            this.tipoJ2.AutoSize = true;
            this.tipoJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoJ2.Location = new System.Drawing.Point(49, 87);
            this.tipoJ2.Name = "tipoJ2";
            this.tipoJ2.Size = new System.Drawing.Size(39, 15);
            this.tipoJ2.TabIndex = 2;
            this.tipoJ2.Text = "Tipo:";
            // 
            // nJ2
            // 
            this.nJ2.AutoSize = true;
            this.nJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nJ2.Location = new System.Drawing.Point(10, 42);
            this.nJ2.Name = "nJ2";
            this.nJ2.Size = new System.Drawing.Size(62, 15);
            this.nJ2.TabIndex = 1;
            this.nJ2.Text = "Nombre:";
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2.ForeColor = System.Drawing.Color.Maroon;
            this.p2.Location = new System.Drawing.Point(9, 3);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(79, 18);
            this.p2.TabIndex = 0;
            this.p2.Text = "Jugador 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Le toca a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(530, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 432);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.newgame);
            this.Controls.Add(this.juego);
            this.Name = "Form1";
            this.Text = "Tres en Raya \\\\VIIKSEN//";
            this.juego.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel juego;
        private System.Windows.Forms.Button newgame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label nJ1;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label nJ2;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.TextBox nombreJ1;
        private System.Windows.Forms.Label tipoJ2;
        private System.Windows.Forms.RadioButton cpuJ2;
        private System.Windows.Forms.RadioButton humanoJ2;
        private System.Windows.Forms.TextBox nombreJ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

