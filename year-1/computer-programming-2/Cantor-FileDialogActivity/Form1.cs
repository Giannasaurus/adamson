using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace Cantor_FileDialogActivity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string path = "";

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please open or save a file first."); // log: open/save file first
                return;
            }

            try
            {
                File.WriteAllText(path, textBox.Text);
                MessageBox.Show("Wrote successfully to: " + path); // log: text save success
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error writing to file: " + ex.Message); // log: error write to file
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text and CSV files|*.txt;*.csv|PDF files|*.pdf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = ofd.FileName;
                    string extension = System.IO.Path.GetExtension(path).ToLower();

                    if (extension == ".txt" || extension == ".csv")
                    {
                        textBox.Text = File.ReadAllText(path); // display text
                        MessageBox.Show("File opened successfully.");
                    }
                    else if (extension == ".pdf")
                    {
                    }
                    else
                    {
                        MessageBox.Show("Unsupported file type."); // log: unsupported file type
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message); // log: error opening file
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text file|*.txt|PDF file|*.pdf|CSV file|*.csv";
            sfd.FileName = "text-file";
            sfd.Title = "Save a file";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = sfd.FileName;

                    File.WriteAllText(path, textBox.Text);
                    MessageBox.Show("File saved successfully to: " + path); // log: file save success
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message); // log: error save file
                }
            }
        }
    }
}
