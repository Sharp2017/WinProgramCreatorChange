namespace WinProgramCreatorChange
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Views.Grid.GridView gvProgram;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.colProgramID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProgramTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatorUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProgramLibName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDateTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPrograms = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bItemUserName = new DevExpress.XtraBars.BarEditItem();
            this.txtUserName = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnQueryPrograms = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeCrator = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.lblQueryInfo = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            gvProgram = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(gvProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            this.SuspendLayout();
            // 
            // gvProgram
            // 
            gvProgram.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProgramID,
            this.colProgramTitle,
            this.colCreatorUserName,
            this.colCreatorUser,
            this.colProgramLibName,
            this.colFolderName,
            this.colCreateDateTime});
            gvProgram.GridControl = this.gcPrograms;
            gvProgram.Name = "gvProgram";
            gvProgram.OptionsBehavior.Editable = false;
            gvProgram.OptionsBehavior.ReadOnly = true;
            gvProgram.OptionsCustomization.AllowFilter = false;
            gvProgram.OptionsCustomization.AllowQuickHideColumns = false;
            gvProgram.OptionsCustomization.AllowSort = false;
            gvProgram.OptionsSelection.MultiSelect = true;
            gvProgram.OptionsView.ShowGroupPanel = false;
            // 
            // colProgramID
            // 
            this.colProgramID.Caption = "ProgramID";
            this.colProgramID.FieldName = "ProgramID";
            this.colProgramID.Name = "colProgramID";
            this.colProgramID.OptionsColumn.AllowFocus = false;
            this.colProgramID.OptionsColumn.AllowSize = false;
            this.colProgramID.OptionsColumn.FixedWidth = true;
            this.colProgramID.Width = 60;
            // 
            // colProgramTitle
            // 
            this.colProgramTitle.Caption = "节目名称";
            this.colProgramTitle.FieldName = "ProgramTitle";
            this.colProgramTitle.Name = "colProgramTitle";
            this.colProgramTitle.OptionsColumn.FixedWidth = true;
            this.colProgramTitle.OptionsColumn.ReadOnly = true;
            this.colProgramTitle.Visible = true;
            this.colProgramTitle.VisibleIndex = 0;
            this.colProgramTitle.Width = 200;
            // 
            // colCreatorUserName
            // 
            this.colCreatorUserName.Caption = "创建者";
            this.colCreatorUserName.FieldName = "CreatorUserName";
            this.colCreatorUserName.Name = "colCreatorUserName";
            this.colCreatorUserName.OptionsColumn.AllowSize = false;
            this.colCreatorUserName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCreatorUserName.OptionsColumn.FixedWidth = true;
            this.colCreatorUserName.Visible = true;
            this.colCreatorUserName.VisibleIndex = 1;
            this.colCreatorUserName.Width = 150;
            // 
            // colCreatorUser
            // 
            this.colCreatorUser.Caption = "CreatorUserID";
            this.colCreatorUser.FieldName = "CreatorUser";
            this.colCreatorUser.Name = "colCreatorUser";
            // 
            // colProgramLibName
            // 
            this.colProgramLibName.Caption = "素材库";
            this.colProgramLibName.FieldName = "ProgramLibName";
            this.colProgramLibName.Name = "colProgramLibName";
            this.colProgramLibName.OptionsColumn.AllowMove = false;
            this.colProgramLibName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colProgramLibName.OptionsColumn.FixedWidth = true;
            this.colProgramLibName.OptionsColumn.ReadOnly = true;
            this.colProgramLibName.Visible = true;
            this.colProgramLibName.VisibleIndex = 2;
            this.colProgramLibName.Width = 150;
            // 
            // colFolderName
            // 
            this.colFolderName.Caption = "类别";
            this.colFolderName.FieldName = "FolderName";
            this.colFolderName.Name = "colFolderName";
            this.colFolderName.OptionsColumn.AllowEdit = false;
            this.colFolderName.OptionsColumn.AllowFocus = false;
            this.colFolderName.OptionsColumn.AllowMove = false;
            this.colFolderName.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colFolderName.OptionsColumn.FixedWidth = true;
            this.colFolderName.OptionsColumn.ReadOnly = true;
            this.colFolderName.Visible = true;
            this.colFolderName.VisibleIndex = 3;
            this.colFolderName.Width = 196;
            // 
            // colCreateDateTime
            // 
            this.colCreateDateTime.Caption = "创建时间";
            this.colCreateDateTime.FieldName = "CreateDateTime";
            this.colCreateDateTime.Name = "colCreateDateTime";
            this.colCreateDateTime.OptionsColumn.AllowMove = false;
            this.colCreateDateTime.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colCreateDateTime.OptionsColumn.FixedWidth = true;
            this.colCreateDateTime.OptionsColumn.ReadOnly = true;
            this.colCreateDateTime.Visible = true;
            this.colCreateDateTime.VisibleIndex = 4;
            this.colCreateDateTime.Width = 352;
            // 
            // gcPrograms
            // 
            this.gcPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPrograms.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gcPrograms.Location = new System.Drawing.Point(0, 27);
            this.gcPrograms.MainView = gvProgram;
            this.gcPrograms.Margin = new System.Windows.Forms.Padding(5);
            this.gcPrograms.Name = "gcPrograms";
            this.gcPrograms.Size = new System.Drawing.Size(1050, 651);
            this.gcPrograms.TabIndex = 10;
            this.gcPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gvProgram});
            this.gcPrograms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
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
            this.bItemUserName,
            this.btnQueryPrograms,
            this.btnChangeCrator,
            this.lblQueryInfo});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtUserName});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bItemUserName, DevExpress.XtraBars.BarItemPaintStyle.Caption),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnQueryPrograms, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeCrator)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.RotateWhenVertical = false;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bItemUserName
            // 
            this.bItemUserName.Caption = "用户名：";
            this.bItemUserName.Edit = this.txtUserName;
            this.bItemUserName.EditValue = "";
            this.bItemUserName.Id = 1;
            this.bItemUserName.Name = "bItemUserName";
            this.bItemUserName.Width = 150;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoHeight = false;
            this.txtUserName.Name = "txtUserName";
            // 
            // btnQueryPrograms
            // 
            this.btnQueryPrograms.Caption = "查询用户的节目";
            this.btnQueryPrograms.Id = 2;
            this.btnQueryPrograms.Name = "btnQueryPrograms";
            this.btnQueryPrograms.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQueryPrograms_ItemClick);
            // 
            // btnChangeCrator
            // 
            this.btnChangeCrator.Caption = "将此用户的节目转给其他用户";
            this.btnChangeCrator.Id = 4;
            this.btnChangeCrator.Name = "btnChangeCrator";
            this.btnChangeCrator.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeCrator_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblQueryInfo)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // lblQueryInfo
            // 
            this.lblQueryInfo.Id = 5;
            this.lblQueryInfo.Name = "lblQueryInfo";
            this.lblQueryInfo.TextAlignment = System.Drawing.StringAlignment.Near;
            this.lblQueryInfo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1050, 27);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 678);
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1050, 31);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1050, 27);
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 651);
            // 
            // FrmMain
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 709);
            this.Controls.Add(this.gcPrograms);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Black";
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "节目制作者转换工具";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(gvProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem bItemUserName;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtUserName;
        private DevExpress.XtraBars.BarButtonItem btnQueryPrograms;
        private DevExpress.XtraGrid.GridControl gcPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn colProgramID;
        private DevExpress.XtraGrid.Columns.GridColumn colProgramTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatorUser;
        private DevExpress.XtraGrid.Columns.GridColumn colProgramLibName;
        private DevExpress.XtraGrid.Columns.GridColumn colFolderName;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDateTime;
        protected DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraBars.BarButtonItem btnChangeCrator;
        private DevExpress.XtraBars.BarStaticItem lblQueryInfo;

    }
}

