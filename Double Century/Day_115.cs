//MainWindow.xaml.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int randTextNumber = 0;
        DispatcherTimer timer = new DispatcherTimer();
        int txtLength = 0;
        bool testFinished = false;
        int wrongWords = 0;
        int counter = 0;


        public MainWindow()
        {
            InitializeComponent();
            List<string> list = new List<string>()

            {
                "0:55 - 1st",
                "0:45 - 2nd",
                "0:36 - 3rd"
            };

            listBox.ItemsSource = list;
            listBox.Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main.Visibility = Visibility.Collapsed;
            randomText();
            main2.Visibility = Visibility.Visible;
            listBox.Visibility = Visibility.Visible;
            CountToThree();
        }



        private async void CountToThree()
        {
            for(int i = 3; i >= 1; i--)
            {
                CountToThreeLbl.Content = "START TYPING IN " +i+ "s";
                await Task.Delay(1000);
            }
            CountToThreeLbl.Visibility = Visibility.Hidden;
            StartTimer();
            Console.WriteLine(TimerLbl.Visibility);
        }
        private async void StartTimer()
        {
            TimerLbl.Visibility = Visibility.Visible;
            for (int i = 60; i >= 1; i--)
            {
                TimerLbl.Content = "TIME LEFT: " + i + "s";
                CheckText();
                await Task.Delay(1000);
                if (testFinished) break;
            }
        }
        private void CheckText()
        {
            int seconds = int.Parse(TimerLbl.Content.ToString().Split(' ')[2].Split('s')[0]);

            if (userText.Text.Length >= txtLength || seconds <= 0)
            {
                ProduceResult();
                testFinished = true;
            }
        }
        public void ProduceResult()
        {
            int words = WordsChecker();
            int seconds = int.Parse(TimerLbl.Content.ToString().Split(' ')[2].Split('s')[0]);

            double wordsPerMinute = (double)words / seconds * 60;
            Console.WriteLine($"Words: {words} - Seconds: {seconds} - Words Per Minute: {Math.Ceiling(wordsPerMinute)}");
            showResultLbl.Content = $"WORDS WRITTEN: {words} | SECONDS: {seconds} | WPM {Math.Ceiling(wordsPerMinute)} | {counter} words right out of {(wrongWords+counter)}";
            main2.Visibility = Visibility.Hidden;
            main3.Visibility = Visibility.Visible;
            testFinished = true;
        }

        public int WordsChecker()
        {
            foreach (var x in userText.Text.Split(' '))
            {
                wrongWords++;
                foreach (var y in textToWriteLbl.Text.Split(' '))
                    counter += x == y ? 1 : 0;
            }
            wrongWords = wrongWords - counter;
            return counter;
        }
        private void randomText()
        {
            Random rand = new Random();
            randTextNumber = rand.Next(1, 5);

            switch (randTextNumber)
            {
                case 1:
                    textToWriteLbl.Text = "In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day.";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
                case 2:
                    textToWriteLbl.Text = "A gentle zephyr wafts through the blossoming orchard, carrying the sweet fragrance of blooming flowers and coaxing the leaves to perform a graceful dance";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
                case 3:
                    textToWriteLbl.Text = "Nestled in the cozy nook of the living room, a curious tabby cat with soft, furry paws playfully explores a patch of sunlight, casting a contented gaze upon a collection of well-loved toys";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
                case 4:
                    textToWriteLbl.Text = "As the grandfather clock in the hallway ticks steadily, a comforting symphony of raindrops taps on the windowpane, creating a soothing melody that serenades the quietude of the cozy reading nook";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
                case 5:
                    textToWriteLbl.Text = "Under the sprawling branches of the old oak tree, a friendly bluebird perches, melodiously trilling a joyous tune, announcing the arrival of a splendid afternoon in the idyllic meadow";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
                default:
                    textToWriteLbl.Text = "In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day.";
                    txtLength = textToWriteLbl.Text.Length;
                    break;
            }
        }
    }
}


//MainWindow.xaml

<Window x:Class="WpfApp2.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp2"
        mc:Ignorable="d"
        Title="Words Per Minute - Counter" Height="450" Width="800">
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="69*"/>
            <RowDefinition Height="365*"/>
        </Grid.RowDefinitions>
        <GroupBox Header="" Name="main" Grid.RowSpan="2" d:IsHidden="True">
            <Grid>
                <Grid.ColumnDefinitions>
                    <ColumnDefinition Width="83*"/>
                    <ColumnDefinition Width="705*"/>
                </Grid.ColumnDefinitions>
                <Label Content="- WORD PER MINUTE - COUNTER - " FontSize="30" FontWeight="Bold" FontFamily="Sitka Small" Foreground="#FF148A4C" Height="44" Width="569" Margin="5,38,130,0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center" VerticalAlignment="Top" Grid.Column="1"/>

                <TextBlock TextWrapping="Wrap" TextAlignment="Center" FontWeight="Bold" FontFamily="Trebuchet MS" FontSize="24" VerticalAlignment="Top" Margin="65,92,172,0" Grid.Column="1"><Run Text="YOU WILL BE GIVEN TEXT TO WRITE "/><LineBreak/><Run Text="WITHIN A MINUTE."/><LineBreak/><Run/><LineBreak/>CLICK <Run Text="START " Foreground="Green"  FontWeight="Bold" FontFamily="Segoe UI Light"/>TO CONTINUE</TextBlock>

                <Button Content="START" Name="startBtn" BorderBrush="White" FontSize="27" FontWeight="Bold" Foreground="White" Background="#FF499E32" FontFamily="Segoe UI Light" Height="45" Width="180" Margin="198,238,327,128" Click="Button_Click_1" Cursor="Hand" Grid.Column="1" HorizontalAlignment="Center" VerticalAlignment="Top">
                    <Button.Template>
                        <ControlTemplate TargetType="{x:Type Button}">
                            <Border Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="0,1,1,1" CornerRadius="20">
                                <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                            </Border>
                        </ControlTemplate>
                    </Button.Template>
                </Button>
            </Grid>
        </GroupBox>
        <ListBox Visibility="Visible" x:Name="listBox" Margin="625,13,34,198" Grid.Row="1" HorizontalAlignment="Right" Foreground="#FF040404" FontWeight="Bold" FontFamily="Segoe UI Semibold" FontSize="14" VerticalAlignment="Top" Width="100" Height="130">
            <ListBox.Background>
                <RadialGradientBrush>
                    <GradientStop Color="#FF9DF1A6"/>
                    <GradientStop Color="#FF4BEF58" Offset="0.87"/>
                </RadialGradientBrush>
            </ListBox.Background>
        </ListBox>

        <GroupBox Name="main2" Visibility="Hidden" Grid.RowSpan="2">
            <Grid>


                <TextBlock Name="textToWriteLbl" TextWrapping="Wrap" Text="In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day." Margin="36,118,0,0" HorizontalAlignment="Left" FontSize="24" FontFamily="PMingLiU-ExtB" FontWeight="Bold" Foreground="#FFED8B27" Width="575" VerticalAlignment="Top" TextAlignment="Center"/>
                <Label Content="WRITE" Margin="231,48,0,0" FontSize="36" FontWeight="Bold" FontFamily="Segoe UI Black" HorizontalAlignment="Left" VerticalAlignment="Top"/>
                <TextBox Name="userText" Margin="51,258,0,0" TextAlignment="Center" HorizontalAlignment="Left" VerticalAlignment="Top" TextWrapping="Wrap" FontSize="24" FontFamily="NSimSun" Foreground="Black" Width="516"/>
                <Label Name="TimerLbl" Content="TIME LEFT: " Margin="46,16,573,378" FontSize="20" FontWeight="Bold" Foreground="#FF18BBDA" RenderTransformOrigin="0.97,-0.241" HorizontalAlignment="Left" VerticalAlignment="Top"/>
                <Label x:Name="CountToThreeLbl" Content="START TYPING IN" Margin="210,215,301,173" FontSize="24" FontWeight="Bold" FontFamily="Nirmala UI Semilight" HorizontalAlignment="Left" VerticalAlignment="Top"/>

            </Grid>
        </GroupBox>

        <GroupBox Name="main3" Visibility="Hidden" Grid.RowSpan="2">
            <Grid>
                <Label Content="RESULT" Margin="239,47,0,0" FontSize="36" FontWeight="Bold" FontFamily="Segoe UI Black" HorizontalAlignment="Left" VerticalAlignment="Top"/>
                <Label Name="showResultLbl" Content="Words: 104  Seconds: 204 WPM 153." Margin="37,161,0,190" HorizontalAlignment="Left" HorizontalContentAlignment="Center" FontSize="33" FontFamily="NSimSun" FontWeight="Bold" Foreground="#FFEF4343"/>
            </Grid>
        </GroupBox>
    </Grid>
</Window>
