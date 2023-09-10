namespace Pixelia
{
    partial class Passf
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
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.btnrecover = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnregresar = new FontAwesome.Sharp.IconButton();
            this.lblcontra = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(158, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperar Passcode";
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(164, 151);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(343, 32);
            this.txtuser.TabIndex = 1;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(164, 236);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(343, 32);
            this.txtpass.TabIndex = 2;
            this.txtpass.Visible = false;
            // 
            // btnrecover
            // 
            this.btnrecover.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecover.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrecover.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnrecover.IconColor = System.Drawing.Color.MediumSeaGreen;
            this.btnrecover.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnrecover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnrecover.Location = new System.Drawing.Point(164, 313);
            this.btnrecover.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnrecover.Name = "btnrecover";
            this.btnrecover.Size = new System.Drawing.Size(343, 53);
            this.btnrecover.TabIndex = 3;
            this.btnrecover.Text = "Recuperar";
            this.btnrecover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnrecover.UseVisualStyleBackColor = true;
            this.btnrecover.Click += new System.EventHandler(this.btnrecover_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btncancelar.IconColor = System.Drawing.Color.DarkRed;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 30;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(541, 400);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(165, 50);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(36, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(36, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Passcode:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 100);
            this.panel1.TabIndex = 7;
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
            this.btnregresar.Location = new System.Drawing.Point(0, 396);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(211, 54);
            this.btnregresar.TabIndex = 10;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontra.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblcontra.Location = new System.Drawing.Point(538, 200);
            this.lblcontra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(168, 27);
            this.lblcontra.TabIndex = 11;
            this.lblcontra.Text = "No encontrado";
            this.lblcontra.Visible = false;
            // 
            // Passf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.lblcontra);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnrecover);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Passf";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recover";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private FontAwesome.Sharp.IconButton btnrecover;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnregresar;
        private System.Windows.Forms.Label lblcontra;
    }
}