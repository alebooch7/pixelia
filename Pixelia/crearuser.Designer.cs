namespace Pixelia
{
    partial class crearuser
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
            this.btncrear = new FontAwesome.Sharp.IconButton();
            this.btncancelar = new FontAwesome.Sharp.IconButton();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblExist = new System.Windows.Forms.Label();
            this.btnregresar = new FontAwesome.Sharp.IconButton();
            this.lblusecreado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrarse";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncrear
            // 
            this.btncrear.BackColor = System.Drawing.Color.FloralWhite;
            this.btncrear.Font = new System.Drawing.Font("Cambria", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncrear.ForeColor = System.Drawing.Color.DarkCyan;
            this.btncrear.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsBy;
            this.btncrear.IconColor = System.Drawing.Color.YellowGreen;
            this.btncrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncrear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncrear.Location = new System.Drawing.Point(201, 281);
            this.btncrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncrear.Name = "btncrear";
            this.btncrear.Size = new System.Drawing.Size(257, 65);
            this.btncrear.TabIndex = 1;
            this.btncrear.Text = "Crear cuenta";
            this.btncrear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncrear.UseVisualStyleBackColor = false;
            this.btncrear.Click += new System.EventHandler(this.btncrear_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.Beige;
            this.btncancelar.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkBlue;
            this.btncancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btncancelar.IconColor = System.Drawing.Color.DarkRed;
            this.btncancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btncancelar.IconSize = 30;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancelar.Location = new System.Drawing.Point(597, 384);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(188, 54);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // txtuser
            // 
            this.txtuser.Font = new System.Drawing.Font("Candara", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.Location = new System.Drawing.Point(176, 123);
            this.txtuser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(347, 32);
            this.txtuser.TabIndex = 3;
            // 
            // txtpass
            // 
            this.txtpass.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.Location = new System.Drawing.Point(176, 210);
            this.txtpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(347, 32);
            this.txtpass.TabIndex = 4;
            this.txtpass.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(28, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Candara", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.Purple;
            this.Password.Location = new System.Drawing.Point(28, 214);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(106, 28);
            this.Password.TabIndex = 6;
            this.Password.Text = "Passcode:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 100);
            this.panel1.TabIndex = 7;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.MistyRose;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 18;
            this.iconPictureBox2.Location = new System.Drawing.Point(758, 0);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(27, 18);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 18;
            this.iconPictureBox1.Location = new System.Drawing.Point(725, 0);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 18);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblExist
            // 
            this.lblExist.AutoSize = true;
            this.lblExist.Font = new System.Drawing.Font("Calisto MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExist.Location = new System.Drawing.Point(607, 210);
            this.lblExist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExist.Name = "lblExist";
            this.lblExist.Size = new System.Drawing.Size(178, 28);
            this.lblExist.TabIndex = 8;
            this.lblExist.Text = "Usuario ya existe";
            this.lblExist.Visible = false;
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
            this.btnregresar.Location = new System.Drawing.Point(0, 384);
            this.btnregresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(199, 54);
            this.btnregresar.TabIndex = 9;
            this.btnregresar.Text = "Regresar";
            this.btnregresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregresar.UseVisualStyleBackColor = false;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // lblusecreado
            // 
            this.lblusecreado.AutoSize = true;
            this.lblusecreado.Font = new System.Drawing.Font("Calisto MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusecreado.Location = new System.Drawing.Point(620, 210);
            this.lblusecreado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblusecreado.Name = "lblusecreado";
            this.lblusecreado.Size = new System.Drawing.Size(165, 28);
            this.lblusecreado.TabIndex = 10;
            this.lblusecreado.Text = "Usuario Creado";
            this.lblusecreado.Visible = false;
            // 
            // crearuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(785, 438);
            this.Controls.Add(this.lblusecreado);
            this.Controls.Add(this.btnregresar);
            this.Controls.Add(this.lblExist);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btncrear);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "crearuser";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.crearuser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btncrear;
        private FontAwesome.Sharp.IconButton btncancelar;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblExist;
        private FontAwesome.Sharp.IconButton btnregresar;
        private System.Windows.Forms.Label lblusecreado;
    }
}