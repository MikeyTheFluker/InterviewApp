using System.Diagnostics;

namespace InterviewApp;

public class Program
{
    public static void Main()
    {
        var workOrdersBuilder = new WorkOrderGetter(new DatabaseReader());
        var asset = workOrdersBuilder.ShowMeAssetOneAndItsWorkOrders(); 
        Debug.WriteLine(asset);
    }
}