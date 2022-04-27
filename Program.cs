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
    public float CANNANG
    {
        get { return CanNang; }
        set { CanNang = value; }
    }
    public void GetHuman()
    {
        Console.WriteLine("Ten: {0} Chieu Cao: {1} Can Nang: {2}", HoVaTen, ChieuCao, CanNang);
    }

    public static int count = 0;

}

static class Number
{
    private static int number;
    public static int GetNumber()
    {
        return number;
    }
    static Number()
    {
        DateTime now = DateTime.Now;
        switch (now.DayOfWeek)
        {

            case DayOfWeek.Monday:
                number = 2;
                break;
            case DayOfWeek.Tuesday:
                number = 3;
                break;
            case DayOfWeek.Wednesday:
                number = 4;
                break;
            case DayOfWeek.Thursday:
                number = 5;
                break;
            case DayOfWeek.Friday:
                number = 6;
                break;
            case DayOfWeek.Saturday:
                number = 7;
                break;
            case DayOfWeek.Sunday:
                number = 8;
                break;

        }
    }


}
namespace HelloWorld
{

    class Program
    {
        static void Main(string[] args)
        {


            Human nguoi = new Human("bac", 165, 65);
            nguoi.GetHuman();
            nguoi.CANNANG = 70;
            nguoi.GetHuman();
            Number.GetNumber();

        }

    }
}