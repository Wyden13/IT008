using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Bai02
{
    class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            
           
            string[] aName = name.Split(' ');
            foreach(var s in aName)
            {
                Console.Write(char.ToUpper(s[0])+ s.Substring(1).ToLower() + " ");
              
            }

        }
    }

}