using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elektronikaiszakuzletwebshop.Service;
using Elektronikaiszakuzletwebshop.Entity;

namespace Elektronikaiszakuzletwebshop.Controller.Impl
{
    [Route("tabletek")]
    public class TabletControllerImpl : AbstractControllerBase<Tablet>
    {
        private readonly IGenericService<Tablet> tabletService;
        public TabletControllerImpl(IGenericService<Tablet> tabletService)
        {
            this.tabletService = tabletService;
        }
        public override void Delete(int id)
        {
            tabletService.Delete(id);
        }

        public override List<Tablet> GetAll()
        {
            return tabletService.GetAll();
        }

        public override Tablet GetById(int id)
        {
            return tabletService.GetById(id);
        }

        public override Tablet Save(Tablet inputData)
        {
            return tabletService.Save(inputData);
        }

        public override Tablet Update(int id, Tablet updateData)
        {
            return tabletService.Update(id, updateData);
        }
    }
}
