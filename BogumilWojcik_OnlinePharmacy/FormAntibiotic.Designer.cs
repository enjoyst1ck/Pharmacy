namespace BogumilWojcik_OnlinePharmacy
{
    partial class FormAntibiotic
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
            this.textBoxLicense = new System.Windows.Forms.TextBox();
            this.textBoxChemicalStructure = new System.Windows.Forms.TextBox();
            this.buttonFill = new System.Windows.Forms.Button();
            this.buttonAddAntibiotic = new System.Windows.Forms.Button();
            this.listBoxAntibiotic = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelNetPrice = new System.Windows.Forms.Label();
            this.labelPrescriptionNumber = new System.Windows.Forms.Label();
            this.labelChemicalStructure = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.textBoxPurpose = new System.Windows.Forms.TextBox();
            this.labelPurpose = new System.Windows.Forms.Label();
            this.labelUse = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.labelLicense = new System.Windows.Forms.Label();
            this.labelComponent = new System.Windows.Forms.Label();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.labelAdverseEffects = new System.Windows.Forms.Label();
            this.textBoxAdverseEffects = new System.Windows.Forms.TextBox();
            this.labelAdditionalInformation = new System.Windows.Forms.Label();
            this.textBoxAdditionalInformation = new System.Windows.Forms.TextBox();
            this.dateTimePickerExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.labelExpirationDate = new System.Windows.Forms.Label();
            this.labelPhoto = new System.Windows.Forms.Label();
            this.pictureBoxPhoto1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhoto2 = new System.Windows.Forms.PictureBox();
            this.buttonReadPhoto = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.numericUpDownNetPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.checkBoxPrescription = new System.Windows.Forms.CheckBox();
            this.labelNumberOfDoses = new System.Windows.Forms.Label();
            this.numericUpDownNumberOfDoses = new System.Windows.Forms.NumericUpDown();
            this.labelPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownContent = new System.Windows.Forms.NumericUpDown();
            this.labelContent = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNetPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfDoses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContent)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxLicense
            // 
            this.textBoxLicense.Location = new System.Drawing.Point(106, 569);
            this.textBoxLicense.Name = "textBoxLicense";
            this.textBoxLicense.Size = new System.Drawing.Size(121, 20);
            this.textBoxLicense.TabIndex = 13;
            // 
            // textBoxChemicalStructure
            // 
            this.textBoxChemicalStructure.Location = new System.Drawing.Point(384, 465);
            this.textBoxChemicalStructure.Name = "textBoxChemicalStructure";
            this.textBoxChemicalStructure.Size = new System.Drawing.Size(141, 20);
            this.textBoxChemicalStructure.TabIndex = 19;
            // 
            // buttonFill
            // 
            this.buttonFill.Location = new System.Drawing.Point(551, 59);
            this.buttonFill.Name = "buttonFill";
            this.buttonFill.Size = new System.Drawing.Size(157, 55);
            this.buttonFill.TabIndex = 21;
            this.buttonFill.Text = "Uzupełnij pola danymi";
            this.buttonFill.UseVisualStyleBackColor = true;
            this.buttonFill.Click += new System.EventHandler(this.buttonFill_Click);
            // 
            // buttonAddAntibiotic
            // 
            this.buttonAddAntibiotic.Location = new System.Drawing.Point(551, 150);
            this.buttonAddAntibiotic.Name = "buttonAddAntibiotic";
            this.buttonAddAntibiotic.Size = new System.Drawing.Size(157, 34);
            this.buttonAddAntibiotic.TabIndex = 22;
            this.buttonAddAntibiotic.Text = "Dodaj antybiotyk";
            this.buttonAddAntibiotic.UseVisualStyleBackColor = true;
            this.buttonAddAntibiotic.Click += new System.EventHandler(this.buttonAddAntibiotic_Click);
            // 
            // listBoxAntibiotic
            // 
            this.listBoxAntibiotic.FormatString = "d";
            this.listBoxAntibiotic.FormattingEnabled = true;
            this.listBoxAntibiotic.HorizontalScrollbar = true;
            this.listBoxAntibiotic.Location = new System.Drawing.Point(551, 204);
            this.listBoxAntibiotic.Name = "listBoxAntibiotic";
            this.listBoxAntibiotic.Size = new System.Drawing.Size(353, 420);
            this.listBoxAntibiotic.TabIndex = 50;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(106, 72);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(123, 20);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            this.textBoxName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxName_MouseDoubleClick);
            this.textBoxName.MouseHover += new System.EventHandler(this.textBoxName_MouseHover);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(10, 73);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Nazwa:";
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(10, 113);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(31, 13);
            this.labelVat.TabIndex = 8;
            this.labelVat.Text = "VAT:";
            // 
            // labelNetPrice
            // 
            this.labelNetPrice.AutoSize = true;
            this.labelNetPrice.Location = new System.Drawing.Point(12, 149);
            this.labelNetPrice.Name = "labelNetPrice";
            this.labelNetPrice.Size = new System.Drawing.Size(59, 13);
            this.labelNetPrice.TabIndex = 9;
            this.labelNetPrice.Text = "Cena netto";
            // 
            // labelPrescriptionNumber
            // 
            this.labelPrescriptionNumber.AutoSize = true;
            this.labelPrescriptionNumber.Location = new System.Drawing.Point(268, 75);
            this.labelPrescriptionNumber.Name = "labelPrescriptionNumber";
            this.labelPrescriptionNumber.Size = new System.Drawing.Size(63, 13);
            this.labelPrescriptionNumber.TabIndex = 12;
            this.labelPrescriptionNumber.Text = "Na recepte:";
            // 
            // labelChemicalStructure
            // 
            this.labelChemicalStructure.AutoSize = true;
            this.labelChemicalStructure.Location = new System.Drawing.Point(263, 466);
            this.labelChemicalStructure.Name = "labelChemicalStructure";
            this.labelChemicalStructure.Size = new System.Drawing.Size(107, 13);
            this.labelChemicalStructure.TabIndex = 13;
            this.labelChemicalStructure.Text = "Struktura chemiczna:";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(12, 223);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(80, 13);
            this.labelAmount.TabIndex = 14;
            this.labelAmount.Text = "Ilość produktu: ";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 263);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(31, 13);
            this.labelDescription.TabIndex = 16;
            this.labelDescription.Text = "Opis:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(106, 260);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(125, 65);
            this.textBoxDescription.TabIndex = 6;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 347);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(28, 13);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Typ:";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Location = new System.Drawing.Point(12, 388);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(43, 13);
            this.labelForm.TabIndex = 20;
            this.labelForm.Text = "Postać:";
            // 
            // textBoxPurpose
            // 
            this.textBoxPurpose.Location = new System.Drawing.Point(106, 426);
            this.textBoxPurpose.Name = "textBoxPurpose";
            this.textBoxPurpose.Size = new System.Drawing.Size(125, 20);
            this.textBoxPurpose.TabIndex = 9;
            // 
            // labelPurpose
            // 
            this.labelPurpose.AutoSize = true;
            this.labelPurpose.Location = new System.Drawing.Point(12, 429);
            this.labelPurpose.Name = "labelPurpose";
            this.labelPurpose.Size = new System.Drawing.Size(79, 13);
            this.labelPurpose.TabIndex = 23;
            this.labelPurpose.Text = "Przeznaczenie:";
            // 
            // labelUse
            // 
            this.labelUse.AutoSize = true;
            this.labelUse.Location = new System.Drawing.Point(13, 461);
            this.labelUse.Name = "labelUse";
            this.labelUse.Size = new System.Drawing.Size(53, 13);
            this.labelUse.TabIndex = 24;
            this.labelUse.Text = "Aplikacja:";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(13, 535);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(59, 13);
            this.labelProducer.TabIndex = 28;
            this.labelProducer.Text = "Producent:";
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(106, 532);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(121, 20);
            this.textBoxProducer.TabIndex = 12;
            // 
            // labelLicense
            // 
            this.labelLicense.AutoSize = true;
            this.labelLicense.Location = new System.Drawing.Point(13, 572);
            this.labelLicense.Name = "labelLicense";
            this.labelLicense.Size = new System.Drawing.Size(80, 13);
            this.labelLicense.TabIndex = 30;
            this.labelLicense.Text = "Nr pozwolenia: ";
            // 
            // labelComponent
            // 
            this.labelComponent.AutoSize = true;
            this.labelComponent.Location = new System.Drawing.Point(268, 149);
            this.labelComponent.Name = "labelComponent";
            this.labelComponent.Size = new System.Drawing.Size(78, 13);
            this.labelComponent.TabIndex = 34;
            this.labelComponent.Text = "Składniki leku:";
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(384, 144);
            this.textBoxComponent.Multiline = true;
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(141, 77);
            this.textBoxComponent.TabIndex = 16;
            // 
            // labelAdverseEffects
            // 
            this.labelAdverseEffects.AutoSize = true;
            this.labelAdverseEffects.Location = new System.Drawing.Point(268, 235);
            this.labelAdverseEffects.Name = "labelAdverseEffects";
            this.labelAdverseEffects.Size = new System.Drawing.Size(84, 13);
            this.labelAdverseEffects.TabIndex = 36;
            this.labelAdverseEffects.Text = "Skutki uboczne:";
            // 
            // textBoxAdverseEffects
            // 
            this.textBoxAdverseEffects.Location = new System.Drawing.Point(384, 232);
            this.textBoxAdverseEffects.Multiline = true;
            this.textBoxAdverseEffects.Name = "textBoxAdverseEffects";
            this.textBoxAdverseEffects.Size = new System.Drawing.Size(141, 93);
            this.textBoxAdverseEffects.TabIndex = 17;
            // 
            // labelAdditionalInformation
            // 
            this.labelAdditionalInformation.AutoSize = true;
            this.labelAdditionalInformation.Location = new System.Drawing.Point(263, 346);
            this.labelAdditionalInformation.Name = "labelAdditionalInformation";
            this.labelAdditionalInformation.Size = new System.Drawing.Size(115, 13);
            this.labelAdditionalInformation.TabIndex = 38;
            this.labelAdditionalInformation.Text = "Informacje dodatkowe:";
            // 
            // textBoxAdditionalInformation
            // 
            this.textBoxAdditionalInformation.Location = new System.Drawing.Point(384, 343);
            this.textBoxAdditionalInformation.Multiline = true;
            this.textBoxAdditionalInformation.Name = "textBoxAdditionalInformation";
            this.textBoxAdditionalInformation.Size = new System.Drawing.Size(141, 103);
            this.textBoxAdditionalInformation.TabIndex = 18;
            // 
            // dateTimePickerExpirationDate
            // 
            this.dateTimePickerExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerExpirationDate.Location = new System.Drawing.Point(106, 185);
            this.dateTimePickerExpirationDate.Name = "dateTimePickerExpirationDate";
            this.dateTimePickerExpirationDate.Size = new System.Drawing.Size(125, 20);
            this.dateTimePickerExpirationDate.TabIndex = 4;
            // 
            // labelExpirationDate
            // 
            this.labelExpirationDate.AutoSize = true;
            this.labelExpirationDate.Location = new System.Drawing.Point(12, 185);
            this.labelExpirationDate.Name = "labelExpirationDate";
            this.labelExpirationDate.Size = new System.Drawing.Size(89, 13);
            this.labelExpirationDate.TabIndex = 41;
            this.labelExpirationDate.Text = "Termin ważności:";
            // 
            // labelPhoto
            // 
            this.labelPhoto.AutoSize = true;
            this.labelPhoto.Location = new System.Drawing.Point(268, 517);
            this.labelPhoto.Name = "labelPhoto";
            this.labelPhoto.Size = new System.Drawing.Size(45, 13);
            this.labelPhoto.TabIndex = 42;
            this.labelPhoto.Text = "Zdjecie:";
            // 
            // pictureBoxPhoto1
            // 
            this.pictureBoxPhoto1.Location = new System.Drawing.Point(352, 499);
            this.pictureBoxPhoto1.Name = "pictureBoxPhoto1";
            this.pictureBoxPhoto1.Size = new System.Drawing.Size(190, 125);
            this.pictureBoxPhoto1.TabIndex = 43;
            this.pictureBoxPhoto1.TabStop = false;
            // 
            // pictureBoxPhoto2
            // 
            this.pictureBoxPhoto2.Location = new System.Drawing.Point(714, 59);
            this.pictureBoxPhoto2.Name = "pictureBoxPhoto2";
            this.pictureBoxPhoto2.Size = new System.Drawing.Size(190, 125);
            this.pictureBoxPhoto2.TabIndex = 44;
            this.pictureBoxPhoto2.TabStop = false;
            // 
            // buttonReadPhoto
            // 
            this.buttonReadPhoto.Location = new System.Drawing.Point(249, 569);
            this.buttonReadPhoto.Name = "buttonReadPhoto";
            this.buttonReadPhoto.Size = new System.Drawing.Size(97, 43);
            this.buttonReadPhoto.TabIndex = 20;
            this.buttonReadPhoto.Text = "Wybierz zdjęcie";
            this.buttonReadPhoto.UseVisualStyleBackColor = true;
            this.buttonReadPhoto.Click += new System.EventHandler(this.buttonReadPhoto_Click);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Antybiotyk",
            "Suplement"});
            this.comboBoxType.Location = new System.Drawing.Point(106, 346);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(125, 21);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.Text = "Antybiotyk";
            // 
            // numericUpDownNetPrice
            // 
            this.numericUpDownNetPrice.DecimalPlaces = 2;
            this.numericUpDownNetPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownNetPrice.Location = new System.Drawing.Point(106, 145);
            this.numericUpDownNetPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownNetPrice.Name = "numericUpDownNetPrice";
            this.numericUpDownNetPrice.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownNetPrice.TabIndex = 3;
            this.numericUpDownNetPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownNetPrice.Leave += new System.EventHandler(this.numericUpDownNetPrice_Leave);
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(106, 223);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(125, 20);
            this.numericUpDownAmount.TabIndex = 5;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "Tabletka",
            "Krople",
            "Syrop",
            "Żel ",
            "Saszetki",
            "Pastylka"});
            this.comboBoxForm.Location = new System.Drawing.Point(106, 387);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(125, 21);
            this.comboBoxForm.TabIndex = 8;
            this.comboBoxForm.Text = "Tabletka";
            // 
            // checkBoxPrescription
            // 
            this.checkBoxPrescription.AutoSize = true;
            this.checkBoxPrescription.Location = new System.Drawing.Point(384, 75);
            this.checkBoxPrescription.Name = "checkBoxPrescription";
            this.checkBoxPrescription.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPrescription.TabIndex = 14;
            this.checkBoxPrescription.UseVisualStyleBackColor = true;
            // 
            // labelNumberOfDoses
            // 
            this.labelNumberOfDoses.AutoSize = true;
            this.labelNumberOfDoses.Location = new System.Drawing.Point(268, 112);
            this.labelNumberOfDoses.Name = "labelNumberOfDoses";
            this.labelNumberOfDoses.Size = new System.Drawing.Size(110, 13);
            this.labelNumberOfDoses.TabIndex = 52;
            this.labelNumberOfDoses.Text = "Ilosc dawek na dzien:";
            // 
            // numericUpDownNumberOfDoses
            // 
            this.numericUpDownNumberOfDoses.Location = new System.Drawing.Point(384, 109);
            this.numericUpDownNumberOfDoses.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownNumberOfDoses.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumberOfDoses.Name = "numericUpDownNumberOfDoses";
            this.numericUpDownNumberOfDoses.Size = new System.Drawing.Size(141, 20);
            this.numericUpDownNumberOfDoses.TabIndex = 15;
            this.numericUpDownNumberOfDoses.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.labelPercent.Location = new System.Drawing.Point(208, 109);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(21, 17);
            this.labelPercent.TabIndex = 54;
            this.labelPercent.Text = "%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(213, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "zł";
            // 
            // comboBoxUse
            // 
            this.comboBoxUse.FormattingEnabled = true;
            this.comboBoxUse.Items.AddRange(new object[] {
            "Doustnie",
            "Podjęzykowo",
            "Domięśniowo",
            "Dożylnie"});
            this.comboBoxUse.Location = new System.Drawing.Point(106, 458);
            this.comboBoxUse.Name = "comboBoxUse";
            this.comboBoxUse.Size = new System.Drawing.Size(125, 21);
            this.comboBoxUse.TabIndex = 10;
            this.comboBoxUse.Text = "Doustnie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(66, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 31);
            this.label2.TabIndex = 57;
            this.label2.Text = "Dane Antybiotyku";
            // 
            // numericUpDownContent
            // 
            this.numericUpDownContent.Location = new System.Drawing.Point(144, 497);
            this.numericUpDownContent.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownContent.Name = "numericUpDownContent";
            this.numericUpDownContent.Size = new System.Drawing.Size(86, 20);
            this.numericUpDownContent.TabIndex = 78;
            // 
            // labelContent
            // 
            this.labelContent.AutoSize = true;
            this.labelContent.Location = new System.Drawing.Point(12, 499);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(132, 13);
            this.labelContent.TabIndex = 79;
            this.labelContent.Text = "Ilość sztuk w opakowaniu:";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(106, 109);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(100, 20);
            this.textBoxVat.TabIndex = 80;
            // 
            // FormAntibiotic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 629);
            this.Controls.Add(this.textBoxVat);
            this.Controls.Add(this.numericUpDownContent);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxUse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPercent);
            this.Controls.Add(this.numericUpDownNumberOfDoses);
            this.Controls.Add(this.labelNumberOfDoses);
            this.Controls.Add(this.checkBoxPrescription);
            this.Controls.Add(this.comboBoxForm);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.numericUpDownNetPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonReadPhoto);
            this.Controls.Add(this.pictureBoxPhoto2);
            this.Controls.Add(this.pictureBoxPhoto1);
            this.Controls.Add(this.labelPhoto);
            this.Controls.Add(this.labelExpirationDate);
            this.Controls.Add(this.dateTimePickerExpirationDate);
            this.Controls.Add(this.textBoxAdditionalInformation);
            this.Controls.Add(this.labelAdditionalInformation);
            this.Controls.Add(this.textBoxAdverseEffects);
            this.Controls.Add(this.labelAdverseEffects);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.labelComponent);
            this.Controls.Add(this.labelLicense);
            this.Controls.Add(this.textBoxProducer);
            this.Controls.Add(this.labelProducer);
            this.Controls.Add(this.labelUse);
            this.Controls.Add(this.labelPurpose);
            this.Controls.Add(this.textBoxPurpose);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelChemicalStructure);
            this.Controls.Add(this.labelPrescriptionNumber);
            this.Controls.Add(this.labelNetPrice);
            this.Controls.Add(this.labelVat);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.listBoxAntibiotic);
            this.Controls.Add(this.buttonAddAntibiotic);
            this.Controls.Add(this.buttonFill);
            this.Controls.Add(this.textBoxChemicalStructure);
            this.Controls.Add(this.textBoxLicense);
            this.Name = "FormAntibiotic";
            this.Text = "FormAntibiotic";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormAntibiotic_MouseDoubleClick);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNetPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfDoses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLicense;
        private System.Windows.Forms.TextBox textBoxChemicalStructure;
        private System.Windows.Forms.Button buttonFill;
        private System.Windows.Forms.Button buttonAddAntibiotic;
        private System.Windows.Forms.ListBox listBoxAntibiotic;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelNetPrice;
        private System.Windows.Forms.Label labelPrescriptionNumber;
        private System.Windows.Forms.Label labelChemicalStructure;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.TextBox textBoxPurpose;
        private System.Windows.Forms.Label labelPurpose;
        private System.Windows.Forms.Label labelUse;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.Label labelLicense;
        private System.Windows.Forms.Label labelComponent;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.Label labelAdverseEffects;
        private System.Windows.Forms.TextBox textBoxAdverseEffects;
        private System.Windows.Forms.Label labelAdditionalInformation;
        private System.Windows.Forms.TextBox textBoxAdditionalInformation;
        private System.Windows.Forms.DateTimePicker dateTimePickerExpirationDate;
        private System.Windows.Forms.Label labelExpirationDate;
        private System.Windows.Forms.Label labelPhoto;
        private System.Windows.Forms.PictureBox pictureBoxPhoto1;
        private System.Windows.Forms.PictureBox pictureBoxPhoto2;
        private System.Windows.Forms.Button buttonReadPhoto;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.NumericUpDown numericUpDownNetPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.CheckBox checkBoxPrescription;
        private System.Windows.Forms.Label labelNumberOfDoses;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfDoses;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxUse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownContent;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TextBox textBoxVat;
    }
}