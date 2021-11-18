using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorApp.Shared.Models
{
    public partial class Territory
    {
        public string Id { get; set; }
        public string TerritoryDescription { get; set; }
        public long RegionId { get; set; }
    }
}
