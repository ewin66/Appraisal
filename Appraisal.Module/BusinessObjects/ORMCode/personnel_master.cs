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
    [DevExpress.ExpressApp.DC.XafDisplayName("Personnel")]
    [DevExpress.Persistent.Base.ImageName("personnel")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("personnel_name")]
    public partial class personnel_master
    {
        public personnel_master(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
