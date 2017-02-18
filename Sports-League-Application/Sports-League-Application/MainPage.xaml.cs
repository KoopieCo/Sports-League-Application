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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Sports_League_Application
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();         
            
        }
        
        private void Create_your_league_button_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(BlankPage1));

            // Add the league info to new league object.
            League tempLeague = new Sports_League_Application.League();
            tempLeague.name = NameBox.Text;
            tempLeague.start = Start_Time.Date.ToString();
            tempLeague.end = End_Time.Date.ToString();
            if (comboBox.SelectedIndex == 0)
                tempLeague.type = "Play-off";
            else
                tempLeague.type = "Round Robin";

            // Add league object to the global list
            Global.Instance.createdLeagues.Add(tempLeague);

            // Create temporary button
            ListViewItem temp = new ListViewItem();
            temp.Content = tempLeague.name;

            // Add button to list
            LeagueList.Items.Add(temp);
        }

        private void LeagueList_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void LeagueList_Loaded(object sender, RoutedEventArgs e)
        {
            // For every league in our global created leagues list, create a button for it.
            for(int i = 0; i < Global.Instance.createdLeagues.Count; i++)
            {
                // Create a new button
                // Create temporary button
                ListViewItem temp = new ListViewItem();
                temp.Content = Global.Instance.createdLeagues[i].name;

                // Add button to the list, buddy.
                LeagueList.Items.Add(temp);
            }
        }

        private void LeagueList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Stores the selected item into temp
            ListViewItem temp = (ListViewItem)e.AddedItems[0];

            // Determine the selected league.
            for(int i = 0; i < Global.Instance.createdLeagues.Count; i++)
            {
                if(temp.Content.ToString().Equals(Global.Instance.createdLeagues[i].name))
                {
                    Global.Instance.selectedLeague = new League();
                    Global.Instance.selectedLeague.name = Global.Instance.createdLeagues[i].name;
                    Global.Instance.selectedLeague.start = Global.Instance.createdLeagues[i].start;
                    Global.Instance.selectedLeague.end = Global.Instance.createdLeagues[i].end;
                    Global.Instance.selectedLeague.type = Global.Instance.createdLeagues[i].type;
                    break;
                }
            }

            //Global.Instance.debugString = temp.Content.ToString();
            //Global.Instance.debugString = Global.Instance.createdLeagues[0].name;

            // Navigate
            this.Frame.Navigate(typeof(BlankPage1));
        }
    }

}
