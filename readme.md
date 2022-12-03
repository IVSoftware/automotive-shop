You mention "the _logic_ of the selected services..." and this phrase is insightful! Consider that one approach is to separate that logic from the _view_ (i.e. the `Form` that allows interaction with that logic) because it's clear enough that when any property changes it causes ripple effects in certain other properties and the behavior is well-defined. If this "business logic" is placed in a non-UI class that models the desired behavior, the properties can be made smart enough to send notification events whenever they change.  

For example, if the dollar amount for `Parts` is changed, it triggers a recalculation of `Tax` and the new value for `Tax` it triggers a recalculation of the `TotelFees` property in turn.

    class AutoShopModel : INotifyPropertyChanged
    {
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
        public event PropertyChangedEventHandler PropertyChanged;        

        private void recalcTotalFees() =>
            TotalFees =
                StandardServiceCharges +
                Parts +
                Labor +
                Tax;
        .
        .
        .
    }

This demonstrates that the model is smart enough to maintain the relative values in a consistent internal state regardless of which property changes. Then, synchronizing the changes to the UI is a simple matter of binding controls like `CheckBox` and `TextBox` to properties in the model that have been set up to be *bindable*. 

For example, the `OilChange` property is just a bool and making it bindable simply means firing an event when its value changes:

    partial class AutoShopModel
    {
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
        bool _oilChange = false;
        .
        .
        .
    }

Finally, the glue that holds it all together takes place in the Load method of the `MainForm` where the `checkBoxOilChange` gets bound to changes of the `AutoShopModel.OilChange` boolean:

    
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Binding binding;
            binding = new Binding(nameof(CheckBox.Checked), AutoShopModel, nameof(AutoShopModel.OilChange), false, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxOilChange.DataBindings.Add(binding);
            .
            .
            .
        }
        AutoShopModel AutoShopModel { get; } = new AutoShopModel();
    }

As a bonus, when you go to make the Android or iOS version of your app, the `AutoShopModel` is portable and reusable because it doesn't reference any platform-specific UI elements. If you're inclined to play around with this View-Model idea, I put together a short demo.

![Screenshot](https://github.com/IVSoftware/automotive-shop/blob/master/automotive-shop/Screenshots/screenshot.png)