using System;
using System.Collections.ObjectModel;
using DEUProject.Server;
using Xamarin.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DEUProject
{
    public class MainModel
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainModel> ModelDap { get; private set; }
        public ObservableCollection<MainModel> ModelPrime { get; private set; }
        public ObservableCollection<MainModel> ModelLinc { get; private set; }


        public Command Prev => new Command(() =>
        {
            Page -= 1;
            Update(bNotice, Page);
        });

        public Command Next => new Command(() =>
        {
            Page += 1;
            Update(bNotice, Page);
        });

        bool bNotice = false;
        int _Page = 1;
        int Page
        {
            set
            {
                if (1 <= value)
                {
                    _Page = value;
                }
                else
                {
                    _Page = 1;
                }
            }
            get => _Page;
        }

        bool _Ref = false;
        public bool Ref
        {
            get => _Ref;
            set
            {
                _Ref = value;
                OnProperty(nameof(Ref));
            }
        }

        public Command Updates => new Command(async () => await Task.Run(() => Update() ));

    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProperty(string name){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Update(bool bNotice = false, int Page = 1)
        {
            Ref = true;
            var dap = new DapSite().GetSite(bNotice, Page);
            var prime = new PrimeSite().GetSite(bNotice, Page);
            var linc = new LincplusSite().GetSite(bNotice, Page);

            ModelDap.Clear();
            foreach (var item in dap)
                ModelDap.Add(item);

            ModelPrime.Clear();
            foreach (var item in prime)
                ModelPrime.Add(item);

            ModelLinc.Clear();
            foreach (var item in linc)
                ModelLinc.Add(item);

            Ref = false;
        }


        public MainViewModel(){
            ModelDap = new ObservableCollection<MainModel>();
            ModelPrime = new ObservableCollection<MainModel>();
            ModelLinc = new ObservableCollection<MainModel>();
            Updates.Execute(null);

        }


    }
}
