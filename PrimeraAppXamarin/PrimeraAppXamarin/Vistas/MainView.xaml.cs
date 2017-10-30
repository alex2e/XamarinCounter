using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeraAppXamarin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainView : ContentPage
    {
        int counter = 0;
        public MainView()
        {
            InitializeComponent();
            BtnCounter.Clicked += (sender, args) =>
            {
                lblCounter.Text = String.Format("Botón pulsado {0} veces", counter++);
            };
        }
    }
}