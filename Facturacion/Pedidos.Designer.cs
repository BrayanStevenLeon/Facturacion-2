namespace Facturacion
{
    partial class Pedidos
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
            this.id_pedido = new System.Windows.Forms.Label();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.id_cliente = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.fecha_pedido = new System.Windows.Forms.Label();
            this.txt_FechaPedido = new System.Windows.Forms.TextBox();
            this.estado_pedido = new System.Windows.Forms.Label();
            this.txt_EstadoPedido = new System.Windows.Forms.TextBox();
            this.id_pago = new System.Windows.Forms.Label();
            this.txt_FormaPago = new System.Windows.Forms.TextBox();
            this.btn_cerrar = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // id_pedido
            // 
            this.id_pedido.AutoSize = true;
            this.id_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pedido.Location = new System.Drawing.Point(100, 109);
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Size = new System.Drawing.Size(74, 17);
            this.id_pedido.TabIndex = 4;
            this.id_pedido.Text = "ID PEDIDO";
            // 
            // txt_pedido
            // 
            this.txt_pedido.Location = new System.Drawing.Point(300, 106);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(144, 20);
            this.txt_pedido.TabIndex = 5;
            // 
            // id_cliente
            // 
            this.id_cliente.AutoSize = true;
            this.id_cliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_cliente.Location = new System.Drawing.Point(100, 165);
            this.id_cliente.Name = "id_cliente";
            this.id_cliente.Size = new System.Drawing.Size(74, 17);
            this.id_cliente.TabIndex = 6;
            this.id_cliente.Text = "ID CLIENTE";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(300, 165);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(144, 20);
            this.txt_cliente.TabIndex = 7;
            // 
            // fecha_pedido
            // 
            this.fecha_pedido.AutoSize = true;
            this.fecha_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_pedido.Location = new System.Drawing.Point(100, 220);
            this.fecha_pedido.Name = "fecha_pedido";
            this.fecha_pedido.Size = new System.Drawing.Size(103, 17);
            this.fecha_pedido.TabIndex = 8;
            this.fecha_pedido.Text = "FECHA PEDIDO";
            // 
            // txt_FechaPedido
            // 
            this.txt_FechaPedido.Location = new System.Drawing.Point(300, 220);
            this.txt_FechaPedido.Name = "txt_FechaPedido";
            this.txt_FechaPedido.Size = new System.Drawing.Size(144, 20);
            this.txt_FechaPedido.TabIndex = 9;
            // 
            // estado_pedido
            // 
            this.estado_pedido.AutoSize = true;
            this.estado_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado_pedido.Location = new System.Drawing.Point(100, 274);
            this.estado_pedido.Name = "estado_pedido";
            this.estado_pedido.Size = new System.Drawing.Size(109, 17);
            this.estado_pedido.TabIndex = 10;
            this.estado_pedido.Text = "ESTADO PEDIDO";
            // 
            // txt_EstadoPedido
            // 
            this.txt_EstadoPedido.Location = new System.Drawing.Point(299, 271);
            this.txt_EstadoPedido.Name = "txt_EstadoPedido";
            this.txt_EstadoPedido.Size = new System.Drawing.Size(144, 20);
            this.txt_EstadoPedido.TabIndex = 11;
            // 
            // id_pago
            // 
            this.id_pago.AutoSize = true;
            this.id_pago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pago.Location = new System.Drawing.Point(100, 328);
            this.id_pago.Name = "id_pago";
            this.id_pago.Size = new System.Drawing.Size(134, 17);
            this.id_pago.TabIndex = 12;
            this.id_pago.Text = "ID FORMA DE PAGO";
            // 
            // txt_FormaPago
            // 
            this.txt_FormaPago.Location = new System.Drawing.Point(300, 328);
            this.txt_FormaPago.Name = "txt_FormaPago";
            this.txt_FormaPago.Size = new System.Drawing.Size(144, 20);
            this.txt_FormaPago.TabIndex = 13;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.AutoSize = true;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.DimGray;
            this.btn_cerrar.Location = new System.Drawing.Point(714, 9);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(17, 17);
            this.btn_cerrar.TabIndex = 14;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(103, 395);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(163, 23);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(299, 395);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(163, 23);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 563);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.txt_FormaPago);
            this.Controls.Add(this.id_pago);
            this.Controls.Add(this.txt_EstadoPedido);
            this.Controls.Add(this.estado_pedido);
            this.Controls.Add(this.txt_FechaPedido);
            this.Controls.Add(this.fecha_pedido);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.id_cliente);
            this.Controls.Add(this.txt_pedido);
            this.Controls.Add(this.id_pedido);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pedidos";
            this.Text = "Pedidos";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_pedido;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.Label id_cliente;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Label fecha_pedido;
        private System.Windows.Forms.TextBox txt_FechaPedido;
        private System.Windows.Forms.Label estado_pedido;
        private System.Windows.Forms.TextBox txt_EstadoPedido;
        private System.Windows.Forms.Label id_pago;
        private System.Windows.Forms.TextBox txt_FormaPago;
        private System.Windows.Forms.Label btn_cerrar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
    }
}