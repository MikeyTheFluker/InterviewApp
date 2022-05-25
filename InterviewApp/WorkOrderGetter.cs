using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Models;

namespace InterviewApp
{
    public class WorkOrderGetter
    {
        public DatabaseReader MyReader;
        public WorkOrderGetter(DatabaseReader reader)
        {
            MyReader = reader;
        }

        public Assets ShowMeAssetOneAndItsWorkOrders()
        {
            var x = MyReader.GetAssets(1);
            var y = MyReader.GetWorkOrders(1);
            x.WorkOrdersList = y;
            return x;
        }
    }
}
