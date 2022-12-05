using Microsoft.AspNetCore.Mvc;
using MyFirstWebApi.Models;
using MyFirstWebApi.Services;

namespace MyFirstWebApi.Controllers
{
    [Route("/api/restaurant/{restaurantId}/dish")]
    [ApiController]
    public class DishController : ControllerBase
    {
        private readonly IDishService _dishService;

        public DishController(IDishService dishService)
        {
            _dishService = dishService;
        }

        [HttpDelete]
        public ActionResult Delete([FromRoute] int restaurantId)
        {
            _dishService.RemoveAll(restaurantId);
            return NoContent();
        }


        [HttpDelete("{dishId}")]
        public ActionResult Delete([FromRoute] int restaurantId, [FromRoute] int dishId)
        {
            _dishService.RemoveAt(restaurantId, dishId);
            return NoContent();
        }


        [HttpPost]
        public ActionResult Post([FromRoute] int restaurantId, [FromBody] CreateDishDto dto)
        {
            var newDishId = _dishService.Create(restaurantId, dto);
            return Created($"/api/restaurant/{restaurantId}/dish/{newDishId}", null);
        }

        [HttpGet("{dishId}")]
        public ActionResult<DishDto> Get([FromRoute] int restaurantId, [FromRoute]int dishId)
        {
            var dishDto = _dishService.GetById(restaurantId, dishId);
            return Ok(dishDto);
        }

        [HttpGet]
        public ActionResult<List<DishDto>> Get([FromRoute] int restaurantId)
        {
            var dishDtos = _dishService.GetAll(restaurantId);
            return Ok(dishDtos);
        }

    }
}
