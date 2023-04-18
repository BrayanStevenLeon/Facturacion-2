namespace Facturacion
{
    partial class Login
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_acceder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Facturacion.Properties.Resources.jeans_removebg_preview__1_;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 330);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.Location = new System.Drawing.Point(329, 80);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(368, 20);
            this.txt_usuario.TabIndex = 1;
            this.txt_usuario.Text = "USUARIO";
            this.txt_usuario.Enter += new System.EventHandler(this.txt_usuario_Enter);
            this.txt_usuario.Leave += new System.EventHandler(this.txt_usuario_Leave);
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña.Location = new System.Drawing.Point(329, 142);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Size = new System.Drawing.Size(368, 20);
            this.txt_contraseña.TabIndex = 2;
            this.txt_contraseña.Text = "CONTRASEÑA";
            this.txt_contraseña.Enter += new System.EventHandler(this.txt_contraseña_Enter);
            this.txt_contraseña.Leave += new System.EventHandler(this.txt_contraseña_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Image = global::Facturacion.Properties.Resources.icons8_cerrar_ventana_501;
            this.btn_cerrar.Location = new System.Drawing.Point(753, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(15, 15);
            this.btn_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_cerrar.TabIndex = 5;
            this.btn_cerrar.TabStop = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_acceder
            // 
            this.btn_acceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_acceder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acceder.FlatAppearance.BorderSize = 0;
            this.btn_acceder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_acceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acceder.Location = new System.Drawing.Point(329, 221);
            this.btn_acceder.Name = "btn_acceder";
            this.btn_acceder.Size = new System.Drawing.Size(408, 40);
            this.btn_acceder.TabIndex = 3;
            this.btn_acceder.Text = "ACCEDER";
            this.btn_acceder.UseVisualStyleBackColor = false;
            this.btn_acceder.Click += new System.EventHandler(this.btn_acceder_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.btn_acceder);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_acceder;
    }
}