

namespace ListTest.Models
{
    public sealed class OrderRow
    {
        public int Id { get; set; }
        public string Patient { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime Created { get; set; }
    }
}
