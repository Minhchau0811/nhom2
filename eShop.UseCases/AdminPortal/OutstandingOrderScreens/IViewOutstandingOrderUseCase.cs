using eShop.CoreBusiness.Models;

namespace eShop.UseCases.AdminPortal.OutstandingOrderScreens
{
    public interface IViewOutstandingOrderUseCase
    {
        IEnumerable<Order> Execute();
    }
}