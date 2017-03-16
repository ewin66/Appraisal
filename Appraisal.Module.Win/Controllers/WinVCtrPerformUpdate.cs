using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Appraisal.Module.Controllers;
using Appraisal.Module.Model;
using DevExpress.Xpf.Core;

namespace Appraisal.Module.Win.Controllers
{
    public class WinVCtrPerformUpdate: VCtrPerformUpdate
    {
        private UI.ProgressForm _dlg;
        private int _progressLable;

        protected override void Inti()
        {
            _dlg = new UI.ProgressForm();
        }

        protected override void ShowDialog(ObservableCollection<UpdateFile> data)
        {
            _dlg.Grid.DataSource = data;
            ((Form) Application.MainWindow.Template).BeginInvoke(new MethodInvoker(() =>
            {
                _dlg.ShowDialog();
            }));
        }

        protected override void HideDialog()
        {
            ((Form)Application.MainWindow.Template).BeginInvoke(new MethodInvoker(() =>
            {
                _dlg.Hide();
            }));
        }

        protected override int ProgressMax
        {
            get { return _dlg.ProgressCtr.Properties.Maximum; }
            set
            {
                ((Form)Application.MainWindow.Template).BeginInvoke(new MethodInvoker(() =>
                {
                    _dlg.ProgressCtr.Properties.Maximum = value;
                }));
            }
        }

        protected override int ProgressValue
        {
            get { return (int)_dlg.ProgressCtr.EditValue; }
            set
            {
                ((Form)Application.MainWindow.Template).BeginInvoke(new MethodInvoker(() =>
                {
                    _dlg.ProgressCtr.EditValue = value;
                }));
            }
        }

        protected override void Distroy()
        {
            _dlg?.Dispose();
        }

        protected override void Refresh()
        {
            _dlg.Grid.RefreshDataSource();
        }
    }
}
