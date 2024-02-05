using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            /* Usage Exemple */
            
            GridView gridView = new GridView(maxRow:2);

            ExempleItem exI1 = new ExempleItem("Titre 1", "Topic 1");
            ExempleItem exI2 = new ExempleItem("Titre 2", "Topic 2");
            ExempleItem exI3 = new ExempleItem("Titre 3", "Topic 3");
            ExempleItem exI4 = new ExempleItem("Titre 4", "Topic 4");
            ExempleItem exI5 = new ExempleItem("Titre 5", "Topic 5");

            gridView.ListItems = new List<GridViewItem>()
            {
                exI1, exI2, exI3, exI4, exI5
            };
            
            Container.Children.Add(gridView);
            
            /* ------------- */
                
        }
    }
}