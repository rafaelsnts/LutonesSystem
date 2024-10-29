namespace LutonesSystem.Forms._1___Principal
{
    partial class form_MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnFornecedorPrincipalMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdicionarFornecedorMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.btnProdutoPrincipalMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdicionarProdutoMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.btnMateriaPrimaPrincipalMenu = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdicionarMateriaPrimaMenu = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.btnFornecedorPrincipalMenu,
            this.btnAdicionarFornecedorMenu,
            this.btnProdutoPrincipalMenu,
            this.btnAdicionarProdutoMenu,
            this.btnMateriaPrimaPrincipalMenu,
            this.btnAdicionarMateriaPrimaMenu,
            this.barButtonItem7});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem2),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem3)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Fornecedores";
            this.barSubItem1.Id = 0;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFornecedorPrincipalMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdicionarFornecedorMenu)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnFornecedorPrincipalMenu
            // 
            this.btnFornecedorPrincipalMenu.Caption = "Menu Principal";
            this.btnFornecedorPrincipalMenu.Id = 3;
            this.btnFornecedorPrincipalMenu.Name = "btnFornecedorPrincipalMenu";
            this.btnFornecedorPrincipalMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFornecedorPrincipalMenu_ItemClick);
            // 
            // btnAdicionarFornecedorMenu
            // 
            this.btnAdicionarFornecedorMenu.Caption = "Adicionar";
            this.btnAdicionarFornecedorMenu.Id = 4;
            this.btnAdicionarFornecedorMenu.Name = "btnAdicionarFornecedorMenu";
            this.btnAdicionarFornecedorMenu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdicionarFornecedorMenu_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "Produtos";
            this.barSubItem2.Id = 1;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnProdutoPrincipalMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdicionarProdutoMenu)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // btnProdutoPrincipalMenu
            // 
            this.btnProdutoPrincipalMenu.Caption = "Menu Principal";
            this.btnProdutoPrincipalMenu.Id = 5;
            this.btnProdutoPrincipalMenu.Name = "btnProdutoPrincipalMenu";
            // 
            // btnAdicionarProdutoMenu
            // 
            this.btnAdicionarProdutoMenu.Caption = "Adicionar";
            this.btnAdicionarProdutoMenu.Id = 6;
            this.btnAdicionarProdutoMenu.Name = "btnAdicionarProdutoMenu";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "Matéria Prima";
            this.barSubItem3.Id = 2;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMateriaPrimaPrincipalMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdicionarMateriaPrimaMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem7)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // btnMateriaPrimaPrincipalMenu
            // 
            this.btnMateriaPrimaPrincipalMenu.Caption = "Tela Principal";
            this.btnMateriaPrimaPrincipalMenu.Id = 7;
            this.btnMateriaPrimaPrincipalMenu.Name = "btnMateriaPrimaPrincipalMenu";
            // 
            // btnAdicionarMateriaPrimaMenu
            // 
            this.btnAdicionarMateriaPrimaMenu.Caption = "Adicionar";
            this.btnAdicionarMateriaPrimaMenu.Id = 8;
            this.btnAdicionarMateriaPrimaMenu.Name = "btnAdicionarMateriaPrimaMenu";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Atualizar Quantidade";
            this.barButtonItem7.Id = 9;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1278, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 668);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1278, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 648);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1278, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 648);
            // 
            // form_MenuPrincipal
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 688);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnFornecedorPrincipalMenu;
        private DevExpress.XtraBars.BarButtonItem btnAdicionarFornecedorMenu;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem btnProdutoPrincipalMenu;
        private DevExpress.XtraBars.BarButtonItem btnAdicionarProdutoMenu;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarButtonItem btnMateriaPrimaPrincipalMenu;
        private DevExpress.XtraBars.BarButtonItem btnAdicionarMateriaPrimaMenu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}