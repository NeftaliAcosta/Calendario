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
            string[] calen = new string[37];
            //int DateTime.DaysInMonth(int year, int month)
            int i=0;
            int aux = 0;
            int dactual, d, ndia, nyear,dinm;//dactual>Obtiene el numero del nombre del dia de la semana
            int w = 1; //Variable que escribe los días en el calendario
            //mactual = DateTime.Now.Month;
            mactual = 1;
            dactual = Convert.ToInt32(DateTime.Today.DayOfWeek);//Nombre del dia actual
            nyear = DateTime.Now.Year; //Obtiene el año actual
            ndia = DateTime.Now.Day; //Obtiene el día en fecha
            int menor = 0;
            dinm = DateTime.DaysInMonth(nyear, mactual);//Numeros totales de dias del mes
            string dinicio = new DateTime(nyear, mactual, 1).DayOfWeek.ToString(); //Obtiene el dia de la semana que inicia el mes
            string dfinal = new DateTime(nyear, mactual + 1,1).AddDays(-1).DayOfWeek.ToString();//Obtiene el dia de la semana que finaliza el mes

            dinicio =traductordias(dinicio);//Traduce el nombre del dia de inicio del mes
            dfinal = traductordias(dfinal);//Traduce el nombre del dia de fin del mes
            mactual=mactual - 1;
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

            
          for (int var =0; var<=6; var++)
            {
              if (dinicio==get.dia[var])
              {
                  for(i=var; aux < dinm; i++)
                  {
                      calen[i] = w.ToString();
                      w++;
                      aux++;
                  }
                    var = 6;
               }
             else 
              {
                  calen[var]=" ";
              }
            }
            if (i <34) 
            {
                for (menor = w - 1; menor <= 34; menor++)
                {
                    calen[menor] = "  ";
                }
            }


            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Hoy es "+ get.dia[dactual]+ " " + ndia+ " de " + get.mes[mactual] + " del " + nyear);
            Console.WriteLine("\n");
            Console.WriteLine("El mes mostrado es: " + get.mes[mactual]);
            Console.WriteLine(get.dia[0]    +"|"+ get.dia[1]    +"|"+ get.dia[2]    +"|"+ get.dia[3]    +"|"+ get.dia[4]    +"|"+ get.dia[5]    +"|"+ get.dia[6]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[0]  +"      |"+ calen[1]  +"    |"+ calen[2]  +"     |"+ calen[3]  +"        |"+ calen[4]  +"     |"+ calen[5]  +"       |"+ calen[6]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[7] + "      |" + calen[8] + "    |" + calen[9] + "    |" + calen[10] + "       |" + calen[11] + "    |" + calen[12] + "      |" + calen[13]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[14] + "     |" + calen[15] + "   |" + calen[16] + "    |" + calen[17] + "       |" + calen[18] + "    |" + calen[19] + "      |" + calen[20]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[21] + "     |" + calen[22] + "   |" + calen[23] + "    |" + calen[24] + "       |" + calen[25] + "    |" + calen[26] + "      |" + calen[27]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[28] + "     |" + calen[29] + "   |" + calen[30] + "    |" + calen[31] + "       |" + calen[32] + "    |" + calen[33] + "      |" + calen[34]);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(calen[35] + "     |" + calen[36] );
            //System.Threading.Thread.Sleep(9000);
            Console.Read();
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
