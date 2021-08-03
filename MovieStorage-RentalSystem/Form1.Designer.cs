
namespace MovieStorage_RentalSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Rental_data_show = new System.Windows.Forms.DataGridView();
            this.customer_data = new System.Windows.Forms.DataGridView();
            this.videodata = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.delete_buuton_customer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.address_customer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.add_button_customer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.email_customer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.phone_customer = new System.Windows.Forms.TextBox();
            this.full_name_customer = new System.Windows.Forms.TextBox();
            this.update_button_customer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Genre_textfield = new System.Windows.Forms.TextBox();
            this.cost_textfiled = new System.Windows.Forms.TextBox();
            this.plot_textfield = new System.Windows.Forms.TextBox();
            this.add_movie = new System.Windows.Forms.Button();
            this.update_movie = new System.Windows.Forms.Button();
            this.delete_movie = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.copies_textfiled = new System.Windows.Forms.TextBox();
            this.ratings_textfiled = new System.Windows.Forms.TextBox();
            this.year_textfiled = new System.Windows.Forms.TextBox();
            this.movie_name_textfiled = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_button_rental = new System.Windows.Forms.Button();
            this.return_button_rentals = new System.Windows.Forms.Button();
            this.Issue_button_rentals = new System.Windows.Forms.Button();
            this.Return_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Issue_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_filed_customer = new System.Windows.Forms.TextBox();
            this.text_filed_videoId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.data_customer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Rental_data_show)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videodata)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rental_data_show
            // 
            this.Rental_data_show.BackgroundColor = System.Drawing.Color.Olive;
            this.Rental_data_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rental_data_show.Location = new System.Drawing.Point(-2, 214);
            this.Rental_data_show.Name = "Rental_data_show";
            this.Rental_data_show.Size = new System.Drawing.Size(674, 167);
            this.Rental_data_show.TabIndex = 0;
            this.Rental_data_show.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rental_data_show_CellContentClick);
            // 
            // customer_data
            // 
            this.customer_data.BackgroundColor = System.Drawing.Color.Olive;
            this.customer_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_data.Location = new System.Drawing.Point(-2, 37);
            this.customer_data.Name = "customer_data";
            this.customer_data.Size = new System.Drawing.Size(347, 145);
            this.customer_data.TabIndex = 1;
            this.customer_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_data_CellContentClick);
            // 
            // videodata
            // 
            this.videodata.BackgroundColor = System.Drawing.Color.Olive;
            this.videodata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.videodata.Location = new System.Drawing.Point(352, 37);
            this.videodata.Name = "videodata";
            this.videodata.Size = new System.Drawing.Size(321, 145);
            this.videodata.TabIndex = 2;
            this.videodata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.videodata_CellContentClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 378);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(546, 232);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Yellow;
            this.tabPage1.Controls.Add(this.delete_buuton_customer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.address_customer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.add_button_customer);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.email_customer);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.phone_customer);
            this.tabPage1.Controls.Add(this.full_name_customer);
            this.tabPage1.Controls.Add(this.update_button_customer);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Customers";
            // 
            // delete_buuton_customer
            // 
            this.delete_buuton_customer.BackColor = System.Drawing.Color.Red;
            this.delete_buuton_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_buuton_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_buuton_customer.Location = new System.Drawing.Point(440, 99);
            this.delete_buuton_customer.Name = "delete_buuton_customer";
            this.delete_buuton_customer.Size = new System.Drawing.Size(74, 31);
            this.delete_buuton_customer.TabIndex = 93;
            this.delete_buuton_customer.Text = "Delete";
            this.delete_buuton_customer.UseVisualStyleBackColor = false;
            this.delete_buuton_customer.Click += new System.EventHandler(this.delete_buuton_customer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Phone :";
            // 
            // address_customer
            // 
            this.address_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_customer.Location = new System.Drawing.Point(397, 55);
            this.address_customer.Name = "address_customer";
            this.address_customer.Size = new System.Drawing.Size(117, 26);
            this.address_customer.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 88;
            this.label5.Text = "Email :";
            // 
            // add_button_customer
            // 
            this.add_button_customer.BackColor = System.Drawing.Color.Red;
            this.add_button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_button_customer.Location = new System.Drawing.Point(281, 99);
            this.add_button_customer.Name = "add_button_customer";
            this.add_button_customer.Size = new System.Drawing.Size(65, 31);
            this.add_button_customer.TabIndex = 92;
            this.add_button_customer.Text = "Add ";
            this.add_button_customer.UseVisualStyleBackColor = false;
            this.add_button_customer.Click += new System.EventHandler(this.add_button_customer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Full Name :";
            // 
            // email_customer
            // 
            this.email_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_customer.Location = new System.Drawing.Point(139, 86);
            this.email_customer.Name = "email_customer";
            this.email_customer.Size = new System.Drawing.Size(117, 26);
            this.email_customer.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(283, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 90;
            this.label7.Text = "Address :";
            // 
            // phone_customer
            // 
            this.phone_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_customer.Location = new System.Drawing.Point(139, 130);
            this.phone_customer.Name = "phone_customer";
            this.phone_customer.Size = new System.Drawing.Size(117, 26);
            this.phone_customer.TabIndex = 84;
            // 
            // full_name_customer
            // 
            this.full_name_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name_customer.Location = new System.Drawing.Point(139, 41);
            this.full_name_customer.Name = "full_name_customer";
            this.full_name_customer.Size = new System.Drawing.Size(117, 26);
            this.full_name_customer.TabIndex = 83;
            // 
            // update_button_customer
            // 
            this.update_button_customer.BackColor = System.Drawing.Color.Red;
            this.update_button_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button_customer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_button_customer.Location = new System.Drawing.Point(352, 99);
            this.update_button_customer.Name = "update_button_customer";
            this.update_button_customer.Size = new System.Drawing.Size(78, 31);
            this.update_button_customer.TabIndex = 91;
            this.update_button_customer.Text = "Update";
            this.update_button_customer.UseVisualStyleBackColor = false;
            this.update_button_customer.Click += new System.EventHandler(this.update_button_customer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Yellow;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.Genre_textfield);
            this.tabPage2.Controls.Add(this.cost_textfiled);
            this.tabPage2.Controls.Add(this.plot_textfield);
            this.tabPage2.Controls.Add(this.add_movie);
            this.tabPage2.Controls.Add(this.update_movie);
            this.tabPage2.Controls.Add(this.delete_movie);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.copies_textfiled);
            this.tabPage2.Controls.Add(this.ratings_textfiled);
            this.tabPage2.Controls.Add(this.year_textfiled);
            this.tabPage2.Controls.Add(this.movie_name_textfiled);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Videos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Genre";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(273, 66);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 20);
            this.label17.TabIndex = 99;
            this.label17.Text = "Plot";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(273, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 20);
            this.label18.TabIndex = 98;
            this.label18.Text = "Cost";
            // 
            // Genre_textfield
            // 
            this.Genre_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre_textfield.Location = new System.Drawing.Point(387, 108);
            this.Genre_textfield.Name = "Genre_textfield";
            this.Genre_textfield.Size = new System.Drawing.Size(117, 26);
            this.Genre_textfield.TabIndex = 97;
            // 
            // cost_textfiled
            // 
            this.cost_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_textfiled.Location = new System.Drawing.Point(387, 16);
            this.cost_textfiled.Name = "cost_textfiled";
            this.cost_textfiled.Size = new System.Drawing.Size(117, 26);
            this.cost_textfiled.TabIndex = 96;
            // 
            // plot_textfield
            // 
            this.plot_textfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot_textfield.Location = new System.Drawing.Point(387, 60);
            this.plot_textfield.Name = "plot_textfield";
            this.plot_textfield.Size = new System.Drawing.Size(117, 26);
            this.plot_textfield.TabIndex = 95;
            // 
            // add_movie
            // 
            this.add_movie.BackColor = System.Drawing.Color.Red;
            this.add_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_movie.Location = new System.Drawing.Point(268, 166);
            this.add_movie.Name = "add_movie";
            this.add_movie.Size = new System.Drawing.Size(58, 31);
            this.add_movie.TabIndex = 94;
            this.add_movie.Text = "Add";
            this.add_movie.UseVisualStyleBackColor = false;
            this.add_movie.Click += new System.EventHandler(this.add_movie_Click);
            // 
            // update_movie
            // 
            this.update_movie.BackColor = System.Drawing.Color.Red;
            this.update_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.update_movie.Location = new System.Drawing.Point(337, 166);
            this.update_movie.Name = "update_movie";
            this.update_movie.Size = new System.Drawing.Size(75, 31);
            this.update_movie.TabIndex = 93;
            this.update_movie.Text = "Update";
            this.update_movie.UseVisualStyleBackColor = false;
            this.update_movie.Click += new System.EventHandler(this.update_movie_Click);
            // 
            // delete_movie
            // 
            this.delete_movie.BackColor = System.Drawing.Color.Red;
            this.delete_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_movie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_movie.Location = new System.Drawing.Point(429, 166);
            this.delete_movie.Name = "delete_movie";
            this.delete_movie.Size = new System.Drawing.Size(75, 31);
            this.delete_movie.TabIndex = 92;
            this.delete_movie.Text = "Delete";
            this.delete_movie.UseVisualStyleBackColor = false;
            this.delete_movie.Click += new System.EventHandler(this.delete_movie_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 73;
            this.label8.Text = "Copies on rent";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "Year realesed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 71;
            this.label10.Text = "Ratings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 20);
            this.label11.TabIndex = 70;
            this.label11.Text = "Movie Name :";
            // 
            // copies_textfiled
            // 
            this.copies_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copies_textfiled.Location = new System.Drawing.Point(129, 153);
            this.copies_textfiled.Name = "copies_textfiled";
            this.copies_textfiled.Size = new System.Drawing.Size(117, 26);
            this.copies_textfiled.TabIndex = 69;
            // 
            // ratings_textfiled
            // 
            this.ratings_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ratings_textfiled.Location = new System.Drawing.Point(129, 61);
            this.ratings_textfiled.Name = "ratings_textfiled";
            this.ratings_textfiled.Size = new System.Drawing.Size(117, 26);
            this.ratings_textfiled.TabIndex = 68;
            // 
            // year_textfiled
            // 
            this.year_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_textfiled.Location = new System.Drawing.Point(129, 105);
            this.year_textfiled.Name = "year_textfiled";
            this.year_textfiled.Size = new System.Drawing.Size(117, 26);
            this.year_textfiled.TabIndex = 67;
            this.year_textfiled.TextChanged += new System.EventHandler(this.year_textfiled_TextChanged);
            // 
            // movie_name_textfiled
            // 
            this.movie_name_textfiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movie_name_textfiled.Location = new System.Drawing.Point(129, 16);
            this.movie_name_textfiled.Name = "movie_name_textfiled";
            this.movie_name_textfiled.Size = new System.Drawing.Size(117, 26);
            this.movie_name_textfiled.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.delete_button_rental);
            this.groupBox1.Controls.Add(this.return_button_rentals);
            this.groupBox1.Controls.Add(this.Issue_button_rentals);
            this.groupBox1.Controls.Add(this.Return_dateTimePicker);
            this.groupBox1.Controls.Add(this.Issue_dateTimePicker);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.text_filed_customer);
            this.groupBox1.Controls.Add(this.text_filed_videoId);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(564, 368);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // delete_button_rental
            // 
            this.delete_button_rental.BackColor = System.Drawing.Color.Red;
            this.delete_button_rental.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button_rental.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delete_button_rental.Location = new System.Drawing.Point(204, 212);
            this.delete_button_rental.Name = "delete_button_rental";
            this.delete_button_rental.Size = new System.Drawing.Size(100, 31);
            this.delete_button_rental.TabIndex = 95;
            this.delete_button_rental.Text = "Delete Movie";
            this.delete_button_rental.UseVisualStyleBackColor = false;
            this.delete_button_rental.Click += new System.EventHandler(this.delete_button_rental_Click);
            // 
            // return_button_rentals
            // 
            this.return_button_rentals.BackColor = System.Drawing.Color.Red;
            this.return_button_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_button_rentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.return_button_rentals.Location = new System.Drawing.Point(100, 212);
            this.return_button_rentals.Name = "return_button_rentals";
            this.return_button_rentals.Size = new System.Drawing.Size(98, 31);
            this.return_button_rentals.TabIndex = 94;
            this.return_button_rentals.Text = "Retrun Now";
            this.return_button_rentals.UseVisualStyleBackColor = false;
            this.return_button_rentals.Click += new System.EventHandler(this.return_button_rentals_Click);
            // 
            // Issue_button_rentals
            // 
            this.Issue_button_rentals.BackColor = System.Drawing.Color.Red;
            this.Issue_button_rentals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Issue_button_rentals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Issue_button_rentals.Location = new System.Drawing.Point(36, 212);
            this.Issue_button_rentals.Name = "Issue_button_rentals";
            this.Issue_button_rentals.Size = new System.Drawing.Size(58, 31);
            this.Issue_button_rentals.TabIndex = 93;
            this.Issue_button_rentals.Text = "Issue";
            this.Issue_button_rentals.UseVisualStyleBackColor = false;
            this.Issue_button_rentals.Click += new System.EventHandler(this.Issue_button_rentals_Click);
            // 
            // Return_dateTimePicker
            // 
            this.Return_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Return_dateTimePicker.Location = new System.Drawing.Point(159, 176);
            this.Return_dateTimePicker.Name = "Return_dateTimePicker";
            this.Return_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Return_dateTimePicker.TabIndex = 92;
            // 
            // Issue_dateTimePicker
            // 
            this.Issue_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Issue_dateTimePicker.Location = new System.Drawing.Point(159, 128);
            this.Issue_dateTimePicker.Name = "Issue_dateTimePicker";
            this.Issue_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Issue_dateTimePicker.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(47, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 20);
            this.label15.TabIndex = 90;
            this.label15.Text = "Return Date";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 129);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 89;
            this.label16.Text = "Issue Date ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(45, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 88;
            this.label13.Text = "Customer ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 87;
            this.label14.Text = "Video Id:";
            // 
            // text_filed_customer
            // 
            this.text_filed_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filed_customer.Location = new System.Drawing.Point(159, 85);
            this.text_filed_customer.Name = "text_filed_customer";
            this.text_filed_customer.Size = new System.Drawing.Size(117, 26);
            this.text_filed_customer.TabIndex = 86;
            // 
            // text_filed_videoId
            // 
            this.text_filed_videoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_filed_videoId.Location = new System.Drawing.Point(159, 40);
            this.text_filed_videoId.Name = "text_filed_videoId";
            this.text_filed_videoId.Size = new System.Drawing.Size(117, 26);
            this.text_filed_videoId.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Red;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(96, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 23);
            this.label12.TabIndex = 84;
            this.label12.Text = "Rental Store";
            // 
            // data_customer
            // 
            this.data_customer.AutoSize = true;
            this.data_customer.BackColor = System.Drawing.Color.Transparent;
            this.data_customer.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data_customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.data_customer.Location = new System.Drawing.Point(39, 9);
            this.data_customer.Name = "data_customer";
            this.data_customer.Size = new System.Drawing.Size(167, 25);
            this.data_customer.TabIndex = 6;
            this.data_customer.Text = "Customer Data";
            this.data_customer.Click += new System.EventHandler(this.data_customer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(492, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Video  Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 96;
            this.label3.Text = "Rental Show";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Red;
            this.label20.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(693, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(256, 20);
            this.label20.TabIndex = 97;
            this.label20.Text = "Name of Popular Movie is";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Red;
            this.label19.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(678, 238);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(278, 18);
            this.label19.TabIndex = 98;
            this.label19.Text = "Name of Popular Customer is";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(970, 616);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_customer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.videodata);
            this.Controls.Add(this.customer_data);
            this.Controls.Add(this.Rental_data_show);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Rental_data_show)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videodata)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Rental_data_show;
        private System.Windows.Forms.DataGridView customer_data;
        private System.Windows.Forms.DataGridView videodata;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label data_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delete_buuton_customer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox address_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button add_button_customer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_customer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox phone_customer;
        private System.Windows.Forms.TextBox full_name_customer;
        private System.Windows.Forms.Button update_button_customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Genre_textfield;
        private System.Windows.Forms.TextBox cost_textfiled;
        private System.Windows.Forms.TextBox plot_textfield;
        private System.Windows.Forms.Button add_movie;
        private System.Windows.Forms.Button update_movie;
        private System.Windows.Forms.Button delete_movie;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox copies_textfiled;
        private System.Windows.Forms.TextBox ratings_textfiled;
        private System.Windows.Forms.TextBox year_textfiled;
        private System.Windows.Forms.TextBox movie_name_textfiled;
        private System.Windows.Forms.Button delete_button_rental;
        private System.Windows.Forms.Button return_button_rentals;
        private System.Windows.Forms.Button Issue_button_rentals;
        private System.Windows.Forms.DateTimePicker Return_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Issue_dateTimePicker;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox text_filed_customer;
        private System.Windows.Forms.TextBox text_filed_videoId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}

