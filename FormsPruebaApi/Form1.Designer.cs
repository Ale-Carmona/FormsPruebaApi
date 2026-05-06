namespace FormsPruebaApi
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
            this.button1 = new System.Windows.Forms.Button();
            this.ldID = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbMatricula = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.txbEdad = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbMatricula = new System.Windows.Forms.TextBox();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ldID
            // 
            this.ldID.AutoSize = true;
            this.ldID.Location = new System.Drawing.Point(168, 67);
            this.ldID.Name = "ldID";
            this.ldID.Size = new System.Drawing.Size(35, 25);
            this.ldID.TabIndex = 1;
            this.ldID.Text = "Id:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(135, 138);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(68, 25);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "Edad:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(120, 209);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(93, 25);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbMatricula
            // 
            this.lbMatricula.AutoSize = true;
            this.lbMatricula.Location = new System.Drawing.Point(107, 280);
            this.lbMatricula.Name = "lbMatricula";
            this.lbMatricula.Size = new System.Drawing.Size(106, 25);
            this.lbMatricula.TabIndex = 4;
            this.lbMatricula.Text = "Matricula:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(153, 349);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(60, 25);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo:";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(234, 67);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 31);
            this.txbId.TabIndex = 6;
            // 
            // txbEdad
            // 
            this.txbEdad.Location = new System.Drawing.Point(234, 132);
            this.txbEdad.Name = "txbEdad";
            this.txbEdad.Size = new System.Drawing.Size(100, 31);
            this.txbEdad.TabIndex = 7;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(234, 203);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(100, 31);
            this.txbNombre.TabIndex = 8;
            // 
            // txbMatricula
            // 
            this.txbMatricula.Location = new System.Drawing.Point(234, 274);
            this.txbMatricula.Name = "txbMatricula";
            this.txbMatricula.Size = new System.Drawing.Size(100, 31);
            this.txbMatricula.TabIndex = 9;
            // 
            // txbTipo
            // 
            this.txbTipo.Location = new System.Drawing.Point(234, 343);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(100, 31);
            this.txbTipo.TabIndex = 10;
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(457, 28);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersWidth = 82;
            this.dgDatos.RowTemplate.Height = 33;
            this.dgDatos.Size = new System.Drawing.Size(824, 318);
            this.dgDatos.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(457, 421);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 57);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(714, 421);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 57);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(948, 421);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 57);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 642);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.txbTipo);
            this.Controls.Add(this.txbMatricula);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbEdad);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbMatricula);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.ldID);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ldID;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbMatricula;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.TextBox txbEdad;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbMatricula;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

