using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Entity;
namespace Elektronikaiszakuzletwebshop.Repository
{
    public class OrderRepository
    {
        private List<Order> orders = new List<Order>();
        private int nextIncremantalId = 0;
        public List<Order> Orders { get => orders; }
        public int NextIncrementalId { get => ++nextIncremantalId; }
    }
}