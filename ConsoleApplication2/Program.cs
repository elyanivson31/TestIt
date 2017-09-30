using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Test2(32, 4564324534327673532);
            Console.WriteLine(result.ToString());
        }



        public static int Test2(int A, ulong B)
        {

            int PlaceHolder = 0;
            var FinalREsult = "";
            int tmplocation = 0;
            int tmpindex = 0;
            int tmpFinalREsult = 0;
            int CurrentLocation = 0;

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string Astring = A.ToString();
            string Bstring = B.ToString();

            for (int i = 0; i < Bstring.Length; i++)
            {
                if (Bstring.Contains(Astring))
                {
                    tmplocation = Bstring.IndexOf(Astring) + CurrentLocation;
                    tmpindex = Bstring.IndexOf(Astring);
                    tmpFinalREsult = Bstring.IndexOf(Astring) + CurrentLocation;
                    FinalREsult += tmpFinalREsult;//Bstring.IndexOf(Astring);
                    var tmpBstring = Bstring.Substring(tmpindex + Astring.Length);
                    Bstring = tmpBstring;
                    CurrentLocation = tmplocation + (Astring.Length);
                }
                else
                {
                    if (FinalREsult == "")
                    { return -1; }
                    break;
                }
            }
            int.TryParse(FinalREsult, out PlaceHolder);
            return PlaceHolder;
        }
    }


}

