using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Navigation;
using LutonesSystem.Forms.Fornecedores;
using LutonesSystem.Forms.Matéria_Prima;
using LutonesSystem.Forms.Produtos;

namespace LutonesSystem.Forms._1___Principal
{
    public partial class form_MenuInicial : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public form_MenuInicial()
        {
            InitializeComponent();
            accordionControl1.OptionsMinimizing.State = AccordionControlState.Minimized;
        }
        public void showChildForminPanel(object Form)
        {
            if (this.pnl_Inicio.Controls.Count > 0)
            {
                this.pnl_Inicio.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_Inicio.Controls.Add(form);
            form.Show();
        }
        private void btnFornecedorPrincipalMenu_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_FornecedorPrincipal());
        }
        private void accordionControl1_MouseLeave(object sender, EventArgs e)
        {
            accordionControl1.OptionsMinimizing.State = AccordionControlState.Minimized;
            MinimizarTodosMenus();
        }

        private void MinimizarTodosMenus()
        {
            foreach (var control in this.Controls)
            {
                if (control is AccordionControl)
                {
                    var element = (AccordionControl)control;
                    element.CollapseAll();
                }
            }
        }
        private void btnFornecedorAdicionarMenu_Click(object sender, EventArgs e)
        {
            form_FornecedorAdicionar fornecedorAdicionarMenu = new form_FornecedorAdicionar();
            fornecedorAdicionarMenu.ShowDialog();

        }

        private void accordionControl1_MouseEnter(object sender, EventArgs e)
        {
            accordionControl1.OptionsMinimizing.State = AccordionControlState.Normal;
        }

        private void accordionTelaInicial_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_Home());
        }

        private void btnInsumosPrincipalMenu_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_InsumosPrincipal());
        }

        private void btnInsumosCadastrar_Click(object sender, EventArgs e)
        {
            form_InsumosAdicionar insumosAdicionar = new form_InsumosAdicionar();
            insumosAdicionar.ShowDialog();
        }

        private void accordionControl1_ExpandStateChanged(object sender, ExpandStateChangedEventArgs e)
        {
            //var teste = (AccordionControl)sender;
            //teste.CollapseAll();
        }

        private void form_MenuInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            MinimizarTodosMenus();
        }

        private void form_MenuInicial_Load(object sender, EventArgs e)
        {
            MinimizarTodosMenus();
        }

        private void btnProdutosPrincipalMenu_Click(object sender, EventArgs e)
        {
            showChildForminPanel(new form_ProdutoPrincipal());
        }

        private void btnCadastrarProdutos_Click(object sender, EventArgs e)
        {
            form_ProdutoAdicionar produtoAdicionar = new form_ProdutoAdicionar();
            produtoAdicionar.ShowDialog();
        }
        //private int contador = 0;
        //private void accordionControl1_CustomDrawElement(object sender, CustomDrawElementEventArgs e)
        //{
        //    var point = new Point(100, 50);
        //    var a = e.ObjectInfo.Element;
        //    if (e.Element.Text == "")
        //    {
        //        if (accordionControl1.OptionsMinimizing.State == AccordionControlState.Normal)
        //        {
        //            e.Handled = true;
        //            e.DrawHeaderBackground();
        //            e.DrawText();
        //            e.Cache.DrawSvgImage(SvgImage.FromFile(@"C:\Users\rafii\Downloads\ok.svg"), point, new SvgPalette());
        //        }
        //        else
        //        {

        //        }

        //    }
        //}
    }
}
