using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;

namespace DiskLayout.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        /// 
        private RelayCommand getDiskInfoCommand;
        public RelayCommand GetDiskInfoCommand
        {
            get
            {
                if(getDiskInfoCommand == null)
                {
                    getDiskInfoCommand = new RelayCommand(ShowMessage);
                }

                return getDiskInfoCommand;
            }

            set
            {
                getDiskInfoCommand = value;
            }
        }

        public MainViewModel mainViewModel;
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
            ///

        }

        private void ShowMessage()
        {
            MessageBox.Show("HelloWorld");
        }

      
    }
}