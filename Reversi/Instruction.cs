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
    public partial class Instruction : Form
    {
        Form return_back;
        public Instruction(Form back)
        {
            InitializeComponent();
            return_back = back;
            label1.Text = "On your turn, you place one piece on the board with your color.\r\nYou must place the piece so that an opponent's piece, or a row of opponent's pieces, is flanked by your pieces. \r\nAll of the opponent's pieces between your pieces are then turned over to become your color. \r\nThe object of the game is to own more pieces than your opponent when the game is over. \r\nThe game is over when neither player has a move. Usually, this means the board is full. \r\n";

        }

        private void Bt_ins_continue_Click(object sender, EventArgs e)
        {
            this.Close();
            return_back.Show();
        }
    }
}
