using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Ent_compra
    {
        public int idCompra { get; set; }           // Identificador de compra
        public string proveedor { get; set; }       // Proveedor de la compra
        public DateTime fecha { get; set; }         // Fecha de la compra
        public decimal cal_x { get; set; }          // Cantidad en cal_x
        public decimal cal_1 { get; set; }          // Cantidad en cal_1
        public decimal cal_2 { get; set; }          // Cantidad en cal_2
        public decimal cal_3 { get; set; }          // Cantidad en cal_3
        public decimal cal_4 { get; set; }          // Cantidad en cal_4
        public decimal cal_m { get; set; }          // Cantidad en cal_m
        public decimal cal_ch { get; set; }         // Cantidad en cal_ch
        public decimal pr_x { get; set; }           // Precio en pr_x
        public decimal pr_1 { get; set; }           // Precio en pr_1
        public decimal pr_2 { get; set; }           // Precio en pr_2
        public decimal pr_3 { get; set; }           // Precio en pr_3
        public decimal pr_4 { get; set; }           // Precio en pr_4
        public decimal pr_m { get; set; }           // Precio en pr_m
        public decimal pr_ch { get; set; }          // Precio en pr_ch
        public decimal mont_tt { get; set; }        // Monto total de la compra
    }

}
