namespace BogumilWojcik_OnlinePharmacy
{
    partial class FormMain
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
            this.buttonAddAntibiotic = new System.Windows.Forms.Button();
            this.buttonAddSupplement = new System.Windows.Forms.Button();
            this.buttonBrowseList = new System.Windows.Forms.Button();
            this.buttonFunctionOperator = new System.Windows.Forms.Button();
            this.labelMain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddAntibiotic
            // 
            this.buttonAddAntibiotic.Location = new System.Drawing.Point(25, 103);
            this.buttonAddAntibiotic.Name = "buttonAddAntibiotic";
            this.buttonAddAntibiotic.Size = new System.Drawing.Size(172, 98);
            this.buttonAddAntibiotic.TabIndex = 1;
            this.buttonAddAntibiotic.Text = "Dodaj Antybiotyk";
            this.buttonAddAntibiotic.UseVisualStyleBackColor = true;
            this.buttonAddAntibiotic.Click += new System.EventHandler(this.buttonAddAntibiotic_Click);
            // 
            // buttonAddSupplement
            // 
            this.buttonAddSupplement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAddSupplement.Location = new System.Drawing.Point(278, 103);
            this.buttonAddSupplement.Name = "buttonAddSupplement";
            this.buttonAddSupplement.Size = new System.Drawing.Size(172, 98);
            this.buttonAddSupplement.TabIndex = 2;
            this.buttonAddSupplement.Text = "Dodaj Suplement";
            this.buttonAddSupplement.UseVisualStyleBackColor = true;
            this.buttonAddSupplement.Click += new System.EventHandler(this.buttonAddSupplement_Click);
            // 
            // buttonBrowseList
            // 
            this.buttonBrowseList.Location = new System.Drawing.Point(25, 225);
            this.buttonBrowseList.Name = "buttonBrowseList";
            this.buttonBrowseList.Size = new System.Drawing.Size(172, 98);
            this.buttonBrowseList.TabIndex = 3;
            this.buttonBrowseList.Text = "Przeglądaj obiekty";
            this.buttonBrowseList.UseVisualStyleBackColor = true;
            this.buttonBrowseList.Click += new System.EventHandler(this.buttonBrowseList_Click);
            // 
            // buttonFunctionOperator
            // 
            this.buttonFunctionOperator.Location = new System.Drawing.Point(278, 225);
            this.buttonFunctionOperator.Name = "buttonFunctionOperator";
            this.buttonFunctionOperator.Size = new System.Drawing.Size(172, 98);
            this.buttonFunctionOperator.TabIndex = 4;
            this.buttonFunctionOperator.Text = "Funkcje operatorowe";
            this.buttonFunctionOperator.UseVisualStyleBackColor = true;
            this.buttonFunctionOperator.Click += new System.EventHandler(this.buttonFunctionOperator_Click);
            // 
            // labelMain
            // 
            this.labelMain.AutoSize = true;
            this.labelMain.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMain.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelMain.Location = new System.Drawing.Point(101, 27);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(287, 36);
            this.labelMain.TabIndex = 5;
            this.labelMain.Text = "Apteka Internetowa";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 362);
            this.Controls.Add(this.labelMain);
            this.Controls.Add(this.buttonFunctionOperator);
            this.Controls.Add(this.buttonBrowseList);
            this.Controls.Add(this.buttonAddSupplement);
            this.Controls.Add(this.buttonAddAntibiotic);
            this.Name = "FormMain";
            this.Text = "Apteka Internetowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAntibiotic;
        private System.Windows.Forms.Button buttonAddSupplement;
        private System.Windows.Forms.Button buttonBrowseList;
        private System.Windows.Forms.Button buttonFunctionOperator;
        private System.Windows.Forms.Label labelMain;
    }
}

