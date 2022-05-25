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
        public TimeSpan HowLongWeWorked;
        public string WhoWorkedOnIt;
    }
}
