﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace Appraisal.Module.BusinessObjects.Appraisaldb
{

    public partial class development : XPLiteObject
    {
        DateTime fdate_10;
        [DevExpress.Xpo.DisplayName(@"Date of 10%")]
        public DateTime date_10
        {
            get { return fdate_10; }
            set { SetPropertyValue<DateTime>("date_10", ref fdate_10, value); }
        }
        DateTime fdate_20;
        [DevExpress.Xpo.DisplayName(@"Date of 20%")]
        public DateTime date_20
        {
            get { return fdate_20; }
            set { SetPropertyValue<DateTime>("date_20", ref fdate_20, value); }
        }
        DateTime fdate_70;
        [DevExpress.Xpo.DisplayName(@"Date of 70%")]
        public DateTime date_70
        {
            get { return fdate_70; }
            set { SetPropertyValue<DateTime>("date_70", ref fdate_70, value); }
        }
        int fdevelopment_id;
        [Key(true)]
        [DevExpress.Xpo.DisplayName(@"ID")]
        public int development_id
        {
            get { return fdevelopment_id; }
            set { SetPropertyValue<int>("development_id", ref fdevelopment_id, value); }
        }
        string fgap_description;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"Gap Description")]
        public string gap_description
        {
            get { return fgap_description; }
            set { SetPropertyValue<string>("gap_description", ref fgap_description, value); }
        }
        string fhow_10;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"How of 10%")]
        public string how_10
        {
            get { return fhow_10; }
            set { SetPropertyValue<string>("how_10", ref fhow_10, value); }
        }
        string fhow_20;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"How of 20%")]
        public string how_20
        {
            get { return fhow_20; }
            set { SetPropertyValue<string>("how_20", ref fhow_20, value); }
        }
        string fhow_70;
        [Size(SizeAttribute.Unlimited)]
        [DevExpress.Xpo.DisplayName(@"How of 70%")]
        public string how_70
        {
            get { return fhow_70; }
            set { SetPropertyValue<string>("how_70", ref fhow_70, value); }
        }
        DateTime freview_date;
        [DevExpress.Xpo.DisplayName(@"Review Date")]
        public DateTime review_date
        {
            get { return freview_date; }
            set { SetPropertyValue<DateTime>("review_date", ref freview_date, value); }
        }
        personnel_master fpersonnel_id;
        [Association(@"developmentReferencespersonnel_master")]
        [DevExpress.Xpo.DisplayName(@"Personnel")]
        public personnel_master personnel_id
        {
            get { return fpersonnel_id; }
            set { SetPropertyValue<personnel_master>("personnel_id", ref fpersonnel_id, value); }
        }
    }

}