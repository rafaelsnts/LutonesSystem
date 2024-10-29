using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Fornecedores
{
    public partial class form_FornecedorAdicionar : DevExpress.XtraEditors.XtraForm
    {
        //private form_FornecedorPrincipal _formFornecedorPrincipal;

        public form_FornecedorAdicionar()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.form_FornecedorAdicionar_Load);

        }

        private void LimparTextBoxFornecedor()
        {

            txtNomeFornecedor.Text = "";
            txtCnpjFornecedor.Text = "";
            txtTelefoneFornecedor.Text = "";
            txtEmailFornecedor.Text = "";
        }

        private void form_FornecedorAdicionar_Load(object sender, EventArgs e)
        {
            dtDataCadastroFornecedor.EditValue = DateTime.Today.Date;
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            tb_fornecedores novoFornecedor = new tb_fornecedores();
            novoFornecedor.for_data_cadastro = dtDataCadastroFornecedor.DateTimeOffset.DateTime;
            novoFornecedor.for_nome = txtNomeFornecedor.Text;
            novoFornecedor.for_cnpj = txtCnpjFornecedor.Text;
            novoFornecedor.for_telefone = txtTelefoneFornecedor.Text.Replace("( ", "").Replace(") ", "").Replace("- ", "");
            novoFornecedor.for_email = txtEmailFornecedor.Text;

            using (LutonesSystemContext context = new LutonesSystemContext())
            {
                context.tb_fornecedores.Add(novoFornecedor);
                context.SaveChanges();
            }

            XtraMessageBox.Show("Fornecedor adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimparTextBoxFornecedor();
            
        }
    }
}