using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable x = new DataTable();
        private void enterresource_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            if(n1<0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("invalid input data");
                Environment.Exit(0);
            }
            
            int i = 1;
            while(n1!=0)
            {
                x.Columns.Add("R" + i, typeof(int));
                n1--;
                i++;
            }

            dataGridViewtotal.DataSource = x;
            dataGridViewava.DataSource = x;
            enterresource.Visible = false;
        }
        private void dataGridViewtotal_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
           
        }
        int indexofrow;
        private void dataGridViewtotal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexofrow = e.RowIndex;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow actionrow = dataGridViewtotal.Rows[indexofrow];
            int ctr = 1;
            for (int i=0;i<int.Parse(numberofresources.Text);i++)
            {
                actionrow.Cells[i].Value = Interaction.InputBox("Enter total number of R" + ctr, "R" + ctr, "", -1, -1);
                int ii = Convert.ToInt32(actionrow.Cells[i].Value);
                if(ii<0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("invalid input data");
                    Environment.Exit(0);
                }
            }
            button1.Visible=false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow actionrow = dataGridViewava.Rows[indexofrow];
            int ctr = 1;
            for (int i = 0; i < int.Parse(numberofresources.Text); i++)
            {
                actionrow.Cells[i].Value = Interaction.InputBox("Enter total number of R" + ctr, "R" + ctr, "", -1, -1);
                int ii = Convert.ToInt32(actionrow.Cells[i].Value);
                if (ii < 0)
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("invalid input data");
                    Environment.Exit(0);
                }
            }
            button2.Visible = false;
        }
        private void enterprocess_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            int i = 1;
            int n2 = Convert.ToInt32(numberofprocess.Text);
            if(n2<0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("invalid input data");
                Environment.Exit(0);
            }
            dataGridViewcurrent.Columns.Add("r " , " ");
            dataGridViewmax.Columns.Add("r ", " ");
            dataGridViewremaining.Columns.Add("r", " ");
            while (n1 != 0)
            {
                dataGridViewcurrent.Columns.Add("R" + i, "R" + i);
                dataGridViewmax.Columns.Add("R" + i, "R" + i);
                dataGridViewremaining.Columns.Add("R" + i, "R" + i);
                n1--;
                i++;
            }
            i = 1;
            while (n2 != 0)
            {
                dataGridViewcurrent.Rows.Add("P" + i);
                dataGridViewmax.Rows.Add("P" + i);
                dataGridViewremaining.Rows.Add("P"+ i);
                n2--;
                i++;
            }
            enterprocess.Visible = false;
        }
        private void entercurrentdata_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            int n2 = Convert.ToInt32(numberofprocess.Text);
            for (int i=0;i<n2;i++)
            {
                for(int j=0;j<=n1;j++)
                {
                    if(j!=0)
                   dataGridViewcurrent.Rows[i].Cells[j].Value =int.Parse(Interaction.InputBox("Enter total number of R" , "R" , "", 1, -1));
                    //int ii = Convert.ToInt32(dataGridViewcurrent.Rows[i].Cells[j].Value.ToString());
                    //if (ii < 0)
                    //{
                    //    MessageBox.Show("invalid input data");
                    //    Environment.Exit(0);
                    //}
                }
            }
            entercurrentdata.Visible = false;
        }
        private void entermaxdata_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            int n2 = Convert.ToInt32(numberofprocess.Text);
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j <= n1; j++)
                {
                    if (j != 0)
                        dataGridViewmax.Rows[i].Cells[j].Value = int.Parse(Interaction.InputBox("Enter total number of R", "R", "", -1, -1));
                    //int ii = Convert.ToInt32(dataGridViewmax.Rows[i].Cells[j].Value.ToString());
                    //if (ii < 0)
                    //{
                    //    MessageBox.Show("invalid input data");
                    //    Environment.Exit(0);
                    //}

                }

            }
            entermaxdata.Visible = false;
        }
        private void comboBoxprocess_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            int n2 = Convert.ToInt32(numberofprocess.Text);
            int t1 = int.Parse( textBoxprocess.Text);
            int t2 = int.Parse(textBoxresource.Text);
            int t3 = int.Parse(textBoxreqnumber.Text);
            DataGridViewRow new_cell = dataGridViewava.Rows[0];
            //new_cell.DefaultCellStyle.BackColor = Color.Red;
            DataGridViewRow new_cell2 = dataGridViewcurrent.Rows[t1-1];
            new_cell.Cells[t2-1].Value =  int.Parse(new_cell.Cells[t2-1].Value.ToString()) - t3;
            new_cell.DefaultCellStyle.BackColor = Color.Red;
            int yy = int.Parse(new_cell.Cells[t2 - 1].Value.ToString()) - t3;
            if(yy<0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("not allowed");
                Environment.Exit(0);
            }
            new_cell2.Cells[t2].Value = int.Parse(new_cell.Cells[t2].Value.ToString()) + t3;
            new_cell2.DefaultCellStyle.BackColor = Color.Red;
            int hh = int.Parse(new_cell.Cells[t2].Value.ToString()) + t3;
            if(hh<0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("not allowed");
                Environment.Exit(0);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(numberofresources.Text);
            int n2 = Convert.ToInt32(numberofprocess.Text);
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j <= n1; j++)
                {

                    if (j != 0)
                    {
                        dataGridViewremaining.Rows[i].Cells[j].Value = (Convert.ToInt32(dataGridViewmax.Rows[i].Cells[j].Value) - Convert.ToInt32(dataGridViewcurrent.Rows[i].Cells[j].Value));
                        int v = Convert.ToInt32(dataGridViewremaining.Rows[i].Cells[j].Value.ToString());
                        if(v<0)
                        {
                            // dataGridViewremaining.Rows[i].Cells[j].Value = 0;
                            SystemSounds.Exclamation.Play();
                            MessageBox.Show("not allowed");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            bool lastflage = false;
            DataGridViewRow actionrow = dataGridViewava.Rows[indexofrow];
            DataGridViewRow new_cell = dataGridViewava.Rows[indexofrow];
            DataGridViewRow bb = dataGridViewtotal.Rows[indexofrow];
            int n1 = Convert.ToInt32(numberofresources.Text);
            int n2 = Convert.ToInt32(numberofprocess.Text);
            bool flage = false;
            int r = 0;
            for (int n = 0; n < n2; n++)
            {
            //   MessageBox.Show("n "+n);
                for (int i = 0; i < n2; i++)
                {
                    // MessageBox.Show("i "+i);
                    
                    for (int j = 0; j <= n1; j++)
                    {
                        if (j != 0)
                        {
                          //  MessageBox.Show("j "+j);

                            if (Convert.ToInt32(dataGridViewremaining.Rows[r].Cells[j].Value.ToString())>Convert.ToInt32(actionrow.Cells[j-1].Value.ToString()))
                            {
                                flage = true;
                                break;
                            }
                            dataGridViewremaining.DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                    if(flage==false)
                    {
                     //  MessageBox.Show("y");
                        for (int u = 0; u < n1; u++)
                        {
                            int x = Convert.ToInt32(new_cell.Cells[u].Value.ToString());
                            int y =Convert.ToInt32(dataGridViewcurrent.Rows[i].Cells[u+1].Value.ToString());
                            new_cell.Cells[u].Value = (x + y).ToString();
                            new_cell.DefaultCellStyle.BackColor = Color.Red;
                        }
                     //  MessageBox.Show("k");
                        dataGridViewremaining.Rows.RemoveAt(r);
                        
                        new_cell.DefaultCellStyle.BackColor = Color.Red;
                        MessageBox.Show("iteration "+i);
                        r = 0;
                    }
                    else
                    {
                        r++;
                    //    MessageBox.Show("rr");
                    }
                }
              //  MessageBox.Show("oo");
                for (int x = 0; x < n1; x++)
                {
                   // MessageBox.Show("x " + x);
                   // MessageBox.Show(new_cell.Cells[x].Value.ToString());
                   // MessageBox.Show(bb.Cells[x].Value.ToString());
                    int v = Convert.ToInt32(new_cell.Cells[x].Value.ToString());
                   // MessageBox.Show("v " + v);
                    int q = Convert.ToInt32(bb.Cells[x].Value.ToString());
                 //   MessageBox.Show("q " + q);
                    if (v != q)
                    {
                     //   MessageBox.Show("da5let");
                        lastflage = true;
                        break;
                    }
                }
               if(lastflage==false)
               {
                    MessageBox.Show("safe");
                    break;
               }
               else if(lastflage==true&&n==n2-1)
               {
                    MessageBox.Show(" not safe");
                    break;
               }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=enewMch9vaM&list=PLb6C49tXQ0xB_iJK3J_p2gU73ct64B0on&index=5&t=1341s");  
        }
    }
}
























