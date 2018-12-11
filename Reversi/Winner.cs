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
    public partial class Winner : Form
    {
        Form return_back,game;
        public Winner(string name,Form Return,Form reversi)
        {
            InitializeComponent();
            return_back = Return;
            game = reversi;
            Lb_winner.Text = name;
        }

        private void Bt_continue_Click(object sender, EventArgs e)
        {
            this.Close();
            game.Close();
            return_back.Show();
        }
    }
}
