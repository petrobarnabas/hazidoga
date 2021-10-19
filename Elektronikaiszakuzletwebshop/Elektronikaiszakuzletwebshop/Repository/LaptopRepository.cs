using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Entity;
namespace Elektronikaiszakuzletwebshop.Repository
{
    public class LaptopRepository
    {
        private List<Laptop> laptops = new List<Laptop>();
        private int nextIncremantalId = 0;
        public List<Laptop> Laptops { get => laptops; }
        public int NextIncrementalId { get => ++nextIncremantalId; }


    }
}
