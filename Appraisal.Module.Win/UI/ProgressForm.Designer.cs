using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;
namespace Appraisal.Module.Win.UI
{
    partial class ProgressForm
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



        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressForm));
            DevExpress.ExpressApp.Win.Layout.XafLayoutConstants xafLayoutConstants1 = new DevExpress.ExpressApp.Win.Layout.XafLayoutConstants();
            this.xafBarManager = new DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.cObjectsCreation = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cRecordEdit = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cView = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cPrint = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cEdit = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cOpenObject = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cUndoRedo = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.cExport = new DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem();
            this.actionContainersManager = new DevExpress.ExpressApp.Win.Templates.ActionContainersManager(this.components);
            this.pbc = new DevExpress.XtraEditors.ProgressBarControl();
            this.bottomPanel = new DevExpress.ExpressApp.Win.Layout.XafLayoutControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlMain = new DevExpress.XtraGrid.GridControl();
            this.gridViewMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnFilePath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnOpResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnResultMsg = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.xafLayoutControlItem1 = new DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem();
            this.xafLayoutControlItem2 = new DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem();
            this.xafLayoutControlItemClose = new DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem();
            this.formStateModelSynchronizer = new DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer(this.components);
            this.viewSiteManager = new DevExpress.ExpressApp.Win.Templates.ViewSiteManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItemClose)).BeginInit();
            this.SuspendLayout();
            // 
            // xafBarManager
            // 
            this.xafBarManager.DockControls.Add(this.barDockControlTop);
            this.xafBarManager.DockControls.Add(this.barDockControlBottom);
            this.xafBarManager.DockControls.Add(this.barDockControlLeft);
            this.xafBarManager.DockControls.Add(this.barDockControlRight);
            this.xafBarManager.Form = this;
            this.xafBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.cObjectsCreation,
            this.cRecordEdit,
            this.cView,
            this.cPrint,
            this.cEdit,
            this.cOpenObject,
            this.cUndoRedo,
            this.cExport});
            this.xafBarManager.MaxItemId = 8;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.xafBarManager;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.xafBarManager;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.xafBarManager;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.xafBarManager;
            // 
            // cObjectsCreation
            // 
            resources.ApplyResources(this.cObjectsCreation, "cObjectsCreation");
            this.cObjectsCreation.ContainerId = "ObjectsCreation";
            this.cObjectsCreation.Id = 0;
            this.cObjectsCreation.Name = "cObjectsCreation";
            this.cObjectsCreation.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cRecordEdit
            // 
            resources.ApplyResources(this.cRecordEdit, "cRecordEdit");
            this.cRecordEdit.ContainerId = "RecordEdit";
            this.cRecordEdit.Id = 1;
            this.cRecordEdit.Name = "cRecordEdit";
            this.cRecordEdit.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cView
            // 
            resources.ApplyResources(this.cView, "cView");
            this.cView.ContainerId = "View";
            this.cView.Id = 2;
            this.cView.Name = "cView";
            this.cView.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cPrint
            // 
            resources.ApplyResources(this.cPrint, "cPrint");
            this.cPrint.ContainerId = "Print";
            this.cPrint.Id = 3;
            this.cPrint.Name = "cPrint";
            this.cPrint.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cEdit
            // 
            resources.ApplyResources(this.cEdit, "cEdit");
            this.cEdit.ContainerId = "Edit";
            this.cEdit.Id = 4;
            this.cEdit.Name = "cEdit";
            this.cEdit.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cOpenObject
            // 
            resources.ApplyResources(this.cOpenObject, "cOpenObject");
            this.cOpenObject.ContainerId = "OpenObject";
            this.cOpenObject.Id = 5;
            this.cOpenObject.Name = "cOpenObject";
            this.cOpenObject.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cUndoRedo
            // 
            resources.ApplyResources(this.cUndoRedo, "cUndoRedo");
            this.cUndoRedo.ContainerId = "UndoRedo";
            this.cUndoRedo.Id = 6;
            this.cUndoRedo.Name = "cUndoRedo";
            this.cUndoRedo.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // cExport
            // 
            resources.ApplyResources(this.cExport, "cExport");
            this.cExport.ContainerId = "Export";
            this.cExport.Id = 7;
            this.cExport.Name = "cExport";
            this.cExport.TargetPageCategoryColor = System.Drawing.Color.Empty;
            // 
            // actionContainersManager
            // 
            this.actionContainersManager.ActionContainerComponents.Add(this.cObjectsCreation);
            this.actionContainersManager.ActionContainerComponents.Add(this.cRecordEdit);
            this.actionContainersManager.ActionContainerComponents.Add(this.cView);
            this.actionContainersManager.ActionContainerComponents.Add(this.cPrint);
            this.actionContainersManager.ActionContainerComponents.Add(this.cEdit);
            this.actionContainersManager.ActionContainerComponents.Add(this.cOpenObject);
            this.actionContainersManager.ActionContainerComponents.Add(this.cUndoRedo);
            this.actionContainersManager.ActionContainerComponents.Add(this.cExport);
            this.actionContainersManager.ContextMenuContainers.Add(this.cObjectsCreation);
            this.actionContainersManager.ContextMenuContainers.Add(this.cEdit);
            this.actionContainersManager.ContextMenuContainers.Add(this.cRecordEdit);
            this.actionContainersManager.ContextMenuContainers.Add(this.cUndoRedo);
            this.actionContainersManager.ContextMenuContainers.Add(this.cOpenObject);
            this.actionContainersManager.ContextMenuContainers.Add(this.cView);
            this.actionContainersManager.ContextMenuContainers.Add(this.cExport);
            this.actionContainersManager.ContextMenuContainers.Add(this.cPrint);
            this.actionContainersManager.DefaultContainer = this.cObjectsCreation;
            this.actionContainersManager.Template = this;
            // 
            // pbc
            // 
            resources.ApplyResources(this.pbc, "pbc");
            this.pbc.MenuManager = this.xafBarManager;
            this.pbc.Name = "pbc";
            this.pbc.Properties.ShowTitle = true;
            this.pbc.StyleController = this.bottomPanel;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AllowCustomization = false;
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.BackColor = System.Drawing.Color.Transparent;
            this.bottomPanel.Controls.Add(this.btnClose);
            this.bottomPanel.Controls.Add(this.gridControlMain);
            this.bottomPanel.Controls.Add(this.pbc);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(762, 252, 621, 400);
            this.bottomPanel.OptionsCustomizationForm.ShowLoadButton = false;
            this.bottomPanel.OptionsCustomizationForm.ShowSaveButton = false;
            this.bottomPanel.OptionsView.AllowItemSkinning = false;
            this.bottomPanel.OptionsView.EnableIndentsInGroupsWithoutBorders = true;
            this.bottomPanel.OptionsView.UseSkinIndents = false;
            this.bottomPanel.Root = this.Root;
            xafLayoutConstants1.InvisibleGroupVerticalDistance = 10;
            xafLayoutConstants1.ItemToBorderHorizontalDistance = 10;
            xafLayoutConstants1.ItemToBorderVerticalDistance = 10;
            xafLayoutConstants1.ItemToItemHorizontalDistance = 10;
            xafLayoutConstants1.ItemToItemVerticalDistance = 4;
            xafLayoutConstants1.ItemToTabBorderDistance = 2;
            this.bottomPanel.XafLayoutConstants = xafLayoutConstants1;
            // 
            // btnClose
            // 
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.StyleController = this.bottomPanel;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControlMain
            // 
            resources.ApplyResources(this.gridControlMain, "gridControlMain");
            this.gridControlMain.MainView = this.gridViewMain;
            this.gridControlMain.MenuManager = this.xafBarManager;
            this.gridControlMain.Name = "gridControlMain";
            this.gridControlMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMain});
            // 
            // gridViewMain
            // 
            this.gridViewMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnFilePath,
            this.gridColumnOpResult,
            this.gridColumnResultMsg});
            this.gridViewMain.GridControl = this.gridControlMain;
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.OptionsBehavior.Editable = false;
            this.gridViewMain.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnFilePath
            // 
            resources.ApplyResources(this.gridColumnFilePath, "gridColumnFilePath");
            this.gridColumnFilePath.FieldName = "FilePath";
            this.gridColumnFilePath.Name = "gridColumnFilePath";
            // 
            // gridColumnOpResult
            // 
            resources.ApplyResources(this.gridColumnOpResult, "gridColumnOpResult");
            this.gridColumnOpResult.FieldName = "OpResult";
            this.gridColumnOpResult.Name = "gridColumnOpResult";
            // 
            // gridColumnResultMsg
            // 
            resources.ApplyResources(this.gridColumnResultMsg, "gridColumnResultMsg");
            this.gridColumnResultMsg.FieldName = "ResultMsg";
            this.gridColumnResultMsg.Name = "gridColumnResultMsg";
            // 
            // Root
            // 
            resources.ApplyResources(this.Root, "Root");
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.xafLayoutControlItem1,
            this.xafLayoutControlItem2,
            this.xafLayoutControlItemClose});
            this.Root.Location = new System.Drawing.Point(0, 0);
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(784, 237);
            this.Root.TextVisible = false;
            // 
            // xafLayoutControlItem1
            // 
            this.xafLayoutControlItem1.Control = this.gridControlMain;
            this.xafLayoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.xafLayoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.xafLayoutControlItem1.Name = "xafLayoutControlItem1";
            this.xafLayoutControlItem1.Size = new System.Drawing.Size(784, 205);
            this.xafLayoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.xafLayoutControlItem1.TextVisible = false;
            // 
            // xafLayoutControlItem2
            // 
            this.xafLayoutControlItem2.Control = this.pbc;
            this.xafLayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.xafLayoutControlItem2.Location = new System.Drawing.Point(0, 205);
            this.xafLayoutControlItem2.Name = "xafLayoutControlItem2";
            this.xafLayoutControlItem2.Size = new System.Drawing.Size(698, 32);
            this.xafLayoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.xafLayoutControlItem2.TextVisible = false;
            // 
            // xafLayoutControlItemClose
            // 
            this.xafLayoutControlItemClose.Control = this.btnClose;
            this.xafLayoutControlItemClose.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.xafLayoutControlItemClose.Location = new System.Drawing.Point(698, 205);
            this.xafLayoutControlItemClose.Name = "xafLayoutControlItemClose";
            this.xafLayoutControlItemClose.Size = new System.Drawing.Size(86, 32);
            this.xafLayoutControlItemClose.TextSize = new System.Drawing.Size(0, 0);
            this.xafLayoutControlItemClose.TextVisible = false;
            // 
            // formStateModelSynchronizer
            // 
            this.formStateModelSynchronizer.Form = this;
            // 
            // viewSiteManager
            // 
            this.viewSiteManager.ViewSiteControl = null;
            // 
            // ProgressForm
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.InitialMinimumSize = new System.Drawing.Size(800, 150);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.xafBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xafLayoutControlItemClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.ExpressApp.Win.Templates.Controls.XafBarManager xafBarManager;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cObjectsCreation;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cRecordEdit;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cView;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cPrint;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cEdit;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cOpenObject;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private ActionContainersManager actionContainersManager;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cUndoRedo;
        private DevExpress.ExpressApp.Win.Templates.ActionContainers.ActionContainerBarItem cExport;
        private DevExpress.ExpressApp.Win.Layout.XafLayoutControl bottomPanel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.ExpressApp.Win.Core.FormStateModelSynchronizer formStateModelSynchronizer;
        private ViewSiteManager viewSiteManager;
        private DevExpress.XtraEditors.ProgressBarControl pbc;
        private DevExpress.XtraGrid.GridControl gridControlMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMain;
        private DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem xafLayoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFilePath;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnOpResult;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnResultMsg;
        private DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem xafLayoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.ExpressApp.Win.Layout.XafLayoutControlItem xafLayoutControlItemClose;
    }
}