using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.Base;

namespace Appraisal.Module.BusinessObjects.Appraisaldb
{
    [DefaultClassOptions]
    [NavigationItem("Appraisal")]
    [DevExpress.ExpressApp.DC.XafDisplayName("Development")]
    [DevExpress.Persistent.Base.ImageName("development")]
    [DevExpress.ExpressApp.DC.XafDefaultProperty("development_id")]
    public partial class development
    {
        public development(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
