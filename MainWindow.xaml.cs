using laba3rpm3k2s.Abstract_Factory;
using laba3rpm3k2s.Factory_Method.Factories;
using laba3rpm3k2s.Factory_Method.Factories.SquareCreators;
using laba3rpm3k2s.Factory_Method.Factories.TriangleCreators;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace laba3rpm3k2s
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        IFigureFactory figureFactory;

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ShapesList.Children.Clear();
                ShapesList.Children.Add(figureFactory.CreateCircle().CreateUIElement());
                ShapesList.Children.Add(figureFactory.CreateTriangle().CreateUIElement());
                ShapesList.Children.Add(figureFactory.CreateSquare().CreateUIElement());
            }
            catch { }
        }

        private void ColorsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Label label = (Label)ColorsList.SelectedItem;
            switch (label.Content.ToString())
            {
                case "Red":
                    figureFactory = new RedFactory(); break;
                case "Blue":
                    figureFactory = new BlueFactory(); break;
                case "Green":
                    figureFactory = new GreenFactory(); break;
                default:
                    return;
            }
        }
    }
}