namespace LutonesSystem.Forms.Fornecedores
{
    partial class form_FornecedorAdicionar
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
            this.txtNomeFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCadastrarFornecedor = new DevExpress.XtraEditors.SimpleButton();
            this.dtDataCadastroFornecedor = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.txtCnpjFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtTelefoneFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailFornecedor = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFornecedor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailFornecedor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeFornecedor
            // 
            this.txtNomeFornecedor.Location = new System.Drawing.Point(12, 113);
            this.txtNomeFornecedor.Name = "txtNomeFornecedor";
            this.txtNomeFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtNomeFornecedor.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Data de Cadastro";
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(106, 254);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(167, 38);
            this.btnCadastrarFornecedor.TabIndex = 5;
            this.btnCadastrarFornecedor.Text = "Cadastrar";
            this.btnCadastrarFornecedor.Click += new System.EventHandler(this.btnCadastrarFornecedor_Click);
            // 
            // dtDataCadastroFornecedor
            // 
            this.dtDataCadastroFornecedor.EditValue = null;
            this.dtDataCadastroFornecedor.Location = new System.Drawing.Point(12, 31);
            this.dtDataCadastroFornecedor.Name = "dtDataCadastroFornecedor";
            this.dtDataCadastroFornecedor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCadastroFornecedor.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtDataCadastroFornecedor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtDataCadastroFornecedor.Properties.MaskSettings.Set("mask", "d");
            this.dtDataCadastroFornecedor.Size = new System.Drawing.Size(144, 20);
            this.dtDataCadastroFornecedor.TabIndex = 9;
            // 
            // txtCnpjFornecedor
            // 
            this.txtCnpjFornecedor.Location = new System.Drawing.Point(224, 113);
            this.txtCnpjFornecedor.Name = "txtCnpjFornecedor";
            this.txtCnpjFornecedor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.txtCnpjFornecedor.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtCnpjFornecedor.Properties.MaskSettings.Set("mask", "00.000.000/0000-00");
            this.txtCnpjFornecedor.Properties.UseMaskAsDisplayFormat = true;
            this.txtCnpjFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtCnpjFornecedor.TabIndex = 2;
            // 
            // txtTelefoneFornecedor
            // 
            this.txtTelefoneFornecedor.Location = new System.Drawing.Point(12, 194);
            this.txtTelefoneFornecedor.Name = "txtTelefoneFornecedor";
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegularMaskManager));
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.txtTelefoneFornecedor.Properties.MaskSettings.Set("mask", "(\\d?\\d?) \\d \\d\\d\\d\\d-\\d\\d\\d\\d");
            this.txtTelefoneFornecedor.Properties.UseMaskAsDisplayFormat = true;
            this.txtTelefoneFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtTelefoneFornecedor.TabIndex = 3;
            // 
            // txtEmailFornecedor
            // 
            this.txtEmailFornecedor.Location = new System.Drawing.Point(224, 194);
            this.txtEmailFornecedor.Name = "txtEmailFornecedor";
            this.txtEmailFornecedor.Size = new System.Drawing.Size(144, 20);
            this.txtEmailFornecedor.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Nome:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 175);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Telefone:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(224, 175);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Email:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(224, 94);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "CNPJ:";
            // 
            // form_FornecedorAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtEmailFornecedor);
            this.Controls.Add(this.txtTelefoneFornecedor);
            this.Controls.Add(this.txtCnpjFornecedor);
            this.Controls.Add(this.dtDataCadastroFornecedor);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeFornecedor);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_FornecedorAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Fornecedor";
            this.Load += new System.EventHandler(this.form_FornecedorAdicionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCnpjFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefoneFornecedor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailFornecedor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNomeFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCadastrarFornecedor;
        private DevExpress.XtraEditors.DateTimeOffsetEdit dtDataCadastroFornecedor;
        private DevExpress.XtraEditors.TextEdit txtCnpjFornecedor;
        private DevExpress.XtraEditors.TextEdit txtTelefoneFornecedor;
        private DevExpress.XtraEditors.TextEdit txtEmailFornecedor;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}