namespace Facturacion
{
    partial class Factura
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
            this.txt_total = new System.Windows.Forms.TextBox();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.txt_impuestos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_cantidad = new System.Windows.Forms.ComboBox();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.txt_factura = new System.Windows.Forms.TextBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.id_pedido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_vender = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.txt_subtotal);
            this.panel1.Controls.Add(this.txt_impuestos);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_cantidad);
            this.panel1.Controls.Add(this.txt_precio);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.txt_pedido);
            this.panel1.Controls.Add(this.txt_factura);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.id_pedido);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(56, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 448);
            this.panel1.TabIndex = 0;
            // 
            // txt_total
            // 
            this.txt_total.Location = new System.Drawing.Point(487, 406);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(117, 20);
            this.txt_total.TabIndex = 28;
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Location = new System.Drawing.Point(292, 406);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(117, 20);
            this.txt_subtotal.TabIndex = 27;
            // 
            // txt_impuestos
            // 
            this.txt_impuestos.Location = new System.Drawing.Point(97, 406);
            this.txt_impuestos.Name = "txt_impuestos";
            this.txt_impuestos.Size = new System.Drawing.Size(117, 20);
            this.txt_impuestos.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(427, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "TOTAL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "SUBTOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "IMPUESTOS";
            // 
            // cmb_cantidad
            // 
            this.cmb_cantidad.FormattingEnabled = true;
            this.cmb_cantidad.Location = new System.Drawing.Point(185, 144);
            this.cmb_cantidad.Name = "cmb_cantidad";
            this.cmb_cantidad.Size = new System.Drawing.Size(117, 21);
            this.cmb_cantidad.TabIndex = 22;
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(185, 112);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(117, 20);
            this.txt_precio.TabIndex = 21;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(185, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(117, 20);
            this.txt_nombre.TabIndex = 20;
            // 
            // txt_pedido
            // 
            this.txt_pedido.Location = new System.Drawing.Point(185, 56);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(117, 20);
            this.txt_pedido.TabIndex = 19;
            // 
            // txt_factura
            // 
            this.txt_factura.Location = new System.Drawing.Point(185, 28);
            this.txt_factura.Name = "txt_factura";
            this.txt_factura.Size = new System.Drawing.Size(117, 20);
            this.txt_factura.TabIndex = 18;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(430, 106);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(163, 23);
            this.btn_eliminar.TabIndex = 17;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(430, 53);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(163, 23);
            this.btn_agregar.TabIndex = 16;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID PEDIDO";
            // 
            // id_pedido
            // 
            this.id_pedido.AutoSize = true;
            this.id_pedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_pedido.Location = new System.Drawing.Point(55, 28);
            this.id_pedido.Name = "id_pedido";
            this.id_pedido.Size = new System.Drawing.Size(81, 17);
            this.id_pedido.TabIndex = 5;
            this.id_pedido.Text = "ID FACTURA";
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 224);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(597, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID PEDIDO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btn_vender
            // 
            this.btn_vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_vender.FlatAppearance.BorderSize = 0;
            this.btn_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vender.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vender.ForeColor = System.Drawing.Color.White;
            this.btn_vender.Location = new System.Drawing.Point(280, 528);
            this.btn_vender.Name = "btn_vender";
            this.btn_vender.Size = new System.Drawing.Size(163, 23);
            this.btn_vender.TabIndex = 29;
            this.btn_vender.Text = "Vender";
            this.btn_vender.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(325, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "FACTURA";
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
            this.btn_cerrar.TabIndex = 30;
            this.btn_cerrar.Text = "X";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 563);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_vender);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label id_pedido;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.TextBox txt_impuestos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_cantidad;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.TextBox txt_factura;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btn_vender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label btn_cerrar;
    }
}