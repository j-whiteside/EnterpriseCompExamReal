using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using EnterpriseComputingExamReal.Models;

namespace EnterpriseComputingExamReal.Tables
{
    public partial class Default : System.Web.UI.Page
    {
		protected EnterpriseComputingExamReal.Models.DefaultConnection2 _db = new EnterpriseComputingExamReal.Models.DefaultConnection2();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Table entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<EnterpriseComputingExamReal.Models.Table> GetData()
        {
            return _db.Tables;
        }
    }
}

