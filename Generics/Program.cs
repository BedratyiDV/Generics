namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyRate<float> currency1 = new CurrencyRate<float>("USD", (float)30.8,(float)32.5);

            Console.WriteLine($"{currency1.Currency}: Buy: {currency1.Buy} Sell: {currency1.Sell}");

            currency1.PrintHistory();

            CurrencyRate<float> currency2 = new CurrencyRate<float>("GBP", (float)35.1, (float)39.7);

            Console.WriteLine($"{currency2.Currency}: Buy: {currency2.Buy} Sell: {currency2.Sell}");

            //currency1.ChangeRate(currency2.Buy, currency2.Sell);
            currency1.ChangeRate((float)40.55, (float)44.66);

            Console.WriteLine($"{currency1.Currency}: Buy: {currency1.Buy} Sell: {currency1.Sell}");

            currency1.PrintHistory();
        }
    }
}