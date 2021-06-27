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
    public partial class EnglishLevel1 : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;
          

        public EnglishLevel1()
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

                    lblQuestion.Text = "Which of the following is probably the most widely used English word throughout the world?";

                    button1.Text = "Good";
                    button2.Text = "Hello";
                    button3.Text = "Okay";
                    button4.Text = "House";

                    correctAnswer = 2;

                    break;



                case 2:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct word.'If he_____ phone, tell him to ring back later'";
                    button1.Text = "Can";
                    button2.Text = "Should";
                    button3.Text = "Might";
                    button4.Text = "Will";

                    correctAnswer = 3;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How many words do you think there are in the English language?";
                    button1.Text = "200 000";
                    button2.Text = "500 000";
                    button3.Text = "1 000 000 +";
                    button4.Text = "10 000";

                    correctAnswer = 3;

                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Provide the correct adjective for the given sentence:'Andrea had a ________ in her hair yesterday'";
                    button1.Text = "nice yellow bow";
                    button2.Text = "Yellow nice bow";
                    button3.Text = "Bow yellow nice";
                    button4.Text = "None of the above";

                    correctAnswer = 4;

                    break;



                case 5:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct word:'My sister really gets a ____ out of singing in public'";
                    button1.Text = "Buzz";
                    button2.Text = "Fun";
                    button3.Text = "Pleasure";
                    button4.Text = "Blush";

                    correctAnswer = 4;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "What should be at the end of a sentence?";
                    button1.Text = "Comma";
                    button2.Text = "Capital Letter";
                    button3.Text = "Full stop";
                    button4.Text = "Elipse";

                    correctAnswer = 2;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct words:'If you _____ mind waiting, I'll call and check if Mr Owen is in'";
                    button1.Text = "Wouldn't";
                    button2.Text = "do";
                    button3.Text = "will";
                    button4.Text = "could";

                    correctAnswer = 4;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Provide the correct adjective for the given sentence:'We met ________ people at the conference'";
                    button1.Text = "two very smart";
                    button2.Text = "Very smart two";
                    button3.Text = "None of the above";
                    button4.Text = "two smart";

                    correctAnswer = 4;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "The first letter of the first word in a sentence should be?";
                    button1.Text = "Small Letter";
                    button2.Text = "Big Letter";
                    button3.Text = "Large Letter";
                    button4.Text = "Capital Letetr";

                    correctAnswer = 1;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Fill in the correct word:'My parents suggested ______ apply for the job'";
                    button1.Text = "me to";
                    button2.Text = "if I";
                    button3.Text = "that I";
                    button4.Text = "Should I";

                    correctAnswer = 2;

                    break;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EnglishLevel1_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EnglishLevels Levl = new EnglishLevels();
            Levl.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
