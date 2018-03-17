using Xamarin.Forms;
using XamarinQCM.ViewModels;

using XamarinQCM.ViewModels;

namespace XamarinQCM.Views
{
    public partial class QuickView : ContentPage
    {
        public QuickView()
        {
            InitializeComponent();
            BindingContext = QuickVM.GetQuick();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            
            var txt = compteur.Text;
            int cpt = int.Parse(txt);
            cpt++;
            compteur.Text = cpt.ToString();


        }
    }
}
