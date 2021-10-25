using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taki
{
    public partial class EnemyFormOfCardShowers : Form
    {
        public EnemyFormOfCardShowers(LinkedList<Card> cards, string name)
        {
            InitializeComponent();
            this.Size = new Size(783, 235);
            this.Text = name + " plays these cards";
            ShowPlayersCards(cards);
        }

        public void ShowPlayersCards(LinkedList<Card> cards)
        {
            var graphicHand = new LinkedList<Cardshower>();

            int less = cards.Count;
            for (int i = 0; i < less; i++)
                graphicHand.AddLast(new Cardshower(this));

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

            if (graphicHand.Count < 5)
                this.Size = new Size(743 - 117 * (6 - graphicHand.Count), 235); // todo find the נוסחה

            magicNumber = 8.5 - distanceFromEight * 1.25; ;

            double factor = 758 / magicNumber;
            int ii = 0;
            foreach (Cardshower cs in graphicHand)
            {
                cs.Image = Cardshower.GetCardImage(cards.ElementAt(ii));
                cs.SetLocation((int)(13 + ii * factor));
                cs.BringToFront();
                ii += 1;
            }
        }
        private int distanceFromEight;
        private double magicNumber;

        private void EnemyFormOfCardShowers_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.Close();
        }
    }
}
