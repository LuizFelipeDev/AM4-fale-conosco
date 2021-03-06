﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM4.DATA
{
    public partial class Estado
    {
        public Estado()
        {
            Pessoa = new HashSet<Pessoa>();
        }

        [Key]
        [Column("Estado_ID")]
        public int EstadoId { get; set; }
        [Required]
        [StringLength(25)]
        public string Nome { get; set; }

        [InverseProperty("IdestadoNavigation")]
        public virtual ICollection<Pessoa> Pessoa { get; set; }
    }
}