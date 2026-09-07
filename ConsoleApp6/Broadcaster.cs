using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    //public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    internal class Broadcaster  //publisher
    {
        string sympol;
        decimal price;

        public Broadcaster(string sympol) => this.sympol = sympol;
        
        public event EventHandler<PriceChangedEventArgs> PriceChanged;
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }
    }
    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;
        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
}
