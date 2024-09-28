using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Escenario : ITransformable
    {
        public Punto centro { get; set; }
        public IDictionary<string, Objeto> listaDeObjeto { get; set; }

        public Escenario()
        {
            centro = new Punto();
            listaDeObjeto = new Dictionary<string, Objeto>();
        }

        public void SetCentro(Punto c)
        {
            centro= c;
        }

        public Punto GetCentro()
        {
            return centro;
        }

        public void AnadirObjeto(string clave, Objeto valor)
        {
            listaDeObjeto.Add(clave, valor);
            centro = Centro();
        }

        public Objeto GetObjeto(string clave)
        {
            return listaDeObjeto[clave];
        }

        public Punto Centro()
        {
            Punto p = new Punto();
            p.Set(0, 0, 0);

            return p;
        }

        public void Trasladar(float x, float y, float z)
        {

            foreach (var objeto in listaDeObjeto)
            {
                objeto.Value.SetCentro(centro);
                objeto.Value.Trasladar(x, y, z);
            }
        }

        public void Escalar(float ve)
        {

            foreach (var objeto in listaDeObjeto)
            {
                objeto.Value.SetCentro(centro);
                objeto.Value.Escalar(ve);
            }
        }

        public void Rotar(float x, float y, float z)
        {
            foreach (var objeto in listaDeObjeto)
            {
                objeto.Value.SetCentro(centro);
                objeto.Value.Rotar(x, y, z);
            }
        }

        public void Dibujar()
        {
            foreach (var objeto in listaDeObjeto)
            {
                objeto.Value.SetCentro(centro);
                objeto.Value.Dibujar();
            }
        }
    }
}
