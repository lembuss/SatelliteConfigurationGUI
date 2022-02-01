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

namespace SatelliteConfigGUI
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

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }


        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            massPayload.Text = String.Empty;
            results.Text = String.Empty;
            targetOrbit.Text = String.Empty;
        }

        private void SubmitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(massPayload.Text) || String.IsNullOrEmpty(targetOrbit.Text))
            {
                MessageBox.Show("Fields cannot be empty");
            }
            else
            {
                double payLoad = Convert.ToDouble(massPayload.Text);
                string orbit = targetOrbit.Text;

                if (payLoad <= 0)
                {
                    MessageBox.Show("Mass Payload Needs to be greater than 0");
                    massPayload.Focus();
                }
                else
                {
                    var satelliteSize = new SatelliteSize(payLoad);

                    var satelliteConfiguration = new SatelliteConfiguration(satelliteSize.WeightGroup, orbit);

                    string resultConfig = ($"Your Satellite is a {satelliteSize.WeightGroup} satellite that will use the {orbit} orbit. The suggested configuration is {satelliteConfiguration.Configuration}");
                    results.Text = resultConfig;


                }

            }




        }
    }
}
