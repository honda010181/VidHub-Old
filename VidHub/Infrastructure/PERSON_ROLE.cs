//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VidHub.Infrastructure
{
    using System;
    using System.Collections.Generic;
    
    public partial class PERSON_ROLE
    {
        public int PERSON_ROLE_ID { get; set; }
        public int PERSON_ID { get; set; }
        public int ROLE_ID { get; set; }
        public Nullable<int> MOVIE_ID { get; set; }
    
        public virtual MOVIE MOVIE { get; set; }
        public virtual ROLE ROLE { get; set; }
        public virtual PERSON PERSON1 { get; set; }
    }
}
