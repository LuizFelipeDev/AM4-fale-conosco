﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM4.DATA
{
    public partial class Mensagem
    {
        public Mensagem()
        {
            FaleConosco = new HashSet<FaleConosco>();
        }

        [Key]
        [Column("Mensagem_ID")]
        public int MensagemId { get; set; }
        [Required]
        [Column("Texto_Mensagem")]
        [StringLength(100)]
        public string TextoMensagem { get; set; }
        [Required]
        [Column("Titulo_Mensagem")]
        [StringLength(100)]
        public string TituloMensagem { get; set; }

        [InverseProperty("IdmensagemNavigation")]
        public virtual ICollection<FaleConosco> FaleConosco { get; set; }
    }
}