using System;

public class Month
{
    public int HotWater { get; set; }
    public int ColdWater { get; set; }
    public int Electricity { get; set; }
    public int Payment { get; set; }

    public Month(int hot,int cold,int e)
    {
        HotWater = hot;
        ColdWater = cold;
        Electricity = e;
        Payment = Convert.ToInt32(Math.Round(((hot + cold) / 1000) * 50 + Electricity * 1.3));
    }
}

public class Bodya
{
    public static void Main()
    {
        var april = new Month(12658,11399,291);
        var may = new Month(15892,13629,341);
        var june = new Month(18788,15787,386);
        var arr = new Month[] { april, may, june };
        foreach(var item in arr)
        {
            Console.WriteLine(item.Payment);
        }
    }
}
