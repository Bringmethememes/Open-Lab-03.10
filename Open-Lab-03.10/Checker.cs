using System;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Open_Lab_03._10
{
    public class Checker
    {
        public int GetNumberOfCharsInString(char letter, string str)
        {
            int a = str.Split(letter).Length - 1;
            return a;
        }
    }
}
