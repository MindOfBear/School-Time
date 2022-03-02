using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SchoolTime
{
    public partial class mainWindow : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (

            ///////////// ROUNDED CORNERS COORDS /////////////////////////
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public mainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            DateTime sesiune = DateTime.Parse("6/5/2022");
            DateTime sesiuneStart = DateTime.Now;
            TimeSpan sesiuneCount = sesiune - sesiuneStart;
            SesiuneCounter.Text = "Sesiune in " + sesiuneCount.Days + " zile";

            sesiuneprogress.Minimum = sesiuneStart.Day;
            sesiuneprogress.Maximum = sesiune.Day;
            sesiuneprogress.Value = sesiune.Day - sesiuneStart.Day;




            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                Orar.Text = "Today you dont have any courses! :)\n njoy your freetime!";
                dayofweek.Text = "luni";
            }
           else if (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday)
            {
                Orar.Text = "14-16  Inteligenta Artificiala  I. Tudor\n16-20  Geometrie Computationala  C.Dinu\nSAU\n16-20  Structuri de date  I.Tudor";
                dayofweek.Text = "marti";
            }
           else if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                Orar.Text = "08-10  Programare Orientata Obiect  Gabroveanu\n10-12  Structuri de date  Belciug\n14-16  Geometrie Computationala  Boldea";
                dayofweek.Text = "miercuri";
            }
          else  if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                Orar.Text = "10-12  Sport\n12-14  Sisteme de operare  Stancu\n14-16  Inteligenta Artificiala  Stoean";
                dayofweek.Text = "joi";
            }
          else  if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
            {
                Orar.Text = "08-10  Engleza  Demetrian\n10-12 Programare Orientata Obiect  Slabu\n16-20  Sisteme Operare  Istrate";
                dayofweek.Text = "vineri";
            }
        }

        private void closeApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dayofweek_Click(object sender, EventArgs e)
        {
           
        }

        private void Orar_Click(object sender, EventArgs e)
        {

        }
        private void SesiuneCounter_Click(object sender, EventArgs e)
        {

        }

        private void sesiuneprogress_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void browser_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://stiinte.ucv.ro");
        }
    }
}
