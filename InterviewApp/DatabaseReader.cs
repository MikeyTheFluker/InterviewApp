using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp.Models;

namespace InterviewApp
{
    /// <summary>
    /// Imagine this class calls the database
    /// </summary>
    public class DatabaseReader
    {
        public List<WorkOrders> GetWorkOrders(int assetId)
        {
            return new List<WorkOrders> {new WorkOrders { AssetId = assetId, WorkOrderId = Random.Shared.Next()} };
        }

        public Assets GetAssets(int assetId)
        {
            return new Assets() {AssetId = assetId, WorkOrdersList = new List<WorkOrders>()};
        }
    }
}
