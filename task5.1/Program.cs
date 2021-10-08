using System;

namespace task5._1
{    class StringArray
    {
        string[] array;


        public StringArray(string[] arr)
        {
            
            this.array = new string[arr.Length];
            for(int i=0;i<arr.Length;++i)
            {
                this.array[i] = arr[i];
            }
        }

        public int CountChar()
        {
            int count = 0;
            for(int i = 0; i < this.array.Length; ++i)
            {
                string[] subs = this.array[i].Split(" ");
                
                for(int j = 0; j < subs.Length; ++j)
                {

                   for(int k = 0; k < subs[j].Length; ++k)
                    {
                        if (subs[j][k] == '#')
                        {
                            count++;
                           
                        }
                    }
                }

            }
            return count;
        }

        public void Replace()
        {
            for (int i = 0; i < this.array.Length; ++i)
            {
                string[] subs = this.array[i].Split(" ");
                int count = this.CountChar();
                int n = 0;
                this.array[i] = "";
                for (int j = 0; j < subs.Length; ++j)
                {
                    if (n <= (count/2))
                    {
                        subs[j] = subs[j].Replace('#', '<');
                        n++;
                    }
                    else
                    {
                       subs[j] =  subs[j].Replace('#', '>');
                        n++;
                    }
                    this.array[i] += subs[j] + " ";
                }

            }
        }

        public void Print()
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StringArray a;
           a = new StringArray(ReadStrings());
            a.Print();
            a.Replace();
            a.Print();
        }
        
        static string[] ReadStrings()
        {
            string[] AS;
            int count;
            string s;
            string[] AS2;


            Console.WriteLine("Enter strings:");

            count = 0;
            AS = new string[count];

            do
            {

                s = Console.ReadLine();


                if (s != "")
                {

                    count++;
                    AS2 = new string[count];
                    for (int i = 0; i < AS2.Length - 1; i++)
                        AS2[i] = AS[i];


                    AS2[count - 1] = s;


                    AS = AS2;
                }
            } while (s != "");
            return AS;
        }
    }
}
