using Microsoft.Toolkit.Uwp.UI.Controls;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.ApplicationModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TabViewApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
        public class Customer
        {
            public String FirstName { get; set; }
            public String LastName { get; set; }
            public String Address { get; set; }
            public Boolean IsNew { get; set; }

            public Customer(String firstName, String lastName,
                String address, Boolean isNew)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Address = address;
                this.IsNew = isNew;
            }

           
        
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = this;
            lists = new List<Customer>(new Customer[4] {
            new Customer("A.", "Zero",
                "12 North Third Street, Apartment 45",
                false),
            new Customer("B.", "One",
                "34 West Fifth Street, Apartment 67",
                false),
            new Customer("C.", "Two",
                "56 East Seventh Street, Apartment 89",
                true),
            new Customer("D.", "Three",
                "78 South Ninth Street, Apartment 10",
                true)
        });
        }
    
        private List<Customer> lists { get; set; }
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            StringReader reader = new StringReader(
   @"<DataTemplate xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation"">
            <Button Content=""Hello""/>
            </DataTemplate>");
            var template = XamlReader.Load(await reader.ReadToEndAsync());
            DataGridTemplateColumn col1 = new DataGridTemplateColumn();
            col1.CellTemplate = template as DataTemplate;
            //col1.CellTemplate = this.Resources["MyButtonTemplate"] as DataTemplate;
            col1.Header = "MyHeader";
            dataGrid1.Columns.Add(col1);

        }

        
    }
}
