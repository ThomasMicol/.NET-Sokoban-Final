using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1___Thomas_Micol
{
    public partial class Form1 : Form, IView
    {
        protected GameController theCtrl;
        protected Button btn_startGame;
        protected Button btn_newGame;
        protected Button btn_loadGame;
        protected List<Button> myElements = new List<Button>();


        public Form1()
        {
            InitializeComponent();

        }

        public void DrawGameControls()
        {
            throw new NotImplementedException();
        }

        public void DisplayMenu()
        {
            this.btn_startGame = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_loadGame = new System.Windows.Forms.Button();

            this.btn_startGame.Location = new System.Drawing.Point(91, 12);
            this.btn_startGame.Name = "button1";
            this.btn_startGame.Size = new System.Drawing.Size(93, 34);
            this.btn_startGame.TabIndex = 0;
            this.btn_startGame.Text = "Start Game";
            this.btn_startGame.UseVisualStyleBackColor = true;

            this.btn_newGame.Location = new System.Drawing.Point(91, 81);
            this.btn_newGame.Name = "button2";
            this.btn_newGame.Size = new System.Drawing.Size(93, 34);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.button2_Click);

            this.btn_loadGame.Location = new System.Drawing.Point(91, 151);
            this.btn_loadGame.Name = "button3";
            this.btn_loadGame.Size = new System.Drawing.Size(93, 34);
            this.btn_loadGame.TabIndex = 2;
            this.btn_loadGame.Text = "Load Game";
            this.btn_loadGame.UseVisualStyleBackColor = true;

            this.Controls.Add(this.btn_startGame);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);

        }

        public void SetController(GameController aCtrl)
        {
            theCtrl = aCtrl;
        }

        public void RedrawLevel()
        {

        }

        public void DisplaySystemMessage(string msg)
        {

        }

        public void PlayWinningSound()
        {

        }

        public void ClearForm()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
