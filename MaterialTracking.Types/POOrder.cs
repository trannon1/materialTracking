//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaterialTracking.Types
{
    using System;
    using System.Collections.Generic;
    
    public partial class POOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public POOrder()
        {
            this.POOrderDetails = new HashSet<POOrderDetail>();
        }
    
        public int POOrderID { get; set; }
        public int OrderRequestID { get; set; }
        public int OrderStatusID { get; set; }
    
        public virtual OrderRequest OrderRequest { get; set; }
        public virtual OrderStatu OrderStatu { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<POOrderDetail> POOrderDetails { get; set; }
    }
}
