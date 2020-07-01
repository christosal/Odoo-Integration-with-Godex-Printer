using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Odoo_Barcode_Printer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            if (Properties.Settings.Default.PrinterName == "")
            {
                checkPrinter.Text = "Μη επιλεγμένος εκτυπωτής";
            }
            else
            {
                checkPrinter.Text = Properties.Settings.Default.PrinterName;
                checkPrinter.Checked = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBarcode.TextLength <= 0)
                {
                    MessageBox.Show("Το πεδίo barcode πρέπει να είναι συμπληρωμένo! ", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    searchDb();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                
            }
        }

        private void searchDb()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(@"Server=192.168.1.25;Port=5432;User Id=admin;Password=password;Database=villagetrain;"))
            {
                try
                {
                    con.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected");
                }

                using (var command = new NpgsqlCommand("SELECT name,list_price FROM public.product_template,public.product_product WHERE public.product_template.id=public.product_product.product_tmpl_id AND public.product_product.barcode='"+textBarcode.Text+"'", con))
                {
                    try
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                            product_name.Text = reader.GetString(0);
                            product_price.Text = string.Format("{0:0.00}€", reader.GetDouble(1));
                            product_name.Visible = true;
                            product_price.Visible = true;
                            Console.WriteLine(
                                string.Format(
                                    "Reading from table=({0},{1:0.00})",

                                    reader.GetString(0),
                                    reader.GetDouble(1)

                                    )
                                );
                        }
                    }catch (System.TimeoutException e)
                    {
                        MessageBox.Show("Έλεγξε οτι το κεντρικό λάπτοπ, η εμπορική διαχείρηση και το wifi είναι ανοιχτά", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var sb = new StringBuilder();
            if (radioButton1.Checked)
            {
                if (textBarcode.TextLength <= 0)
                {
                    MessageBox.Show("Το πεδίo barcode πρέπει να είναι συμπληρωμένo! ", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBarcode.TextLength<8)
                {

                    sb.AppendLine();
                    sb.AppendLine("^XSET,CODEPAGE,15");
                    sb.AppendLine("^Q25,3");
                    sb.AppendLine("^W40");
                    sb.AppendLine("^H8");
                    sb.AppendLine("^P" + numericUpDown1.Value.ToString());
                    sb.AppendLine("^S3");
                    sb.AppendLine("^AD");
                    sb.AppendLine("^C1");
                    sb.AppendLine("^R0");
                    sb.AppendLine("~Q-16");
                    sb.AppendLine("^O0");
                    sb.AppendLine("^D0");
                    sb.AppendLine("^E12");
                    sb.AppendLine("~R255");
                    sb.AppendLine("^L");
                    sb.AppendLine("Dy2-me-dd");
                    sb.AppendLine("Th:m:s");
                    sb.AppendLine("BA3,54,78,2,5,47,0,1," + textBarcode.Text.ToString());
                    sb.AppendLine("R61,5,252,70,4,4");
                    sb.AppendLine("ATA,95,13,39,39,0,E,A,0," + product_price.Text.Substring(0, product_price.Text.Length - 1)+" €");
                    sb.AppendLine("AB,35,156,1,1,0,0E,www.diashandmade.com");
                    sb.AppendLine("E");
                   
                }
                else
                {
                    sb.AppendLine();
                    sb.AppendLine("^XSET,CODEPAGE,15");
                    sb.AppendLine("^XSET,KEYBOARD,13");
                    sb.AppendLine("^Q25,3");
                    sb.AppendLine("^W40");
                    sb.AppendLine("^H8");
                    sb.AppendLine("^P" + numericUpDown1.Value.ToString());
                    sb.AppendLine("^S3");
                    sb.AppendLine("^AD");
                    sb.AppendLine("^C1");
                    sb.AppendLine("^R0");
                    sb.AppendLine("~Q-16");
                    sb.AppendLine("^O0");
                    sb.AppendLine("^D0");
                    sb.AppendLine("^E12");
                    sb.AppendLine("~R255");
                    sb.AppendLine("^L");
                    sb.AppendLine("Dy2-me-dd");
                    sb.AppendLine("Th:m:s");
                    sb.AppendLine("BE,47,100,2,5,47,0,1," + textBarcode.Text);
                    sb.AppendLine("R64,14,255,79,4,4");
                    sb.AppendLine("ATA,95,22,39,39,0,0,A,0,"+ product_price.Text.Substring(0,product_price.Text.Length-1)+ " €");
                    sb.AppendLine("E");
                    
                   
                }
            }
            else
            {
                sb.AppendLine();
                sb.AppendLine("^XSET,CODEPAGE,15");
                sb.AppendLine("^Q25,3");
                sb.AppendLine("^W40");
                sb.AppendLine("^H8");
                sb.AppendLine("^P" + numericUpDown1.Value.ToString());
                sb.AppendLine("^S3");
                sb.AppendLine("^AD");
                sb.AppendLine("^C1");
                sb.AppendLine("^R0");
                sb.AppendLine("~Q-16");
                sb.AppendLine("^O0");
                sb.AppendLine("^D0");
                sb.AppendLine("^E12");
                sb.AppendLine("~R255");
                sb.AppendLine("^L");
                sb.AppendLine("Dy2-me-dd");
                sb.AppendLine("AD,14,81,1,1,0,0E," + comboBox1.Text);
                sb.AppendLine("AB,68,158,1,1,0,0E,www.villagetrain.gr");
                sb.AppendLine("AB,70,10,1,1,0,0E,EAU DE PARFUM");
                sb.AppendLine("AA,88,138,1,1,0,0E,Order perfumes on");
                sb.AppendLine("AB,17,54,1,1,0,0E,Type:");
                sb.AppendLine("R0,45,363,132,4,4");
                sb.AppendLine("E");
               
            }

            
            try
            {
                //var sb = new StringBuilder();
                
               if (checkPrinter.Checked)
                {
                    RawPrinterHelper.SendStringToPrinter(Properties.Settings.Default.PrinterName, sb.ToString());
                }
                else
                {
                    PrintDialog pd = new PrintDialog();
                    if (DialogResult.OK == pd.ShowDialog(this))
                    {
                        checkPrinter.Text = pd.PrinterSettings.PrinterName;
                        
                        RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, sb.ToString());

                    }
                }
                
            }
            catch (Exception exe)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void product_price_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
                comboBox1.Visible = false;
                textBarcode.Visible = true;
                textBarcode.Text = "";
                textAddPerfume.Visible = false;
                buttonAddPerfume.Visible = false;
                buttonRemovePerfume.Visible = false;
                buttonRandom.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {
                product_name.Visible = false;
                product_price.Visible = false;
                radioButton1.Checked = false;
                comboBox1.Visible = true;
                textBarcode.Visible = false;
                textAddPerfume.Visible = true;
                buttonAddPerfume.Visible = true;
                buttonRemovePerfume.Visible = true;
                buttonRandom.Visible = false;
            }
        }

        private void buttonAddPerfume_Click(object sender, EventArgs e)
        {
            if (textAddPerfume.TextLength > 0)
            {
                comboBox1.Items.Add(textAddPerfume.Text);
                MessageBox.Show("Το άρωμα "+textAddPerfume.Text+" προστέθηκε!", "Περάστηκε!", MessageBoxButtons.OK, MessageBoxIcon.None);
                textAddPerfume.Text = "";
            }
            else
            {
                MessageBox.Show("Πρέπει να εισάγεις μια ονομασία αρώματος!", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemovePerfume_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Πρέπει πρώτα να επιλέξεις ενα άρωμα απο την λίστα για να διαγραφεί!", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                DialogResult dialogResult = MessageBox.Show("Είσαι σίγουρος οτι θές να αφαιρέσεις το " + comboBox1.SelectedItem + " ;", "Σίγουρα;", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    comboBox1.Items.Remove(comboBox1.Text);
                    MessageBox.Show("Το άρωμα αφαιρέθηκε!", "Αφαιρέθηκε!", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                
                
            }
        }

        private void checkPrinter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkPrinter.Checked)
            {
                if (checkPrinter.Text== "Μη επιλεγμένος εκτυπωτής")
                {
                    checkPrinter.Checked = false;
                    MessageBox.Show("Πρέπει πρώτα να επιλέξεις εκτυπωτή!", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Properties.Settings.Default.PrinterName = checkPrinter.Text;
                    Properties.Settings.Default.Save();
                    
                }
            }
        }

        private void textAddPerfume_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            var barcodes_list = new List<Int64>();
            using(NpgsqlConnection con = new NpgsqlConnection(@"Server=192.168.1.25;Port=5432;User Id=admin;Password=password;Database=villagetrain;"))
            {
                try
                {
                    con.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                if (con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("Connected");
                }

                using (var command = new NpgsqlCommand("select CAST (barcode AS BIGINT) from public.product_product where CAST (barcode AS BIGINT)>10000 and CAST (barcode AS BIGINT)<99999",con))
                {
                    try
                    {
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            barcodes_list.Add(reader.GetInt64(0)); 
                        }
                    }
                    catch (System.TimeoutException er)
                    {
                        MessageBox.Show("Έλεγξε οτι το κεντρικό λάπτοπ, η εμπορική διαχείρηση και το wifi είναι ανοιχτά", "Βιάστηκες!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                }
            }
            while (true)
            {
                var rand = new System.Random();
                int index = rand.Next(10000, 99999);
                if (!barcodes_list.Contains(index)){
                    textBarcode.Text = index.ToString();
                    break;
                }
            }
            
        }
    }
}
