namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            header = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizeAmmountValue = new TextBox();
            prizeAmmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentgeLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            header.ForeColor = Color.FromArgb(51, 153, 255);
            header.Location = new Point(12, 9);
            header.Name = "header";
            header.Size = new Size(209, 50);
            header.TabIndex = 12;
            header.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(232, 73);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(227, 35);
            placeNumberValue.TabIndex = 1;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNumberLabel.Location = new Point(12, 70);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(183, 37);
            placeNumberLabel.TabIndex = 17;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizeAmmountValue
            // 
            prizeAmmountValue.Location = new Point(232, 155);
            prizeAmmountValue.Name = "prizeAmmountValue";
            prizeAmmountValue.Size = new Size(227, 35);
            prizeAmmountValue.TabIndex = 3;
            prizeAmmountValue.Text = "0";
            // 
            // prizeAmmountLabel
            // 
            prizeAmmountLabel.AutoSize = true;
            prizeAmmountLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            prizeAmmountLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizeAmmountLabel.Location = new Point(12, 152);
            prizeAmmountLabel.Name = "prizeAmmountLabel";
            prizeAmmountLabel.Size = new Size(199, 37);
            prizeAmmountLabel.TabIndex = 19;
            prizeAmmountLabel.Text = "Prize Ammount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(232, 114);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(227, 35);
            placeNameValue.TabIndex = 2;
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            placeNameLabel.ForeColor = Color.FromArgb(51, 153, 255);
            placeNameLabel.Location = new Point(12, 111);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(157, 37);
            placeNameLabel.TabIndex = 21;
            placeNameLabel.Text = "Place Name";
            // 
            // prizePercentgeValue
            // 
            prizePercentageValue.Location = new Point(232, 265);
            prizePercentageValue.Name = "prizePercentgeValue";
            prizePercentageValue.Size = new Size(227, 35);
            prizePercentageValue.TabIndex = 4;
            prizePercentageValue.Text = "0";
            // 
            // prizePercentgeLabel
            // 
            prizePercentgeLabel.AutoSize = true;
            prizePercentgeLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            prizePercentgeLabel.ForeColor = Color.FromArgb(51, 153, 255);
            prizePercentgeLabel.Location = new Point(12, 262);
            prizePercentgeLabel.Name = "prizePercentgeLabel";
            prizePercentgeLabel.Size = new Size(212, 37);
            prizePercentgeLabel.TabIndex = 23;
            prizePercentgeLabel.Text = "Prize Percentage";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            orLabel.ForeColor = Color.FromArgb(51, 153, 255);
            orLabel.Location = new Point(196, 206);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(78, 37);
            orLabel.TabIndex = 25;
            orLabel.Text = "- or -";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            createPrizeButton.ForeColor = Color.FromArgb(51, 153, 255);
            createPrizeButton.Location = new Point(12, 314);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(447, 41);
            createPrizeButton.TabIndex = 5;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            createPrizeButton.Click += createPrizeButton_Click;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 367);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentgeLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmmountValue);
            Controls.Add(prizeAmmountLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(header);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizeAmmountValue;
        private Label prizeAmmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentgeLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}