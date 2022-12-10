using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
namespace oop_4_2
{

    public partial class Form1 : Form
    {
        Model model;

        



        class Model
        {
            private int valueA;
            private int valueB;
            private int valueC;
            public System.EventHandler observer;
           
            public Model()
            {
                StreamReader get = new StreamReader("test.txt");
                valueA = Int32.Parse(get.ReadLine());
                valueB = Int32.Parse(get.ReadLine());
                valueC = Int32.Parse(get.ReadLine());
                

            }

            public Model(int A, int B, int C)
            {
                valueA = A;
                valueB = B;
                valueC = C;
            



            }
            
            //public Model(int x) {
            //    valueA= Properties.Settings.Default.SaveValueA;
            //    valueB=Properties.Settings.Default.SaveValueB;
            //    valueC=Properties.Settings.Default.SaveValueC;
                

            //}

            public int GetValueA()
            {
                return valueA;
            }
            public int GetValueB()
            {
                return valueB;
            }
            public int GetValueC()
            {
                return valueC;
            }
            public void load() {
                SetValueC(Properties.Settings.Default.SaveValueC);
                SetValueB(Properties.Settings.Default.SaveValueB);
                SetValueA(Properties.Settings.Default.SaveValueA);
            }
            public void SetValueA(int A)
            {
                
                
                this.valueA = A;
             
                if (valueA > valueC)
                {
                    valueC = valueB = valueA;
                    
                    
                }
                else if (valueA > valueB)
                {
                    valueB = valueC;
                    
                }
                observer.Invoke(this,null);
            }

            public void SetValueB(int B)
            {
               
                  if (B > valueC)
                {
                    valueB = valueC;
                }
                else if (B < valueA)
                {
                    valueB = valueA;
                }
                else
                {
                    valueB = B;
                }
                observer.Invoke(this, null);
            }
            
            public void SetValueC(int C)
            {
              
                {
                    this.valueC = C;
                  
                    if (valueC < valueA)
                    {
                        valueA = valueB = valueC;
                        
                    }
                    else if (valueC < valueB)
                    {
                        valueB = valueC;
                        
                    }
                    observer.Invoke(this,null);
                }
                

            }

            public void saveValues()//сохраняем Values в файл
            {
                StreamWriter save = new StreamWriter("test.txt", false);
                save.WriteLine(valueA);
                save.WriteLine(valueB);
                save.WriteLine(valueC);
                save.Close();
            }

        }
        
            public Form1()
        {
            InitializeComponent();

            model = new Model();
            model.observer += new System.EventHandler(this.UpdateFromModel);
            model.observer.Invoke(this, null);









        }
       

        private void UpdateFromModel(object sender, EventArgs e) {

         
            trackBarLetter_C.Value = model.GetValueC();
            textBoxLetter_C.Text = model.GetValueC().ToString();
            numericUpLetter_C.Value= model.GetValueC();
            trackLetter_B.Value = model.GetValueB();
            textLetter_B.Text = model.GetValueB().ToString();
            numericUpLetter_B.Value = model.GetValueB();

            trackLetter_A.Value = model.GetValueA();
            textLetter_A.Text = model.GetValueA().ToString();
            numericUpLetter_A.Value = model.GetValueA();
        }


        




        //B

       
        private void numericUpLetter_B_ValueChanged(object sender, EventArgs e)
        {
            model.SetValueB(Decimal.ToInt32(numericUpLetter_B.Value));
        }
        private void trackLetter_B_ValueChanged(object sender, EventArgs e)
        {
            model.SetValueB(Decimal.ToInt32(trackLetter_B.Value));
        }

        //A
        private void trackLetter_A_ValueChanged(object sender, EventArgs e)
        {
            
            model.SetValueA(Decimal.ToInt32(trackLetter_A.Value));
        }

       
        private void numericUpLetter_A_ValueChanged(object sender, EventArgs e)
        {
            
            model.SetValueA(Decimal.ToInt32(numericUpLetter_A.Value));
        }
     
        //C

        
        private void numericUpLetter_C_ValueChanged_1(object sender, EventArgs e)
        {
            model.SetValueC(Decimal.ToInt32(numericUpLetter_C.Value));
        }

        private void trackBarLetter_C_ValueChanged(object sender, EventArgs e)
        {
            model.SetValueC(Decimal.ToInt32(trackBarLetter_C.Value));
        }
       




        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            model.saveValues();
        }



        private void textBoxLetter_C_Leave(object sender, EventArgs e)
        {
            model.SetValueC(Int32.Parse(textBoxLetter_C.Text));
        }

        private void textLetter_B_Leave(object sender, EventArgs e)
        {
            model.SetValueB(Int32.Parse(textLetter_B.Text));
        }

        private void textLetter_A_Leave(object sender, EventArgs e)
        {
            model.SetValueA(Int32.Parse(textLetter_A.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}