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
        <GroupBox Header="" Name="main">
            <TextBlock TextWrapping="Wrap" Margin="72,0,265,0" Height="133" TextAlignment="Center" FontWeight="Bold" FontFamily="Trebuchet MS" FontSize="24"><Run Text="YOU WILL BE GIVEN TEXT TO WRITE WITHIN A MINUTE."/><LineBreak/><Run/><LineBreak/><Run Text="CLICK START TO CONTINUE"/><LineBreak/><Run/><LineBreak/><Run/></TextBlock>
        </GroupBox>

        <GroupBox Header="Timeline" Margin="661,62,10,132" Name="timeline"/>
        <ListBox Margin="680,99,29,229" Name="listbox"/>
        <Label Content="- WORD PER MINUTE - COUNTER - " Margin="43,81,215,282" FontSize="30" FontWeight="Bold" FontFamily="Sitka Small" Foreground="#FF148A4C" HorizontalContentAlignment="Center" VerticalContentAlignment="Center"/>
        <Button Content="START" Margin="204,298,416,91" BorderBrush="White" FontSize="27" FontWeight="Bold" Foreground="White" Background="#FF499E32" FontFamily="Segoe UI Light">
            <Button.Template>
                <ControlTemplate TargetType="Button">
                    <Border Background="{TemplateBinding Background}" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="0,1,1,1" CornerRadius="20">
                        <ContentPresenter HorizontalAlignment="Center" VerticalAlignment="Center"/>
                    </Border>
                </ControlTemplate>
            </Button.Template>
        </Button>

    </Grid>
</Window>




//MainWindow.xaml.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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
    }
}
