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
    
    public partial class StudentQuizQuestion
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Answer { get; set; }
        public string Expected { get; set; }
        public System.DateTime Date { get; set; }
        public bool AnswerShown { get; set; }
        public string History { get; set; }
        public int QuestionId { get; set; }
        public int Grade { get; set; }
    
        public virtual QuizQuestion QuizQuestion { get; set; }
        public virtual Student Student { get; set; }
    }
}
