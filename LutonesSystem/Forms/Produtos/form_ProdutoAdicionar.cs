using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Produtos
{
    public partial class form_ProdutoAdicionar : DevExpress.XtraEditors.XtraForm
    {
        public form_ProdutoAdicionar()
        {
            InitializeComponent();
        }
        private void btnCadastrarProduto_Click_1(object sender, EventArgs e)
        {
            tb_produtos novoProduto = new tb_produtos();
            novoProduto.prd_nome = txtNomeProduto.Text;
            novoProduto.prd_descricao = txtDescricao.Text;
            novoProduto.prd_preco_venda = Convert.ToDecimal(txtPrecoVenda.Text.Replace("R$ ", ""));
            novoProduto.prd_qtd_estoque = Convert.ToInt32(spinQuantidade.EditValue);

            using (LutonesSystemContext context = new LutonesSystemContext())
            {
                context.tb_produtos.Add(novoProduto);
                context.SaveChanges();

                XtraMessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}