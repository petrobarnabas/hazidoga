using Elektronikaiszakuzletwebshophazidoga.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elektronikaiszakuzletwebshophazidoga.Service;

namespace Elektronikaiszakuzletwebshophazidoga.Controller.Impl
{
    [Route("laptopok")]
    public class LaptopControllerImpl : LaptopControllerBase<Laptop>
    {
        private readonly IGenericService<Laptop> laptopService;
        public LaptopControllerImpl(IGenericService<Laptop> laptopService)
        {
            this.laptopService = laptopService;
        }
        public override void Delete(int id)
        {
            laptopService.Delete(id);
        }

        public override List<Laptop> GetAll()
        {
            return laptopService.GetAll();
        }

        public override Laptop GetById(int id)
        {
            return laptopService.GetById(id);
        }

        public override Laptop Save(Laptop inputData)
        {
            return laptopService.Save(inputData);
        }

        public override Laptop Update(int id, Laptop updateData)
        {
            return laptopService.Update(id, updateData);
        }
    }
}
