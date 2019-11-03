using FreshMvvm;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFShimmerLayoutSample.Models;

namespace XFShimmerLayoutSample
{
    public class ShimmerListViewPageModel : FreshBasePageModel

    {


        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set
            {
                _isBusy = value;
                RaisePropertyChanged("IsBusy");
            }
        }


        private ObservableCollection<string> _things;
        public ObservableCollection<string> Things
        {
            get { return _things; }
            set
            {
                _things = value;
                RaisePropertyChanged("Things");
            }
        }

        private Command _startAnimationCommand;
        public Command StartAnimationCommand
        {
            get { return _startAnimationCommand; }
            set
            {
                _startAnimationCommand = value;
                RaisePropertyChanged("StartAnimationCommand");
            }
        }

        public ShimmerListViewPageModel() => StartAnimationCommand = new Command(async () =>
                                               {
                                                   await GetData();
                                               });

        protected async override void ViewIsAppearing(object sender, EventArgs e)
        {
            base.ViewIsAppearing(sender, e);
            await GetData();
        }
        public async Task GetData()
        {
            IsBusy = true;

            Things = new ObservableCollection<string>
                                                   {
                    "", "", ""
                   
                                                   };

            await Task.Delay(5000);
            Things = new ObservableCollection<string>
                                                   {
                    "jjj",
                    "jjj",
                    "jjj",
                    "jjj",
                    "jjj"
                                                   };

            //Load real data here. 
            IsBusy = false;
        }
    }
}
