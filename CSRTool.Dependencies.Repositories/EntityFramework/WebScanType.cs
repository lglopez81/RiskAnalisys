//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSRTool.Dependencies.Repositories.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class WebScanType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WebScanType()
        {
            this.AssessmentCustomerWebScan = new HashSet<AssessmentCustomerWebScan>();
            this.AssessmentSupplierWebScan = new HashSet<AssessmentSupplierWebScan>();
        }
    
        public System.Guid Id { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentCustomerWebScan> AssessmentCustomerWebScan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssessmentSupplierWebScan> AssessmentSupplierWebScan { get; set; }
    }
}
