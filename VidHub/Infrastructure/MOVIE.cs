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
    
    public partial class MOVIE
    {
        public MOVIE()
        {
            this.MOVIE_LINK = new HashSet<MOVIE_LINK>();
        }
    
        public int MOVIE_ID { get; set; }
        public string TITLE { get; set; }
        public string MOVIE_POSTER_PATH { get; set; }
    
        public virtual ICollection<MOVIE_LINK> MOVIE_LINK { get; set; }
    }
}
