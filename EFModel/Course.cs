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
    
    public partial class Course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.CourseInstances = new HashSet<CourseInstance>();
            this.CourseCourseMaterialRequirements = new HashSet<CourseCourseMaterialRequirement>();
            this.CoursePrerequisites = new HashSet<CoursePrerequisite>();
            this.CoursePrerequisites1 = new HashSet<CoursePrerequisite>();
            this.CourseRequiredTools = new HashSet<CourseRequiredTool>();
            this.CourseSupplies = new HashSet<CourseSupply>();
            this.CourseTechnologyRequirements = new HashSet<CourseTechnologyRequirement>();
            this.CourseTextbooks = new HashSet<CourseTextbook>();
            this.CourseObjectives = new HashSet<CourseObjective>();
            this.CourseCorequisites = new HashSet<CourseCorequisite>();
            this.CourseCorequisites1 = new HashSet<CourseCorequisite>();
        }
    
        public int x_Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public string Description { get; set; }
        public int Credits { get; set; }
        public string Department { get; set; }
        public int Number { get; set; }
        public byte[] Picture { get; set; }
        public int Id { get; set; }
        public int GradeScaleGroupId { get; set; }
    
        public virtual GradeScaleGroup GradeScaleGroup { get; set; }
        public virtual School School { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseInstance> CourseInstances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseCourseMaterialRequirement> CourseCourseMaterialRequirements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoursePrerequisite> CoursePrerequisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoursePrerequisite> CoursePrerequisites1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseRequiredTool> CourseRequiredTools { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSupply> CourseSupplies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTechnologyRequirement> CourseTechnologyRequirements { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseTextbook> CourseTextbooks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseObjective> CourseObjectives { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseCorequisite> CourseCorequisites { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseCorequisite> CourseCorequisites1 { get; set; }
    }
}
