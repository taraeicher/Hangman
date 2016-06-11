using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/*Project Number: HangmanGame
 *Date: 1 March 2011
 *Programmer Name: Tara Eicher
 *Program Description: This program allows two users to play a virtual game of hangman. The first player's
 *      entry is the basis for comparison. Multiple-letter entries are not permitted. Incorrect and correct 
 *      entries are displayed. Individual games may not be saved. Allow multiple games.
 */

namespace Hangman
{
    public partial class frmHangman : Form
    {
        string strWord, strSecret = ""; //input player one
        string strGuess; //input player two
        string strGuesses=""; //accumulate incorrect entries
        const string strEnter = "Enter Word";         //display in text boxes
        const string strEnterGuess = "Enter Guess";
        int intLength, intNumGuess=0;  //length input word, num incorrect guesses
        public frmHangman()
        {
            InitializeComponent();
        }

        private void btnWord_Click(object sender, EventArgs e)  //first player entry
        {
            if (txtBxWord.Text != strEnter)
            {
                btnPlay.Visible = true;
                btnPlay.TabStop = true;         //user must select Play to continue
                this.AcceptButton = btnPlay;
                btnPlay.Focus();
                strWord = txtBxWord.Text;
                strWord = strWord.ToLower();
                txtBxWord.Text = "";    //clear entry
                lblWord.Enabled = false;   //may not enter another word
                txtBxWord.Enabled = false;
                btnWord.Enabled = false;
                intLength = strWord.Length;  //display one dash for each character in word
                for (int i = 0; i < intLength; ++i)
                {
                    strSecret += "-";
                    txtBxSecret.Text = strSecret;
                }
            }
            else  //require entry
            {
                MessageBox.Show("You must enter a word.");
                lblWord.Focus();
            }            
        }

        private void btnGo_Click(object sender, EventArgs e)  //Handle player 2's guess
        {
            string strNumGuess= "Incorrect Guesses: ";  //for display
            int intIndex;
            strGuess = txtBxGuess.Text;
            strGuess = strGuess.ToLower();
            if (strGuess.IndexOf(strEnterGuess)<0)  //if user has entered something
            {
                txtBxGuess.Text = strEnterGuess;       //set for next entry 
                txtBxGuess.ForeColor = Color.Gray;
                txtBxGuess.Focus();
                if (strGuess.Length == 1)   //only allow one character at a time
                {
                    intIndex = strWord.IndexOf(strGuess);
                    if (intIndex != -1)  //if guess is correct
                    {
                        do  //display each instance of character
                        {
                            strSecret = strSecret.Remove(intIndex, 1);
                            strSecret = strSecret.Insert(intIndex, strGuess);
                            txtBxSecret.Text = strSecret;
                            intIndex = strWord.IndexOf(strGuess, intIndex + 1);
                        }
                        while (intIndex != -1);
                    }
                    else  //if guess is incorrect
                    {
                        ++intNumGuess;  
                        int intCheck = strGuesses.IndexOf(strGuess); 
                        if (intCheck < 0) //has not already been guessed
                        {
                            strGuesses += strGuess;  //display this character as incorrect
                            txtBxIncorrect.Text = strGuesses + "\n\n" + strNumGuess + intNumGuess.ToString();
                            picBxBase.Visible = true;  //display corresponding piece of picture
                            if (intNumGuess > 1)
                            {
                                picBxTallVert.Visible = true;
                                if (intNumGuess > 2)
                                {
                                    picBxHorizontal.Visible = true;
                                    if (intNumGuess > 3)
                                    {
                                        picBxShortVert.Visible = true;
                                        if (intNumGuess > 4)
                                        {
                                            picBxHead.Visible = true;
                                            if (intNumGuess > 5)
                                            {
                                                picBxBody.Visible = true;
                                                if (intNumGuess > 6)
                                                {
                                                    picBxRightArm.Visible = true;
                                                    if (intNumGuess > 7)
                                                    {
                                                        picBxLeftArm.Visible = true;
                                                        if (intNumGuess > 8)
                                                        {
                                                            picBxRightLeg.Visible = true;
                                                            if (intNumGuess > 9)
                                                            {
                                                                picBxLeftLeg.Visible = true;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("You have already guessed that letter.");
                        }

                    }
                    if (strSecret.Equals(strWord))  //if user has won
                    {
                        lblWinLose.ForeColor = Color.Red;
                        lblWinLose.Text = "You Win!";
                        lblGuess.Enabled = false;  //allow Play Again or Exit
                        txtBxGuess.Enabled = false;
                        btnGo.Enabled = false;
                        btnAgain.Visible = true;
                        btnAgain.Focus();
                    }
                    else if (intNumGuess > 9)  //if user has lost
                    {
                        lblWinLose.ForeColor = Color.Blue;
                        lblWinLose.Text = "You Lose.";
                        lblGuess.Enabled = false;  //allow Play Again or Exit
                        txtBxGuess.Enabled = false;
                        btnGo.Enabled = false;
                        btnAgain.Visible = true;
                        btnAgain.Focus();
                    }
                }
                else
                    MessageBox.Show("You must enter one letter at a time.");
            }
            else
                MessageBox.Show("You must enter a guess."); 
            lblGuess.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)  //Player 2's turn
        {
            btnPlay.Visible = false;  //bring attention to Player 2 controls
            this.AcceptButton = btnGo;
            lblGuess.Enabled = true;
            txtBxGuess.Enabled = true;
            txtBxGuess.TabStop = true;
            txtBxGuess.Focus();
            btnGo.TabStop = true;
            btnGo.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e) //close and exit program
        {
            this.Close();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
                picBxBase.Visible=false;       //hide all pieces of picture
                picBxTallVert.Visible=false;
                picBxHorizontal.Visible=false;
                picBxShortVert.Visible=false;
                picBxHead.Visible=false;
                picBxLeftArm.Visible=false;
                picBxRightArm.Visible = false;
                picBxBody.Visible = false;
                picBxLeftLeg.Visible = false;
                picBxRightLeg.Visible = false;
                lblGuess.Enabled=false;        //disable Player 2 controls
                txtBxGuess.Enabled=false;
                txtBxGuess.TabStop=false;
                btnGo.Enabled=false;
                btnGo.TabStop=false;
                lblWord.Enabled=true;               //Player 1's turn
                txtBxWord.Enabled=true;
                txtBxWord.TabStop=true;
                txtBxWord.Text = strEnter;
                txtBxWord.ForeColor = Color.Gray;
                btnWord.Enabled=true;
                btnWord.TabStop=true;
                btnPlay.Visible=false;
                btnAgain.Visible=false;
                lblWinLose.Text="";             //hide results of last game
                txtBxIncorrect.Text = "";
                txtBxSecret.Text="";
                strSecret = "";         //clear storage
                strGuesses = "";
                intNumGuess = 0;
        }

        private void txtBxWord_TextChanged(object sender, EventArgs e) //change font color 
        {
            this.AcceptButton = btnWord; 
            txtBxWord.ForeColor = Color.Black;
        }

        private void txtBxGuess_TextChanged(object sender, EventArgs e)  //change font color    
        {
            this.AcceptButton = btnGo;
            txtBxGuess.ForeColor = Color.Black;
        }
    }
}
