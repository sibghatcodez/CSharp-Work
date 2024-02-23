//MainWindow.xaml.cs
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public MainWindow()
        {
            InitializeComponent();
            List<string> list = new List<string>()
            {
                "0:55 - 1st",
                "0:45 - 2nd",
                "0:36 - 3rd"
            };

            listbox.ItemsSource = list;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main.Visibility = Visibility.Collapsed;
            randomText();
            main2.Visibility = Visibility.Visible;
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
        }
        private async void StartTimer()
        {
            TimerLbl.Visibility = Visibility.Visible;
            for (int i = 60; i >= 1; i--)
            {
                TimerLbl.Content = "TIME LEFT: " + i + "s";
                await Task.Delay(1000);
            }
        }

        private void randomText()
        {
            Random rand = new Random();
            randTextNumber = rand.Next(1, 5);

            switch (randTextNumber)
            {
                case 1:
                    textToWriteLbl.Text = "In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day.";
                    break;
                case 2:
                    textToWriteLbl.Text = "A gentle zephyr wafts through the blossoming orchard, carrying the sweet fragrance of blooming flowers and coaxing the leaves to perform a graceful dance";
                    break;
                case 3:
                    textToWriteLbl.Text = "Nestled in the cozy nook of the living room, a curious tabby cat with soft, furry paws playfully explores a patch of sunlight, casting a contented gaze upon a collection of well-loved toys";
                    break;
                case 4:
                    textToWriteLbl.Text = "As the grandfather clock in the hallway ticks steadily, a comforting symphony of raindrops taps on the windowpane, creating a soothing melody that serenades the quietude of the cozy reading nook";
                    break;
                case 5:
                    textToWriteLbl.Text = "Under the sprawling branches of the old oak tree, a friendly bluebird perches, melodiously trilling a joyous tune, announcing the arrival of a splendid afternoon in the idyllic meadow";
                    break;
                default:
                    textToWriteLbl.Text = "In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day.";
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
            <RowDefinition Height="197*"/>
            <RowDefinition Height="237*"/>
        </Grid.RowDefinitions>
        <GroupBox Header="" Name="main" Grid.RowSpan="2" d:IsHidden="True">
            <Grid>
                <Label Content="- WORD PER MINUTE - COUNTER - " FontSize="30" FontWeight="Bold" FontFamily="Sitka Small" Foreground="#FF148A4C" HorizontalAlignment="Left" VerticalAlignment="Top" Height="71" Width="569" Margin="51,88,0,0" HorizontalContentAlignment="Center" VerticalContentAlignment="Center"/>

                <TextBlock TextWrapping="Wrap" TextAlignment="Center" FontWeight="Bold" FontFamily="Trebuchet MS" FontSize="24" VerticalAlignment="Center" Margin="-53,0,32,0"><Run Text="YOU WILL BE GIVEN TEXT TO WRITE "/><LineBreak/><Run Text="WITHIN A MINUTE."/><LineBreak/><Run/><LineBreak/>CLICK <Run Text="START " Foreground="Green"  FontWeight="Bold" FontFamily="Segoe UI Light"/>TO CONTINUE</TextBlock>

                <Button Content="START" Name="startBtn" BorderBrush="White" FontSize="27" FontWeight="Bold" Foreground="White" Background="#FF499E32" FontFamily="Segoe UI Light" Height="45" Width="180" Margin="280,289,0,0" Click="Button_Click_1" HorizontalAlignment="Left" VerticalAlignment="Top" Cursor="Hand">
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

        <GroupBox Header="Timeline" Margin="666,62,10,144" Name="timeline" Grid.RowSpan="2"/>
        <ListBox Margin="693,99,29,229" Name="listbox" Grid.RowSpan="2"/>

        <GroupBox Name="main2" Visibility="Collapsed" Grid.RowSpan="2">
            <Grid>


                <TextBlock Name="textToWriteLbl" TextWrapping="Wrap" Text="In the early hours of the morning, the radiant sun ascends in the eastern sky, casting a golden hue over the tranquil countryside, awakening the world to a new day." Margin="36,118,0,0" HorizontalAlignment="Left" FontSize="24" FontFamily="PMingLiU-ExtB" FontWeight="Bold" Foreground="#FFED8B27" Width="575" VerticalAlignment="Top" TextAlignment="Center"/>
                <Label Content="WRITE" Margin="231,48,0,0" FontSize="36" FontWeight="Bold" FontFamily="Sitka Small" HorizontalAlignment="Left" VerticalAlignment="Top"/>
                <TextBox Margin="51,258,0,0" TextAlignment="Center" HorizontalAlignment="Left" VerticalAlignment="Top" TextWrapping="Wrap" FontSize="24" FontFamily="NSimSun" Foreground="Black" Width="560"/>
                <Label x:Name="TimerLbl" Content="TIME LEFT: " Margin="476,51,155,341" FontSize="20" FontWeight="Bold" Foreground="#FF18BBDA"/>
                <Label x:Name="CountToThreeLbl" Content="START TYPING IN" Margin="228,203,204,148" FontSize="24" FontWeight="Bold" FontFamily="Nirmala UI Semilight" VerticalContentAlignment="Center"/>

            </Grid>
        </GroupBox>
    </Grid>
</Window>
