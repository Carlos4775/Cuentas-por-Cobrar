//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppCxC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Tipo_Documentos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Documentos()
        {
            this.Transacciones = new HashSet<Transaccione>();
        }

        
    
        public int Id_tipoDocumento { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]
      
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Cuenta Contable")]
        public string Cuenta_contable { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
