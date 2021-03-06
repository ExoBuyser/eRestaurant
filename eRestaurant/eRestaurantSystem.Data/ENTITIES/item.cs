﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion

namespace eRestaurantSystem.Data.ENTITIES
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal CurrentCost { get; set; }
        public bool Active{ get; set; }
        public int? Calories{ get; set; }
        public string comment{ get; set; }
        public int MenuCategoryID{ get; set; }
        public virtual MenuCategory
    }
}
