using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using auth_book.Models;
using System.Collections.Generic;

namespace auth_book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        // definer en metode  som returnere en int og bageefter en der retunrere string
       [HttpGet]
       public List<Car> getAll()
        {
            List<Car> listCars = new List<Car>
            {
                new Car(){carId=1,model="127",brand="fiat",color="sort"},
                new Car(){carId=1,model="127",brand="fiat",color="sort"},
                new Car(){carId=1,model="127",brand="fiat",color="sort"},
            };
            return listCars;
        }
       
    }
}
