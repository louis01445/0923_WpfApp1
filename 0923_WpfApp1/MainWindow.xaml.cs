using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _0923_WpfApp1
{
    public partial class MainWindow : Window
    {
        Dictionary<string int> drinls = new Dictionary<string, int>()
                {
            {"紅茶大杯", 45},
            {"紅茶小杯", 45},
            {"綠茶大杯", 45},
            {"綠茶小杯", 45},
            {"可樂大杯", 45},
            {"可樂小杯", 45}
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        Dictionary<string, int> order = new Dictionary<string, int>()
        {

        };
        private void orderButton_Click(object sender, RoutedEventArgs e)
        {
            order.Clear();
            resultMessage = "";
            for (int i = 0 i < DrinkMenuStackPanel.Children.Count; i++)
            {
                var sp = Drink MenuStackPanel.Children[i] as StackPanel;
                var cb sp.Children[0] as CheckBox;
                var sl = sp.Children[2] as Slider;
                int quantity = (int)sl.Value;
                if (cb.IsChecked == true && quantity > 0)
                {
                    string drinkName = cb.Content.ToString();
                int price = (int)sl.Value;
                }
            }
    }
}