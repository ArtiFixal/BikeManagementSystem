namespace BikeManagementSystemDesktop
{
    public class InputValidator
    {
        public static void ChangeColorToError(Control element)
        {
            element.BackColor = Color.Red;
        }

        public static void RestoreDefaultColor(Control element)
        {
            element.BackColor = SystemColors.Window;
        }

        public static bool ValidateTextBox(TextBox textBox)
        {
            if(string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                ChangeColorToError(textBox);
                return false;
            }
            else
            {
                textBox.BorderStyle = BorderStyle.Fixed3D;
                RestoreDefaultColor(textBox);
                return true;
            }
        }

        public static bool ValidateComboBox(ComboBox comboBox)
        {
            if(comboBox.SelectedItem==null)
            {
                ChangeColorToError(comboBox);
                return false;
            }
            else
            {
                RestoreDefaultColor(comboBox);
                return true;
            }
        }
    }
}
