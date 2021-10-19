using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Entity;
namespace Elektronikaiszakuzletwebshop.Repository
{
    public class TabletRepository
    {
        private List<Tablet> tablets = new List<Tablet>();
        private int nextIncremantalId = 0;
        public List<Tablet> Tablets { get => tablets; }
        public int NextIncrementalId { get => ++nextIncremantalId; }
    }
}
