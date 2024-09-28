using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    public class Game: GameWindow
    {
        private Escenario escenario1;
        public ITransformable p;
        public float s;

        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            escenario1 = new Escenario();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black);
            GL.Enable(EnableCap.DepthTest);

            Serializador serializador = new Serializador();

            if (!File.Exists("figura3d.json"))
            {
                serializador.CrearYGuardar(); // Crear y guardar el objeto si no existe el archivo
            }

            //Escenario escenarioCargado = serializador.Cargar("figura3d.json");
            escenario1 = serializador.Cargar("figura3d.json");


            //frente.escalar(1.5f); //aqui
            //parte1.escalar(1.2f);
            //objeto1.escalar(1.3f);
            //escenario1.escalar(1.2f);

            //Parte1, Parte2, Objeto1, cubo, Objeto2
            //GL.Rotate(45, 0.0, 0.1, 0.1);

            p = escenario1;
            //p = escenario1.GetObjeto("Objeto1");

            //p.Rotar(0, 45, 0);
            //p.Escalar(1.5f);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);


            s = (float)(e.Time * 0.07);
            p = escenario1;
            //p = escenario1.GetObjeto("Objeto1");
            //p = escenario1.GetObjeto("Objeto1").GetParte("Parte2");

            //p.Rotar(0, 45, 0);
            //p.Trasladar(0f, 0.001f, 0f);

            p.Dibujar();
            
            

            //frente.Dibujar();


            Context.SwapBuffers();

        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }
    }
}
