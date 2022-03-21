using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
       


        public Form1()
        {
            InitializeComponent();

        }




       // int Apple = Settings1.Default.apple;
        //int Orange = Settings1.Default.orange;
        //int Banana = Settings1.Default.banana  ;
        //int Grapes = Settings1.Default.grapes;
      //  int Strawberry = Settings1.Default.strawberry;
      //  int Mango = Settings1.Default.mango;
      //  int Avocado = Settings1.Default.avocado;
     //   int Watermelon = Settings1.Default.watermelon;
     //   int Tomato = Settings1.Default.tomato;
     //   int Potato = Settings1.Default.potato;
    //    int Onion = Settings1.Default.onion;
    //    int Lettuce = Settings1.Default.lettuce;
     //   int Corn = Settings1.Default.corn;
    //    int Carrot = Settings1.Default.carrot;
   //     int Pumpkin = Settings1.Default.pumpkin;
   //     int Cucumber = Settings1.Default.cucumber;
       int[] stacke=new int[1000000];
        int sum = 0;
       int max = 0;
        int counter = 0;
        int remainingchange = 0;
        int cheacker = 0;
        int valuetochange;
        int billnumber = 0;
        

        private void stacking(int productvalue)
        {
            
            max++;
            stacke[max] = productvalue;

            
        }
       
     
        
        private void popping()
        {
            sum = sum - stacke[max];
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum;
          
            max--;

        }
        private void DeleteLine(int a_line)
        {
            
            
                int start_index = richTextBox1.GetFirstCharIndexFromLine(a_line);
                int count = richTextBox1.Lines[a_line].Length;

                // Eat new line chars
                if (a_line < richTextBox1.Lines.Length - 1)
                {
                    count += richTextBox1.GetFirstCharIndexFromLine(a_line + 1) -
                        ((start_index + count - 1) + 1);

                }

                richTextBox1.Text = richTextBox1.Text.Remove(start_index, count);


            
        }
        private void changeprice(int product,int index)
        {
            richTextBox2.Text = "current price is ";
            richTextBox3.Text = product + "$";
            richTextBox5.Text = "New price ";
            valuetochange = index;
            
        }
      


        private void button_orange(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.orange;
                richTextBox1.Text = richTextBox1.Text + "ORANGE " + Settings1.Default.orange + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.orange);
            }
            else {
                changeprice(Settings1.Default.orange,1);


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_apple(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.apple;
                richTextBox1.Text = richTextBox1.Text + "APPLE " + Settings1.Default.apple + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.apple);
            }
            else
            {
                changeprice(Settings1.Default.apple,2);

            }
        }


            private void button_banana(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.banana;
                richTextBox1.Text = richTextBox1.Text + "BANANA" + Settings1.Default.banana + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.banana);
            }
            else
            {
                changeprice(Settings1.Default.banana,3);

            }
            
        }
        

        private void button_grapes(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.grapes;
                richTextBox1.Text = richTextBox1.Text + "GRAPES " + Settings1.Default.grapes + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.grapes);
            }
            else
            {
                changeprice(Settings1.Default.grapes, 4);

            }

            
        }

        private void button_strawberry(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.strawberry;
                richTextBox1.Text = richTextBox1.Text + "STRAWBERY" + Settings1.Default.strawberry + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.strawberry);
            }
            else { changeprice(Settings1.Default.strawberry, 5); }
        }

        private void button_mango(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.mango;
                richTextBox1.Text = richTextBox1.Text + "MANGO " + Settings1.Default.mango + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.mango);
            }
            else { changeprice(Settings1.Default.mango, 6); }
            
        }

        private void button_avocado(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.avocado;
                richTextBox1.Text = richTextBox1.Text + "AVOCADO " + Settings1.Default.avocado + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.avocado);

            }
            else { changeprice(Settings1.Default.avocado, 7); }
        }

        private void button_watermelon(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.watermelon;
            richTextBox1.Text = richTextBox1.Text + "WATERMELON " + Settings1.Default.watermelon + "$ +1\n";
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum + "$";
            stacking(Settings1.Default.watermelon); }


            else { changeprice(Settings1.Default.watermelon,8); }
        }

        private void button_tomato(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.tomato;
                richTextBox1.Text = richTextBox1.Text + "TOMATO " + Settings1.Default.tomato + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.tomato);

            }

            else { changeprice(Settings1.Default.tomato, 9); }
        }

        private void button_potato(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.potato;
            richTextBox1.Text = richTextBox1.Text + "POTATO " + Settings1.Default.potato + "$\t +1\n";
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum + "$";
            stacking(Settings1.Default.potato);
        }else { changeprice(Settings1.Default.potato, 10);
    }
}

        private void button_onion(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.onion;
                richTextBox1.Text = richTextBox1.Text + "ONION " + Settings1.Default.onion + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.onion);
            }
            else
            {
                changeprice(Settings1.Default.onion, 11);
            }
            }

        private void button_lettuce(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.lettuce;
                richTextBox1.Text = richTextBox1.Text + "LETTUCE " + Settings1.Default.lettuce + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.lettuce);
            }
            else
            {
                changeprice(Settings1.Default.lettuce, 12);
            }
        }

        private void button_corn(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum =sum + Settings1.Default.corn;
            richTextBox1.Text = richTextBox1.Text + "CORN " + Settings1.Default.corn + "$\t +1\n";
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum + "$";
            stacking(Settings1.Default.corn);
        }
            else
            {
                changeprice(Settings1.Default.corn, 13);
    }
}

        private void button_carrot(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum+ Settings1.Default.carrot;
            richTextBox1.Text = richTextBox1.Text + "CARROT " + Settings1.Default.carrot + "$\t +1\n";
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum + "$";
            stacking(Settings1.Default.carrot);
            }
            else
            {
                changeprice(Settings1.Default.carrot, 14);
            }
        }

        private void button_pumpkin(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum = sum + Settings1.Default.pumpkin;
                richTextBox1.Text = richTextBox1.Text + "PUMPKIN " + Settings1.Default.pumpkin + "$\t +1\n";
                textBox1.Clear();
                textBox1.Text = textBox1.Text + sum + "$";
                stacking(Settings1.Default.pumpkin);
            }
            else
            {
                changeprice(Settings1.Default.pumpkin, 15);
            }

        }

        private void button_cucumber(object sender, EventArgs e)
        {
            if (cheacker == 0)
            {
                sum =sum + Settings1.Default.cucumber;
            richTextBox1.Text = richTextBox1.Text + "CUCUMBER " + Settings1.Default.cucumber + "$\t +1\n";
            textBox1.Clear();
            textBox1.Text = textBox1.Text + sum + "$";
            stacking(Settings1.Default.cucumber);
            }
            else
            {
                changeprice(Settings1.Default.cucumber, 16);
            }
        }

        private void button_delete(object sender, EventArgs e)
        {
            if (max > 0)
            {
               
                popping();

                DeleteLine(max);
                
            }
        }

        private void pay(object sender, EventArgs e)
        {
            
            Settings1.Default.counter++;
            richTextBox1.Text = richTextBox1.Text + "\nthe sum is= " + sum + "$\nTAX= " + sum * 0.15 + "$\nbill number= "+ Settings1.Default.counter + "\n\n\n\n";
            //  richTextBox1.SaveFile("c:\temp\bills.txt", RichTextBoxStreamType.PlainText);
            Settings1.Default.bill = Settings1.Default.bill+ richTextBox1.Text;
            Settings1.Default.Save();
            sum = 0;
            textBox1.Clear();
            richTextBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           

        }

        private void change_prices(object sender, EventArgs e)
        {
            richTextBox2.Visible = true;
            richTextBox3.Visible = true;
            richTextBox4.Visible = true;
            richTextBox5.Visible = true;
            save.Visible = true;
            cheacker = 1;
        }

       

        private void SaveButton(object sender, EventArgs e)
        {
            richTextBox2.Visible = false;
            richTextBox3.Visible = false;
            richTextBox4.Visible = false;
            richTextBox5.Visible = false;
            save.Visible = false;
            if (richTextBox4.TextLength > 0)
            {
                switch (valuetochange)
                {
                    case 1:
                        Settings1.Default.orange = int.Parse(richTextBox4.Text);
                        break;
                    case 2:
                        Settings1.Default.apple = int.Parse(richTextBox4.Text);
                        break;
                    case 3:
                        Settings1.Default.banana = int.Parse(richTextBox4.Text);
                        break;
                    case 4:
                        Settings1.Default.grapes = int.Parse(richTextBox4.Text);
                        break;
                    case 5:
                        Settings1.Default.strawberry = int.Parse(richTextBox4.Text);
                        break;
                    case 6:
                        Settings1.Default.mango = int.Parse(richTextBox4.Text);
                        break;
                    case 7:
                        Settings1.Default.avocado = int.Parse(richTextBox4.Text);
                        break;
                    case 8:
                        Settings1.Default.watermelon = int.Parse(richTextBox4.Text);
                        break;
                    case 9:
                        Settings1.Default.tomato = int.Parse(richTextBox4.Text);
                        break;
                    case 10:
                        Settings1.Default.potato = int.Parse(richTextBox4.Text);
                        break;
                    case 11:
                        Settings1.Default.onion = int.Parse(richTextBox4.Text);
                        break;
                    case 12:
                        Settings1.Default.lettuce = int.Parse(richTextBox4.Text);
                        break;
                    case 13:
                        Settings1.Default.corn = int.Parse(richTextBox4.Text);
                        break;
                    case 14:
                        Settings1.Default.carrot = int.Parse(richTextBox4.Text);
                        break;
                    case 15:
                        Settings1.Default.pumpkin = int.Parse(richTextBox4.Text);
                        break;
                    case 16:
                        Settings1.Default.cucumber = int.Parse(richTextBox4.Text);
                        break;


                }
            }
            richTextBox4.Clear();
            richTextBox2.Clear();
            richTextBox3.Clear();
            richTextBox5.Clear();
            Settings1.Default.Save();
            cheacker = 0;
        }

        private void Cancel(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            sum = 0;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void cal(object sender, EventArgs e)
        {
            

            if (textBox2.TextLength > 0)
            {
                remainingchange = int.Parse(textBox2.Text);


            }
            textBox3.Text = remainingchange-sum + "$";

        }

        private void fsafas(object sender, EventArgs e)
        {

        }

        private void showbill(object sender, EventArgs e)
        {
            richTextBox6.Visible = true;
            richTextBox6.Text = Settings1.Default.bill;
            button3.Visible = true;

        }

        private void closebills(object sender, EventArgs e)
        {
            richTextBox6.Visible = false;
            button3.Visible = false;
        }

        private void mohammed(object sender, EventArgs e)
        {
            
        }
    }
}
