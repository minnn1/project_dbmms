//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class PurchaseOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
            this.Expenses = new HashSet<Expens>();
        }
    
        public int purchaseorderID { get; set; }
        public Nullable<int> purchaserequisitionID { get; set; }
        public string purchaseorderName { get; set; }
        public Nullable<int> purchaseorderQTY { get; set; }
        public Nullable<double> purchaseorderPrice { get; set; }
        public Nullable<System.DateTime> purchaseorderDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Expens> Expenses { get; set; }
        public virtual PurchaseRequisition PurchaseRequisition { get; set; }
    }
}
