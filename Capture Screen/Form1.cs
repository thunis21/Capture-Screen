namespace Capture_Screen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void takeScreenShot()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                var file = string.Format(@"C:\temp\SCR{0}.png", DateTime.Now.Ticks);
                bmp.Save(file);  // saves the image
            }
            imageSlider1.Images.Add(bmp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            takeScreenShot();
        }
    }
}