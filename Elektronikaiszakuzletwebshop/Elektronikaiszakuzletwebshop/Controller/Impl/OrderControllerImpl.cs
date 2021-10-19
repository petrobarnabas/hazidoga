using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elektronikaiszakuzletwebshop.Service;
using Elektronikaiszakuzletwebshop.Entity;

namespace Elektronikaiszakuzletwebshop.Controller.Impl
{
    [Route("rendelesek")]
    public class OrderControllerImpl : AbstractControllerBase<Order>
    {
        private readonly IGenericService<Order> orderService;
        public OrderControllerImpl(IGenericService<Order> orderService)
        {
            this.orderService = orderService;
        }
        public override void Delete(int id)
        {
            orderService.Delete(id);
        }

        public override List<Order> GetAll()
        {
            return orderService.GetAll();
        }

        public override Order GetById(int id)
        {
            return orderService.GetById(id);
        }

        public override Order Save(Order inputData)
        {
            return orderService.Save(inputData);
        }

        public override Order Update(int id, Order updateData)
        {
            return orderService.Update(id, updateData);
        }
    }
}
