namespace LutonesSystem.Forms.Produtos
{
    partial class form_ProdutoEditar
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
            this.txtDescricao = new DevExpress.XtraEditors.TextEdit();
            this.btnAtualizarProduto = new DevExpress.XtraEditors.SimpleButton();
            this.txtPrecoVenda = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinQuantidade = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNomeProduto = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(221, 72);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(137, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // btnAtualizarProduto
            // 
            this.btnAtualizarProduto.Location = new System.Drawing.Point(106, 227);
            this.btnAtualizarProduto.Name = "btnAtualizarProduto";
            this.btnAtualizarProduto.Size = new System.Drawing.Size(167, 38);
            this.btnAtualizarProduto.TabIndex = 4;
            this.btnAtualizarProduto.Text = "Atualizar";
            this.btnAtualizarProduto.Click += new System.EventHandler(this.btnAtualizarProduto_Click);
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.EditValue = "0,0";
            this.txtPrecoVenda.Location = new System.Drawing.Point(23, 150);
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecoVenda.Properties.MaskSettings.Set("mask", "c");
            this.txtPrecoVenda.Properties.UseMaskAsDisplayFormat = true;
            this.txtPrecoVenda.Size = new System.Drawing.Size(137, 20);
            this.txtPrecoVenda.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(23, 131);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(76, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "Preço Unitário:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(221, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(64, 13);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "Quantidade:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(221, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 38;
            this.labelControl2.Text = "Descrição:";
            // 
            // spinQuantidade
            // 
            this.spinQuantidade.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantidade.Location = new System.Drawing.Point(221, 150);
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
            this.labelControl1.Location = new System.Drawing.Point(23, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 36;
            this.labelControl1.Text = "Nome:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(23, 72);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(137, 20);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // form_ProdutoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.btnAtualizarProduto);
            this.Controls.Add(this.txtPrecoVenda);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.spinQuantidade);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNomeProduto);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_ProdutoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Informaçoes";
            ((System.ComponentModel.ISupportInitialize)(this.txtDescricao.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoVenda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeProduto.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.SimpleButton btnAtualizarProduto;
        private DevExpress.XtraEditors.TextEdit txtPrecoVenda;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinQuantidade;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNomeProduto;
    }
}