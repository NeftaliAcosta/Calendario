using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendario
{
    class fcalendario
    {

        public static void generador()
        {
            
            calendario get = new calendario();
            int mactual;
            int contador=1;
            int menor = 35;
            
            string[] calen = new string[35];
            //int DateTime.DaysInMonth(int year, int month)
            int m;
            int dactual, d, ndia, nyear,dinm;
  
            mactual = DateTime.Now.Month;
            dactual = DateTime.Now.Day;
            nyear = DateTime.Now.Year;
            ndia = DateTime.Now.Day;
            dinm = DateTime.DaysInMonth(nyear, mactual);
            //DateTime fecha1 = new DateTime(nyear, DateTime.Now.Month, 1);
            //DateTime fecha2 = new DateTime(nyear, DateTime.Now.Month+1, 1).AddDays(-1);
            string dinicio = new DateTime(nyear, DateTime.Now.Month, 1).DayOfWeek.ToString();
            string dfinal = new DateTime(nyear, DateTime.Now.Month + 1,1).AddDays(-1).DayOfWeek.ToString();

            dinicio =traductordias(dinicio);
            dfinal = traductordias(dfinal);
            m = mactual - 1;
            d = dactual - 1;

            get.dia[0] = "Domingo";
            get.dia[1] = "Lunes";
            get.dia[2] = "Martes";
            get.dia[3] = "Miercoles";
            get.dia[4] = "Jueves";
            get.dia[5] = "Viernes";
            get.dia[6] = "Sabado";

            get.mes[0] = "Enero";
            get.mes[1] = "Febero";
            get.mes[2] = "Marzo";
            get.mes[3] = "Abril";
            get.mes[4] = "Mayo";
            get.mes[5] = "Junio";
            get.mes[6] = "Julio";
            get.mes[7] = "Agosto";
            get.mes[8] = "Septiembre";
            get.mes[9] = "Octubre";
            get.mes[10] = "Nomviembre";
            get.mes[11] = "Diciembre";

            int aux = 0;
            for (int w=0; w<=34; w++)
            {
                if (dinicio==get.dia[w])
                {
                    
                    
                    for ( aux=w; aux<dinm; aux++)
                    {
                        calen[aux] = contador.ToString();
                        contador++;
                    }
                }
                else if(aux <=menor)
                {
                    calen[aux] = "";
                    aux++;
                }
                


                
              
                menor--;
            }
           

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Hoy es "+ dactual+ " " + ndia+ " de " + get.mes[m] + " del " + nyear);
            Console.WriteLine("\n");
            Console.WriteLine(get.dia[0]    +"|"+ get.dia[1]    +"|"+ get.dia[2]    +"|"+ get.dia[3]    +"|"+ get.dia[4]    +"|"+ get.dia[5]    +"|"+ get.dia[6]);
            Console.WriteLine("------------------------------------------------------");



            System.Threading.Thread.Sleep(9000);
        }

        public static string traductordias(string dia)
        {
            if (dia == "Sunday"){
                dia = "Domingo";
            }
            else if (dia == "Monday")
            {
                dia = "Lunes";
            }
            else if (dia == "Tuesday")
            {
                dia = "Martes";
            }
            else if (dia == "Wednesday")
            {
                dia = "Miercoles";
            }
            else if (dia == "Thursday")
            {
                dia = "Jueves";
            }
            else if (dia == "Friday")
            {
                dia = "Viernes";
            }
            else if (dia == "Saturday")
            {
                dia = "Sabado";
            }

            return dia;
        }
    }

    
}
