using ElektronikaiSzakuzletWebShopV2.Entity;
using System.Collections.Generic;
using ElektronikaiSzakuzletWebShopV2.Repository;

namespace ElektronikaiSzakuzletWebShopV2.Service.Impl
{
    public class LaptopServiceImpl : IGenericService<Laptop>
    {
        private readonly LaptopRepository laptopRepository;

        public LaptopServiceImpl(LaptopRepository laptopRepository)
        {
            this.laptopRepository = laptopRepository;
        }
        public void Delete(int id)
        {
            laptopRepository.Laptops.Remove(GetById(id));
        }

        public List<Laptop> GetAll()
        {
            return laptopRepository.Laptops;
        }

        public Laptop GetById(int id)
        {
            return laptopRepository.Laptops.Find(x => x.Id == id);
        }

        public Laptop Save(Laptop inputData)
        {
            inputData.Id = laptopRepository.NextIncrementalId;
            laptopRepository.Laptops.Add(inputData);
            return inputData;
        }

        public Laptop Update(int id, Laptop updateData)
        {
            var dbLaptop = GetById(id);
            dbLaptop.Name = updateData.Name;
            dbLaptop.Price = updateData.Price;
            dbLaptop.ScreenSize = updateData.ScreenSize;
            dbLaptop.BatteryCapacity = updateData.BatteryCapacity;
            dbLaptop.Cpu = updateData.Cpu;
            dbLaptop.Description = updateData.Description;
            dbLaptop.Gpu = updateData.Gpu;

        }
    }
}

