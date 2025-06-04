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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            header = new Label();
            tournamentName = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            header.ForeColor = Color.FromArgb(51, 153, 255);
            header.Location = new Point(12, 9);
            header.Name = "header";
            header.Size = new Size(214, 50);
            header.TabIndex = 0;
            header.Text = "Tournament:";
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tournamentName.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentName.Location = new Point(232, 9);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roundLabel.ForeColor = Color.FromArgb(51, 153, 255);
            roundLabel.Location = new Point(12, 75);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(94, 37);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(112, 74);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(209, 38);
            roundDropDown.TabIndex = 3;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            unplayedOnlyCheckBox.ForeColor = Color.FromArgb(51, 153, 255);
            unplayedOnlyCheckBox.Location = new Point(112, 118);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(209, 41);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.ItemHeight = 30;
            matchupListBox.Location = new Point(12, 165);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(309, 302);
            matchupListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            teamOneName.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneName.Location = new Point(370, 165);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(165, 37);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            teamOneScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamOneScoreLabel.Location = new Point(370, 202);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(88, 37);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(464, 205);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(100, 35);
            teamOneScoreValue.TabIndex = 9;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(464, 432);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(100, 35);
            teamTwoScoreValue.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoScoreLabel.Location = new Point(370, 429);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(88, 37);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            teamTwoName.ForeColor = Color.FromArgb(51, 153, 255);
            teamTwoName.Location = new Point(370, 392);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(165, 37);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            versusLabel.ForeColor = Color.FromArgb(51, 153, 255);
            versusLabel.Location = new Point(439, 301);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(70, 37);
            versusLabel.TabIndex = 13;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            scoreButton.ForeColor = Color.FromArgb(51, 153, 255);
            scoreButton.Location = new Point(597, 302);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(92, 41);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(702, 479);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentName);
            Controls.Add(header);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private Label tournamentName;
        private Label roundLabel;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
