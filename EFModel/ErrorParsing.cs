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
    
    public partial class ErrorParsing
    {
        public int LanguageId { get; set; }
        public string ErrorPattern { get; set; }
        public int Id { get; set; }
        public Nullable<int> PatternOrder { get; set; }
    
        public virtual Language Language { get; set; }
    }
}
