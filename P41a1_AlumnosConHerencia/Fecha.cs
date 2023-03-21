using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P41a1_AlumnosConHerencia
{
    class Fecha
    {
        //Atributos
        int anyo, mes, dia;

        string[] vMeses = {"enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre"};
        public int[] maximoDiasMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        //Constructores
        public Fecha(int anyo, int mes, int dia)
        {
            this.Anyo = anyo;
            this.Mes = mes;
            this.Dia = dia;
        }
        public Fecha(int fechaNac) 
        {
            string fechaComoString = fechaNac.ToString();
            this.Anyo=int.Parse(fechaComoString.Substring(0,4));
            this.Mes = int.Parse(fechaComoString.Substring(4,2));
            this.Dia = int.Parse(fechaComoString.Substring(6,2));
        }
        public Fecha() 
        {
            this.Anyo = DateTime.Now.Year;
            this.Mes=DateTime.Now.Month;
            this.Dia=DateTime.Now.Day;
        }

        //Propiedades getter & setter de los campos
        public int Anyo { get => anyo; set => anyo = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Dia { get => dia; set => dia = value; }

        //Propiedades de solo lectura
        public int FechaEntero
        {
            get
            {
                string fechaConcat=anyo.ToString()+mes.ToString()+dia.ToString();
                return int.Parse(fechaConcat);
            }
        }
        public string FechaStringSP
        {
            get => String.Format("{0}/{1}/{2}",dia.ToString("00"),mes.ToString("00"),anyo.ToString());
        }
        public string FechaStringTexto
        {
            get => String.Format("{0} de {1} de {2}",dia,vMeses[mes],anyo);
        }
        public bool EsBisiesto
        {
            get 
            {
                if(DateTime.IsLeapYear(this.anyo))
                    return true;
                else 
                    return false;
            }
        }
        public void AvanzaDia()
        {
            dia++;
            if (dia > maximoDiasMes[mes])
            {
                dia = 1;
                mes++;
            }
            if (mes > 12)
            {
                mes = 1;
                anyo++;

                if (EsBisiesto)
                    maximoDiasMes[1] = 29;
                else
                    maximoDiasMes[1] = 28;
            }
        }



    }
}
