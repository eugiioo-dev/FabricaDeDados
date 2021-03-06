﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricaDeDadosWeb.Models
{
    public partial class Endereco
    {
        public Endereco()
        {
            EmpresaEndereco = new HashSet<EmpresaEndereco>();
            PessoaEndereco = new HashSet<PessoaEndereco>();
        }

        [Key]
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public int IdMunicipio { get; set; }

        [ForeignKey("IdMunicipio")]
        public virtual Municipio Municipio1 { get; set; }
        public virtual ICollection<EmpresaEndereco> EmpresaEndereco { get; set; }
        public virtual ICollection<PessoaEndereco> PessoaEndereco { get; set; }
    }
}
