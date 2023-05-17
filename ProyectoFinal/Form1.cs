using System.Text.RegularExpressions;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            int suma;

            suma = valor1 + valor2;
            textBox3.Text = "";
            textBox3.Text = textBox3.Text + suma;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            int resta;

            resta = valor1 - valor2;
            textBox3.Text = "";
            textBox3.Text = textBox3.Text + resta;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);

            int por;

            por = valor1 * valor2;
            textBox3.Text = "";
            textBox3.Text = textBox3.Text + por;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int valor1, valor2;//declaramos  las variables

            valor1 = Convert.ToInt32(textBox1.Text); //capturar el valor en el texbox. convirtiendo a entero el text del box1 y lo almacena en la variable
            valor2 = Convert.ToInt32(textBox2.Text);

            int division;

            division = valor1 / valor2;
            textBox3.Text = "";
            textBox3.Text = textBox3.Text + division;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int valor1, valor2;

            valor1 = Convert.ToInt32(textBox1.Text);
            valor2 = Convert.ToInt32(textBox2.Text);
            if (valor1 > valor2)// condicion para el boton de resultado
            {
                textBox3.Text = "";
                textBox3.Text = textBox3.Text + "El Numero es mayor es" + valor1;

            }
            else
            {
                textBox3.Text = "";
                textBox3.Text = textBox3.Text + "El Numero no es mayor es" + valor2;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            textBox3.Text = "";
            int valor1, cont;
            valor1 = Convert.ToInt32(textBox1.Text);
            cont = 1; //iniciar la variable cont--contador

            while (cont <= valor1)
            {

                textBox3.Text = textBox3.Text + "■";
                cont++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

            string cadena;
            cadena = textBox4.Text;
            int i;
            i = 0;
            int suma = 0;



            while (i < cadena.Length)// longitud total (.lenght ---
            {
                if (cadena[i] == 'a')/// condicionales

                {
                    suma = suma + 1;
                }
                if (cadena[i] == 'e')

                {
                    suma = suma + 1;
                }
                if (cadena[i] == 'i')

                {
                    suma = suma + 1;
                }
                if (cadena[i] == 'o')

                {
                    suma = suma + 1;
                }
                if (cadena[i] == 'u')

                {
                    suma = suma + 1;
                }
                i++;
            }
            textBox3.Text = textBox3.Text + "Vocales en el texto son : " + suma;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int valor1;//declaramos  las variables
            double r;

            valor1 = Convert.ToInt32(textBox1.Text); //capturar el valor en el texbox. convirtiendo a entero el text del box1 y lo almacena en la variable


            int raiz;

            r = Math.Sqrt(valor1);
            textBox3.Text = "";
            textBox3.Text = textBox3.Text + r;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}