using RA.Kernel.Attributes;
using RA.WindowsClient.Properties;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Controls;

namespace RA.WindowsClient.Helpers
{
    public class ComboBoxHelper
    {
        public const string ENUMRESULT_NAME = "Name";
        public const string ENUMRESULT_ID = "Id";

        public static void BindEnum<T>(ComboBox comboBox)
        {
            IList<ComboBoxModel> items = new List<ComboBoxModel>();

            foreach (var item in Enum.GetValues(typeof(T)))
            {
                var attr = typeof(T).GetMember(item.ToString())[0].GetCustomAttribute<ResourceAttribute>();
                
                items.Add(new ComboBoxModel { Name = Resource.ResourceManager.GetString(attr.ResourceName), Id = (int)item });
            }

            comboBox.ItemsSource = items;

            comboBox.DisplayMemberPath = ENUMRESULT_NAME;
            comboBox.SelectedValuePath = ENUMRESULT_ID;
        }
    }


    public class ComboBoxModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
