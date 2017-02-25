using System;

namespace TipCalc.ViewModels
{
    public class TipCalcViewModel : BaseViewModel
    {
        public TipCalcViewModel()
        {
            tipPercent = 15;
        }

        decimal subTotal;
        public decimal Subtotal
        {
            get { return subTotal; }
            set
            {
                if (subTotal != value)
                {
                    subTotal = value;
                    OnPropertyChanged("TipValue");
                    OnPropertyChanged("Total");
                }
            }
        }

        decimal recepitTotal;
        public decimal RecepitTotal
        {
            get { return recepitTotal; }
            set
            {
                if (recepitTotal != value)
                {
                    recepitTotal = value;
                    OnPropertyChanged("TipValue");
                    OnPropertyChanged("Total");
                }
            }
        }

        decimal tipPercent;
        public decimal TipPercent
        {
            get { return tipPercent; }
            set
            {
                if (value != tipPercent)
                {
                    tipPercent = value;
                    OnPropertyChanged("TipPercent");
                    OnPropertyChanged("TipValue");
                    OnPropertyChanged("Total");
                }
            }
        }
        
        public decimal TipValue
        {
            get
            {
                if (RecepitTotal == 0m || Subtotal == 0m || TipPercent == 0m)
                    return 0m;

                var percent = TipPercent;
                percent /= 100;
                decimal value = (Subtotal * (1 + percent)) + (RecepitTotal - Subtotal);
                decimal fract = value - Math.Truncate(value);
                int f = (int)(fract * 100);
                while ((f % 25) != 0)
                    ++f;
                fract = f;
                fract /= 100;
                value = Math.Truncate(value) + fract;

                return value - RecepitTotal;
            }
        }

        public decimal Total
        {
            get { return TipValue + RecepitTotal; }
        }
    }
}
