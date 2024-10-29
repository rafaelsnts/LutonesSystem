using DevExpress.XtraEditors;
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
    public partial class form_FuncionarioAdicionar : DevExpress.XtraEditors.XtraForm
    {
        public form_FuncionarioAdicionar()
        {
            InitializeComponent();
        }

        private void btnAdicionarfuncionario_Click(object sender, EventArgs e)
        {
            tb_funcionarios novoFuncionario = new tb_funcionarios();
            novoFuncionario.fun_data_cadastro = DateTime.Now;
            novoFuncionario.fun_nome = txtNomeFuncionario.Text;
            novoFuncionario.fun_cargo = cmbCargoFuncionario.Text;

            using (LutonesSystemContext context = new LutonesSystemContext())
            {
                context.tb_funcionarios.Add(novoFuncionario);
                context.SaveChanges();

                XtraMessageBox.Show("Funcionário adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }
    }
}