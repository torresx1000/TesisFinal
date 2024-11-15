using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Endidad
{
    public class Ent_Stock
    {
        public int idStock { get; set; }            // Identificador del stock
        public DateTime fecha { get; set; }         // Fecha del registro de stock
        public decimal st_x { get; set; }           // Cantidad en stock para cal_x
        public decimal st_1 { get; set; }           // Cantidad en stock para cal_1
        public decimal st_2 { get; set; }           // Cantidad en stock para cal_2
        public decimal st_3 { get; set; }           // Cantidad en stock para cal_3
        public decimal st_4 { get; set; }           // Cantidad en stock para cal_4
        public decimal st_m { get; set; }           // Cantidad en stock para cal_m
        public decimal st_ch { get; set; }          // Cantidad en stock para cal_ch

    }
}
