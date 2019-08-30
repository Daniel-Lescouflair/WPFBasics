using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFBasics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The Description is: {this.DescriptionText.Text}");
        }

        //This function sets everything to unchecked after hitting the reset button on the form.
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckBox.IsChecked = this.AssemblyCheckBox.IsChecked = this.PlasmaCheckBox.IsChecked = this.LaserCheckBox.IsChecked = this.PurchaseCheckBox.IsChecked =
                this.LatheCheckBox.IsChecked = this.DrillCheckBox.IsChecked = this.FoldCheckBox.IsChecked = this.RollCheckBox.IsChecked = this.SawCheckBox.IsChecked = false;
        }

        //Gathering information from what's checked and putting in the Length textbox for Laughs.
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            //When you are adding something from the sender to work within the form, you must have the type of value you ar sending.
            this.LengthTextBox.Text += ((CheckBox)sender).Content;
        }

        //Gathering the data from the finish Drop down and sending it to a Note text field when information was selected.
        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Because the function fires off expecting a value, we put this if statement here to expect a null so that it doesn't create a runtime error.
            if (this.NoteText == null)
            {
                return;
            }
                    
            
            var combo = (ComboBox)sender;                   //Setting the combo to the ComboBox Sender for cleaner code.
            var value = (ComboBoxItem)combo.SelectedValue;  //Setting the comboBoxItem combo selected value to a cleaner code. 
            this.NoteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropDown, null);
        }

        private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SupplierNameText.Text;
        }

        
    }
}
