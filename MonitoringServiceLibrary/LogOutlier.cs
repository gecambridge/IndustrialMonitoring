//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class LogOutlier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LogOutlier()
        {
            this.ItemsLogRawDatas = new HashSet<ItemsLogRawData>();
        }
    
        public int OutlierId { get; set; }
        public int ItemId { get; set; }
        public string IQR { get; set; }
        public string LQR { get; set; }
        public string UQR { get; set; }
        public string Value { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Item Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ItemsLogRawData> ItemsLogRawDatas { get; set; }
    }
}
