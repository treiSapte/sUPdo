using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace sUPdo
{
    public partial class frmAutentifications : MetroForm
    {
        public frmAutentifications()
        {
            InitializeComponent();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 1;
        }

        private void btnSingUP_Click(object sender, EventArgs e)
        {
            //profesor
            lblTeach.Visible = false;
            if(txtNameT.Text!=""&&txtPasswordT.Text!=""&&txtEmailT.Text!="")
            {
                RegexUtilities ru = new RegexUtilities();
                if (ru.IsValidEmail(txtEmailT.Text)==false)
                {
                    lblTeach.Visible = true;
                    lblTeach.Text = "Adresa de email este invalida.";
                }
                else
                {
                    if (database.signUPteacher(txtNameT.Text, txtEmailT.Text, txtPasswordT.Text) == 1)// inserarea in database
                    {
                        metroTabControl1.SelectedIndex = 1;
                    }
                    else
                    {
                        lblTeach.Visible = true;
                        lblTeach.Text = "Adresa de email există deja în baza de date.";
                    } }

            }
            else
            {
                lblTeach.Visible = true;
                lblTeach.Text = "Completați toate câmpurile.";
            }

        }

       

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            lblLogin.Visible = false;
            if (txtPassSignIN.Text != "" && txtEmailSignIN.Text != "")
            {
                int a, b;
                a = database.signINt(txtEmailSignIN.Text, txtPassSignIN.Text);
                b = database.signINs(txtEmailSignIN.Text, txtPassSignIN.Text);
                if (a == 1)
                {
                    important.teacherORstudent = 1;
                    Form frm = new frmTeacher();
                    frm.Show();
                    this.Hide();
                }
                else
                    if (b == 1)
                {
                    important.teacherORstudent = 2;
                    database.getIdTeacher(important.id);
                    Form frm = new frmStudent();
                    frm.Show();

                    this.Hide();

                }
                else
                    if (a == 0 || b == 0)
                {
                    //nere
                    lblLogin.Visible = true;
                    lblLogin.Text = "Date incorecte.";
                    pnlForgotEmaiil.Visible = true;
                }
                else
                    if (a == 2 || b == 2)
                {
                    //email
                    lblLogin.Visible = true;
                    lblLogin.Text = "Adresa de email nu există în baza de date.";
                }


            }
            else
            {
                lblLogin.Visible = true;
                lblLogin.Text = "Completați toate câmpurile.";
                
            }
        }



        private void btnSignupS_Click(object sender, EventArgs e)
        {
            lblStudent.ForeColor = Color.Red;
            lblStudent.Visible = false;
            if(txtName.Text!=""&&txtEmail.Text!=""&&txtPassword.Text!=""&&txtClass.Text!=""&&txtCode_teacher.Text!="")
            {
                RegexUtilities ru = new RegexUtilities(); // test
                if (ru.IsValidEmail(txtEmail.Text) == false)
                {
                    lblStudent.Visible = true;
                    lblStudent.Text = "Adresa de email este invalida.";
                }
                else
                {
                    switch (database.signUPstudent(txtName.Text, txtEmail.Text, txtPassword.Text, txtClass.Text, int.Parse(txtCode_teacher.Text)))
                    {
                        case 2:
                            {
                                lblStudent.Visible = true;
                                lblStudent.Text = "Adresa de email există deja în baza de date.";
                                txtEmail.Text = "";
                                txtPassword.Text = "";
                                break;
                            }
                        case 1:
                            {
                                metroTabControl1.SelectedIndex = 1;
                                break;
                            }
                    }
                }
                
            }
                else
                {
                lblStudent.Visible = true;
                lblStudent.Text = "Completați toate câmpurile.";

                }
        }

        private void btnForgotPass_Click(object sender, EventArgs e)
        {
            pnlForgotEmaiil.Visible = true;
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {
            pnlForgotEmaiil.Visible = false;
            lblSendEmail.Visible = false;
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            if(txtForgotEmail.Text!="")
            {
                string pass = database.recPass(txtForgotEmail.Text);
                if(pass!=".")
                {
                    functions.SendMail(txtForgotEmail.Text, pass);
                    
                    lblSendEmail.Visible = true;
                    lblSendEmail.ForeColor = Color.Purple;
                    lblSendEmail.Text = "Un mail cu parola a fost trimis la adresa"+'\n'+" de email specificată.";
                }
                else
                {
                    lblSendEmail.Visible = true;
                    lblSendEmail.ForeColor = Color.Red;
                    lblSendEmail.Text = "Adresa de email nu există în baza de date.";
                }

            }
            else
            {
                lblSendEmail.Visible = true;
                lblSendEmail.ForeColor = Color.Red;
                lblSendEmail.Text = "Introduceți adresa de email";
            }
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlForgotEmaiil.Visible = false;
        }

        private void frmAutentifications_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            this.Parent = null;
            e.Cancel = true;
        }
    }
}
