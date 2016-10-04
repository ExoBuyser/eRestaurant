﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurantSystem.Data.Entities
{
    [Table("MenuCategories")]
    public class MenuCategory
    {
        [key]
        public int MenuCategoryID { get; set; }
        public string Description { get; set; }
    }
}
