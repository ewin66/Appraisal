using DevExpress;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Templates;
using System.Collections.Generic;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Win.Core;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.ExpressApp.Win.Templates.ActionContainers;
using DevExpress.Utils.CodedUISupport;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

namespace Appraisal.Module.Win.UI
{
    public partial class ProgressForm : PopupFormBase
    {
        public ProgressBarControl ProgressCtr
        {
            get { return pbc; }
        }

        public GridControl Grid
        {
            get { return gridControlMain; }
        }
        protected override XafLayoutControl BottomPanel
        {
            get { return bottomPanel; }
        }
        protected override ViewSiteManager ViewSiteManager
        {
            get { return viewSiteManager; }
        }
        protected override FormStateModelSynchronizer FormStateModelSynchronizer
        {
            get { return formStateModelSynchronizer; }
        }
        public override ICollection<IActionContainer> GetContainers()
        {
            return actionContainersManager.GetContainers();
        }
        public override IActionContainer DefaultContainer
        {
            get { return actionContainersManager.DefaultContainer; }
        }
        public override DevExpress.XtraBars.BarManager BarManager
        {
            get { return xafBarManager; }
        }
        public ProgressForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            if ((int)pbc.EditValue == pbc.Properties.Maximum)
            {
                Close();
            }
        }
    }
}