using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using Windows.UI.Xaml.Controls;

namespace Al_Mathurat_UWP__renewed_.Views
{
    public sealed partial class HomePage : Page, INotifyPropertyChanged
    {

        public HomePage()
        {
            InitializeComponent();


            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private async void feedback_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var success = await Windows.System.Launcher.LaunchUriAsync(new Uri("mailto:itzbluebxrry@outlook.com?subject=Al-Mathurat%20UWP%20Feedback"));
        }

        private void set_name_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            greettextblock.Text = "Hi, " + change.Text + "!";
        }
    }
}
