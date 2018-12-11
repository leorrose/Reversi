using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reversi
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void Bt_continue_Click(object sender, EventArgs e)
        {
            if(Tb_Player1.Text.Length != 0)
            {
                if(Tb_player2.Text.Length != 0)
                {
                    Program.player1 = Tb_Player1.Text;
                    Program.player2 = Tb_player2.Text;
                    this.Hide();
                    Reversi NewGame = new Reversi(this);
                    NewGame.Show();
                    Tb_Player1.Text = "";
                    Tb_player2.Text = "";
                }
                else
                    MessageBox.Show("No name - Player 2!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("No name - Player 1!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Bt_login_exit_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to leave?", "Leave Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
