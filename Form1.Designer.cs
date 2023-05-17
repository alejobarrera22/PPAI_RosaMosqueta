namespace PPAI_RosaMosqueta
{
    partial class VentanaConsultarEncuesta
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
            this.lbl_Desde = new System.Windows.Forms.Label();
            this.date_Desde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.gBox_Periodo = new System.Windows.Forms.GroupBox();
            this.pan_Llamadas = new System.Windows.Forms.Panel();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.gBox_Periodo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.Location = new System.Drawing.Point(58, 79);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(51, 16);
            this.lbl_Desde.TabIndex = 0;
            this.lbl_Desde.Text = "Desde:";
            // 
            // date_Desde
            // 
            this.date_Desde.Location = new System.Drawing.Point(135, 74);
            this.date_Desde.Name = "date_Desde";
            this.date_Desde.Size = new System.Drawing.Size(277, 22);
            this.date_Desde.TabIndex = 1;
            this.date_Desde.UseWaitCursor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.UseWaitCursor = true;
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.Location = new System.Drawing.Point(494, 79);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(46, 16);
            this.lbl_Hasta.TabIndex = 2;
            this.lbl_Hasta.Text = "Hasta:";
            // 
            // gBox_Periodo
            // 
            this.gBox_Periodo.Controls.Add(this.btn_Aceptar);
            this.gBox_Periodo.Location = new System.Drawing.Point(27, 39);
            this.gBox_Periodo.Name = "gBox_Periodo";
            this.gBox_Periodo.Size = new System.Drawing.Size(884, 127);
            this.gBox_Periodo.TabIndex = 4;
            this.gBox_Periodo.TabStop = false;
            this.gBox_Periodo.Text = "Período";
            // 
            // pan_Llamadas
            // 
            this.pan_Llamadas.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pan_Llamadas.Location = new System.Drawing.Point(27, 200);
            this.pan_Llamadas.Name = "pan_Llamadas";
            this.pan_Llamadas.Size = new System.Drawing.Size(884, 322);
            this.pan_Llamadas.TabIndex = 5;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(787, 86);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(91, 35);
            this.btn_Aceptar.TabIndex = 0;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(814, 548);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 31);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // VentanaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 591);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.pan_Llamadas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.date_Desde);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.gBox_Periodo);
            this.Name = "VentanaConsultarEncuesta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.gBox_Periodo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.DateTimePicker date_Desde;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.GroupBox gBox_Periodo;
        private System.Windows.Forms.Panel pan_Llamadas;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

