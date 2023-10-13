
namespace MergePDF
{
    partial class MainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.openFileDialogPDF = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogPDF = new System.Windows.Forms.SaveFileDialog();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonMerge = new System.Windows.Forms.Button();
            this.listViewPDFfile = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialogPDF
            // 
            this.openFileDialogPDF.Filter = "PDF (*.pdf)|*.pdf";
            this.openFileDialogPDF.Multiselect = true;
            this.openFileDialogPDF.RestoreDirectory = true;
            this.openFileDialogPDF.Title = "Dodaj pliki PDF";
            this.openFileDialogPDF.ValidateNames = false;
            // 
            // saveFileDialogPDF
            // 
            this.saveFileDialogPDF.DefaultExt = "pdf";
            this.saveFileDialogPDF.Filter = "PDF (*.pdf)|*.pdf";
            this.saveFileDialogPDF.RestoreDirectory = true;
            this.saveFileDialogPDF.Title = "Zapisz plik PDF";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Red;
            this.buttonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Image = global::MergePDF.Properties.Resources.pdf;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(51, 286);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(85, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj PDF";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonMerge
            // 
            this.buttonMerge.BackColor = System.Drawing.Color.Red;
            this.buttonMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMerge.Image = global::MergePDF.Properties.Resources.save;
            this.buttonMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMerge.Location = new System.Drawing.Point(283, 286);
            this.buttonMerge.Name = "buttonMerge";
            this.buttonMerge.Size = new System.Drawing.Size(97, 23);
            this.buttonMerge.TabIndex = 2;
            this.buttonMerge.Text = "Złącz pliki";
            this.buttonMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonMerge.UseVisualStyleBackColor = false;
            this.buttonMerge.Click += new System.EventHandler(this.buttonMerge_Click);
            // 
            // listViewPDFfile
            // 
            this.listViewPDFfile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewPDFfile.HideSelection = false;
            this.listViewPDFfile.Location = new System.Drawing.Point(51, 63);
            this.listViewPDFfile.Name = "listViewPDFfile";
            this.listViewPDFfile.Size = new System.Drawing.Size(583, 217);
            this.listViewPDFfile.TabIndex = 3;
            this.listViewPDFfile.UseCompatibleStateImageBehavior = false;
            this.listViewPDFfile.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lokalizacja pliku";
            this.columnHeader1.Width = 565;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Image = global::MergePDF.Properties.Resources.clear;
            this.buttonClear.Location = new System.Drawing.Point(17, 224);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(28, 28);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Red;
            this.buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Image = global::MergePDF.Properties.Resources.delete;
            this.buttonRemove.Location = new System.Drawing.Point(17, 190);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(28, 28);
            this.buttonRemove.TabIndex = 6;
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.Color.Red;
            this.buttonDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDown.Image = global::MergePDF.Properties.Resources.down;
            this.buttonDown.Location = new System.Drawing.Point(17, 129);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(28, 28);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.Color.Red;
            this.buttonUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUp.Image = global::MergePDF.Properties.Resources.up;
            this.buttonUp.Location = new System.Drawing.Point(17, 95);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(28, 28);
            this.buttonUp.TabIndex = 4;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Image = global::MergePDF.Properties.Resources.exit;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(554, 286);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Zamknij";
            this.buttonExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(654, 315);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.listViewPDFfile);
            this.Controls.Add(this.buttonMerge);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Merge PDF file / Łączenie plików PDF";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPDF;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonMerge;
        private System.Windows.Forms.ListView listViewPDFfile;
        private System.Windows.Forms.OpenFileDialog openFileDialogPDF;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonClear;
    }
}

