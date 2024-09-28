using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Objeto : ITransformable
    {
        public Punto centro { get; set; }
        public IDictionary<string, Parte> listaDeParte { get; set; }

        public Objeto()
        {
            centro= new Punto();
            listaDeParte= new Dictionary<string, Parte>();
        }

        public void SetCentro(Punto c)
        {
            centro = c;
        }

        public Punto GetCentro()
        {
            return centro;
        }

        public void AnadirParte(string clave, Parte valor)
        {
            listaDeParte.Add(clave, valor);
            centro = Centro();
        }

        public Parte GetParte(string clave)
        {
            return listaDeParte[clave];
        }

        public Punto Centro()
        {
            Punto p = new Punto();
            float sumX = 0;
            float sumY = 0;
            float sumZ = 0;

            foreach (var parte in listaDeParte)
            {
                var centroParte = parte.Value.Centro();
                sumX += centroParte.x;
                sumY += centroParte.y;
                sumZ += centroParte.z;
            }

            // Promedio de los centros de las partes
            if (listaDeParte.Count > 0)
            {
                p.Set(sumX / listaDeParte.Count,
                    sumY / listaDeParte.Count,
                    sumZ / listaDeParte.Count) ;
            }

            return p;
        }

        public void Trasladar(float x, float y, float z)
        {

            foreach (var parte in listaDeParte)
            {
                parte.Value.SetCentro(centro);
                parte.Value.Trasladar(x, y, z);
            }
        }

        public void Escalar(float ve)
        {

            foreach (var parte in listaDeParte)
            {
                parte.Value.SetCentro(centro);
                parte.Value.Escalar(ve);
            }
        }

        public void Rotar(float x, float y, float z)
        {
            foreach (var parte in listaDeParte)
            {
                parte.Value.SetCentro(centro);
                parte.Value.Rotar(x, y, z);
            }
        }

        public void Dibujar()
        {
            //realizar suma de centros
            foreach (var parte in listaDeParte)
            {
                parte.Value.SetCentro(centro);
                parte.Value.Dibujar();
            }
        }
    }
}
