using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AzureDemo.Core
{
    public class ListViewModel : MvxViewModel
    {
        public ListViewModel()
        {
            this.AddItemCommand = new MvxCommand(() => this.AddItem());
        }

        public ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>
        {
            "item 1",
            "Item 2",
            "Item 3",
            "Item 4"
        };

        public ICommand AddItemCommand { get; private set; }

        private void AddItem()
        {
            
        }
    }
}
