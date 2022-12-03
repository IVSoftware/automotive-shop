using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace automotive_shop
{
    static class Price
    {
        public const decimal OilChange = 29.99m;
        public const decimal LubeJob = 18.99m;
        public const decimal TaxRate = 0.073m;
    }
    class AutoShopModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            switch (propertyName)
            {
                case nameof(Parts):
                    recalcTax();
                    break;
                case nameof(StandardServiceCharges):
                case nameof(Tax):
                case nameof(Labor):
                    recalcTotalFees();
                    break;
                default:
                    recalcStandardServiceCharges();
                    break;
            }
        }
        private void recalcTax() => Tax = Parts * Price.TaxRate;

        private void recalcTotalFees() =>
            TotalFees =
                StandardServiceCharges +
                Parts +
                Labor +
                Tax;
                
        private void recalcStandardServiceCharges()
        {
            decimal tmp = 0;
            if (OilChange) tmp += Price.OilChange;
            if (LubeJob) tmp += Price.LubeJob;
            StandardServiceCharges = tmp;
        }

        bool _oilChange = false;
        public bool OilChange
        {
            get => _oilChange;
            set
            {
                if (!Equals(_oilChange, value))
                {
                    _oilChange = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _lubeJob = false;
        public bool LubeJob
        {
            get => _lubeJob;
            set
            {
                if (!Equals(_lubeJob, value))
                {
                    _lubeJob = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal _parts = 0;
        public decimal Parts
        {
            get => _parts;
            set
            {
                if (!Equals(_parts, value))
                {
                    _parts = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal _labor = 0;
        public decimal Labor
        {
            get => _labor;
            set
            {
                if (!Equals(_labor, value))
                {
                    _labor = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal _standardServiceCharges = 0;
        public decimal StandardServiceCharges
        {
            get => _standardServiceCharges;
            set
            {
                if (!Equals(_standardServiceCharges, value))
                {
                    _standardServiceCharges = value;
                    OnPropertyChanged();
                }
            }
        }

        internal void Clear()
        {
            OilChange = LubeJob = false;
            Parts = Labor = 0m;
        }

        decimal _tax = 0;
        public decimal Tax
        {
            get => _tax;
            set
            {
                if (!Equals(_tax, value))
                {
                    _tax = value;
                    OnPropertyChanged();
                }
            }
        }
        decimal _totalFees = 0;
        public decimal TotalFees
        {
            get => _totalFees;
            set
            {
                if (!Equals(_totalFees, value))
                {
                    _totalFees = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
