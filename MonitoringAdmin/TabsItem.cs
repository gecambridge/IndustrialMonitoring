//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class TabsItem
    {
        public int TabItemId { get; set; }
        public int TabId { get; set; }
        public int ItemId { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual Tab Tab { get; set; }
    }
}
