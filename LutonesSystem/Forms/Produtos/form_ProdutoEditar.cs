using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Produtos
{
    public partial class form_ProdutoEditar : DevExpress.XtraEditors.XtraForm
    {
        LutonesSystemContext context = new LutonesSystemContext();
        private tb_produtos produtoDaTela;

        private int _produtoId;

        public int ProdutosId
        {
            get
            {
                return _produtoId;
            }
            set
            {
                _produtoId = value;
                produtoDaTela = context.tb_produtos.Find(_produtoId);
                txtNomeProduto.Text = produtoDaTela.prd_nome;
                txtDescricao.Text = produtoDaTela.prd_descricao;
                txtPrecoVenda.Text = produtoDaTela.prd_preco_venda.ToString();
                spinQuantidade.EditValue = produtoDaTela.prd_qtd_estoque.ToString();
            }
        }
        public form_ProdutoEditar()
        {
            InitializeComponent();
        }

        private void btnAtualizarProduto_Click(object sender, EventArgs e)
        {
            produtoDaTela = context.tb_produtos.Find(_produtoId);
            produtoDaTela.prd_nome = txtNomeProduto.Text;
            produtoDaTela.prd_descricao = txtDescricao.Text;
            produtoDaTela.prd_preco_venda = Convert.ToDecimal(txtPrecoVenda.Text.Replace("R$ ", ""));
            produtoDaTela.prd_qtd_estoque = Convert.ToInt32(spinQuantidade.EditValue);

            context.tb_produtos.Update(produtoDaTela);
            context.SaveChanges();

            XtraMessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}