using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Serializador
    {

        public void CrearYGuardar()
        {
            Punto a = new Punto();
            Punto b = new Punto();
            Punto c = new Punto();
            Punto d = new Punto();
            Punto a1 = new Punto();
            Punto b1 = new Punto();
            Punto c1 = new Punto();
            Punto d1 = new Punto();
            Punto f = new Punto();
            Punto g = new Punto();
            Punto h = new Punto();
            Punto i = new Punto();
            Punto f1 = new Punto();
            Punto g1 = new Punto();
            Punto h1 = new Punto();
            Punto i1 = new Punto();

            a.Set(-0.2f, -0.8f, 0.0f);
            b.Set(-0.2f, -0.6f, 0.0f);
            c.Set(-0.8f, -0.6f, 0.0f);
            d.Set(-0.8f, -0.8f, 0.0f);

            a1.Set(-0.2f, -0.8f, 0.2f);
            b1.Set(-0.2f, -0.6f, 0.2f);
            c1.Set(-0.8f, -0.6f, 0.2f);
            d1.Set(-0.8f, -0.8f, 0.2f);

            //abajo
            f.Set(-0.4f, -0.6f, 0.0f);
            g.Set(-0.4f, -0.1f, 0.0f);
            h.Set(-0.6f, -0.1f, 0.0f);
            i.Set(-0.6f, -0.6f, 0.0f);

            f1.Set(-0.4f, -0.6f, 0.2f);
            g1.Set(-0.4f, -0.1f, 0.2f);
            h1.Set(-0.6f, -0.1f, 0.2f);
            i1.Set(-0.6f, -0.6f, 0.2f);

            Poligono frente = new Poligono();
            frente.AnadirPunto("Punto1", a);
            frente.AnadirPunto("Punto2", b);
            frente.AnadirPunto("Punto3", c);
            frente.AnadirPunto("Punto4", d);


            Poligono atras = new Poligono();
            atras.AnadirPunto("Punto5", a1);
            atras.AnadirPunto("Punto6", b1);
            atras.AnadirPunto("Punto7", c1);
            atras.AnadirPunto("Punto8", d1);

            Poligono izquierda = new Poligono();
            izquierda.AnadirPunto("Punto9", a1);
            izquierda.AnadirPunto("Punto10", b1);
            izquierda.AnadirPunto("Punto11", b);
            izquierda.AnadirPunto("Punto12", a);

            Poligono derecha = new Poligono();
            derecha.AnadirPunto("Punto13", d1);
            derecha.AnadirPunto("Punto14", c1);
            derecha.AnadirPunto("Punto15", c);
            derecha.AnadirPunto("Punto16", d);

            Poligono frente2 = new Poligono();
            frente2.AnadirPunto("P1", f);
            frente2.AnadirPunto("P2", g);
            frente2.AnadirPunto("P3", h);
            frente2.AnadirPunto("P4", i);

            Poligono atras2 = new Poligono();
            atras2.AnadirPunto("P5", f1);
            atras2.AnadirPunto("P6", g1);
            atras2.AnadirPunto("P7", h1);
            atras2.AnadirPunto("P8", i1);

            Poligono izquierda2 = new Poligono();
            izquierda2.AnadirPunto("P9", f);
            izquierda2.AnadirPunto("P10", g);
            izquierda2.AnadirPunto("P11", g1);
            izquierda2.AnadirPunto("P12", f1);

            Poligono derecha2 = new Poligono();
            derecha2.AnadirPunto("P1", i);
            derecha2.AnadirPunto("P2", h);
            derecha2.AnadirPunto("P3", h1);
            derecha2.AnadirPunto("P4", i1);

            Parte parte1 = new Parte();
            parte1.AnadirPoligono("c1", frente);
            parte1.AnadirPoligono("c2", atras);
            parte1.AnadirPoligono("c3", izquierda);
            parte1.AnadirPoligono("c4", derecha);

            Parte parte2 = new Parte();
            parte2.AnadirPoligono("c1", frente2);
            parte2.AnadirPoligono("c2", atras2);
            parte2.AnadirPoligono("c3", izquierda2);
            parte2.AnadirPoligono("c4", derecha2);

            Objeto objeto1 = new Objeto();
            objeto1.AnadirParte("Parte1", parte1);
            objeto1.AnadirParte("Parte2", parte2);

            /////objeto2

            Punto a2 = new Punto(-0.2f, 0.2f, 0.0f);
            Punto b2 = new Punto(-0.2f, -0.2f, 0.0f);
            Punto c2 = new Punto(0.2f, -0.2f, 0.0f);
            Punto d2 = new Punto(0.2f, 0.2f, 0.0f);

            Punto a21 = new Punto(-0.2f, 0.2f, 0.2f);
            Punto b21 = new Punto(-0.2f, -0.2f, 0.2f);
            Punto c21 = new Punto(0.2f, -0.2f, 0.2f);
            Punto d21 = new Punto(0.2f, 0.2f, 0.2f);

            // va2c2ios 
            Poligono front = new Poligono();
            Poligono back = new Poligono();
            Poligono left = new Poligono();
            Poligono right = new Poligono();
            Poligono up = new Poligono();
            Poligono down = new Poligono();


            front.AnadirPunto("p1", a2);
            front.AnadirPunto("p2", b2);
            front.AnadirPunto("p3", c2);
            front.AnadirPunto("p4", d2);

            back.AnadirPunto("p5", a21);
            back.AnadirPunto("p6", b21);
            back.AnadirPunto("p7", c21);
            back.AnadirPunto("p8", d21);

            left.AnadirPunto("p1", a2);
            left.AnadirPunto("p2", a21);
            left.AnadirPunto("p3", b21);
            left.AnadirPunto("p4", b2);

            right.AnadirPunto("p1", d2);
            right.AnadirPunto("p2", d21);
            right.AnadirPunto("p3", c21);
            right.AnadirPunto("p4", c2);

            up.AnadirPunto("p1", a2);
            up.AnadirPunto("p2", a21);
            up.AnadirPunto("p3", d21);
            up.AnadirPunto("p4", d2);

            down.AnadirPunto("p1", b2);
            down.AnadirPunto("p2", b21);
            down.AnadirPunto("p3", c21);
            down.AnadirPunto("p4", c2);


            Parte cubo2 = new Parte();

            Objeto cubo = new Objeto();

            cubo2.AnadirPoligono("a", front);
            cubo2.AnadirPoligono("b", back);
            cubo2.AnadirPoligono("c", left);
            cubo2.AnadirPoligono("d", right);
            cubo2.AnadirPoligono("e", up);
            cubo2.AnadirPoligono("f", down);

            cubo.AnadirParte("cubo", cubo2);

            //objeto3
            Punto A = new Punto();
            Punto B = new Punto();
            Punto C = new Punto();
            Punto D = new Punto();
            Punto A1 = new Punto();
            Punto B1 = new Punto();
            Punto C1 = new Punto();
            Punto D1 = new Punto();
            Punto F = new Punto();
            Punto G = new Punto();
            Punto H = new Punto();
            Punto I = new Punto();
            Punto F1 = new Punto();
            Punto G1 = new Punto();
            Punto H1 = new Punto();
            Punto I1 = new Punto();

            A.Set(0.2f, 0.8f, 0.0f);
            B.Set(0.2f, 0.6f, 0.0f);
            C.Set(0.8f, 0.6f, 0.0f);
            D.Set(0.8f, 0.8f, 0.0f);

            A1.Set(0.2f, 0.8f, 0.2f);
            B1.Set(0.2f, 0.6f, 0.2f);
            C1.Set(0.8f, 0.6f, 0.2f);
            D1.Set(0.8f, 0.8f, 0.2f);

            //abajo
            F.Set(0.4f, 0.6f, 0.0f);
            G.Set(0.4f, 0.1f, 0.0f);
            H.Set(0.6f, 0.1f, 0.0f);
            I.Set(0.6f, 0.6f, 0.0f);

            F1.Set(0.4f, 0.6f, 0.2f);
            G1.Set(0.4f, 0.1f, 0.2f);
            H1.Set(0.6f, 0.1f, 0.2f);
            I1.Set(0.6f, 0.6f, 0.2f);

            Poligono frente1 = new Poligono();
            frente1.AnadirPunto("Punto1", A);
            frente1.AnadirPunto("Punto2", B);
            frente1.AnadirPunto("Punto3", C);
            frente1.AnadirPunto("Punto4", D);


            Poligono atras1 = new Poligono();
            atras1.AnadirPunto("Punto5", A1);
            atras1.AnadirPunto("Punto6", B1);
            atras1.AnadirPunto("Punto7", C1);
            atras1.AnadirPunto("Punto8", D1);

            Poligono izquierda1 = new Poligono();
            izquierda1.AnadirPunto("Punto9", A1);
            izquierda1.AnadirPunto("Punto10", B1);
            izquierda1.AnadirPunto("Punto11", B);
            izquierda1.AnadirPunto("Punto12", A);

            Poligono derecha1 = new Poligono();
            derecha1.AnadirPunto("Punto13", D1);
            derecha1.AnadirPunto("Punto14", C1);
            derecha1.AnadirPunto("Punto15", C);
            derecha1.AnadirPunto("Punto16", D);

            Poligono frente21 = new Poligono();
            frente21.AnadirPunto("P1", F);
            frente21.AnadirPunto("P2", G);
            frente21.AnadirPunto("P3", H);
            frente21.AnadirPunto("P4", I);

            Poligono atras21 = new Poligono();
            atras21.AnadirPunto("P5", F1);
            atras21.AnadirPunto("P6", G1);
            atras21.AnadirPunto("P7", H1);
            atras21.AnadirPunto("P8", I1);

            Poligono izquierda21 = new Poligono();
            izquierda21.AnadirPunto("P9", F);
            izquierda21.AnadirPunto("P10", G);
            izquierda21.AnadirPunto("P11", G1);
            izquierda21.AnadirPunto("P12", F1);

            Poligono derecha21 = new Poligono();
            derecha21.AnadirPunto("P1", I);
            derecha21.AnadirPunto("P2", H);
            derecha21.AnadirPunto("P3", H1);
            derecha21.AnadirPunto("P4", I1);

            Parte parte11 = new Parte();
            parte11.AnadirPoligono("c1", frente1);
            parte11.AnadirPoligono("c2", atras1);
            parte11.AnadirPoligono("c3", izquierda1);
            parte11.AnadirPoligono("c4", derecha1);

            Parte parte21 = new Parte();
            parte21.AnadirPoligono("c1", frente21);
            parte21.AnadirPoligono("c2", atras21);
            parte21.AnadirPoligono("c3", izquierda21);
            parte21.AnadirPoligono("c4", derecha21);

            Objeto objeto3 = new Objeto();
            objeto3.AnadirParte("Parte1", parte11);
            objeto3.AnadirParte("Parte2", parte21);
            ///
            Escenario escenario1 = new Escenario();
            escenario1.AnadirObjeto("Objeto1", objeto1);
            escenario1.AnadirObjeto("Objeto2", cubo);
            escenario1.AnadirObjeto("Objeto3", objeto3);


            // Guardar el objeto serializado
            Guardar(escenario1, "figura3d.json");
        }

        public void Guardar(Escenario escenanario, string ruta)
        {
            string json = JsonSerializer.Serialize(escenanario);
            File.WriteAllText(ruta, json);
        }

        public Escenario Cargar(string ruta)
        {
            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<Escenario>(json);
        }
    }
}
