using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Fornecedores
{
    public partial class form_FornecedorEditar : DevExpress.XtraEditors.XtraForm
    {
        LutonesSystemContext context = new LutonesSystemContext();
        private int _fornecedorId;

        public int FornecedorId
        {
            get
            {
                return _fornecedorId;
            }
            set
            {
                _fornecedorId = value;
                var fornecedor = context.tb_fornecedores.Find(_fornecedorId);
                txtDataCadastroFornecedor.EditValue = fornecedor.for_data_cadastro.Value.Date;
                txtNomeFornecedor.Text = fornecedor.for_nome;
                txtCnpjFornecedor.Text = fornecedor.for_cnpj;
                txtTelefoneFornecedor.Text = fornecedor.for_telefone;
                txtEmailFornecedor.Text = fornecedor.for_email;


            }
        }
        public form_FornecedorEditar()
        {
            InitializeComponent();
        }

        private void btnAtualizarFornecedor_Click_1(object sender, EventArgs e)
        {
            var fornecedor = context.tb_fornecedores.Find(_fornecedorId);
            fornecedor.for_data_cadastro = DateTime.Parse(txtDataCadastroFornecedor.Text);
            fornecedor.for_nome = txtNomeFornecedor.Text;
            fornecedor.for_cnpj = txtCnpjFornecedor.Text;
            fornecedor.for_telefone = txtTelefoneFornecedor.Text;
            fornecedor.for_email = txtEmailFornecedor.Text;

            context.tb_fornecedores.Update(fornecedor);
            context.SaveChanges();

            XtraMessageBox.Show("Fornecedor atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //LimparTextBoxFornecedor();
        }
    }
}