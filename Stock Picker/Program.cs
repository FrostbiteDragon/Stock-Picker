using System;
using System.Linq;

Console.WriteLine(StockPicker.PickStocks(new int[] { 17, 3, 6, 9, 15, 8, 6, 1, 10 }));

public static class StockPicker
{
    public static (int, int) PickStocks(int[] stocks)
    {
        return stocks
        .SelectMany((_, i) => stocks.Select((_, j) => (day1: i, day2: i + j))) //tupple all possible day combination
        .Where(x => x.day2 < stocks.Length) // remove invalid days
        .OrderByDescending(x => stocks[x.day2] - stocks[x.day1]) // order by greatest profit to lowest profit
        .First(); //take first element
    }
}
