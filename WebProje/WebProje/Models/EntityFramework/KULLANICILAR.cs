//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebProje.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls.Expressions;

    public partial class KULLANICILAR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KULLANICILAR()
        {
            this.YORUMLAR = new HashSet<YORUMLAR>();
        }


        public int KULLANICIID { get; set; }
        [Required(ErrorMessage = "Kullan�c� Ad� Girilmelidir")]
        public string KULLANICIAD { get; set; }
        public Nullable<bool> KULLANICITIP { get; set; }
        [Required(ErrorMessage = "e-Mail Girilmelidir")]
        [EmailAddress(ErrorMessage = "L�tfen Ge�erli e-Mail giriniz")]
        public string KULLANICIEMAIL { get; set; }
        [Required(ErrorMessage = "�ifre Girilmelidir")]
        public string KULLANICISIFRE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<YORUMLAR> YORUMLAR { get; set; }
    }
}
