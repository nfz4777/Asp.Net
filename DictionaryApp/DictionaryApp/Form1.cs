﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DictionaryApp
{
    public partial class frm_Dictionary : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=NAFIZ\SQL2012;Initial Catalog=EtoBdictionary;Integrated Security=True");
        DataTable dt;
        public frm_Dictionary()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();

            //SqlCommand command;
            SqlDataAdapter sqladp = new SqlDataAdapter("select * from tbl_EntoBng where Word like ('" + txt_Search.Text + "%') ", sqlcon);

            // String sql = "";
            // sql = "select * from tbl_Contact where FirstName like ('" + txt_Search.Text + "%') ";
            // command = new SqlCommand(sql, sqlcon);
            //sqladp.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            sqladp.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void txt_Word_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Word.Text != "")
                {
                    sqlcon.Open();
                    SqlCommand command;
                    SqlDataAdapter sqladp = new SqlDataAdapter();
                    String sql = "";
                    sql = "Insert into tbl_EntoBng (Word,Meaning) values ('" + txt_Word.Text + "',  N' "+txt_Meaning.Text+" ')";
                    command = new SqlCommand(sql, sqlcon);
                    sqladp.InsertCommand = new SqlCommand(sql, sqlcon);
                    sqladp.InsertCommand.ExecuteNonQuery();
                    command.Dispose();
                    MessageBox.Show("Sucessfully Added ");
                }









                //  ````````` Class Code```````````````
                /*if (txt_Name.Text != "")
                {
                    SqlDataAdapter sda = new SqlDataAdapter(@"INSERT INTO tbl_Contact
                         (name) VALUES ('" + txt_Name.Text + "')  ", sqlcon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);



                    MessageBox.Show("Sucessfully Added ");
                }
                else
                {
                    MessageBox.Show("Invalid input !!");
                }*/
                //  ````````  Class code end````````````

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
                txt_Word.Clear();
                txt_Meaning.Clear();
            }
        }

        private void btn_Display_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            DataTable dt;
            //SqlCommand command;
            SqlDataAdapter sqladp = new SqlDataAdapter("Select * from tbl_EntoBng", sqlcon);
            //  String sql = "";
            //sql = "Select * from tbl_Contact";
            // command = new SqlCommand(sql, sqlcon);
            //sqladp.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();

            sqladp.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command;
                SqlDataAdapter sqladp = new SqlDataAdapter();
                String sql = "";
                sql = "Delete tbl_EntoBng where Word= ('" + txt_Word.Text + "')";
                command = new SqlCommand(sql, sqlcon);
                sqladp.DeleteCommand = new SqlCommand(sql, sqlcon);
                sqladp.DeleteCommand.ExecuteNonQuery();
                command.Dispose();
                MessageBox.Show("Sucessfully Deleted ");
                txt_Word.Clear();
                txt_Meaning.Clear();






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            try
            {
                sqlcon.Open();
                SqlCommand command;
                SqlDataAdapter sqladp = new SqlDataAdapter();
                String sql = "";
                sql = "Update tbl_EntoBng set  Word= ('" + txt_Word.Text + "') where" 
                    +" Meaning=(N'"+ txt_Update.Text +"')";
                command = new SqlCommand(sql, sqlcon);
                sqladp.UpdateCommand = new SqlCommand(sql, sqlcon);
                sqladp.UpdateCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Sucessfully Updated");
                txt_Word.Clear();
                txt_Update.Clear();
               






            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_UpdateMeaning_Click(object sender, EventArgs e)
        {
            try
            {
                sqlcon.Open();
                SqlCommand command;
                SqlDataAdapter sqladp = new SqlDataAdapter();
                String sql = "";
                sql = "Update tbl_EntoBng set  Meaning= (N'" + txt_Meaning.Text + "') where"
                    + " Word=(N'" + txt_UpdateM.Text + "')";
                command = new SqlCommand(sql, sqlcon);
                sqladp.UpdateCommand = new SqlCommand(sql, sqlcon);
                sqladp.UpdateCommand.ExecuteNonQuery();
                command.Dispose();

                MessageBox.Show("Sucessfully Updated");
                txt_Meaning.Clear();
                txt_UpdateM.Clear();







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Close(object sender, FormClosedEventArgs e)
        {
          /*  DialogResult ds = MessageBox.Show("Do you want to exit?",
             "Exit", MessageBoxButtons.YesNo);
            if (ds == DialogResult.Yes)
            {*/
                Application.Exit();
           /* }
            else
            {

                e.Cancel = true;
            }*/
        }

        private void txt_SearchM_TextChanged(object sender, EventArgs e)
        {
            sqlcon.Open();

            //SqlCommand command;
            SqlDataAdapter sqladp = new SqlDataAdapter("select * from tbl_EntoBng where Meaning like (N'"+txt_SearchM.Text+"%')", sqlcon);

            // String sql = "";
            // sql = "select * from tbl_Contact where FirstName like ('" + txt_Search.Text + "%') ";
            // command = new SqlCommand(sql, sqlcon);
            //sqladp.SelectCommand.ExecuteNonQuery();
            dt = new DataTable();
            sqladp.Fill(dt);
            dataGridView1.DataSource = dt;
            sqlcon.Close();
        }
    }
}
