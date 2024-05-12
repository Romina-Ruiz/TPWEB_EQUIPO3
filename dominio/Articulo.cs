using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {

        public int Id { get; set; }
        public string Cod_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string _Descripcion { get; set; }
        public float Precio { get; set; }

        public int Id_marca { get; set; }
        public int Id_cate { get; set; }


        public string des_marca { get; set; }
        public string des_categoria { get; set; }

        public string urlImagen { get; set; }

        public int IdArticulo { get; set; }

        public int Id_imagen { get; set; }

    }
}
