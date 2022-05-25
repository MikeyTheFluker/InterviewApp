using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Models
{
    public class WorkOrders
    {
        public int WorkOrderId;
        public int AssetId;


        public override string ToString()
        {
            return "WorkOrder: " + AssetId;
        }
    }
}
