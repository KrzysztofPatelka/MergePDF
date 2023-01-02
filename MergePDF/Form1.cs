using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PdfSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using MetroFramework.Forms;
using MetroFramework.Animation;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Native;
using MetroFramework.Properties;

namespace MergePDF
{
    public partial class Form1 : MetroForm
    {
        public static void MergePDFs(string targetPath, string[] pdfs)
        {
            using (PdfDocument targetDoc = new PdfDocument())
            {
                foreach (string pdf in pdfs)
                {
                    using (PdfDocument pdfDoc = PdfReader.Open(pdf, PdfDocumentOpenMode.Import))
                    {
                        for (int i = 0; i < pdfDoc.PageCount; i++)
                        {
                            targetDoc.AddPage(pdfDoc.Pages[i]);
                        }
                    }
                }
                targetDoc.Save(targetPath);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewPDFfile.Items.Clear();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        ListViewItem item = new ListViewItem(file);
                        listViewPDFfile.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy usunąć z listy wszystkie pliki PDF?", "Zapytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listViewPDFfile.Items.Clear();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectItem in listViewPDFfile.SelectedItems)
            {
                listViewPDFfile.Items.Remove(selectItem);
            }
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewPDFfile.SelectedItems)
            {
                if (lvi.Index > 0)
                {
                    int index = lvi.Index - 1;
                    listViewPDFfile.Items.RemoveAt(lvi.Index);
                    listViewPDFfile.Items.Insert(index, lvi);
                }
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listViewPDFfile.SelectedItems)
            {
                if (lvi.Index < listViewPDFfile.Items.Count-1)
                {
                    int index = lvi.Index + 1;
                    listViewPDFfile.Items.RemoveAt(lvi.Index);
                    listViewPDFfile.Items.Insert(index, lvi);
                }
            }
        }

        private void buttonMerge_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewPDFfile.Items.Count < 2)
                {
                    MessageBox.Show("Należy wskazać co najmniej dwa plik do połączenia.", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string[] pdfFiles = new string[listViewPDFfile.Items.Count];
                        for (int i = 0; i < listViewPDFfile.Items.Count; i++)
                        {
                            pdfFiles[i] = listViewPDFfile.Items[i].SubItems[0].Text;
                        }
                        MergePDFs(saveFileDialog1.FileName,pdfFiles);
                        listViewPDFfile.Items.Clear();
                        MessageBox.Show("Plik został zapisany w lokalizacji: " + saveFileDialog1.FileName, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        /*
                        foreach (string file in pdfFiles)
                        {
                            MessageBox.Show(file);
                        }
                        MessageBox.Show(pdfFiles.Count().ToString());
                        MessageBox.Show(saveFileDialog1.FileName);
                        */
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd: " + ex, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
