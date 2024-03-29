﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_POO
{
    //Subclasse 
    class Importados : Produtos
    {
        public  double Taxa { get; set; }

        public Importados(string nome, double preco, double taxa)
        :base(nome, preco)
        {

            Taxa = taxa;
        }
        //Metodo Etiquetas
        public override string Etiqueta()
        {
            return base.Etiqueta()+" (Taxa: " +Taxa+ ")" ;
        }
    }

}
