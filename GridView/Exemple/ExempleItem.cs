using Xamarin.Forms;

namespace GridView
{
    public class ExempleItem : GridViewItem
    {
        public string name { get; set; }
        
        public string topic { get; set; }
    
        public ExempleItem(string name, string topic)
        {
            this.name = name;
            this.topic = topic;
            
            this.SetView(new ExempleItemView(this).View);
        }
            
    }
}