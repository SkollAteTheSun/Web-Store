﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data.Model;

namespace WebStore.Data.Interfaces
{
    public interface IAllOrders
    {
        void createOreder(Order order);

    }
}
