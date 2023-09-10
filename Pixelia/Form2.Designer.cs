namespace Pixelia
{
    partial class recomendacion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbjuego1 = new System.Windows.Forms.PictureBox();
            this.ptbImagen2 = new System.Windows.Forms.PictureBox();
            this.ptbImagen3 = new System.Windows.Forms.PictureBox();
            this.btnregresar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbjuego1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 100);
            this.panel1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(524, 84);
            this.label3.TabIndex = 35;
            this.label3.Text = "Recomendaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 84);
            this.label2.TabIndex = 33;
            this.label2.Text = "Pixelia";
            // 
            // ptbjuego1
            // 
            this.ptbjuego1.Location = new System.Drawing.Point(40, 119);
            this.ptbjuego1.Name = "ptbjuego1";
            this.ptbjuego1.Size = new System.Drawing.Size(309, 442);
            this.ptbjuego1.TabIndex = 35;
            this.ptbjuego1.TabStop = false;
            this.ptbjuego1.Click += new System.EventHandler(this.ptbjuego1_Click);
            // 
            // ptbImagen2
            // 
            this.ptbImagen2.Location = new System.Drawing.Point(372, 119);
            this.ptbImagen2.Name = "ptbImagen2";
            this.ptbImagen2.Size = new System.Drawing.Size(288, 442);
            this.ptbImagen2.TabIndex = 36;
            this.ptbImagen2.TabStop = false;
            // 
            // ptbImagen3
            // 
            this.ptbImagen3.Location = new System.Drawing.Point(703, 119);
            this.ptbImagen3.Name = "ptbImagen3";
            this.ptbImagen3.Size = new System.Drawing.Size(280, 442);
            this.ptbImagen3.TabIndex = 37;
            this.ptbImagen3.TabStop = false;
            // 
            // btnregresar
            // 
            this.btnregresar.BackColor = System.Drawing.Color.MintCream;
            this.btnregresar.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.ForeColor = System.Drawing.Color.Blue;
            this.btnregresar.IconChar = FontAwesome.Sharp.IconChar.ReplyAll;
            this.btnregresar.IconColor = System.Drawing.Color.DarkSlateBlue;
            this.btnregresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnregresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregresar.Location = new System.Drawing.Point(34, 513);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(211, 54);
            this.btnregresar.TabIndex = 38;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // recomendacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 573);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.ptbImagen3);
            this.Controls.Add(this.ptbImagen2);
            this.Controls.Add(this.ptbjuego1);
            this.Controls.Add(this.panel1);
            this.Name = "recomendacion";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbjuego1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImagen3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbjuego1;
        private System.Windows.Forms.PictureBox ptbImagen2;
        private System.Windows.Forms.PictureBox ptbImagen3;
        private FontAwesome.Sharp.IconButton btnregresar;
    }
}