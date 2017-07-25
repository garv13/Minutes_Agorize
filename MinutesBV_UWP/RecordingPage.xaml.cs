using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MinutesBV_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RecordingPage : Page
    {
        public RecordingPage()
        {
            this.InitializeComponent();
        }

        private async void RecordingIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            ContentDialog locationPromptDialog = new ContentDialog
            {
                Title = "Are You Sure?",
                Content = "Do you want to end the recording",
                CloseButtonText = "Yes",
                PrimaryButtonText = "No"
            };

            ContentDialogResult result = await locationPromptDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                // sont stop the recording and countinue 
            }
            else
            {
                Frame.Navigate(typeof(EnterSpeakerPage));
            }
        }
    }
}
