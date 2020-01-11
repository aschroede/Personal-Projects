using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretIngredientSorter
{
    public partial class Form1 : Form
    {
        GetSecretIngredient ingredientMethod = null;
        Suzanne suzanne = new Suzanne();
        Amy amy = new Amy();
        public Form1()
        {
            InitializeComponent();
        }

        private void getTheIngredient_Click(object sender, EventArgs e)
        {
            if (ingredientMethod != null)
                MessageBox.Show("I'll add " + ingredientMethod((int)amount.Value));
            else
                MessageBox.Show("I don't have a secret ingredient!");
        }

        private void getSuzannesDelegate_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(suzanne.MySecretIngredientMethod);
        }

        private void getAmysDelegate_Click(object sender, EventArgs e)
        {
            ingredientMethod = new GetSecretIngredient(amy.AmySecretIngredientMethod);
        }
    }
}
