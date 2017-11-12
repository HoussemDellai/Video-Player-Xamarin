using System;
using Plugin.MediaManager;
using Plugin.MediaManager.Abstractions.Enums;
using Xamarin.Forms;

namespace VideoPlayerApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        
        private async void PlayStop_Clicked(object sender, EventArgs e)
        {
            if (PlayPauseButton.Text == "Play")
            {
                await CrossMediaManager.Current.Play(VideoEntry.Text, MediaFileType.Video);

                PlayPauseButton.Text = "Stop";
            }

            else if (PlayPauseButton.Text == "Stop")
            {
                await CrossMediaManager.Current.Stop();

                PlayPauseButton.Text = "Play";
            }
        }
    }
}
