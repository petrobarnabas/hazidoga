using Elektronikaiszakuzletwebshop.Entity;
using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Repository;
namespace Elektronikaiszakuzletwebshop.Service.Impl
{
    public class MobilServiceImpl : IGenericService<Mobil>
    {
        private readonly MobilRepository mobilRepository;

        public MobilServiceImpl(MobilRepository mobilRepository)
        {
            this.mobilRepository = mobilRepository;
        }
        public void Delete(int id)
        {
            mobilRepository.Mobiles.Remove(GetById(id));
        }

        public List<Mobil> GetAll()
        {
            return mobilRepository.Mobiles;
        }

        public Mobil GetById(int id)
        {
            return mobilRepository.Mobiles.Find(x => x.Id == id);
        }

        public Mobil Save(Mobil inputData)
        {
            inputData.Id = mobilRepository.NextIncrementalId;
            mobilRepository.Mobiles.Add(inputData);
            return inputData;
        }

        public Mobil Update(int id, Mobil updateData)
        {
            var dbMobil = GetById(id);
            dbMobil.Name = updateData.Name;
            dbMobil.Price = updateData.Price;
            dbMobil.ScreenSize = updateData.ScreenSize;
            dbMobil.BatteryCapacity = updateData.BatteryCapacity;
            dbMobil.Description = updateData.Description;
            return dbMobil;
        }
    }
}