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
    
    public partial class VideoMaterialStep
    {
        public int VideoMaterialId { get; set; }
        public int TimeStamp { get; set; }
        public string Action { get; set; }
        public int Xs1 { get; set; }
        public int Ys1 { get; set; }
        public int Xs2 { get; set; }
        public int Ys2 { get; set; }
        public int Xe1 { get; set; }
        public int Ye1 { get; set; }
        public int Xe2 { get; set; }
        public int Ye2 { get; set; }
        public string Text { get; set; }
        public int Id { get; set; }
        public string Style { get; set; }
    
        public virtual VideoMaterial VideoMaterial { get; set; }
    }
}
