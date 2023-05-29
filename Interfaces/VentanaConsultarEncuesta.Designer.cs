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
            this.gBox_Llamada = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gBox_Encuesta = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_CSV = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.gBox_Periodo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLlamadasEncontradas)).BeginInit();
            this.gBox_Llamada.SuspendLayout();
            this.gBox_Encuesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Desde
            // 
            this.lbl_Desde.AutoSize = true;
            this.lbl_Desde.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Desde.Location = new System.Drawing.Point(59, 149);
            this.lbl_Desde.Name = "lbl_Desde";
            this.lbl_Desde.Size = new System.Drawing.Size(51, 16);
            this.lbl_Desde.TabIndex = 0;
            this.lbl_Desde.Text = "Desde:";
            this.lbl_Desde.Visible = false;
            // 
            // dateDesde
            // 
            this.dateDesde.Location = new System.Drawing.Point(135, 144);
            this.dateDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateDesde.Name = "dateDesde";
            this.dateDesde.Size = new System.Drawing.Size(277, 22);
            this.dateDesde.TabIndex = 1;
            this.dateDesde.UseWaitCursor = true;
            this.dateDesde.Value = new System.DateTime(2023, 5, 26, 0, 0, 0, 0);
            this.dateDesde.Visible = false;
            this.dateDesde.ValueChanged += new System.EventHandler(this.date_Desde_ValueChanged);
            // 
            // dateHasta
            // 
            this.dateHasta.Location = new System.Drawing.Point(571, 144);
            this.dateHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateHasta.Name = "dateHasta";
            this.dateHasta.Size = new System.Drawing.Size(277, 22);
            this.dateHasta.TabIndex = 3;
            this.dateHasta.UseWaitCursor = true;
            this.dateHasta.Visible = false;
            this.dateHasta.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_Hasta
            // 
            this.lbl_Hasta.AutoSize = true;
            this.lbl_Hasta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Hasta.Location = new System.Drawing.Point(493, 149);
            this.lbl_Hasta.Name = "lbl_Hasta";
            this.lbl_Hasta.Size = new System.Drawing.Size(46, 16);
            this.lbl_Hasta.TabIndex = 2;
            this.lbl_Hasta.Text = "Hasta:";
            this.lbl_Hasta.Visible = false;
            // 
            // gBox_Periodo
            // 
            this.gBox_Periodo.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gBox_Periodo.Controls.Add(this.buttonBuscar);
            this.gBox_Periodo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBox_Periodo.Location = new System.Drawing.Point(27, 110);
            this.gBox_Periodo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Periodo.Name = "gBox_Periodo";
            this.gBox_Periodo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Periodo.Size = new System.Drawing.Size(923, 133);
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
            this.buttonBuscar.Location = new System.Drawing.Point(818, 87);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(91, 34);
            this.buttonBuscar.TabIndex = 1;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Cancelar.Location = new System.Drawing.Point(895, 798);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(97, 31);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Visible = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // opcionConsultarEncuesta
            // 
            this.opcionConsultarEncuesta.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.opcionConsultarEncuesta.Location = new System.Drawing.Point(27, 36);
            this.opcionConsultarEncuesta.Margin = new System.Windows.Forms.Padding(4);
            this.opcionConsultarEncuesta.Name = "opcionConsultarEncuesta";
            this.opcionConsultarEncuesta.Size = new System.Drawing.Size(188, 28);
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
            this.dataLlamadasEncontradas.Location = new System.Drawing.Point(27, 306);
            this.dataLlamadasEncontradas.Margin = new System.Windows.Forms.Padding(4);
            this.dataLlamadasEncontradas.Name = "dataLlamadasEncontradas";
            this.dataLlamadasEncontradas.RowHeadersWidth = 92;
            this.dataLlamadasEncontradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataLlamadasEncontradas.Size = new System.Drawing.Size(416, 218);
            this.dataLlamadasEncontradas.TabIndex = 8;
            this.dataLlamadasEncontradas.Visible = false;
            this.dataLlamadasEncontradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // llamadas
            // 
            this.llamadas.HeaderText = "LlamadasEncontradas";
            this.llamadas.MinimumWidth = 11;
            this.llamadas.Name = "llamadas";
            this.llamadas.ReadOnly = true;
            this.llamadas.Width = 172;
            // 
            // seleccioneLlamada
            // 
            this.seleccioneLlamada.AutoSize = true;
            this.seleccioneLlamada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.seleccioneLlamada.Location = new System.Drawing.Point(24, 279);
            this.seleccioneLlamada.Name = "seleccioneLlamada";
            this.seleccioneLlamada.Size = new System.Drawing.Size(156, 16);
            this.seleccioneLlamada.TabIndex = 9;
            this.seleccioneLlamada.Text = "Selecione una LLamada:";
            this.seleccioneLlamada.Visible = false;
            // 
            // textNombreCompleto
            // 
            this.textNombreCompleto.Location = new System.Drawing.Point(193, 39);
            this.textNombreCompleto.Margin = new System.Windows.Forms.Padding(4);
            this.textNombreCompleto.Name = "textNombreCompleto";
            this.textNombreCompleto.ReadOnly = true;
            this.textNombreCompleto.Size = new System.Drawing.Size(253, 22);
            this.textNombreCompleto.TabIndex = 10;
            this.textNombreCompleto.Visible = false;
            // 
            // labelNombreCompleto
            // 
            this.labelNombreCompleto.AutoSize = true;
            this.labelNombreCompleto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNombreCompleto.Location = new System.Drawing.Point(11, 39);
            this.labelNombreCompleto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombreCompleto.Name = "labelNombreCompleto";
            this.labelNombreCompleto.Size = new System.Drawing.Size(161, 16);
            this.labelNombreCompleto.TabIndex = 11;
            this.labelNombreCompleto.Text = "Nombre Completo Cliente";
            this.labelNombreCompleto.Visible = false;
            // 
            // labelDuracionLlamada
            // 
            this.labelDuracionLlamada.AutoSize = true;
            this.labelDuracionLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDuracionLlamada.Location = new System.Drawing.Point(11, 105);
            this.labelDuracionLlamada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuracionLlamada.Name = "labelDuracionLlamada";
            this.labelDuracionLlamada.Size = new System.Drawing.Size(121, 16);
            this.labelDuracionLlamada.TabIndex = 12;
            this.labelDuracionLlamada.Text = "Duracion LLamada";
            this.labelDuracionLlamada.Visible = false;
            // 
            // textBoxDuracionLLamada
            // 
            this.textBoxDuracionLLamada.Location = new System.Drawing.Point(193, 105);
            this.textBoxDuracionLLamada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDuracionLLamada.Name = "textBoxDuracionLLamada";
            this.textBoxDuracionLLamada.ReadOnly = true;
            this.textBoxDuracionLLamada.Size = new System.Drawing.Size(253, 22);
            this.textBoxDuracionLLamada.TabIndex = 13;
            this.textBoxDuracionLLamada.Visible = false;
            // 
            // textBoxEstadoActualLLamada
            // 
            this.textBoxEstadoActualLLamada.Location = new System.Drawing.Point(193, 170);
            this.textBoxEstadoActualLLamada.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEstadoActualLLamada.Name = "textBoxEstadoActualLLamada";
            this.textBoxEstadoActualLLamada.ReadOnly = true;
            this.textBoxEstadoActualLLamada.Size = new System.Drawing.Size(253, 22);
            this.textBoxEstadoActualLLamada.TabIndex = 15;
            this.textBoxEstadoActualLLamada.Visible = false;
            // 
            // labelEstadoActualLlamada
            // 
            this.labelEstadoActualLlamada.AutoSize = true;
            this.labelEstadoActualLlamada.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelEstadoActualLlamada.Location = new System.Drawing.Point(11, 170);
            this.labelEstadoActualLlamada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstadoActualLlamada.Name = "labelEstadoActualLlamada";
            this.labelEstadoActualLlamada.Size = new System.Drawing.Size(146, 16);
            this.labelEstadoActualLlamada.TabIndex = 14;
            this.labelEstadoActualLlamada.Text = "Estado Actual Llamada";
            this.labelEstadoActualLlamada.Visible = false;
            // 
            // gBox_Llamada
            // 
            this.gBox_Llamada.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gBox_Llamada.Controls.Add(this.textBoxEstadoActualLLamada);
            this.gBox_Llamada.Controls.Add(this.button1);
            this.gBox_Llamada.Controls.Add(this.labelEstadoActualLlamada);
            this.gBox_Llamada.Controls.Add(this.labelNombreCompleto);
            this.gBox_Llamada.Controls.Add(this.textBoxDuracionLLamada);
            this.gBox_Llamada.Controls.Add(this.textNombreCompleto);
            this.gBox_Llamada.Controls.Add(this.labelDuracionLlamada);
            this.gBox_Llamada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBox_Llamada.Location = new System.Drawing.Point(482, 306);
            this.gBox_Llamada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Llamada.Name = "gBox_Llamada";
            this.gBox_Llamada.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Llamada.Size = new System.Drawing.Size(467, 218);
            this.gBox_Llamada.TabIndex = 16;
            this.gBox_Llamada.TabStop = false;
            this.gBox_Llamada.Text = "Llamada Seleccionada";
            this.gBox_Llamada.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(787, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // gBox_Encuesta
            // 
            this.gBox_Encuesta.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.gBox_Encuesta.Controls.Add(this.label2);
            this.gBox_Encuesta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gBox_Encuesta.Location = new System.Drawing.Point(27, 547);
            this.gBox_Encuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Encuesta.Name = "gBox_Encuesta";
            this.gBox_Encuesta.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gBox_Encuesta.Size = new System.Drawing.Size(923, 209);
            this.gBox_Encuesta.TabIndex = 17;
            this.gBox_Encuesta.TabStop = false;
            this.gBox_Encuesta.Text = "Encuesta";
            this.gBox_Encuesta.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre Encuesta";
            this.label2.Visible = false;
            // 
            // btn_CSV
            // 
            this.btn_CSV.Location = new System.Drawing.Point(27, 795);
            this.btn_CSV.Name = "btn_CSV";
            this.btn_CSV.Size = new System.Drawing.Size(96, 31);
            this.btn_CSV.TabIndex = 18;
            this.btn_CSV.Text = "Generar CSV";
            this.btn_CSV.UseVisualStyleBackColor = true;
            this.btn_CSV.Visible = false;
            this.btn_CSV.Click += new System.EventHandler(this.btn_CSV_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Location = new System.Drawing.Point(140, 795);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(100, 31);
            this.btn_imprimir.TabIndex = 19;
            this.btn_imprimir.Text = "Imprimir";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Visible = false;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // VentanaConsultarEncuesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btn_Cancelar;
            this.ClientSize = new System.Drawing.Size(1005, 838);
            this.Controls.Add(this.btn_imprimir);
            this.Controls.Add(this.btn_CSV);
            this.Controls.Add(this.gBox_Encuesta);
            this.Controls.Add(this.seleccioneLlamada);
            this.Controls.Add(this.dataLlamadasEncontradas);
            this.Controls.Add(this.opcionConsultarEncuesta);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.dateHasta);
            this.Controls.Add(this.lbl_Hasta);
            this.Controls.Add(this.dateDesde);
            this.Controls.Add(this.lbl_Desde);
            this.Controls.Add(this.gBox_Periodo);
            this.Controls.Add(this.gBox_Llamada);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VentanaConsultarEncuesta";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Encuesta";
            this.gBox_Periodo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLlamadasEncontradas)).EndInit();
            this.gBox_Llamada.ResumeLayout(false);
            this.gBox_Llamada.PerformLayout();
            this.gBox_Encuesta.ResumeLayout(false);
            this.gBox_Encuesta.PerformLayout();
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
        private System.Windows.Forms.GroupBox gBox_Llamada;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBox_Encuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_CSV;
        private System.Windows.Forms.Button btn_imprimir;
    }
}

