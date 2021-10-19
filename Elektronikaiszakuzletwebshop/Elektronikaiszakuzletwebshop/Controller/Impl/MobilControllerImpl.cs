using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elektronikaiszakuzletwebshop.Service;
using Elektronikaiszakuzletwebshop.Entity;

namespace Elektronikaiszakuzletwebshop.Controller.Impl
{
    [Route("mobilok")]
    public class MobilControllerImpl : AbstractControllerBase<Mobil>
    {
        private readonly IGenericService<Mobil> mobilService;
        public MobilControllerImpl(IGenericService<Mobil> mobiService)
        {
            this.mobilService = mobiService;
        }
        public override void Delete(int id)
        {
            mobilService.Delete(id);
        }

        public override List<Mobil> GetAll()
        {
            return mobilService.GetAll();
        }

        public override Mobil GetById(int id)
        {
            return mobilService.GetById(id);
        }

        public override Mobil Save(Mobil inputData)
        {
            return mobilService.Save(inputData);
        }

        public override Mobil Update(int id, Mobil updateData)
        {
            return mobilService.Update(id, updateData);
        }
    }
}
