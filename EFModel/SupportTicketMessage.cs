//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SupportTicketMessage
    {
        public int Id { get; set; }
        public int SupportTicketId { get; set; }
        public int StudentId { get; set; }
        public string Message { get; set; }
        public byte[] Image { get; set; }
        public string Role { get; set; }
        public bool Active { get; set; }
        public bool ViewStatus { get; set; }
    
        public virtual Student Student { get; set; }
        public virtual SupportTicket SupportTicket { get; set; }
    }
}