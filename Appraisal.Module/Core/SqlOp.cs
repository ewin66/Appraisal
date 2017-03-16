using System;
using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using Appraisal.Module.BusinessObjects.Appraisaldb;

namespace Appraisal.Module.Core
{
    public static class SqlOp
    {
        public static DateTime GetServerDateTime(Session session)
        {
            DevExpress.Data.Filtering.CriteriaOperator funcNow =
                new DevExpress.Data.Filtering.FunctionOperator(DevExpress.Data.Filtering.FunctionOperatorType.Now);
            return (DateTime)session.Evaluate(typeof(XPObjectType), funcNow, null);
        }
        public static DateTime GetServerDateTime(DevExpress.ExpressApp.IObjectSpace session)
        {
            DevExpress.Data.Filtering.CriteriaOperator funcNow =
                new DevExpress.Data.Filtering.FunctionOperator(DevExpress.Data.Filtering.FunctionOperatorType.Now);
            return (DateTime)session.Evaluate(typeof(XPObjectType), funcNow, null);
        }

        public static options GetOptionValue(Session session, string optionName)
        {
            return  session.FindObject<options>(CriteriaOperator.Parse("acc_option_name = ?", optionName));
            //return session.FindObject<options>(CriteriaOperator.Parse("account_id = ?", Types.OptionsType.FilesPath.ToString()));
        }
        public static options GetOptionalue(DevExpress.ExpressApp.IObjectSpace objectSpace, string optionName)
        {
            return objectSpace.FindObject<options>(CriteriaOperator.Parse("option_name = ?", optionName));
            //return objectSpace.FindObject<options>(CriteriaOperator.Parse("option_value = ?", Types.OptionsType.FilesPath.ToString()));
            
        }
    }
}
