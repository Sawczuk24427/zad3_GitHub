using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3_GitHub
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public decimal Value { get; set; }

        public ComboBoxItem(string text, decimal value)
        {
            Text = text;
            Value = value;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
