using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class PrimeNumbersForm : Form
    {
        private int firstValue;
        private int secondValue;
        private List<int> primeNumbers = new List<int>();
        private TaskScheduler _scheduler;

        public PrimeNumbersForm()
        {
            InitializeComponent();
            _scheduler = TaskScheduler.FromCurrentSynchronizationContext();
        }

        private void GetFirstValue(object sender, EventArgs e)
        {
            if (int.TryParse(txtFirstValue.Text, out firstValue) && firstValue >= 1)
            {
                btnSecond.Enabled = true;
            }
            else
            {
                btnSecond.Enabled = false;
                btnCalculate.Enabled = false;
                txtFirstValue.Text = "";
            }
        }

        private void GetSecondValue(object sender, EventArgs e)
        {
            if (int.TryParse(txtSecondValue.Text, out secondValue) && secondValue > firstValue)
            {
                btnCalculate.Enabled = true;
            }
            else
            {
                btnCalculate.Enabled = false;
                txtSecondValue.Text = "";
            }
        }

        private void CalculatePrimes(object sender, EventArgs e)
        {
            listPrimes.Items.Clear(); // Limpiar la lista antes de calcular nuevos números primos
            primeNumbers.Clear(); // Limpiar la lista de números primos

            Task.Factory.StartNew(() =>
            {
                for (int number = firstValue; number <= secondValue; number++)
                {
                    if (IsPrime(number))
                    {
                        // Agregar el número primo a la lista dentro del hilo de la interfaz de usuario
                        listPrimes.Invoke((MethodInvoker)delegate
                        {
                            listPrimes.Items.Add(number);
                            listPrimes.TopIndex = listPrimes.Items.Count - 1;
                            Thread.Sleep(100);
                        });
                    }
                }
            }).ContinueWith(_ =>
            {
                // Actualizar el campo de texto de cantidad cuando se completa el cálculo
                txtCantidad.Invoke((MethodInvoker)delegate
                {
                    txtCantidad.Text = listPrimes.Items.Count.ToString();
                });

            }, CancellationToken.None, TaskContinuationOptions.None, _scheduler);

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
                    return false; 
                }
            }
            return true; 
        }

        private void RestartAll(object sender, EventArgs e)
        {
            txtFirstValue.Text = "";
            txtSecondValue.Text = "";
            btnCalculate.Enabled = false;
            btnSecond.Enabled = false;
            primeNumbers.Clear();
            listPrimes.Items.Clear();
            txtCantidad.Text = "";
        }
    }
}
