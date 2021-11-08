using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using OpenTK.Platform;
using System.Collections;



//Beleniuc Vitalie 3132B Laboratorul 4
//Aplicatie template scrisa de la 0

//1.Creați o aplicație care la apăsarea unui set de taste va modifica
//culoarea unei fețe a unui cub 3D (coordonatele acestuia vor fi
//încărcate dintr-un fișier text) între valorile minime și maxime, pentru
//fiecare canal de culoare.

//2. Modificați aplicația pentru a manipula valorile RGB pentru fiecare
//vertex ce definește un triunghi. Afișați valorile RGB în consolă.

//3. Implementați un mecanism de modificare a culorilor (randomizare sau
//încărcare din paletă predefinită) pentru o clasă ce permite desenarea
//unui cub în spațiul 3D.


namespace OpenTK_Test
{

    class Window : GameWindow
    {
        Shapes shape = new Shapes();

        Desenare controls = new Desenare();
        Camera cam = new Camera();
        Random rand = new Random();

        //ArrayList arlist = new ArrayList();
        private List<Vector3> coordsList;


        bool drawShape = false;
        float x, y, z;
        int i = 0;
        int limit = 0;
        bool collision = false;


        public Window() : base(900, 700, new GraphicsMode(32, 0, 0, 8))
        {
            VSync = VSyncMode.On;

            controls.Controls();
            //controls.fataControls();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            GL.ClearColor(Color.Blue);
            GL.Enable(EnableCap.DepthTest);
            GL.DepthFunc(DepthFunction.Less);
            GL.Hint(HintTarget.PolygonSmoothHint, HintMode.Nicest);

            coordsList = new List<Vector3>();


        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            GL.Viewport(0, 0, Width, Height);
            double aspect_ratio = Width / (double)Height;


            Matrix4 perspective = Matrix4.CreatePerspectiveFieldOfView(MathHelper.PiOver4, (float)aspect_ratio, 1, 64);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadMatrix(ref perspective);

            Matrix4 lookat = Matrix4.LookAt(0, 0, 30, 0, 0, 0, 0, 1, 0);
            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadMatrix(ref lookat);

            cam.SetCamera();


        }

        public void Check(int limit1)
        {
            if (limit1 >= y)
            {
                drawShape = false;
                limit = 0;
                i = 0;
                collision = true;
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit);
            GL.Clear(ClearBufferMask.DepthBufferBit);

            shape.DrawAxe();
            //Pentru cub care isi schimba culorile vertexilor
            shape.DrawCube();

            GL.PointSize(10);

            //Pentru cub cu colori randomizate
            //shape.DrawCube3D();

            //if (drawShape == true)
            //{
            //    GL.PushMatrix();
            //    GL.Translate(0, i--, 0);
            //    Check(limit);
            //    limit++;
            //    GL.Translate(x, y, z);
            //    shape.DrawCub1();
            //    GL.PopMatrix();
            //}

            //if(collision == true)
            //{

            //    coordsList.Add(new Vector3(x,y,z));

            //    collision = false;
            //}

            //foreach(Vector3 v in coordsList)
            //{
            //    GL.PushMatrix();
            //    GL.Translate(v.X,0,v.Z);
            //    shape.DrawCub1();
            //    GL.PopMatrix();
            //}

            SwapBuffers();

        }



        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);

            KeyboardState keyboard = Keyboard.GetState();
            MouseState mouse = Mouse.GetState();


            if (keyboard[Key.Left])
            {
                cam.MoveForward();
            }
            if (keyboard[Key.Right])
            {
                cam.MoveBackward();
            }
            if (keyboard[Key.Down])
            {
                cam.MoveLeft();
            }
            if (keyboard[Key.Up])
            {
                cam.MoveRight();
            }
            if (keyboard[Key.Number1])
            {
                cam.MoveUp();
            }
            if (keyboard[Key.Number2])
            {
                cam.MoveDown();
            }


            if (keyboard[Key.Escape])
            {
                Exit();
            }
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            //Console.WriteLine("OnMouseDown");

            if (e.Button == MouseButton.Left)
            {
                x = rand.Next(-20,20);
                y = rand.Next(0,20);
                z = rand.Next(-20,20);

                Console.WriteLine("Obiect generat la:" + x + " " + y + " " + z);
                drawShape = true;
            }
        }





        static void Main(string[] args)
        {
            using (Window example = new Window())
            {
                example.Run(30.0, 0.0);
            }
        }
    }
}