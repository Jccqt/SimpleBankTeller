using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Teller
{
    public class InputValidation
    {
        public static void WholeNumbersOnly(object sender, KeyPressEventArgs e)
        {
            // will only allow whole numbers on textboxes
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void FloatingNumbersOnly(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // will only allow control characters (e.g., Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // will only allow digits and dot
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // will only allow one dot
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
                return;
            }

            // will prevent dot as first character
            if (textBox.Text.Length == 0 && e.KeyChar == '.')
            {
                e.Handled = true;
                return;
            }

            // will limit to 2 decimal places
            if (textBox.Text.Contains('.'))
            {
                int index = textBox.Text.IndexOf('.');
                string decimals = textBox.Text.Substring(index + 1);

                if (decimals.Length >= 2)
                {
                    if (textBox.SelectionStart > index)
                    {
                        e.Handled = true;
                    }
                }
            }
        }
    }
}
