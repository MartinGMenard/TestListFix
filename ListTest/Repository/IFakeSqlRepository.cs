using ListTest.Models;

namespace ListTest.Repository;

public interface IFakeSqlRepository
{
    List<OrderRow> FetchData();
}