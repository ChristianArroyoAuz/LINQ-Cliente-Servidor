// ******************************************************************************************
// Arroyo Auz Christian Xavier.                                                             *
// 01/07/2016.                                                                              *
// ******************************************************************************************


using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    //Para enviar los datos sin necesidad de de convertirlo
    [Serializable]
    //Para agregar y conseguir el nombre de la tabla que se usara en las consultas
    [Table(Name = "Piezas")]
    public class Piezas
    {
        //Agregando los atributos de las las columnas de las tablas, el ID se  le asignara como clave primaria para
        //evitar repeticiones
        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Nombre_Pieza;

        [Column]
        public string Descripcion;

        [Column]
        public int Costo;


        //Constructor vacio que no recibe parametros
        public Piezas()
        {
        }

        //Constructor que recibe los parametrso de las consultas
        public Piezas(int ini_id, string ini_nombre, string ini_descripcion, int ini_costo)
        {
            //Igualando las variables locales a las variables recibidas
            Id = ini_id;
            Nombre_Pieza = ini_descripcion;
            Descripcion = ini_descripcion;
            Costo = ini_costo;
        }

        //Parametros que me devuelve el constructor para presentarlos en el datgridview
        public override string ToString()
        {
            return Id + Nombre_Pieza + Descripcion + Costo;
        }
    }
}