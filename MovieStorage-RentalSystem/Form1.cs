using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStorage_RentalSystem
{
    public partial class Form1 : Form
    {
        ConnectSQL connect = new ConnectSQL();

        int rent = 0;
       int Video_ID = 0;
          int   Rental_ID = 0;
              int  Cust_ID = 0;


        public Form1()
        {
            InitializeComponent();
        }

        // add customer

        private void add_button_customer_Click(object sender, EventArgs e)
        {
            if (!full_name_customer.Text.Equals("") && !email_customer.Text.Equals("") && !phone_customer.Text.Equals("") && !address_customer.Text.Equals(""))
            {

                String qry = "insert into tbCustomer(CustName,CustEmail,CustPhone,CustAdr) values('" + full_name_customer.Text + "','" + email_customer.Text.ToString() + "','" + phone_customer.Text.ToString() + "','" + address_customer.Text + "')";
                connect.runIDU(qry);
                MessageBox.Show("Customer Registered"); 
                
            }
            else {

                MessageBox.Show("Need to fill all details");
            }

            full_name_customer.Text = "";email_customer.Text = "";phone_customer.Text = "";address_customer.Text = "";text_filed_customer.Text = "";


        }
        // price setting
        private void year_textfiled_TextChanged(object sender, EventArgs e)
        {
            try {
                DateTime now = DateTime.Now;

                int yr = now.Year;
                int diff = yr - Convert.ToInt32(year_textfiled.Text.ToString());
                // MessageBox.Show(diff.ToString());
                if (diff >= 5)
                {
                    cost_textfiled.Text = "2";
                }
                if (diff >= 0 && diff < 5)
                {
                    cost_textfiled.Text = "5";
                }

            }
            catch (Exception ex) { 
            
            }
            
        }

        private void delete_buuton_customer_Click(object sender, EventArgs e)
        {

            if (!text_filed_customer.Text.Equals("") && !full_name_customer.Text.Equals("") && !email_customer.Text.Equals("") && !phone_customer.Text.Equals("") && !address_customer.Text.Equals(""))
            {

                String qry = "delete from tbCustomer where id=" + Convert.ToInt32(text_filed_customer.Text.ToString()) + "";
                connect.runIDU(qry);
                MessageBox.Show("Customer Removed");

                
            }
            else
            {
                MessageBox.Show("Need to fill all details");
            }

            full_name_customer.Text = ""; email_customer.Text = ""; phone_customer.Text = ""; address_customer.Text = ""; text_filed_customer.Text = "";


        }

        // update customer

        private void update_button_customer_Click(object sender, EventArgs e)
        {
            if (!text_filed_customer.Text.Equals("") && !full_name_customer.Text.Equals("") && !email_customer.Text.Equals("") && !phone_customer.Text.Equals("") && !address_customer.Text.Equals(""))
            {

                String qry = "update  tbCustomer set CustName='" + full_name_customer.Text + "',CustEmail='" + email_customer.Text.ToString() + "',CustPhone='" + phone_customer.Text.ToString() + "',CustAdr='" + address_customer.Text + "' where id=" + Convert.ToInt32(text_filed_customer.Text.ToString()) + "";

                connect.runIDU(qry);
                MessageBox.Show("Customer Record is Edited "); 
            }
            else
            {
                MessageBox.Show("Need to fill all details");

            }

            full_name_customer.Text = ""; email_customer.Text = ""; phone_customer.Text = ""; address_customer.Text = ""; text_filed_customer.Text = "";


        }

        private void add_movie_Click(object sender, EventArgs e)
        {

            if (!movie_name_textfiled.Text.Equals("") && !ratings_textfiled.Text.Equals("") && !year_textfiled.Text.Equals("") && !copies_textfiled.Text.Equals("") && !cost_textfiled.Text.Equals("") && !Genre_textfield.Text.Equals("") && !plot_textfield.Text.Equals("")) {
                String qry = "";
                qry = "insert into tbVideos(VTitle,Rating,VYear,VCost,VCopy,VPlot,VGenre) values('" + movie_name_textfiled.Text.ToString() + "','" + ratings_textfiled.Text.ToString() + "','" + year_textfiled.Text.ToString() + "','" + cost_textfiled.Text.ToString() + "','" + copies_textfiled.Text.ToString() + "','" + plot_textfield.Text.ToString() + "','" + Genre_textfield.Text.ToString() + "')";
                connect.runIDU(qry);
                MessageBox.Show("Video Record Saved");
                
            }
            else {
                MessageBox.Show("Need to FIll the details ");
            }

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = "";ratings_textfiled.Text = "";year_textfiled.Text = "";
            cost_textfiled.Text="";copies_textfiled.Text = "";plot_textfield.Text = "";
            Genre_textfield.Text = "";




        }

        private void delete_movie_Click(object sender, EventArgs e)
        {
            if (!movie_name_textfiled.Text.Equals("") && !ratings_textfiled.Text.Equals("") && !year_textfiled.Text.Equals("") && !copies_textfiled.Text.Equals("") && !cost_textfiled.Text.Equals("") && !Genre_textfield.Text.Equals("") && !plot_textfield.Text.Equals(""))
            {
                String qry = "";
                qry = "delete from  tbVideos where id=" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + "";
                connect.runIDU(qry);
                MessageBox.Show("Video Record is Removed");
                
            }
            else
            {
                MessageBox.Show("Need to FIll the details ");
            }
            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = ""; ratings_textfiled.Text = ""; year_textfiled.Text = "";
            cost_textfiled.Text = ""; copies_textfiled.Text = ""; plot_textfield.Text = "";
            Genre_textfield.Text = "";

        }

        private void update_movie_Click(object sender, EventArgs e)
        {

            if (!movie_name_textfiled.Text.Equals("") && !ratings_textfiled.Text.Equals("") && !year_textfiled.Text.Equals("") && !copies_textfiled.Text.Equals("") && !cost_textfiled.Text.Equals("") && !Genre_textfield.Text.Equals("") && !plot_textfield.Text.Equals(""))
            {
                String qry = "";
                qry = "update tbVideos set VTitle='" + movie_name_textfiled.Text.ToString() + "',Rating='" + ratings_textfiled.Text.ToString() + "',VYear='" + year_textfiled.Text.ToString() + "',VCost='" + cost_textfiled.Text.ToString() + "',VCopy='" + copies_textfiled.Text.ToString() + "',VPlot='" + plot_textfield.Text.ToString() + "',VGenre ='" + Genre_textfield.Text.ToString() + "' where id=" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + "";
                connect.runIDU(qry);
                MessageBox.Show("Video Record Updated ");
                
            }
            else
            {
                MessageBox.Show("Need to FIll the details ");
            }

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = ""; ratings_textfiled.Text = ""; year_textfiled.Text = "";
            cost_textfiled.Text = ""; copies_textfiled.Text = ""; plot_textfield.Text = "";
            Genre_textfield.Text = "";

        }

        private void Issue_button_rentals_Click(object sender, EventArgs e)
        {
            if (!text_filed_customer.Text.Equals("") && !text_filed_videoId.Text.Equals(""))
            {
                String qry = "";
                qry = "insert into tbRental(MID,CID,IssueDate,ReturnDate) values(" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + "," + Convert.ToInt32(text_filed_customer.Text.ToString()) + ",'" + Issue_dateTimePicker.Text + "',' booked')";
                connect.runIDU(qry);
                MessageBox.Show("movie is issued on rent ");

            
            }
            else {

                MessageBox.Show("Need to select the data or movie ");
            }

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = ""; ratings_textfiled.Text = ""; year_textfiled.Text = "";
            cost_textfiled.Text = ""; copies_textfiled.Text = ""; plot_textfield.Text = "";
            Genre_textfield.Text = "";

            full_name_customer.Text = ""; email_customer.Text = ""; phone_customer.Text = ""; address_customer.Text = ""; text_filed_customer.Text = "";


        }

        private void return_button_rentals_Click(object sender, EventArgs e)
        {

            if (!text_filed_customer.Text.Equals("") && !text_filed_videoId.Text.Equals(""))
            {
                int id = 1, Cost = 0, bill = 0;
                String diff = "";
                String qry = "";
                qry = "";
                qry = "select * from tbVideos where id=" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + "";
                DataTable tbl = new DataTable();
                tbl = connect.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    Cost = Convert.ToInt32(tbl.Rows[tbl.Rows.Count - 1]["VCost"].ToString());

                }
                DateTime Current_date = DateTime.Now;


                DateTime Old_date = Convert.ToDateTime(Issue_dateTimePicker.Value.ToString());



                diff = (Current_date - Old_date).TotalDays.ToString();



                Double dif = Math.Round(Convert.ToDouble(diff));
                if (dif<=0) {
                    dif = 1;
                }

                bill = Cost * Convert.ToInt32(dif);





                qry = "";
                qry = "Update tbRental set MID=" + Convert.ToInt32(text_filed_videoId.Text.ToString()) + ",CID=" + Convert.ToInt32(text_filed_customer.Text.ToString()) + ",IssueDate='" + Issue_dateTimePicker.Text + "',ReturnDate='" + Return_dateTimePicker.Text + "' where id=" + rent + "";
                connect.runIDU(qry);
                MessageBox.Show("movie is returned on rent and bill is " + bill);


                
            }
            else
            {

                MessageBox.Show("Need to select the data or movie ");

            }

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = ""; ratings_textfiled.Text = ""; year_textfiled.Text = "";
            cost_textfiled.Text = ""; copies_textfiled.Text = ""; plot_textfield.Text = "";
            Genre_textfield.Text = "";

            full_name_customer.Text = ""; email_customer.Text = ""; phone_customer.Text = ""; address_customer.Text = ""; text_filed_customer.Text = "";

        }

        private void delete_button_rental_Click(object sender, EventArgs e)
        {


            if (!text_filed_customer.Text.Equals("") && !text_filed_videoId.Text.Equals(""))
            {

                String qry = "";
                qry = "dalete from tbRental  where id=" + rent + "";
                connect.runIDU(qry);
                MessageBox.Show("movie is removed");


                
            }
            else
            {

                MessageBox.Show("Need to select the data or movie ");



            }

            text_filed_videoId.Text = "";
            movie_name_textfiled.Text = ""; ratings_textfiled.Text = ""; year_textfiled.Text = "";
            cost_textfiled.Text = ""; copies_textfiled.Text = ""; plot_textfield.Text = "";
            Genre_textfield.Text = "";

            full_name_customer.Text = ""; email_customer.Text = ""; phone_customer.Text = ""; address_customer.Text = ""; text_filed_customer.Text = "";


        }

        private void data_customer_Click(object sender, EventArgs e)
        {
            try
            {
               string qry = "";
                qry = "select * from tbCustomer";
                DataTable tbl = new DataTable();
                tbl = connect.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    customer_data.DataSource = tbl;
                }
                Cust_ID = 1;
                Rental_ID = 0;
                Video_ID = 0;

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }

        }

        // show video data

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                String qry = "";
                qry = "select * from tbVideos";
                DataTable tbl = new DataTable();
                tbl = connect.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    videodata.DataSource = tbl;
                }
                Video_ID = 1;
                Rental_ID = 0;
                Cust_ID = 0;

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        // data grid view

        private void videodata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Video_ID>0) {
                
                text_filed_videoId.Text = videodata.CurrentRow.Cells[0].Value.ToString();
                movie_name_textfiled.Text = videodata.CurrentRow.Cells[1].Value.ToString();

                ratings_textfiled.Text = videodata.CurrentRow.Cells[2].Value.ToString();
                year_textfiled.Text = videodata.CurrentRow.Cells[3].Value.ToString(); ;
                cost_textfiled.Text = videodata.CurrentRow.Cells[4].Value.ToString(); ; 
                copies_textfiled.Text = videodata.CurrentRow.Cells[5].Value.ToString(); ;
                plot_textfield.Text = videodata.CurrentRow.Cells[6].Value.ToString(); ;
                Genre_textfield.Text = videodata.CurrentRow.Cells[7].Value.ToString(); ;
            }
            Video_ID = 0;
        }

        private void customer_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (Cust_ID>0) {
                text_filed_customer.Text = customer_data.CurrentRow.Cells[0].Value.ToString();
                full_name_customer.Text = customer_data.CurrentRow.Cells[1].Value.ToString();
                email_customer.Text = customer_data.CurrentRow.Cells[2].Value.ToString();
                phone_customer.Text = customer_data.CurrentRow.Cells[3].Value.ToString();

                address_customer.Text = customer_data.CurrentRow.Cells[4].Value.ToString();

            }
            Cust_ID = 0;

        }

        private void label3_Click(object sender, EventArgs e)
        {

            try
            {
                String qry = "";
                qry = "select * from tbRental";
                DataTable tbl = new DataTable();
                tbl = connect.getRecords(qry);
                if (tbl.Rows.Count > 0)
                {
                    Rental_data_show.DataSource = tbl;
                }
                Video_ID = 0;
                Rental_ID = 1;
                Cust_ID = 0;

            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);

            }
        }

        private void Rental_data_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Rental_ID>0) {

                rent = Convert.ToInt32(Rental_data_show.CurrentRow.Cells[0].Value.ToString());
                text_filed_videoId.Text = Rental_data_show.CurrentRow.Cells[1].Value.ToString();
                text_filed_customer.Text = Rental_data_show.CurrentRow.Cells[2].Value.ToString();


            }
            Rental_ID=0;


        }

        private void label20_Click(object sender, EventArgs e)
        {
            DataTable dataTable=connect.getRecords("select * from tbVideos");
            int rowIndex = 0;
            string Title = "";
            while (rowIndex < dataTable.Rows.Count)
            {
                DataTable Rental = connect.getRecords("select * from tbRental where MId=" + Convert.ToInt32(dataTable.Rows[rowIndex]["id"]) + "");

                int length = 0;
                if (Rental.Rows.Count > length)
                {
                    Title = dataTable.Rows[rowIndex]["VTitle"].ToString();
                    length = Rental.Rows.Count;
                }
                rowIndex++;
            }
            MessageBox.Show(Title + " is the best Video, Good Luck");



        }

        private void label19_Click(object sender, EventArgs e)
        {
            DataTable dataTable = connect.getRecords("select * from tbCustomer");
            int rowIndex = 0;
            string Title = "";
            while (rowIndex < dataTable.Rows.Count)
            {
                DataTable Rental = connect.getRecords("select * from tbRental where CID=" + Convert.ToInt32(dataTable.Rows[rowIndex]["id"]) + "");

                int length = 0;
                if (Rental.Rows.Count > length)
                {
                    Title = dataTable.Rows[rowIndex]["CustName"].ToString();
                    length = Rental.Rows.Count;
                }
                rowIndex++;
            }
            MessageBox.Show(Title + " is the best Customer, Good Luck");
        }
    }
}
