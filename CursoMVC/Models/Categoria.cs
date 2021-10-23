﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Categoria
    {
        public List<Produtos> Produtos { get; set; }
        public int Id {get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}
