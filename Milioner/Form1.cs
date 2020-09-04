using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milioner
{
    public partial class Form1 : Form
    {
        private int iSlide;
        private string rightAnswer;
        private Boolean playerLost;
        private int[] randomNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10 ,11, 12, 13, 14, 15 };
        private int timeLeft;
        private int highestScore;
        public Form1()
        {
            InitializeComponent();
            //this.BackgroundImage = imageList1.Images[18];
            //this.BackgroundImageLayout = ImageLayout.Stretch;
            iSlide = 0;
            rightAnswer = "";
            playerLost = false;
            timeLeft = 15;
            highestScore = 0;
        }


        private void shuffleArray<T>(T [] array)
        {
            // Make sure same questions don't repeat each self
            Random rnd = new Random();

            //Make sure they dont repeat method, da se testira oti mnogu se mali shansite da se pogodat sami. Ke loopova mnogu skoro beskonechno. Plus arrayot e lokalno taka da nema da raboti
            int n = array.Length;
            while (n > 1)
            {
                int k = rnd.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        private void questionPicker(int num, int iSlide)
        {
            switch (num)
            {
                case 1:
                    this.Question1(iSlide);
                    break;

                case 2:
                    this.Question2(iSlide);
                    break;

                case 3:
                    this.Question3(iSlide);
                    break;

                case 4:
                    this.Question4(iSlide);
                    break;

                case 5:
                    this.Question5(iSlide);
                    break;

                case 6:
                    this.Question6(iSlide);
                    break;

                case 7:
                    this.Question7(iSlide);
                    break;

                case 8:
                    this.Question8(iSlide);
                    break;

                case 9:
                    this.Question9(iSlide);
                    break;

                case 10:
                    this.Question10(iSlide);
                    break;

                case 11:
                    this.Question11(iSlide);
                    break;

                case 12:
                    this.Question12(iSlide);
                    break;

                case 13:
                    this.Question13(iSlide);
                    break;

                case 14:
                    this.Question14(iSlide);
                    break;

                case 15:
                    this.Question15(iSlide);
                    break;


            }
        }

        private void randomQuestionsGenerator(int slide)
        {
            button1.Enabled = false;
            if (slide <= this.randomNums.Length && slide <= 15)
            {
                questionPicker(this.randomNums[slide - 1], slide);
            } else
            {
                // No more questions this is the END DO something

                label2.Font = new Font("Arial", 20);
                label2.TextAlign = ContentAlignment.MiddleCenter;
                label2.Text = "Tarik: Congratulations!!!! You won 1M $$$";

                pictureBox1.Image = imageList1.Images[0];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                button1.Enabled = true;
                button1.Text = "Play again";
                button1.BackColor = Color.Green;

                //Disable radio buttons
                radioButton1.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;

                // 
                button2.ForeColor = Color.White;
                button2.BackColor = Color.FromArgb(0, 0, 187);
                button3.ForeColor = Color.White;
                button3.BackColor = Color.FromArgb(0, 0, 187);
                button2.Enabled = false;
                button3.Enabled = false;

                // Resetting values
                this.iSlide = 0;
                this.rightAnswer = "";
                this.playerLost = false;
                this.timeLeft = 15;
                label1.Text = "Timer";

                // Shuffle the array for random questions
                this.shuffleArray<int>(this.randomNums);

            }
        }

        //Shuffle questions
        private void answersShuffleHandler(string[] answers, string correctAnswer)
        {
            RadioButton[] radioButtons = { radioButton1, radioButton5, radioButton6, radioButton7 };

            shuffleArray<string>(answers);

            for (int i = 0; i < answers.Length; i++)
            {
                if (correctAnswer == answers[i])
                {
                    switch (i)
                    {
                        case 0:
                            this.rightAnswer = "A";
                            break;
                        case 1:
                            this.rightAnswer = "C";
                            break;
                        case 2:
                            this.rightAnswer = "B";
                            break;
                        case 3:
                            this.rightAnswer = "D";
                            break;
                    }
                }
                radioButtons[i].Text = answers[i];
            }
        }
        private void Question1(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What is the full real name of the YouTuber?";

            string[] answers = { "Felix Arvid Ulf Kjellberg", "Felix Arvid ", "Felix Thor Baze Teiller", "Ingrid Olaf Kalleh Trailler" };
            string correctAnswer = "Felix Arvid Ulf Kjellberg";

            this.answersShuffleHandler(answers, correctAnswer);
           
        }
        private void Question2(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What time did the YouTuber get born?";

            string[] answers = { "August 6th", "January 19th", "March 3th", "October the 24th" };
            string correctAnswer = "October the 24th";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question3(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Who does a series similar to YouTuber's?";

            string[] answers = { "Jack Douglass", "King Liang", "Mark Edward Fischbach", "Sean McLoglean" };
            string correctAnswer = "Jack Douglass";

            this.answersShuffleHandler(answers, correctAnswer);
        }

        private void Question4(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Who is the YouTuber's partner?";

            string[] answers = { "Marzia Bisognin" ,"Alinity","Pokimane" ,"Valeria pezemskaya" };
            string correctAnswer = "Marzia Bisognin";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question5(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Who does a series similar to YouTuber's?";

            string[] answers = { "Nearly 50 million Subscribers" ,"No idea" ,"Nearly a Billion", "More than 100 million Subscribers" };
            string correctAnswer = "More than 100 million Subscribers";

            this.answersShuffleHandler(answers, correctAnswer);
        }

        private void Question6(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What is the name of the Site the YouTuber's video directory is running on??";

            string[] answers = { "Metacafe","Veoh","Archive.org","M.YouTube.com" };
            string correctAnswer = "M.YouTube.com";

            this.answersShuffleHandler(answers, correctAnswer);
        }

        private void Question7(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What is the YouTuber's famous for?";

            string[] answers = { "CRAFTING", "LET'S PLAYS", "CODING", "ART" };
            string correctAnswer = "LET'S PLAYS";

            this.answersShuffleHandler(answers, correctAnswer);
        }

        private void Question8(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Which Sharing Web-directory did the YouTuber leave?";

            string[] answers = { "Twitter", "Facebook", "Instagram", "Vkontakte" };
            string correctAnswer = "Twitter";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question9(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Why did the YouTuber leave the Sharing Web-directory mentioned in the previous request?";

            string[] answers = { " He disliked It", "He had a Conflict", "He didn't need It", "For no reason" };
            string correctAnswer = "He had a Conflict";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question10(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What game does the YouTuber play?";

            string[] answers = { "Amnesia", "Warcraft", "Minecraft", "Destiny" };
            string correctAnswer = "Minecraft";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question11(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What is the YouTuber's Nickname?";

            string[] answers = { "Arrvide", "Reverso", "Felix", "PewDiePie" };
            string correctAnswer = "PewDiePie";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question12(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Which year was he born? ";

            string[] answers = { "1991", "1988", "1989" , "1990" };
            string correctAnswer = "1989";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question13(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". Which one is true about PewDiePie?";

            string[] answers = { "Swedish", "American", "Irish", "Polish" };
            string correctAnswer = "Swedish";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question14(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". What does PewDiePie call his fanbase?";

            string[] answers = { "Team Pew", "Squad Fam", "Squid Fam", "Team Fam " };
            string correctAnswer = "Squad Fam";

            this.answersShuffleHandler(answers, correctAnswer);
        }
        private void Question15(int questionNum)
        {
            label2.Text = questionNum.ToString() + ". When did his channel subscribers surpass one million?";

            string[] answers = { "2010", "2015", "2012", "2013" };
            string correctAnswer = "2012";

            this.answersShuffleHandler(answers, correctAnswer);
        }





        private void Form1_Load(object sender, EventArgs e)
        {

            // Shuffle Questions
            this.shuffleArray<int>(this.randomNums);

            label2.Font = new Font("Arial", 20);
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Text = "Tarik: Start game if ready!";
            if (this.playerLost)
            {
                label2.Text = "Tarik: Nice try. Click start game if you want to try again!";
            }

            // Pic 1
            pictureBox1.Image = imageList1.Images[0];
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Pic 2
            pictureBox2.Image = imageList1.Images[17];
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            
            // Pic 3
            pictureBox3.Image = imageList1.Images[16];
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            radioButton1.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;

            // Reset text to nothing
            radioButton1.Text = "";
            radioButton5.Text = "";
            radioButton6.Text = "";
            radioButton7.Text = "";

            radioButton1.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;

            // 50:50 and call a friend button
            button2.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(0, 0, 187);
            button2.Enabled = false;
            button3.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(0, 0, 187);
            button3.Enabled = false;

            label1.Text = "Timer";

            button1.BackColor = Color.SpringGreen;
            button1.Text = "Start game";

            timer1.Stop();
            // Resetting values
            this.iSlide = 0;
            this.rightAnswer = "";
            this.playerLost = false;
            this.timeLeft = 15;
        }

        private void rightAnswerChecker(string answer, RadioButton radioButton)
        {
            timer1.Stop();
            button1.Enabled = true;
            if (answer == this.rightAnswer)
            {
                button1.Text = "Tarik: Your answer is correct! Continue";
                button1.BackColor = Color.Green;
                radioButton.BackColor = Color.Green;
            }
            else
            {
                // The player actually lost, now the button is used for restarting!
                button1.Text = "You lost! The right answer was " + this.rightAnswer.ToString();
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.White;
                radioButton.BackColor = Color.Red;

                button2.Enabled = false;
                button3.Enabled = false;

                this.playerLost = true;
            }
        }


        private void disableOthers(RadioButton radioButton)
        {
            RadioButton[] radioButtons = { radioButton1, radioButton5, radioButton6, radioButton7 };
            foreach(RadioButton button in radioButtons)
            {
                if(button == radioButton)
                {
                    continue;
                }
                button.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string answer = "A";
           this.rightAnswerChecker(answer, radioButton1);
            // Disable other buttons
            this.disableOthers(radioButton1);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            string answer = "C";
            this.rightAnswerChecker(answer, radioButton5);
            // Disable other buttons
            this.disableOthers(radioButton5);
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            string answer = "B";
            this.rightAnswerChecker(answer, radioButton6);
            // Disable other buttons
            this.disableOthers(radioButton6);
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            string answer = "D";
            this.rightAnswerChecker(answer, radioButton7);
            // Disable other buttons
            this.disableOthers(radioButton7);
        }

 

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Answer";

            // Beginning of the game
            if (this.iSlide == 0 && !this.playerLost)
            {
                label1.Text = "Timer";
                button1.BackColor = Color.DarkBlue;
                button1.ForeColor = Color.White;
                label2.Font = new Font("Arial", 12);
                label2.TextAlign = ContentAlignment.TopLeft;
                radioButton1.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;

                button2.Enabled = true;
                button3.Enabled = true;
            }

            // Set highest score 
            if (iSlide + 1 > this.highestScore && !this.playerLost)
            {
                this.highestScore = iSlide + 1;
                label3.Text = "Highest rating: " + this.highestScore.ToString();
            }

            if (this.playerLost)
            {
                // Restart whole game
                this.Form1_Load(sender, e);
            } else {
                // Continue game

                label1.Text = "15 seconds";
                label2.Text = "";

                radioButton1.Checked = false;
                radioButton5.Checked = false;
                radioButton6.Checked = false;
                radioButton7.Checked = false;


                radioButton1.Enabled = true;
                radioButton5.Enabled = true;
                radioButton6.Enabled = true;
                radioButton7.Enabled = true;

                radioButton1.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;


                radioButton1.BackColor = Color.DarkBlue;
                radioButton5.BackColor = Color.DarkBlue;
                radioButton6.BackColor = Color.DarkBlue;
                radioButton7.BackColor = Color.DarkBlue;

                button1.BackColor = Color.DarkBlue;

                iSlide = iSlide + 1;

                // Pic 1, change it depening on where the user is
                pictureBox1.Image = imageList1.Images[iSlide];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                this.timeLeft = 15;
                timer1.Start();

                randomQuestionsGenerator(iSlide);
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            RadioButton[] radioButtons = new RadioButton[3];

            switch (this.rightAnswer)
            {
                case "A":
                    radioButtons[0] = radioButton5;
                    radioButtons[1] = radioButton6;
                    radioButtons[2] = radioButton7;

                    break;
                case "B":
                    radioButtons[0] = radioButton1;
                    radioButtons[1] = radioButton5;
                    radioButtons[2] = radioButton7;

                    break;
                case "C":
                    radioButtons[0] = radioButton1;
                    radioButtons[1] = radioButton6;
                    radioButtons[2] = radioButton7;

                    break;
                case "D":
                    radioButtons[0] = radioButton1;
                    radioButtons[1] = radioButton5;
                    radioButtons[2] = radioButton6;

                    break;

            }

            // Now shuffle radio buttons
            this.shuffleArray<RadioButton>(radioButtons);

            // After shuffle is done randomly remove the first 2 radio buttons
            radioButtons[0].Visible = false;
            radioButtons[1].Visible = false;
            button2.Enabled = false;
            button2.BackColor = Color.Red;
        }

        // 80% of the time he's right, 20% he's in the wrong
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Font = new Font("Arial", 20);
            label2.TextAlign = ContentAlignment.MiddleCenter;

            Random random = new Random();
            int rng = random.Next(1, 10);
            if (rng > 8)
            {
                //Wrong answer
                if (rightAnswer != "A")
                {
                    label2.Text = "Vujko Petarche (Od avstralija, normalno se znaj): Zdravo vnuce, mislam deka tochniot odgovor e pod C";
                } else
                {
                    label2.Text = "Vujko Petarche (Od avstralija, normalno se znaj): Zdravo vnuce, mislam deka tochniot odgovor e pod A";
                }

            } else
            {
                //Right Answer
                label2.Text = "Vujko Petarche (Od avstralija, normalno se znaj): Zdravo vnuce, mislam deka tochniot odgovor e pod " + this.rightAnswer;
            }


            button3.Enabled = false;
            button3.BackColor = Color.Red;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.timeLeft > 0)
            {
                this.timeLeft = this.timeLeft - 1;
                label1.Text = timeLeft + " seconds";
            } else
            {
                timer1.Stop();
                // The player actually lost, now the button is used for restarting!
                button1.Text = "You lost! The right answer was " + this.rightAnswer.ToString();
                button1.BackColor = Color.Red;
                button1.ForeColor = Color.White;

                button2.Enabled = false;
                button3.Enabled = false;

                button1.Enabled = true;

                this.playerLost = true;
            }
        }
    }
}
