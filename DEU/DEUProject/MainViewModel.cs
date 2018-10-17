using System;
using System.Collections.ObjectModel;
using DEUProject.Server;

namespace DEUProject
{
    public class MainModel
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Link { get; set; }
    }


    public class MainViewModel
    {
        public ObservableCollection<MainModel> ModelDap { get; private set; }
        public ObservableCollection<MainModel> ModelPrime { get; private set; }

        public  MainViewModel(){
            ModelDap = new ObservableCollection<MainModel>();
            ModelPrime = new ObservableCollection<MainModel>();

            DapSite d = new DapSite();
            PrimeSite p = new PrimeSite();


            foreach (var item in d.GetSite()){
                ModelDap.Add(item);
            }
            foreach (var item in p.GetSite())
            {
                ModelPrime.Add(item);
            }


        }


    }
}
