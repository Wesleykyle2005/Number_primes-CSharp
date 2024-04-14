using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class PrimeNumbersForm : Form
    {
        private int firstValue;
        private int secondValue;
        private List<int> primeNumbers = new List<int>();

        public PrimeNumbersForm()
        {
            InitializeComponent();
        }

        private void GetFirstValue(object sender, EventArgs e)
        {
            if (int.TryParse(txtFirstValue.Text, out firstValue) && firstValue >= 0)
            {
                btnSecond.Enabled = true;
            }
            else
            {
                txtFirstValue.Text = "";
            }
        }

        private void GetSecondValue(object sender, EventArgs e)
        {
            if (int.TryParse(txtSecondValue.Text, out secondValue) && secondValue >= firstValue)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                txtSecondValue.Text = "";
            }
        }

        private void CalculatePrimes(object sender, EventArgs e)
        {
            listPrimes.Items.Clear(); // Limpiar la lista antes de calcular nuevos números primos
            primeNumbers.Clear(); // Limpiar la lista de números primos

            for (int number = Math.Max(2, firstValue); number <= secondValue; number++)
            {
                if (IsPrime(number))
                {
                    primeNumbers.Add(number); // Agregar el número primo a la lista
                }
            }

            // Mostrar los números primos en la lista
            foreach (int prime in primeNumbers)
            {
                listPrimes.Items.Add(prime);
            }
            txtCantidad.Text = listPrimes.Items.Count.ToString();
        }

        private bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false; // 1 y los números negativos no son primos
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false; // No es primo si es divisible por algún número menor que su raíz cuadrada
                }
            }
            return true; // Es primo si no se encontraron divisores
        }

        private void RestartAll(object sender, EventArgs e)
        {
            txtFirstValue.Text = "";
            txtSecondValue.Text = "";
            btnCalculate.Enabled = false;
            btnSecond.Enabled = false;
            primeNumbers.Clear(); // Limpiar la lista de números primos
            listPrimes.Items.Clear();
        }
    }
}
