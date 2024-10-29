using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Funcionários
{
    public partial class form_FuncionarioPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_FuncionarioPrincipal()
        {
            InitializeComponent();
        }

        private void btnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExcluir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void viewFuncionarios_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == GridHitTest.RowCell)
            {
                e.Allow = false;
                popupFuncionarios.ShowPopup(gridFuncionarios.PointToScreen(e.Point));
            }
        }
    }
}