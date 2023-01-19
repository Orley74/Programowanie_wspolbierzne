
//Chwaszcz Kacper

using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace projektPW2
{
    public partial class Form1 : Form
    {
        //deklaracja zmiennych globalnych 
        public PictureBox[] Boxes = new PictureBox[109]; 
        public PictureBox[] Regal1 = new PictureBox[32]; 
        public PictureBox[] Regal2 = new PictureBox[32];
        public PictureBox[] Regal3 = new PictureBox[32];
        public PictureBox[] Regal4 = new PictureBox[14];
       
        public static SemaphoreSlim Reg1 = new SemaphoreSlim(1, 1);//semafory blokujace regaly
        public static SemaphoreSlim Reg2 = new SemaphoreSlim(1, 1);
        public static SemaphoreSlim Reg3 = new SemaphoreSlim(1, 1);
        public static SemaphoreSlim Reg4 = new SemaphoreSlim(1, 1);
        public static SemaphoreSlim Check = new SemaphoreSlim(1, 1); 
        int pozostale1 = 31, pozostale2 = 31, pozostale3 = 31, pozostale4 = 12; //zmienne pomocnicze do sprawdzenia ile przedmiotow pozostalo na regale
        int a = 6;


        public Form1()
        {   int a = 6;
            InitializeComponent();
            start();
            for (int i = 0; i < 5; i++)//utworzenie watkow klientow
            {
                Thread watki = new Thread(Buy);
                watki.Name = i.ToString();
                watki.IsBackground = true;
                
                watki.Start();
            }

            for (int i = 5; i < 8; i++)//utworzenie watkow pracownikow
            {
                Thread watki = new Thread(Add);
                watki.Name = i.ToString();
                watki.IsBackground = true;
                watki.Start();
            }
        }


        
        
        public void start()
        {

            if (true)
            {

                PictureBox Polka1 = pictureBox1;
                PictureBox Polka2 = pictureBox2;
                PictureBox Polka3 = pictureBox3;
                //-----------
                //POLKA 1
                //---------
               
                Boxes[0] = Regal4_1;
                Boxes[1] = Regal4_2;
                Boxes[2] = Regal1_25;
                Boxes[3] = Regal1_27;
                Boxes[4] = Regal1_26;
                Boxes[5] = Regal1_28;
                Boxes[6] = Regal1_29;
                Boxes[7] = Regal1_30;
                Boxes[8] = Regal1_31;
                Boxes[9] = Regal1_32;
                Boxes[10] = Regal1_24;
                Boxes[11] = Regal1_23;
                Boxes[12] = Regal1_22;
                Boxes[13] = Regal1_21;
                Boxes[14] = Regal1_20;
                Boxes[15] = Regal1_18;
                Boxes[16] = Regal1_19;
                Boxes[17] = Regal1_17;
                Boxes[18] = Regal1_16;
                Boxes[19] = Regal1_15;
                Boxes[20] = Regal1_14;
                Boxes[21] = Regal1_13;
                Boxes[22] = Regal1_12;
                Boxes[23] = Regal1_10;
                Boxes[24] = Regal1_11;
                Boxes[25] = Regal1_9;
                Boxes[26] = Regal1_8;
                Boxes[27] = Regal1_7;
                Boxes[28] = Regal1_6;
                Boxes[29] = Regal1_5;
                Boxes[30] = Regal1_4;
                Boxes[31] = Regal1_2;
                Boxes[32] = Regal1_3;
                Boxes[33] = Regal1_1;
                for (int i = 2; i < 34; i++)
                {
                    Regal1[i - 2] = Boxes[i];
                }
                //-----------------------
                //POLKA 2 
                //-----------------------
                Boxes[34] = Regal2_22;
                Boxes[35] = Regal2_7;
                Boxes[36] = Regal2_6;
                Boxes[37] = Regal2_5;
                Boxes[38] = Regal2_4;
                Boxes[39] = Regal2_2;
                Boxes[40] = Regal2_3;
                Boxes[41] = Regal2_1;
                Boxes[42] = Regal2_16;
                Boxes[43] = Regal2_15;
                Boxes[44] = Regal2_14;
                Boxes[45] = Regal2_13;
                Boxes[46] = Regal2_12;
                Boxes[47] = Regal2_10;
                Boxes[48] = Regal2_11;
                Boxes[49] = Regal2_9;
                Boxes[50] = Regal2_24;
                Boxes[51] = Regal2_23;
                Boxes[52] = Regal2_21;
                Boxes[53] = Regal2_20;
                Boxes[54] = Regal2_18;
                Boxes[55] = Regal2_19;
                Boxes[56] = Regal2_17;
                Boxes[57] = Regal2_32;
                Boxes[58] = Regal2_31;
                Boxes[59] = Regal2_30;
                Boxes[60] = Regal2_29;
                Boxes[61] = Regal2_28;
                Boxes[62] = Regal2_26;
                Boxes[63] = Regal2_27;
                Boxes[64] = Regal2_25;
                Boxes[69] = Regal2_8;

                for (int i = 34; i < 65; i++)
                {
                    Regal2[i - 34] = Boxes[i];
                }
                Regal2[31] = Regal2_8;

                //---------------
                //POLKA 3
                //--------------
                Boxes[65] = Regal4_4;
                Boxes[66] = Regal4_5;
                Boxes[67] = Regal4_6;
                Boxes[68] = Regal4_7;

                Boxes[70] = Regal4_12;
                Boxes[71] = Regal4_3;
                Boxes[72] = Regal3_7;
                Boxes[73] = Regal3_6;
                Boxes[74] = Regal3_5;
                Boxes[75] = Regal4_8;
                Boxes[76] = Regal3_2;
                Boxes[77] = Regal3_3;
                Boxes[78] = Regal3_1;
                Boxes[79] = Regal3_16;
                Boxes[80] = Regal3_15;
                Boxes[81] = Regal3_14;
                Boxes[82] = Regal3_13;
                Boxes[83] = Regal3_12;
                Boxes[84] = Regal3_10;
                Boxes[85] = Regal3_11;
                Boxes[86] = Regal3_9;
                Boxes[87] = Regal3_24;
                Boxes[88] = Regal3_23;
                Boxes[89] = Regal3_22;
                Boxes[90] = Regal3_21;
                Boxes[91] = Regal3_20;
                Boxes[92] = Regal3_18;
                Boxes[93] = Regal3_19;
                Boxes[94] = Regal3_17;
                Boxes[95] = Regal3_32;
                Boxes[96] = Regal3_31;
                Boxes[97] = Regal3_30;
                Boxes[98] = Regal3_29;
                Boxes[99] = Regal3_28;
                Boxes[100] = Regal3_26;
                Boxes[101] = Regal3_27;
                Boxes[102] = Regal3_25;
                Boxes[103] = Regal4_9;
                Boxes[104] = Regal4_10;
                Boxes[105] = Regal4_11;
                Boxes[106] = Regal4_13;
                Boxes[107] = Regal3_8;
                Boxes[108] = Regal3_4;
                //3333333
                for (int i = 72; i < 103; i++)
                {
                    Regal3[i - 72] = Boxes[i];
                }
                Regal3[30] = Regal3_4;
                Regal3[31] = Regal3_8;
                Regal4[0] = Boxes[0];
                Regal4[1] = Boxes[1];
                Regal4[2] = Boxes[71];
                Regal4[3] = Boxes[65];
                Regal4[4] = Boxes[66];
                Regal4[5] = Boxes[67];
                Regal4[6] = Boxes[68];
                Regal4[7] = Boxes[75];
                Regal4[8] = Boxes[103];
                Regal4[9] = Boxes[104];
                Regal4[10] = Boxes[105];
                Regal4[11] = Boxes[106];
                Regal4[12] = Boxes[70];

            

                Random color = new Random();
                foreach (PictureBox b in Boxes)
                {
                    if (b != null)
                    {

                        b.BorderStyle = BorderStyle.FixedSingle;
                        switch (color.Next(1, 7))
                        {
                            case 1:
                                b.BackColor = Color.Aqua;
                                Thread.Sleep(50);
                                break;
                            case 2:
                                b.BackColor = Color.Gold;
                                Thread.Sleep(50);
                                break;
                            case 3:
                                b.BackColor = Color.Red;
                                Thread.Sleep(50);
                                break;
                            case 4:
                                b.BackColor = Color.MediumVioletRed;
                                Thread.Sleep(50);
                                break;
                            case 5:
                                b.BackColor = Color.RosyBrown;
                                Thread.Sleep(50);
                                break;
                            case 6:
                                b.BackColor = Color.PaleGreen;
                                Thread.Sleep(50);
                                break;

                        }
                    }
                }

            }
        }

        void take(int numerRegalu, int iloscProduktow)
        {
            Random randomInt = new Random();

            switch (numerRegalu)
            {
                case 0:
                    if (pozostale1 == 0)
                    {
                        break;
                    }
                    Reg1.Wait();     
                    //Reg1.Wait(500); ten zapis spowoduje ze gdy minie 500ms a watek nie dostanie sie do 
                    // sekcji krytycznej to zrezygnuje czy tylko czeka 500ms?
                    

                    if (iloscProduktow > pozostale1)
                    {
                        iloscProduktow = pozostale1 + 1;

                    }
                    for (int j = pozostale1; j > pozostale1 - iloscProduktow; j--)
                    {
                        Thread.Sleep(randomInt.Next(50));
                        Regal1[j].BackColor = pictureBox1.BackColor;
                       
                    }
                    if (iloscProduktow < pozostale1)
                        pozostale1 -= iloscProduktow;

                    else
                        pozostale1 = 0;
                    Reg1.Release();
                    break;

                case 1:
                    if (pozostale2 == 0)
                    {
                        break;
                    }
                    Reg2.Wait();
                    if (iloscProduktow > pozostale2)
                    {
                        iloscProduktow = pozostale2 + 1;

                    }
                    for (int j = pozostale2; j > pozostale2 - iloscProduktow; j--)
                    {
                        Thread.Sleep(randomInt.Next(50));
                        Regal2[j].BackColor = pictureBox1.BackColor;
                    }
                    if (iloscProduktow < pozostale2)
                        pozostale2 -= iloscProduktow;

                    else
                        pozostale2 = 0;
                    Reg2.Release();
                    break;

                case 2:

                    if (pozostale3 == 0)
                    {
                        break;
                    }
                    Reg3.Wait();
                    if (iloscProduktow > pozostale3)
                    {
                        iloscProduktow = pozostale3 + 1;

                    }
                    for (int j = pozostale3; j > pozostale3 - iloscProduktow; j--)
                    {
                        Thread.Sleep(randomInt.Next(50));
                        Regal3[j].BackColor = pictureBox1.BackColor;
                    }
                    if (iloscProduktow < pozostale3)
                        pozostale3 -= iloscProduktow;

                    else
                        pozostale3 = 0;
                    Reg3.Release();
                    break;

                case 3:
                    if (pozostale4 == 0)
                    {
                        break;
                    }
                    Reg4.Wait();
                    if (iloscProduktow > pozostale4)
                    {
                        iloscProduktow = pozostale4 + 1;

                    }
                    for (int j = pozostale4; j > pozostale4 - iloscProduktow; j--)
                    {
                        Thread.Sleep(randomInt.Next(50));
                        Regal4[j].BackColor = pictureBox1.BackColor;
                    }
                    if (iloscProduktow < pozostale4)
                        pozostale4 -= iloscProduktow;

                    else
                        pozostale4 = 0;
                    Reg4.Release();
                    break;
            }


        }
        void Buy()
        {
            int numerRegalu;
            int iloscProduktow;
            while (true)
            {

                Random randomInt = new Random();
                numerRegalu = randomInt.Next(0, 4);
                iloscProduktow = randomInt.Next(1, 6);
                take(numerRegalu, iloscProduktow);
               
                Thread.Sleep(randomInt.Next(1000));
            }
        }
   
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

        }
        int sprawdz()
        {
            int regal=5;
            if (pozostale1 == 0)
                return 0;
            if (pozostale2 == 0)
                return 1;
            if (pozostale3 == 0)
                return 2;
            if (pozostale4 == 0)
                return 3;
            
            return regal;
        }
        void dodaj(int nrRegalu)
        {
            Random color = new Random();
            switch (nrRegalu)
            { 
                case 0:
                    Reg1.Wait();
                    foreach (PictureBox b in Regal1)
                    {
                        
                        switch (color.Next(1, 7))
                        {
                            case 1:
                                b.BackColor = Color.Aqua;
                                Thread.Sleep(50);
                                break;
                            case 2:
                                b.BackColor = Color.Gold;
                                Thread.Sleep(50);
                                break;
                            case 3:
                                b.BackColor = Color.Red;
                                Thread.Sleep(50);
                                break;
                            case 4:
                                b.BackColor = Color.MediumVioletRed;
                                Thread.Sleep(50);
                                break;
                            case 5:
                                b.BackColor = Color.RosyBrown;
                                Thread.Sleep(50);
                                break;
                            case 6:
                                b.BackColor = Color.PaleGreen;
                                Thread.Sleep(50);
                                break;

                        }
                    }
                    pozostale1 = 31;
                    Reg1.Release();
                    break;

                case 1:
                    Reg2.Wait();
                    foreach (PictureBox b in Regal2)
                    {
                        
                        switch (color.Next(1, 7)) {
                            case 1:
                                b.BackColor = Color.Aqua;
                                Thread.Sleep(50);
                                break;
                            case 2:
                                b.BackColor = Color.Gold;
                                Thread.Sleep(50);
                                break;
                            case 3:
                                b.BackColor = Color.Red;
                                Thread.Sleep(50);
                                break;
                            case 4:
                                b.BackColor = Color.MediumVioletRed;
                                Thread.Sleep(50);
                                break;
                            case 5:
                                b.BackColor = Color.RosyBrown;
                                Thread.Sleep(50);
                                break;
                            case 6:
                                b.BackColor = Color.PaleGreen;
                                Thread.Sleep(50);
                                break;

                        }
                    }
                    pozostale2 = 31;
                    Reg2.Release();
                    break;

                case 2:
                    Reg3.Wait();
                    
                    foreach (PictureBox b in Regal3)
                    {
                        
                        switch (color.Next(1, 7))
                        {
                            case 1:
                                b.BackColor = Color.Aqua;
                                Thread.Sleep(50);
                                break;
                            case 2:
                                b.BackColor = Color.Gold;
                                Thread.Sleep(50);
                                break;
                            case 3:
                                b.BackColor = Color.Red;
                                Thread.Sleep(50);
                                break;
                            case 4:
                                b.BackColor = Color.MediumVioletRed;
                                Thread.Sleep(50);
                                break;
                            case 5:
                                b.BackColor = Color.RosyBrown;
                                Thread.Sleep(50);
                                break;
                            case 6:
                                b.BackColor = Color.PaleGreen;
                                Thread.Sleep(50);
                                break;

                        }
                    }
                    pozostale3 = 31;
                    Reg3.Release();
                    break;

                case 3:
                    Reg4.Wait();
                    
                    foreach (PictureBox b in Regal4){  
                        if (b != null)
                            
                        switch (color.Next(1, 7))
                        {
                                case 1:
                                    b.BackColor = Color.Aqua;
                                    Thread.Sleep(50);
                                    break;
                                case 2:
                                    b.BackColor = Color.Gold;
                                    Thread.Sleep(50);
                                    break;
                                case 3:
                                    b.BackColor = Color.Red;
                                    Thread.Sleep(50);
                                    break;
                                case 4:
                                    b.BackColor = Color.MediumVioletRed;
                                    Thread.Sleep(50);
                                    break;
                                case 5:
                                    b.BackColor = Color.RosyBrown;
                                    Thread.Sleep(50);
                                    break;
                                case 6:
                                    b.BackColor = Color.PaleGreen;
                                    Thread.Sleep(50);
                                    break;

                            }
                    }
                    pozostale4 = 12;
                    Reg4.Release();
                    break;

            }
        }

        private void customer4_Click(object sender, EventArgs e)
        {

        }

     
        void Add()
        {
            
            while (true)
            {
                
                Random randomInt = new Random();
                Check.Wait();
                if ((a=sprawdz()) < 5)
                {
                   
                    dodaj(a);
                    
                }
                Check.Release();
                Thread.Sleep(randomInt.Next(100));
               
            }
        }
        

    }
} 
