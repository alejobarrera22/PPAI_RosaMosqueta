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
            this.dateDesde = new System.Windows.Forms.DateTimePicker();
            this.dateHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Hasta = new System.Windows.Forms.Label();
            this.gBox_Periodo = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.opcionConsultarEncuesta = new System.Windows.Forms.Button();
            this.dataLlamadasEncontradas = new System.Windows.Forms.DataGridView();
            this.llamadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seleccioneLlamada = new System.Windows.Forms.Label();
            this.textNombreCompleto = new System.Windows.Forms.TextBox();
            this.labelNombreCompleto = new System.Windows.Forms.Label();
            this.labelDuracionLlamada = new System.Windows.Forms.Label();
            this.textBoxDuracionLLamada = new System.Windows.Forms.TextBox();
            this.textBoxEstadoActualLLamada = new System.Windows.Forms.TextBox();
            this.labelEstadoActualLlamada = new System.Windows.Forms.Label();
            this.gBox_Periodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLlamadasEncontradas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Desde.Location = new System.Drawing.Point(44, 121);
            this.lbl_Desde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(41, 13);
            this.lbl_Desde.TabIndex = 0;
            this.lbl_Desde.Text = "Desde:";
            this.lbl_Desde.Visible = false;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(101, 117);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(209, 20);
            this.dateDesde.TabIndex = 1;
            this.dateDesde.UseWaitCursor = true;
            this.dateDesde.Value = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.dateDesde.Visible = false;
            this.dateDesde.ValueChanged += new System.EventHandler(this.date_Desde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(428, 117);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(209, 20);
            this.dateHasta.TabIndex = 3;
            this.dateHasta.UseWaitCursor = true;
            this.dateHasta.Visible = false;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Hasta.Location = new System.Drawing.Point(370, 121);
            this.lbl_Hasta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(38, 13);
            this.lbl_Hasta.TabIndex = 2;
            this.lbl_Hasta.Text = "Hasta:";
            this.lbl_Hasta.Visible = false;
            // 
            // gBox_Periodo
            // 
            this.gBox_Periodo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gBox_Periodo.Controls.Add(this.buttonBuscar);
            this.gBox_Periodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBox_Periodo.Location = new System.Drawing.Point(20, 89);
            this.gBox_Periodo.Margin = new System.Windows.Forms.Padding(2);
            this.gBox_Periodo.Name = "gBox_Periodo";
            this.gBox_Periodo.Padding = new System.Windows.Forms.Padding(2);
            this.gBox_Periodo.Size = new System.Drawing.Size(663, 103);
            this.gBox_Periodo.TabIndex = 4;
            this.gBox_Periodo.TabStop = false;
            this.gBox_Periodo.Text = "Período";
            this.gBox_Periodo.Visible = false;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBuscar.Location = new System.Drawing.Point(590, 71);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(68, 28);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Location = new System.Drawing.Point(610, 502);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(73, 25);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // opcionConsultarEncuesta
            // 
            this.opcionConsultarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opcionConsultarEncuesta.Location = new System.Drawing.Point(20, 29);
            this.opcionConsultarEncuesta.Name = "opcionConsultarEncuesta";
            this.opcionConsultarEncuesta.Size = new System.Drawing.Size(141, 23);
            this.opcionConsultarEncuesta.TabIndex = 7;
            this.opcionConsultarEncuesta.Text = "Consutar Encuesta";
            this.opcionConsultarEncuesta.UseVisualStyleBackColor = true;
            this.opcionConsultarEncuesta.Click += new System.EventHandler(this.opcionConsultarEncuesta_Click);
            // 
            // dataLlamadasEncontradas
            // 
            this.dataLlamadasEncontradas.AllowUserToAddRows = false;
            this.dataLlamadasEncontradas.AllowUserToDeleteRows = false;
            this.dataLlamadasEncontradas.AllowUserToResizeColumns = false;
            this.dataLlamadasEncontradas.AllowUserToResizeRows = false;
            this.dataLlamadasEncontradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataLlamadasEncontradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLlamadasEncontradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.llamadas});
            this.dataLlamadasEncontradas.Location = new System.Drawing.Point(47, 249);
            this.dataLlamadasEncontradas.Name = "dataLlamadasEncontradas";
            this.dataLlamadasEncontradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLlamadasEncontradas.Size = new System.Drawing.Size(184, 177);
            this.dataLlamadasEncontradas.TabIndex = 8;
            this.dataLlamadasEncontradas.Visible = false;
            this.dataLlamadasEncontradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // llamadas
            // 
            this.llamadas.HeaderText = "LlamadasEncontradas";
            this.llamadas.Name = "llamadas";
            this.llamadas.ReadOnly = true;
            this.llamadas.Width = 137;
            // 
            // seleccioneLlamada
            // 
            this.seleccioneLlamada.AutoSize = true;
            this.seleccioneLlamada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seleccioneLlamada.Location = new System.Drawing.Point(44, 220);
            this.seleccioneLlamada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.seleccioneLlamada.Name = "seleccioneLlamada";
            this.seleccioneLlamada.Size = new System.Drawing.Size(125, 13);
            this.seleccioneLlamada.TabIndex = 9;
            this.seleccioneLlamada.Text = "Selecione una LLamada:";
            this.seleccioneLlamada.Visible = false;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(428, 249);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.Size = new System.Drawing.Size(144, 20);
            this.textNombreCompleto.TabIndex = 10;
            this.textNombreCompleto.Visible = false;
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreCompleto.Location = new System.Drawing.Point(425, 220);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(126, 13);
            this.labelNombreCompleto.TabIndex = 11;
            this.labelNombreCompleto.Text = "Nombre Completo Cliente";
            this.labelNombreCompleto.Visible = false;
            // 
            // labelDuracionLlamada
            // 
            this.labelDuracionLlamada.AutoSize = true;
            this.labelDuracionLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDuracionLlamada.Location = new System.Drawing.Point(425, 293);
            this.labelDuracionLlamada.Name = "labelDuracionLlamada";
            this.labelDuracionLlamada.Size = new System.Drawing.Size(97, 13);
            this.labelDuracionLlamada.TabIndex = 12;
            this.labelDuracionLlamada.Text = "Duracion LLamada";
            this.labelDuracionLlamada.Visible = false;
            // 
            // textBoxDuracionLLamada
            // 
            this.textBoxDuracionLLamada.Location = new System.Drawing.Point(428, 327);
            this.textBoxDuracionLLamada.Name = "textBoxDuracionLLamada";
            this.textBoxDuracionLLamada.Size = new System.Drawing.Size(144, 20);
            this.textBoxDuracionLLamada.TabIndex = 13;
            this.textBoxDuracionLLamada.Visible = false;
            // 
            // textBoxEstadoActualLLamada
            // 
            this.textBoxEstadoActualLLamada.Location = new System.Drawing.Point(428, 407);
            this.textBoxEstadoActualLLamada.Name = "textBoxEstadoActualLLamada";
            this.textBoxEstadoActualLLamada.Size = new System.Drawing.Size(144, 20);
            this.textBoxEstadoActualLLamada.TabIndex = 15;
            this.textBoxEstadoActualLLamada.Visible = false;
            // 
            // labelEstadoActualLlamada
            // 
            this.labelEstadoActualLlamada.AutoSize = true;
            this.labelEstadoActualLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstadoActualLlamada.Location = new System.Drawing.Point(425, 373);
            this.labelEstadoActualLlamada.Name = "labelEstadoActualLlamada";
            this.labelEstadoActualLlamada.Size = new System.Drawing.Size(184, 13);
            this.labelEstadoActualLlamada.TabIndex = 14;
            this.labelEstadoActualLlamada.Text = "Estado Actual Llamada Seleccionada";
            this.labelEstadoActualLlamada.Visible = false;
            // 
            // VentanaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(692, 538);
            this.Controls.Add(this.textBoxEstadoActualLLamada);
            this.Controls.Add(this.labelEstadoActualLlamada);
            this.Controls.Add(this.textBoxDuracionLLamada);
            this.Controls.Add(this.labelDuracionLlamada);
            this.Controls.Add(this.labelNombreCompleto);
            this.Controls.Add(this.textNombreCompleto);
            this.Controls.Add(this.seleccioneLlamada);
            this.Controls.Add(this.dataLlamadasEncontradas);
            this.Controls.Add(this.opcionConsultarEncuesta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.gBox_Periodo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "VentanaConsultarEncuesta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.Load += new System.EventHandler(this.VentanaConsultarEncuesta_Load);
            this.gBox_Periodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLlamadasEncontradas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Desde;
        private System.Windows.Forms.DateTimePicker dateDesde;
        private System.Windows.Forms.DateTimePicker dateHasta;
        private System.Windows.Forms.Label lbl_Hasta;
        private System.Windows.Forms.GroupBox gBox_Periodo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button opcionConsultarEncuesta;
        private System.Windows.Forms.DataGridView dataLlamadasEncontradas;
        private System.Windows.Forms.Label seleccioneLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn llamadas;
        private System.Windows.Forms.TextBox textNombreCompleto;
        private System.Windows.Forms.Label labelNombreCompleto;
        private System.Windows.Forms.Label labelDuracionLlamada;
        private System.Windows.Forms.TextBox textBoxDuracionLLamada;
        private System.Windows.Forms.TextBox textBoxEstadoActualLLamada;
        private System.Windows.Forms.Label labelEstadoActualLlamada;
    }
}

