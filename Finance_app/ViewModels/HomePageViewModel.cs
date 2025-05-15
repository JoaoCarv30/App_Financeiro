using System.Collections.ObjectModel;

namespace Finance_app.ViewModels;

public class HomePageViewModel
{
    public ObservableCollection<string> Images { get; set; }
    
    public HomePageViewModel()
    {
        Images = new ObservableCollection<string>
        {
            "cart1.png",
            "cart2.png",
            
        };
    }
}
