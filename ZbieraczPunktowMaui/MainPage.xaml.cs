namespace ZbieraczPunktowMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        Player player;
        public MainPage()
        {
            InitializeComponent();
            player = new Player();
            mainLayout.Children.Add(player.image);
        }
        
    }

}
