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
    
    public partial class UsersServicesPermission
    {
        public int UserServicePermissionId { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual User User { get; set; }
    }
}
