namespace Appraisal.Module.Controllers
{
    abstract partial class VCtrPerformUpdate
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ActGetUpdate = new DevExpress.ExpressApp.Actions.SimpleAction();
            // 
            // ActGetUpdate
            // 
            this.ActGetUpdate.Caption = "Get Updates";
            this.ActGetUpdate.ConfirmationMessage = "Are you sure?";
            this.ActGetUpdate.Id = "ActGetUpdate";
            this.ActGetUpdate.ImageName = "getdata";
            this.ActGetUpdate.ToolTip = null;
            this.ActGetUpdate.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ActGetUpdate_Execute);
            // 
            // VCtrPerformUpdate
            // 
            this.Actions.Add(this.ActGetUpdate);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ActGetUpdate;
    }
}
