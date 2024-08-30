using System.Drawing;
using System.Windows.Forms;

namespace MHD_ESaver
{
    partial class StatsPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsPanel));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            gesamtZeitraumBox = new MaterialSkin.Controls.MaterialCheckbox();
            endDatumPicker = new DateTimePicker();
            startDatumPicker = new DateTimePicker();
            endDatumLabel = new MaterialSkin.Controls.MaterialLabel();
            startDatumLabel = new MaterialSkin.Controls.MaterialLabel();
            fahrzeugLabel = new MaterialSkin.Controls.MaterialLabel();
            fahrzeugBox = new MaterialSkin.Controls.MaterialComboBox();
            eBox = new MaterialSkin.Controls.MaterialTextBox();
            einsatzGesamtLabel = new MaterialSkin.Controls.MaterialLabel();
            kilometerGesamtLabel = new MaterialSkin.Controls.MaterialLabel();
            kmBox = new MaterialSkin.Controls.MaterialTextBox();
            naLabel = new MaterialSkin.Controls.MaterialLabel();
            naBox = new MaterialSkin.Controls.MaterialTextBox();
            ambulantLabel = new MaterialSkin.Controls.MaterialLabel();
            ambulantBox = new MaterialSkin.Controls.MaterialTextBox();
            fehlfahrtLabel = new MaterialSkin.Controls.MaterialLabel();
            fehlfahrtBox = new MaterialSkin.Controls.MaterialTextBox();
            exportBttn = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(gesamtZeitraumBox);
            materialCard1.Controls.Add(endDatumPicker);
            materialCard1.Controls.Add(startDatumPicker);
            materialCard1.Controls.Add(endDatumLabel);
            materialCard1.Controls.Add(startDatumLabel);
            materialCard1.Controls.Add(fahrzeugLabel);
            materialCard1.Controls.Add(fahrzeugBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(429, 290);
            materialCard1.TabIndex = 0;
            // 
            // gesamtZeitraumBox
            // 
            gesamtZeitraumBox.AutoSize = true;
            gesamtZeitraumBox.Depth = 0;
            gesamtZeitraumBox.Location = new Point(134, 221);
            gesamtZeitraumBox.Margin = new Padding(0);
            gesamtZeitraumBox.MouseLocation = new Point(-1, -1);
            gesamtZeitraumBox.MouseState = MaterialSkin.MouseState.HOVER;
            gesamtZeitraumBox.Name = "gesamtZeitraumBox";
            gesamtZeitraumBox.ReadOnly = false;
            gesamtZeitraumBox.Ripple = true;
            gesamtZeitraumBox.Size = new Size(165, 37);
            gesamtZeitraumBox.TabIndex = 6;
            gesamtZeitraumBox.Text = "Gesamterzeitraum";
            gesamtZeitraumBox.UseVisualStyleBackColor = true;
            gesamtZeitraumBox.CheckedChanged += gesamtZeitraumBox_CheckedChanged;
            // 
            // endDatumPicker
            // 
            endDatumPicker.CustomFormat = "yyyy-mm-dd";
            endDatumPicker.Format = DateTimePickerFormat.Short;
            endDatumPicker.Location = new Point(98, 185);
            endDatumPicker.Name = "endDatumPicker";
            endDatumPicker.Size = new Size(229, 23);
            endDatumPicker.TabIndex = 5;
            endDatumPicker.ValueChanged += endDatumPicker_ValueChanged;
            // 
            // startDatumPicker
            // 
            startDatumPicker.CustomFormat = "";
            startDatumPicker.Format = DateTimePickerFormat.Short;
            startDatumPicker.Location = new Point(98, 124);
            startDatumPicker.Name = "startDatumPicker";
            startDatumPicker.Size = new Size(229, 23);
            startDatumPicker.TabIndex = 4;
            startDatumPicker.ValueChanged += startDatumPicker_ValueChanged;
            // 
            // endDatumLabel
            // 
            endDatumLabel.AutoSize = true;
            endDatumLabel.Depth = 0;
            endDatumLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endDatumLabel.Location = new Point(98, 163);
            endDatumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            endDatumLabel.Name = "endDatumLabel";
            endDatumLabel.Size = new Size(74, 19);
            endDatumLabel.TabIndex = 3;
            endDatumLabel.Text = "Enddatum";
            // 
            // startDatumLabel
            // 
            startDatumLabel.AutoSize = true;
            startDatumLabel.Depth = 0;
            startDatumLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startDatumLabel.Location = new Point(98, 102);
            startDatumLabel.MouseState = MaterialSkin.MouseState.HOVER;
            startDatumLabel.Name = "startDatumLabel";
            startDatumLabel.Size = new Size(81, 19);
            startDatumLabel.TabIndex = 2;
            startDatumLabel.Text = "Startdatum";
            // 
            // fahrzeugLabel
            // 
            fahrzeugLabel.AutoSize = true;
            fahrzeugLabel.Depth = 0;
            fahrzeugLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fahrzeugLabel.Location = new Point(98, 23);
            fahrzeugLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fahrzeugLabel.Name = "fahrzeugLabel";
            fahrzeugLabel.Size = new Size(67, 19);
            fahrzeugLabel.TabIndex = 1;
            fahrzeugLabel.Text = "Fahrzeug";
            // 
            // fahrzeugBox
            // 
            fahrzeugBox.AutoResize = false;
            fahrzeugBox.BackColor = Color.FromArgb(255, 255, 255);
            fahrzeugBox.Depth = 0;
            fahrzeugBox.DrawMode = DrawMode.OwnerDrawVariable;
            fahrzeugBox.DropDownHeight = 174;
            fahrzeugBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fahrzeugBox.DropDownWidth = 121;
            fahrzeugBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            fahrzeugBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            fahrzeugBox.FormattingEnabled = true;
            fahrzeugBox.IntegralHeight = false;
            fahrzeugBox.ItemHeight = 43;
            fahrzeugBox.Location = new Point(98, 45);
            fahrzeugBox.MaxDropDownItems = 4;
            fahrzeugBox.MouseState = MaterialSkin.MouseState.OUT;
            fahrzeugBox.Name = "fahrzeugBox";
            fahrzeugBox.Size = new Size(229, 49);
            fahrzeugBox.StartIndex = 0;
            fahrzeugBox.TabIndex = 0;
            fahrzeugBox.SelectedIndexChanged += fahrzeugBox_SelectedIndexChanged;
            // 
            // eBox
            // 
            eBox.AnimateReadOnly = false;
            eBox.BorderStyle = BorderStyle.None;
            eBox.Depth = 0;
            eBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            eBox.LeadingIcon = null;
            eBox.Location = new Point(17, 424);
            eBox.MaxLength = 50;
            eBox.MouseState = MaterialSkin.MouseState.OUT;
            eBox.Multiline = false;
            eBox.Name = "eBox";
            eBox.ReadOnly = true;
            eBox.Size = new Size(165, 50);
            eBox.TabIndex = 1;
            eBox.Text = "";
            eBox.TrailingIcon = null;
            // 
            // einsatzGesamtLabel
            // 
            einsatzGesamtLabel.AutoSize = true;
            einsatzGesamtLabel.Depth = 0;
            einsatzGesamtLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            einsatzGesamtLabel.Location = new Point(17, 392);
            einsatzGesamtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            einsatzGesamtLabel.Name = "einsatzGesamtLabel";
            einsatzGesamtLabel.Size = new Size(118, 19);
            einsatzGesamtLabel.TabIndex = 7;
            einsatzGesamtLabel.Text = "Einsätze gesamt";
            // 
            // kilometerGesamtLabel
            // 
            kilometerGesamtLabel.AutoSize = true;
            kilometerGesamtLabel.Depth = 0;
            kilometerGesamtLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            kilometerGesamtLabel.Location = new Point(281, 391);
            kilometerGesamtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            kilometerGesamtLabel.Name = "kilometerGesamtLabel";
            kilometerGesamtLabel.Size = new Size(125, 19);
            kilometerGesamtLabel.TabIndex = 9;
            kilometerGesamtLabel.Text = "Kilometer gesamt";
            // 
            // kmBox
            // 
            kmBox.AnimateReadOnly = false;
            kmBox.BorderStyle = BorderStyle.None;
            kmBox.Depth = 0;
            kmBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            kmBox.LeadingIcon = null;
            kmBox.Location = new Point(281, 423);
            kmBox.MaxLength = 50;
            kmBox.MouseState = MaterialSkin.MouseState.OUT;
            kmBox.Multiline = false;
            kmBox.Name = "kmBox";
            kmBox.ReadOnly = true;
            kmBox.Size = new Size(165, 50);
            kmBox.TabIndex = 8;
            kmBox.Text = "";
            kmBox.TrailingIcon = null;
            // 
            // naLabel
            // 
            naLabel.AutoSize = true;
            naLabel.Depth = 0;
            naLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            naLabel.Location = new Point(17, 617);
            naLabel.MouseState = MaterialSkin.MouseState.HOVER;
            naLabel.Name = "naLabel";
            naLabel.Size = new Size(143, 19);
            naLabel.TabIndex = 13;
            naLabel.Text = "NA-Einsätze gesamt";
            // 
            // naBox
            // 
            naBox.AnimateReadOnly = false;
            naBox.BorderStyle = BorderStyle.None;
            naBox.Depth = 0;
            naBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            naBox.LeadingIcon = null;
            naBox.Location = new Point(17, 655);
            naBox.MaxLength = 50;
            naBox.MouseState = MaterialSkin.MouseState.OUT;
            naBox.Multiline = false;
            naBox.Name = "naBox";
            naBox.ReadOnly = true;
            naBox.Size = new Size(165, 50);
            naBox.TabIndex = 12;
            naBox.Text = "";
            naBox.TrailingIcon = null;
            // 
            // ambulantLabel
            // 
            ambulantLabel.AutoSize = true;
            ambulantLabel.Depth = 0;
            ambulantLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            ambulantLabel.Location = new Point(17, 505);
            ambulantLabel.MouseState = MaterialSkin.MouseState.HOVER;
            ambulantLabel.Name = "ambulantLabel";
            ambulantLabel.Size = new Size(135, 19);
            ambulantLabel.TabIndex = 15;
            ambulantLabel.Text = "Ambulante gesamt";
            // 
            // ambulantBox
            // 
            ambulantBox.AnimateReadOnly = false;
            ambulantBox.BorderStyle = BorderStyle.None;
            ambulantBox.Depth = 0;
            ambulantBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ambulantBox.LeadingIcon = null;
            ambulantBox.Location = new Point(17, 537);
            ambulantBox.MaxLength = 50;
            ambulantBox.MouseState = MaterialSkin.MouseState.OUT;
            ambulantBox.Multiline = false;
            ambulantBox.Name = "ambulantBox";
            ambulantBox.ReadOnly = true;
            ambulantBox.Size = new Size(165, 50);
            ambulantBox.TabIndex = 14;
            ambulantBox.Text = "";
            ambulantBox.TrailingIcon = null;
            // 
            // fehlfahrtLabel
            // 
            fehlfahrtLabel.AutoSize = true;
            fehlfahrtLabel.Depth = 0;
            fehlfahrtLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fehlfahrtLabel.Location = new Point(281, 505);
            fehlfahrtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fehlfahrtLabel.Name = "fehlfahrtLabel";
            fehlfahrtLabel.Size = new Size(139, 19);
            fehlfahrtLabel.TabIndex = 17;
            fehlfahrtLabel.Text = "Fehlfahrten gesamt";
            // 
            // fehlfahrtBox
            // 
            fehlfahrtBox.AnimateReadOnly = false;
            fehlfahrtBox.BorderStyle = BorderStyle.None;
            fehlfahrtBox.Depth = 0;
            fehlfahrtBox.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fehlfahrtBox.LeadingIcon = null;
            fehlfahrtBox.Location = new Point(281, 537);
            fehlfahrtBox.MaxLength = 50;
            fehlfahrtBox.MouseState = MaterialSkin.MouseState.OUT;
            fehlfahrtBox.Multiline = false;
            fehlfahrtBox.Name = "fehlfahrtBox";
            fehlfahrtBox.ReadOnly = true;
            fehlfahrtBox.Size = new Size(165, 50);
            fehlfahrtBox.TabIndex = 16;
            fehlfahrtBox.Text = "";
            fehlfahrtBox.TrailingIcon = null;
            // 
            // exportBttn
            // 
            exportBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            exportBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            exportBttn.Depth = 0;
            exportBttn.HighEmphasis = true;
            exportBttn.Icon = null;
            exportBttn.Location = new Point(281, 655);
            exportBttn.Margin = new Padding(4, 6, 4, 6);
            exportBttn.MouseState = MaterialSkin.MouseState.HOVER;
            exportBttn.Name = "exportBttn";
            exportBttn.NoAccentTextColor = Color.Empty;
            exportBttn.Size = new Size(107, 36);
            exportBttn.TabIndex = 18;
            exportBttn.Text = "export txt";
            exportBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            exportBttn.UseAccentColor = false;
            exportBttn.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(281, 617);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(141, 19);
            materialLabel1.TabIndex = 19;
            materialLabel1.Text = "Statistik exportieren";
            // 
            // StatsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 725);
            Controls.Add(materialLabel1);
            Controls.Add(exportBttn);
            Controls.Add(fehlfahrtLabel);
            Controls.Add(fehlfahrtBox);
            Controls.Add(ambulantLabel);
            Controls.Add(ambulantBox);
            Controls.Add(naLabel);
            Controls.Add(naBox);
            Controls.Add(kilometerGesamtLabel);
            Controls.Add(kmBox);
            Controls.Add(einsatzGesamtLabel);
            Controls.Add(eBox);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StatsPanel";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ESaver | Statistik";
            Load += StatsPanel_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private DateTimePicker endDatumPicker;
        private DateTimePicker startDatumPicker;
        private MaterialSkin.Controls.MaterialLabel endDatumLabel;
        private MaterialSkin.Controls.MaterialLabel startDatumLabel;
        private MaterialSkin.Controls.MaterialLabel fahrzeugLabel;
        private MaterialSkin.Controls.MaterialComboBox fahrzeugBox;
        private MaterialSkin.Controls.MaterialTextBox eBox;
        private MaterialSkin.Controls.MaterialLabel einsatzGesamtLabel;
        private MaterialSkin.Controls.MaterialLabel kilometerGesamtLabel;
        private MaterialSkin.Controls.MaterialTextBox kmBox;
        private MaterialSkin.Controls.MaterialLabel naLabel;
        private MaterialSkin.Controls.MaterialTextBox naBox;
        private MaterialSkin.Controls.MaterialLabel ambulantLabel;
        private MaterialSkin.Controls.MaterialTextBox ambulantBox;
        private MaterialSkin.Controls.MaterialLabel fehlfahrtLabel;
        private MaterialSkin.Controls.MaterialTextBox fehlfahrtBox;
        private MaterialSkin.Controls.MaterialButton exportBttn;
        private MaterialSkin.Controls.MaterialCheckbox gesamtZeitraumBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}