//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ErucaCRM.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class ContentApplicationPage
    {
        public int ContentApplicationPageId { get; set; }
        public int CultureInformationId { get; set; }
        public int ApplicationPageId { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string PageContent { get; set; }
        public Nullable<bool> UseDefaultContent { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        public virtual ApplicationPage ApplicationPage { get; set; }
        public virtual CultureInformation CultureInformation { get; set; }
    }
}
