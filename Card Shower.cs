using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taki
{
    public class Cardshower : PictureBox 
    {
        public bool IsMarked;
        readonly int REGULAR_Y_POSITION;

        Form mainform;
        public int index;

        public Cardshower(Form mainform)
        {
            this.Size = new System.Drawing.Size(117, 163);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Click += new EventHandler(this.Clicked);
            this.mainform = mainform;

            if (mainform.GetType() == typeof(Mainform))
            {
                Mainform mf = (Mainform)mainform;
                mf.GAMEpanel.Controls.Add(this);
                REGULAR_Y_POSITION = 334;
            }
            else
            {
                Form form = (Form)mainform;
                form.Controls.Add(this);
                REGULAR_Y_POSITION = 15;
            }
        }

        private void Clicked(object sender, EventArgs e)
        {
            if (mainform.GetType() == typeof(Mainform))
            {
                Mainform mf = (Mainform)mainform;
                mf.CardWasPressed(index);
            }
        }

        public void SetLocation(int x)
        {
            this.Location = new System.Drawing.Point(x, REGULAR_Y_POSITION);
        }

        public void DressAsCard(Card card)
        {
            Image = GetCardImage(card);
        }

        public void Mark()
        {
            Location = new System.Drawing.Point(Location.X, REGULAR_Y_POSITION - 20);
            IsMarked = true;
        }

        public void Unmark()
        {
            Location = new System.Drawing.Point(Location.X, REGULAR_Y_POSITION);
            IsMarked = false;
        }

        public static System.Drawing.Bitmap GetCardImage(Card card)
        {
            if (card.Color == Color.Blue)
            {
                if (card.Value == Value.ChangeDirection)
                    return TakiImages.New_Doc_11;
                if (card.Value == Value.Eight)
                    return TakiImages.New_Doc_1;
                if (card.Value == Value.One)
                    return TakiImages.New_Doc_9;
                if (card.Value == Value.Three)
                    return TakiImages.New_Doc_7;
                if (card.Value == Value.Four)
                    return TakiImages.New_Doc_6;
                if (card.Value == Value.Five)
                    return TakiImages.New_Doc_5;
                if (card.Value == Value.Six)
                    return TakiImages.New_Doc_4;
                if (card.Value == Value.Seven)
                    return TakiImages.New_Doc_3;
                if (card.Value == Value.Nine)
                    return TakiImages.New_Doc_2;
                if (card.Value == Value.PlusTwo)
                    return TakiImages.New_Doc_8;
                if (card.Value == Value.Taki)
                    return TakiImages.New_Doc_13;
                if (card.Value == Value.Stop)
                    return TakiImages.New_Doc_10;
                if (card.Value == Value.plus)
                    return TakiImages.New_Doc_12;

            }
            if(card.Color == Color.Green)
            {
                if (card.Value == Value.ChangeDirection)
                    return TakiImages.New_Doc_50;
                if (card.Value == Value.Eight)
                    return TakiImages.New_Doc_41;
                if (card.Value == Value.One)
                    return TakiImages.New_Doc_48;
                if (card.Value == Value.Three)
                    return TakiImages.New_Doc_47;
                if (card.Value == Value.Four)
                    return TakiImages.New_Doc_45;
                if (card.Value == Value.Five)
                    return TakiImages.New_Doc_44;
                if (card.Value == Value.Six)
                    return TakiImages.New_Doc_43;
                if (card.Value == Value.Seven)
                    return TakiImages.New_Doc_42;
                if (card.Value == Value.Nine)
                    return TakiImages.New_Doc_40;
                if (card.Value == Value.PlusTwo)
                    return TakiImages.New_Doc_46;
                if (card.Value == Value.Taki)
                    return TakiImages.New_Doc_52;
                if (card.Value == Value.Stop)
                    return TakiImages.New_Doc_51;
                if (card.Value == Value.plus)
                    return TakiImages.New_Doc_49;

            }
            if (card.Color == Color.Red)
            {
                if (card.Value == Value.ChangeDirection)
                    return TakiImages.New_Doc_24;
                if (card.Value == Value.Eight)
                    return TakiImages.New_Doc_15;
                if (card.Value == Value.One)
                    return TakiImages.New_Doc_22;
                if (card.Value == Value.Three)
                    return TakiImages.New_Doc_20;
                if (card.Value == Value.Four)
                    return TakiImages.New_Doc_19;
                if (card.Value == Value.Five)
                    return TakiImages.New_Doc_18;
                if (card.Value == Value.Six)
                    return TakiImages.New_Doc_17;
                if (card.Value == Value.Seven)
                    return TakiImages.New_Doc_16;
                if (card.Value == Value.Nine)
                    return TakiImages.New_Doc_14;
                if (card.Value == Value.PlusTwo)
                    return TakiImages.New_Doc_21;
                if (card.Value == Value.Taki)
                    return TakiImages.New_Doc_26;
                if (card.Value == Value.Stop)
                    return TakiImages.New_Doc_23;
                if (card.Value == Value.plus)
                    return TakiImages.New_Doc_25;

            }
            if (card.Color == Color.Yellow)
            {
                if (card.Value == Value.ChangeDirection)
                    return TakiImages.New_Doc_37;
                if (card.Value == Value.Eight)
                    return TakiImages.New_Doc_28;
                if (card.Value == Value.One)
                    return TakiImages.New_Doc_35;
                if (card.Value == Value.Three)
                    return TakiImages.New_Doc_33;
                if (card.Value == Value.Four)
                    return TakiImages.New_Doc_32;
                if (card.Value == Value.Five)
                    return TakiImages.New_Doc_31;
                if (card.Value == Value.Six)
                    return TakiImages.New_Doc_30;
                if (card.Value == Value.Seven)
                    return TakiImages.New_Doc_29;
                if (card.Value == Value.Nine)
                    return TakiImages.New_Doc_27;
                if (card.Value == Value.PlusTwo)
                    return TakiImages.New_Doc_34;
                if (card.Value == Value.Taki)
                    return TakiImages.New_Doc_39;
                if (card.Value == Value.Stop)
                    return TakiImages.New_Doc_36;
                if (card.Value == Value.plus)
                    return TakiImages.New_Doc_38;

            }
            if (card.Color == Color.None)
            {
                if (card.Value == Value.SuperTaki)
                    return TakiImages.New_Doc_54;
                if (card.Value == Value.ChangeColor)
                    return TakiImages.New_Doc_53;
            }
            return TakiImages.New_Doc_53;
        }
    }
}
