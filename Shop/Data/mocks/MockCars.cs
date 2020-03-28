using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _carsCategory = new MockCategory();
        public IEnumerable<Car> Cars {

            get
            {
                return new List<Car>
                {
                    new Car{
                        name = "qwdqwd1",
                        shortDesc="wefbvr1", longDesc = "qwdqwd1",
                        img = "/img/boatbig.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                     new Car{
                        name = "aasdaw2",
                        shortDesc="dfhrw2", longDesc = "awdawd2",
                        img = "/img/boatbig.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                      new Car{
                        name = "asdcqwe3",
                        shortDesc="gwefwef3", longDesc = "bdfbrs3",
                        img = "/img/busred.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                       new Car{
                        name = "sdfvsv4",
                        shortDesc="dfbdfgr4", longDesc = "wegwewf4",
                        img = "/img/planeace.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                        new Car{
                        name = "gdfb5",
                        shortDesc="wrgrg5", longDesc = "wefh5",
                        img = "/img/carracer.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    },
                    new Car{
                        name = "heth6",
                        shortDesc="grgh6", longDesc = "ergeht6",
                        img = "/img/planepaper.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = _carsCategory.AllCategories.First()
                    }
                };
            }
               
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car getObjextCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
