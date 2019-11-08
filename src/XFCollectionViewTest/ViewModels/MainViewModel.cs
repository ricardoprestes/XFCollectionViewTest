using System.Collections.ObjectModel;
using XFCollectionViewTest.Models;

namespace XFCollectionViewTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public MainViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>();
        }
    }
}
