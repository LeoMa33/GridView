using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GridView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExempleItemView : ViewCell
    {
        public ExempleItemView(ExempleItem item)
        {
            InitializeComponent();

            Name.Text = item.name;
            Topic.Text = item.topic;
        }
    }
}