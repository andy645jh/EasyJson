using System;
using System.Collections;
using System.IO;
using ManageJson.lib;

namespace ManageJson
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader objReader = new StreamReader("../../test.txt");
            
            string json = objReader.ReadToEnd();
            EasyJson easy = new EasyJson();
            easy.ParseToJsonObj(json);
            
            /*ArrayList arrText = new ArrayList();
            string[] arr = json.Split(',');
            string newStr = "";
            foreach(var num in arr)
            {
                //Console.WriteLine(num);
                newStr += "'"+num+"',";
            }

            objReader.Close();                      
            
            Console.WriteLine("prueba: "+newStr);
            */
            Console.ReadKey();
        }
    }
}
