using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace sUPdo
{
    public partial class frmTeacher : MetroForm
    {
        public frmTeacher()
        {
            InitializeComponent();
        }

        private string path;

        public string stringToClasses = "";

        private void frmActions_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            metroLabel1.Text = "Codul tău este: " + important.id; //pus where
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path,"Fisiere sUPdo Profesor");
           
            Directory.CreateDirectory(path);
            // important.nume si important.id

            string classString = dbforteacher.getClasses();
           
            string[] classes = classString.Split(' ');
            foreach(string word in classes)
            {
                if (word != " ")
                    cmbClasses.Items.Add(word);
            }

        }

        Panel[] pnl = new Panel[100];

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(metroTabControl1.SelectedIndex==1)
            {
                ///apel
                dbforteacher.extractFiles();
                makePanels();
            }
            else
                if(metroTabControl1.SelectedIndex==2)
            {
                this.Hide();
                frmAutentifications frm = new frmAutentifications();
                frm.Show();
            }
            
               
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        // pun datele si la click se downlandeaza si deschide

        private void makePanels()
        {
            int x = 25, y = 25;
            
            for (int i=0;i<important.lungime;i++)
            {
                
                pnl[i] = new Panel();
                pnl[i].Location = new Point(x, y);
                pnl[i].BackColor = Color.Purple;
                pnl[i].Size = new Size(390, 120);
                pnl[i].CreateControl();
                pnlMain.Controls.Add(pnl[i]);
                y = y + 130;

                Label lbl = new Label();
                lbl.Location = new Point(10, 10);
                lbl.Text = "Elevul " + important.files[i].nameS;
                lbl.Size = new Size(new Point(300, 25));
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arial", 12, FontStyle.Regular);
                lbl.CreateControl();
                pnl[i].Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Location = new Point(10, 35);
                lbl2.Text ="Din clasa " + important.files[i].classS;
                lbl2.Size = new Size(new Point(300, 25));
                lbl2.ForeColor = Color.White;
                lbl2.Font = new Font("Arial", 12, FontStyle.Regular);
                lbl2.CreateControl();
                pnl[i].Controls.Add(lbl2);

                Label lbl3 = new Label();
                lbl3.Location = new Point(10, 60);
                lbl3.Size = new Size(new Point(300, 25));
                lbl3.ForeColor = Color.White;
                lbl3.Font = new Font("Arial", 12, FontStyle.Regular);
                lbl3.Text = "La data de " + important.files[i].datime.ToString();
                lbl3.CreateControl();
                pnl[i].Controls.Add(lbl3);

                Button btn = new Button();
                btn.Location = new Point(10, 85);
                btn.Text = "Deschide";
                btn.Size = new Size(new Point(90, 30));
                btn.Font = new Font("Arial", 12, FontStyle.Regular);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.Name = i.ToString();
                btn.Click += Btn_Click;
                btn.CreateControl();
                pnl[i].Controls.Add(btn); 

                if (important.files[i].message != "")
                {
                    Button btnMsj = new Button();
                    btnMsj.Location = new Point(110, 85);
                    btnMsj.Text = "Mesaj";
                    btnMsj.Size = new Size(new Point(90, 30));
                    btnMsj.Font = new Font("Arial", 12, FontStyle.Regular);
                    btnMsj.ForeColor = Color.White;
                    btnMsj.FlatStyle = FlatStyle.Flat;
                    btnMsj.Name = i.ToString();
                    btnMsj.Click += BtnMsj_Click;
                    btnMsj.CreateControl();
                    pnl[i].Controls.Add(btnMsj); 
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string loc = path + @"\" + important.files[int.Parse(but.Name)].namefile + "." + important.files[int.Parse(but.Name)].extension;
            if (File.Exists(but.Name)==false)
            {
                dbforteacher.makefisier(loc,important.files[int.Parse(but.Name)].id);
            }
            System.Diagnostics.Process.Start(loc);
        }

        private void BtnMsj_Click(object sender, EventArgs e)
        {
            Button dar = (Button)sender;
            important.varPoz = int.Parse(dar.Name);
            Form frm = new frmMessage();
            frm.Show();
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            foreach (string path in lstPaths)
            {
                dbforteacher.insertFiles(path, txtMessage.Text, stringToClasses);
               
            }
            
            MessageBox.Show("Fisierele au fost trimise");
            lstPaths.Clear();
            stringToClasses = "";
        }

      

        List<string> lstPaths = new List<string>();

        private void pnlFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            int i;
            string pathts;
            for (i = 0; i < files.Length; i++)
            {
                pathts = files[i];
                lstPaths.Add(pathts);
            }

        }

        private void pnlFiles_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void cmbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            stringToClasses = stringToClasses + " " + cmbClasses.SelectedItem;
        }
    }
}
