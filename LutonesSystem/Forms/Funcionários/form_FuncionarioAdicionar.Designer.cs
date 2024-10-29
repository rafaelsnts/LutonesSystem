namespace LutonesSystem.Forms.Funcionários
{
    partial class form_FuncionarioAdicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtDataCadastroFuncionario = new DevExpress.XtraEditors.DateEdit();
            this.txtNomeFuncionario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbCargoFuncionario = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnAdicionarfuncionario = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFuncionario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFuncionario.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(46, 9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(92, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Data de Cadastro:";
            // 
            // dtDataCadastroFuncionario
            // 
            this.dtDataCadastroFuncionario.EditValue = null;
            this.dtDataCadastroFuncionario.Location = new System.Drawing.Point(46, 28);
            this.dtDataCadastroFuncionario.Name = "dtDataCadastroFuncionario";
            this.dtDataCadastroFuncionario.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCadastroFuncionario.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtDataCadastroFuncionario.Size = new System.Drawing.Size(182, 20);
            this.dtDataCadastroFuncionario.TabIndex = 1;
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(46, 91);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(182, 20);
            this.txtNomeFuncionario.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(46, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Nome:";
            // 
            // cmbCargoFuncionario
            // 
            this.cmbCargoFuncionario.FormattingEnabled = true;
            this.cmbCargoFuncionario.Location = new System.Drawing.Point(46, 149);
            this.cmbCargoFuncionario.Name = "cmbCargoFuncionario";
            this.cmbCargoFuncionario.Size = new System.Drawing.Size(182, 21);
            this.cmbCargoFuncionario.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(46, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cargo:";
            // 
            // btnAdicionarfuncionario
            // 
            this.btnAdicionarfuncionario.Location = new System.Drawing.Point(46, 209);
            this.btnAdicionarfuncionario.Name = "btnAdicionarfuncionario";
            this.btnAdicionarfuncionario.Size = new System.Drawing.Size(182, 33);
            this.btnAdicionarfuncionario.TabIndex = 6;
            this.btnAdicionarfuncionario.Text = "Adicionar";
            this.btnAdicionarfuncionario.Click += new System.EventHandler(this.btnAdicionarfuncionario_Click);
            // 
            // form_FuncionarioAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 275);
            this.Controls.Add(this.btnAdicionarfuncionario);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.cmbCargoFuncionario);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.dtDataCadastroFuncionario);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "form_FuncionarioAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFuncionario.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtDataCadastroFuncionario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNomeFuncionario.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtDataCadastroFuncionario;
        private DevExpress.XtraEditors.TextEdit txtNomeFuncionario;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbCargoFuncionario;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnAdicionarfuncionario;
    }
}