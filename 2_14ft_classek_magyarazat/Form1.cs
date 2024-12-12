using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_14ft_classek_magyarazat
{
    public partial class Form1 : Form
    {
        List<Dog> dogs = new List<Dog>();
        public Form1()
        {
            InitializeComponent();
            Start();
        }
        void Start()
        {
            AddEvents();
        }
        void AddEvents()
        {
            button1.Click += Button1Event;
            button2.Click += Button2Event;
            button3.Click += Button3Event;
        }
        void Button1Event(Object s, EventArgs e)
        {
            square oneSquare = new square("valami");
            groupBox1.Controls.Add(oneSquare);
            oneSquare.Top = 10;
        }
        void Button2Event(Object s, EventArgs e)
        {
            /*Dog oneDog = new Dog("Zsömi");
            oneDog.age = 5;
            listBox1.Items.Add($"Kutya neve: {oneDog.name}, kora: {oneDog.age}");
            oneDog.Bark();*/
            foreach (Dog dog in dogs)
            {
                dog.Bark();
            }
        }
        void Button3Event(Object s, EventArgs e)
        {
            try
            {
                Dog oneDog = new Dog(textBox1.Text, int.Parse(textBox2.Text));
                //oneDog.age = int.Parse(textBox2.Text);
                ShowDog oneShowDog = new ShowDog(oneDog);
                groupBox4.Controls.Add(oneShowDog);
                oneShowDog.Top = oneShowDog.Height * dogs.Count;
                dogs.Add(oneDog);
                listBox1.Items.Add($"Kutya neve: {oneDog.name}, kora: {oneDog.age}");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                textBox2.Text = "";
                textBox2.Focus();
            }
            
            
        }
    }
}
