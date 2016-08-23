using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1 {
    public class State {
        public int StateCode { get; set; }
        public string StateName { get; set; }

        public static IQueryable<State> GetStates() {
            return new List<State>
            {
                new State {
                    StateCode = 1,
                    StateName = "Alabama"
                },

                new State {
                    StateCode = 2,
                    StateName = "Alaska"
                },

                new State {
                    StateCode = 3,
                    StateName = "Arizona"
                }
            
            }.AsQueryable();
        }
    }
}
    
