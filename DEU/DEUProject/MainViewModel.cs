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

        bool _Ref = false;
        public bool Ref
        {
            get
            {
                return _Ref;
            }
            set
            {
                _Ref = value;
                OnProperty(nameof(Ref));
            }
        }

        public Command Updates 
        {
            get {
                return new Command(async () => await Task.Run(() => Update() ));
            }
        }
    
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnProperty(string name){
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public void Update()
        {
            Ref = true;
            var dap = new DapSite().GetSite();
            var prime = new PrimeSite().GetSite();

            ModelDap.Clear();
            foreach (var item in dap)
                ModelDap.Add(item);

            ModelPrime.Clear();
            foreach (var item in prime)
                ModelPrime.Add(item);
            Ref = false;
        }


        public MainViewModel(){
            ModelDap = new ObservableCollection<MainModel>();
            ModelPrime = new ObservableCollection<MainModel>();
            new LincplusSite().GetSite();
            Updates.Execute(null);

        }


    }
}
