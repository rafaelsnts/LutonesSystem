namespace LutonesSystem.Forms.Fornecedores
{
    partial class form_FornecedorEditar
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmailFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefoneFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtDataCadastroFornecedor = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtCnpjFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.btnAtualizarFornecedor = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCadastroFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjFornecedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(224, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "CNPJ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(224, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "Telefone:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 18;
            this.labelControl2.Text = "Nome:";
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(224, 194);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtEmailFornecedor.TabIndex = 4;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(12, 194);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("mask", "(\\d?\\d?) \\d \\d\\d\\d\\d-\\d\\d\\d\\d");
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtTelefoneFornecedor.TabIndex = 3;
            // 
            // txtDataCadastroFornecedor
            // 
            this.txtDataCadastroFornecedor.EditValue = null;
            this.txtDataCadastroFornecedor.Location = new System.Drawing.Point(12, 31);
            this.txtDataCadastroFornecedor.Name = "txtDataCadastroFornecedor";
            this.txtDataCadastroFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataCadastroFornecedor.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.txtDataCadastroFornecedor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtDataCadastroFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtDataCadastroFornecedor.TabIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Data de Cadastro";
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(12, 113);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // txtCnpjFornecedor
            // 
            this.txtCnpjFornecedor.Location = new System.Drawing.Point(224, 113);
            this.txtCnpjFornecedor.Name = "txtCnpjFornecedor";
            this.txtCnpjFornecedor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtCnpjFornecedor.Properties.MaskSettings.Set("mask", "00.000.000/0000-00");
            this.txtCnpjFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtCnpjFornecedor.TabIndex = 2;
            // 
            // btnAtualizarFornecedor
            // 
            this.btnAtualizarFornecedor.Location = new System.Drawing.Point(104, 255);
            this.btnAtualizarFornecedor.Name = "btnAtualizarFornecedor";
            this.btnAtualizarFornecedor.Size = new System.Drawing.Size(167, 38);
            this.btnAtualizarFornecedor.TabIndex = 5;
            this.btnAtualizarFornecedor.Text = "Atualizar Fornecedor";
            this.btnAtualizarFornecedor.Click += new System.EventHandler(this.btnAtualizarFornecedor_Click_1);
            // 
            // form_FornecedorEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.btnAtualizarFornecedor);
            this.Controls.Add(this.txtCnpjFornecedor);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.txtDataCadastroFornecedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeFornecedor);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_FornecedorEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Informações";
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataCadastroFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjFornecedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEmailFornecedor;
        private DevExpress.XtraEditors.TextEdit txtTelefoneFornecedor;
        private DevExpress.XtraEditors.DateTimeOffsetEdit txtDataCadastroFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeFornecedor;
        private DevExpress.XtraEditors.TextEdit txtCnpjFornecedor;
        private DevExpress.XtraEditors.SimpleButton btnAtualizarFornecedor;
    }
}