using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace LutonesSystem.Forms.Produtos
{
    public partial class form_ProdutoPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_ProdutoPrincipal()
        {
            InitializeComponent();
            CarregarTabelaProdutos();
        }

        private void CarregarTabelaProdutos()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();

            linqInstantFeedbackSource.KeyExpression = "prd_id";
            linqInstantFeedbackSource.DefaultSorting = "prd_nome ASC";

            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridProdutos.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {

        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            LutonesSystemContext context = new LutonesSystemContext();
            var query =
                from produto in context.tb_produtos
                orderby produto.prd_nome ascending
                select new
                {
                    produto.prd_id,
                    produto.prd_nome,
                    produto.prd_descricao,
                    produto.prd_preco_venda,
                    produto.prd_qtd_estoque
                };
            e.QueryableSource = query;
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Deseja realmente deletar o produto selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int idProduto = Convert.ToInt32(viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prd_id"));

                using (LutonesSystemContext context = new LutonesSystemContext())
                {
                    tb_produtos produto = context.tb_produtos.Find(idProduto);
                    context.tb_produtos.Remove(produto);
                    context.SaveChanges();
                }

                XtraMessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idProduto = Convert.ToInt32(viewProdutos.GetRowCellValue(viewProdutos.FocusedRowHandle, "prd_id"));
            int linhaSelecionada = viewProdutos.FocusedRowHandle;

            if (XtraMessageBox.Show("Deseja realmente deletar o produto selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (LutonesSystemContext context = new LutonesSystemContext())
                {
                    tb_produtos produto = context.tb_produtos.Find(idProduto);
                    context.tb_produtos.Remove(produto);
                    context.SaveChanges();
                }

                XtraMessageBox.Show("Produto deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            viewProdutos.FocusedRowHandle = linhaSelecionada;
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewProdutos.GetFocusedRowCellValue("prd_id");
            int idProduto = Convert.ToInt32(linhaSelecionada);

            form_ProdutoEditar formProdutoEditar = new form_ProdutoEditar();
            formProdutoEditar.ProdutosId = idProduto;
            formProdutoEditar.ShowDialog();
        }

        private void viewProdutos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupProdutos.ShowPopup(gridProdutos.PointToScreen(e.Point));
            }
        }
    }
}
