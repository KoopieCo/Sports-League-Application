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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Sports_League_Application
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public static string LeagueName = "Name";
        public static string LeagueType = "Type";
        public static string StartTime = "Start";
        public static string EndTime = "End";
        public static string Description = "Description";
        public BlankPage1()
        {
            this.InitializeComponent();
            

    }

        private void Return_To_Main_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
           
            TitleBlock.Text = Global.Instance.selectedLeague.name;
            LeagueStyle.Text = Global.Instance.selectedLeague.type;
            LeagueStart.Text = Global.Instance.selectedLeague.start;
            LeagueEnd.Text = Global.Instance.selectedLeague.end;
            DescriptionBox.Text = Description;

            textBox.Text = Global.Instance.debugString;
        }

        

        private void RainBow_League_Click(object sender, RoutedEventArgs e)
        {


        LeagueName = "RainBow Unicorn League";
        LeagueType = "Play Off";
        StartTime = "Febuary 18th 2017";
        EndTime = "April 22nd 2017";
        Description = "Scorpions are the expected winners, Mark is up for the MVP status this season. Season injuries so far: Skye broke his arm, Mary twisted her ankle, and Rocko the mascot had to go to the vet and will miss the finals.";
        TitleBlock.Text = LeagueName;
        LeagueStyle.Text = LeagueType;
        LeagueStart.Text = StartTime;
        LeagueEnd.Text = EndTime;
        DescriptionBox.Text = Description;

        }
        private void Grid_Unloaded(object sender, RoutedEventArgs e)
        {
        LeagueName = "Name";
        LeagueType = "Type";
        StartTime = "Start";
        EndTime = "End";
        Description = "Description";
    }

        private void RainBow_League_Loaded(object sender, RoutedEventArgs e)
        {
            RainBow_League.Content = Global.Instance.selectedLeague.name;

        }
    }
}
