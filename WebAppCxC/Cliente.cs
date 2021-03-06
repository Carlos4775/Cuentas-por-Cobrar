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
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Balances = new HashSet<Balance>();
            this.Transacciones = new HashSet<Transaccione>();
        }

        [DisplayName("Id del cliente")]
        public int Id_cliente { get; set; }

        [Required(ErrorMessage ="Este campo es obligatorio")]

        [DisplayName("Nombre Cliente")]
        public string Nombre_cliente { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Limite Credito")]
        public decimal LimiteCredito { get; set; }
        public bool Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Balance> Balances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
