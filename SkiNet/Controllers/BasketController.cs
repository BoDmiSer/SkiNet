using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SkiNet.Data.Repository;
using SkiNet.Dtos;
using SkiNet.Models;
using System.Threading.Tasks;

namespace SkiNet.Controllers
{
    public class BasketController : BaseApiController
    {
        private readonly IBasketRepository _bascketRepository;
        private readonly IMapper _mapper;
        public BasketController (IBasketRepository basketRepository, IMapper mapper)
        {
            _bascketRepository = basketRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<CustomerBasket>> GetBasketById(string id)
        {
            var basket = await _bascketRepository.GetBasketAsync(id);
            return Ok(basket ?? new CustomerBasket(id));
        }

        [HttpPost]
        public async Task<ActionResult<CustomerBasket>> UpdateBasket(CustomerBasketDto basket)
        {
            var customerBasket = _mapper.Map<CustomerBasket>(basket);
            var updatedBasket = await _bascketRepository.UpdateBasketAsync(customerBasket);
            return Ok(updatedBasket);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _bascketRepository.DeleteBasketAsync(id);
        }
    }
}
