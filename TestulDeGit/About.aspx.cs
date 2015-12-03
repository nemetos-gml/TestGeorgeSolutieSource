using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class About : Page
{
    public struct EndOfDayDataFeedToService
    {
        public int superPoints;
        public int totalAmount;
        public int totalItems;
        public int numberOfCustomers;
        public int totalAmountSuperPoints;
        public int totalAmountWithoutSuperPoints;
        public int numberOfCustomersWithSuperPoints;
        public int numberOfCustomersWithoutSuperPoints;
        public int totalItemsSuperPoints;
        public int totalItemsWithoutSuperPoints;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        decimal a = 2.8m - 7.5m;
    }
}