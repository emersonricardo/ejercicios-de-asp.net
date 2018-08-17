using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ejecicio2NotasWebApp.Models
{
    public class CapturaDatos
    {
        // datos String
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }

        // variables de Matematicas
        [Range(0.0,10.0,ErrorMessage ="El dato ingresado no es correcto por favor ingrese notas entre 0.0 y 10.0")]
        [Display(Name ="Nota 1 de Matematicas")]
        public double lab1Mate { get; set; }
        public double lab2Mate { get; set; }
        public double lab3Mate { get; set; }

        //variables de Ceincia
        public double lab1Ciencia { get; set; }
        public double lab2Ciencia { get; set; }
        public double lab3Ciencia { get; set; }

        //variables de Ceincia
        public double lab1lenguaje { get; set; }
        public double lab2lenguaje { get; set; }
        public double lab3lenguaje { get; set; }

        //variables de Ceincia
        public double lab1Tecno { get; set; }
        public double lab2Tecno { get; set; }
        public double lab3Tecno { get; set; }

        public double Matematicas( CapturaDatos datos)
        {

            return ((datos.lab1Mate*0.33)+(datos.lab2Mate*0.33)+(datos.lab3Mate*0.34));
        }

        public double Ciencia(CapturaDatos datos)
        {

            return ((datos.lab1Ciencia * 0.33) + (datos.lab2Ciencia * 0.33) + (datos.lab3Ciencia * 0.34));
        }
        public double Lenguaje(CapturaDatos datos)
        {

            return ((datos.lab1lenguaje * 0.33) + (datos.lab2lenguaje * 0.33) + (datos.lab3lenguaje * 0.34));
        }
        public double Tecnologia(CapturaDatos datos)
        {

            return ((datos.lab1Tecno * 0.33) + (datos.lab2Tecno * 0.33) + (datos.lab3Tecno * 0.34));
        }






    }
}