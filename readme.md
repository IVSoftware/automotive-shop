You mention "the _logic_ of the selected services..." and this phrase is really insightful. Consider that you can deal with that _logic_ separately from the _view_ (i.e. `Form`) that allows interaction with that logic. It's clear enough that when any property changes it cause effects in certain other properties. One option is to put your "business logic" in non-UI class that models the behavior that you want, and make the properties smart enough to send notification events when they change. For example, if the dollar amount for `Parts` is changed, it triggers a recalculation of `Tax` and new value for `Tax` it triggers a recalculation of the total fees.

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

    As you can see, the model is smart enough to adjust itself so that all of the values are in a consistent state no matter what property gets changed. Synchronizing the changes to the UI is a simple matter of binding controls like `CheckBox` and `TextBox` to properties in the model that have been set up to be *bindable*. For example, the `OilChange` property is just a bool:

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
        }
        AutoShopModel AutoShopModel { get; } = new AutoShopModel();
    }

    As a bonus, when you go to make the Android or iOS version of your app, the `AutoShopModel` is portable and reusable because it doesn't reference any platform-specific UI elements. If you're inclined to play around with this View-Model idea, I put together a short demo.

    ![Screenshot](https://github.com/IVSoftware/automotive-shop/blob/master/automotive-shop/Screenshots/screenshot.png)