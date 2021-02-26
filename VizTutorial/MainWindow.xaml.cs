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
using VizConnectC;

namespace VizTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VizEnginePool myVizEngine = new VizEnginePool();

        public MainWindow()
        {
            InitializeComponent();
            ConnectToViz();
        }

        public void ConnectToViz()
        {
            myVizEngine.Disconnect();
            myVizEngine.CleanRendererList();
            myVizEngine.AddRenderer("localhost", 6100);
            myVizEngine.Connect();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myVizEngine.Send("SCENE*/AT/Development/Tutorial*TREE*$G_ALL$group*GEOM*TEXT SET " + VIZ_TXT.Text);
        }
    }
}
