using MediaManager;
using MediaManager.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VideoPlay
{
    public partial class MainPage : ContentPage
    {
        public IList<string> Mp3UrlList => new[]{
                "https://ia800806.us.archive.org/15/items/Mp3Playlist_555/AaronNeville-CrazyLove.mp3",
                "https://ia800605.us.archive.org/32/items/Mp3Playlist_555/CelineDion-IfICould.mp3",
                "https://ia800605.us.archive.org/32/items/Mp3Playlist_555/Daughtry-Homeacoustic.mp3",
                "https://storage.googleapis.com/uamp/The_Kyoto_Connection_-_Wake_Up/01_-_Intro_-_The_Way_Of_Waking_Up_feat_Alan_Watts.mp3",
                "https://aphid.fireside.fm/d/1437767933/02d84890-e58d-43eb-ab4c-26bcc8524289/d9b38b7f-5ede-4ca7-a5d6-a18d5605aba1.mp3"
        };
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayStopButton(object sender, EventArgs e)
        {
            if (PlayStopButtonText.Text == "Play")
            {
                CrossMediaManager.Current.Play(Mp3UrlList);
                PlayStopButtonText.Text = "Stop";
            }
            else if (PlayStopButtonText.Text == "Stop")
            {
                CrossMediaManager.Current.Stop();

                PlayStopButtonText.Text = "Play";
            }
        }

        private async void PrevButton_Clicked(object sender, EventArgs e)
        {
            await CrossMediaManager.Current.PlayPrevious();
        }
        private async void NextButtonText_Clicked(object sender, EventArgs e)
        {

            await CrossMediaManager.Current.PlayNext();
        }
    }
}
