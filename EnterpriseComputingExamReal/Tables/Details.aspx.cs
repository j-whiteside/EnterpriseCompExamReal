﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using EnterpriseComputingExamReal.Models;

namespace EnterpriseComputingExamReal.Tables
{
    public partial class Details : System.Web.UI.Page
    {
		protected EnterpriseComputingExamReal.Models.DefaultConnection2 _db = new EnterpriseComputingExamReal.Models.DefaultConnection2();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // This is the Select methd to selects a single Table item with the id
        // USAGE: <asp:FormView SelectMethod="GetItem">
        public EnterpriseComputingExamReal.Models.Table GetItem([FriendlyUrlSegmentsAttribute(0)]int? Id)
        {
            if (Id == null)
            {
                return null;
            }

            using (_db)
            {
	            return _db.Tables.Where(m => m.Id == Id).FirstOrDefault();
            }
        }

        protected void ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Cancel", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("../Default");
            }
        }
    }
}

