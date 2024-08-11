namespace agenda
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
            this.nombreLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.numeroLabel = new System.Windows.Forms.Label();
            this.correoLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guardarBtn = new System.Windows.Forms.Button();
            this.direccionInp = new System.Windows.Forms.TextBox();
            this.correoInp = new System.Windows.Forms.TextBox();
            this.nombreInp = new System.Windows.Forms.TextBox();
            this.numeroInp = new System.Windows.Forms.TextBox();
            this.apellidoInp = new System.Windows.Forms.TextBox();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.buscarInp = new System.Windows.Forms.TextBox();
            this.buscarBtn = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel.Location = new System.Drawing.Point(6, 43);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(87, 25);
            this.nombreLabel.TabIndex = 0;
            this.nombreLabel.Text = "Nombre:";
            this.nombreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel.Location = new System.Drawing.Point(267, 43);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(98, 25);
            this.apellidoLabel.TabIndex = 1;
            this.apellidoLabel.Text = "Apellidos:";
            this.apellidoLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // numeroLabel
            // 
            this.numeroLabel.AutoSize = true;
            this.numeroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroLabel.Location = new System.Drawing.Point(6, 137);
            this.numeroLabel.Name = "numeroLabel";
            this.numeroLabel.Size = new System.Drawing.Size(188, 25);
            this.numeroLabel.TabIndex = 2;
            this.numeroLabel.Text = "Numero de telefono:";
            this.numeroLabel.Click += new System.EventHandler(this.numeroLabel_Click);
            // 
            // correoLabel
            // 
            this.correoLabel.AutoSize = true;
            this.correoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoLabel.Location = new System.Drawing.Point(267, 137);
            this.correoLabel.Name = "correoLabel";
            this.correoLabel.Size = new System.Drawing.Size(177, 25);
            this.correoLabel.TabIndex = 3;
            this.correoLabel.Text = "Correo electronico:";
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionLabel.Location = new System.Drawing.Point(6, 222);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(99, 25);
            this.direccionLabel.TabIndex = 4;
            this.direccionLabel.Text = "Direccion:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.guardarBtn);
            this.groupBox1.Controls.Add(this.direccionInp);
            this.groupBox1.Controls.Add(this.correoInp);
            this.groupBox1.Controls.Add(this.nombreInp);
            this.groupBox1.Controls.Add(this.nombreLabel);
            this.groupBox1.Controls.Add(this.numeroInp);
            this.groupBox1.Controls.Add(this.apellidoInp);
            this.groupBox1.Controls.Add(this.direccionLabel);
            this.groupBox1.Controls.Add(this.apellidoLabel);
            this.groupBox1.Controls.Add(this.correoLabel);
            this.groupBox1.Controls.Add(this.numeroLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 391);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de contacto";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // guardarBtn
            // 
            this.guardarBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.guardarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guardarBtn.Location = new System.Drawing.Point(11, 312);
            this.guardarBtn.Name = "guardarBtn";
            this.guardarBtn.Size = new System.Drawing.Size(477, 51);
            this.guardarBtn.TabIndex = 7;
            this.guardarBtn.Text = "Guardar";
            this.guardarBtn.UseVisualStyleBackColor = false;
            this.guardarBtn.Click += new System.EventHandler(this.guardarBtn_Click);
            // 
            // direccionInp
            // 
            this.direccionInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionInp.Location = new System.Drawing.Point(11, 269);
            this.direccionInp.Name = "direccionInp";
            this.direccionInp.Size = new System.Drawing.Size(216, 26);
            this.direccionInp.TabIndex = 7;
            // 
            // correoInp
            // 
            this.correoInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoInp.Location = new System.Drawing.Point(272, 175);
            this.correoInp.Name = "correoInp";
            this.correoInp.Size = new System.Drawing.Size(216, 26);
            this.correoInp.TabIndex = 6;
            // 
            // nombreInp
            // 
            this.nombreInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreInp.Location = new System.Drawing.Point(11, 80);
            this.nombreInp.Name = "nombreInp";
            this.nombreInp.Size = new System.Drawing.Size(216, 26);
            this.nombreInp.TabIndex = 5;
            this.nombreInp.TextChanged += new System.EventHandler(this.nombreInp_TextChanged);
            // 
            // numeroInp
            // 
            this.numeroInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroInp.Location = new System.Drawing.Point(11, 175);
            this.numeroInp.Name = "numeroInp";
            this.numeroInp.Size = new System.Drawing.Size(216, 26);
            this.numeroInp.TabIndex = 9;
            // 
            // apellidoInp
            // 
            this.apellidoInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoInp.Location = new System.Drawing.Point(272, 80);
            this.apellidoInp.Name = "apellidoInp";
            this.apellidoInp.Size = new System.Drawing.Size(216, 26);
            this.apellidoInp.TabIndex = 8;
            // 
            // dgvContactos
            // 
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvContactos.Location = new System.Drawing.Point(537, 144);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.RowHeadersWidth = 51;
            this.dgvContactos.Size = new System.Drawing.Size(1044, 391);
            this.dgvContactos.TabIndex = 6;
            this.dgvContactos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContactos_CellContentClick);
            // 
            // buscarInp
            // 
            this.buscarInp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarInp.Location = new System.Drawing.Point(537, 99);
            this.buscarInp.Name = "buscarInp";
            this.buscarInp.Size = new System.Drawing.Size(719, 30);
            this.buscarInp.TabIndex = 7;
            this.buscarInp.TextChanged += new System.EventHandler(this.buscarInp_TextChanged);
            // 
            // buscarBtn
            // 
            this.buscarBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.buscarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buscarBtn.Location = new System.Drawing.Point(1271, 96);
            this.buscarBtn.Name = "buscarBtn";
            this.buscarBtn.Size = new System.Drawing.Size(154, 42);
            this.buscarBtn.TabIndex = 8;
            this.buscarBtn.Text = "Buscar";
            this.buscarBtn.UseVisualStyleBackColor = false;
            this.buscarBtn.Click += new System.EventHandler(this.buscarBtn_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(640, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(223, 58);
            this.titulo.TabIndex = 9;
            this.titulo.Text = "Weloapp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1490, 676);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscarBtn);
            this.Controls.Add(this.buscarInp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Label numeroLabel;
        private System.Windows.Forms.Label correoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nombreInp;
        private System.Windows.Forms.TextBox correoInp;
        private System.Windows.Forms.TextBox direccionInp;
        private System.Windows.Forms.TextBox apellidoInp;
        private System.Windows.Forms.TextBox numeroInp;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.Button guardarBtn;
        private System.Windows.Forms.TextBox buscarInp;
        private System.Windows.Forms.Button buscarBtn;
        private System.Windows.Forms.Label titulo;
    }
}

