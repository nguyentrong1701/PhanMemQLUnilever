//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Distributor.DTO.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock
    {
        public int ProId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
