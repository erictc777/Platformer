namespace Juego
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.pbCancha = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(334, 616);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(75, 23);
            this.BotonSalir.TabIndex = 0;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // pbCancha
            // 
            this.pbCancha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbCancha.Location = new System.Drawing.Point(10, 7);
            this.pbCancha.Name = "pbCancha";
            this.pbCancha.Size = new System.Drawing.Size(398, 607);
            this.pbCancha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCancha.TabIndex = 1;
            this.pbCancha.TabStop = false;
            this.pbCancha.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCancha_Paint);
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 618);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 26);
            this.label2.TabIndex = 3;
            // 
            // puntos
            // 
            this.puntos.AutoSize = true;
            this.puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntos.Location = new System.Drawing.Point(9, 621);
            this.puntos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(60, 24);
            this.puntos.TabIndex = 4;
            this.puntos.Text = "label3";
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(419, 651);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbCancha);
            this.Controls.Add(this.BotonSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCancha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.PictureBox pbCancha;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label puntos;
    }
}

