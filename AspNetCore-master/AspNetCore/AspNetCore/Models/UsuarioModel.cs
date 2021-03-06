using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore_3_0.Models
{
    public class UsuarioModel
    {
        
            [Key]
            public int id { get; set; }
           public string nome { get; set; }
           public string email { get; set; }
            public string cpf { get; set; }
            public string endereco { get; set; }

            [Display(Name = "Data de Nascimento")]
            public DateTime dataNascimento { get; set; }

            [Display(Name = "Data de criação do Usuario")]
            public DateTime dataCriacao { get; set; }


            //public List<ContaModel> contas { get; set; }
        }
    }


