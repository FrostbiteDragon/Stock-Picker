using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine(StockPicker.PickStocks(new int[] { 17, 3, 6, 9, 15, 8, 6, 1, 10 }));

public static class StockPicker
{
    public static (int, int) PickStocks(int[] stocks)
    {
        return stocks
        .SelectMany((_, day1) => stocks.Select((_, j) => (day1, day2: day1 + j))) //tupple all possible day combonations
        .Where(x => x.day2 < stocks.Length) // remove invalid days
        .OrderByDescending(x => stocks[x.Item2] - stocks[x.day1]) // order by greatest profit to lowest profit
        .First(); //take first element
    }
}
