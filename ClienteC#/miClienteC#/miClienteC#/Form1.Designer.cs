namespace miClienteC_
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connect_bttn = new System.Windows.Forms.Button();
            this.disconnect_bttn = new System.Windows.Forms.Button();
            this.newform_bttn = new System.Windows.Forms.Button();
            this.contLbl = new System.Windows.Forms.Label();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.PuertoBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PuertoBox);
            this.groupBox1.Controls.Add(this.IPBox);
            this.groupBox1.Controls.Add(this.disconnect_bttn);
            this.groupBox1.Controls.Add(this.connect_bttn);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones de Conexión";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // connect_bttn
            // 
            this.connect_bttn.Location = new System.Drawing.Point(35, 182);
            this.connect_bttn.Name = "connect_bttn";
            this.connect_bttn.Size = new System.Drawing.Size(128, 23);
            this.connect_bttn.TabIndex = 1;
            this.connect_bttn.Text = "Conectar";
            this.connect_bttn.UseVisualStyleBackColor = true;
            this.connect_bttn.Click += new System.EventHandler(this.connect_bttn_Click);
            // 
            // disconnect_bttn
            // 
            this.disconnect_bttn.Location = new System.Drawing.Point(35, 211);
            this.disconnect_bttn.Name = "disconnect_bttn";
            this.disconnect_bttn.Size = new System.Drawing.Size(128, 23);
            this.disconnect_bttn.TabIndex = 2;
            this.disconnect_bttn.Text = "Desconectar";
            this.disconnect_bttn.UseVisualStyleBackColor = true;
            this.disconnect_bttn.Click += new System.EventHandler(this.disconnect_bttn_Click);
            // 
            // newform_bttn
            // 
            this.newform_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newform_bttn.Location = new System.Drawing.Point(236, 52);
            this.newform_bttn.Name = "newform_bttn";
            this.newform_bttn.Size = new System.Drawing.Size(409, 65);
            this.newform_bttn.TabIndex = 1;
            this.newform_bttn.Text = "Crear Nuevo Formulario";
            this.newform_bttn.UseVisualStyleBackColor = true;
            this.newform_bttn.Click += new System.EventHandler(this.newform_bttn_Click);
            // 
            // contLbl
            // 
            this.contLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.contLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contLbl.Location = new System.Drawing.Point(590, 328);
            this.contLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.contLbl.Name = "contLbl";
            this.contLbl.Size = new System.Drawing.Size(197, 113);
            this.contLbl.TabIndex = 13;
            this.contLbl.Visible = false;
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(35, 54);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(128, 22);
            this.IPBox.TabIndex = 14;
            this.IPBox.Text = "192.168.56.102";
            // 
            // PuertoBox
            // 
            this.PuertoBox.Location = new System.Drawing.Point(35, 116);
            this.PuertoBox.Name = "PuertoBox";
            this.PuertoBox.Size = new System.Drawing.Size(128, 22);
            this.PuertoBox.TabIndex = 14;
            this.PuertoBox.Text = "9150";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Puerto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contLbl);
            this.Controls.Add(this.newform_bttn);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button connect_bttn;
        private System.Windows.Forms.Button disconnect_bttn;
        private System.Windows.Forms.Button newform_bttn;
        private System.Windows.Forms.Label contLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PuertoBox;
        private System.Windows.Forms.TextBox IPBox;
    }
}

