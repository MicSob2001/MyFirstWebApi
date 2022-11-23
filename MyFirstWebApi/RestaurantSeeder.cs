using MyFirstWebApi.Entities;

namespace MyFirstWebApi
{
    public class RestaurantSeeder
    {
        public readonly RestaurantDbContex _dbContext;

        public RestaurantSeeder(RestaurantDbContex dbContex)
        {
            _dbContext = dbContex;
        }
        public void Seed()
        {
            if (_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges();
                }
            }
        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>() {
                new Restaurant()
                {
                    Name = "KFC",
                    Description =
                            "KFC (short for Kentucky Fried Chicken) is an American fast food restaurant chain headquartered in Louisville, Kentucky, that specializes in fried chicken.",
                    Category = "Fast Food",
                    HasDelivery = true,
                    ContactEmail = "contact@kfc.com",
                    ContactNumber = "111222333",
                    Dishes = new List<Dish>()
                        {
                            new Dish()
                            {
                                Name = "Nashville Hot Chicken",
                                Price = 10.30M,
                                Description = "Some food",
                            },

                            new Dish()
                            {
                                Name = "Chicken Nuggets",
                                Price = 5.30M,
                                Description = "Some food",
                            },
                        },
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Długa 5",
                        PostalCode = "30-001"
                    }
                },
                new Restaurant()
                {
                    Name = "McDonald Szewska",
                    Description =
                        "McDonald's Corporation (McDonald's), incorporated on December 21, 1964, operates and franchises McDonald's restaurants.",
                    Category = "Fast Food",
                    HasDelivery = true,
                    ContactEmail = "contact@mcdonald.com",
                    ContactNumber = "444555666",
                    Address = new Address()
                    {
                        City = "Kraków",
                        Street = "Szewska 2",
                        PostalCode = "30-001"
                    }
                }
            };
            return restaurants;
        }
    }
}
