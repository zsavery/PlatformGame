namespace Platform
{
    public partial class MainPage : ContentPage
    {
        public int level = 1;
        public int score = 0;
        public Label scoreLabel;
        public Label levelLabel;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Start_Button_Clicked(object sender, EventArgs e)
        {
            Fill_Grid();

            Start_Button.IsEnabled = false;
        }

        private void Reset_Button_Clicked(object sender, EventArgs e)
        {

        }

        async public void Fill_Grid()
        {
            int rows = 5;
            int columns = 5;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    StackLayout unit = new StackLayout() { ZIndex = 0 };
                    unit.BackgroundColor = Colors.LightSkyBlue;
                    gameGrid.Add(unit, j, i);

                    await Task.Delay(100);
                }
            }

            //Lab code here: 

            scoreLabel = new Label()
            {
                //solution
            };

            levelLabel = new Label()
            {
                //solution
            };

            //delay
            //add score label
            //delay
            //add level label
        }

    }
}