namespace SetListManager
{
    partial class SetListManager_Form
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
            bandListBox = new ListBox();
            setlistListBox = new ListBox();
            songListBox = new ListBox();
            bandInfoGroupBox = new GroupBox();
            deleteBandButton = new Button();
            clearBandButton = new Button();
            editBandButton = new Button();
            addBandButton = new Button();
            genreTextBox = new TextBox();
            bandMembersTextBox = new TextBox();
            bandNameTextBox = new TextBox();
            bandIDTextBox = new TextBox();
            genreLabel = new Label();
            bandMembersLabel = new Label();
            bandNameLabel = new Label();
            bandIDLabel = new Label();
            setlistInfoGroupBox = new GroupBox();
            deleteSetlistButton = new Button();
            clearSetlistButton = new Button();
            editSetlistButton = new Button();
            addSetlistButton = new Button();
            durationTextBox = new TextBox();
            numberSongsTextBox = new TextBox();
            setlistRatingTextBox = new TextBox();
            moodTextBox = new TextBox();
            setlistNameTextBox = new TextBox();
            setlistIDTextBox = new TextBox();
            durationLabel = new Label();
            numberSongsLabel = new Label();
            setlistRatingLabel = new Label();
            moodLabel = new Label();
            setlistNameLabel = new Label();
            setlistIDLabel = new Label();
            songInfoTextBox = new GroupBox();
            deleteSongButton = new Button();
            clearSongButton = new Button();
            editSongButton = new Button();
            addSongButton = new Button();
            songRatingTextBox = new TextBox();
            lengthTextBox = new TextBox();
            asPerformedTextBox = new TextBox();
            artistTextBox = new TextBox();
            songNameTextBox = new TextBox();
            songIDTextBox = new TextBox();
            songRatingLabel = new Label();
            lengthLabel = new Label();
            asPerfomedLabel = new Label();
            artistLabel = new Label();
            songNameLabel = new Label();
            songIDLabel = new Label();
            bandInfoGroupBox.SuspendLayout();
            setlistInfoGroupBox.SuspendLayout();
            songInfoTextBox.SuspendLayout();
            SuspendLayout();
            // 
            // bandListBox
            // 
            bandListBox.BackColor = Color.LightSteelBlue;
            bandListBox.FormattingEnabled = true;
            bandListBox.ItemHeight = 18;
            bandListBox.Location = new Point(514, 27);
            bandListBox.Name = "bandListBox";
            bandListBox.Size = new Size(346, 202);
            bandListBox.TabIndex = 0;
            bandListBox.TabStop = false;
            bandListBox.SelectedIndexChanged += bandListBox_SelectedIndexChanged;
            // 
            // setlistListBox
            // 
            setlistListBox.BackColor = Color.LightSteelBlue;
            setlistListBox.FormattingEnabled = true;
            setlistListBox.ItemHeight = 18;
            setlistListBox.Location = new Point(514, 27);
            setlistListBox.Name = "setlistListBox";
            setlistListBox.Size = new Size(346, 256);
            setlistListBox.TabIndex = 1;
            setlistListBox.TabStop = false;
            setlistListBox.SelectedIndexChanged += setlistListBox_SelectedIndexChanged;
            // 
            // songListBox
            // 
            songListBox.BackColor = Color.LightSteelBlue;
            songListBox.FormattingEnabled = true;
            songListBox.ItemHeight = 18;
            songListBox.Location = new Point(514, 27);
            songListBox.Name = "songListBox";
            songListBox.Size = new Size(346, 256);
            songListBox.TabIndex = 2;
            songListBox.TabStop = false;
            songListBox.SelectedIndexChanged += songListBox_SelectedIndexChanged;
            // 
            // bandInfoGroupBox
            // 
            bandInfoGroupBox.Controls.Add(deleteBandButton);
            bandInfoGroupBox.Controls.Add(clearBandButton);
            bandInfoGroupBox.Controls.Add(editBandButton);
            bandInfoGroupBox.Controls.Add(addBandButton);
            bandInfoGroupBox.Controls.Add(genreTextBox);
            bandInfoGroupBox.Controls.Add(bandMembersTextBox);
            bandInfoGroupBox.Controls.Add(bandNameTextBox);
            bandInfoGroupBox.Controls.Add(bandIDTextBox);
            bandInfoGroupBox.Controls.Add(genreLabel);
            bandInfoGroupBox.Controls.Add(bandMembersLabel);
            bandInfoGroupBox.Controls.Add(bandNameLabel);
            bandInfoGroupBox.Controls.Add(bandIDLabel);
            bandInfoGroupBox.Controls.Add(bandListBox);
            bandInfoGroupBox.Location = new Point(16, 15);
            bandInfoGroupBox.Name = "bandInfoGroupBox";
            bandInfoGroupBox.Size = new Size(885, 238);
            bandInfoGroupBox.TabIndex = 1;
            bandInfoGroupBox.TabStop = false;
            bandInfoGroupBox.Text = "Band Information";
            // 
            // deleteBandButton
            // 
            deleteBandButton.BackColor = Color.LightSlateGray;
            deleteBandButton.Location = new Point(378, 189);
            deleteBandButton.Name = "deleteBandButton";
            deleteBandButton.Size = new Size(116, 39);
            deleteBandButton.TabIndex = 7;
            deleteBandButton.Text = "Delete Band";
            deleteBandButton.UseVisualStyleBackColor = false;
            deleteBandButton.Click += deleteBandButton_Click;
            // 
            // clearBandButton
            // 
            clearBandButton.BackColor = Color.LightSlateGray;
            clearBandButton.Location = new Point(254, 189);
            clearBandButton.Name = "clearBandButton";
            clearBandButton.Size = new Size(116, 39);
            clearBandButton.TabIndex = 6;
            clearBandButton.Text = "Clear All";
            clearBandButton.UseVisualStyleBackColor = false;
            clearBandButton.Click += clearBandButton_Click;
            // 
            // editBandButton
            // 
            editBandButton.BackColor = Color.LightSlateGray;
            editBandButton.Location = new Point(132, 189);
            editBandButton.Name = "editBandButton";
            editBandButton.Size = new Size(116, 39);
            editBandButton.TabIndex = 5;
            editBandButton.Text = "Edit Band";
            editBandButton.UseVisualStyleBackColor = false;
            editBandButton.Click += editBandButton_Click;
            // 
            // addBandButton
            // 
            addBandButton.BackColor = Color.LightSlateGray;
            addBandButton.Location = new Point(8, 189);
            addBandButton.Name = "addBandButton";
            addBandButton.Size = new Size(116, 39);
            addBandButton.TabIndex = 4;
            addBandButton.Text = "Add Band";
            addBandButton.UseVisualStyleBackColor = false;
            addBandButton.Click += addBandButton_Click;
            // 
            // genreTextBox
            // 
            genreTextBox.BackColor = Color.LightSteelBlue;
            genreTextBox.Location = new Point(86, 141);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(406, 25);
            genreTextBox.TabIndex = 3;
            // 
            // bandMembersTextBox
            // 
            bandMembersTextBox.BackColor = Color.LightSteelBlue;
            bandMembersTextBox.Location = new Point(152, 105);
            bandMembersTextBox.Name = "bandMembersTextBox";
            bandMembersTextBox.Size = new Size(340, 25);
            bandMembersTextBox.TabIndex = 2;
            // 
            // bandNameTextBox
            // 
            bandNameTextBox.BackColor = Color.LightSteelBlue;
            bandNameTextBox.Location = new Point(122, 71);
            bandNameTextBox.Name = "bandNameTextBox";
            bandNameTextBox.Size = new Size(370, 25);
            bandNameTextBox.TabIndex = 1;
            // 
            // bandIDTextBox
            // 
            bandIDTextBox.BackColor = Color.LightSlateGray;
            bandIDTextBox.Enabled = false;
            bandIDTextBox.Location = new Point(98, 36);
            bandIDTextBox.Name = "bandIDTextBox";
            bandIDTextBox.Size = new Size(394, 25);
            bandIDTextBox.TabIndex = 1;
            bandIDTextBox.TabStop = false;
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new Point(20, 144);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new Size(60, 18);
            genreLabel.TabIndex = 4;
            genreLabel.Text = "Genre:";
            // 
            // bandMembersLabel
            // 
            bandMembersLabel.AutoSize = true;
            bandMembersLabel.Location = new Point(20, 109);
            bandMembersLabel.Name = "bandMembersLabel";
            bandMembersLabel.Size = new Size(126, 18);
            bandMembersLabel.TabIndex = 3;
            bandMembersLabel.Text = "Band Members:";
            // 
            // bandNameLabel
            // 
            bandNameLabel.AutoSize = true;
            bandNameLabel.Location = new Point(20, 75);
            bandNameLabel.Name = "bandNameLabel";
            bandNameLabel.Size = new Size(96, 18);
            bandNameLabel.TabIndex = 2;
            bandNameLabel.Text = "Band Name:";
            // 
            // bandIDLabel
            // 
            bandIDLabel.AutoSize = true;
            bandIDLabel.Location = new Point(20, 39);
            bandIDLabel.Name = "bandIDLabel";
            bandIDLabel.Size = new Size(72, 18);
            bandIDLabel.TabIndex = 1;
            bandIDLabel.Text = "Band ID:";
            // 
            // setlistInfoGroupBox
            // 
            setlistInfoGroupBox.Controls.Add(deleteSetlistButton);
            setlistInfoGroupBox.Controls.Add(clearSetlistButton);
            setlistInfoGroupBox.Controls.Add(editSetlistButton);
            setlistInfoGroupBox.Controls.Add(addSetlistButton);
            setlistInfoGroupBox.Controls.Add(durationTextBox);
            setlistInfoGroupBox.Controls.Add(numberSongsTextBox);
            setlistInfoGroupBox.Controls.Add(setlistRatingTextBox);
            setlistInfoGroupBox.Controls.Add(moodTextBox);
            setlistInfoGroupBox.Controls.Add(setlistNameTextBox);
            setlistInfoGroupBox.Controls.Add(setlistIDTextBox);
            setlistInfoGroupBox.Controls.Add(durationLabel);
            setlistInfoGroupBox.Controls.Add(numberSongsLabel);
            setlistInfoGroupBox.Controls.Add(setlistRatingLabel);
            setlistInfoGroupBox.Controls.Add(moodLabel);
            setlistInfoGroupBox.Controls.Add(setlistNameLabel);
            setlistInfoGroupBox.Controls.Add(setlistIDLabel);
            setlistInfoGroupBox.Controls.Add(setlistListBox);
            setlistInfoGroupBox.Location = new Point(16, 261);
            setlistInfoGroupBox.Name = "setlistInfoGroupBox";
            setlistInfoGroupBox.Size = new Size(885, 297);
            setlistInfoGroupBox.TabIndex = 2;
            setlistInfoGroupBox.TabStop = false;
            setlistInfoGroupBox.Text = "SetList Information";
            // 
            // deleteSetlistButton
            // 
            deleteSetlistButton.BackColor = Color.LightSlateGray;
            deleteSetlistButton.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteSetlistButton.Location = new Point(378, 252);
            deleteSetlistButton.Name = "deleteSetlistButton";
            deleteSetlistButton.Size = new Size(116, 39);
            deleteSetlistButton.TabIndex = 16;
            deleteSetlistButton.Text = "Delete SetList";
            deleteSetlistButton.UseVisualStyleBackColor = false;
            deleteSetlistButton.Click += deleteSetlistButton_Click;
            // 
            // clearSetlistButton
            // 
            clearSetlistButton.BackColor = Color.LightSlateGray;
            clearSetlistButton.Location = new Point(254, 252);
            clearSetlistButton.Name = "clearSetlistButton";
            clearSetlistButton.Size = new Size(116, 39);
            clearSetlistButton.TabIndex = 15;
            clearSetlistButton.Text = "Clear All";
            clearSetlistButton.UseVisualStyleBackColor = false;
            clearSetlistButton.Click += clearSetlistButton_Click;
            // 
            // editSetlistButton
            // 
            editSetlistButton.BackColor = Color.LightSlateGray;
            editSetlistButton.Location = new Point(132, 252);
            editSetlistButton.Name = "editSetlistButton";
            editSetlistButton.Size = new Size(116, 39);
            editSetlistButton.TabIndex = 14;
            editSetlistButton.Text = "Edit SetList";
            editSetlistButton.UseVisualStyleBackColor = false;
            editSetlistButton.Click += editSetlistButton_Click;
            // 
            // addSetlistButton
            // 
            addSetlistButton.BackColor = Color.LightSlateGray;
            addSetlistButton.Location = new Point(8, 252);
            addSetlistButton.Name = "addSetlistButton";
            addSetlistButton.Size = new Size(116, 39);
            addSetlistButton.TabIndex = 13;
            addSetlistButton.Text = "Add SetList";
            addSetlistButton.UseVisualStyleBackColor = false;
            addSetlistButton.Click += addSetlistButton_Click;
            // 
            // durationTextBox
            // 
            durationTextBox.BackColor = Color.LightSteelBlue;
            durationTextBox.Location = new Point(113, 205);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(379, 25);
            durationTextBox.TabIndex = 12;
            // 
            // numberSongsTextBox
            // 
            numberSongsTextBox.BackColor = Color.LightSteelBlue;
            numberSongsTextBox.Location = new Point(171, 170);
            numberSongsTextBox.Name = "numberSongsTextBox";
            numberSongsTextBox.Size = new Size(321, 25);
            numberSongsTextBox.TabIndex = 11;
            // 
            // setlistRatingTextBox
            // 
            setlistRatingTextBox.BackColor = Color.LightSteelBlue;
            setlistRatingTextBox.Location = new Point(175, 135);
            setlistRatingTextBox.Name = "setlistRatingTextBox";
            setlistRatingTextBox.Size = new Size(317, 25);
            setlistRatingTextBox.TabIndex = 10;
            // 
            // moodTextBox
            // 
            moodTextBox.BackColor = Color.LightSteelBlue;
            moodTextBox.Location = new Point(148, 99);
            moodTextBox.Name = "moodTextBox";
            moodTextBox.Size = new Size(344, 25);
            moodTextBox.TabIndex = 9;
            // 
            // setlistNameTextBox
            // 
            setlistNameTextBox.BackColor = Color.LightSteelBlue;
            setlistNameTextBox.Location = new Point(142, 64);
            setlistNameTextBox.Name = "setlistNameTextBox";
            setlistNameTextBox.Size = new Size(352, 25);
            setlistNameTextBox.TabIndex = 8;
            // 
            // setlistIDTextBox
            // 
            setlistIDTextBox.BackColor = Color.LightSlateGray;
            setlistIDTextBox.Enabled = false;
            setlistIDTextBox.Location = new Point(120, 29);
            setlistIDTextBox.Name = "setlistIDTextBox";
            setlistIDTextBox.Size = new Size(372, 25);
            setlistIDTextBox.TabIndex = 8;
            setlistIDTextBox.TabStop = false;
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new Point(20, 207);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new Size(87, 18);
            durationLabel.TabIndex = 8;
            durationLabel.Text = "Duration:";
            // 
            // numberSongsLabel
            // 
            numberSongsLabel.AutoSize = true;
            numberSongsLabel.Location = new Point(20, 172);
            numberSongsLabel.Name = "numberSongsLabel";
            numberSongsLabel.Size = new Size(145, 18);
            numberSongsLabel.TabIndex = 7;
            numberSongsLabel.Text = "Number of Songs:";
            // 
            // setlistRatingLabel
            // 
            setlistRatingLabel.AutoSize = true;
            setlistRatingLabel.Location = new Point(20, 137);
            setlistRatingLabel.Name = "setlistRatingLabel";
            setlistRatingLabel.Size = new Size(149, 18);
            setlistRatingLabel.TabIndex = 6;
            setlistRatingLabel.Text = "Readiness Rating:";
            // 
            // moodLabel
            // 
            moodLabel.AutoSize = true;
            moodLabel.Location = new Point(20, 104);
            moodLabel.Name = "moodLabel";
            moodLabel.Size = new Size(122, 18);
            moodLabel.TabIndex = 4;
            moodLabel.Text = "Overall Mood:";
            // 
            // setlistNameLabel
            // 
            setlistNameLabel.AutoSize = true;
            setlistNameLabel.Location = new Point(18, 69);
            setlistNameLabel.Name = "setlistNameLabel";
            setlistNameLabel.Size = new Size(118, 18);
            setlistNameLabel.TabIndex = 3;
            setlistNameLabel.Text = "Set List Name:";
            // 
            // setlistIDLabel
            // 
            setlistIDLabel.AutoSize = true;
            setlistIDLabel.Location = new Point(20, 33);
            setlistIDLabel.Name = "setlistIDLabel";
            setlistIDLabel.Size = new Size(94, 18);
            setlistIDLabel.TabIndex = 2;
            setlistIDLabel.Text = "Set List ID:";
            // 
            // songInfoTextBox
            // 
            songInfoTextBox.Controls.Add(deleteSongButton);
            songInfoTextBox.Controls.Add(clearSongButton);
            songInfoTextBox.Controls.Add(editSongButton);
            songInfoTextBox.Controls.Add(addSongButton);
            songInfoTextBox.Controls.Add(songRatingTextBox);
            songInfoTextBox.Controls.Add(lengthTextBox);
            songInfoTextBox.Controls.Add(asPerformedTextBox);
            songInfoTextBox.Controls.Add(artistTextBox);
            songInfoTextBox.Controls.Add(songNameTextBox);
            songInfoTextBox.Controls.Add(songIDTextBox);
            songInfoTextBox.Controls.Add(songRatingLabel);
            songInfoTextBox.Controls.Add(lengthLabel);
            songInfoTextBox.Controls.Add(asPerfomedLabel);
            songInfoTextBox.Controls.Add(artistLabel);
            songInfoTextBox.Controls.Add(songNameLabel);
            songInfoTextBox.Controls.Add(songIDLabel);
            songInfoTextBox.Controls.Add(songListBox);
            songInfoTextBox.Location = new Point(16, 566);
            songInfoTextBox.Name = "songInfoTextBox";
            songInfoTextBox.Size = new Size(885, 291);
            songInfoTextBox.TabIndex = 3;
            songInfoTextBox.TabStop = false;
            songInfoTextBox.Text = "Song Information";
            // 
            // deleteSongButton
            // 
            deleteSongButton.BackColor = Color.LightSlateGray;
            deleteSongButton.Location = new Point(378, 245);
            deleteSongButton.Name = "deleteSongButton";
            deleteSongButton.Size = new Size(116, 39);
            deleteSongButton.TabIndex = 25;
            deleteSongButton.Text = "Delete Song";
            deleteSongButton.UseVisualStyleBackColor = false;
            deleteSongButton.Click += deleteSongButton_Click;
            // 
            // clearSongButton
            // 
            clearSongButton.BackColor = Color.LightSlateGray;
            clearSongButton.Location = new Point(254, 245);
            clearSongButton.Name = "clearSongButton";
            clearSongButton.Size = new Size(116, 39);
            clearSongButton.TabIndex = 24;
            clearSongButton.Text = "Clear All";
            clearSongButton.UseVisualStyleBackColor = false;
            clearSongButton.Click += clearSongButton_Click;
            // 
            // editSongButton
            // 
            editSongButton.BackColor = Color.LightSlateGray;
            editSongButton.Location = new Point(132, 245);
            editSongButton.Name = "editSongButton";
            editSongButton.Size = new Size(116, 39);
            editSongButton.TabIndex = 23;
            editSongButton.Text = "Edit Song";
            editSongButton.UseVisualStyleBackColor = false;
            editSongButton.Click += editSongButton_Click;
            // 
            // addSongButton
            // 
            addSongButton.BackColor = Color.LightSlateGray;
            addSongButton.Location = new Point(8, 245);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(116, 39);
            addSongButton.TabIndex = 22;
            addSongButton.Text = "Add Song";
            addSongButton.UseVisualStyleBackColor = false;
            addSongButton.Click += addSongButton_Click;
            // 
            // songRatingTextBox
            // 
            songRatingTextBox.BackColor = Color.LightSteelBlue;
            songRatingTextBox.Location = new Point(173, 201);
            songRatingTextBox.Name = "songRatingTextBox";
            songRatingTextBox.Size = new Size(319, 25);
            songRatingTextBox.TabIndex = 21;
            // 
            // lengthTextBox
            // 
            lengthTextBox.BackColor = Color.LightSteelBlue;
            lengthTextBox.Location = new Point(95, 165);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(397, 25);
            lengthTextBox.TabIndex = 20;
            // 
            // asPerformedTextBox
            // 
            asPerformedTextBox.BackColor = Color.LightSteelBlue;
            asPerformedTextBox.Location = new Point(171, 130);
            asPerformedTextBox.Name = "asPerformedTextBox";
            asPerformedTextBox.Size = new Size(321, 25);
            asPerformedTextBox.TabIndex = 19;
            // 
            // artistTextBox
            // 
            artistTextBox.BackColor = Color.LightSteelBlue;
            artistTextBox.Location = new Point(162, 97);
            artistTextBox.Name = "artistTextBox";
            artistTextBox.Size = new Size(330, 25);
            artistTextBox.TabIndex = 18;
            // 
            // songNameTextBox
            // 
            songNameTextBox.BackColor = Color.LightSteelBlue;
            songNameTextBox.Location = new Point(120, 62);
            songNameTextBox.Name = "songNameTextBox";
            songNameTextBox.Size = new Size(372, 25);
            songNameTextBox.TabIndex = 17;
            // 
            // songIDTextBox
            // 
            songIDTextBox.BackColor = Color.LightSlateGray;
            songIDTextBox.Enabled = false;
            songIDTextBox.Location = new Point(96, 27);
            songIDTextBox.Name = "songIDTextBox";
            songIDTextBox.Size = new Size(396, 25);
            songIDTextBox.TabIndex = 17;
            songIDTextBox.TabStop = false;
            // 
            // songRatingLabel
            // 
            songRatingLabel.AutoSize = true;
            songRatingLabel.Location = new Point(18, 205);
            songRatingLabel.Name = "songRatingLabel";
            songRatingLabel.Size = new Size(149, 18);
            songRatingLabel.TabIndex = 8;
            songRatingLabel.Text = "Readiness Rating:";
            // 
            // lengthLabel
            // 
            lengthLabel.AutoSize = true;
            lengthLabel.Location = new Point(20, 170);
            lengthLabel.Name = "lengthLabel";
            lengthLabel.Size = new Size(69, 18);
            lengthLabel.TabIndex = 7;
            lengthLabel.Text = "Length:";
            // 
            // asPerfomedLabel
            // 
            asPerfomedLabel.AutoSize = true;
            asPerfomedLabel.Location = new Point(20, 135);
            asPerfomedLabel.Name = "asPerfomedLabel";
            asPerfomedLabel.Size = new Size(145, 18);
            asPerfomedLabel.TabIndex = 6;
            asPerfomedLabel.Text = "As Performed By:";
            // 
            // artistLabel
            // 
            artistLabel.AutoSize = true;
            artistLabel.Location = new Point(20, 99);
            artistLabel.Name = "artistLabel";
            artistLabel.Size = new Size(136, 18);
            artistLabel.TabIndex = 5;
            artistLabel.Text = "Original Artist:";
            // 
            // songNameLabel
            // 
            songNameLabel.AutoSize = true;
            songNameLabel.Location = new Point(20, 64);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(94, 18);
            songNameLabel.TabIndex = 4;
            songNameLabel.Text = "Song Name:";
            // 
            // songIDLabel
            // 
            songIDLabel.AutoSize = true;
            songIDLabel.Location = new Point(20, 29);
            songIDLabel.Name = "songIDLabel";
            songIDLabel.Size = new Size(70, 18);
            songIDLabel.TabIndex = 3;
            songIDLabel.Text = "Song ID:";
            // 
            // SetListManager_Form
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(921, 872);
            Controls.Add(songInfoTextBox);
            Controls.Add(setlistInfoGroupBox);
            Controls.Add(bandInfoGroupBox);
            Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SetListManager_Form";
            Text = "SetList Manager";
            bandInfoGroupBox.ResumeLayout(false);
            bandInfoGroupBox.PerformLayout();
            setlistInfoGroupBox.ResumeLayout(false);
            setlistInfoGroupBox.PerformLayout();
            songInfoTextBox.ResumeLayout(false);
            songInfoTextBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox bandListBox;
        private ListBox setlistListBox;
        private ListBox songListBox;
        private GroupBox bandInfoGroupBox;
        private GroupBox setlistInfoGroupBox;
        private GroupBox songInfoTextBox;
        private Label genreLabel;
        private Label bandMembersLabel;
        private Label bandNameLabel;
        private Label bandIDLabel;
        private Label durationLabel;
        private Label numberSongsLabel;
        private Label setlistRatingLabel;
        private Label moodLabel;
        private Label setlistNameLabel;
        private Label setlistIDLabel;
        private Label asPerfomedLabel;
        private Label artistLabel;
        private Label songNameLabel;
        private Label songIDLabel;
        private Label songRatingLabel;
        private Label lengthLabel;
        private TextBox genreTextBox;
        private TextBox bandMembersTextBox;
        private TextBox bandNameTextBox;
        private TextBox bandIDTextBox;
        private Button deleteBandButton;
        private Button clearBandButton;
        private Button editBandButton;
        private Button addBandButton;
        private Button deleteSetlistButton;
        private Button clearSetlistButton;
        private Button editSetlistButton;
        private Button addSetlistButton;
        private TextBox durationTextBox;
        private TextBox numberSongsTextBox;
        private TextBox setlistRatingTextBox;
        private TextBox moodTextBox;
        private TextBox setlistNameTextBox;
        private TextBox setlistIDTextBox;
        private Button deleteSongButton;
        private Button clearSongButton;
        private Button editSongButton;
        private Button addSongButton;
        private TextBox songRatingTextBox;
        private TextBox lengthTextBox;
        private TextBox asPerformedTextBox;
        private TextBox artistTextBox;
        private TextBox songNameTextBox;
        private TextBox songIDTextBox;
    }
}
