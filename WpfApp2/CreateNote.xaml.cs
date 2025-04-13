using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;
using WpfApp2.Models;

namespace WpfApp2
{
    /// <summary>
    /// Lógica interna para CreateNote.xaml
    /// </summary>
    /// 
   public partial class CreateNote : Window
    {
        private void MoverWindowNotas(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                this.DragMove();
        }
        public CreateNote()
        {

            InitializeComponent();
            txtNome.Text = "Teste";
            txtDescricao.Text = "Teste";

            Notes Nota = new Notes(txtNome.Text, txtDescricao.Text);

            string teste = Nota.Id.ToString();

            Debug.WriteLine(teste, Nota.Name, Nota.Description);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void txtDescricao_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
