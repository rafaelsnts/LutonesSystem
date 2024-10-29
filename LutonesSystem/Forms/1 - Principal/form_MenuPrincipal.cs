using LutonesSystem.Forms.Fornecedores;

namespace LutonesSystem.Forms._1___Principal
{
    public partial class form_MenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnFornecedorPrincipalMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_FornecedorPrincipal fornecedorPrincipalMenu = new form_FornecedorPrincipal();
            fornecedorPrincipalMenu.ShowDialog();

        }

        private void btnAdicionarFornecedorMenu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            form_FornecedorAdicionar fornecedorAdicionarMenu = new form_FornecedorAdicionar();
            fornecedorAdicionarMenu.ShowDialog();
        }
    }
}