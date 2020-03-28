using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        static public void Initial(AppDBContent content)
        {

            if(!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(content => content.Value));
            }

            if (!content.Car.Any())
            {
                content.Car.AddRange(
                     new Car
                     {
                         name = "qwdqwd1",
                         shortDesc = "wefbvr1",
                         longDesc = "qwdqwd1",
                         img = "/img/boatbig.png",
                         price = 45000,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Классические автомобили"]
                     },
                     new Car
                     {
                         name = "aasdaw2",
                         shortDesc = "dfhrw2",
                         longDesc = "awdawd2",
                         img = "/img/boatbig.png",
                         price = 45000,
                         isFavourite = true,
                         available = false,
                         Category = Categories["Классические автомобили"]
                     },
                      new Car
                      {
                          name = "asdcqwe3",
                          shortDesc = "gwefwef3",
                          longDesc = "bdfbrs3",
                          img = "/img/busred.png",
                          price = 45000,
                          isFavourite = false,
                          available = true,
                          Category = Categories["Электромобиль"]
                      },
                       new Car
                       {
                           name = "sdfvsv4",
                           shortDesc = "dfbdfgr4",
                           longDesc = "wegwewf4",
                           img = "/img/planeace.png",
                           price = 45000,
                           isFavourite = false,
                           available = true,
                           Category = Categories["Классические автомобили"]
                       },
                        new Car
                        {
                            name = "gdfb5",
                            shortDesc = "wrgrg5",
                            longDesc = "wefh5",
                            img = "/img/carracer.png",
                            price = 45000,
                            isFavourite = true,
                            available = false,
                            Category = Categories["Электромобиль"]
                        },
                    new Car
                    {
                        name = "heth6",
                        shortDesc = "grgh6",
                        longDesc = "ergeht6",
                        img = "/img/planepaper.png",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category{categoryName ="Электромобиль" ,desc="Современныйвид транспорта"},
                        new Category{categoryName= "Классические автомобили", desc="Машина с двигателем внутреннего згорания"}
                    };

                    category = new Dictionary<string, Category>();

                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }
    }
}
