using Microsoft.AspNetCore.Mvc;
using SkiNet.Data.Repository;
using SkiNet.Models;
using System.Threading.Tasks;

namespace SkiNet.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _bascketRepository;
        public BasketController (IBasketRepository basketRepository)
        {
            _bascketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _bascketRepository.GetBasketAsync(id);
            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasket basket)
        {
            var updatedBasket = await _bascketRepository.UpdateBasketAsync(basket);
            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _bascketRepository.DeleteBasketAsync(id);
        }
    }
}
