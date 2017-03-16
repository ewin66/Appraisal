using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Appraisal.Module.BusinessObjects.Appraisaldb
{

    public partial class options
    {
        public options(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
