using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace sUPdo
{
    public partial class frmStudent : MetroForm
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private string path;

        private void frmStudent_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectedIndex = 0;
            path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "Fisiere sUPdo Elev");

            Directory.CreateDirectory(path);

        }

       

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 2)
            {
                this.Hide();
                frmAutentifications frm = new frmAutentifications();
                frm.Show();
            }
            if(metroTabControl1.SelectedIndex==1)
            {
                dbforstudent.extractFiles();
                makePanels();
            }
        }
        Panel[] pnl = new Panel[100];
        private void makePanels()
        {
            int x = 25, y = 25;

            for (int i = 0; i < important.lungime; i++)
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
                lbl.Text = "Profesorul " + important.filesS[i].nameS;
                lbl.Size = new Size(new Point(300, 25));
                lbl.ForeColor = Color.White;
                lbl.Font = new Font("Arial", 12, FontStyle.Regular);
                lbl.CreateControl();
                pnl[i].Controls.Add(lbl);

                Label lbl2 = new Label();
                lbl2.Location = new Point(10, 35);
                lbl2.Text = "La data de " + important.filesS[i].datime.ToString();
                lbl2.Size = new Size(new Point(300, 25));
                lbl2.ForeColor = Color.White;
                lbl2.Font = new Font("Arial", 12, FontStyle.Regular);
                lbl2.CreateControl();
                pnl[i].Controls.Add(lbl2);

             

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

                if (important.filesS[i].message != "")
                {
                    Button btnMsj = new Button();
                    btnMsj.Location = new Point(110, 85);
                    btnMsj.Text = "Mesaj";
                    btnMsj.Size = new Size(new Point(90, 30));
                    btnMsj.Font = new Font("Arial", 12, FontStyle.Regular);
                    btnMsj.FlatStyle = FlatStyle.Flat;
                    btnMsj.Name = i.ToString();
                    btnMsj.ForeColor = Color.White;
                    btnMsj.Click += BtnMsj_Click;
                    btnMsj.CreateControl();
                    pnl[i].Controls.Add(btnMsj); 
                }
            }
        }

        private void BtnMsj_Click(object sender, EventArgs e)
        {
            Button dar = (Button)sender;
            important.varPoz = int.Parse(dar.Name);
            Form frm = new frmMessage();
            frm.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            string loc = path + @"\" + important.filesS[int.Parse(but.Name)].namefile + "." + important.filesS[int.Parse(but.Name)].extension;
            if (File.Exists(but.Name) == false)
            {
                dbforstudent.makefisier(loc, important.filesS[int.Parse(but.Name)].id);
            }
            System.Diagnostics.Process.Start(loc);
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

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            important.trimis = 0;
            foreach(string path in lstPaths)
            {
                long length =new FileInfo(path).Length;

                if (Path.GetExtension(path) == ".exe"|| Path.GetExtension(path)==".Ink" || Path.GetExtension(path) == ".bat")
                    MessageBox.Show("Fisierul " + Path.GetFileNameWithoutExtension(path) + " nu va fi trimis deoarece este un executabil");
                else
                    if (length > 10000000)
                    MessageBox.Show("Marimea fisierului " + Path.GetFileNameWithoutExtension(path) + " depaseste 10MB si nu va fi trimis");
                else
                    dbforstudent.insertFiles(path, txtMessage.Text);

            }

            if (important.trimis != 0)
            {
                MessageBox.Show("Fisierele au fost trimise");
            }
            

            lstPaths.Clear();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
