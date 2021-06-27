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
    public partial class EnglishLevel2 : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;

        public EnglishLevel2()
        {
            InitializeComponent();
            askQuestion(questionNumber);
            totalQuestions = 10;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
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

                    lblQuestion.Text = "Which of the following is the longest word that appears in a play by William Shakespeare?";

                    button1.Text = "antidisestablishmentarianism";
                    button2.Text = "sesquipedalian";
                    button3.Text = " honorificabilitudinitatibus";
                    button4.Text = "incomprehensibleness";

                    correctAnswer = 2;

                    break;



                case 2:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Which one of the following words is an example of an isogram?";
                    button1.Text = "racecar";
                    button2.Text = "palindrome";
                    button3.Text = "buffet";
                    button4.Text = "destruction";

                    correctAnswer = 3;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Which of the following terms refers to the substitution of a more offensive word or phrase for one considered less offensive?";
                    button1.Text = "Eeuphemism";
                    button2.Text = "dysphemism";
                    button3.Text = "orthophemism";
                    button4.Text = "neologism";

                    correctAnswer = 4;

                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "In approximately how many countries does the English language have official or special status?";
                    button1.Text = "67";
                    button2.Text = "10";
                    button3.Text = "80";
                    button4.Text = "35";

                    correctAnswer = 4;

                    break;



                case 5:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correctwords:'I’m not sure if I shut down the computer. I can’t really remember _______ it down.'";
                    button1.Text = "have shut";
                    button2.Text = "to shut";
                    button3.Text = "shutting";
                    button4.Text = "I shut";

                    correctAnswer = 2;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Which country contains the largest English-speaking population in the world?";
                    button1.Text = "England";
                    button2.Text = "China";
                    button3.Text = "United States";
                    button4.Text = "Australia";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct words for:(I asked Jane about the accident, but she _____ a word)";
                    button1.Text = "wouldn't say";
                    button2.Text = "didn't use to";
                    button3.Text = "shouldn't say";
                    button4.Text = "refused";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "The sentence Natasha is a friend of Joans and a client of Marlowe's contains two examples of which grammatical structure?";
                    button1.Text = "double entendre";
                    button2.Text = " double comparative";
                    button3.Text = "double genitive";
                    button4.Text = "double negative";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct words for :(Nobody should think they're above _____ )";
                    button1.Text = "approach";
                    button2.Text = "blame";
                    button3.Text = "responsibility";
                    button4.Text = "reproach";

                    correctAnswer = 1;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Which of the following is generally regarded as the first genuine dictionary in English?";
                    button1.Text = "Dictionary of the English Language by Samuel Johnson";
                    button2.Text = "The Elementarie by Richard Mulcaster";
                    button3.Text = "A Table Alphabeticall by Robert Cawdrey";
                    button4.Text = "Glossographia by Thomas Blount";

                    correctAnswer = 3;

                    break;


            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EnglishLevels En2 = new EnglishLevels();
            En2.Show();
            this.Hide();
        }
    }
}
