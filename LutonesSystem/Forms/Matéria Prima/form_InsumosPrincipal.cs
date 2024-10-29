using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace LutonesSystem.Forms.Matéria_Prima
{
    public partial class form_InsumosPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_InsumosPrincipal()
        {
            InitializeComponent();
            CarregarTabelaInsumos();
        }

        private void CarregarTabelaInsumos()
        {
            LinqInstantFeedbackSource linqInstantFeedbackSource = new LinqInstantFeedbackSource();

            linqInstantFeedbackSource.KeyExpression = "in_id";
            linqInstantFeedbackSource.DefaultSorting = "in_nome ASC";

            linqInstantFeedbackSource.GetQueryable += LinkqInstantFeedbackSource_GetQueryable;
            linqInstantFeedbackSource.DismissQueryable += LinkqInstantFeedbackSource_DismissQueryable;

            gridInsumos.DataSource = linqInstantFeedbackSource;
        }

        private void LinkqInstantFeedbackSource_DismissQueryable(object sender, GetQueryableEventArgs e)
        {

        }

        private void LinkqInstantFeedbackSource_GetQueryable(object sender, GetQueryableEventArgs e)
        {
            LutonesSystemContext context = new LutonesSystemContext();
            var query =
                from insumo in context.tb_insumos
                orderby insumo.in_nome ascending
                select new
                {
                    insumo.in_id,
                    insumo.in_nome,
                    insumo.in_unidade_medida,
                    insumo.in_preco_unitario,
                    insumo.in_quantidade_estoque,
                    insumo.in_fk_id_fornecedores
                };
            e.QueryableSource = query;
        }

        private void btnDeletar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewInsumos.GetFocusedRowCellValue("in_id");
            int idInsumo = Convert.ToInt32(linhaSelecionada);



            if (XtraMessageBox.Show("Deseja realmente deletar o insumo selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (LutonesSystemContext context = new LutonesSystemContext())
                {
                    var insumo = context.tb_insumos.Find(idInsumo);
                    context.tb_insumos.Remove(insumo);  
                    context.SaveChanges();

                    XtraMessageBox.Show("Insumo deletado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarTabelaInsumos();
                }
            }

        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var linhaSelecionada = viewInsumos.GetFocusedRowCellValue("in_id");
            int idInsumo = Convert.ToInt32(linhaSelecionada);

            form_InsumosEditar formInsumoEditar = new form_InsumosEditar();
            formInsumoEditar.InsumosId = idInsumo;
            formInsumoEditar.ShowDialog();
        }

        private void viewInsumos_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {

            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupInsumos.ShowPopup(gridInsumos.PointToScreen(e.Point));
            }
        }
    }
}