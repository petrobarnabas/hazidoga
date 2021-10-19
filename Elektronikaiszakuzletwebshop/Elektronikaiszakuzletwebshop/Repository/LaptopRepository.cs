using System.Collections.Generic;
using ElektronikaiSzakuzletWebShopV2.Entity;

namespace ElektronikaiSzakuzletWebShopV2.Repository
{
    public class LaptopRepository
    {
        private List<Laptop> laptops = new List<Laptop>();
        private int nextIncremantalId = 0;
        public List<Laptop> Laptops { get => laptops; }
        public int NextIncrementalId { get => ++nextIncremantalId; }


    }
}
