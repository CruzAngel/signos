using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Zodiaco
{
    /// <summary>
    /// Descripción breve de ZodiacoWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacoWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string Fecha(DateTime fecha)
        {
            string signo=string.Empty;
            int fec = fecha.Year;
            if (fecha >= new DateTime(fec, 3, 20)&&fecha<= new DateTime(fec, 4, 20))
            {
                signo = "Eres signo Aries";
            }

            if (fecha >= new DateTime(fec, 4, 20) && fecha <= new DateTime(fec, 5, 21))
            {
                signo = "Eres signo Tauro";
            }

            if (fecha >= new DateTime(fec, 5, 21) && fecha <= new DateTime(fec, 6, 21))
            {
                signo = "Eres signo Géminis";
            }

            if (fecha >= new DateTime(fec, 6, 21) && fecha <= new DateTime(fec, 7, 23))
            {
                signo = "Eres signo Cáncer";
            }

            if (fecha >= new DateTime(fec, 7, 23) && fecha <= new DateTime(fec, 8, 23))
            {
                signo = "Eres signo Leo";
            }

            if (fecha >= new DateTime(fec, 8, 23) && fecha <= new DateTime(fec, 9, 23))
            {
                signo = "Eres signo Virgo";
            }

            if (fecha >= new DateTime(fec, 9, 23) && fecha <= new DateTime(fec, 10, 23))
            {
                signo = "Eres signo Libra";
            }

            if (fecha >= new DateTime(fec, 10, 23) && fecha <= new DateTime(fec, 11, 22))
            {
                signo = "Eres signo Escorpio";
            }

            if (fecha >= new DateTime(fec, 11, 22) && fecha <= new DateTime(fec, 12, 22))
            {
                signo = "Eres signo Sagitario";
            }

            if (fecha >= new DateTime(fec, 12, 22) || fecha <= new DateTime(fec, 1, 20))
            {
                signo = "Eres signo Capricornio";
            }

            if (fecha >= new DateTime(fec, 1, 20) && fecha <= new DateTime(fec, 2, 18))
            {
                signo = "Eres signo Acuario";
            }

            if (fecha >= new DateTime(fec, 2, 18) && fecha <= new DateTime(fec, 3, 20))
            {
                signo = "Eres signo Piscis";
            }
            return signo;
        }
    }
}
