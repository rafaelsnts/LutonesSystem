using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace LutonesSystem.Forms.Fornecedores
{
    public partial class form_FornecedorPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_FornecedorPrincipal()
        {
            InitializeComponent();
            CarregarTabelaFornecedores();
        }

        public void CarregarTabelaFornecedores()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();

            linqInstantFeedbackSource.KeyExpression = "for_id";
            linqInstantFeedbackSource.DefaultSorting = "for_nome ASC";

            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridFornecedores.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {
        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            LutonesSystemContext context = new LutonesSystemContext();
            var query =
                from fornecedor in context.tb_fornecedores
                orderby fornecedor.for_nome ascending
                select new
                {
                    fornecedor.for_id,
                    fornecedor.for_nome,
                    fornecedor.for_cnpj,
                    fornecedor.for_telefone,
                    fornecedor.for_email,
                    fornecedor.for_data_cadastro
                };
            e.QueryableSource = query;
        }

        private void btnDeletarFornecedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFornecedores.GetFocusedRowCellValue("for_id");
            int idFornecedor = Convert.ToInt32(linhaSelecionada);

            if (XtraMessageBox.Show("Deseja realmente deletar o fornecedor?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (LutonesSystemContext context = new LutonesSystemContext())
                {
                    var fornecedor = context.tb_fornecedores.Find(idFornecedor);

                    var insumosAssociados = context.tb_insumos.Any(i => i.in_fk_id_fornecedores == idFornecedor);
                    if (insumosAssociados)
                    {
                        XtraMessageBox.Show("Não é possível deletar este fornecedor, pois ele possui insumos associados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    context.tb_fornecedores.Remove(fornecedor);
                    context.SaveChanges();

                    XtraMessageBox.Show("Fornecedor deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTabelaFornecedores();
                }
            }
        }

        private void btnEditarFornecedor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewFornecedores.GetFocusedRowCellValue("for_id");
            int idFornecedor = Convert.ToInt32(linhaSelecionada);

            form_FornecedorEditar formFornecedorEditar = new form_FornecedorEditar();
            formFornecedorEditar.FornecedorId = idFornecedor;
            formFornecedorEditar.ShowDialog();
            CarregarTabelaFornecedores();
        }

        private void viewFornecedores_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupFornecedores.ShowPopup(gridFornecedores.PointToScreen(e.Point));
            }
        }
    }
}