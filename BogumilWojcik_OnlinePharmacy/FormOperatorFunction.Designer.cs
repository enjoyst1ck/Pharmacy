namespace BogumilWojcik_OnlinePharmacy
{
    partial class FormOperatorFunction
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
            this.labelResults1 = new System.Windows.Forms.Label();
            this.labelResults2 = new System.Windows.Forms.Label();
            this.comboBoxObject1 = new System.Windows.Forms.ComboBox();
            this.labelMain = new System.Windows.Forms.Label();
            this.comboBoxObject2 = new System.Windows.Forms.ComboBox();
            this.labelResults3 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCompare2 = new System.Windows.Forms.Button();
            this.buttonCompare1 = new System.Windows.Forms.Button();
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.labelHelp2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelResults1
            // 
            this.labelResults1.AutoSize = true;
            this.labelResults1.Location = new System.Drawing.Point(207, 280);
            this.labelResults1.Name = "labelResults1";
            this.labelResults1.Size = new System.Drawing.Size(162, 13);
            this.labelResults1.TabIndex = 9;
            this.labelResults1.Text = "Wynik przeciążenia operatora ==";
            // 
            // labelResults2
            // 
            this.labelResults2.AutoSize = true;
            this.labelResults2.Location = new System.Drawing.Point(207, 338);
            this.labelResults2.Name = "labelResults2";
            this.labelResults2.Size = new System.Drawing.Size(159, 13);
            this.labelResults2.TabIndex = 10;
            this.labelResults2.Text = "Wynik przeciążenia operatora !=";
            // 
            // comboBoxObject1
            // 
            this.comboBoxObject1.FormattingEnabled = true;
            this.comboBoxObject1.Location = new System.Drawing.Point(44, 158);
            this.comboBoxObject1.Name = "comboBoxObject1";
            this.comboBoxObject1.Size = new System.Drawing.Size(104, 21);
            this.comboBoxObject1.TabIndex = 1;
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMain.Location = new System.Drawing.Point(40, 64);
            this.labelMain.Name = "labelMain";
            this.labelMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelMain.Size = new System.Drawing.Size(324, 92);
            this.labelMain.TabIndex = 6;
            this.labelMain.Text = "Wybierz dwa obiekty z listy Suplementów, których wagi netto(pudełek) będziemy uży" +
    "wać:";
            // 
            // comboBoxObject2
            // 
            this.comboBoxObject2.FormattingEnabled = true;
            this.comboBoxObject2.Location = new System.Drawing.Point(181, 158);
            this.comboBoxObject2.Name = "comboBoxObject2";
            this.comboBoxObject2.Size = new System.Drawing.Size(125, 21);
            this.comboBoxObject2.TabIndex = 2;
            // 
            // labelResults3
            // 
            this.labelResults3.AutoSize = true;
            this.labelResults3.Location = new System.Drawing.Point(207, 405);
            this.labelResults3.Name = "labelResults3";
            this.labelResults3.Size = new System.Drawing.Size(156, 13);
            this.labelResults3.TabIndex = 11;
            this.labelResults3.Text = "Wynik przeciążenia operatora +";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(44, 392);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(144, 39);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Dodaj wage netto pudełek obu obiektów";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCompare2
            // 
            this.buttonCompare2.Location = new System.Drawing.Point(44, 325);
            this.buttonCompare2.Name = "buttonCompare2";
            this.buttonCompare2.Size = new System.Drawing.Size(144, 39);
            this.buttonCompare2.TabIndex = 4;
            this.buttonCompare2.Text = "Porównaj - czy różne?";
            this.buttonCompare2.UseVisualStyleBackColor = true;
            this.buttonCompare2.Click += new System.EventHandler(this.buttonCompare2_Click);
            // 
            // buttonCompare1
            // 
            this.buttonCompare1.Location = new System.Drawing.Point(44, 267);
            this.buttonCompare1.Name = "buttonCompare1";
            this.buttonCompare1.Size = new System.Drawing.Size(144, 39);
            this.buttonCompare1.TabIndex = 3;
            this.buttonCompare1.Text = "Porównaj - czy takie samo?";
            this.buttonCompare1.UseVisualStyleBackColor = true;
            this.buttonCompare1.Click += new System.EventHandler(this.buttonCompare1_Click);
            // 
            // labelHelp1
            // 
            this.labelHelp1.AutoSize = true;
            this.labelHelp1.Location = new System.Drawing.Point(45, 194);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(225, 13);
            this.labelHelp1.TabIndex = 7;
            this.labelHelp1.Text = "Waga zawartości pudełka wybranego obiektu";
            // 
            // labelHelp2
            // 
            this.labelHelp2.AutoSize = true;
            this.labelHelp2.Location = new System.Drawing.Point(45, 222);
            this.labelHelp2.Name = "labelHelp2";
            this.labelHelp2.Size = new System.Drawing.Size(225, 13);
            this.labelHelp2.TabIndex = 8;
            this.labelHelp2.Text = "Waga zawartości pudełka wybranego obiektu";
            // 
            // FormOperatorFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.labelHelp2);
            this.Controls.Add(this.labelHelp1);
            this.Controls.Add(this.buttonCompare1);
            this.Controls.Add(this.buttonCompare2);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelResults3);
            this.Controls.Add(this.comboBoxObject2);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.comboBoxObject1);
            this.Controls.Add(this.labelResults2);
            this.Controls.Add(this.labelResults1);
            this.Name = "FormOperatorFunction";
            this.Text = "FormOperatorFunction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResults1;
        private System.Windows.Forms.Label labelResults2;
        private System.Windows.Forms.ComboBox comboBoxObject1;
        private System.Windows.Forms.Label labelMain;
        private System.Windows.Forms.ComboBox comboBoxObject2;
        private System.Windows.Forms.Label labelResults3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCompare2;
        private System.Windows.Forms.Button buttonCompare1;
        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.Label labelHelp2;
    }
}