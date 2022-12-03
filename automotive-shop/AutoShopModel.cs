using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace automotive_shop
{
    class AutoShopModel : INotifyPropertyChanged
    {
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
        bool _radiatorFlush = false;
        public bool RadiatorFlush
        {
            get => _radiatorFlush;
            set
            {
                if (!Equals(_radiatorFlush, value))
                {
                    _radiatorFlush = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _transmissionFlush = false;
        public bool TransmissionFlush
        {
            get => _transmissionFlush;
            set
            {
                if (!Equals(_transmissionFlush, value))
                {
                    _transmissionFlush = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _inspection = false;
        public bool Inspection
        {
            get => _inspection;
            set
            {
                if (!Equals(_inspection, value))
                {
                    _inspection = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _replaceMuffler = false;
        public bool ReplaceMuffler
        {
            get => _replaceMuffler;
            set
            {
                if (!Equals(_replaceMuffler, value))
                {
                    _replaceMuffler = value;
                    OnPropertyChanged();
                }
            }
        }
        bool _tireRotation = false;
        public bool TireRotation
        {
            get => _tireRotation;
            set
            {
                if (!Equals(_tireRotation, value))
                {
                    _tireRotation = value;
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


        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            recalc();
        }

        private readonly PropertyInfo[] _properties = typeof(AutoShopModel).GetProperties();
        private void recalc()
        {
            foreach (var propertyInfo in _properties)
            {
                var name = propertyInfo.Name;
                switch (propertyInfo.Name)
                {
                    default:
                        Debug.Assert(false, $"The '{name}' property has not been handled.");
                        break;
                }
            }
        }
    }
}
