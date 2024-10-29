using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Xpo;
using LutonesSystem.XPO.LutonesSystem;

namespace LutonesSystem.Forms.Matéria_Prima
{
    public partial class form_InsumosAdicionar : DevExpress.XtraEditors.XtraForm
    {
        public form_InsumosAdicionar()
        {
            InitializeComponent();
            CarregarLookUpFornecedores();
        }

        private void CarregarLookUpFornecedores()
        {
            //using (LutonesSystemContext db = new LutonesSystemContext())
            //{
            //    lookFornecedor.Properties.DataSource = db.tb_fornecedores.ToList();
            //    lookFornecedor.Properties.ValueMember = "id_fornecedor";
            //    lookFornecedor.Properties.DisplayMember = "fo_nome";
            //}

            UnitOfWork uou = new UnitOfWork(XpoDefault.DataLayer);

            var query =
                from fornecedor in new XPQuery<tb_fornecedoresXPO>(uou)
                orderby fornecedor.for_nome descending
                select new
                {
                    fornecedor.for_id,
                    fornecedor.for_nome,
                    fornecedor.for_cnpj,
                    fornecedor.for_telefone,
                    fornecedor.for_email,
                    fornecedor.for_data_cadastro
                };

            var fornecedores = query.ToList();

            lookFornecedor.Properties.DataSource = fornecedores;
            lookFornecedor.Properties.ValueMember = "for_id";
            lookFornecedor.Properties.DisplayMember = "for_nome";

        }
        private void btnCadastrarInsumos_Click(object sender, EventArgs e)
        {
            tb_insumos novoInsumo = new tb_insumos();
            novoInsumo.in_nome = txtNomeInsumo.Text;
            novoInsumo.in_unidade_medida = cmbUnidadeMedida.Text;
            novoInsumo.in_preco_unitario = Convert.ToDecimal(txtPrecoUnitario.Text.Replace("R$ ", ""));
            novoInsumo.in_quantidade_estoque = Convert.ToInt32(spinQuantidade.EditValue);
            novoInsumo.in_fk_id_fornecedores = Convert.ToInt32(lookFornecedor.EditValue);

            using (LutonesSystemContext context = new LutonesSystemContext())
            {
                context.tb_insumos.Add(novoInsumo);
                context.SaveChanges();
            }

            XtraMessageBox.Show("Insumo cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}