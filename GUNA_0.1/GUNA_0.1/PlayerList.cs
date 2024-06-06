using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUNA_0._1
{
    public partial class PlayerList : Form
    {
        
        public PlayerList()
        {
            InitializeComponent();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void Players_Load(object sender, EventArgs e)
        {

            guna2DataGridView1.Rows.Add(7);
            guna2DataGridView1.Rows[0].Cells[1].Value = Image.FromFile("players\\boy.png");
            guna2DataGridView1.Rows[0].Cells[2].Value = "";
            guna2DataGridView1.Rows[0].Cells[3].Value = "Player1";
            guna2DataGridView1.Rows[0].Cells[4].Value = "Konto1";
            guna2DataGridView1.Rows[0].Cells[5].Value = "12";
            guna2DataGridView1.Rows[0].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[0].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[1].Cells[1].Value = Image.FromFile("players\\hacker.png");
            guna2DataGridView1.Rows[1].Cells[2].Value = "";
            guna2DataGridView1.Rows[1].Cells[3].Value = "Player2";
            guna2DataGridView1.Rows[1].Cells[4].Value = "Konto2";
            guna2DataGridView1.Rows[1].Cells[5].Value = "12";
            guna2DataGridView1.Rows[1].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[1].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[2].Cells[1].Value = Image.FromFile("players\\girl.png");
            guna2DataGridView1.Rows[2].Cells[2].Value = "";
            guna2DataGridView1.Rows[2].Cells[3].Value = "Player3";
            guna2DataGridView1.Rows[2].Cells[4].Value = "Konto3";
            guna2DataGridView1.Rows[2].Cells[5].Value = "12";
            guna2DataGridView1.Rows[2].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[2].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[3].Cells[1].Value = Image.FromFile("players\\girl.png");
            guna2DataGridView1.Rows[3].Cells[2].Value = "";
            guna2DataGridView1.Rows[3].Cells[3].Value = "Player4";
            guna2DataGridView1.Rows[3].Cells[4].Value = "Konto3";
            guna2DataGridView1.Rows[3].Cells[5].Value = "12";
            guna2DataGridView1.Rows[3].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[3].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[4].Cells[1].Value = Image.FromFile("players\\girl.png");
            guna2DataGridView1.Rows[4].Cells[2].Value = "";
            guna2DataGridView1.Rows[4].Cells[3].Value = "Player5";
            guna2DataGridView1.Rows[4].Cells[4].Value = "Konto3";
            guna2DataGridView1.Rows[4].Cells[5].Value = "12";
            guna2DataGridView1.Rows[4].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[4].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[5].Cells[1].Value = Image.FromFile("players\\girl.png");
            guna2DataGridView1.Rows[5].Cells[2].Value = "";
            guna2DataGridView1.Rows[5].Cells[3].Value = "Player6";
            guna2DataGridView1.Rows[5].Cells[4].Value = "Konto3";
            guna2DataGridView1.Rows[5].Cells[5].Value = "12";
            guna2DataGridView1.Rows[5].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[5].Cells[7].Value = "12.01.2021";

            guna2DataGridView1.Rows[6].Cells[1].Value = Image.FromFile("players\\girl.png");
            guna2DataGridView1.Rows[6].Cells[2].Value = "";
            guna2DataGridView1.Rows[6].Cells[3].Value = "Player7";
            guna2DataGridView1.Rows[6].Cells[4].Value = "Konto3";
            guna2DataGridView1.Rows[6].Cells[5].Value = "12";
            guna2DataGridView1.Rows[6].Cells[6].Value = "Minecraft";
            guna2DataGridView1.Rows[6].Cells[7].Value = "12.01.2021";
        }

    }
}
