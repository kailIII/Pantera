﻿namespace Presentacion
{
    partial class frmProcKardexProductoDetalle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcKardexProductoDetalle));
            this.dgvListaKardex = new System.Windows.Forms.DataGridView();
            this.CHFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPOMOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNROMOVIMIENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHINGRESOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSALIDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHSALDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPREF1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNREF1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTOPREF2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNREF2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPREF3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNREF3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHTIPREF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHNREF4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtAlamacen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKardex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListaKardex
            // 
            this.dgvListaKardex.AllowUserToAddRows = false;
            this.dgvListaKardex.AllowUserToDeleteRows = false;
            this.dgvListaKardex.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaKardex.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaKardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CHFECHA,
            this.CHTIPOMOV,
            this.CHNROMOVIMIENTO,
            this.CHINGRESOS,
            this.CHSALIDAS,
            this.CHSALDO,
            this.CHTIPREF1,
            this.CHNREF1,
            this.CHTOPREF2,
            this.CHNREF2,
            this.CHTIPREF3,
            this.CHNREF3,
            this.CHTIPREF4,
            this.CHNREF4});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaKardex.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListaKardex.Location = new System.Drawing.Point(12, 107);
            this.dgvListaKardex.Name = "dgvListaKardex";
            this.dgvListaKardex.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaKardex.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListaKardex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaKardex.Size = new System.Drawing.Size(688, 410);
            this.dgvListaKardex.TabIndex = 0;
            // 
            // CHFECHA
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.CHFECHA.DefaultCellStyle = dataGridViewCellStyle2;
            this.CHFECHA.HeaderText = "FECHA";
            this.CHFECHA.Name = "CHFECHA";
            this.CHFECHA.ReadOnly = true;
            this.CHFECHA.Width = 80;
            // 
            // CHTIPOMOV
            // 
            this.CHTIPOMOV.HeaderText = "TIPO DE MOVIMIENTO";
            this.CHTIPOMOV.Name = "CHTIPOMOV";
            this.CHTIPOMOV.ReadOnly = true;
            this.CHTIPOMOV.Width = 200;
            // 
            // CHNROMOVIMIENTO
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CHNROMOVIMIENTO.DefaultCellStyle = dataGridViewCellStyle3;
            this.CHNROMOVIMIENTO.HeaderText = "N° MOVIM.";
            this.CHNROMOVIMIENTO.Name = "CHNROMOVIMIENTO";
            this.CHNROMOVIMIENTO.ReadOnly = true;
            // 
            // CHINGRESOS
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(255)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = "00.00";
            this.CHINGRESOS.DefaultCellStyle = dataGridViewCellStyle4;
            this.CHINGRESOS.HeaderText = "INGRESOS";
            this.CHINGRESOS.Name = "CHINGRESOS";
            this.CHINGRESOS.ReadOnly = true;
            this.CHINGRESOS.Width = 80;
            // 
            // CHSALIDAS
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = "00.00";
            this.CHSALIDAS.DefaultCellStyle = dataGridViewCellStyle5;
            this.CHSALIDAS.HeaderText = "SALIDAS";
            this.CHSALIDAS.Name = "CHSALIDAS";
            this.CHSALIDAS.ReadOnly = true;
            this.CHSALIDAS.Width = 80;
            // 
            // CHSALDO
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = "00.00";
            this.CHSALDO.DefaultCellStyle = dataGridViewCellStyle6;
            this.CHSALDO.HeaderText = "SALDO";
            this.CHSALDO.Name = "CHSALDO";
            this.CHSALDO.ReadOnly = true;
            this.CHSALDO.Width = 80;
            // 
            // CHTIPREF1
            // 
            this.CHTIPREF1.HeaderText = "TIP. REF. #1";
            this.CHTIPREF1.Name = "CHTIPREF1";
            this.CHTIPREF1.ReadOnly = true;
            // 
            // CHNREF1
            // 
            this.CHNREF1.HeaderText = "NOM. REF. #1";
            this.CHNREF1.Name = "CHNREF1";
            this.CHNREF1.ReadOnly = true;
            this.CHNREF1.Width = 200;
            // 
            // CHTOPREF2
            // 
            this.CHTOPREF2.HeaderText = "TIP. REF. #2";
            this.CHTOPREF2.Name = "CHTOPREF2";
            this.CHTOPREF2.ReadOnly = true;
            // 
            // CHNREF2
            // 
            this.CHNREF2.HeaderText = "NOM. REF. #2";
            this.CHNREF2.Name = "CHNREF2";
            this.CHNREF2.ReadOnly = true;
            this.CHNREF2.Width = 200;
            // 
            // CHTIPREF3
            // 
            this.CHTIPREF3.HeaderText = "TIP. REF. #3";
            this.CHTIPREF3.Name = "CHTIPREF3";
            this.CHTIPREF3.ReadOnly = true;
            // 
            // CHNREF3
            // 
            this.CHNREF3.HeaderText = "NOM.REF. #3";
            this.CHNREF3.Name = "CHNREF3";
            this.CHNREF3.ReadOnly = true;
            this.CHNREF3.Width = 200;
            // 
            // CHTIPREF4
            // 
            this.CHTIPREF4.HeaderText = "TIP. REF. #4";
            this.CHTIPREF4.Name = "CHTIPREF4";
            this.CHTIPREF4.ReadOnly = true;
            // 
            // CHNREF4
            // 
            this.CHNREF4.HeaderText = "NOM. REF. #4";
            this.CHNREF4.Name = "CHNREF4";
            this.CHNREF4.ReadOnly = true;
            this.CHNREF4.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.ForeColor = System.Drawing.Color.Blue;
            this.txtCodigo.Location = new System.Drawing.Point(65, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(103, 20);
            this.txtCodigo.TabIndex = 2;
            this.txtCodigo.TabStop = false;
            // 
            // txtDescrip
            // 
            this.txtDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtDescrip.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescrip.ForeColor = System.Drawing.Color.Blue;
            this.txtDescrip.Location = new System.Drawing.Point(174, 16);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.ReadOnly = true;
            this.txtDescrip.Size = new System.Drawing.Size(431, 20);
            this.txtDescrip.TabIndex = 3;
            this.txtDescrip.TabStop = false;
            // 
            // txtUnidad
            // 
            this.txtUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtUnidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUnidad.ForeColor = System.Drawing.Color.Blue;
            this.txtUnidad.Location = new System.Drawing.Point(611, 16);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(74, 20);
            this.txtUnidad.TabIndex = 4;
            this.txtUnidad.TabStop = false;
            // 
            // txtAlamacen
            // 
            this.txtAlamacen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.txtAlamacen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAlamacen.ForeColor = System.Drawing.Color.Blue;
            this.txtAlamacen.Location = new System.Drawing.Point(65, 50);
            this.txtAlamacen.Name = "txtAlamacen";
            this.txtAlamacen.ReadOnly = true;
            this.txtAlamacen.Size = new System.Drawing.Size(323, 20);
            this.txtAlamacen.TabIndex = 5;
            this.txtAlamacen.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Almacen";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.txtDescrip);
            this.groupBox1.Controls.Add(this.txtAlamacen);
            this.groupBox1.Controls.Add(this.txtUnidad);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 89);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Producto";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(604, 45);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.SystemColors.Window;
            this.btnExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.Location = new System.Drawing.Point(518, 45);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(80, 28);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "&Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.Window;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(432, 45);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 28);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // frmProcKardexProductoDetalle
            // 
            this.AcceptButton = this.btnImprimir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(712, 529);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvListaKardex);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProcKardexProductoDetalle";
            this.ShowInTaskbar = false;
            this.Text = "MOVIMIENTO DE PRODUCTOS";
            this.Load += new System.EventHandler(this.frmProcKardexProductoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKardex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaKardex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtAlamacen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPOMOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNROMOVIMIENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHINGRESOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSALIDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHSALDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPREF1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNREF1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTOPREF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNREF2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPREF3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNREF3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHTIPREF4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHNREF4;
    }
}