using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Game
{
    public partial class AfrikaansLevel2 : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;

        public AfrikaansLevel2()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAnswerEvents(object sender, EventArgs e)
        {
            //linking the button to the question-senders
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag); //convert function from the sender object
            //int saved as tag

            //correct answer button
            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                //work out the percentage

                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(
                    "Quiz has Ended!!!" + Environment.NewLine +
                    "You have answered " + score + " questions correctly." + Environment.NewLine +
                    "Your total percentage is " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);

            }
            //for question to go to the next one`
            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.English;

                    lblQuestion.Text = "Wat is die hoofstad van Griekeland? ";

                    button1.Text = "Rome";
                    button2.Text = "Suid-Afrika";
                    button3.Text = "Athene";
                    button4.Text = "Italie";

                    correctAnswer = 2;

                    break;



                case 2:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "wat is die name van jan van riebeeck se kasteel?";
                    button1.Text = "Groot kaap";
                    button2.Text = "Kaap van Goodhope";
                    button3.Text = "Kasteel van Riebeek";
                    button4.Text = "Riebeeks huis";

                    correctAnswer = 3;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Kies die regte vertaling vir 'We have to social distance and wear masks due to covid-19'";
                    button1.Text = "ek kan nie glo dat covid-19 'n hele pandemie begin het nie";
                    button2.Text = "Ons moet sosiale afstand neem en maskers dra as gevolg van covid-19";
                    button3.Text = "ons moet almal 'n afstand van mekaar hou";
                    button4.Text = "Ek kan nêrens heen gaan nie weens covid-19";

                    correctAnswer = 3;

                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "My ma het vir my gesê dat ek haar om vieruur moet gaan haal. Dit is nou half drie. Hoe lank moet ek nog wag?";
                    button1.Text = "Een en 'n half uur";
                    button2.Text = "twee uur";
                    button3.Text = "fyfteen miniete";
                    button4.Text = "vier en n half uur";

                    correctAnswer = 4;

                    break;



                case 5:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Een van hierdie antwoorde is 'n hoofstad van Suid-Afrika. kies die regte een.";
                    button1.Text = "johannesburg";
                    button2.Text = "Abuja";
                    button3.Text = "Kaapstad";
                    button4.Text = "Nie een hiervan nie";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Kies die regte vertaling vir 'My Teacher Said tha the tests ends at half past 2.'";
                    button1.Text = "Ek wonder wanneer hierdie toets gaan eindig";
                    button2.Text = "My onderwyser het gesê dat die toetse om half 2 eindig";
                    button3.Text = "Ek dink die toets eindig volgens my onderwyser binnekort";
                    button4.Text = "My onderwyser het gesê dat die toetse om half vyf eindig";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "My suster wil graag in films optree. Wat sal haar titel wees?";
                    button1.Text = "syfilm";
                    button2.Text = "aktrise";
                    button3.Text = "Film Meisie";
                    button4.Text = "Aktor";

                    correctAnswer = 3;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "los hierdie vergelyking op: vyftien keer tien gedeel, deur twee";
                    button1.Text = "vyf en sewentig";
                    button2.Text = "honderd en vyftig";
                    button3.Text = "twee en twintig";
                    button4.Text = "agt en negentig";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Kies die regte vertaling vir 'I cant believe that i am stuck in traffic!'";
                    button1.Text = "Ek kan nie glo dat hierdie lyn so lank is nie!";
                    button2.Text = "my motor sit vas!";
                    button3.Text = "Ek kan nie glo dat ek in die verkeer sit nie!";
                    button4.Text = "Hierdie verkeer is kranksinnig!";

                    correctAnswer = 2;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "My pa het my gevra om die bande op sy motor te ruil. Watter hulpmiddel is nodig om dit te doen?";
                    button1.Text = "Bout";
                    button2.Text = "Skroewedraaier";
                    button3.Text = "hamer";
                    button4.Text = "moersleutel";

                    correctAnswer = 1;

                    break;


            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AfrikaansLevels Afr1 = new AfrikaansLevels();
            Afr1.Show();
            this.Hide();
        }
    }
}
