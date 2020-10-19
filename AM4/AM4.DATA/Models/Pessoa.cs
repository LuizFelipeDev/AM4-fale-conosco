﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM4.DATA
{
    public partial class Pessoa
    {
        public Pessoa()
        {
            FaleConosco = new HashSet<FaleConosco>();
        }

        [Key]
        [Column("Pessoa_ID")]
        public int PessoaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DtNascimento { get; set; }
        [Column("CPF")]
        public long Cpf { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        public long Celular { get; set; }
        [Column("CEP")]
        public int Cep { get; set; }
        [Required]
        [StringLength(25)]
        public string Rua { get; set; }
        [Required]
        [StringLength(10)]
        public string Numero { get; set; }
        [StringLength(15)]
        public string Complemento { get; set; }
        [Required]
        [StringLength(25)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(25)]
        public string Cidade { get; set; }
        [Column("IDEstado")]
        public int Idestado { get; set; }

        [ForeignKey(nameof(Idestado))]
        [InverseProperty(nameof(Estado.Pessoa))]
        public virtual Estado IdestadoNavigation { get; set; }
        [InverseProperty("IdpessoaNavigation")]
        public virtual ICollection<FaleConosco> FaleConosco { get; set; }
    }
}