
namespace Life
{
    partial class GameGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlsGroupBox = new System.Windows.Forms.GroupBox();
            this.labelGeneration = new System.Windows.Forms.Label();
            this.genTextBox = new System.Windows.Forms.TextBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.colorSaveGroupBox = new System.Windows.Forms.GroupBox();
            this.radioColorBlue = new System.Windows.Forms.RadioButton();
            this.radioColorGreen = new System.Windows.Forms.RadioButton();
            this.radioColorRed = new System.Windows.Forms.RadioButton();
            this.labelColorSelection = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.controlsGroupBox.SuspendLayout();
            this.colorSaveGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // controlsGroupBox
            //
            this.controlsGroupBox.Controls.Add(this.labelGeneration);
            this.controlsGroupBox.Controls.Add(this.genTextBox);
            this.controlsGroupBox.Controls.Add(this.resetButton);
            this.controlsGroupBox.Controls.Add(this.pauseButton);
            this.controlsGroupBox.Controls.Add(this.startButton);
            this.controlsGroupBox.Location = new System.Drawing.Point(12, 4);
            this.controlsGroupBox.Name = "controlsGroupBox";
            this.controlsGroupBox.Size = new System.Drawing.Size(450, 58);
            this.controlsGroupBox.TabIndex = 0;
            this.controlsGroupBox.TabStop = false;
            //
            // labelGeneration
            //
            this.labelGeneration.AutoSize = true;
            this.labelGeneration.Location = new System.Drawing.Point(332, 13);
            this.labelGeneration.Name = "labelGeneration";
            this.labelGeneration.Size = new System.Drawing.Size(112, 13);
            this.labelGeneration.TabIndex = 4;
            this.labelGeneration.Text = "Generation Number:";
            //
            // genTextBox
            //
            this.genTextBox.Location = new System.Drawing.Point(332, 29);
            this.genTextBox.Name = "genTextBox";
            this.genTextBox.Size = new System.Drawing.Size(112, 22);
            this.genTextBox.TabIndex = 3;
            this.genTextBox.Text = "0";
            //
            // resetButton
            //
            this.resetButton.Location = new System.Drawing.Point(218, 16);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(100, 34);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            //
            // pauseButton
            //
            this.pauseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.pauseButton.Location = new System.Drawing.Point(112, 16);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(100, 34);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            //
            // startButton
            //
            this.startButton.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(6, 16);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 34);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            //
            // mainGroupBox
            //
            this.mainGroupBox.Location = new System.Drawing.Point(12, 125);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(450, 450);
            this.mainGroupBox.TabIndex = 1;
            this.mainGroupBox.TabStop = false;
            //
            // timer
            //
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            //
            // colorSaveGroupBox
            //
            this.colorSaveGroupBox.Controls.Add(this.radioColorBlue);
            this.colorSaveGroupBox.Controls.Add(this.radioColorGreen);
            this.colorSaveGroupBox.Controls.Add(this.radioColorRed);
            this.colorSaveGroupBox.Controls.Add(this.labelColorSelection);
            this.colorSaveGroupBox.Controls.Add(this.saveButton);
            this.colorSaveGroupBox.Location = new System.Drawing.Point(12, 65);
            this.colorSaveGroupBox.Name = "colorSaveGroupBox";
            this.colorSaveGroupBox.Size = new System.Drawing.Size(450, 55);
            this.colorSaveGroupBox.TabIndex = 2;
            this.colorSaveGroupBox.TabStop = false;
            //
            // radioColorBlue
            //
            this.radioColorBlue.AutoSize = true;
            this.radioColorBlue.Checked = true;
            this.radioColorBlue.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.radioColorBlue.Location = new System.Drawing.Point(271, 22);
            this.radioColorBlue.Name = "radioColorBlue";
            this.radioColorBlue.Size = new System.Drawing.Size(48, 19);
            this.radioColorBlue.TabIndex = 4;
            this.radioColorBlue.TabStop = true;
            this.radioColorBlue.Text = "Blue";
            this.radioColorBlue.UseVisualStyleBackColor = true;
            this.radioColorBlue.CheckedChanged += new System.EventHandler(this.radioColorBlue_CheckedChanged);
            //
            // radioColorGreen
            //
            this.radioColorGreen.AutoSize = true;
            this.radioColorGreen.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioColorGreen.ForeColor = System.Drawing.Color.Green;
            this.radioColorGreen.Location = new System.Drawing.Point(197, 22);
            this.radioColorGreen.Name = "radioColorGreen";
            this.radioColorGreen.Size = new System.Drawing.Size(56, 19);
            this.radioColorGreen.TabIndex = 3;
            this.radioColorGreen.TabStop = true;
            this.radioColorGreen.Text = "Green";
            this.radioColorGreen.UseVisualStyleBackColor = true;
            this.radioColorGreen.CheckedChanged += new System.EventHandler(this.radioColorGreen_CheckedChanged);
            //
            // radioColorRed
            //
            this.radioColorRed.AutoSize = true;
            this.radioColorRed.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioColorRed.ForeColor = System.Drawing.Color.Red;
            this.radioColorRed.Location = new System.Drawing.Point(125, 22);
            this.radioColorRed.Name = "radioColorRed";
            this.radioColorRed.Size = new System.Drawing.Size(45, 19);
            this.radioColorRed.TabIndex = 2;
            this.radioColorRed.TabStop = true;
            this.radioColorRed.Text = "Red";
            this.radioColorRed.UseVisualStyleBackColor = true;
            this.radioColorRed.CheckedChanged += new System.EventHandler(this.radioColorRed_CheckedChanged);
            //
            // labelColorSelection
            //
            this.labelColorSelection.AutoSize = true;
            this.labelColorSelection.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColorSelection.Location = new System.Drawing.Point(10, 22);
            this.labelColorSelection.Name = "labelColorSelection";
            this.labelColorSelection.Size = new System.Drawing.Size(112, 15);
            this.labelColorSelection.TabIndex = 1;
            this.labelColorSelection.Text = "Cell Color Selection:";
            //
            // saveButton
            //
            this.saveButton.Location = new System.Drawing.Point(329, 13);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(115, 34);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save Image";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            //
            // GameGUI
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 586);
            this.Controls.Add(this.colorSaveGroupBox);
            this.Controls.Add(this.mainGroupBox);
            this.Controls.Add(this.controlsGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 625);
            this.MinimumSize = new System.Drawing.Size(490, 625);
            this.Name = "GameGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRG455 - Game of Life";
            this.Load += new System.EventHandler(this.GameGUI_Load);
            this.controlsGroupBox.ResumeLayout(false);
            this.controlsGroupBox.PerformLayout();
            this.colorSaveGroupBox.ResumeLayout(false);
            this.colorSaveGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlsGroupBox;
        private System.Windows.Forms.Label labelGeneration;
        private System.Windows.Forms.TextBox genTextBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox colorSaveGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton radioColorBlue;
        private System.Windows.Forms.RadioButton radioColorGreen;
        private System.Windows.Forms.RadioButton radioColorRed;
        private System.Windows.Forms.Label labelColorSelection;
    }
}

