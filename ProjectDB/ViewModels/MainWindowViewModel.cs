using System;
using ReactiveUI;
using System;
using Avalonia.Interactivity;

namespace ProjectDB.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public int nodes { get; set; }
        public int connections { get; set; }


        public void OnTesting()
        {
            Console.WriteLine(nodes);
        }

    }
}
