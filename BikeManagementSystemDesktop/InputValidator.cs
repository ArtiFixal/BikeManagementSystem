﻿namespace BikeManagementSystemDesktop
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

        /// <summary>
        /// Checks if first date is before last date.
        /// </summary>
        /// 
        /// <param name="first">From when we start</param>
        /// <param name="last">When we end</param>
        /// 
        /// <returns>Validation status</returns>
        public static bool ValidateDateChronology(DateTimePicker first,DateTimePicker last)
        {
            if(first.Value > last.Value)
            {
                first.CalendarTitleBackColor = Color.Red;
                return false;
            }
            else
            {
                first.CalendarTitleBackColor = SystemColors.Window;
                return true;
            }
        }

        public static bool ValidateNumber(NumericUpDown number,decimal rangeFrom,decimal rangeTo)
        {
            decimal value=number.Value;
            if(value>rangeTo || value<rangeFrom)
            {
                ChangeColorToError(number);
                return false;
            }
            else
            {
                RestoreDefaultColor(number);
                return true;
            }
        }
    }
}
