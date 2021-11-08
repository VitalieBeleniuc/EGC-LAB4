using System;
using System.Collections.Generic;
using OpenTK.Input;

namespace OpenTK_Test
{
    //1.Creați o aplicație care la apăsarea unui set de taste va modifica
    //culoarea unei fețe a unui cub 3D (coordonatele acestuia vor fi
    //încărcate dintr-un fișier text) între valorile minime și maxime, pentru
    //fiecare canal de culoare.

    //2. Modificați aplicația pentru a manipula valorile RGB pentru fiecare
    //vertex ce definește un triunghi. Afișați valorile RGB în consolă.

    class Desenare
    {
        PreluareCoordonate data = new PreluareCoordonate();

        public double colorRed_V1 = 200;
        public double colorGreen_V1 = 1;
        public double colorBlue_V1 = 1;

        public double colorRed_V2 = 1;
        public double colorGreen_V2 = 200;
        public double colorBlue_V2 = 1;

        public double colorRed_V3 = 1;
        public double colorGreen_V3 = 1;
        public double colorBlue_V3 = 200;

        public double colorRed = 100;
        public double colorGreen= 0;
        public double colorBlue = 100;


        public void Controls()
        {
            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 1: Z, micsora: X");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 1: C, micsora: V");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 1: B, micsora: N\n");

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 2: A, micsora: S");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 2: D, micsora: F");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 2: G, micsora: H\n");

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 3: Q, micsora: W");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 3: E, micsora: R");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 3: T, micsora: Y\n");

            Console.WriteLine("Pentru a mari canalul RED pentru Vertexul 4: M, micsora: ,");
            Console.WriteLine("Pentru a mari canalul GREEN pentru Vertexul 4: J, micsora: K");
            Console.WriteLine("Pentru a mari canalul BLUE pentru Vertexul 4: U, micsora: I\n");
        }

        public void fataControls()
        {
            Console.WriteLine("Pentru a mari canalul RED: Z, micsora: X");
            Console.WriteLine("Pentru a mari canalul GREEN: C, micsora: V");
            Console.WriteLine("Pentru a mari canalul BLUE: B, micsora: N\n");
        }


        private void Valori()
        {
            Console.WriteLine("VERTEX 1 - Red:" + colorRed_V1 + " Green:" + colorGreen_V1 + " Blue:" + colorBlue_V1);
            Console.WriteLine("VERTEX 2 - Red:" + colorRed_V2 + " Green:" + colorGreen_V2 + " Blue:" + colorBlue_V2);
            Console.WriteLine("VERTEX 3 - Red:" + colorRed_V3 + " Green:" + colorGreen_V3 + " Blue:" + colorBlue_V3);
            Console.WriteLine("VERTEX 4 - Red:" + colorRed + " Green:" + colorGreen + " Blue:" + colorBlue);

        }

        private void ValoriCub()
        {
            Console.WriteLine("Red:" + colorRed + " Green:" + colorGreen + " Blue:" + colorBlue);
        }

        //1.Creați o aplicație care la apăsarea unui set de taste va modifica
        //culoarea unei fețe a unui cub 3D (coordonatele acestuia vor fi
        //încărcate dintr-un fișier text) între valorile minime și maxime, pentru
        //fiecare canal de culoare.
        public void deseneazaFata()
        {
            KeyboardState keyboard = Keyboard.GetState();

            if (keyboard[Key.Z])
            {
                Console.Clear();
                colorRed++;
                ValoriCub();

            }
            else if (keyboard[Key.X])
            {
                Console.Clear();
                colorRed--;
                ValoriCub();

            }

            if (keyboard[Key.C])
            {
                Console.Clear();
                colorGreen++;
                ValoriCub();

            }
            else if (keyboard[Key.V])
            {
                Console.Clear();
                colorGreen--;
                ValoriCub();

            }

            if (keyboard[Key.B])
            {
                Console.Clear();
                colorBlue++;
                ValoriCub();

            }
            else if (keyboard[Key.N])
            {
                Console.Clear();
                colorBlue--;
                ValoriCub();

            }
        }

        //2. Modificați aplicația pentru a manipula valorile RGB pentru fiecare
        //vertex ce definește un triunghi. Afișați valorile RGB în consolă.
        public void deseneaza()
        {

            KeyboardState keyboard = Keyboard.GetState();



            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////    VERTEX 1    //////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            if (colorRed_V1 < 255 && colorRed_V1 > 0)
            {
                if (keyboard[Key.Z])
                {
                    Console.Clear();
                    colorRed_V1++;
                    Valori();
                }
                else if (keyboard[Key.X])
                {
                    Console.Clear();
                    colorRed_V1--;
                    Valori();
                }
            }
            else if (colorRed_V1 >= 255)
            {
                if (keyboard[Key.X])
                {
                    Console.Clear();
                    colorRed_V1--;
                    Valori();
                }
            }
            else if (colorRed_V1 <= 0)
            {
                if (keyboard[Key.Z])
                {
                    Console.Clear();
                    colorRed_V1++;
                    Valori();
                }
            }



            if (colorGreen_V1 < 255 && colorGreen_V1 > 0)
            {
                if (keyboard[Key.C])
                {
                    Console.Clear();
                    colorGreen_V1++;
                    Valori();
                }
                else if (keyboard[Key.V])
                {
                    Console.Clear();
                    colorGreen_V1--;
                    Valori();
                }
            }
            else if (colorGreen_V1 >= 255)
            {
                if (keyboard[Key.V])
                {
                    Console.Clear();
                    colorGreen_V1--;
                    Valori();
                }
            }
            else if (colorGreen_V1 <= 0)
            {
                if (keyboard[Key.C])
                {
                    Console.Clear();
                    colorGreen_V1++;
                    Valori();
                }
            }



            if (colorBlue_V1 < 255 && colorBlue_V1 > 0)
            {
                if (keyboard[Key.B])
                {
                    Console.Clear();
                    colorBlue_V1++;
                    Valori();
                }
                else if (keyboard[Key.N])
                {
                    Console.Clear();
                    colorBlue_V1--;
                    Valori();
                }
            }
            else if (colorBlue_V1 >= 255)
            {
                if (keyboard[Key.N])
                {
                    Console.Clear();
                    colorBlue_V1--;
                    Valori();
                }
            }
            else if (colorBlue_V1 <= 0)
            {
                if (keyboard[Key.B])
                {
                    Console.Clear();
                    colorBlue_V1++;
                    Valori();
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////////////    VERTEX 2    //////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////


            if (colorRed_V2 < 255 && colorRed_V2 > 0)
            {
                if (keyboard[Key.A])
                {
                    Console.Clear();
                    colorRed_V2++;
                    Valori();

                }
                else if (keyboard[Key.S])
                {
                    Console.Clear();
                    colorRed_V2--;
                    Valori();
                }
            }
            else if (colorRed_V2 >= 255)
            {
                if (keyboard[Key.S])
                {
                    Console.Clear();
                    colorRed_V2--;
                    Valori();
                }
            }
            else if (colorRed_V2 <= 0)
            {
                if (keyboard[Key.A])
                {
                    Console.Clear();
                    colorRed_V2++;
                    Valori();
                }
            }



            if (colorGreen_V2 < 255 && colorGreen_V2 > 0)
            {
                if (keyboard[Key.D])
                {
                    Console.Clear();
                    colorGreen_V2++;
                    Valori();
                }
                else if (keyboard[Key.F])
                {
                    Console.Clear();
                    colorGreen_V2--;
                    Valori();
                }
            }
            else if (colorGreen_V2 >= 255)
            {
                if (keyboard[Key.D])
                {
                    Console.Clear();
                    colorGreen_V2--;
                    Valori();
                }
            }
            else if (colorGreen_V2 <= 0)
            {
                if (keyboard[Key.F])
                {
                    Console.Clear();
                    colorGreen_V2++;
                    Valori();
                }
            }



            if (colorBlue_V2 < 255 && colorBlue_V2 > 0)
            {
                if (keyboard[Key.G])
                {
                    Console.Clear();
                    colorBlue_V2++;
                    Valori();
                }
                else if (keyboard[Key.H])
                {
                    Console.Clear();
                    colorBlue_V2--;
                    Valori();
                }
            }
            else if (colorBlue_V2 >= 255)
            {
                if (keyboard[Key.H])
                {
                    Console.Clear();
                    colorBlue_V2--;
                    Valori();
                }
            }
            else if (colorBlue_V2 <= 0)
            {
                if (keyboard[Key.G])
                {
                    Console.Clear();
                    colorBlue_V2++;
                    Valori();
                }
            }


            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////       VERTEX 3 //////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            if (colorRed_V3 < 255 && colorRed_V3 > 0)
            {
                if (keyboard[Key.Q])
                {
                    Console.Clear();
                    colorRed_V3++;
                    Valori();

                }
                else if (keyboard[Key.W])
                {
                    Console.Clear();
                    colorRed_V3--;
                    Valori();
                }
            }
            else if (colorRed_V3 >= 255)
            {
                if (keyboard[Key.W])
                {
                    Console.Clear();
                    colorRed_V3--;
                    Valori();
                }
            }
            else if (colorRed_V3 <= 0)
            {
                if (keyboard[Key.Q])
                {
                    Console.Clear();
                    colorRed_V3++;
                    Valori();
                }
            }



            if (colorGreen_V3 < 255 && colorGreen_V3 > 0)
            {
                if (keyboard[Key.E])
                {
                    Console.Clear();
                    colorGreen_V3++;
                    Valori();
                }
                else if (keyboard[Key.R])
                {
                    Console.Clear();
                    colorGreen_V3--;
                    Valori();
                }
            }
            else if (colorGreen_V3 >= 255)
            {
                if (keyboard[Key.R])
                {
                    Console.Clear();
                    colorGreen_V3--;
                    Valori();
                }
            }
            else if (colorGreen_V3 <= 0)
            {
                if (keyboard[Key.E])
                {
                    Console.Clear();
                    colorGreen_V3++;
                    Valori();
                }
            }



            if (colorBlue_V3 < 255 && colorBlue_V3 > 0)
            {
                if (keyboard[Key.T])
                {
                    Console.Clear();
                    colorBlue_V3++;
                    Valori();
                }
                else if (keyboard[Key.Y])
                {
                    Console.Clear();
                    colorBlue_V3--;
                    Valori();
                }
            }
            else if (colorBlue_V3 >= 255)
            {
                if (keyboard[Key.Y])
                {
                    Console.Clear();
                    colorBlue_V3--;
                    Valori();
                }
            }
            else if (colorBlue_V3 <= 0)
            {
                if (keyboard[Key.T])
                {
                    Console.Clear();
                    colorBlue_V3++;
                    Valori();
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////       VERTEX 4 //////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////////

            if (colorRed < 255 && colorRed > 0)
            {
                if (keyboard[Key.M])
                {
                    Console.Clear();
                    colorRed++;
                    Valori();

                }
                else if (keyboard[Key.Comma])
                {
                    Console.Clear();
                    colorRed--;
                    Valori();
                }
            }
            else if (colorRed >= 255)
            {
                if (keyboard[Key.Comma])
                {
                    Console.Clear();
                    colorRed--;
                    Valori();
                }
            }
            else if (colorRed <= 0)
            {
                if (keyboard[Key.M])
                {
                    Console.Clear();
                    colorRed++;
                    Valori();
                }
            }



            if (colorGreen < 255 && colorGreen > 0)
            {
                if (keyboard[Key.J])
                {
                    Console.Clear();
                    colorGreen++;
                    Valori();
                }
                else if (keyboard[Key.K])
                {
                    Console.Clear();
                    colorGreen--;
                    Valori();
                }
            }
            else if (colorGreen >= 255)
            {
                if (keyboard[Key.K])
                {
                    Console.Clear();
                    colorGreen--;
                    Valori();
                }
            }
            else if (colorGreen <= 0)
            {
                if (keyboard[Key.J])
                {
                    Console.Clear();
                    colorGreen++;
                    Valori();
                }
            }



            if (colorBlue < 255 && colorBlue > 0)
            {
                if (keyboard[Key.U])
                {
                    Console.Clear();
                    colorBlue++;
                    Valori();
                }
                else if (keyboard[Key.I])
                {
                    Console.Clear();
                    colorBlue--;
                    Valori();
                }
            }
            else if (colorBlue >= 255)
            {
                if (keyboard[Key.I])
                {
                    Console.Clear();
                    colorBlue--;
                    Valori();
                }
            }
            else if (colorBlue <= 0)
            {
                if (keyboard[Key.U])
                {
                    Console.Clear();
                    colorBlue++;
                    Valori();
                }
            }
        }
    }
}
