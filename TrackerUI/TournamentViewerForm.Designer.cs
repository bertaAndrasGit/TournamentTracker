namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TournamentLabel = new Label();
            TournamentNameLabel = new Label();
            roundLabel = new Label();
            matchupListBox = new ListBox();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            teamOneNameLable = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreTextBox = new TextBox();
            versusLabel = new Label();
            teamTwoScoreTextBox = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoNameLable = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // TournamentLabel
            // 
            TournamentLabel.AutoSize = true;
            TournamentLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentLabel.ForeColor = Color.Aqua;
            TournamentLabel.Location = new Point(50, 45);
            TournamentLabel.Name = "TournamentLabel";
            TournamentLabel.Size = new Size(164, 32);
            TournamentLabel.TabIndex = 0;
            TournamentLabel.Text = "Tournament:";
            // 
            // TournamentNameLabel
            // 
            TournamentNameLabel.AutoSize = true;
            TournamentNameLabel.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            TournamentNameLabel.ForeColor = Color.Aqua;
            TournamentNameLabel.Location = new Point(220, 45);
            TournamentNameLabel.Name = "TournamentNameLabel";
            TournamentNameLabel.Size = new Size(110, 32);
            TournamentNameLabel.TabIndex = 1;
            TournamentNameLabel.Text = "<None>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            roundLabel.ForeColor = Color.Aqua;
            roundLabel.Location = new Point(50, 97);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(76, 24);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round:";
            // 
            // matchupListBox
            // 
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 18;
            matchupListBox.Location = new Point(50, 201);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(280, 364);
            matchupListBox.TabIndex = 3;
            // 
            // roundDropDown
            // 
            roundDropDown.Cursor = Cursors.Hand;
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(132, 98);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(111, 26);
            roundDropDown.TabIndex = 4;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Popup;
            unplayedOnlyCheckBox.ForeColor = Color.Aqua;
            unplayedOnlyCheckBox.Location = new Point(132, 130);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(124, 22);
            unplayedOnlyCheckBox.TabIndex = 5;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // teamOneNameLable
            // 
            teamOneNameLable.AutoSize = true;
            teamOneNameLable.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamOneNameLable.ForeColor = Color.Aqua;
            teamOneNameLable.Location = new Point(407, 201);
            teamOneNameLable.Name = "teamOneNameLable";
            teamOneNameLable.Size = new Size(189, 24);
            teamOneNameLable.TabIndex = 7;
            teamOneNameLable.Text = "<Team One Name>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            teamOneScoreLabel.ForeColor = Color.Aqua;
            teamOneScoreLabel.Location = new Point(407, 244);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(76, 24);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreTextBox
            // 
            teamOneScoreTextBox.Location = new Point(489, 244);
            teamOneScoreTextBox.Name = "teamOneScoreTextBox";
            teamOneScoreTextBox.Size = new Size(107, 26);
            teamOneScoreTextBox.TabIndex = 9;
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            versusLabel.ForeColor = Color.Aqua;
            versusLabel.Location = new Point(452, 294);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(107, 24);
            versusLabel.TabIndex = 10;
            versusLabel.Text = "-----VS-----";
            // 
            // teamTwoScoreTextBox
            // 
            teamTwoScoreTextBox.Location = new Point(489, 378);
            teamTwoScoreTextBox.Name = "teamTwoScoreTextBox";
            teamTwoScoreTextBox.Size = new Size(107, 26);
            teamTwoScoreTextBox.TabIndex = 13;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            teamTwoScoreLabel.ForeColor = Color.Aqua;
            teamTwoScoreLabel.Location = new Point(407, 378);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(76, 24);
            teamTwoScoreLabel.TabIndex = 12;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoNameLable
            // 
            teamTwoNameLable.AutoSize = true;
            teamTwoNameLable.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            teamTwoNameLable.ForeColor = Color.Aqua;
            teamTwoNameLable.Location = new Point(407, 335);
            teamTwoNameLable.Name = "teamTwoNameLable";
            teamTwoNameLable.Size = new Size(188, 24);
            teamTwoNameLable.TabIndex = 11;
            teamTwoNameLable.Text = "<Team Two Name>";
            // 
            // scoreButton
            // 
            scoreButton.Cursor = Cursors.Hand;
            scoreButton.FlatAppearance.BorderColor = Color.Aqua;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.Teal;
            scoreButton.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            scoreButton.ForeColor = Color.Aqua;
            scoreButton.Location = new Point(638, 290);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(93, 35);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(828, 635);
            Controls.Add(scoreButton);
            Controls.Add(teamTwoScoreTextBox);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoNameLable);
            Controls.Add(versusLabel);
            Controls.Add(teamOneScoreTextBox);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneNameLable);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(matchupListBox);
            Controls.Add(roundLabel);
            Controls.Add(TournamentNameLabel);
            Controls.Add(TournamentLabel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TournamentViewerForm";
            Text = "Tournament viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TournamentLabel;
        private Label TournamentNameLabel;
        private Label roundLabel;
        private ListBox matchupListBox;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private Label teamOneNameLable;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreTextBox;
        private Label versusLabel;
        private TextBox teamTwoScoreTextBox;
        private Label teamTwoScoreLabel;
        private Label teamTwoNameLable;
        private Button scoreButton;
    }
}