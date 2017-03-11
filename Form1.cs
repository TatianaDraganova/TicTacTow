using System;
using System.Windows.Forms;

namespace TicTacTow
{
	public partial class Form1 : Form
	{
		private int player = 1;
		private int p1 = 0;
		private int p2 = 0;
		private int q = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;
			btn.Enabled = false;
			if (player % 2 == 1)
			{
				btn.Text = @"X";
			}
			else if (player % 2 == 0)
			{
				btn.Text = @"0";
			}
			int result = CheckWin();

			if (result == 1)
			{
				if (player % 2 == 1)
				{
					LB.Text = "Победили крестики";
					p1++;
					TboxX.Text = p1.ToString();
					q++;
					textBox3.Text = q.ToString();

				}
				else if (player % 2 == 0)
				{
					LB.Text = "Победили нолики";

					p2++;
					TboxO.Text = p2.ToString();
					q++;
					textBox3.Text = q.ToString();
				}
			}
			else if (result == -1)
			{
				LB.Text = "Ничья";
				q++;
				textBox3.Text = q.ToString();

			}
			player++;
		}

		private int CheckWin()
		{
			#region Horzontal Winning Condtion
			//Winning Condition For First Row   
			if (b1.Text == b7.Text && b7.Text == b6.Text)
			{
				return 1;
			}
			//Winning Condition For Second Row   
			else if (b5.Text == b4.Text && b4.Text == b3.Text)
			{
				return 1;
			}
			//Winning Condition For Third Row   
			else if (b2.Text == b9.Text && b9.Text == b8.Text)
			{
				return 1;
			}
			#endregion

			#region vertical Winning Condtion
			//Winning Condition For First Column       
			else if (b1.Text == b5.Text && b5.Text == b2.Text)
			{
				return 1;
			}
			//Winning Condition For Second Column  
			else if (b7.Text == b4.Text && b4.Text == b9.Text)
			{
				return 1;
			}
			//Winning Condition For Third Column  
			else if (b6.Text == b3.Text && b3.Text == b8.Text)
			{
				return 1;
			}
			#endregion

			#region Diagonal Winning Condition
			else if (b1.Text == b4.Text && b4.Text == b8.Text)
			{
				return 1;
			}
			else if (b6.Text == b4.Text && b4.Text == b2.Text)
			{
				return 1;
			}
			#endregion

			#region Checking For Draw
			// If all the cells or values filled with X or O then any player has won the match  
			else if (b1.Text != "1" && b7.Text != "7" && b6.Text != "6" && b5.Text != "5" && b4.Text != "4" && b3.Text != "3" && b2.Text != "2" && b9.Text != "9" && b8.Text != "8")
			{
				return -1;
			}
			#endregion

			else
			{
				return 0;
			}


		}

		private void Playagain_Click(object sender, EventArgs e)
		{
			player = 1;

			b1.Enabled = true; 
			b2.Enabled = true; 
			b3.Enabled = true; 
			b4.Enabled = true; 
			b5.Enabled = true; 
			b6.Enabled = true; 
			b7.Enabled = true; 
			b8.Enabled = true;
			b9.Enabled = true;

			b1.Text = "1";
			b2.Text = "2";
			b3.Text = "3";
			b4.Text = "4";
			b5.Text = "5";
			b6.Text = "6";
			b7.Text = "7";
			b8.Text = "8";
			b9.Text = "9";
			LB.Text = "";
			MessageBox.Show("Новая игра");

		}
	}
}
