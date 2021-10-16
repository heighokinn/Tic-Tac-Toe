using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TickTackToe
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		public bool firstPlayer = true;
		public void stopGame()
		{
			button1.Enabled = false;
			button2.Enabled = false;
			button3.Enabled = false;
			button4.Enabled = false;
			button5.Enabled = false;
			button6.Enabled = false;
			button7.Enabled = false;
			button8.Enabled = false;
			button9.Enabled = false;
		}
		public void checkWinFirstPlayer()
		{
			if (button1.Text == "x" && button2.Text == "x" && button3.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button4.Text == "x" && button5.Text == "x" && button6.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button7.Text == "x" && button8.Text == "x" && button9.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button1.Text == "x" && button4.Text == "x" && button7.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button2.Text == "x" && button5.Text == "x" && button8.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button3.Text == "x" && button6.Text == "x" && button9.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button1.Text == "x" && button5.Text == "x" && button9.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
			else if (button3.Text == "x" && button5.Text == "x" && button7.Text == "x")
			{
				firstWon.Visible = true;
				stopGame();
			}
		}
		public void checkWinSecondPlayer()
		{
			if (button1.Text == "o" && button2.Text == "o" && button3.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button4.Text == "o" && button5.Text == "o" && button6.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button7.Text == "o" && button8.Text == "o" && button9.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button1.Text == "o" && button4.Text == "o" && button7.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button2.Text == "o" && button5.Text == "o" && button8.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button3.Text == "o" && button6.Text == "o" && button9.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button1.Text == "o" && button5.Text == "o" && button9.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
			else if (button3.Text == "o" && button5.Text == "o" && button7.Text == "o")
			{
				secondWon.Visible = true;
				stopGame();
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (firstPlayer)
			{
				sender.GetType().GetProperty("Text").SetValue(sender, "x"); 
				checkWinFirstPlayer();
				label1.Text = "Ходит второй игрок.";
			}
			if (!firstPlayer)
			{
				sender.GetType().GetProperty("Text").SetValue(sender, "o");
				checkWinSecondPlayer();
				label1.Text = "Ходит первый игрок.";
			}
			firstPlayer = !firstPlayer;
			sender.GetType().GetProperty("Enabled").SetValue(sender, false);
		}

		private void button10_Click(object sender, EventArgs e)
		{
			button1.Enabled = true;
			button2.Enabled = true;
			button3.Enabled = true;
			button4.Enabled = true;
			button5.Enabled = true;
			button6.Enabled = true;
			button7.Enabled = true;
			button8.Enabled = true;
			button9.Enabled = true;

			firstWon.Visible = false;
			secondWon.Visible = false;

			label1.Text = "Ходит первый игрок.";

			button1.Text = "";
			button2.Text = "";
			button3.Text = "";
			button4.Text = "";
			button5.Text = "";
			button6.Text = "";
			button7.Text = "";
			button8.Text = "";
			button9.Text = "";
		}
	}
}
