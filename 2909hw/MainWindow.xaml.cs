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

namespace _2909hw
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string getImageName(Image obj)
        {
            string source = obj.Source.ToString();
            int startPoint = source.LastIndexOf('/');
            StringBuilder res = new StringBuilder();
            for(int i=startPoint+1; i < source.Length; i++)
            {
                res.Append(source[i]);
            }
            return res.ToString();
        }
        public MainWindow()
        {
            InitializeComponent();
            Tab1.Header = getImageName((Image)Tab1.Content);
            Tab2.Header = getImageName((Image)Tab2.Content);
            Tab3.Header = getImageName((Image)Tab3.Content);
        }
    }
}
