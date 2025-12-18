using ListTest.Models;

namespace ListTest.Repository
{
    //No Touching this class or anything in it, its just part of the test.. pretend its a black box .. or we don't have access to the code at all.. just a syncronous thing we must call. 
    public class FakeSqlRepository : IFakeSqlRepository
    {
        public List<OrderRow> FetchData()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4)); 
            return new List<OrderRow>
            {
                new() { Id = 1, Patient = "Alice Jones", Status = "Open",   Created = DateTime.Now.AddMinutes(-12) },
                new() { Id = 2, Patient = "Bob Smith",   Status = "Queued", Created = DateTime.Now.AddMinutes(-33) },
                new() { Id = 3, Patient = "Chris Lee",   Status = "Closed", Created = DateTime.Now.AddHours(-2) },
            };
        }
    }
}
