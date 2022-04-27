using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Human
{
    private string? HoVaTen;
    private float ChieuCao, CanNang;

    public Human(string HT, float CC, float CN)
    {
        HoVaTen = HT;
        ChieuCao = CC;
        CanNang = CN;
        count++;
    }

    public void GetHuman()
    {
        Console.WriteLine("Ten: {0} Chieu Cao: {1} Can Nang: {2}", HoVaTen, ChieuCao, CanNang);
    }

    public static int count = 0;

}
namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {


            Human nguoi = new Human("Bac", 165, 65);
            nguoi.GetHuman();
            Console.WriteLine(Human.count);



        }

    }
}