namespace ElektronikaiSzakuzletWebShopV2.Entity

{
    public abstract class AbstractPortableItem : AbstractItem
    {
        public int BatteryCapacity { get; set; }
        public double ScreenSize { get; set; }
    }
}
