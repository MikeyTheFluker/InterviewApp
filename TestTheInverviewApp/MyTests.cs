using InterviewApp;
using InterviewApp.Models;
using Xunit;

namespace TestTheInterviewApp
{
    public class MyTests
    {
        private WorkOrderGetter testSubject;
        public MyTests()
        {
            testSubject = new WorkOrderGetter(new DatabaseReader());
        }
        [Fact]
        public void Does()
        {
            var x = testSubject.ShowMeAssetOneAndItsWorkOrders();
            Assert.NotNull(x);
        }
    }
}