using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _4PraktinisDarbas_Sandelys
{
    public partial class Form1 : Form
    {
        string connString;

        public Form1()
        {
            InitializeComponent();
            connString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Arnas\Documents\Visual Studio 2015\Projects\4PraktinisDarbas_Sandelys\4PraktinisDarbas_Sandelys\SandelysDatabase.mdf ; Integrated Security = True";
            //PopulateTiekejaiSutartys();
            PopulateTiekejai();
            UzpildytiDataGrid();
            UzpildytiCmb();
        }

        private void btnPridetiTiekeja_Click(object sender, EventArgs e)
        {
            PridetiTiekeja();
        }

        private void PridetiTiekeja()
        {
            string query = "INSERT INTO Tiekejas VALUES (@Pavadinimas, @Kodas)";
            string query2 = "INSERT INTO Sutartis VALUES (@Kodas, @Pradzia, @Pabaiga)";
            string querycheck = "SELECT COUNT(*) FROM Tiekejas WHERE Pavadinimas like @Pavadinimas OR Kodas like @Kodas";

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlCommand check = new SqlCommand(querycheck, connection);

            try
            {
                if (txtTiekImonesKodas.Text != "" && txtTiekImonesPav.Text != "")
                {
                    connection.Open();
                    check.Parameters.AddWithValue("@Pavadinimas", txtTiekImonesPav.Text);
                    check.Parameters.AddWithValue("@Kodas", txtTiekImonesKodas.Text);
                    int checkquery = (int)check.ExecuteScalar();

                    if (checkquery == 0)
                    {
                        command.Parameters.AddWithValue("@Pavadinimas", txtTiekImonesPav.Text);
                        command.Parameters.AddWithValue("@Kodas", txtTiekImonesKodas.Text);
                        command.ExecuteNonQuery();

                        command2.Parameters.AddWithValue("@Kodas", txtTiekImonesKodas.Text);
                        command2.Parameters.AddWithValue("@Pradzia", dateTimePickerTiekPradzia.Value.Date);
                        command2.Parameters.AddWithValue("@Pabaiga", dateTimePickerTiekPabaiga.Value.Date);
                        command2.ExecuteNonQuery();

                        MessageBox.Show("Tiekėjas sėkmingai pridėtas");
                    }
                    else
                    {
                        MessageBox.Show("Toks tiekėjas jau yra!");
                    }
                }
                else
                {
                    MessageBox.Show("Neužpildėte visų laukų");
                }
               
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();                
            }
        }

        private void PopulateTiekejai()
        {          

            SqlConnection connection = new SqlConnection(connString);            
            try
            {
                connection.Open();
                DataTable tiekejaiTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tiekejas", connection);

                adapter.Fill(tiekejaiTable);
                lstSutartysTiekejai.DisplayMember = "Pavadinimas";
                lstSutartysTiekejai.ValueMember = "Kodas";
                lstSutartysTiekejai.DataSource = tiekejaiTable;

                lstTiekejaiProduktai.DisplayMember = "Pavadinimas";
                lstTiekejaiProduktai.ValueMember = "Kodas";
                lstTiekejaiProduktai.DataSource = tiekejaiTable;

                lstTiekejai.DisplayMember = "Pavadinimas";
                lstTiekejai.ValueMember = "Kodas";
                lstTiekejai.DataSource = tiekejaiTable;

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void lstSutartysTiekejai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Sutartis WHERE Kodas IN" +
                "(SELECT Kodas FROM Tiekejas WHERE Kodas = @Kodas)";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                command.Parameters.AddWithValue("@Kodas", lstSutartysTiekejai.SelectedValue);
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    txtSutartisKodas.Text = "Sutarties kodas: " + (string)dr["Kodas"];
                    txtDatosPradzia.Text = Convert.ToString((DateTime)dr["SutartiesPradzia"]);
                    txtDatosPabaiga.Text = Convert.ToString((DateTime)dr["SutartiesPabaiga"]);
                }
                dr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void lstTiekejaiProduktai_SelectedIndexChanged(object sender, EventArgs e)
        {

            string query = "SELECT DISTINCT p.Pavadinimas, p.ProduktoID, p.KategorijosID FROM Produktas as p " +
                "INNER JOIN TiekejoProduktas as tp ON tp.ProduktoID = p.ProduktoID " +
                "INNER JOIN Sutartis as s ON s.Kodas = tp.Kodas "+
                "WHERE tp.Kodas = @Kodas";

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Kodas", lstTiekejaiProduktai.SelectedValue);
            try
            {
                
                connection.Open();
                DataTable produktaiTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(produktaiTable);
                lstTiekejoPrekes.DisplayMember = "Pavadinimas";
                lstTiekejoPrekes.ValueMember = "ProduktoID";
                lstTiekejoPrekes.DataSource = produktaiTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void lstTiekejoPrekes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string queryKaina = "SELECT tp.Kaina FROM TiekejoProduktas as tp " +
                "INNER JOIN Produktas as p ON p.ProduktoID = tp.ProduktoID " +
                "WHERE tp.ProduktoID = @ID ";

            string queryKat = "SELECT k.Pavadinimas FROM Kategorija as k " +
                "INNER JOIN Produktas as p ON p.KategorijosID = k.KategorijosID " +
                "INNER JOIN TiekejoProduktas as tp ON tp.ProduktoID = p.ProduktoID " +
                "WHERE p.ProduktoID = @ID";


            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(queryKaina, connection);
            SqlCommand command2 = new SqlCommand(queryKat, connection);
            command.Parameters.AddWithValue("@ID", lstTiekejoPrekes.SelectedValue);
            command2.Parameters.AddWithValue("@ID", lstTiekejoPrekes.SelectedValue);

            try
            {
                connection.Open();
                string kaina = Convert.ToString(command.ExecuteScalar());
                txtPrekesKaina.Text = kaina;
                string kategorija = Convert.ToString(command2.ExecuteScalar());
                txtPrekesKategorija.Text = kategorija;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }


        }

        private void buttonPratesti_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Sutartis SET SutartiesPabaiga = @naujaPabaiga WHERE Kodas = @Kodas";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@naujaPabaiga", dateTimePickerPratesti.Value.Date);
            command.Parameters.AddWithValue("@Kodas", lstSutartysTiekejai.SelectedValue);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                txtDatosPabaiga.Text = Convert.ToString(dateTimePickerPratesti.Value.Date);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnIsregistruoti_Click(object sender, EventArgs e)
        {
            //string query = "DELETE ";
        }

        private void btnNutraukti_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Sutartis SET SutartiesPradzia = NULL , SutartiesPabaiga = NULL WHERE Kodas = @Kodas";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Kodas", lstSutartysTiekejai.SelectedValue);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnUzsakytiSandeli_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SandelioPreke VALUES (@Pavadinimas, @SandelioKaina, @KategorijosID, @Likutis, @TiekejoProduktoID)";

            string queryKat = "SELECT k.KategorijosID FROM Kategorija as k " +
                "INNER JOIN Produktas as p ON p.KategorijosID = k.KategorijosID " +
                "INNER JOIN TiekejoProduktas as tp ON tp.ProduktoID = p.ProduktoID " +
                "WHERE p.ProduktoID = @ID";

            string queryPav = "SELECT Pavadinimas FROM Produktas WHERE ProduktoID = @ID";

            string queryTiekID = "SELECT tp.TiekejoProduktoID FROM TiekejoProduktas as tp " +
                "INNER JOIN Produktas as p ON p.ProduktoID = tp.ProduktoID " +
                "WHERE tp.ProduktoID = @ID ";

                

            decimal suma = Convert.ToDecimal(txtPrekesKaina.Text) * Convert.ToDecimal(1.5) + Convert.ToDecimal(txtPrekesKaina.Text) * Convert.ToDecimal(0.21);

            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);
            SqlCommand commandKat = new SqlCommand(queryKat, connection);
            SqlCommand commandPav = new SqlCommand(queryPav, connection);
            SqlCommand commandTiekID = new SqlCommand(queryTiekID, connection);

            try
            {
                if(txtKiekis.Text == "" || Convert.ToInt32(txtKiekis.Text) <= 0)
                {
                    MessageBox.Show("Blogai įvestas kiekis");
                }
                else
                {
                    connection.Open();
                    commandKat.Parameters.AddWithValue("@ID", lstTiekejoPrekes.SelectedValue);
                    string katID = Convert.ToString(commandKat.ExecuteScalar());

                    commandPav.Parameters.AddWithValue("@ID", lstTiekejoPrekes.SelectedValue);
                    string pavadinimas = Convert.ToString(commandPav.ExecuteScalar());

                    commandTiekID.Parameters.AddWithValue("@ID", lstTiekejoPrekes.SelectedValue);
                    string tiekID = Convert.ToString(commandTiekID.ExecuteScalar());

                    command.Parameters.AddWithValue("@Pavadinimas", pavadinimas);
                    command.Parameters.AddWithValue("@SandelioKaina", suma);
                    command.Parameters.AddWithValue("@KategorijosID", katID);
                    command.Parameters.AddWithValue("@Likutis", Convert.ToInt32(txtKiekis.Text));
                    command.Parameters.AddWithValue("@TiekejoProduktoID", tiekID);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Prekė pridėta į sandėlį");
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }            
        }
        private void UzpildytiDataGrid()
        {
            string query = "SELECT * FROM SandelioPreke";
            SqlConnection connection = new SqlConnection(connString);
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(command.CommandText, connection);
                sda.Fill(ds, "Prekes");
                foreach(DataRow dr in ds.Tables["Prekes"].Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), Convert.ToDecimal(dr[1]), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void UzpildytiCmb()
        {
            string queryKat = "SELECT * FROM Kategorija";
            string queryPav = "SELECT Pavadinimas FROM Produktas";
            SqlConnection connection = new SqlConnection(connString);
            try
            {
                connection.Open();
                SqlDataAdapter sda = new SqlDataAdapter(queryKat, connString);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Kategorijos");
                cmbKategorijaSandelys.DisplayMember = "Pavadinimas";
                cmbKategorijaSandelys.ValueMember = "KategorijosID";
                cmbKategorijaSandelys.DataSource = ds.Tables["Kategorijos"];

                SqlDataAdapter sda2 = new SqlDataAdapter(queryPav, connString);
                DataSet ds2 = new DataSet();
                sda2.Fill(ds2, "Pavadinimai");
                cmbPrekesPavSandelys.DisplayMember = "Pavadinimas";
                cmbPrekesPavSandelys.ValueMember = "Pavadinimas";
                cmbPrekesPavSandelys.DataSource = ds2.Tables["Pavadinimai"];

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        
        private void cmbKategorijaSandelys_SelectedIndexChanged(object sender, EventArgs e) // tiesiog daryti nauja query ir tiek palei Kategorija
        {

        }

        private void cmbPrekesPavSandelys_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            UzpildytiDataGrid();
        }

        private void btnFilterKat_Click(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dataGridView1.DataSource;
            //bs.Filter = "[kategorijaID] Like '%" + cmbKategorijaSandelys.SelectedItem.ToString() + "%'";
            //dataGridView1.DataSource = bs;

            //DataTable dt = new DataTable();
            //DataView dv = dt.DefaultView;
            //dv.RowFilter = string.Format("[kategorijaID] LIKE '%{0}%'", cmbKategorijaSandelys.SelectedItem.ToString());
            //dataGridView1.DataSource = dv;

            string query = "SELECT * FROM SandelioPreke WHERE KategorijosID = @ID";
            SqlConnection connection = new SqlConnection(connString);


            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", cmbKategorijaSandelys.SelectedValue);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Prekes");
                foreach (DataRow dr in ds.Tables["Prekes"].Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), Convert.ToDecimal(dr[1]), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnFilterPav_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM SandelioPreke WHERE Pavadinimas = @Pav";
            SqlConnection connection = new SqlConnection(connString);


            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Pav", cmbPrekesPavSandelys.SelectedValue);
                DataSet ds = new DataSet();
                SqlDataAdapter sda = new SqlDataAdapter(command);
                sda.Fill(ds, "Prekes");
                foreach (DataRow dr in ds.Tables["Prekes"].Rows)
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), Convert.ToDecimal(dr[1]), Convert.ToInt32(dr[2]), Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]));
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
