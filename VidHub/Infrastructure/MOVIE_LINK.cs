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
    
    public partial class MOVIE_LINK
    {
        public Nullable<int> MOVIE_ID { get; set; }
        public Nullable<int> SOURCE_WEB_SITE_ID { get; set; }
        public string PATH { get; set; }
        public Nullable<int> PATH_TYPE_ID { get; set; }
        public Nullable<int> UP_VOTE { get; set; }
        public Nullable<int> DOWN_VOTE { get; set; }
        public int MOVIE_LINK_ID { get; set; }
    
        public virtual MOVIE MOVIE { get; set; }
        public virtual PATH_TYPE PATH_TYPE { get; set; }
        public virtual WEB_SITE WEB_SITE { get; set; }
    }
}
