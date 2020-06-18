using BlackjackEngine;
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

namespace BlackjackGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Blackjack game;

        public MainWindow()
        {
            InitializeComponent();

            game = new Blackjack();
            game.Init();

            game.DealToPlayer();
            PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
            game.DealToDealer();
            PutOnScreen(DealerPanel, game.GetDealerLastCard());
            game.DealToPlayer();
            PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
            game.DealToDealer();
            PutOnScreen(DealerPanel, game.GetDealerLastCard());
        }

        private void StandButton_Click(object sender, RoutedEventArgs e)
        {
            // play again? prompt
            string sCaption = "Title";
            string sMessageBoxText = "Would you like to play again?";
            if (game.Stand())
            {
                winnerLabel.Content = "Winner: Player";
                sCaption = "You Win!";
            }
            else
            {
                winnerLabel.Content = "Winner: Dealer";
                sCaption = "You Lost!";
            }

            // asking if they want to play again
            MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
            MessageBoxImage icnMessageBox = MessageBoxImage.Warning;
            MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

            if (rsltMessageBox == MessageBoxResult.Yes)
            {
                // this clears the entire window
                //this.Content = new UserControl();

                // clears only the 2 panes that hold the card images
                DealerPanel.Children.Clear();
                PlayerPanel.Children.Clear();

                // reset game
                game = new Blackjack();
                game.Init();

                // deal cards
                game.DealToPlayer();
                PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
                game.DealToDealer();
                PutOnScreen(DealerPanel, game.GetDealerLastCard());
                game.DealToPlayer();
                PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
                game.DealToDealer();
                PutOnScreen(DealerPanel, game.GetDealerLastCard());
            }
            else
            {
                // Exit program
                Environment.Exit(0);
            }
        }

        private void HitButton_Click(object sender, RoutedEventArgs e)
        {
            game.DealToPlayer();
            PutOnScreen(PlayerPanel, game.GetPlayerLastCard());

            if (game.IsPlayerBusted())
            {
                MessageBox.Show("Busted. You lost");

                winnerLabel.Content = "Winner: Dealer";
                string sCaption = "You Lost!";
                string sMessageBoxText = "Would you like to play again?";


                // asking if they want to play again
                MessageBoxButton btnMessageBox = MessageBoxButton.YesNoCancel;
                MessageBoxImage icnMessageBox = MessageBoxImage.Warning;
                MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);
                if (rsltMessageBox == MessageBoxResult.Yes)
                {
                    // this clears the entire window
                    //this.Content = new UserControl();

                    // clears only the 2 panes that hold the card images
                    DealerPanel.Children.Clear();
                    PlayerPanel.Children.Clear();

                    game = new Blackjack();
                    game.Init();

                    game.DealToPlayer();
                    PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
                    game.DealToDealer();
                    PutOnScreen(DealerPanel, game.GetDealerLastCard());
                    game.DealToPlayer();
                    PutOnScreen(PlayerPanel, game.GetPlayerLastCard());
                    game.DealToDealer();
                    PutOnScreen(DealerPanel, game.GetDealerLastCard());
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        private void PutOnScreen(WrapPanel panel, Card c)
        {
            if (c == null) return;

            String filename = "cards/" + c.GetFilename();

            Image img = new Image();
            img.Source = new BitmapImage(new Uri(filename, UriKind.Relative));

            panel.Children.Add(img);
        }

    }
}
