//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace fbuCloset.Models
{
    using System;
    
    public partial class spView_UserOutfits_Result
    {
        public System.Guid uoUserOutfitID { get; set; }
        public string uoUserID { get; set; }
        public string uoUserOutfitDesc { get; set; }
        public string uoOutfitGroupID { get; set; }
        public bool uoSessionOutfit { get; set; }
        public System.DateTime uoCreateDate { get; set; }
        public string uoCreateUser { get; set; }
        public Nullable<System.DateTime> uoModifyDate { get; set; }
        public string uoModifyUser { get; set; }
        public string uopAttachmentID { get; set; }
        public Nullable<System.Guid> uopUserOutfitsPartID { get; set; }
        public Nullable<System.DateTime> uofCreateDate { get; set; }
        public Nullable<int> uopFrameID { get; set; }
        public string Name { get; set; }
        public string Web { get; set; }
        public string Owner { get; set; }
        public string Filename { get; set; }
    }
}
