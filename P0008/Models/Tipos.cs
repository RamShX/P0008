using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace P0008.Models
{
	public class Tipos
	{
        public int IdTipos { get; set; }
        public string Descripcion { get; set; }
        public byte[] Imagen { get; set; }
        public bool Activo { get; set; }

    }
}