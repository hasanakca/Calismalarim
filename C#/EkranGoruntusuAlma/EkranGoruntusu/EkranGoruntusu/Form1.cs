using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using klavyeDinle;
namespace EkranGoruntusu
{
    public partial class Form1 : Form
    {
        globalKeyboardHook klavyeDinleyicisi = new globalKeyboardHook();
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetDesktopWindow();

        [StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);
        [DllImport("User32.dll")]
        static extern IntPtr GetDC(IntPtr hwnd);

        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);
        static void Ciz()
        {
            Pen redPen = new Pen(Color.Red, 5);
            IntPtr desktop = GetDC(IntPtr.Zero);
            using (Graphics g = Graphics.FromHdc(desktop))
            {
                g.DrawRectangle(redPen, 0, 0, 1599, 900);
            }
            ReleaseDC(IntPtr.Zero, desktop);
        }
        public void DinlenecekTuslariAyarla()
        {
            // hangi tuşları dinlemek istiyorsak burada ekliyoruz
            // Ben burada F,K ve M harflerine basılınca tetiklenecek şekilde ayarladım
            klavyeDinleyicisi.HookedKeys.Add(Keys.F12);
            
            //basıldığında ilk burası çalışır
            klavyeDinleyicisi.KeyDown += new KeyEventHandler(CaptureWindow);
            //basıldıktan sonra ikinci olarak burası çalışır

        }


        public Graphics captureGraphics;
        public Bitmap captureBitmap;
        private void CaptureWindow(object sender, KeyEventArgs e)
        
        {
            try

            {
                Ciz();
                captureBitmap = new Bitmap(1600, 862, PixelFormat.Format32bppArgb);


                Rectangle captureRectangle = Screen.AllScreens[0].Bounds;


                captureGraphics = Graphics.FromImage(captureBitmap);


                captureGraphics.CopyFromScreen(captureRectangle.Left, captureRectangle.Top, 0, 0, captureRectangle.Size);


                Form2 form2 = new Form2();
                form2.captureBitmap = captureBitmap;
                form2.Show();
                //captureBitmap.Save(@"C:\Users\Hasan\Desktop\YeniFoto2.png", ImageFormat.Png);

                //MessageBox.Show("Ekran görüntüsü alındı.");

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }
            e.Handled = false;
        }

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            DinlenecekTuslariAyarla();


        }

    }
}
