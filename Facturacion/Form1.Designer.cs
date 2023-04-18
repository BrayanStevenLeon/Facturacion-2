namespace Facturacion
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
            this.panel_lateral = new System.Windows.Forms.Panel();
            this.margen = new System.Windows.Forms.Panel();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_telas = new System.Windows.Forms.Button();
            this.btn_proveedores = new System.Windows.Forms.Button();
            this.btn_pago = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_detalles = new System.Windows.Forms.Button();
            this.btn_pedidos = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_lateral.SuspendLayout();
            this.margen.SuspendLayout();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_lateral
            // 
            this.panel_lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel_lateral.Controls.Add(this.btn_telas);
            this.panel_lateral.Controls.Add(this.btn_proveedores);
            this.panel_lateral.Controls.Add(this.btn_pago);
            this.panel_lateral.Controls.Add(this.btn_factura);
            this.panel_lateral.Controls.Add(this.btn_productos);
            this.panel_lateral.Controls.Add(this.btn_detalles);
            this.panel_lateral.Controls.Add(this.btn_pedidos);
            this.panel_lateral.Controls.Add(this.btn_cliente);
            this.panel_lateral.Controls.Add(this.margen);
            this.panel_lateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_lateral.Location = new System.Drawing.Point(0, 0);
            this.panel_lateral.Name = "panel_lateral";
            this.panel_lateral.Size = new System.Drawing.Size(200, 563);
            this.panel_lateral.TabIndex = 0;
            // 
            // margen
            // 
            this.margen.Controls.Add(this.pictureBox1);
            this.margen.Dock = System.Windows.Forms.DockStyle.Top;
            this.margen.Location = new System.Drawing.Point(0, 0);
            this.margen.Name = "margen";
            this.margen.Size = new System.Drawing.Size(200, 136);
            this.margen.TabIndex = 0;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(82)))), ((int)(((byte)(99)))));
            this.panel_contenedor.Controls.Add(this.pictureBox2);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(200, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(743, 563);
            this.panel_contenedor.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::Facturacion.Properties.Resources.jeans_removebg_preview1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(743, 563);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_telas
            // 
            this.btn_telas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_telas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_telas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_telas.FlatAppearance.BorderSize = 0;
            this.btn_telas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_telas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_telas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_telas.ForeColor = System.Drawing.Color.White;
            this.btn_telas.Image = global::Facturacion.Properties.Resources.icons8_pantalones_30;
            this.btn_telas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_telas.Location = new System.Drawing.Point(0, 346);
            this.btn_telas.Name = "btn_telas";
            this.btn_telas.Size = new System.Drawing.Size(200, 30);
            this.btn_telas.TabIndex = 8;
            this.btn_telas.Text = "Telas";
            this.btn_telas.UseVisualStyleBackColor = false;
            this.btn_telas.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_proveedores
            // 
            this.btn_proveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_proveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_proveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_proveedores.FlatAppearance.BorderSize = 0;
            this.btn_proveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proveedores.ForeColor = System.Drawing.Color.White;
            this.btn_proveedores.Image = global::Facturacion.Properties.Resources.icons8_camión_verificado_30;
            this.btn_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_proveedores.Location = new System.Drawing.Point(0, 316);
            this.btn_proveedores.Name = "btn_proveedores";
            this.btn_proveedores.Size = new System.Drawing.Size(200, 30);
            this.btn_proveedores.TabIndex = 7;
            this.btn_proveedores.Text = "Proveedores";
            this.btn_proveedores.UseVisualStyleBackColor = false;
            this.btn_proveedores.Click += new System.EventHandler(this.btn_proveedores_Click);
            // 
            // btn_pago
            // 
            this.btn_pago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_pago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pago.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pago.FlatAppearance.BorderSize = 0;
            this.btn_pago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pago.ForeColor = System.Drawing.Color.White;
            this.btn_pago.Image = global::Facturacion.Properties.Resources.icons8_caro_2_30;
            this.btn_pago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pago.Location = new System.Drawing.Point(0, 286);
            this.btn_pago.Name = "btn_pago";
            this.btn_pago.Size = new System.Drawing.Size(200, 30);
            this.btn_pago.TabIndex = 6;
            this.btn_pago.Text = "Formas de pago";
            this.btn_pago.UseVisualStyleBackColor = false;
            this.btn_pago.Click += new System.EventHandler(this.btn_pago_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_factura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_factura.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_factura.FlatAppearance.BorderSize = 0;
            this.btn_factura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_factura.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_factura.ForeColor = System.Drawing.Color.White;
            this.btn_factura.Image = global::Facturacion.Properties.Resources.icons8_factura_pagada_30;
            this.btn_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_factura.Location = new System.Drawing.Point(0, 256);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(200, 30);
            this.btn_factura.TabIndex = 5;
            this.btn_factura.Text = "Factura";
            this.btn_factura.UseVisualStyleBackColor = false;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_productos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_productos.FlatAppearance.BorderSize = 0;
            this.btn_productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productos.ForeColor = System.Drawing.Color.White;
            this.btn_productos.Image = global::Facturacion.Properties.Resources.icons8_producto_30;
            this.btn_productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_productos.Location = new System.Drawing.Point(0, 226);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(200, 30);
            this.btn_productos.TabIndex = 4;
            this.btn_productos.Text = "Productos";
            this.btn_productos.UseVisualStyleBackColor = false;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_detalles
            // 
            this.btn_detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_detalles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_detalles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_detalles.FlatAppearance.BorderSize = 0;
            this.btn_detalles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_detalles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detalles.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_detalles.ForeColor = System.Drawing.Color.White;
            this.btn_detalles.Image = global::Facturacion.Properties.Resources.icons8_hojas_de_cálculo_30;
            this.btn_detalles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_detalles.Location = new System.Drawing.Point(0, 196);
            this.btn_detalles.Name = "btn_detalles";
            this.btn_detalles.Size = new System.Drawing.Size(200, 30);
            this.btn_detalles.TabIndex = 3;
            this.btn_detalles.Text = "Detalles pedido";
            this.btn_detalles.UseVisualStyleBackColor = false;
            this.btn_detalles.Click += new System.EventHandler(this.btn_detalles_Click);
            // 
            // btn_pedidos
            // 
            this.btn_pedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_pedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_pedidos.FlatAppearance.BorderSize = 0;
            this.btn_pedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.btn_pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pedidos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pedidos.ForeColor = System.Drawing.Color.White;
            this.btn_pedidos.Image = global::Facturacion.Properties.Resources.icons8_agregar_a_carrito_de_compras_30;
            this.btn_pedidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pedidos.Location = new System.Drawing.Point(0, 166);
            this.btn_pedidos.Name = "btn_pedidos";
            this.btn_pedidos.Size = new System.Drawing.Size(200, 30);
            this.btn_pedidos.TabIndex = 2;
            this.btn_pedidos.Text = "Pedidos";
            this.btn_pedidos.UseVisualStyleBackColor = false;
            this.btn_pedidos.Click += new System.EventHandler(this.btn_pedidos_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cliente.FlatAppearance.BorderSize = 0;
            this.btn_cliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.White;
            this.btn_cliente.Image = global::Facturacion.Properties.Resources.icons8_usuario_30;
            this.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cliente.Location = new System.Drawing.Point(0, 136);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(200, 30);
            this.btn_cliente.TabIndex = 1;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Facturacion.Properties.Resources.jeans_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(40, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 563);
            this.Controls.Add(this.panel_contenedor);
            this.Controls.Add(this.panel_lateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_lateral.ResumeLayout(false);
            this.margen.ResumeLayout(false);
            this.panel_contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_lateral;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_contenedor;
        private System.Windows.Forms.Button btn_telas;
        private System.Windows.Forms.Button btn_proveedores;
        private System.Windows.Forms.Button btn_pago;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_detalles;
        private System.Windows.Forms.Button btn_pedidos;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Panel margen;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

