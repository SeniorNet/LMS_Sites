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
    
    public partial class SanitizedCodeErrorCodeHint
    {
        public int Id { get; set; }
        public int SanitizedCodeErrorId { get; set; }
        public int CodeHintId { get; set; }
    
        public virtual CodeHint CodeHint { get; set; }
        public virtual SanitizedCodeError SanitizedCodeError { get; set; }
    }
}
