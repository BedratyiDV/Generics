using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CurrencyRate<T>
    {
        public string Currency { get; set; }
        public T Buy { get; set; }
        public T Sell { get; set; }

        private List<CurrencyRate<T>> _changeHistory;

        public CurrencyRate(string currency, T buy, T sell)
        {
            Currency = currency;
            Buy = buy;
            Sell = sell;
            _changeHistory = new List<CurrencyRate<T>>();
            _changeHistory.Add(this);

        }
        
         public void ChangeRate(T newBuy, T newSell) 
        
        {
            Buy = newBuy;
            Sell = newSell;
            Console.WriteLine($"New {Currency} course values: Buy: {Buy} Sell: {Sell}");
            _changeHistory.Add(this);
        }
        public void PrintHistory()
        {
            Console.WriteLine("Currency rate change history:");

            foreach (CurrencyRate<T>  currency in _changeHistory)

            { 
                Console.WriteLine($"Currency: {currency.Currency}  Buy: {currency.Buy} Sell: {currency.Sell}"); 
            }
             

        }
    }
}
