using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1 {
    public class City {

        public int  StateCode {get; set;}
        public int CityID { get; set;}
        public string CityName { get; set;}

        public static IQueryable<City> GetCities() {
            return new List<City>
            {
                new City {
                    StateCode = 1,
                    CityID = 1,
                    CityName = "Dothan"
                },

                new City {
                    StateCode = 2,
                    CityID = 1,
                    CityName = "Juneau"
                },

                new City {
                    StateCode = 3,
                    CityID = 1,
                    CityName = "Tempe"
                }

            }.AsQueryable();
        }
    }
}