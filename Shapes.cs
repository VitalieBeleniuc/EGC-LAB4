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

namespace OpenTK_Test
{
    class Shapes
    {
        PreluareCoordonate dataCub = new PreluareCoordonate();
        Desenare cubdesen = new Desenare();
        PreluareCoordonate data = new PreluareCoordonate();
        Desenare desen = new Desenare();
        static Random rand = new Random();
        int DIM = 1;

        float[] random = Randomize();


        //3. Implementați un mecanism de modificare a culorilor (randomizare sau
        //încărcare din paletă predefinită) pentru o clasă ce permite desenarea
        //unui cub în spațiul 3D.

        public static float[] Randomize()
        {
            float[] randomcolors = new float[12];
            for(int i =0; i<randomcolors.Length; i++)
            {
                float rand1 = (float)rand.Next(0, 255) / 255;
                randomcolors[i] = rand1;
            }

            return randomcolors;
        }

        public void DrawPuncte()
        {
            GL.Begin(PrimitiveType.Points);
            GL.Color3(Color.Cyan);
            GL.Vertex2(0, 0);
            GL.End();
        }

        public void DrawAxe()
        {
            //Desenați axele de coordonate din aplicația-template folosind un singur apel GL.Begin().
            GL.Begin(PrimitiveType.Lines);
            //axa X
            GL.Color3(Color.Red);
            GL.Vertex2(-50, 0);
            GL.Vertex2(50, 0);
            //axa Y
            GL.Color3(Color.Red);
            GL.Vertex2(0, -50);
            GL.Vertex2(0, 50);
            //axa Z
            GL.Color3(Color.Red);
            GL.Vertex3(0, 0, 50);
            GL.Vertex3(0, 0, -50);
            GL.End();
        }

        public void DrawLinii()
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.Red);
            GL.Vertex2(1, 3);
            GL.Vertex2(1, 6);
            GL.Vertex2(1, -3);
            GL.Vertex2(1, -6);
            GL.End();

        }


        public void DrawLineStrip()
        {
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(Color.Purple);
            GL.Vertex2(-15, -10);
            GL.Color3(Color.Red);
            GL.Vertex2(-15, 12);
            GL.Color3(Color.Yellow);
            GL.Vertex2(15, 12);
            GL.Color3(Color.Green);
            GL.Vertex2(15, -10);

            GL.End();
        }

        public void DrawLineLoop()
        {
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(Color.Yellow);
            GL.Vertex2(-10, -10);
            GL.Vertex2(-10, 10);

            GL.Vertex2(10, 10);
            GL.Vertex2(10, -10);

            GL.End();
        }


        public void DrawTriunghi()
        {

            List<int> poz = data.preluareCoordonate();
            desen.deseneaza();

            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(desen.colorRed_V1 / 255, desen.colorGreen_V1 / 255, desen.colorBlue_V1 / 255);
            GL.Vertex2(poz[0], poz[1]);
            GL.Color3(desen.colorRed_V2 / 255, desen.colorGreen_V2 / 255, desen.colorBlue_V2 / 255);
            GL.Vertex2(poz[2], poz[3]);
            GL.Color3(desen.colorRed_V3 / 255, desen.colorGreen_V3 / 255, desen.colorBlue_V3 / 255);
            GL.Vertex2(poz[4], poz[5]);
            GL.End();
        }


        public void DrawTriunghiStrip()
        {
            GL.Begin(PrimitiveType.TriangleStrip);
            GL.Color3(Color.Lime);
            GL.Vertex2(-2, -7);
            GL.Vertex2(2, -7);
            GL.Vertex2(0, -9);
            GL.Color3(Color.Red);
            GL.Vertex2(9, -9);
            GL.End();
        }

        public void DrawTriunghiFan()
        {
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.Lime);
            GL.Vertex2(5, 0);
            GL.Vertex2(2, -5);
            GL.Vertex2(2, 5);
            GL.Color3(Color.Red);
            GL.Vertex2(3, 6);
            GL.End();
        }

        public void DrawCube()
        {
            List<int> cub = dataCub.PreluareCub();
            cubdesen.deseneaza();

            GL.Begin(PrimitiveType.Quads);

            GL.Color3(Color.Silver);
            GL.Vertex3(cub[0], cub[1], cub[2]);
            GL.Vertex3(cub[3], cub[4], cub[5]);
            GL.Vertex3(cub[6], cub[7], cub[8]);
            GL.Vertex3(cub[9], cub[10], cub[11]);

            GL.Color3(Color.Honeydew);
            GL.Vertex3(cub[12], cub[13], cub[14]);
            GL.Vertex3(cub[15], cub[16], cub[17]);
            GL.Vertex3(cub[18], cub[19], cub[20]);
            GL.Vertex3(cub[21], cub[22], cub[23]);

            GL.Color3(Color.Moccasin);
            GL.Vertex3(cub[24], cub[25], cub[26]);
            GL.Vertex3(cub[27], cub[28], cub[29]);
            GL.Vertex3(cub[30], cub[31], cub[32]);
            GL.Vertex3(cub[33], cub[34], cub[35]);

            //Liste

            GL.Color3(Color.IndianRed);
            GL.Vertex3(cub[36], cub[37], cub[38]);
            GL.Vertex3(cub[39], cub[40], cub[41]);
            GL.Vertex3(cub[42], cub[43], cub[44]);
            GL.Vertex3(cub[45], cub[46], cub[47]);

            GL.Color3(cubdesen.colorRed_V1 / 255, cubdesen.colorGreen_V1 / 255, cubdesen.colorBlue_V1 / 255);
            GL.Vertex3(cub[48], cub[49], cub[50]);
            GL.Color3(cubdesen.colorRed_V2 / 255, cubdesen.colorGreen_V2 / 255, cubdesen.colorBlue_V2 / 255);
            GL.Vertex3(cub[51], cub[52], cub[53]);
            GL.Color3(cubdesen.colorRed_V3 / 255, cubdesen.colorGreen_V3 / 255, cubdesen.colorBlue_V3 / 255);
            GL.Vertex3(cub[54], cub[55], cub[56]);
            GL.Color3(cubdesen.colorRed / 255, cubdesen.colorGreen / 255, cubdesen.colorBlue / 255);
            GL.Vertex3(cub[57], cub[58], cub[59]);

            GL.Color3(Color.ForestGreen);
            GL.Vertex3(cub[60], cub[61], cub[62]);
            GL.Vertex3(cub[63], cub[64], cub[65]);
            GL.Vertex3(cub[66], cub[67], cub[68]);
            GL.Vertex3(cub[69], cub[70], cub[71]);

            GL.End();
        }



        public void DrawCube3D()
        {
            List<int> cub = dataCub.PreluareCub();


            GL.Begin(PrimitiveType.Quads);

            GL.Color3(random[3], random[4], random[5]);
            GL.Vertex3(cub[0], cub[1], cub[2]);
            GL.Vertex3(cub[3], cub[4], cub[5]);
            GL.Vertex3(cub[6], cub[7], cub[8]);
            GL.Vertex3(cub[9], cub[10], cub[11]);

            GL.Color3(random[0], random[1], random[2]);
            GL.Vertex3(cub[12], cub[13], cub[14]);
            GL.Vertex3(cub[15], cub[16], cub[17]);
            GL.Vertex3(cub[18], cub[19], cub[20]);
            GL.Vertex3(cub[21], cub[22], cub[23]);

            GL.Color3(random[6], random[7], random[8]);
            GL.Vertex3(cub[24], cub[25], cub[26]);
            GL.Vertex3(cub[27], cub[28], cub[29]);
            GL.Vertex3(cub[30], cub[31], cub[32]);
            GL.Vertex3(cub[33], cub[34], cub[35]);

            GL.Color3(random[6], random[7], random[8]);
            GL.Vertex3(cub[36], cub[37], cub[38]);
            GL.Vertex3(cub[39], cub[40], cub[41]);
            GL.Vertex3(cub[42], cub[43], cub[44]);
            GL.Vertex3(cub[45], cub[46], cub[47]);

            GL.Color3(random[0], random[1], random[2]);
            GL.Vertex3(cub[48], cub[49], cub[50]);
            GL.Vertex3(cub[51], cub[52], cub[53]);
            GL.Vertex3(cub[54], cub[55], cub[56]);
            GL.Vertex3(cub[57], cub[58], cub[59]);

            GL.Color3(random[3], random[4], random[5]);
            GL.Vertex3(cub[60], cub[61], cub[62]);
            GL.Vertex3(cub[63], cub[64], cub[65]);
            GL.Vertex3(cub[66], cub[67], cub[68]);
            GL.Vertex3(cub[69], cub[70], cub[71]);

            GL.End();
        }

        public void DrawCub1()
        {
            GL.Begin(PrimitiveType.Quads);

            GL.Color3(Color.Silver);
            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, -1.0f * DIM);

            GL.Color3(Color.Silver);
            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, 1.0f * DIM);

            GL.Color3(Color.Silver);

            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, -1.0f * DIM);

            GL.Color3(Color.Silver);
            GL.Vertex3(-1.0f * DIM, -1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, 1.0f * DIM);

            GL.Color3(Color.Silver);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(-1.0f * DIM, 1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, -1.0f * DIM);

            GL.Color3(Color.Silver);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, -1.0f * DIM);
            GL.Vertex3(1.0f * DIM, 1.0f * DIM, 1.0f * DIM);
            GL.Vertex3(1.0f * DIM, -1.0f * DIM, 1.0f * DIM);

            GL.End();
        }

    }
}
