using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Taki
{
    public partial class Mainform : Form
    {
        private SoundPlayer sp = new SoundPlayer(Properties.Resources.buttonPress);
        private LinkedList<Card> chosens = new LinkedList<Card>();
        Taki game;
        public string name;
        LinkedList<Cardshower> graphicHand = new LinkedList<Cardshower>();

        public Mainform()
        {
            InitializeComponent();
            NOTGAMEpanel.BringToFront();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chosens.Clear();

            Player[] players = new Player[3] ;

            Form1 f = new Form1(this);
            f.ShowDialog();
            if(f.chosenName == null)
                return;
            players[0] = new Player(f.chosenName);
            players[1] = new Brain(Brain.GenerateName());
            do
            {
                players[2] = new Brain(Brain.GenerateName());
            } while (players[2].Name == players[1].Name);

            game = new Taki(players);
            MatchGraphicsToLogic();
            GAMEpanel.BringToFront();
        }

        public void MatchGraphicsToLogic()
        {
            enemy1label.Text = game.Players[1].Name + ": " + game.Players[1].cards.Count + " left";
            enemy2label.Text = game.Players[2].Name + ": " + game.Players[2].cards.Count + " left";
            topCard.Image = Cardshower.GetCardImage(game.PlayedCards.WhatsOnTop());
            this.Turn_label.Text = "Turn of: " + game.Players[game.Currentturn].Name;
            this.Text = "Taki: " + (game.Direction == 1 ? "->" : "<-");
            
            ShowPlayersCards();
        }

        public void ShowPlayersCards()
        {
            if (game.Players[0].cards.Count > graphicHand.Count)
            {
                int less = game.Players[0].cards.Count - graphicHand.Count;
                for (int i = 0; i < less; i++)
                    graphicHand.AddLast(new Cardshower(this));
            }
            else if (game.Players[0].cards.Count < graphicHand.Count)
            {
                int more = graphicHand.Count - game.Players[0].cards.Count;
                for (int i = 0; i < more; i++)
                {
                    this.GAMEpanel.Controls.Remove(graphicHand.Last.Value);
                    graphicHand.RemoveLast();
                }
            }

            int count = 0;
            foreach (Cardshower cs in graphicHand)
            {
                cs.index = count;
                count++;
            }

            if (graphicHand.Count <= 5)
                distanceFromEight = 2;
            else
                distanceFromEight = 8 - graphicHand.Count;

            magicNumber = 8.5 - distanceFromEight * 1.25; ;

            double factor = 758 / magicNumber;
            int ii = 0;
            foreach (Cardshower cs in graphicHand)
            {
                cs.Image = Cardshower.GetCardImage(game.Players[0].cards.ElementAt(ii));
                cs.SetLocation((int)(13 + ii * factor));
                cs.BringToFront();
                ii += 1;
            }
        }
        private int distanceFromEight;
        private double magicNumber;

        public void MarkCard(int index)
        {
            graphicHand.ElementAt(index).Mark();
        }

        public void CardWasPressed(int index)
        {
            if (game.Currentturn != 0) // actuall player
                return;

            Cardshower graphicCard = graphicHand.ElementAt(index);

            if (graphicCard.IsMarked)
            {
                graphicCard.Unmark();
                chosens.Remove(game.Players[0].cards.ElementAt(index));
            }
            else
            {
                graphicCard.Mark();
                chosens.AddLast(game.Players[0].cards.ElementAt(index));
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userAttemptedToPlay()
        {
            if (game.Currentturn != 0)
            {
                MessageBox.Show("Not your turn!", "Oops");
                return;
            }

            if (chosens.Count == 0)
            {
                MessageBox.Show("you didn't pick cards", "Oops");
                return;
            }
            
            if(chosens.Count == 1 && chosens.Last.Value.Value == Value.ChangeColor)
                if (game.IsLegal(chosens))
                {
                    sp.Play();
                    game.MakeTurn(chosens.ToArray());
                    if (game.DidPlayerWin())
                    {
                        MatchGraphicsToLogic();
                        this.Update();
                        AlertSomeoneWon(game.Players[0]);
                        chosens.Clear();
                        return;
                    }
                }
                     

            while ((chosens.First.Value.Value == Value.SuperTaki && chosens.First.Value.Color == Color.None) || (chosens.Last.Value.Value == Value.ChangeColor && chosens.Last.Value.Color == Color.None))
            {
                Color_Picker CP = new Color_Picker();
                CP.ShowDialog();
                if(chosens.First.Value.Value == Value.SuperTaki)
                    chosens.First.Value.Color = CP.Chosen;
                else
                    chosens.Last.Value.Color = CP.Chosen;
            }

            if (game.IsLegal(chosens))
            {
                game.MakeTurn(chosens.ToArray());
                if (game.DidPlayerWin())
                {
                    MatchGraphicsToLogic();
                    this.Update();
                    AlertSomeoneWon(game.Players[0]);
                    return;
                }
                foreach (Cardshower cs in graphicHand)
                    cs.Unmark();
                chosens.Clear();
                MakeTheBrainsPlay();
            }
            else
            {
                MessageBox.Show("Move is Ilegal", "Oops");
                if (chosens.First.Value.Value == Value.SuperTaki)
                    chosens.First.Value.Color = Color.None;
                if (chosens.Last.Value.Value == Value.ChangeColor)
                    chosens.Last.Value.Color = Color.None;
            }
        }

        private void MakeTheBrainsPlay()
        {
            while (game.Currentturn != 0)
            {
                MatchGraphicsToLogic();
                this.Update();
                Thread.Sleep(500);
                Brain b = (Brain)game.Players[game.Currentturn];
                LinkedList<Card> cards = b.Play(game.Top, game.PlusTwoActivated);
                if (cards == null)
                {
                    MessageBox.Show(game.Players[game.Currentturn].Name + " took a card");
                    game.GivePlayerCard(b);
                }
                else
                {
                    new EnemyFormOfCardShowers(cards, game.Players[game.Currentturn].Name).ShowDialog();
                    game.MakeTurn(cards.ToArray());
                }
                if (game.DidPlayerWin())
                {
                    MatchGraphicsToLogic();
                    this.Update();
                    AlertSomeoneWon(b);
                    return;
                }
            }
            MatchGraphicsToLogic();
        }

        public void AlertSomeoneWon(Player player)
        {
            MessageBox.Show(player.Name + " has won!", "Victory");
            GAMEpanel.SendToBack();
        }


        private void pictureBox_Click(object sender, EventArgs e)//החפיסה של הקלפים הפתוחים
        {
            if(chosens != null && chosens.Count > 0)
            userAttemptedToPlay();
        }

        private void pictureBox13_Click(object sender, EventArgs e)//החפיסה של קלפים לא משומשים
        {
            if (game.Currentturn == 0)
            {
                chosens.Clear();
                foreach (Cardshower cs in graphicHand)
                    cs.Unmark();
                game.GivePlayerCard(game.Players[0]);
                MatchGraphicsToLogic();
                MakeTheBrainsPlay();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(null, null);
        }

        private void GAMEpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
