using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.OutstandingOrderScreens
{
    public class ViewOutstandingOrderUseCase : IViewOutstandingOrderUseCase
    {
        private readonly IOrderRepository orderRepository;
        public ViewOutstandingOrderUseCase(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public IEnumerable<Order> Execute()
        {
            return orderRepository.GetOutstandingOrders();
        }
    }
}
