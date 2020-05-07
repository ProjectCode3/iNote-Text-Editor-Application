using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net;


namespace OffGrid_iNote_Alpha_1._2
{
    public partial class AccountDets : UserControl
    {
        public AccountDets()
        {
            InitializeComponent();
        }

        public string AccName;
        public string Password;
        public int ID_Key;
        public bool Registered = false;

        private void AccountDets_Load(object sender, EventArgs e)
        {
            Boolean Reg = Properties.Config.Default.Registered;

            if (Reg == false)
            {
                btnRegister.Visible = true;
                Registered = false;              
            } else
            {
                btnRegister.Visible = false;
                Registered = true;
                lblAccNametxt.Text = Properties.Config.Default.UserName;
                lblAccID.Text = Properties.Config.Default.ID_Key.ToString();
                lblHostName.Text = Properties.Config.Default.PC_HOST;                
                lblAccReg.Text = Registered.ToString();
            }           
        } 

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string HostName = Environment.MachineName;
            Random rand = new Random();
          DialogResult dialogResult = MessageBox.Show("You're Account is not registered!",
                            "/n Would You like to Register Now", MessageBoxButtons.OKCancel);        
            
            if (dialogResult == DialogResult.OK)
            { 
                AccName = Microsoft.VisualBasic.Interaction.InputBox("Please Enter Your Full Name", "Register Name");
                Password = Microsoft.VisualBasic.Interaction.InputBox("Please Enter A Password For Your Account", "Register A Password");
                ID_Key = rand.Next(111111, 999999);
                
                if (AccName.Trim() == string.Empty && Password.Trim() == string.Empty)
                {
                    MessageBox.Show("[Exception] ERROR_Code = 400 Invalid Input ", "Input Error Exception");

                } else if (Password.Trim() ==  string.Empty && AccName.Trim() != string.Empty)
                {
                    MessageBox.Show("[Exception] ERROR_Code = 400 Invalid Input ", "Input Error Exception");
                } else if (AccName.Trim() == string.Empty && Password.Trim() != string.Empty)
                {
                    MessageBox.Show("[Exception] ERROR_Code = 400 Invalid Input ", "Input Error Exception");
                } else
                {
                    MessageBox.Show("Account Registered", "Account Registration Complete");
                    Registered = true;

                    if (Registered == true)
                    {
                        DialogResult returnVal = MessageBox.Show("To Complete Registration Please Restart The Program", "Registration", MessageBoxButtons.OK);

                        if (returnVal == DialogResult.OK)
                        {
                            Config config = new Config();
                            config.Close();
                        }

                        btnRegister.Visible = false;
                    }
                    
                    Properties.Config.Default.Registered = Registered;
                    Properties.Config.Default.UserName = AccName;
                    Properties.Config.Default.Password = Password;
                    Properties.Config.Default.ID_Key = ID_Key;
                    Properties.Config.Default.PC_HOST = HostName;
                    Properties.Config.Default.Save();

                    lblAccNametxt.Text = Properties.Config.Default.UserName;
                    lblAccID.Text = Properties.Config.Default.ID_Key.ToString();
                    lblHostName.Text = Properties.Config.Default.PC_HOST;
                    lblAccReg.Text = Registered.ToString();
                }

            } else
            {
                Registered = false;               
            }          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Cancel Everything
            DialogResult returnVal = MessageBox.Show("Are You Sure You Wish To Exit" +
                                                     "Any Unsaved Changes will Be Discared", "Exit Preferences", MessageBoxButtons.YesNo);

            if (returnVal == DialogResult.Yes)
            {
                MessageBox.Show("[Cancelled By User] Cancelled Account Details", "Exit Account Details");
                this.Hide();
            } else
            {
                MessageBox.Show("[Cancelled By User] Discarding Cancellation", "Exiting Account Details");
            }
        }
    }
}
 