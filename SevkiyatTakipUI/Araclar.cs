using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SevkiyatTakipUI
{
    public class Araclar
    {
        public static void AutoComplete(ComboBox comboBox)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                collection.Add(comboBox.GetItemText(comboBox.Items[i]));
            }
            comboBox.AutoCompleteCustomSource = collection;
        }
    }
}
