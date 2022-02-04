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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection bd = new SqlConnection(@"Data source = localhost;Initial Catalog = testcandidats; Integrated Security = true; Connection Timeout = 0");
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bd.Open();
            bd.Close();

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
            //nc numéro client,np nom/prénom, ge genre,vi ville,tel tel,tr travail,se secteur,di diplome,exp annee d exp
            //enregistrer
        {
            if (int.Parse(nc.Text) > 0 && np.Text != ""&& ge.Text != "" && vi.Text != "" && tel.Text != "" && tr.Text != "" && se.Text != "" && di.Text != "" && exp.Text != "")
       {
                bd.Close();

                bd.Open();
                SqlCommand cmd = new SqlCommand("insert into candidats values(" + nc.Text + ",'" + np.Text + "','" + ge.Text + "','" + vi.Text + "','" + tel.Text + "','" + tr.Text + "','" + se.Text + "','" + di.Text + "','" + exp.Text + "')", bd);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Candidature enregistrée", "Gestion Candidats");
                nc.Clear();
                ge.Clear();
                vi.Clear();
                tel.Clear();
                tr.Clear();
                se.Clear();
                di.Clear();
                exp.Clear();
            }
            else
            {
                MessageBox.Show("Saisie Incorrect", "Gestion des candidats");
            }
    }

                private void button1_Click(object sender, EventArgs e)
        {
            //quitter
            if (MessageBox.Show("Quitter application", "Gestion candidats", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
            //rechercher numéro candidat
        {
            int ncrs = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("N°Candidat recherché", "testcandidats"));
            bd.Close();
            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from candidats where [ncandidat] = '" + ncrs.ToString() + "'", bd);
            SqlDataReader dt = cmd.ExecuteReader();
            if(dt.HasRows == true)
            {
                dt.Read();
                ncsr.Text = dt.GetValue(0).ToString();
                npsr.Text = dt.GetValue(1).ToString();
                gesr.Text =  dt.GetValue(2).ToString();
                visr.Text = dt.GetValue(3).ToString();
                telsr.Text = dt.GetValue(4).ToString();
                trsr.Text = dt.GetValue(5).ToString();
                sesr.Text = dt.GetValue(6).ToString();
                disr.Text = dt.GetValue(7).ToString();
                expsr.Text = dt.GetValue(8).ToString();

            }
            else
            {
                MessageBox.Show("Pas de candidats correspondants");
            }
            bd.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            bd.Close();

            bd.Open();
            SqlCommand cmd = new SqlCommand("select * from candidats", bd);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                tableau.Rows.Add(
                    da.GetValue(0),
                    da.GetValue(1),
                    da.GetValue(2),
                    da.GetValue(3),
                    da.GetValue(4),
                    da.GetValue(5),
                    da.GetValue(6),
                    da.GetValue(7),
                    da.GetValue(8)

                                );
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

    

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click_1(object sender, EventArgs e)
        {

        }

        private void label23_Click_1(object sender, EventArgs e)
        {

        }

        private void label24_Click_1(object sender, EventArgs e)
        {

        }

        private void label25_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_2(object sender, EventArgs e)
        {

        }

        private void label10_Click_3(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //modifier profil candidat
            bd.Close();

           if (MessageBox.Show("Voulez-vous effectuer la modification", "testcandidats", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
               bd.Open ();
                SqlCommand cmd = new SqlCommand("update candidats set nomprenom ='" + npsr.Text + "',genre='" + gesr.Text + "',ville ='" + visr.Text + "',téléphone='" + telsr.Text + "',travail ='" + trsr.Text + "',secteur='" + sesr.Text + "',diplome='" + disr.Text + "',Annéedexp='" + expsr.Text + "' where [ncandidat]='" + ncsr.ToString() + "'", bd) ;
            cmd.ExecuteNonQuery();
              MessageBox.Show("Modification réussi", "testcandidats");
                bd.Close();

            } 

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
    