﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ff.coffee.repository
{
    public class RestaurantRepository : BaseRepository<Restaurant>
    {
        public RestaurantRepository(IUnitOfWork unit)
            : base(unit)
        { }
    }
}
