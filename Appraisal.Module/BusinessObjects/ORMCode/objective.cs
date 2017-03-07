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
    [DevExpress.ExpressApp.DC.XafDisplayName("Objective")]
    [DevExpress.Persistent.Base.ImageName("Objective")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("Objective_id")]
    public partial class objective
    {
        public objective(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
