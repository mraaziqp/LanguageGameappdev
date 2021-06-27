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
    public partial class AfrikaansLevel1 : Form
    {
        int correctAnswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;

        public AfrikaansLevel1()
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

                    lblQuestion.Text = "A common phrase in any language is learning how to say thank you. Which one of these words means thank you?";

                    button1.Text = "Oor";
                    button2.Text = "Dankie";
                    button3.Text = "Slim";
                    button4.Text = "Sy";

                    correctAnswer = 3;

                    break;



                case 2:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "How would i say 'Good Morning'?";
                    button1.Text = "Goeie Nag";
                    button2.Text = "Goeie Middag";
                    button3.Text = "Goeie More";
                    button4.Text = "Goeie Dag";

                    correctAnswer = 2;

                    break;



                case 3:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Choose the correct vocabulary. In English the correct sentence would be 'Round the corner'";
                    button1.Text = "Oor die brug";
                    button2.Text = "Aan die linkerkant";
                    button3.Text = "Om die hoek";
                    button4.Text = "Aan die regterkant";

                    correctAnswer = 2;

                    break;



                case 4:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "My Watch says the time is 'Half-een'. What time is this in English?";
                    button1.Text = "1:30";
                    button2.Text = "1:00";
                    button3.Text = "12:00";
                    button4.Text = "12:30";

                    correctAnswer = 1;

                    break;



                case 5:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "'ek moet badkamer toe gaan'. What is the correct translation of this sentence?";
                    button1.Text = "I need a bath.";
                    button2.Text = "Where is the bathroom?";
                    button3.Text = "Can i see your room?";
                    button4.Text = "i need to go to the bathroom.";

                    correctAnswer = 1;

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Choose the correct sentence for 'I would like to sleep now'";
                    button1.Text = "Ek slaap nou.";
                    button2.Text = "Ek wil nou graag slaap";
                    button3.Text = "Ek sal slaap";
                    button4.Text = "Ek sal nou slaap";

                    correctAnswer = 3;

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "My friend said that he has 'Tuiswerk' to do. What does this mean?";
                    button1.Text = "Hit the gym.";
                    button2.Text = "Tough work to do.";
                    button3.Text = "Tie his shoes";
                    button4.Text = "He has Homework to do.";

                    correctAnswer = 1;

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Choose the correct color order'Blue, black, red and white'";
                    button1.Text = "Blou, Rooi, Swart, Wit";
                    button2.Text = "Blou, Wit, Swart, Rooi ";
                    button3.Text = "Swart, Wit, Blou, Rooi ";
                    button4.Text = "Blou, Swart, Rooi, Wit ";

                    correctAnswer = 1;

                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "A 'Haai' is chasing me. what does Haai mean? ";
                    button1.Text = "Shark";
                    button2.Text = "Chicken";
                    button3.Text = "Lion";
                    button4.Text = "Dolphin";

                    correctAnswer = 4;

                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.English;
                    lblQuestion.Text = "Choose the correct Time translation for 'kwart voor vyf'";
                    button1.Text = "02:50";
                    button2.Text = "17:15";
                    button3.Text = "16:45";
                    button4.Text = "12:19";

                    correctAnswer = 2;

                    break;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AfrikaansLevels Gb = new AfrikaansLevels();
            Gb.Show();
            this.Hide();
        }
    }
}
