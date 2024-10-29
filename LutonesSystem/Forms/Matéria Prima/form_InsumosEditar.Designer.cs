namespace LutonesSystem.Forms.Matéria_Prima
{
    partial class form_InsumosEditar
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lookFornecedor = new DevExpress.XtraEditors.LookUpEdit();
            this.btnAtualizarInsumo = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrecoUnitario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinQuantidade = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeInsumo = new DevExpress.XtraEditors.TextEdit();
            this.cmbUnidadeMedida = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoUnitario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeInsumo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadeMedida.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 22);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(62, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Fornecedor:";
            // 
            // lookFornecedor
            // 
            this.lookFornecedor.Location = new System.Drawing.Point(23, 41);
            this.lookFornecedor.Name = "lookFornecedor";
            this.lookFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookFornecedor.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("for_nome", "Nome")});
            this.lookFornecedor.Properties.NullText = "";
            this.lookFornecedor.Size = new System.Drawing.Size(137, 20);
            this.lookFornecedor.TabIndex = 20;
            // 
            // btnAtualizarInsumo
            // 
            this.btnAtualizarInsumo.Location = new System.Drawing.Point(108, 259);
            this.btnAtualizarInsumo.Name = "btnAtualizarInsumo";
            this.btnAtualizarInsumo.Size = new System.Drawing.Size(167, 38);
            this.btnAtualizarInsumo.TabIndex = 4;
            this.btnAtualizarInsumo.Text = "Atualizar";
            this.btnAtualizarInsumo.Click += new System.EventHandler(this.btnAtualizarInsumo_Click);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.EditValue = "0,0";
            this.txtPrecoUnitario.Location = new System.Drawing.Point(23, 193);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecoUnitario.Properties.MaskSettings.Set("mask", "c");
            this.txtPrecoUnitario.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrecoUnitario.Size = new System.Drawing.Size(137, 20);
            this.txtPrecoUnitario.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 174);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 17;
            this.labelControl4.Text = "Preço Unitário:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(221, 174);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Quantidade:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(221, 96);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 13);
            this.labelControl2.TabIndex = 15;
            this.labelControl2.Text = "Unidade de Medida:";
            // 
            // spinQuantidade
            // 
            this.spinQuantidade.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantidade.Location = new System.Drawing.Point(221, 193);
            this.spinQuantidade.Name = "spinQuantidade";
            this.spinQuantidade.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinQuantidade.Properties.MaxValue = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.spinQuantidade.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantidade.Size = new System.Drawing.Size(137, 20);
            this.spinQuantidade.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(23, 96);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Nome:";
            // 
            // txtNomeInsumo
            // 
            this.txtNomeInsumo.Location = new System.Drawing.Point(23, 115);
            this.txtNomeInsumo.Name = "txtNomeInsumo";
            this.txtNomeInsumo.Size = new System.Drawing.Size(137, 20);
            this.txtNomeInsumo.TabIndex = 0;
            // 
            // cmbUnidadeMedida
            // 
            this.cmbUnidadeMedida.Location = new System.Drawing.Point(221, 115);
            this.cmbUnidadeMedida.Name = "cmbUnidadeMedida";
            this.cmbUnidadeMedida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbUnidadeMedida.Properties.Items.AddRange(new object[] {
            "KG",
            "UN",
            "G",
            "DZ",
            "PA",
            "CX",
            "PT",
            "RL"});
            this.cmbUnidadeMedida.Size = new System.Drawing.Size(137, 20);
            this.cmbUnidadeMedida.TabIndex = 1;
            // 
            // form_InsumosEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.cmbUnidadeMedida);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lookFornecedor);
            this.Controls.Add(this.btnAtualizarInsumo);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spinQuantidade);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeInsumo);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_InsumosEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Atualizar Informações";
            ((System.ComponentModel.ISupportInitialize)(this.lookFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoUnitario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeInsumo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbUnidadeMedida.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnAtualizarInsumo;
        private DevExpress.XtraEditors.TextEdit txtPrecoUnitario;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeInsumo;
        private DevExpress.XtraEditors.ComboBoxEdit cmbUnidadeMedida;
    }
}