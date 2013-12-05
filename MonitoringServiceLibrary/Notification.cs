//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonitoringServiceLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public Notification()
        {
            this.NotificationsReceivers = new HashSet<NotificationsReceiver>();
            this.NotificationsSilenceHistories = new HashSet<NotificationsSilenceHistory>();
        }
    
        public int NotificationId { get; set; }
        public int ItemId { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationDescription { get; set; }
        public Nullable<double> HighLimit { get; set; }
        public Nullable<double> LowLimit { get; set; }
        public bool AutoAcknowledge { get; set; }
        public int NotificationPriority { get; set; }
        public bool IsSilent { get; set; }
        public bool AutoUnmute { get; set; }
        public Nullable<System.DateTime> UnmuteDate { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual ICollection<NotificationsReceiver> NotificationsReceivers { get; set; }
        public virtual ICollection<NotificationsSilenceHistory> NotificationsSilenceHistories { get; set; }
    }
}