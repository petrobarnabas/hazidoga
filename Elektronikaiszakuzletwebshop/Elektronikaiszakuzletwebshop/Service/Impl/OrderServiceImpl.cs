using Elektronikaiszakuzletwebshop.Entity;
using System.Collections.Generic;
using Elektronikaiszakuzletwebshop.Repository;
namespace Elektronikaiszakuzletwebshop.Service.Impl
{
    public class OrderServiceImpl : IGenericService<Order>
    {
        private readonly OrderRepository orderRepository;

        public OrderServiceImpl(OrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public void Delete(int id)
        {
            orderRepository.Orders.Remove(GetById(id));
        }

        public List<Order> GetAll()
        {
            return orderRepository.Orders;
        }

        public Order GetById(int id)
        {
            return orderRepository.Orders.Find(x => x.Id == id);
        }

        public Order Save(Order inputData)
        {
            inputData.Id = orderRepository.NextIncrementalId;
            orderRepository.Orders.Add(inputData);
            return inputData;
        }

        public Order Update(int id, Order updateData)
        {
            var dbOrder = GetById(id);
            dbOrder.Name = updateData.Name;
            dbOrder.Price = updateData.Price;
            dbOrder.ScreenSize = updateData.ScreenSize;
            dbOrder.BatteryCapacity = updateData.BatteryCapacity;
            dbOrder.Description = updateData.Description;
            return dbOrder;
        }
    }
}