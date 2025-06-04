namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            header = new Label();
            tournamentNameValue = new TextBox();
            tournamentNameLabel = new Label();
            entryFeeValue = new TextBox();
            entryFeeLabel = new Label();
            selectTeamDropDown = new ComboBox();
            selectTeamLabel = new Label();
            createNewTeamLink = new LinkLabel();
            addTeamButton = new Button();
            createPrizeButton = new Button();
            tournamentPlayerListBox = new ListBox();
            teamPlayerLabel = new Label();
            deleteSelectedPrizeButton = new Button();
            prizesListBox = new ListBox();
            prizesLabel = new Label();
            deleteSelectedPlayerButton = new Button();
            createTournamentButton = new Button();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            header.ForeColor = Color.FromArgb(51, 153, 255);
            header.Location = new Point(12, 9);
            header.Name = "header";
            header.Size = new Size(317, 50);
            header.TabIndex = 1;
            header.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            tournamentNameValue.Location = new Point(12, 108);
            tournamentNameValue.Name = "tournamentNameValue";
            tournamentNameValue.Size = new Size(317, 35);
            tournamentNameValue.TabIndex = 11;
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            tournamentNameLabel.Location = new Point(12, 68);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(236, 37);
            tournamentNameLabel.TabIndex = 10;
            tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeValue
            // 
            entryFeeValue.Location = new Point(149, 161);
            entryFeeValue.Name = "entryFeeValue";
            entryFeeValue.Size = new Size(99, 35);
            entryFeeValue.TabIndex = 13;
            entryFeeValue.Text = "0";
            // 
            // entryFeeLabel
            // 
            entryFeeLabel.AutoSize = true;
            entryFeeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            entryFeeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            entryFeeLabel.Location = new Point(12, 158);
            entryFeeLabel.Name = "entryFeeLabel";
            entryFeeLabel.Size = new Size(131, 37);
            entryFeeLabel.TabIndex = 12;
            entryFeeLabel.Text = "Entry Fee:";
            // 
            // selectTeamDropDown
            // 
            selectTeamDropDown.FormattingEnabled = true;
            selectTeamDropDown.Location = new Point(12, 308);
            selectTeamDropDown.Name = "selectTeamDropDown";
            selectTeamDropDown.Size = new Size(317, 38);
            selectTeamDropDown.TabIndex = 15;
            // 
            // selectTeamLabel
            // 
            selectTeamLabel.AutoSize = true;
            selectTeamLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            selectTeamLabel.ForeColor = Color.FromArgb(51, 153, 255);
            selectTeamLabel.Location = new Point(12, 268);
            selectTeamLabel.Name = "selectTeamLabel";
            selectTeamLabel.Size = new Size(156, 37);
            selectTeamLabel.TabIndex = 14;
            selectTeamLabel.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            createNewTeamLink.AutoSize = true;
            createNewTeamLink.Location = new Point(215, 274);
            createNewTeamLink.Name = "createNewTeamLink";
            createNewTeamLink.Size = new Size(114, 30);
            createNewTeamLink.TabIndex = 16;
            createNewTeamLink.TabStop = true;
            createNewTeamLink.Text = "create new";
            // 
            // addTeamButton
            // 
            addTeamButton.FlatAppearance.BorderColor = Color.Silver;
            addTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addTeamButton.FlatStyle = FlatStyle.Flat;
            addTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            addTeamButton.ForeColor = Color.FromArgb(51, 153, 255);
            addTeamButton.Location = new Point(12, 363);
            addTeamButton.Name = "addTeamButton";
            addTeamButton.Size = new Size(317, 41);
            addTeamButton.TabIndex = 17;
            addTeamButton.Text = "Add Team";
            addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(12, 419);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(317, 41);
            createPrizeButton.TabIndex = 18;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // tournamentPlayerListBox
            // 
            tournamentPlayerListBox.BorderStyle = BorderStyle.FixedSingle;
            tournamentPlayerListBox.FormattingEnabled = true;
            tournamentPlayerListBox.ItemHeight = 30;
            tournamentPlayerListBox.Location = new Point(361, 108);
            tournamentPlayerListBox.Name = "tournamentPlayerListBox";
            tournamentPlayerListBox.Size = new Size(301, 152);
            tournamentPlayerListBox.TabIndex = 20;
            // 
            // teamPlayerLabel
            // 
            teamPlayerLabel.AutoSize = true;
            teamPlayerLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            teamPlayerLabel.ForeColor = Color.FromArgb(51, 153, 255);
            teamPlayerLabel.Location = new Point(361, 68);
            teamPlayerLabel.Name = "teamPlayerLabel";
            teamPlayerLabel.Size = new Size(187, 37);
            teamPlayerLabel.TabIndex = 19;
            teamPlayerLabel.Text = "Team / Players";
            // 
            // deleteSelectedPrizeButton
            // 
            deleteSelectedPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPrizeButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteSelectedPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPrizeButton.Location = new Point(680, 348);
            deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            deleteSelectedPrizeButton.Size = new Size(104, 72);
            deleteSelectedPrizeButton.TabIndex = 24;
            deleteSelectedPrizeButton.Text = "Delete Selected";
            deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // prizesListBox
            // 
            prizesListBox.BorderStyle = BorderStyle.FixedSingle;
            prizesListBox.FormattingEnabled = true;
            prizesListBox.ItemHeight = 30;
            prizesListBox.Location = new Point(361, 308);
            prizesListBox.Name = "prizesListBox";
            prizesListBox.Size = new Size(301, 152);
            prizesListBox.TabIndex = 23;
            // 
            // prizesLabel
            // 
            prizesLabel.AutoSize = true;
            prizesLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            prizesLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizesLabel.Location = new Point(361, 271);
            prizesLabel.Name = "prizesLabel";
            prizesLabel.Size = new Size(187, 37);
            prizesLabel.TabIndex = 22;
            prizesLabel.Text = "Team / Players";
            // 
            // deleteSelectedPlayerButton
            // 
            deleteSelectedPlayerButton.FlatAppearance.BorderColor = Color.Silver;
            deleteSelectedPlayerButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            deleteSelectedPlayerButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            deleteSelectedPlayerButton.FlatStyle = FlatStyle.Flat;
            deleteSelectedPlayerButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            deleteSelectedPlayerButton.ForeColor = Color.FromArgb(51, 153, 255);
            deleteSelectedPlayerButton.Location = new Point(680, 148);
            deleteSelectedPlayerButton.Name = "deleteSelectedPlayerButton";
            deleteSelectedPlayerButton.Size = new Size(104, 72);
            deleteSelectedPlayerButton.TabIndex = 25;
            deleteSelectedPlayerButton.Text = "Delete Selected";
            deleteSelectedPlayerButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            createTournamentButton.FlatAppearance.BorderColor = Color.Silver;
            createTournamentButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTournamentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTournamentButton.FlatStyle = FlatStyle.Flat;
            createTournamentButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            createTournamentButton.ForeColor = Color.FromArgb(51, 153, 255);
            createTournamentButton.Location = new Point(215, 479);
            createTournamentButton.Name = "createTournamentButton";
            createTournamentButton.Size = new Size(317, 41);
            createTournamentButton.TabIndex = 26;
            createTournamentButton.Text = "Create Tournament";
            createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(797, 532);
            Controls.Add(createTournamentButton);
            Controls.Add(deleteSelectedPlayerButton);
            Controls.Add(deleteSelectedPrizeButton);
            Controls.Add(prizesListBox);
            Controls.Add(prizesLabel);
            Controls.Add(tournamentPlayerListBox);
            Controls.Add(teamPlayerLabel);
            Controls.Add(createPrizeButton);
            Controls.Add(addTeamButton);
            Controls.Add(createNewTeamLink);
            Controls.Add(selectTeamDropDown);
            Controls.Add(selectTeamLabel);
            Controls.Add(entryFeeValue);
            Controls.Add(entryFeeLabel);
            Controls.Add(tournamentNameValue);
            Controls.Add(tournamentNameLabel);
            Controls.Add(header);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateTournamentForm";
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private TextBox tournamentNameValue;
        private Label tournamentNameLabel;
        private TextBox entryFeeValue;
        private Label entryFeeLabel;
        private ComboBox selectTeamDropDown;
        private Label selectTeamLabel;
        private LinkLabel createNewTeamLink;
        private Button addTeamButton;
        private Button createPrizeButton;
        private ListBox tournamentPlayerListBox;
        private Label teamPlayerLabel;
        private Button deleteSelectedPrizeButton;
        private ListBox prizesListBox;
        private Label prizesLabel;
        private Button deleteSelectedPlayerButton;
        private Button createTournamentButton;
    }
}