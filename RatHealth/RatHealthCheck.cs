using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace RatHealth
{
    public partial class RatHealthCheck : Form
    {
        public static string rat_no;
        public static string name_val;
        

        
        public static StringBuilder nose_char = new StringBuilder();
        public static StringBuilder teeth_char = new StringBuilder();
        public static StringBuilder eyes_char = new StringBuilder();
        public static StringBuilder ears_char = new StringBuilder();
        public static StringBuilder cheeks_char = new StringBuilder();
        public static StringBuilder chest_char = new StringBuilder();
        public static StringBuilder kidney_char = new StringBuilder();
        public static StringBuilder penis_char = new StringBuilder();
        public static StringBuilder testicles_char = new StringBuilder();
        public static StringBuilder tail_char = new StringBuilder();
        public static StringBuilder body_char = new StringBuilder();
        public static StringBuilder grooming_char = new StringBuilder();
        public static StringBuilder skin_char = new StringBuilder();
        public static StringBuilder faeces_char = new StringBuilder();
        public static StringBuilder posture_char = new StringBuilder();

        public StringBuilder[] feature_array = new StringBuilder[] {nose_char, teeth_char, eyes_char, ears_char, cheeks_char, chest_char, kidney_char,penis_char,testicles_char, tail_char, body_char,grooming_char,skin_char, faeces_char, posture_char };
        
        

        public RatHealthCheck()
        {

            InitializeComponent();
            

        }

        private void nose_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            
        }
        private void submit_Click(object sender, EventArgs e)
        {
            var date = DateTime.Now.ToShortDateString();
            ListBox[] tb = { nose, teeth, eyes, ears, cheeks, chest, kidney, penis, testicles, tail, body, grooming, skin, faeces, posture };
            int i = 0;
            foreach (StringBuilder feature in feature_array)
            {
                var temp = tb[i];
                foreach (object item in temp.SelectedItems)
                {
                    feature.Append(item.ToString());
                    feature.Append(" ");
                }
                ++i;
            }
            CsvFile.openCsvWriter(rat_no);
            CsvFile.CsvWriter.Write($"{name_val},{DateTime.Now.ToShortDateString()}, Age: {age.Text.ToString()},Weight: {weight.Text.ToString()},Overall:{overall.SelectedItem.ToString()}, Nose:{nose_char}, Teeth:{teeth_char}, Eyes:{eyes_char}, Ears: {ears_char}, Cheeks:{cheeks_char}, Chest:{chest_char}, Kidney:{kidney_char}, Penis:{penis_char}, Testicles:{testicles_char}, Tail:{tail_char}, Body:{body_char}, Grooming:{grooming_char}, Skin: {skin_char}, Faeces:{faeces_char}, Posture:{ posture_char}, Notes:{notes.Text.ToString()} \n");
            CsvFile.closeWriter();
            if (!Directory.Exists($@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Rat Health\CurrentRats\{rat_no}"))
                Directory.CreateDirectory($@"C:\Users\sahanasrivathsa\Documents\Barnes Lab\Rat Health\CurrentRats\{rat_no}");
            var bmpScreenCapture = new Bitmap(Width, Height);
            DrawToBitmap(bmpScreenCapture, new Rectangle(0, 0, bmpScreenCapture.Width, bmpScreenCapture.Height));
            bmpScreenCapture.Save(
                $"C:\\Users\\sahanasrivathsa\\Documents\\Barnes Lab\\Rat Health\\CurrentRats\\{rat_no}\\{DateTime.Now.ToString("yyyyMMdd")}.gif",
                ImageFormat.Gif);


            this.Close();
        }

        private void posture_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void penis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

