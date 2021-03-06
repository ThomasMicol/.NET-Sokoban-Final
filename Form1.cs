﻿using System;
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
            this.btn_moveUp = new System.Windows.Forms.Button();
            this.btn_moveLeft = new System.Windows.Forms.Button();
            this.btn_moveDown = new System.Windows.Forms.Button();
            this.btn_moveRight = new System.Windows.Forms.Button();
            this.btn_undoMove = new System.Windows.Forms.Button();
            this.btn_redoMove = new System.Windows.Forms.Button();
            this.btn_resetLevel = new System.Windows.Forms.Button();
            this.btn_saveState = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();

            this.btn_moveUp.Location = new System.Drawing.Point(760, 602 - 36);
            this.btn_moveUp.Size = new System.Drawing.Size(58, 34);
            this.btn_moveUp.Text = "UP";
            this.btn_moveUp.UseVisualStyleBackColor = true;
            this.btn_moveUp.Click += new System.EventHandler(this.moveUp_Click);

            this.btn_moveLeft.Location = new System.Drawing.Point(760 - 60, 602);
            this.btn_moveLeft.Size = new System.Drawing.Size(58, 34);
            this.btn_moveLeft.Text = "LEFT";
            this.btn_moveLeft.UseVisualStyleBackColor = true;
            this.btn_moveLeft.Click += new System.EventHandler(this.moveLeft_Click);

            this.btn_moveDown.Location = new System.Drawing.Point(760, 602);
            this.btn_moveDown.Size = new System.Drawing.Size(58, 34);
            this.btn_moveDown.Text = "DOWN";
            this.btn_moveDown.UseVisualStyleBackColor = true;
            this.btn_moveDown.Click += new System.EventHandler(this.moveDown_Click);

            this.btn_moveRight.Location = new System.Drawing.Point(760 + 60, 602);
            this.btn_moveRight.Size = new System.Drawing.Size(58, 34);
            this.btn_moveRight.Text = "RIGHT";
            this.btn_moveRight.UseVisualStyleBackColor = true;
            this.btn_moveRight.Click += new System.EventHandler(this.moveRight_Click);

            this.btn_undoMove.Location = new System.Drawing.Point(760 - 140, 602);
            this.btn_undoMove.Size = new System.Drawing.Size(58, 34);
            this.btn_undoMove.Text = "Undo";
            this.btn_undoMove.UseVisualStyleBackColor = true;
            this.btn_undoMove.Click += new System.EventHandler(this.undoMove_Click);

            this.btn_redoMove.Location = new System.Drawing.Point(760 - 140, 602 - 36);
            this.btn_redoMove.Size = new System.Drawing.Size(58, 34);
            this.btn_redoMove.Text = "Redo";
            this.btn_redoMove.UseVisualStyleBackColor = true;
            this.btn_redoMove.Click += new System.EventHandler(this.redoMove_Click);

            this.btn_resetLevel.Location = new System.Drawing.Point(131, 602 - 36);
            this.btn_resetLevel.Size = new System.Drawing.Size(93, 34);
            this.btn_resetLevel.Text = "Reset Level";
            this.btn_resetLevel.UseVisualStyleBackColor = true;
            this.btn_resetLevel.Click += new System.EventHandler(this.resetLevel_Click);

            this.btn_saveState.Location = new System.Drawing.Point(131, 602);
            this.btn_saveState.Size = new System.Drawing.Size(93, 34);
            this.btn_saveState.Text = "Save Game";
            this.btn_saveState.UseVisualStyleBackColor = true;
            this.btn_saveState.Click += new System.EventHandler(this.saveGame_Click);

            this.btn_exit.Location = new System.Drawing.Point(31, 602);
            this.btn_exit.Size = new System.Drawing.Size(93, 34);
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.exit_Click);


            this.Controls.Add(this.btn_moveUp);
            this.Controls.Add(this.btn_moveLeft);
            this.Controls.Add(this.btn_moveDown);
            this.Controls.Add(this.btn_moveRight);
            this.Controls.Add(this.btn_undoMove);
            this.Controls.Add(this.btn_redoMove);
            this.Controls.Add(this.btn_resetLevel);
            this.Controls.Add(this.btn_saveState);
            this.Controls.Add(this.btn_exit);

            this.myElements.Add(this.btn_moveUp);
            this.myElements.Add(this.btn_moveLeft);
            this.myElements.Add(this.btn_moveDown);
            this.myElements.Add(this.btn_moveRight);
            this.myElements.Add(this.btn_undoMove);
            this.myElements.Add(this.btn_redoMove);
            this.myElements.Add(this.btn_resetLevel);
            this.myElements.Add(this.btn_saveState);
            this.myElements.Add(this.btn_exit);
          
        }

        private void exit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void saveGame_Click(object sender, EventArgs e)
        {
            theCtrl.SaveLevelState();
        }

        private void resetLevel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void redoMove_Click(object sender, EventArgs e)
        {
            theCtrl.RedoMove();
        }

        private void undoMove_Click(object sender, EventArgs e)
        {
            theCtrl.UndoMove();
        }

        private void moveRight_Click(object sender, EventArgs e)
        {
            theCtrl.MovePlayer(Directions.RIGHT);
        }

        private void moveDown_Click(object sender, EventArgs e)
        {
            theCtrl.MovePlayer(Directions.DOWN);
        }

        private void moveLeft_Click(object sender, EventArgs e)
        {
            theCtrl.MovePlayer(Directions.LEFT);
        }

        private void moveUp_Click(object sender, EventArgs e)
        {
            theCtrl.MovePlayer(Directions.UP);
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
            SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            SolidBrush backgroundBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            SolidBrush wallBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            SolidBrush floorBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
            SolidBrush goalTileBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Gold);
            SolidBrush boxBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Green);
            SolidBrush playerBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Blue);
            Graphics graphic = this.CreateGraphics();
            graphic.FillRectangle(backgroundBrush, new Rectangle(31, 20, 848, 520));
            Level g = theCtrl.theLevel;
            int tileWidth = 848 / g.GetRowWidth();
            int tileHeight = 520 / g.GetColumnHeight();
            Entity[] l = g.GetLevelData();
            foreach(Entity e in l)
            {
                Location myLoc = e.GetLocation();
                if(e.GetEntityType() == EntityTypes.Floor)
                {
                    brush.Color = Color.LightGray;
                }
                if (e.GetEntityType() == EntityTypes.Wall)
                {
                    brush.Color = Color.DarkGray;
                }
                if (e.GetEntityType() == EntityTypes.GoalTile)
                {
                    brush.Color = Color.Gold;
                }
                if (e.GetEntityType() == EntityTypes.MovableBlock)
                {
                    brush.Color = Color.Green;
                }
                if (e.GetEntityType() == EntityTypes.Player)
                {
                    brush.Color = Color.Blue;
                }
                graphic.FillRectangle(brush, new Rectangle(31 + (myLoc.x * tileWidth), 20 + (myLoc.y * tileHeight) ,tileWidth , tileHeight));
            }
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
