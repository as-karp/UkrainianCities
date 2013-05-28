using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Mista_Ukraine
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox14.Checked = true;
            checkBox15.Checked = true;
            checkBox16.Checked = true;
            checkBox17.Checked = true;
            checkBox18.Checked = true;
            checkBox19.Checked = true;
            checkBox20.Checked = true;
            checkBox21.Checked = true;
            checkBox22.Checked = true;
            checkBox23.Checked = true;
            checkBox24.Checked = true;
            checkBox25.Checked = true;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
            checkBox17.Checked = false;
            checkBox18.Checked = false;
            checkBox19.Checked = false;
            checkBox20.Checked = false;
            checkBox21.Checked = false;
            checkBox22.Checked = false;
            checkBox23.Checked = false;
            checkBox24.Checked = false;
            checkBox25.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = 0; 
           
           
           


            if (checkBox1.Checked) 
                {
                
                    t += 1; 
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Волинська");               
                obl.Close();


               

                StreamReader streamReader = new StreamReader("Lutsk.txt"); //Открываем файл для чтения
                string str = ""; //Объявляем переменную, в которую будем записывать текст из файла
                string tmp_str;                                     
                while (!streamReader.EndOfStream) //Цикл длиться пока не будет достигнут конец файла
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Волинська" + "\r\n";
                     
                     //str += streamReader.ReadLine() + ":Волинська" + "\r\n"; //В переменную str по строчно записываем содержимое файла
                }                                    
                StreamWriter gra; 
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                
                gra.Write(str);
                gra.Close();


            }
            
            if (checkBox2.Checked) 
                {
                    t += 1; 
                    StreamWriter obl;
                    FileInfo ob = new FileInfo("tmp.txt");
                    obl = ob.AppendText();
                    obl.WriteLine("Рівненська");
                    obl.Close();


                   
                    StreamReader streamReader = new StreamReader("Rivne.txt");
                    string str = "";
                    string tmp_str;
                    while (!streamReader.EndOfStream) 
                    {
                        tmp_str = streamReader.ReadLine();
                        if (tmp_str != "") str += tmp_str + ":Рівненська" + "\r\n";                    
                    }

                    StreamWriter gra;
                    FileInfo gr = new FileInfo("gra.txt");
                    gra = gr.AppendText();
                    gra.Write(str);
                    gra.Close();
                }

            if (checkBox2.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Рівненська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Rivne.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Рівненська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox3.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Львівська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Lviv.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Львівська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox4.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Житомирська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Gutomur.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Житомирська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox5.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Тернопільська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Ternopil.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Тернопільська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox6.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Івано-Франківська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Ivano-Frankivsk.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Івано-Франківська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox7.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Закарпатська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Uzhgorod.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Закарпатська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox8.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Хмельницька");
                obl.Close();



                StreamReader streamReader = new StreamReader("Khmelnitsky.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Хмельницька" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox9.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Вінницька");
                obl.Close();



                StreamReader streamReader = new StreamReader("Vinnytsia.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Рівненська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox10.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Чернівецька");
                obl.Close();



                StreamReader streamReader = new StreamReader("Chernivtsi.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Чернівецька" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox11.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Київська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Kyiv.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Київська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox12.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Черкаська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Cherkasy.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Черкаська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox13.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Одеська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Odessa.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Одеська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox14.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Чернігівська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Chernihiv.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Чернігівська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox15.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Полтавська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Poltava.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Полтавська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox16.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Кіровоградська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Kirovohrad.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Кіровоградська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox17.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Миколаївська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Mykolaiv.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Миколаївська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox18.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Херсонська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Kherson.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Херсонська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox19.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Дніпропетровська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Dnipropetrovska.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Дніпропетровська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox20.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Запорізька");
                obl.Close();



                StreamReader streamReader = new StreamReader("Zaporizhzhya.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Запорізька" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox21.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Харківська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Kharkiv.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Харківська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox22.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Донецька");
                obl.Close();



                StreamReader streamReader = new StreamReader("Donetsk.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Донецька" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox23.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Луганська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Luhansk.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Луганська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox24.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("А.Р. Крим");
                obl.Close();



                StreamReader streamReader = new StreamReader("ARkrym.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":А.Р. Крим" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }

            if (checkBox25.Checked)
            {
                t += 1;
                StreamWriter obl;
                FileInfo ob = new FileInfo("tmp.txt");
                obl = ob.AppendText();
                obl.WriteLine("Сумська");
                obl.Close();



                StreamReader streamReader = new StreamReader("Sumy.txt");
                string str = "";
                string tmp_str;
                while (!streamReader.EndOfStream)
                {
                    tmp_str = streamReader.ReadLine();
                    if (tmp_str != "") str += tmp_str + ":Сумська" + "\r\n";
                }

                StreamWriter gra;
                FileInfo gr = new FileInfo("gra.txt");
                gra = gr.AppendText();
                gra.Write(str);
                gra.Close();
            }



            if (t == 0)
            {
                MessageBox.Show("Ви не вибрали жодної області");
            }
            else
            {
                Form3 f3 = new Form3();
                f3.Show();
                this.Hide();
            }
            
              
                

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Form2.ActiveForm.Close();
           // Form1 f1 = new Form1();
           // f1.Show();
            Application.Exit();
            
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            int ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            int ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            this.Location = new Point((ScreenWidth / 2) - (this.Width / 2),
                (ScreenHeight / 2) - (this.Height / 2));
        
        }
    }
}
