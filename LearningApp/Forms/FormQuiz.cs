using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningApp.Forms
{
    public partial class FormQuiz : Form
    {
        int correctAnswer;
        int questionNumber = 1;
        int score = 3;
        int percentage;
        int totalQuestions;

        public FormQuiz()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 5;
        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if(buttonTag == correctAnswer)
            {
                score++;
            }
            if(questionNumber == totalQuestions)
            {
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show("Correct answers: " + score + Environment.NewLine + "Your score: " + percentage + "%" + Environment.NewLine + "Click OK to play again");

                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }

            questionNumber++;
            askQuestion(questionNumber);
        }

        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    lblWord.Text = "SCREW";
                    lblSentence.Text = "Good luck doing your bird in Bristol nick, it's got some of the worst SCREWS in England.";

                    button1.Text = "KLAWISZ (STRAŻNIK WIĘZIENNY)";
                    button2.Text = "ŚRÓBA";
                    button3.Text = "GWÓŹDŹ";
                    button4.Text = "OKANTKOWAĆ / OSZUKAĆ";

                    correctAnswer = 1;
                    break;

                case 2:
                    lblWord.Text = "SNITCH";
                    lblSentence.Text = "It can't be proved, but everyone thinks Dean was murdered for being a SNITCH.";

                    button1.Text = "ZWĘDZIĆ (COŚ)";
                    button2.Text = "KAPUŚ";
                    button3.Text = "ZDRAJCA";
                    button4.Text = "SZPIEG";

                    correctAnswer = 2;
                    break;

                case 3:
                    lblWord.Text = "PISSING IT DOWN";
                    lblSentence.Text = "The moment I stepped outside it started PISSING IT DOWN.";

                    button1.Text = "SIKAĆ";
                    button2.Text = "PADAĆ DESZCZ";
                    button3.Text = "ULEWA";
                    button4.Text = "LAĆ JAK Z CEBRA";

                    correctAnswer = 4;
                    break;

                case 4:
                    lblWord.Text = "PIECE";
                    lblSentence.Text = "I'm not suprised the murder rate is so high here, there's too many PIECES floating about.";

                    button1.Text = "KAWAŁEK";
                    button2.Text = "CZĘŚĆ";
                    button3.Text = "BROŃ PALNA";
                    button4.Text = "NIEBEZPIECZNE NARZĘDZIE";

                    correctAnswer = 3;
                    break;

                case 5:
                    lblWord.Text = "TO RIP OFF";
                    lblSentence.Text = "I knew Derek would be RIPPED OFF by that car garage - it's got an awfull reputation.";

                    button1.Text = "OKANTOWAĆ";
                    button2.Text = "ZERWAĆ";
                    button3.Text = "ROZERWAĆ";
                    button4.Text = "WPROWADZIĆ W BŁĄD";

                    correctAnswer = 1;
                    break;
            }
        }

        private void lblWord_Click(object sender, EventArgs e)
        {

        }

        private void lblSentence_Click(object sender, EventArgs e)
        {

        }
    }
}
