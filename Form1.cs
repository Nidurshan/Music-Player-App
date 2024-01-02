namespace Music_Player_App
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            LblLogo = new Label();
            listBoxSongs = new ListBox();
            btnSelectSongs = new Button();
            LblFooter = new Label();
            pictureBox2 = new PictureBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.PaleTurquoise;
            TopPanel.Controls.Add(pictureBox2);
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(LblLogo);
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(759, 47);
            TopPanel.TabIndex = 0;
            TopPanel.Paint += TopPanel_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(705, 116);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(27, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LblLogo
            // 
            LblLogo.AutoSize = true;
            LblLogo.Font = new Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LblLogo.Location = new Point(7, 11);
            LblLogo.Name = "LblLogo";
            LblLogo.Size = new Size(188, 25);
            LblLogo.TabIndex = 1;
            LblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            listBoxSongs.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxSongs.FormattingEnabled = true;
            listBoxSongs.ItemHeight = 20;
            listBoxSongs.Location = new Point(512, 64);
            listBoxSongs.Name = "listBoxSongs";
            listBoxSongs.Size = new Size(202, 284);
            listBoxSongs.TabIndex = 1;
            // 
            // btnSelectSongs
            // 
            btnSelectSongs.BackColor = Color.OrangeRed;
            btnSelectSongs.FlatStyle = FlatStyle.Flat;
            btnSelectSongs.ForeColor = Color.White;
            btnSelectSongs.Location = new Point(512, 354);
            btnSelectSongs.Name = "btnSelectSongs";
            btnSelectSongs.Size = new Size(202, 35);
            btnSelectSongs.TabIndex = 2;
            btnSelectSongs.Text = "Select Songs";
            btnSelectSongs.UseVisualStyleBackColor = false;
            // 
            // LblFooter
            // 
            LblFooter.AutoSize = true;
            LblFooter.ForeColor = SystemColors.ControlDarkDark;
            LblFooter.Location = new Point(307, 412);
            LblFooter.Name = "LblFooter";
            LblFooter.Size = new Size(137, 15);
            LblFooter.TabIndex = 4;
            LblFooter.Text = "Developed By Nidurshan";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(692, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(16, 64);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(480, 325);
            axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // MusicPlayerApp
            // 
            ClientSize = new Size(730, 436);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(LblFooter);
            Controls.Add(btnSelectSongs);
            Controls.Add(listBoxSongs);
            Controls.Add(TopPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MusicPlayerApp";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Music Player App";
            Load += MusicPlayerApp_Load;
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void MusicPlayerApp_Load(object sender, EventArgs e)
        {

        }

        private Panel TopPanel;

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private Label LblLogo;
        private PictureBox pictureBox1;
        private ListBox listBoxSongs;
        private Button btnSelectSongs;
        private Label LblFooter;
        private PictureBox pictureBox2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}
