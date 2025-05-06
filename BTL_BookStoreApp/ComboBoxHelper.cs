using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;

namespace BTL_BookStoreApp
{
    internal class ComboBoxHelper
    {
        public void LoadToComboBox<T>(
            ComboBox comboBox,
            List<T> source,
            Func<T, string> getId,
            Func<T, string> getName,
            string specialItemName = "Khác...")
        {
            var items = source
                .Select(item => new SpecialItem
                {
                    Id = getId(item),
                    Name = getName(item)
                })
                .ToList();

            items.Add(new SpecialItem
            {
                Id = "-1",
                Name = specialItemName
            });

            comboBox.DataSource = null;
            comboBox.DataSource = items;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";
        }

    }
}

