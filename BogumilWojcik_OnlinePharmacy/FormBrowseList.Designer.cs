namespace BogumilWojcik_OnlinePharmacy
{
    partial class FormBrowseList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObject = new System.Windows.Forms.ComboBox();
            this.buttonDelate = new System.Windows.Forms.Button();
            this.buttonSum = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(13, 115);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(154, 53);
            this.buttonBrowse.TabIndex = 1;
            this.buttonBrowse.Text = "Przeglądaj obiekty";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.HorizontalScrollbar = true;
            this.listBoxList.Location = new System.Drawing.Point(12, 246);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(350, 329);
            this.listBoxList.TabIndex = 4;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(93, 594);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Następny";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(12, 594);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Poprzedni";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(172, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 125);
            this.pictureBox1.TabIndex = 93;
            this.pictureBox1.TabStop = false;
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelMain.Location = new System.Drawing.Point(85, 9);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(361, 39);
            this.labelMain.TabIndex = 94;
            this.labelMain.Text = "Przeglądanie obiektów";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Location = new System.Drawing.Point(12, 190);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(71, 34);
            this.buttonSaveFile.TabIndex = 95;
            this.buttonSaveFile.Text = "Zapisz";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(92, 190);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(75, 34);
            this.buttonReadFile.TabIndex = 96;
            this.buttonReadFile.Text = "Odczytaj";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Pliki tekstowe|*.txt";
            // 
            // pictureFileDialog
            // 
            this.pictureFileDialog.Title = "Wczytywanie obrazka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Wybierz indeks z listy obiektów, który obiekt chcesz usunąć";
            // 
            // comboBoxObject
            // 
            this.comboBoxObject.FormattingEnabled = true;
            this.comboBoxObject.Location = new System.Drawing.Point(448, 115);
            this.comboBoxObject.Name = "comboBoxObject";
            this.comboBoxObject.Size = new System.Drawing.Size(105, 21);
            this.comboBoxObject.TabIndex = 98;
            this.comboBoxObject.SelectedIndexChanged += new System.EventHandler(this.comboBoxObject_SelectedIndexChanged);
            // 
            // buttonDelate
            // 
            this.buttonDelate.Location = new System.Drawing.Point(478, 151);
            this.buttonDelate.Name = "buttonDelate";
            this.buttonDelate.Size = new System.Drawing.Size(75, 23);
            this.buttonDelate.TabIndex = 99;
            this.buttonDelate.Text = "Usuń";
            this.buttonDelate.UseVisualStyleBackColor = true;
            this.buttonDelate.Click += new System.EventHandler(this.buttonDelate_Click);
            this.buttonDelate.MouseHover += new System.EventHandler(this.buttonDelate_MouseHover);
            // 
            // buttonSum
            // 
            this.buttonSum.Location = new System.Drawing.Point(371, 552);
            this.buttonSum.Name = "buttonSum";
            this.buttonSum.Size = new System.Drawing.Size(75, 23);
            this.buttonSum.TabIndex = 100;
            this.buttonSum.Text = "Policz";
            this.buttonSum.UseVisualStyleBackColor = true;
            this.buttonSum.Click += new System.EventHandler(this.buttonSum_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Location = new System.Drawing.Point(174, 599);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(147, 13);
            this.labelSum.TabIndex = 101;
            this.labelSum.Text = "Suma wszystkich produktów: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Indeks aktualnie oglądanego obiektu:";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(162, 88);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(32, 13);
            this.labelIndex.TabIndex = 103;
            this.labelIndex.Text = "index";
            this.labelIndex.Visible = false;
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(371, 470);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 104;
            this.buttonSort.Text = "Posortuj";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormBrowseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 629);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.buttonSum);
            this.Controls.Add(this.buttonDelate);
            this.Controls.Add(this.comboBoxObject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.listBoxList);
            this.Controls.Add(this.buttonBrowse);
            this.Name = "FormBrowseList";
            this.Text = "FormBrowseList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog pictureFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxObject;
        private System.Windows.Forms.Button buttonDelate;
        private System.Windows.Forms.Button buttonSum;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Button buttonSort;
    }
}