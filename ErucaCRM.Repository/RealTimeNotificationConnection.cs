//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErucaCRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class RealTimeNotificationConnection
    {
        public int RealTimeId { get; set; }
        public string ConnectionId { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public bool IsConnected { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
