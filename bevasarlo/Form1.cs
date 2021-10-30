using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bevasarlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Fruits gyumik = new Fruits();
            Price arak = new Price();
            counter szamlalo = new counter();
            gyumik.Banana = bananaCheckbox.Text;
            gyumik.Strawberry = strawberryCheckbox.Text;
            gyumik.Tomato = tomatoCheckbox.Text;
            gyumik.Eggplant = eggplantCheckbox.Text;
            gyumik.Pineapple = pineappleCheckbox.Text;
            gyumik.Cucumber = cucumberCheckbox.Text;
            gyumik.Potato = potatoCheckbox.Text;
            gyumik.Onion = onionCheckbox.Text;
            gyumik.Paprika = paprikaCheckbox.Text;
            gyumik.Salad = saladCheckbox.Text;
            szamlalo.SaladQuantity = saladNumber.Value;
            szamlalo.BananaQuantity = bananaNumber.Value;
            szamlalo.StrawberryQuantity = strawberryNumber.Value;
            szamlalo.TomatoQuantity = tomatoNumber.Value;
            szamlalo.EggplantQuantity = eggplantNumber.Value;
            szamlalo.PineappleQuantity = pineappleNumber.Value;
            szamlalo.CucumberQuantity = cucumberNumber.Value;
            szamlalo.PotatoQuantity = potatoNumber.Value;
            szamlalo.OnionQuantity = onionNumber.Value;
            szamlalo.PaprikaQuantity = paprikaNumber.Value;
            if (potatoCheckbox.Checked== true) 
            {
                shoppingList.Items.Add(gyumik.Potato);
                shoppingList.Items.Add(potatoNumber.Value * arak.PotatoPrice + "ft");
                shoppingList.Items.Add(szamlalo.PotatoQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.PotatoPrice * szamlalo.PotatoQuantity;
            }
            if(saladCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Salad);
                shoppingList.Items.Add(saladNumber.Value * arak.SaladPrice + "ft");
                shoppingList.Items.Add(szamlalo.SaladQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.SaladPrice * szamlalo.SaladQuantity;
            }
            if (bananaCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Banana);
                shoppingList.Items.Add(bananaNumber.Value * arak.BananaPrice+"ft");
                shoppingList.Items.Add(szamlalo.BananaQuantity+"db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.BananaPrice * szamlalo.BananaQuantity;
            }
            if (onionCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Onion);
                shoppingList.Items.Add(onionNumber.Value * arak.OnionPrice + "ft");
                shoppingList.Items.Add(szamlalo.OnionQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.OnionPrice * szamlalo.OnionQuantity;
            }
            if (eggplantCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Eggplant);
                shoppingList.Items.Add(eggplantNumber.Value * arak.EggplantPrice +"ft");
                shoppingList.Items.Add(szamlalo.EggplantQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.EggplantPrice * szamlalo.EggplantQuantity;
            }
            if (tomatoCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Tomato);
                shoppingList.Items.Add(tomatoNumber.Value * arak.TomatoPrice + "ft");
                shoppingList.Items.Add(szamlalo.TomatoQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.TomatoPrice * szamlalo.TomatoQuantity;
            }
            if (strawberryCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Strawberry);
                shoppingList.Items.Add(strawberryNumber.Value * arak.StrawberryPrice + "ft");
                shoppingList.Items.Add(szamlalo.StrawberryQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.StrawberryPrice * szamlalo.StrawberryQuantity;
            }
            if (cucumberCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Cucumber);
                shoppingList.Items.Add(cucumberNumber.Value * arak.CucumberPrice + "ft");
                shoppingList.Items.Add(szamlalo.CucumberQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.CucumberPrice * szamlalo.CucumberQuantity;
            }
            if (pineappleCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Pineapple);
                shoppingList.Items.Add(pineappleNumber.Value * arak.PineapplePrice + "ft");
                shoppingList.Items.Add(szamlalo.PineappleQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.PineapplePrice * szamlalo.PineappleQuantity;
            }
            if(paprikaCheckbox.Checked == true)
            {
                shoppingList.Items.Add(gyumik.Paprika);
                shoppingList.Items.Add(paprikaNumber.Value * arak.PaprikaPrice + "ft");
                shoppingList.Items.Add(szamlalo.PaprikaQuantity + "db");
                shoppingList.Items.Add("---------------------------------");
                moneySummaryNumeric.Value += arak.PaprikaPrice * szamlalo.PaprikaQuantity;
            }
            addItemButton.Enabled = false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            shoppingList.Items.Clear();
            addItemButton.Enabled = true;
            moneySummaryNumeric.Value = 0;
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(moneySummaryNumeric.Value + "Forint sikeresen kifizetve, jó egészséget kívánunk!");
            shoppingList.Items.Clear();
            addItemButton.Enabled = true;
            moneySummaryNumeric.Value = 0;
        }
        private void moneySummaryNumeric_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
