using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.Server.Models
{
    public partial class Category
    {
        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
