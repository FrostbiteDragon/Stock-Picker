using System;
using Xunit;

namespace Stock_Picker_Tests
{
    public class Tests
    {
        [Fact]
        public void StockPikerReturnsCorrectDays()
        {
            var stocks = new int[] { 17, 3, 6, 9, 15, 8, 6, 1, 10 };
            var expected = (1, 4);

            var actual = StockPicker.PickStocks(stocks);

            Assert.Equal(expected, actual);
        }
    }
}
