using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Mista_Ukraine
{
    public partial class Form3 : Form
    {
        public string bukvapl;
        public string bukvacomp;
        public int n;
        public string[] baza = new string[100];
        public string[] bazaObl = new string[100];
        public Form3()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

            FileInfo gra = new FileInfo("gra.txt");
            gra.Delete();
            FileInfo tmp = new FileInfo("tmp.txt");
            tmp.Delete();
            /*StreamWriter gra = new StreamWriter("gra.txt");
            
            gra.WriteLine("");
            gra.Close();
            StreamWriter tmp = new StreamWriter("tmp.txt");
            tmp.WriteLine("");
            tmp.Close();*/
            Application.Exit();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2),
                (ScreenHeight / 2) - (this.Height / 2));

            System.Windows.Forms.InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("uk-UA"));           
            button3.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string buf = "";
            string perevirka = "";
            int i = 0;
            int povtor = new int(); 
            int r = new int();
            string obl = "";
            int k1 = 0;
            int z = 0;
            string hidpl = textBox1.Text;
            if (hidpl == "" & dataGridView1.SelectedCells[0].RowIndex > 0)
            {
                MessageBox.Show("Введіть назву міста");
            }
            else
            {
                StreamReader streame = new StreamReader("gra.txt");
                while ((!streame.EndOfStream) & (perevirka != hidpl))
                {
                    perevirka = "";
                    buf = streame.ReadLine();
                    if (buf.Length > 0)
                    {
                        i = 0;
                        while (buf[i] != ':')
                        {
                            perevirka += buf[i];
                            i = i + 1;
                        }
                    }
                }

                //if ((dataGridView1.SelectedCells.Count>0))                 
                    if (dataGridView1.SelectedCells[0].RowIndex > 0)
                {
                    if ((perevirka == hidpl) & (perevirka[0] == bukvacomp[0]/*bukvapl[0]*/))
                    {
                        r = 0;
                        povtor = 0;
                        for (int l = 0; l <= n; l++)
                        {
                            obl = buf;
                            obl = obl.Remove(0, i + 1);
                            if ((perevirka == baza[l]) & (obl == bazaObl[l]))
                            {
                                r = r + 1;
                            }
                            if ((perevirka == baza[l]) & (obl != bazaObl[l]))
                            {
                                povtor = povtor + 1;
                            }
                        }
                        if ((r == 0) | (r > 0) & (povtor > 0))
                        {
                            obl = buf;
                            obl = obl.Remove(0, i + 1);
                            dataGridView1.Rows.Add(perevirka, obl);
                            textBox1.Text = "";
                            bukvapl = perevirka.Remove(0, i - 1);
                            if (bukvapl == "ь")
                            {
                                bukvapl = perevirka.Remove(0, i - 2);
                                bukvapl = bukvapl.Remove(1, 1);
                            }
                            else
                            {
                                if (bukvapl == "и")
                                {
                                    bukvapl = perevirka.Remove(0, i - 2);
                                    bukvapl = bukvapl.Remove(1, 1);
                                }
                                else
                                {
                                    if ((bukvapl == "й") & ((perevirka.Remove(0, i - 2)) != "ий"))
                                    {
                                        bukvapl = perevirka.Remove(0, i - 2);
                                        bukvapl = bukvapl.Remove(1, 1);
                                    }
                                    else
                                    {
                                        if ((bukvapl == "й") & ((perevirka.Remove(0, i - 2)) == "ий"))
                                        {
                                            bukvapl = perevirka.Remove(0, i - 3);
                                            bukvapl = bukvapl.Remove(1, 2);
                                        }
                                    }
                                }
                            }
                            bukvapl = bukvapl.ToUpper();
                            label3.Text = bukvapl;
                            z = 1;
                            n = n + 1;
                            baza[n] = perevirka;
                            bazaObl[n] = obl;
                        }
                        else
                        {
                            MessageBox.Show("Таке місто вже було назване");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ваш хід" + " " + hidpl + " " + " - неправельний");
                    }                    
                }
                streame.Close();
            }
            
            if (hidpl == "" & dataGridView1.SelectedCells[0].RowIndex == 0)
            {
                MessageBox.Show("Введіть назву міста");
            }
            else
            {
                //if ((dataGridView1.SelectedCells.Count == 0)) 
                if (dataGridView1.SelectedCells[0].RowIndex == 0)
                {
                    if (perevirka == hidpl)
                    {
                        r = 0;
                        povtor = 0;
                        for (int l = 0; l <= n; l++)
                        {
                            obl = buf;
                            obl = obl.Remove(0, i + 1);
                            if ((perevirka == baza[l]) & (obl == bazaObl[l]))
                            {
                                r = r + 1;
                            }
                            if ((perevirka == baza[l]) & (obl != bazaObl[l]))
                            {
                                povtor = povtor + 1;
                            }
                        }
                        obl = buf;
                        obl = obl.Remove(0, i + 1);
                        dataGridView1.Rows.Add(perevirka, obl);
                        textBox1.Text = "";
                        bukvapl = perevirka.Remove(0, i - 1);
                        if (bukvapl == "ь")
                        {
                            bukvapl = perevirka.Remove(0, i - 2);
                            bukvapl = bukvapl.Remove(1, 1);
                        }
                        else
                        {
                            if (bukvapl == "и")
                            {
                                bukvapl = perevirka.Remove(0, i - 2);
                                bukvapl = bukvapl.Remove(1, 1);
                            }
                            else
                            {
                                if ((bukvapl == "й") & ((perevirka.Remove(0, i - 2)) != "ий"))
                                {
                                    bukvapl = perevirka.Remove(0, i - 2);
                                    bukvapl = bukvapl.Remove(1, 1);
                                }
                                else
                                {
                                    if ((bukvapl == "й") & ((perevirka.Remove(0, i - 2)) == "ий"))
                                    {
                                        bukvapl = perevirka.Remove(0, i - 3);
                                        bukvapl = bukvapl.Remove(1, 2);
                                    }
                                }
                            }
                        }
                        bukvapl = bukvapl.ToUpper();
                        label3.Text = bukvapl;
                        z = 1;
                        n = n + 1;
                        baza[n] = perevirka;
                        bazaObl[n] = obl;

                    }
                    k1 = k1 + 1;
                    if ((hidpl != "") & (z == 0))
                    {
                        MessageBox.Show("Ваш хід" + " " + hidpl + " " + " - неправельний");
                    }
                }
            }
            string vidpovid = " ";
            int z1 = 0;
            /*if (perevirka == "")
            {
                MessageBox.Show("Введіть назву міста");
            }
            else*/
            //{
                if (z == 1)
                {
                    StreamReader stream = new StreamReader("gra.txt");
                    while (!stream.EndOfStream) //& (vidpovid[0] != bukvapl[0]))
                    {
                        vidpovid = "";
                        buf = stream.ReadLine();
                        if (buf.Length > 0)
                        {
                            i = 0;
                            while (buf[i] != ':')
                            {
                                vidpovid += buf[i];
                                i = i + 1;
                            }
                        }


                        if ((vidpovid[0] == bukvapl[0]) & (z1 != 1))
                        {
                            r = 0;
                            for (int l = 0; l <= n; l++)
                            {
                                obl = buf;
                                obl = obl.Remove(0, i + 1);
                                if (vidpovid == baza[l])
                                {
                                    r = r + 1;
                                }
                            }

                            if (r == 0)
                            {

                                obl = buf;
                                obl = obl.Remove(0, i + 1);
                                dataGridView2.Rows.Add(vidpovid, obl);

                                bukvacomp = vidpovid.Remove(0, i - 1);
                                if (bukvacomp == "ь")
                                {
                                    bukvacomp = vidpovid.Remove(0, i - 2);
                                    bukvacomp = bukvacomp.Remove(1, 1);
                                }
                                else
                                {
                                    if (bukvacomp == "и")
                                    {
                                        bukvacomp = vidpovid.Remove(0, i - 2);
                                        bukvacomp = bukvacomp.Remove(1, 1);
                                    }
                                    else
                                    {
                                        if ((bukvacomp == "й") & ((vidpovid.Remove(0, i - 2)) != "ий"))
                                        {
                                            bukvacomp = vidpovid.Remove(0, i - 2);
                                            bukvacomp = bukvacomp.Remove(1, 1);
                                        }
                                        else
                                        {
                                            if ((bukvacomp == "й") & ((vidpovid.Remove(0, i - 2)) == "ий"))
                                            {
                                                bukvacomp = vidpovid.Remove(0, i - 3);
                                                bukvacomp = bukvacomp.Remove(1, 2);
                                            }
                                        }
                                    }
                                }
                                bukvacomp = bukvacomp.ToUpper();
                                label3.Text = bukvacomp;
                                z1 = 1;
                                n = n + 1;
                                baza[n] = vidpovid;
                                bazaObl[n] = obl;
                                textBox2.Text = vidpovid;
                            }
                        }
                    }
                    stream.Close();
                }
                
            //}
            
            if ((z1 == 0) & (z > 0))
            {
                MessageBox.Show("В програми немає ходів! Ви перемогли");
                button1.Hide();
                //button3.Show();
            }                      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Show();
            button3.Hide();
            bukvapl = " ";
            bukvacomp = " " ;
            for (int i = 0; i <= n; i++)
            {
                bazaObl[i] = " ";
            }
            for (int i = 0; i <= n; i++)
            {
                baza[i] = " ";
            }
            n = 0;
            label3.Text = "";
            textBox2.Text = "";
            //dataGridView1.Rows.Clear();
            //dataGridView2.Rows.Clear();
                        
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.CurrentCell = dataGridView1[0, 0];
                dataGridView1.Rows.Remove(dataGridView1.Rows[1]);
            }
            for (int i = 1; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.CurrentCell = dataGridView2[0, 0];
                dataGridView2.Rows.Remove(dataGridView2.Rows[1]);
            }
           
            
                //dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);

            
           /*  for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(i);
            }
            for (int i = 1; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows.RemoveAt(i);
            }*/
            
            
            /*while (dataGridView2.Rows.Count != 1)
            dataGridView2.Rows.Remove(dataGridView2.Rows[dataGridView2.Rows.Count - 1]);
            while (dataGridView1.Rows.Count != 1)
            dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);
            */
        }
    }
}

