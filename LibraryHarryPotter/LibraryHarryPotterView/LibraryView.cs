using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryHarryPotterView
{
    public partial class LibraryView : Form
    {
        public LibraryView()
        {
            InitializeComponent();
        }

        // Function that Add quantity from book which client wish buy
        private void ActionAddition(object sender, EventArgs e)
        {
            Double aux = 0;
            string nameButton = (sender as Button).Name;

            switch (nameButton)
            {
                case "btnActionA":
                    aux = Double.Parse(lbOne.Text) + 1;
                    lbOne.Text = aux.ToString();
                    break;
                case "btnActionB":
                    aux = Double.Parse(lbTwo.Text) + 1;
                    lbTwo.Text = aux.ToString();
                    break;
                case "btnActionC":
                    aux = Double.Parse(lbThree.Text) + 1;
                    lbThree.Text = aux.ToString();
                    break;
                case "btnActionD":
                    aux = Double.Parse(lbFour.Text) + 1;
                    lbFour.Text = aux.ToString();
                    break;
                case "btnActionE":
                    aux = Double.Parse(lbFive.Text) + 1;
                    lbFive.Text = aux.ToString();
                    break;
                case "btnActionF":
                    aux = Double.Parse(lbSix.Text) + 1;
                    lbSix.Text = aux.ToString();
                    break;
                case "btnActionG":
                    aux = Double.Parse(lbSeven.Text) + 1;
                    lbSeven.Text = aux.ToString();
                    break;
                default:
                    break;
            }
        }//private void ActionAddition(object sender, EventArgs e)

        // Function that Subtract quantity from book which client wish buy
        private void ActionSubtration(object sender, EventArgs e)
        {
            Double aux = 0;
            string nameButton = (sender as Button).Name;

            switch (nameButton)
            {
                case "btnSubA":
                    if (lbOne.Text != "0")
                    {
                        aux = Double.Parse(lbOne.Text) - 1;
                        lbOne.Text = aux.ToString();
                    }
                    break;
                case "btnSubB":
                    if (lbTwo.Text != "0")
                    {
                        aux = Double.Parse(lbTwo.Text) - 1;
                        lbTwo.Text = aux.ToString();
                    }
                    break;
                case "btnSubC":
                    if (lbThree.Text != "0")
                    {
                        aux = Double.Parse(lbThree.Text) - 1;
                        lbThree.Text = aux.ToString();
                    }
                    break;
                case "btnSubD":
                    if (lbFour.Text != "0")
                    {
                        aux = Double.Parse(lbFour.Text) - 1;
                        lbFour.Text = aux.ToString();
                    }
                    break;
                case "btnSubE":
                    if (lbFive.Text != "0")
                    {
                        aux = Double.Parse(lbFive.Text) - 1;
                        lbFive.Text = aux.ToString();
                    }
                    break;
                case "btnSubF":
                    if (lbSix.Text != "0")
                    {
                        aux = Double.Parse(lbSix.Text) - 1;
                        lbSix.Text = aux.ToString();
                    }
                    break;
                case "btnSubG":
                    if (lbSeven.Text != "0")
                    {
                        aux = Double.Parse(lbSeven.Text) - 1;
                        lbSeven.Text = aux.ToString();
                    }
                    break;
                default:
                    break;
            }
        }//private void ActionSubtration(object sender, EventArgs e)

        // Function that calculate the discount and the totality of sell
        private void Calculate(object sender, EventArgs e)
        {
            double qtd = 0;
            double qtdReal = 0;
            int count = 0;

            string  [] books =  new string [] { "lbOne", "lbTwo", "lbThree", "lbFour", "lbFive", "lbSix", "lbSeven" };
            // Preço de um título qualquer: R$ 42,00
            // 2 livros - 5 %
            // 3 livros - 10 %
            // 4 livros - 15 %
            // 5 livros - 20 %

            foreach (var item in books)
            {
                var book = this.Controls.OfType<Label>()
                           .FirstOrDefault(c => c.Name == item);
                if (book.Text != "0")
                {
                    count += 1;
                    qtdReal += Double.Parse(book.Text);
                }
            }
            qtdReal = qtdReal * 42;
                switch (count)
                {
                    case 1:
                        qtd = qtdReal*42;
                        break;
                    case 2:
                        qtd = qtdReal - (qtdReal * 0.05);
                        break;
                    case 3:
                        qtd = qtdReal - (qtdReal * 0.1);
                        break;
                    case 4:
                        qtd = qtdReal - (qtdReal * 0.15);
                        break;
                    case 5:
                        qtd = qtdReal - (qtdReal * 0.20);
                        break;
                    default:
                        break;
                }
            lbDiscount.Text = (qtdReal - qtd ).ToString();
            lbTotality.Text = qtd.ToString();
        }//private void Calculate (object sender, EventArgs e)

        // Function that clean every labels on program
        private void Clean (object sender, EventArgs e)
        {
            lbOne.Text = "0";
            lbTwo.Text = "0";
            lbThree.Text = "0";
            lbFour.Text = "0";
            lbFive.Text = "0";
            lbSix.Text = "0";
            lbSeven.Text = "0";
            lbDiscount.Text = "0.0";
            lbTotality.Text = "0.0";

        }//private void Clean (object sender, EventArgs e)
    }
}
