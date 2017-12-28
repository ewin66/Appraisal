using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System.Data;
using System.Threading.Tasks;
using Appraisal.Module.BusinessObjects.Appraisaldb;
using Appraisal.Module.Core;
using Appraisal.Module.Model;
using static System.Double;
using static System.Int16;


namespace Appraisal.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public abstract partial class VCtrPerformUpdate : ViewController
    {
        protected VCtrPerformUpdate()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
            Dictionary<string, int[]> data = new Dictionary<string, int[]>();
            data.Add("", new []{1,2,3});
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
            Inti();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
            Distroy();
        }

        private void ActGetUpdate_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += worker_DoWork;
            worker.RunWorkerAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            IObjectSpace objectSpace = Application.CreateObjectSpace();
            BusinessObjects.Appraisaldb.options option = SqlOp.GetOptionalue(objectSpace, Types.OptionsType.FilesPath.ToString());

            ObservableCollection<UpdateFile> fileslst = new ObservableCollection<UpdateFile>();
            ShowDialog(fileslst);
            string[] files = Directory.GetFiles(option.option_value, "*.xlsx", SearchOption.AllDirectories);
            ProgressMax = files.Length;
            ProgressValue = 0;

            foreach (string file in files)
                fileslst.Add(new UpdateFile(file));


            foreach (UpdateFile file in fileslst)
            {
                ProgressValue = ProgressValue + 1;
                try
                {
                    //1 Personal, 3 Behaviours, 4 Objectives, 5 Development, 6 ObjectivesNy
                    //0 Personal, 1 Behaviours, 2 Objectives, 3 Development, 4 ObjectivesNy
                    List<DataTable> sheets = ExcelApi.LoadExcelFile_VBA(file.FilePath, new[] { 1, 3, 4, 5, 7 });

                    //Personal
                    int personnelId;// = Convert.ToInt32(sheets[0].Rows[12][2]);
                    if (!int.TryParse(sheets[0].Rows[12][2].ToString(), out personnelId))
                    {
                        personnelId = (DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Second +
                                      DateTime.Now.Millisecond) * -1;
                    }
                    personnel_master personnel = objectSpace.GetObjectByKey<personnel_master>(personnelId);
                    if (personnel == null)
                    {
                        personnel = objectSpace.CreateObject<personnel_master>();
                        personnel.personnel_id = personnelId;
                    }
                    personnel.personnel_name = sheets[0].Rows[11][2].ToString();
                    personnel.job_name = sheets[0].Rows[13][2].ToString();
                    personnel.time_in_current_role = sheets[0].Rows[16][5].ToString();
                    if (DateTime.TryParse(sheets[0].Rows[14][5].ToString(), out DateTime reviewDate))
                        personnel.review_date = reviewDate;
                    personnel.job_description = sheets[0].Rows[17][5].ToString();
                    if (int.TryParse(sheets[0].Rows[12][7].ToString(), out int managerId))
                        personnel.manager_id = managerId;
                    personnel.manager_name = sheets[0].Rows[11][7].ToString();
                    personnel.last_update_date = DateTime.Now;
                    personnel.file_path = file.FilePath;

                    //Delete before insert
                    objectSpace.Delete(personnel.objectives);
                    objectSpace.Delete(personnel.objective_next_years);
                    objectSpace.Delete(personnel.developments);

                    //Behaviours
                    GetBehaviours(personnel, sheets);
                    //Objectives
                    GetObjectives(sheets, personnel, objectSpace);
                    //Development
                    GetDevelopment(sheets[3], personnel, objectSpace);
                    //ObjectivesNy
                    GetObjectivesNy(sheets[4], personnel, objectSpace);

                    objectSpace.CommitChanges();
                    file.OpResult = Types.OperationResult.Success;
                    Refresh();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    file.OpResult = Types.OperationResult.Fail;
                    file.ResultMsg = exception.Message;
                }
            }
        }
        private static void GetBehaviours(personnel_master personnel, IReadOnlyList<DataTable> sheets)
        {
            personnel.ENTREPRENEURIAL_LEADERSHIP_EVIDENCE = sheets[1].Rows[14][4].ToString();
            if (TryParse(sheets[1].Rows[14][8].ToString(), out short entrepreneurialLeadershipRating))
                personnel.ENTREPRENEURIAL_LEADERSHIP_RATING = entrepreneurialLeadershipRating;
            if (TryParse(sheets[1].Rows[14][10].ToString(), out double entrepreneurialLeadershipWeight))
                personnel.ENTREPRENEURIAL_LEADERSHIP_Weight = entrepreneurialLeadershipWeight;

            personnel.PERFORMANCE_EVIDENCE = sheets[1].Rows[24][4].ToString();
            if (TryParse(sheets[1].Rows[24][8].ToString(), out short performanceRating))
                personnel.PERFORMANCE_RATING = performanceRating;
            if (TryParse(sheets[1].Rows[24][10].ToString(), out double performanceWeight))
                personnel.PERFORMANCE_Weight = performanceWeight;

            personnel.CONSUMER_FOCUSED_EVIDENCE = sheets[1].Rows[31][4].ToString();
            if (TryParse(sheets[1].Rows[31][8].ToString(), out short consumerFocusedRating))
                personnel.CONSUMER_FOCUSED_RATING = consumerFocusedRating;
            if (TryParse(sheets[1].Rows[31][10].ToString(), out double consumerFocusedWeight))
                personnel.CONSUMER_FOCUSED_Weight = consumerFocusedWeight;

            personnel.ACCOUNTABILITY_EVIDENCE = sheets[1].Rows[41][4].ToString();
            if (TryParse(sheets[1].Rows[41][8].ToString(), out short accountabilityRating))
                personnel.ACCOUNTABILITY_RATING = accountabilityRating;
            if (TryParse(sheets[1].Rows[41][10].ToString(), out double accountabilityWeight))
                personnel.ACCOUNTABILITY_Weight = accountabilityWeight;

            personnel.TEAM_WORK_EVIDENCE = sheets[1].Rows[49][4].ToString();
            if (TryParse(sheets[1].Rows[49][8].ToString(), out short teamWorkRating))
                personnel.TEAM_WORK_RATING = teamWorkRating;
            if (TryParse(sheets[1].Rows[49][10].ToString(), out double teamWorkWeight))
                personnel.TEAM_WORK_Weight = teamWorkWeight;

            personnel.QUALITY_EVIDENCE = sheets[1].Rows[58][4].ToString();
            if (TryParse(sheets[1].Rows[58][8].ToString(), out short qualityRating))
                personnel.QUALITY_RATING = qualityRating;
            if (TryParse(sheets[1].Rows[58][10].ToString(), out double qualityWeight))
                personnel.QUALITY_Weight = qualityWeight;
        }
        private static void GetObjectives(IReadOnlyList<DataTable> sheets, personnel_master personnel, IObjectSpace objectSpace)
        {
            for (int objInx = 0; objInx < sheets[2].Rows.Count; objInx++)
            {
                if (sheets[2].Rows[objInx][0].ToString() == "Appraisee: Describe your overall performance over the past year")
                {
                    objInx++;
                    personnel.emp_past_year_description_appraisee = sheets[2].Rows[objInx][0].ToString();
                    objInx += 12;
                    if (TryParse(sheets[2].Rows[objInx][9].ToString(), out short empRating))
                        personnel.emp_rating = empRating;
                    objInx += 13;
                    personnel.manager_past_year_description_appraisee = sheets[2].Rows[objInx][0].ToString();
                    objInx += 12;
                    if (TryParse(sheets[2].Rows[objInx][9].ToString(), out short managerRating))
                        personnel.manager_rating = managerRating;
                    objInx += 12;
                    personnel.appraisee_comments = sheets[2].Rows[objInx][0].ToString();

                    break;
                }
                if (sheets[2].Rows[objInx][0].ToString() != "Objective")
                    continue;
                objInx++;
                while (sheets[2].Rows[objInx][0].ToString().Trim() == string.Empty)
                {
                    objInx++;
                }
                //if (sheets[2].Rows[objInx + 1][0].ToString().Trim() == string.Empty)
                //    continue;
                //objInx++;
                objective obv = objectSpace.CreateObject<objective>();
                obv.objective1 = sheets[2].Rows[objInx][0].ToString();
                obv.personnel_id = personnel;
                obv.base_start_point = sheets[2].Rows[objInx][6].ToString();
                obv.method_actions = sheets[2].Rows[objInx][9].ToString();
                if (TryParse(sheets[2].Rows[objInx][14].ToString(), out double weight))
                    obv.weight = weight;
                if (DateTime.TryParse(sheets[2].Rows[objInx][15].ToString(), out DateTime timeInCurrentRole))
                    obv.timing_to_complete = timeInCurrentRole;
                if (TryParse(sheets[2].Rows[objInx][16].ToString(), out short rating))
                    obv.rating = rating;
                objInx += 7;
                obv.employee_comment = sheets[2].Rows[objInx][0].ToString();
                obv.manager_comment = sheets[2].Rows[objInx][6].ToString();
            }
        }
        private static void GetDevelopment(DataTable sheet, personnel_master personnel, IObjectSpace objectSpace)
        {
            for (int objInx = 17; objInx < sheet.Rows.Count; objInx++)
            {
                if (sheet.Rows[objInx][0].ToString() == "Possible Career Development")
                {
                    personnel.possible_career_development_emp = sheet.Rows[objInx + 2][0].ToString();
                    personnel.possible_career_development_manager = sheet.Rows[objInx + 10][0].ToString();
                    personnel.possible_career_development_how = sheet.Rows[objInx + 18][0].ToString();
                    break;
                }
                if (sheet.Rows[objInx][0].ToString() == string.Empty)
                    continue;
                development dev = objectSpace.CreateObject<development>();
                dev.personnel_id = personnel;
                dev.gap_description = sheet.Rows[objInx][0].ToString();
                if (DateTime.TryParse(sheet.Rows[objInx][9].ToString(), out DateTime reviewDate))
                    dev.review_date = reviewDate;

                dev.how_10 = sheet.Rows[objInx][3].ToString();
                dev.how_20 = sheet.Rows[objInx + 1][3].ToString();
                dev.how_70 = sheet.Rows[objInx + 2][3].ToString();

                if (DateTime.TryParse(sheet.Rows[objInx][8].ToString(), out DateTime date10))
                    dev.date_10 = date10;
                if (DateTime.TryParse(sheet.Rows[objInx + 1][8].ToString(), out DateTime date20))
                    dev.date_20 = date20;
                if (DateTime.TryParse(sheet.Rows[objInx + 2][8].ToString(), out DateTime date70))
                    dev.date_70 = date70;

                objInx += 2;
            }
        }
        private static void GetObjectivesNy(DataTable sheet, personnel_master personnel, IObjectSpace objectSpace)
        {
            for (int objInx = 11; objInx < sheet.Rows.Count; objInx++)
            {
                if (sheet.Rows[objInx][0].ToString() == string.Empty)
                    continue;
                objective_next_year obv = objectSpace.CreateObject<objective_next_year>();
                obv.objective = sheet.Rows[objInx][0].ToString();
                obv.personnel_id = personnel;
                obv.base_start_point = sheet.Rows[objInx][6].ToString();
                obv.method_actions = sheet.Rows[objInx][9].ToString();
                if (DateTime.TryParse(sheet.Rows[objInx][13].ToString(), out DateTime timeInCurrentRole))
                    obv.timing_to_complete = timeInCurrentRole;
                if (TryParse(sheet.Rows[objInx][14].ToString(), out short rating))
                    obv.rating = rating;
                objInx += 3;
                //obv.Save();
            }
            

            //for (int objInx = 8; objInx < sheet.Rows.Count; objInx++)
            //{
            //    if (sheet.Rows[objInx][0].ToString() != "Objective")
            //        continue;
            //    if (sheet.Rows[objInx + 2][0].ToString().Trim() == string.Empty)
            //        continue;
            //    objInx += 2;
            //    objective_next_year obv = objectSpace.CreateObject<objective_next_year>();
            //    obv.objective = sheet.Rows[objInx][0].ToString();
            //    obv.personnel_id = personnel;
            //    obv.base_start_point = sheet.Rows[objInx][6].ToString();
            //    obv.method_actions = sheet.Rows[objInx][9].ToString();
            //    if (DateTime.TryParse(sheet.Rows[objInx][13].ToString(), out DateTime timeInCurrentRole))
            //        obv.timing_to_complete = timeInCurrentRole;
            //    if (TryParse(sheet.Rows[objInx][14].ToString(), out short rating))
            //        obv.rating = rating;
            //}
        }

        protected abstract void Inti();
        protected abstract void Distroy();
        protected abstract void ShowDialog(ObservableCollection<UpdateFile> datda);
        protected abstract void HideDialog();
        protected abstract int ProgressMax { get; set; }
        protected abstract int ProgressValue { get; set; }
        protected abstract void Refresh();
    }
}
