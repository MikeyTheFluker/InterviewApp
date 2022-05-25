using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Models
{
    public class Assets
    {
        public int AssetId;
        public List<WorkOrders> WorkOrdersList;

        public override string ToString()
        {
            return "Asset: " + AssetId + " WorkOrders: " + string.Join(",", WorkOrdersList.Select(d=> d.ToString()));
        }
    }
}
