using Microsoft.Maui.Platform;
using Windows.UI.Xaml;

namespace ZbieraczPunktowMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Player player;
        Player player2;
        public MainPage()
        {
            InitializeComponent();
            player = new Player();
            player.addToBoard(mainLayout, 50, 50);
            player2 = new Player();
            player2.addToBoard(mainLayout, 200, 50);
            var handler = mainLayout.Handler;
            UIElement? nativeView = handler?.PlatformView as UIElement;
            if (nativeView != null)
            {
                nativeView.KeyDown += this.PlatformView_KeyDown;
                nativeView.KeyUp += this.PlatformView_KeyUp;
                nativeView.PreviewKeyDown += this.PlatformView_PreviewKeyDown;
            }
        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {

        }
    }

}
