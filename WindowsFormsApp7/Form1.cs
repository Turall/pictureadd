using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Images images = new Images();
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(images.getImage());
            //Image image = Image.FromFile(@"C:\Users\mura_hq22\Downloads\images\image2.jpg");
            //Point point = new Point(50, 50);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(images.getPrevImage());
        }
    }


    interface IImage
    {
        string getImage();
    }

    class Images: IImage
    {
        string[] arrayimagepath;
        int index = -1;
        public Images()
        {
            arrayimagepath = new string[3];
            arrayimagepath[0] = @"C:\Users\mura_hq22\Downloads\images\image 1.jfif";
            arrayimagepath[1] = @"C:\Users\mura_hq22\Downloads\images\image2.jfif";
            arrayimagepath[2] = @"C:\Users\mura_hq22\Downloads\images\images.jfif";
            
        }
        public string getImage()
        {
            index++;
            if(index < 0 || index > 2)
            {
                index = 2;
                return arrayimagepath[index];
            }
            return arrayimagepath[index];
        }
        public string getPrevImage ()
        {
            index--;
            if (index < 0 || index > 2)
            {
                index = 0;
                return arrayimagepath[index];
            }
            return arrayimagepath[index];
        }
    }
    class Path
    {

    }
}
