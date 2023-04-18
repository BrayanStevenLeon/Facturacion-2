namespace Facturacion
{
    partial class Productos
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
            this.btn_cerrar = new System.Windows.Forms.Label();
            this.id_producto = new System.Windows.Forms.Label();
            this.txt_producto = new System.Windows.Forms.TextBox();
            this.nombre_producto = new System.Windows.Forms.Label();
            this.txt_NombreProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tela = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "PRODUCTOS";
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
            this.btn_cerrar.TabIndex = 16;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // id_producto
            // 
            this.id_producto.AutoSize = true;
            this.id_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_producto.Location = new System.Drawing.Point(118, 105);
            this.id_producto.Name = "id_producto";
            this.id_producto.Size = new System.Drawing.Size(97, 17);
            this.id_producto.TabIndex = 17;
            this.id_producto.Text = "ID PRODUCTO";
            // 
            // txt_producto
            // 
            this.txt_producto.Location = new System.Drawing.Point(289, 104);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.Size = new System.Drawing.Size(144, 20);
            this.txt_producto.TabIndex = 18;
            // 
            // nombre_producto
            // 
            this.nombre_producto.AutoSize = true;
            this.nombre_producto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_producto.Location = new System.Drawing.Point(118, 154);
            this.nombre_producto.Name = "nombre_producto";
            this.nombre_producto.Size = new System.Drawing.Size(138, 17);
            this.nombre_producto.TabIndex = 19;
            this.nombre_producto.Text = "NOMBRE PRODUCTO";
            // 
            // txt_NombreProducto
            // 
            this.txt_NombreProducto.Location = new System.Drawing.Point(289, 154);
            this.txt_NombreProducto.Name = "txt_NombreProducto";
            this.txt_NombreProducto.Size = new System.Drawing.Size(144, 20);
            this.txt_NombreProducto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "DESCRIPCION";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(289, 200);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(144, 20);
            this.txt_descripcion.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "PRECIO UNITARIO";
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(289, 246);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(144, 20);
            this.txt_precio.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "ID PROVEEDOR";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.Location = new System.Drawing.Point(289, 289);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(144, 20);
            this.txt_proveedor.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(118, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "ID TELA";
            // 
            // txt_tela
            // 
            this.txt_tela.Location = new System.Drawing.Point(289, 335);
            this.txt_tela.Name = "txt_tela";
            this.txt_tela.Size = new System.Drawing.Size(144, 20);
            this.txt_tela.TabIndex = 28;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(540, 104);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(163, 23);
            this.btn_guardar.TabIndex = 29;
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
            this.btn_eliminar.Location = new System.Drawing.Point(540, 154);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(163, 23);
            this.btn_eliminar.TabIndex = 30;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_actualizar.ForeColor = System.Drawing.Color.White;
            this.btn_actualizar.Location = new System.Drawing.Point(540, 197);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(163, 23);
            this.btn_actualizar.TabIndex = 31;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(36, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(679, 172);
            this.dataGridView1.TabIndex = 32;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID PRODUCTO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUCTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "DESCRIPCION";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "PRECIO UNT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID PROVEDOR";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_tela);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreProducto);
            this.Controls.Add(this.nombre_producto);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.id_producto);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_cerrar;
        private System.Windows.Forms.Label id_producto;
        private System.Windows.Forms.TextBox txt_producto;
        private System.Windows.Forms.Label nombre_producto;
        private System.Windows.Forms.TextBox txt_NombreProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_proveedor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tela;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}