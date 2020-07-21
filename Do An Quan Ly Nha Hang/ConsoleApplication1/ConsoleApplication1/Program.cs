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
            string specialchar = @"~1`1!1@1#1$1%1^1&1*1(1)1_1-1+1=1{1[1}1]1|1\1'1:1?1/1>1.1<1,1;";
            string[] arrSpecialChar = specialchar.Split('1');
            string hoten = "Hứa Tôn Đạ@t";
            for (int i = 0; i < arrSpecialChar.Count(); i++)
            {
                if (hoten.Contains(arrSpecialChar[i].ToString()))
                {
                    Console.Write("Trong chuỗi có kí tự đặc biệt: "+arrSpecialChar[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
