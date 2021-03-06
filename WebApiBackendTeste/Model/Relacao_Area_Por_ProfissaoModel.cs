﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiBackendTeste.Model {
    public class Relacao_Area_Por_ProfissaoModel {
        [Table("Relacao_Area_Por_Profissao")]
        public class Relacao_Area_Por_Profissao {
            /// <summary>
            /// 
            /// </summary>
            [Key]
            [Column("IdRelacao_Area_Por_Profissao")]
            public int IdRelacao_Area_Por_Profissao { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("IdAreaConhecimento")]
            [Required(ErrorMessage = "A Área de Conhecimento é Obrigatória", AllowEmptyStrings = false)]
            public string IdAreaConhecimento { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [Column("IdProfissao")]
            [Required(ErrorMessage = "O nome da Profisão é Obrigatório", AllowEmptyStrings = false)]
            public int IdProfissao { get; set; }

            /// <summary>
            /// 
            /// </summary>
            [ForeignKey("IdAreaConhecimento")]
            public AreaDeConhecimento AreaDeConhecimento { get; private set; }

            [ForeignKey("IdProfissao")]
            public ProfissoesModel Profissao { get; private set; }

        }
    }
}