using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Appraisal.Module.Interface;

namespace Appraisal.Win.Classes
{
    public class PerformUpdate : Module.Interface.IPerformUpdate
    {
        private int _progressMax;
        private int _progressValue;

        public void ShowDialog()
        {
            throw new NotImplementedException();
            //using (Form form = new Form())
            //{
            //    ProgressBarControl progressBarControl = new ProgressBarControl();
            //    SimpleButton cancelProgress = new SimpleButton();

            //    form.Size = new Size(200, 50);
            //    form.TopMost = true;
            //    form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //    form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            //    form.CancelButton = cancelProgress;
            //    form.StartPosition = FormStartPosition.CenterScreen;
            //    form.FormBorderStyle = FormBorderStyle.None;
            //    form.Controls.Add((Control)progressBarControl);
            //    form.Controls.Add((Control)cancelProgress);

            //    cancelProgress.Dock = DockStyle.Right;
            //    cancelProgress.Text = "Cancel";
            //    cancelProgress.Size = new Size(50, 50);
            //    cancelProgress.Click += new EventHandler(cancelProgress_Click);

            //    progressBarControl.Size = new Size(150, 50);
            //    progressBarControl.Dock = DockStyle.Left;
            //    progressBarControl.Properties.Step = 1;
            //    progressBarControl.Properties.PercentView = true;
            //    progressBarControl.Properties.Maximum = 100;
            //    progressBarControl.Properties.Minimum = 0;

            //    form.Show();

            //    for (int i = 0; i < 100; i++)
            //    {
            //        ((DevExpress.ExpressApp.ListView)View).CollectionSource.Add(new Something(View.ObjectSpace.Session));
            //        progressBarControl.PerformStep();
            //        cancelProgress.Update();
            //        System.Windows.Forms.Application.DoEvents();
            //    }
            //    form.Close();
            //}
        }

        public void HideDialog()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            throw new NotImplementedException();
        }

        public int ProgressMax
        {
            get { return _progressMax; }
            set { _progressMax = value; }
        }

        public int ProgressValue
        {
            get { return _progressValue; }
            set { _progressValue = value; }
        }
    }
}
