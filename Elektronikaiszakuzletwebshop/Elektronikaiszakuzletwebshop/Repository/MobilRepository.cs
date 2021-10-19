using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Entity;
namespace Elektronikaiszakuzletwebshop.Repository
{
    public class MobilRepository
    {
        private List<Mobil> mobiles = new List<Mobil>();
        private int nextIncremantalId = 0;
        public List<Mobil> Mobiles { get => mobiles; }
        public int NextIncrementalId { get => ++nextIncremantalId; }
    }
}

