using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace EditorTexto
{
    public partial class frmEditor : Form
    {
        private FontStyle style = FontStyle.Regular;
        private InstalledFontCollection installedFonts = new InstalledFontCollection();
        List<string> historialTexto = new List<string>();
        List<Font> HistorialFuentes = new List<Font>();
        private bool regreso = false;
        OpenFileDialog archivo = new OpenFileDialog();
        FileStream fs;
        string ruta = string.Empty;
        

        public frmEditor()
        {
            InitializeComponent();
            bool pd = pruebasDagosas();
        }
        
        private void frmEditor_Load(object sender, EventArgs e)
        {
            historialTexto.Add(txtTexto.Text);
            HistorialFuentes.Add(txtTexto.Font);
            fuenteToolStripMenuItem.Enabled = cargarFuentes();
        }

        private void lstFuentes_DrawItem(object sender, DrawItemEventArgs e)
        {
            FontFamily family = installedFonts.Families[e.Index];
            FontStyle style = FontStyle.Regular;
            if (!family.IsStyleAvailable(style))
                style = FontStyle.Bold;
            if (!family.IsStyleAvailable(style))
                style = FontStyle.Italic;
            Font fnt = new Font(family, 10, style);
            Brush brush;
            if (e.State == DrawItemState.Selected)
                brush = new SolidBrush(Color.White);
            else
                brush = new SolidBrush(lstFuentes.ForeColor);
            e.DrawBackground();
            e.Graphics.DrawString(family.GetName(0), fnt, brush, e.Bounds.Location);
        }

        private void lstFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstFuentes.SelectedItem != null)
            {
                txtFuente.Text = lstFuentes.SelectedItem.ToString();
                lblEjemplo.Font = txtFuente.Font = new Font(lstFuentes.SelectedItem.ToString(), 16);
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlFuentes.Visible = true;
        }

        private void btnCerrarFuentes_Click(object sender, EventArgs e)
        {
            pnlFuentes.Visible = false;
        }

        private void lstEstilo_DrawItem(object sender, DrawItemEventArgs e)
        {
            Font fnt;
            switch (e.Index)
            {
                case 0:
                    fnt = new Font(e.Font.FontFamily, 10, FontStyle.Regular);
                    e.DrawBackground();
                    e.Graphics.DrawString("Normal",
                                          fnt, new SolidBrush(Color.Black), e.Bounds.Location);
                    break;
                case 1:
                    fnt = new Font(e.Font.FontFamily, 10, FontStyle.Italic);
                    e.DrawBackground();
                    e.Graphics.DrawString("Oblicua",
                                          fnt, new SolidBrush(Color.Black), e.Bounds.Location);
                    break;
                case 2:
                    fnt = new Font(e.Font.FontFamily, 10, FontStyle.Bold);
                    e.DrawBackground();
                    e.Graphics.DrawString("Negrita",
                                          fnt, new SolidBrush(Color.Black), e.Bounds.Location);
                    break;
                case 3:
                    fnt = new Font(e.Font.FontFamily, 10, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))));
                    e.DrawBackground();
                    e.Graphics.DrawString("Oblicua Negrita",
                                          fnt, new SolidBrush(Color.Black), e.Bounds.Location);
                    break;
                default:
                    break;
            }
        }

        private void lstEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (lstEstilo.SelectedIndex)
            {
                case 0:
                    style = FontStyle.Regular;
                    txtEstilo.Font = lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Regular);
                    break;
                case 1:
                    style = FontStyle.Italic;
                    txtEstilo.Font = lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Italic);
                    break;
                case 2:
                    style = FontStyle.Bold;
                    txtEstilo.Font = lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, FontStyle.Bold);
                    break;
                case 3:
                    style = ((FontStyle)((FontStyle.Bold | FontStyle.Italic)));
                    txtEstilo.Font = lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, lblEjemplo.Font.Size, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))));
                    break;
                default:
                    break;
            }
            if (lstEstilo.SelectedItem != null)
                txtEstilo.Text = lstEstilo.SelectedItem.ToString();
        }

        private void lstTamaño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTamaño.SelectedItem != null)
            {
                lblEjemplo.Font = new Font(lblEjemplo.Font.FontFamily, int.Parse(lstTamaño.SelectedItem.ToString()), lblEjemplo.Font.Style);
                txtTamaño.Text = lstTamaño.SelectedItem.ToString();
            }
        }

        private void txtFuente_TextChanged(object sender, EventArgs e)
        {
            if (txtFuente.TextLength != 0)
                for (int i = 0; i < lstFuentes.Items.Count; i++)
                    if (lstFuentes.Items[i].ToString().Contains(txtFuente.Text))
                    {
                        int lenght = txtFuente.TextLength;
                        lstFuentes.SelectedIndex = i;
                        txtFuente.SelectionStart = lenght;
                        txtFuente.SelectionLength = txtFuente.TextLength - lenght;
                        break;
                    }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            txtTexto.Font = lblEjemplo.Font;
            pnlFuentes.Visible = false;
            txtFuente.Text = txtEstilo.Text = txtTamaño.Text = string.Empty;
            lstEstilo.ClearSelected();
            lstFuentes.ClearSelected();
            lstTamaño.ClearSelected();
            historialTexto.Add(txtTexto.Text);
            HistorialFuentes.Add(txtTexto.Font);
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            if (!regreso)
            {
                historialTexto.Add(txtTexto.Text);
                HistorialFuentes.Add(txtTexto.Font);
                regresarToolStripMenuItem.Enabled = true;
            }
            regreso = false;
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regresarToolStripMenuItem.Enabled = regresar();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Enabled = abrirArchivo();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(ruta, txtTexto.Text);
            txtTexto.Text = string.Empty;
            txtTexto.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = string.Empty;
            if (buscar() == 0)
            {
                lblResultado.Text = "Sin Resultados";
                txtReemplazo.Enabled = btnReemplazar.Enabled = false;
            }
            else
                txtReemplazo.Enabled = btnReemplazar.Enabled = true;
        }

        private void btnCerrarBusqueda_Click(object sender, EventArgs e)
        {
            txtReemplazo.Enabled = btnReemplazar.Enabled = pnlBusqueda.Visible = false;
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlBusqueda.Visible = true;
        }

        private void btnReemplazar_Click(object sender, EventArgs e)
        {
            txtTexto.Text = txtTexto.Text.Replace(txtBuscar.Text, txtReemplazo.Text);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!nuevoArchivo())
            {
                MessageBox.Show("Error al crear archivo");
                txtTexto.Enabled = false;
            }
            else
                txtTexto.Enabled = true;

        }

        public int buscar()
        {
            int cont = 0;
            txtTexto.Select(0, txtTexto.TextLength);
            txtTexto.SelectionColor = Color.Black;
            int indexToText = 0;
            for (int x = 0; x < txtTexto.Text.Length; x++)
            {
                indexToText = txtTexto.Find(txtBuscar.Text, x, txtTexto.Text.Length, RichTextBoxFinds.MatchCase);
                if (indexToText != -1)
                {
                    txtTexto.Select(indexToText, txtBuscar.TextLength);
                    txtTexto.SelectionColor = Color.Red;
                    x += txtBuscar.Text.Length;
                    cont++;
                }
            }
            return cont;
        }

        public bool abrirArchivo()
        {
            try
            {
                archivo.Filter = "Texto Text|*.txt";
                archivo.Title = "Abrir archivo";
                archivo.ShowDialog();
                if (archivo.FileName != "")
                {
                    fs = (FileStream)archivo.OpenFile();
                    txtTexto.Text = File.ReadAllText(fs.Name);
                    ruta = fs.Name;
                    fs.Close();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar abrir en alchivo, error: " + ex.ToString());
                return false;
            }
        }

        public bool regresar()
        {
            if (historialTexto.Count > 1)
            {
                regreso = true;
                txtTexto.Text = historialTexto[historialTexto.Count - 2];
                historialTexto.RemoveAt(historialTexto.Count - 1);
                txtTexto.Font = HistorialFuentes[HistorialFuentes.Count - 2];
                HistorialFuentes.RemoveAt(HistorialFuentes.Count - 1);
                return true;
            }
            else
            {
                if (historialTexto.Count == 1)
                {
                    txtTexto.Text = historialTexto[0];
                    txtTexto.Font = HistorialFuentes[0];
                    regreso = true;
                    historialTexto.Clear();
                    HistorialFuentes.Clear();
                    historialTexto.Add(txtTexto.Text);
                    HistorialFuentes.Add(txtTexto.Font);
                }
                return false;
            }
        }

        public bool cargarFuentes()
        {
            lstFuentes.Items.Clear();
            foreach (FontFamily fuente in installedFonts.Families)
                lstFuentes.Items.Add(fuente.Name);
            if (lstFuentes.Items.Count > 0)
                return true;
            return false;
        }

        public bool nuevoArchivo()
        {
            FolderBrowserDialog nuevo = new FolderBrowserDialog();
            if (nuevo.ShowDialog() == DialogResult.OK)
            {
                ruta = nuevo.SelectedPath + "\\nuevoArchivo.txt";
                using (StreamWriter a = File.AppendText(ruta))
                {
                    a.Close();
                    return true;
                }
            }
            return false;
        }

        public Boolean pruebasDagosas()
        {
            //txtTexto.Text = "hola hola";
            //txtBuscar.Text = "hola";
            return true;
        }
    }
}
