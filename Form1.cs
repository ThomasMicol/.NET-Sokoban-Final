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

        protected Button btn_moveUp;
        protected Button btn_moveLeft;
        protected Button btn_moveDown;
        protected Button btn_moveRight;

        protected Button btn_undoMove;
        protected Button btn_redoMove;

        protected Button btn_resetLevel;
        protected Button btn_saveState;

        protected Button btn_exit;


        protected List<Control> myElements = new List<Control>();


        public Form1()
        {
            InitializeComponent();

        }

        public void DrawGameControls()
        {
            this.btn_startGame = new System.Windows.Forms.Button();
            this.btn_newGame = new System.Windows.Forms.Button();
            this.btn_loadGame = new System.Windows.Forms.Button();

            this.btn_startGame.Location = new System.Drawing.Point(91, 12);
            this.btn_startGame.Size = new System.Drawing.Size(93, 34);
            this.btn_startGame.Text = "Start Game";
            this.btn_startGame.UseVisualStyleBackColor = true;
            this.btn_startGame.Click += new System.EventHandler(this.StartGame_Click);

            this.btn_newGame.Location = new System.Drawing.Point(91, 81);
            this.btn_newGame.Size = new System.Drawing.Size(93, 34);
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.NewGame_Click);

            this.btn_loadGame.Location = new System.Drawing.Point(91, 151);
            this.btn_loadGame.Size = new System.Drawing.Size(93, 34);
            this.btn_loadGame.Text = "Load Game";
            this.btn_loadGame.UseVisualStyleBackColor = true;
            this.btn_loadGame.Click += new System.EventHandler(this.LoadGame_Click);

            this.Controls.Add(this.btn_startGame);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);
            myElements.Add(btn_loadGame);
            myElements.Add(btn_newGame);
            myElements.Add(btn_startGame);
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
            this.btn_startGame.Click += new System.EventHandler(this.StartGame_Click);

            this.btn_newGame.Location = new System.Drawing.Point(91, 81);
            this.btn_newGame.Name = "button2";
            this.btn_newGame.Size = new System.Drawing.Size(93, 34);
            this.btn_newGame.TabIndex = 1;
            this.btn_newGame.Text = "New Game";
            this.btn_newGame.UseVisualStyleBackColor = true;
            this.btn_newGame.Click += new System.EventHandler(this.NewGame_Click);

            this.btn_loadGame.Location = new System.Drawing.Point(91, 151);
            this.btn_loadGame.Name = "button3";
            this.btn_loadGame.Size = new System.Drawing.Size(93, 34);
            this.btn_loadGame.TabIndex = 2;
            this.btn_loadGame.Text = "Load Game";
            this.btn_loadGame.UseVisualStyleBackColor = true;
            this.btn_loadGame.Click += new System.EventHandler(this.LoadGame_Click);

            this.Controls.Add(this.btn_startGame);
            this.Controls.Add(this.btn_loadGame);
            this.Controls.Add(this.btn_newGame);
            myElements.Add(btn_loadGame);
            myElements.Add(btn_newGame);
            myElements.Add(btn_startGame);

        }

        private void LoadGame_Click(object sender, EventArgs e)
        {
            theCtrl.LoadLevel("ay");
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            theCtrl.StartGameFromLastState();
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
            foreach(Control element in myElements)
            {
                element.Visible = false;
                element.Hide();
            }
            myElements.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            theCtrl.StartNewGame();
        }
    }
}
