using eShop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.ProcessedOrdersScreen
{
    public interface IViewProcessedOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}