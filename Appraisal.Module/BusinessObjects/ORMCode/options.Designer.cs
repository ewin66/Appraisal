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

    public partial class options : XPLiteObject
    {
        string foption_name;
        [Key]
        [Size(SizeAttribute.Unlimited)]
        public string option_name
        {
            get { return foption_name; }
            set { SetPropertyValue<string>("option_name", ref foption_name, value); }
        }
        string foption_value;
        [Size(SizeAttribute.Unlimited)]
        public string option_value
        {
            get { return foption_value; }
            set { SetPropertyValue<string>("option_value", ref foption_value, value); }
        }
    }

}