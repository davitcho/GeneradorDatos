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
using ManejoDatos;

namespace GeneradorsetDatos
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

        private void BntGen_Click(object sender, RoutedEventArgs e)
        {
            if (CmbTipo.SelectedItem != null)
            {
                ComboBoxItem ComboItem = (ComboBoxItem)CmbTipo.SelectedItem;
                string name = ComboItem.Name;
                switch (name)
                {
                    case "Bol":
                        AppendText(GeneradorTipoDato.GenerarBoolString());
                        break;
                    case "Num":
                        AppendText(GeneradorTipoDato.GenerarStringNumero());
                        break;
                    case "Let":
                        AppendText(GeneradorTipoDato.GenerarSting(50));
                        break;
                    case "Alf": //Hola Willy!
                        AppendText(GeneradorTipoDato.GenerarAlfanumerico());
                        break;
                    case "DISO":
                        AppendText(Utilidades.DateToString(GeneradorFechas.GenerarFechaNacimiento()));
                        break;

                }


            }

        }
        private void ClearText()
        {
            TxtResultado.Text = "";
        }
        private void AppendText(string _texto)
        {
            if (TxtResultado.Text.Length > 0)
            {
                TxtResultado.Text += Environment.NewLine + _texto;
                TxtResultado.ScrollToEnd();
            }
            else
            {
                TxtResultado.Text = _texto;
            }
        }


        private void BntLimpiar_Click(object sender, RoutedEventArgs e)
        {
            ClearText();
        }
    }
}
