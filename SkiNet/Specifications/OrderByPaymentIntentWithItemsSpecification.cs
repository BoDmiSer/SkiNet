using SkiNet.Models.OrderAggregate;

namespace SkiNet.Specifications
{
    public class OrderByPaymentIntentWithItemsSpecification : BaseSpecification<Order>
    {
        public OrderByPaymentIntentWithItemsSpecification(string paymentIntentId)
            : base(o => o.PaymentIntentId == paymentIntentId)
        {
        }
    }
}
