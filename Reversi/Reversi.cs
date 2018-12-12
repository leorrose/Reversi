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
    
    public partial class Reversi : Form
    {
        Form Return_back;
        private int[,] arr = new int[8,8];
        int playerTurn =0;
        public Reversi(Form Return)
        {
            InitializeComponent();
            Lb_Player_turn.Text = Program.player1;
            Lb_player1.Text = Program.player1;
            Lb_player2.Text = Program.player2;
            Return_back = Return;
            for(int i=0; i<8; ++i)
            {
                for(int j=0; j<8; ++j)
                {
                   arr [i, j] = 0;
                }
            }
            arr[3, 3] = 2;
            arr[3, 4] = 1;
            arr[4, 3] = 1;
            arr[4, 4] = 2;
        }

        private void Print_table()
        {

            for (int i =1; i<= 64; ++i)
            {
                switch (i)
                {
                    case 1:
                        if (arr[0, 0] == 1)
                        {
                            pictureBox_A1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A1.BackgroundImageLayout = ImageLayout.Stretch; 
                        }
                        else if (arr[0, 0] == 2)
                        {
                            pictureBox_A1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 2:
                        if (arr[1, 0] == 1)
                        {
                            pictureBox_A2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 0] == 2)
                        {
                            pictureBox_A2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 3:
                        if (arr[2, 0] == 1)
                        {
                            pictureBox_A3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 0] == 2)
                        {
                            pictureBox_A3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 4:
                        if (arr[3, 0] == 1)
                        {
                            pictureBox_A4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 0] == 2)
                        {
                            pictureBox_A4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 5:
                        if (arr[4, 0] == 1)
                        {
                            pictureBox_A5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 0] == 2)
                        {
                            pictureBox_A5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 6:
                        if (arr[5, 0] == 1)
                        {
                            pictureBox_A6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 0] == 2)
                        {
                            pictureBox_A6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 7:
                        if (arr[6, 0] == 1)
                        {
                            pictureBox_A7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 0] == 2)
                        {
                            pictureBox_A7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 8:
                        if (arr[7, 0] == 1)
                        {
                            pictureBox_A8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_A8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 0] == 2)
                        {
                            pictureBox_A8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_A8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 9:
                        if (arr[0, 1] == 1)
                        {
                            pictureBox_B1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 1] == 2)
                        {
                            pictureBox_B1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 10:
                        if (arr[1, 1] == 1)
                        {
                            pictureBox_B2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 1] == 2)
                        {
                            pictureBox_B2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 11:
                        if (arr[2, 1] == 1)
                        {
                            pictureBox_B3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 1] == 2)
                        {
                            pictureBox_B3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 12:
                        if (arr[3, 1] == 1)
                        {
                            pictureBox_B4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 1] == 2)
                        {
                            pictureBox_B4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 13:
                        if (arr[4, 1] == 1)
                        {
                            pictureBox_B5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 1] == 2)
                        {
                            pictureBox_B5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 14:
                        if (arr[5, 1] == 1)
                        {
                            pictureBox_B6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 1] == 2)
                        {
                            pictureBox_B6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 15:
                        if (arr[6,1] == 1)
                        {
                            pictureBox_B7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6,1] == 2)
                        {
                            pictureBox_B7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 16:
                        if (arr[7, 1] == 1)
                        {
                            pictureBox_B8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_B8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 1] == 2)
                        {
                            pictureBox_B8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_B8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 17:
                        if (arr[0, 2] == 1)
                        {
                            pictureBox_C1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 2] == 2)
                        {
                            pictureBox_C1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 18:
                        if (arr[1, 2] == 1)
                        {
                            pictureBox_C2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 2] == 2)
                        {
                            pictureBox_C2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 19:
                        if (arr[2, 2] == 1)
                        {
                            pictureBox_C3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 2] == 2)
                        {
                            pictureBox_C3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 20:
                        if (arr[3, 2] == 1)
                        {
                            pictureBox_C4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 2] == 2)
                        {
                            pictureBox_C4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 21:
                        if (arr[4, 2] == 1)
                        {
                            pictureBox_C5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 2] == 2)
                        {
                            pictureBox_C5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 22:
                        if (arr[5, 2] == 1)
                        {
                            pictureBox_C6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5,2] == 2)
                        {
                            pictureBox_C6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 23:
                        if (arr[6, 2] == 1)
                        {
                            pictureBox_C7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 2] == 2)
                        {
                            pictureBox_C7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 24:
                        if (arr[7, 2] == 1)
                        {
                            pictureBox_C8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_C8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 2] == 2)
                        {
                            pictureBox_C8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_C8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 25:
                        if (arr[0, 3] == 1)
                        {
                            pictureBox_D1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 3] == 2)
                        {
                            pictureBox_D1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 26:
                        if (arr[1,3] == 1)
                        {
                            pictureBox_D2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 3] == 2)
                        {
                            pictureBox_D2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 27:
                        if (arr[2, 3] == 1)
                        {
                            pictureBox_D3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 3] == 2)
                        {
                            pictureBox_D3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 28:
                        if (arr[3, 3] == 1)
                        {
                            pictureBox_D4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 3] == 2)
                        {
                            pictureBox_D4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 29:
                        if (arr[4, 3] == 1)
                        {
                            pictureBox_D5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 3] == 2)
                        {
                            pictureBox_D5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 30:
                        if (arr[5, 3] == 1)
                        {
                            pictureBox_D6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 3] == 2)
                        {
                            pictureBox_D6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 31:
                        if (arr[6, 3] == 1)
                        {
                            pictureBox_D7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 3] == 2)
                        {
                            pictureBox_D7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 32:
                        if (arr[7, 3] == 1)
                        {
                            pictureBox_D8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_D8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 3] == 2)
                        {
                            pictureBox_D8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_D8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 33:
                        if (arr[0, 4] == 1)
                        {
                            pictureBox_E1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 4] == 2)
                        {
                            pictureBox_E1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 34:
                        if (arr[1, 4] == 1)
                        {
                            pictureBox_E2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 4] == 2)
                        {
                            pictureBox_E2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 35:
                        if (arr[2, 4] == 1)
                        {
                            pictureBox_E3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 4] == 2)
                        {
                            pictureBox_E3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 36:
                        if (arr[3, 4] == 1)
                        {
                            pictureBox_E4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 4] == 2)
                        {
                            pictureBox_E4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 37:
                        if (arr[4, 4] == 1)
                        {
                            pictureBox_E5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 4] == 2)
                        {
                            pictureBox_E5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 38:
                        if (arr[5, 4] == 1)
                        {
                            pictureBox_E6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 4] == 2)
                        {
                            pictureBox_E6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 39:
                        if (arr[6, 4] == 1)
                        {
                            pictureBox_E7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 4] == 2)
                        {
                            pictureBox_E7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 40:
                        if (arr[7, 4] == 1)
                        {
                            pictureBox_E8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_E8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 4] == 2)
                        {
                            pictureBox_E8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_E8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 41:
                        if (arr[0, 5] == 1)
                        {
                            pictureBox_F1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 5] == 2)
                        {
                            pictureBox_F1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 42:
                        if (arr[1, 5] == 1)
                        {
                            pictureBox_F2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 5] == 2)
                        {
                            pictureBox_F2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 43:
                        if (arr[2, 5] == 1)
                        {
                            pictureBox_F3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 5] == 2)
                        {
                            pictureBox_F3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 44:
                        if (arr[3, 5] == 1)
                        {
                            pictureBox_F4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 5] == 2)
                        {
                            pictureBox_F4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;

                    case 45:
                        if (arr[4, 5] == 1)
                        {
                            pictureBox_F5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 5] == 2)
                        {
                            pictureBox_F5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 46:
                        if (arr[5, 5] == 1)
                        {
                            pictureBox_F6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 5] == 2)
                        {
                            pictureBox_F6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 47:
                        if (arr[6, 5] == 1)
                        {
                            pictureBox_F7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 5] == 2)
                        {
                            pictureBox_F7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 48:
                        if (arr[7, 5] == 1)
                        {
                            pictureBox_F8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_F8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 5] == 2)
                        {
                            pictureBox_F8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_F8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 49:
                        if (arr[0, 6] == 1)
                        {
                            pictureBox_G1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 6] == 2)
                        {
                            pictureBox_G1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 50:
                        if (arr[1, 6] == 1)
                        {
                            pictureBox_G2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 6] == 2)
                        {
                            pictureBox_G2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 51:
                        if (arr[2, 6] == 1)
                        {
                            pictureBox_G3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 6] == 2)
                        {
                            pictureBox_G3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 52:
                        if (arr[3, 6] == 1)
                        {
                            pictureBox_G4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 6] == 2)
                        {
                            pictureBox_G4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 53:
                        if (arr[4, 6] == 1)
                        {
                            pictureBox_G5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 6] == 2)
                        {
                            pictureBox_G5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 54:
                        if (arr[5, 6] == 1)
                        {
                            pictureBox_G6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 6] == 2)
                        {
                            pictureBox_G6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 55:
                        if (arr[6, 6] == 1)
                        {
                            pictureBox_G7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 6] == 2)
                        {
                            pictureBox_G7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 56:
                        if (arr[7, 6] == 1)
                        {
                            pictureBox_G8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_G8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 6] == 2)
                        {
                            pictureBox_G8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_G8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 57:
                        if (arr[0, 7] == 1)
                        {
                            pictureBox_H1.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[0, 7] == 2)
                        {
                            pictureBox_H1.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H1.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 58:
                        if (arr[1, 7] == 1)
                        {
                            pictureBox_H2.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[1, 7] == 2)
                        {
                            pictureBox_H2.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H2.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 59:
                        if (arr[2, 7] == 1)
                        {
                            pictureBox_H3.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[2, 7] == 2)
                        {
                            pictureBox_H3.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H3.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 60:
                        if (arr[3, 7] == 1)
                        {
                            pictureBox_H4.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[3, 7] == 2)
                        {
                            pictureBox_H4.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H4.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 61:
                        if (arr[4, 7] == 1)
                        {
                            pictureBox_H5.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[4, 7] == 2)
                        {
                            pictureBox_H5.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H5.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 62:
                        if (arr[5, 7] == 1)
                        {
                            pictureBox_H6.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[5, 7] == 2)
                        {
                            pictureBox_H6.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H6.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 63:
                        if (arr[6, 7] == 1)
                        {
                            pictureBox_H7.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[6, 7] == 2)
                        {
                            pictureBox_H7.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H7.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                    case 64:
                        if (arr[7, 7] == 1)
                        {
                            pictureBox_H8.BackgroundImage = Properties.Resources.white_piece;
                            pictureBox_H8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        else if (arr[7, 7] == 2)
                        {
                            pictureBox_H8.BackgroundImage = Properties.Resources.Black_piece;
                            pictureBox_H8.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        break;
                }
                
            }
            sum();
        }

        private void pictureBox_H8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 7);
            pictureBox_H8.Enabled = false;
        }

        private void pictureBox_F8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 5);
            pictureBox_F8.Enabled = false;
        }

        private void pictureBox_E8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 4);
            pictureBox_E8.Enabled = false;
        }

        private void pictureBox_D8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 3);
            pictureBox_D8.Enabled = false;
        }

        private void picture_C8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 2);
            pictureBox_C8.Enabled = false;
        }

        private void picture_B8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 1);
            pictureBox_B8.Enabled = false;
        }

        private void picture_A8_Click(object sender, EventArgs e)
        {
            UpdateArr(7,0);
            pictureBox_A8.Enabled = false;
        }

        private void picture_A7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 0);
            pictureBox_A7.Enabled = false;
        }

        private void picture_B7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 1);
            pictureBox_B7.Enabled = false;
        }

        private void picture_C7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 2);
            pictureBox_C7.Enabled = false;
        }

        private void pictureBox_D7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 3);
            pictureBox_D7.Enabled = false;
        }

        private void pictureBox_E7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 4);
            pictureBox_E7.Enabled = false;
        }

        private void pictureBox_F7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 5);
            pictureBox_F7.Enabled = false;
        }

        private void pictureBox_G7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 6);
            pictureBox_G7.Enabled = false;
        }

        private void pictureBox_H7_Click(object sender, EventArgs e)
        {
            UpdateArr(6, 7);
            pictureBox_H7.Enabled = false;
        }

        private void pictureBox_H6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 7);
            pictureBox_H6.Enabled = false;

        }

        private void pictureBox_G6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 6);
            pictureBox_G6.Enabled = false;
        }

        private void pictureBox_F6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 5);
            pictureBox_F6.Enabled = false;
        }

        private void pictureBox_E6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 4);
            pictureBox_E6.Enabled = false;
        }

        private void pictureBox_D6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 3);
            pictureBox_D6.Enabled = false;
        }

        private void picture_C6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 2);
            pictureBox_C6.Enabled = false;
        }

        private void picture_B6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 1);
            pictureBox_B6.Enabled = false;
        }

        private void picture_A6_Click(object sender, EventArgs e)
        {
            UpdateArr(5, 0);
            pictureBox_A6.Enabled = false;
        }

        private void picture_A5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 0);
            pictureBox_A5.Enabled = false;
        }

        private void picture_B5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 1);
            pictureBox_B5.Enabled = false;
        }

        private void picture_C5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 2);
            pictureBox_C5.Enabled = false;
        }

        private void pictureBox_D5_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_E5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox_F5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 5);
            pictureBox_F5.Enabled = false;
        }

        private void pictureBox_H5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 7);
            pictureBox_H5.Enabled = false;
        }

        private void pictureBox_H4_Click(object sender, EventArgs e)
        {
            UpdateArr(3, 7);
            pictureBox_H4.Enabled = false;
        }

        private void pictureBox_G4_Click(object sender, EventArgs e)
        {
            UpdateArr(3, 6);
            pictureBox_G4.Enabled = false;
        }

        private void pictureBox_F4_Click(object sender, EventArgs e)
        {
            UpdateArr(3 ,5);
            pictureBox_F4.Enabled = false;
        }

        private void pictureBox_E4_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox_D4_Click(object sender, EventArgs e)
        {
           
        }

        private void picture_C4_Click(object sender, EventArgs e)
        {
            UpdateArr(3, 2);
            pictureBox_C4.Enabled = false;
        }

        private void picture_B4_Click(object sender, EventArgs e)
        {
            UpdateArr(3, 1);
            pictureBox_B4.Enabled = false;
        }

        private void picture_A4_Click(object sender, EventArgs e)
        {
            UpdateArr(3, 0);
            pictureBox_A4.Enabled = false;
        }

        private void picture_A3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 0);
            pictureBox_A3.Enabled = false;
        }

        private void picture_B3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 1);
            pictureBox_B3.Enabled = false;
        }

        private void picture_C3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 2);
            pictureBox_C3.Enabled = false;
        }

        private void pictureBox_D3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 3);
            pictureBox_D3.Enabled = false;
        }

        private void pictureBox_E3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 4);
            pictureBox_E3.Enabled = false;
        }

        private void pictureBox_F3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 5);
            pictureBox_F3.Enabled = false;
        }

        private void pictureBox_G3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 6);
            pictureBox_G3.Enabled = false;
        }

        private void pictureBox_H3_Click(object sender, EventArgs e)
        {
            UpdateArr(2, 7);
            pictureBox_H3.Enabled = false;
        }

        private void pictureBox_H2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 7);
            pictureBox_H2.Enabled = false;
        }

        private void pictureBox_H1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 7);
            pictureBox_H1.Enabled = false;
        }

        private void pictureBox_G1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 6);
            pictureBox_G1.Enabled = false;
        }

        private void pictureBox_G2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 6);
            pictureBox_G2.Enabled = false;
        }

        private void pictureBox_F1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 5);
            pictureBox_F1.Enabled = false;
        }

        private void pictureBox_F2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 5);
            pictureBox_F2.Enabled = false;
        }

        private void pictureBox_E2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 4);
            pictureBox_E2.Enabled = false;
        }

        private void pictureBox_E1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 4);
            pictureBox_E1.Enabled = false;
        }

        private void pictureBox_D1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 3);
            pictureBox_D1.Enabled = false;
        }

        private void pictureBox_D2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 3);
            pictureBox_D2.Enabled = false;
        }

        private void picture_C2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 2);
            pictureBox_C2.Enabled = false;
        }

        private void picture_C1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 2);
            pictureBox_C1.Enabled = false;
        }

        private void picture_B1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 1);
            pictureBox_B1.Enabled = false;
        }

        private void picture_B2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 1);
            pictureBox_B2.Enabled = false;
        }

        private void picture_A2_Click(object sender, EventArgs e)
        {
            UpdateArr(1, 0);
            pictureBox_A2.Enabled = false;
        }

        private void picture_A1_Click(object sender, EventArgs e)
        {
            UpdateArr(0, 0);
            pictureBox_A1.Enabled = false;
        }

        private void pictureBox_G8_Click(object sender, EventArgs e)
        {
            UpdateArr(7, 6);
            pictureBox_G8.Enabled = false;
        }

        private void pictureBox_G5_Click(object sender, EventArgs e)
        {
            UpdateArr(4, 6);
            pictureBox_G5.Enabled = false;
        }
        private void UpdateArr(int i, int j)
        {
            if (playerTurn % 2 == 0)
            {
                Lb_Player_turn.Text = Program.player2;
                arr[i, j] = 1; //white
                FixArr(i, j, 1);
            }
            else
            {
                Lb_Player_turn.Text = Program.player1;
                arr[i, j] = 2; //black
                FixArr(i, j, 2);
            }
            playerTurn += 1;
            Print_table();
            EndGame();
        }
        private void sum()
        {
            int Sum1 = 0, Sum2 = 0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (arr[i, j] == 1)
                        Sum1 += 1;
                    else if (arr[i, j] == 2)
                        Sum2 += 1;
                }
            }
            Lb_Score1.Text = Sum1.ToString();
            Lb_Score2.Text = Sum2.ToString();
        }



        private void FixArr(int i , int j, int player)
        {
            Up_col_check(i, j, player);
            Down_col_check(i,j, player);
            right_row_check(i, j, player);
            Left_row_check(i, j, player);
            Left_Up_slant_check(i,  j, player);
            Right_Up_slant_check(i, j,player);
            left_Down_slant_check(i,j,player);
            Right_Down_slant_check(i,j,player);

         }
        private void Up_col_check(int i,int j,int player)
        {
            int index = -1, flag = 0;
            for (int k=i-1; k>=0; --k)
            {
                if (arr[k, j] == player && flag!=1 )
                {
                    index = k;
                    flag = 1;
                }
                else if( arr[k, j] == 0 && flag!=1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k<i; ++k)
                {
                    arr[k, j] = player;
                }
            }
        }
        private void Down_col_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = i + 1; k <=7; ++k)
            {
                if (arr[k, j] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[k, j] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k > i; --k)
                {
                    arr[k, j] = player;
                }
            }
        }
        private void right_row_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = j + 1; k <= 7; ++k)
            {
                if (arr[i, k] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[i, k] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k > j; --k)
                {
                    arr[i, k] = player;
                }
            }
        }
        private void Left_row_check(int i, int j, int player)
        {
            int index = -1, flag = 0;
            for (int k = j - 1; k >= 0; --k)
            {
                if (arr[i, k] == player && flag != 1)
                {
                    index = k;
                    flag = 1;
                }
                else if (arr[i, k] == 0 && flag != 1)
                {
                    index = -1;
                    flag = 1;
                }
            }
            if (index != -1)
            {
                for (int k = index; k < j; ++k)
                {
                    arr[i, k] = player;
                }
            }
        }
        private void Left_Up_slant_check(int i, int j, int player)
        {
            int indexX = -1,indexY=-1, flag = 0;
            for (int k = i - 1,z=j-1; k >= 0 && z>=0; --k,--z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY!=-1)
            {
                for (int k = indexX,z=indexY; k <i && z< j; ++k, ++z)
                {
                    arr[k, z] = player;
                }
            }
        }
        private void Right_Up_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i - 1, z = j + 1; k >= 0 && z <= 7; --k, ++z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k < i && z > j; ++k, --z)
                {
                    arr[k, z] = player;
                }
            }
        }
        private void left_Down_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i + 1, z = j - 1; k <= 7 && z >= 0; ++k, --z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k > i && z < j; --k, ++z)
                {
                    arr[k, z] = player;
                }
            }
        }
        private void Right_Down_slant_check(int i, int j, int player)
        {
            int indexX = -1, indexY = -1, flag = 0;
            for (int k = i + 1, z = j + 1; k <= 7 && z <= 7; ++k, ++z)
            {
                if (arr[k, z] == player && flag != 1)
                {
                    indexX = k;
                    indexY = z;
                    flag = 1;
                }
                else if (arr[k, z] == 0 && flag != 1)
                {
                    indexX = -1;
                    indexY = -1;
                    flag = 1;
                }
            }
            if (indexX != -1 && indexY != -1)
            {
                for (int k = indexX, z = indexY; k > i && z > j; --k, --z)
                {
                    arr[k, z] = player;
                }
            }
        }
        private void EndGame()
        {
            int Sum1 = 0, Sum2 = 0,flag=0;
            for (int i = 0; i < 8; ++i)
            {
                for (int j = 0; j < 8; ++j)
                {
                    if (arr[i, j] == 1)
                        Sum1 += 1;
                    else if (arr[i, j] == 2)
                        Sum2 += 1;
                    else
                        flag= 1;
                  
                }
            }
            if (flag == 0)
            {
                if (Sum1 > Sum2)
                {
                    Winner Newwinner = new Winner(Program.player1,Return_back,this);
                    Newwinner.Show();
                }
                else if (Sum2 > Sum1)
                {
                    Winner Newwinner = new Winner(Program.player2,Return_back,this);
                    Newwinner.Show();
                }
                else
                {
                    Winner Newwinner = new Winner("Its a tie!!",Return_back,this);
                    Newwinner.Show();
                }
                
            }
        }



        private void Bt_Reversi_back_click(object sender, EventArgs e)
        {
            this.Close();
            Return_back.Show();
        }

        private void Bt_Reversi_Exit_click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to leave?", "Leave Game?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void Bt_reversi_instuctions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instruction Newins = new Instruction(this);
            Newins.Show();
        }
    }
}
