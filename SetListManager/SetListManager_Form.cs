namespace SetListManager
{
    public partial class SetListManager_Form : Form
    {
        public SetListManager_Form()
        {
            InitializeComponent();
        }

        private void addBandButton_Click(object sender, EventArgs e)
        {
            if ((bandNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Band Name TextBox can not be blank.");
                bandNameTextBox.Focus();
                return;
            }
            else if ((bandMembersTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Band Members TextBox can not be blank.");
                bandMembersTextBox.Focus();
                return;
            }
            else if ((genreTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Genre TextBox can not be blank.");
                genreTextBox.Focus();
                return;
            }
            else
            {
                //Good Code goes here
                Msg("Good Validated Code");
            }
        }

        private void editBandButton_Click(object sender, EventArgs e)
        {

        }

        private void clearBandButton_Click(object sender, EventArgs e)
        {
            ClearBand();
        }

        private void deleteBandButton_Click(object sender, EventArgs e)
        {

        }

        private void bandListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addSetlistButton_Click(object sender, EventArgs e)
        {
            if ((setlistNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("SetList Name TextBox can not be blank.");
                setlistNameTextBox.Focus();
                return;
            }
            else if ((moodTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("SetList Overall Mood TextBox can not be blank.");
                moodTextBox.Focus();
                return;
            }
            else if ((setlistRatingTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("SetList Rating TextBox can not be blank.");
                setlistRatingTextBox.Focus();
                return;
            }
            else if ((numberSongsTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("SetList Number of Songs TextBox can not be blank.");
                numberSongsTextBox.Focus();
                return;
            }
            else if ((durationTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("SetList Duration TextBox can not be blank.");
                durationTextBox.Focus();
                return;
            }
            else
            {
                //Good Code goes here
                Msg("Good Validated Code");
            }
        }

        private void editSetlistButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSetlistButton_Click(object sender, EventArgs e)
        {
            ClearSetList();
        }

        private void deleteSetlistButton_Click(object sender, EventArgs e)
        {

        }

        private void setlistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            if ((songNameTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Song Name TextBox can not be blank.");
                songNameTextBox.Focus();
                return;
            }
            else if ((artistTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Song's Original Artist TextBox can not be blank.");
                artistTextBox.Focus();
                return;
            }
            else if ((asPerformedTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("As Performed By TextBox can not be blank.");
                asPerformedTextBox.Focus();
                return;
            }
            else if ((lengthTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Song's Length TextBox can not be blank.");
                lengthTextBox.Focus();
                return;
            }
            else if ((songRatingTextBox.Text ?? "") == (string.Empty ?? ""))
            {
                Msg("Song's Readiness Rating TextBox can not be blank.");
                songRatingTextBox.Focus();
                return;
            }
            else
            {
                //Good Code goes here
                Msg("Good Validated Code");
            }
        }

        private void editSongButton_Click(object sender, EventArgs e)
        {

        }

        private void clearSongButton_Click(object sender, EventArgs e)
        {
            ClearSong();
        }

        private void deleteSongButton_Click(object sender, EventArgs e)
        {

        }

        private void songListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ClearBand()
        {
            this.bandIDTextBox.Clear();
            this.bandNameTextBox.Clear();
            this.bandMembersTextBox.Clear();
            this.genreTextBox.Clear();
        }

        public void ClearSetList()
        {
            this.setlistIDTextBox.Clear();
            this.setlistNameTextBox.Clear();
            this.moodTextBox.Clear();
            this.setlistRatingTextBox.Clear();
            this.numberSongsTextBox.Clear();
            this.durationTextBox.Clear();
        }

        public void ClearSong()
        {
            this.songIDTextBox.Clear();
            this.songNameTextBox.Clear();
            this.artistTextBox.Clear();
            this.asPerformedTextBox.Clear();
            this.lengthTextBox.Clear();
            this.songRatingTextBox.Clear();
        }

        public void ClearAll()
        {
            ClearBand();
            ClearSetList();
            ClearSong();
        }

        public void Msg(string msg)
        {
            MessageBox.Show(msg, "SetList Manager", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        }
    }
}
