using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN_v2
{
    public partial class Form2 : Form
    {
        public SocketManager SOCKET;
        public Form1 form1;
        public ChessBoard CHESSBOARD;

        public Form2(bool isHostGame, SocketManager socket, Form1 form1, string IP = null)
        {
            InitializeComponent();
            SOCKET = socket;
            this.form1 = form1;

            CHESSBOARD = new ChessBoard(this.Panel_ChessBoard, this, isHostGame);

            CHESSBOARD.BoardChecked += CHESSBOARD_BoardChecked;
            CHESSBOARD.Game_over += CHESSBOARD_Game_over;

            CHESSBOARD.DrawChessBoard();

        }

        private void CHESSBOARD_Game_over(object sender, EventArgs e)
        {
            Endgame();
        }

        private void CHESSBOARD_BoardChecked(object sender, EventArgs e)
        {
            coolDownBar.Value = 0;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SocketData Test_Data = new SocketData((int)SocketCommand.NOTIFY, new Point(), "ahaha");
            SOCKET.Send(Test_Data);
        }


        public void sendInformation()
        {
            Thread sendInforThread = new Thread(() => 
            {
                SocketData MyInfor = new SocketData((int)SocketCommand.FIRST_CONNECT, new Point(),form1.MainPlayer.Nickname.ToString());
                SOCKET.Send(MyInfor);
            });
            sendInforThread.IsBackground = true;
            sendInforThread.Start();
        }

        public void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(10);
                    try
                    {
                        SocketData Dataset = (SocketData)SOCKET.Receive();
                        //MessageBox.Show(message);
                        ConvertSocketDataReceived(Dataset);
                        Listen();
                        break;
                    }
                    catch (Exception)
                    {


                    }
                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        public void Endgame()
        {
            timer1.Stop();
            if (CHESSBOARD.isTurnForMe)
            {
                if (MessageBox.Show("You looseeeeeeeee !!!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    //NewGame();
                }
            }
            else
            {
                if (MessageBox.Show("You Winnnnnnnnnnn !!!", "", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    //NewGame();
                }
            }
        }


        public void ConvertSocketDataReceived(SocketData Data)
        {
            switch (Data.command)
            {
                case (int)SocketCommand.FIRST_CONNECT:
                    label_NameGuest.Text = Data.message.ToString();
                    label_NameMain.Text = form1.MainPlayer.Nickname.ToString();
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        coolDownBar.Value = 0;
                        CHESSBOARD.GuestMark(Data.point);
                    }));

                    break;
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(Data.message.ToString());
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        //CHESSBOARD.NewGame();
                        if(MessageBox.Show("Your partner want to make new match, Continue?", "", MessageBoxButtons.YesNo)==DialogResult.Yes)
                        {
                            SocketData data = new SocketData((int)SocketCommand.ACCEPT, new Point());
                            SOCKET.Send(data);
                            CHESSBOARD.NewGame();
                        }
                        else
                        {
                            SocketData data = new SocketData((int)SocketCommand.IGNORE, new Point());
                            SOCKET.Send(data);
                            MessageBox.Show("New match request is aborted.");
                        }
                    }));
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    break;
                case (int)SocketCommand.ACCEPT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("Your partner accept new match");
                        CHESSBOARD.NewGame();
                    }));
                    break;
                case (int)SocketCommand.IGNORE:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("Your partner ignore new match");
                    }));
                    break;
            }
        }

        private void vánMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Waitting Request...");
            //CHESSBOARD.NewGame();
            SocketData data = new SocketData((int)SocketCommand.NEW_GAME, new Point());
            SOCKET.Send(data);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            coolDownBar.PerformStep();
            if (coolDownBar.Value == coolDownBar.Maximum)
            {
                Endgame();
            }
        }
    }
}
