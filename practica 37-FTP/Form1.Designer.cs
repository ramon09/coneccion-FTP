namespace practica_37_FTP
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
            this.lblSalida = new System.Windows.Forms.Label();
            this.bttnUploadFile = new System.Windows.Forms.Button();
            this.bttnSlectFile = new System.Windows.Forms.Button();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(131, 158);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(35, 13);
            this.lblSalida.TabIndex = 11;
            this.lblSalida.Text = "label4";
            this.lblSalida.Click += new System.EventHandler(this.txtSalida_Click);
            // 
            // bttnUploadFile
            // 
            this.bttnUploadFile.AutoSize = true;
            this.bttnUploadFile.Location = new System.Drawing.Point(15, 149);
            this.bttnUploadFile.Name = "bttnUploadFile";
            this.bttnUploadFile.Size = new System.Drawing.Size(110, 30);
            this.bttnUploadFile.TabIndex = 9;
            this.bttnUploadFile.Text = "Subir archivo";
            this.bttnUploadFile.UseVisualStyleBackColor = true;
            this.bttnUploadFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // bttnSlectFile
            // 
            this.bttnSlectFile.AutoSize = true;
            this.bttnSlectFile.Location = new System.Drawing.Point(12, 65);
            this.bttnSlectFile.Name = "bttnSlectFile";
            this.bttnSlectFile.Size = new System.Drawing.Size(156, 30);
            this.bttnSlectFile.TabIndex = 10;
            this.bttnSlectFile.Text = "Seleccionar archivo";
            this.bttnSlectFile.UseVisualStyleBackColor = true;
            this.bttnSlectFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 113);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(153, 20);
            this.textBoxFile.TabIndex = 7;
            // 
            // textBoxServer
            // 
            this.textBoxServer.Location = new System.Drawing.Point(134, 6);
            this.textBoxServer.Name = "textBoxServer";
            this.textBoxServer.Size = new System.Drawing.Size(160, 20);
            this.textBoxServer.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de archivo en el servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de archivo seleccionado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP de Servidor FTP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 185);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.bttnUploadFile);
            this.Controls.Add(this.bttnSlectFile);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.textBoxServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button bttnUploadFile;
        private System.Windows.Forms.Button bttnSlectFile;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

