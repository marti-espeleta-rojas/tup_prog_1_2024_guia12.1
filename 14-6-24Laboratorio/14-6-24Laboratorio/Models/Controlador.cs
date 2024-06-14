using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_6_24Laboratorio.Models
{
    public class Controlador
    {
        public string[] names = new string[100];
        public int[] tiempos = new int[100];
        public int cont = 0;
        public void AgregarCompetidor(string comp)
        {
            names[cont++] = comp;
        }
        public void AgregarTiempos(int numeroPiloto,int hh, int min)
        {
            int total;
            total = hh * 60 + min;
            tiempos[numeroPiloto] = total;
        }
        public void MetodoBurbuja()
        {
            int auxint;
            string auxnom;
            for (int i = 0; i<cont-1;i++)
            {
                for (int j=i+1; j < cont; j++)
                {
                    if (tiempos[j] < tiempos[i])
                    {
                        auxint = tiempos[j];
                        tiempos[j] = tiempos[i];
                        tiempos[i] = auxint;

                        auxnom = names[j];
                        names[j] = names[i];
                        names[i] = auxnom;
                    }
                }
            }
        }
    }
}
