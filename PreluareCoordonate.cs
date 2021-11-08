using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenTK_Test
{
    class PreluareCoordonate
    {
        List<int> pos = new List<int>(new int[12]);
        List<int> pos2 = new List<int>(new int[100]);


        public List<int> preluareCoordonate()
        {
            char[] delimiterChars = { ',' };
            StreamReader file = new StreamReader(@"C:\Users\Vittalik\source\repos\OpenTK Test\bin\Debug\coordonate.txt");

            string line;
            while ((line = file.ReadLine()) != null)
            {
                string[] values = line.Split(delimiterChars);
                int i = 0;
                foreach (string v in values)
                {
                    pos[i] = Int32.Parse(v);
                    i++;
                }
            }

            return pos;
        }



        public List<int> PreluareCub()
        {
            string filePath = @"cub.txt";
            string line;


            if (File.Exists(filePath))
            {
                StreamReader file = null;
                try
                {
                    file = new StreamReader(filePath);
                    string[] values;
                    int i = 0;

                    while ((line = file.ReadLine()) != null)
                    {
                        values = line.Split(',');

                            foreach (string v in values)
                            {
                                pos2[i] = Int32.Parse(v);
                                i++;
                            }
                    }

                }
                finally
                {
                    if (file != null)
                        file.Close();
                }
            }
            return pos2;
        }

    }
}
