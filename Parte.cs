using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static OpenTK.Graphics.OpenGL.GL;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Parte : ITransformable
    {
        public Punto centro { get; set; }
        public IDictionary<string, Poligono> listaDePoligono { get; set; }

        public Parte()
        {
            centro=new Punto();
            listaDePoligono = new Dictionary<string, Poligono>();
        }

        public void SetCentro(Punto c)
        {
            centro = c;
        }

        public Punto GetCentro()
        {
            return centro;
        }

        public void AnadirPoligono(string clave, Poligono valor)
        {
            listaDePoligono.Add(clave, valor);
            centro=Centro();
        }

        public Poligono GetPoligono(string clave)
        {
            return listaDePoligono[clave];
        }

        public Punto Centro()
        {
            Punto p=new Punto();
            float sumx = 0;
            float sumy = 0;
            float sumz = 0;

            foreach (var poligono in listaDePoligono)
            {
                centro = poligono.Value.GetCentro();
                sumx=sumx+centro.x; 
                sumy=sumy+centro.y;
                sumz=sumz+centro.z;
            }

            float PromX=sumx/listaDePoligono.Count;
            float PromY=sumy/listaDePoligono.Count;
            float PromZ=sumz/listaDePoligono.Count;

            p.Set(PromX, PromY, PromZ);
            return p;

        }

        public void Trasladar(float x, float y, float z)
        {

            foreach (var poligono in listaDePoligono)
            {
                poligono.Value.SetCentro(this.centro);
                poligono.Value.Trasladar(x, y, z);

            }

        }

        public void Escalar(float ve)
        {

            foreach (var poligono in listaDePoligono)
            {
                poligono.Value.SetCentro(centro);
                poligono.Value.Escalar(ve);
            }
        }

        public void Rotar(float x, float y, float z)
        {
            foreach (var poligono in listaDePoligono)
            {
                poligono.Value.SetCentro(centro);
                poligono.Value.Rotar(x, y, z);
            }
        }

        public void Dibujar()
        {
            foreach (var poligono in listaDePoligono)
            {
                poligono.Value.SetCentro(centro);
                poligono.Value.Dibujar();
            }
        }
    }
}
