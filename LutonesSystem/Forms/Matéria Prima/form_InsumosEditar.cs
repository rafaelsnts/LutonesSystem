using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace LutonesSystem.Forms.Matéria_Prima
{
    public partial class form_InsumosEditar : DevExpress.XtraEditors.XtraForm
    {
        LutonesSystemContext context = new LutonesSystemContext();
        private int _insumoId;

        public int InsumosId
        {
            get
            {
                return _insumoId;
            }
            set
            {
                _insumoId = value;
                var insumo = context.tb_insumos.Find(_insumoId);
                txtNomeInsumo.Text = insumo.in_nome;
                cmbUnidadeMedida.Text = insumo.in_unidade_medida;
                txtPrecoUnitario.Text = insumo.in_preco_unitario.ToString();
                spinQuantidade.EditValue = insumo.in_quantidade_estoque.ToString();
                lookFornecedor.EditValue = insumo.in_fk_id_fornecedores.ToString();


            }
        }
        public form_InsumosEditar()
        {
            InitializeComponent();
        }

        private void btnAtualizarInsumo_Click(object sender, EventArgs e)
        {
            var insumo = context.tb_insumos.Find(_insumoId);
            insumo.in_nome = txtNomeInsumo.Text;
            insumo.in_unidade_medida = cmbUnidadeMedida.Text;
            insumo.in_preco_unitario = Convert.ToDecimal(txtPrecoUnitario.Text.Replace("R$ ", ""));
            insumo.in_quantidade_estoque = Convert.ToInt32(spinQuantidade.EditValue);
            insumo.in_fk_id_fornecedores = Convert.ToInt32(lookFornecedor.EditValue);

            context.tb_insumos.Update(insumo);
            context.SaveChanges();

            XtraMessageBox.Show("Insumo atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}