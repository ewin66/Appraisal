using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.Persistent.Base;

namespace Appraisal.Module.BusinessObjects.Appraisaldb
{
    [DefaultClassOptions]
    [NavigationItem("Appraisal")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Objective Next Year")]
    [DevExpress.Persistent.Base.ImageName("objective")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("Objective_id")]
    public partial class objective_next_year
    {
        public objective_next_year(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
