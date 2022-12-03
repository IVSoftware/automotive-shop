using System;
using System.Windows.Forms;

namespace automotive_shop
{
    public partial class MainForm : Form
    {
        public MainForm() => InitializeComponent();
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Binding binding;
            binding = new Binding(nameof(CheckBox.Checked), AutoShopModel, nameof(AutoShopModel.OilChange), false, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxOilChange.DataBindings.Add(binding);

            binding = new Binding(nameof(CheckBox.Checked), AutoShopModel, nameof(AutoShopModel.LubeJob), false, DataSourceUpdateMode.OnPropertyChanged);
            checkBoxLubeJob.DataBindings.Add(binding);

            binding = new Binding(nameof(TextBox.Text), AutoShopModel, nameof(AutoShopModel.Parts), true, DataSourceUpdateMode.OnValidation);
            textBoxAdditionalParts.KeyDown += onAnyKeyDown;
            textBoxAdditionalParts.GotFocus += onAnyGotFocus;
            binding.Format += (sender, e) => e.Value = ((decimal)e.Value).ToString("F2");
            textBoxAdditionalParts.DataBindings.Add(binding);

            binding = new Binding(nameof(TextBox.Text), AutoShopModel, nameof(AutoShopModel.Labor), true, DataSourceUpdateMode.OnValidation);
            textBoxLabor.KeyDown += onAnyKeyDown;
            textBoxLabor.GotFocus += onAnyGotFocus;
            binding.Format += (sender, e) => e.Value = ((decimal)e.Value).ToString("F2");
            textBoxLabor.DataBindings.Add(binding);

            binding = new Binding(nameof(TextBox.Text), AutoShopModel, nameof(AutoShopModel.StandardServiceCharges), true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = ((decimal)e.Value).ToString("F2");
            textBoxStandardServiceCharge.DataBindings.Add(binding);

            binding = new Binding(nameof(TextBox.Text), AutoShopModel, nameof(AutoShopModel.Tax), true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = ((decimal)e.Value).ToString("F2");
            textBoxTax.DataBindings.Add(binding);

            binding = new Binding(nameof(TextBox.Text), AutoShopModel, nameof(AutoShopModel.TotalFees), true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (sender, e) => e.Value = ((decimal)e.Value).ToString("F2");
            textBoxTotalFees.DataBindings.Add(binding);

            // Adjust prices based on config file
            checkBoxOilChange.Text = $"Oil Change {Price.OilChange.ToString("F2")}";
            checkBoxLubeJob.Text = $"Lube Job {Price.LubeJob.ToString("F2")}";
        }

        private void onAnyKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);
            }
        }

        private void onAnyGotFocus(object sender, EventArgs e) => BeginInvoke((MethodInvoker)delegate { (sender as TextBox)?.SelectAll();});

        AutoShopModel AutoShopModel { get; } = new AutoShopModel();

        private void buttonClear_Click(object sender, EventArgs e) => AutoShopModel.Clear();
    }
}
