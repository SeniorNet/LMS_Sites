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
    
    public partial class Test
    {
        public string ParameterValues { get; set; }
        public string ExpectedOutput { get; set; }
        public bool OutputException { get; set; }
        public bool Autogenerated { get; set; }
        public int Id { get; set; }
        public int CodingProblemId { get; set; }
    
        public virtual CodingProblem CodingProblem { get; set; }
    }
}
