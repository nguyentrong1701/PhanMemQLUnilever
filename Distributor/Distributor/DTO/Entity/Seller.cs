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
    
    public partial class Seller
    {
        public Seller()
        {
            this.IssueDetails = new HashSet<IssueDetail>();
            this.Issues = new HashSet<Issue>();
            this.Debts = new HashSet<Debt>();
            this.SellerSales = new HashSet<SellerSale>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    
        public virtual ICollection<IssueDetail> IssueDetails { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Debt> Debts { get; set; }
        public virtual ICollection<SellerSale> SellerSales { get; set; }
    }
}
