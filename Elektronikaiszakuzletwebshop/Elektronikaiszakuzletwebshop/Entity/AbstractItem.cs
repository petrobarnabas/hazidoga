namespace Elektronikaiszakuzletwebshop.Entity

{
    public abstract class AbstractItem : AbstractBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
