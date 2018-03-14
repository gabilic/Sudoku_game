using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class frmSudoku : Form
    {
        private Igra igra = new Igra();

        public frmSudoku()
        {
            InitializeComponent();
            igra.popuniSlagalicu += igra_popuniSlagalicu;
            igra.vratiOdgovor += igra_vratiOdgovor;
            String[] param = { "-q" };
            PlEngine.Initialize(param);
            PlQuery.PlCall("use_module(sudoku)");
        }

        private void frmSudoku_Load(object sender, EventArgs e)
        {
            dgvSlagalica.Rows.Add(9);
            cmbRazina.SelectedIndex = 0;
            btnProvjeri.Enabled = false;
            btnRjesenje.Enabled = false;
        }

        private void btnNova_Click(object sender, EventArgs e)
        {
            int razina = cmbRazina.SelectedIndex + 4;
            igra.novaIgra(razina);
            btnProvjeri.Enabled = true;
            btnRjesenje.Enabled = true;
        }

        private void dgvSlagalica_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 75, 0, 75, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 150, 0, 150, 228);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 66, 228, 66);
            e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, 132, 228, 132);
        }

        private void btnRjesenje_Click(object sender, EventArgs e)
        {
            igra.rjesenje();
        }

        public void igra_popuniSlagalicu(String[,] brojevi, String tip)
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    dgvSlagalica.Rows[i].Cells[j].Value = brojevi[i, j];
                    if(tip == "pocetna")
                    {
                        if (brojevi[i, j] != String.Empty)
                        {
                            dgvSlagalica.Rows[i].Cells[j].ReadOnly = true;
                            dgvSlagalica.Rows[i].Cells[j].Style = dgvSlagalica.DefaultCellStyle;
                        }
                        else
                        {
                            dgvSlagalica.Rows[i].Cells[j].ReadOnly = false;
                            dgvSlagalica.Rows[i].Cells[j].Style = new DataGridViewCellStyle
                            {
                                ForeColor = Color.Blue,
                                SelectionForeColor = Color.Blue
                            };
                        }
                    }
                    else
                    {
                        if(dgvSlagalica.Rows[i].Cells[j].Style.ForeColor == Color.Red)
                        {
                            dgvSlagalica.Rows[i].Cells[j].Style = new DataGridViewCellStyle
                            {
                                ForeColor = Color.Blue,
                                SelectionForeColor = Color.Blue
                            };
                        }
                    }
                }
            }
        }

        private void btnProvjeri_Click(object sender, EventArgs e)
        {
            provjeriRjesenje();
        }

        public void provjeriRjesenje()
        {
            bool praznaPolja = false;
            String element = "";
            String provjera = "[";
            for(int i = 0; i < 9; i++)
            {
                provjera += "[";
                for(int j = 0; j < 9; j++)
                {
                    element = dgvSlagalica.Rows[i].Cells[j].Value.ToString();
                    provjera += (element == String.Empty ? "_," : element + ",");
                    if(element == String.Empty)
                    {
                        praznaPolja = true;
                    }
                }
                provjera = provjera.Remove(provjera.Length - 1);
                provjera += "],";
            }
            provjera = provjera.Remove(provjera.Length - 1);
            provjera += "]";

            if(!praznaPolja)
            {
                igra.provjera(provjera);
            }
            else
            {
                MessageBox.Show("Popunite sva prazna mjesta u slagalici kako biste provjerili rješenje.");
            }
        }

        public void igra_vratiOdgovor(IEnumerable<Rezultat> rezultat)
        {
            bool igraGotova = true;
            foreach(var element in rezultat)
            {
                if(element.broj != String.Empty)
                {
                    igraGotova = false;
                    dgvSlagalica.Rows[Int32.Parse(element.broj) / 9].Cells[Int32.Parse(element.broj) % 9].Style = new DataGridViewCellStyle
                    {
                        ForeColor = Color.Red,
                        SelectionForeColor = Color.Red
                    };
                }
            }
            if(igraGotova)
            {
                MessageBox.Show("Uspješno ste ispunili Sudoku slagalicu.");
            }
        }

        private void dgvSlagalica_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvSlagalica.CurrentCell != null && dgvSlagalica.CurrentCell.Style.ForeColor == Color.Red)
            {
                dgvSlagalica.CurrentCell.Style = new DataGridViewCellStyle
                {
                    ForeColor = Color.Blue,
                    SelectionForeColor = Color.Blue
                };
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            PlEngine.PlCleanup();
            base.OnFormClosing(e);
            if(e.CloseReason == CloseReason.WindowsShutDown) return;
        }
    }
}
