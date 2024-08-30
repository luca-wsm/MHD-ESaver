using System.Drawing;
using System.Windows.Forms;

namespace MHD_ESaver
{
    partial class MainPanel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            sendBttn = new MaterialSkin.Controls.MaterialButton();
            notarztCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            fahrerBeifahrerLabel = new MaterialSkin.Controls.MaterialLabel();
            fahrerBeifahrerBox = new MaterialSkin.Controls.MaterialTextBox2();
            kilometerLabel = new MaterialSkin.Controls.MaterialLabel();
            kilometerBox = new MaterialSkin.Controls.MaterialTextBox2();
            endZeitLabel = new MaterialSkin.Controls.MaterialLabel();
            endZeitBox = new MaterialSkin.Controls.MaterialTextBox2();
            startZeitLabel = new MaterialSkin.Controls.MaterialLabel();
            startZeitBox = new MaterialSkin.Controls.MaterialTextBox2();
            endOrtLabel = new MaterialSkin.Controls.MaterialLabel();
            endOrtBox = new MaterialSkin.Controls.MaterialTextBox2();
            locationStripEnd = new ContextMenuStrip(components);
            evStripEnd = new ToolStripMenuItem();
            piusStripEnd = new ToolStripMenuItem();
            klinikumStripEnd = new ToolStripMenuItem();
            leerfahrtStripEnd = new ToolStripMenuItem();
            fehlfahrtStripEnd = new ToolStripMenuItem();
            startOrtLabel = new MaterialSkin.Controls.MaterialLabel();
            startOrtBox = new MaterialSkin.Controls.MaterialTextBox2();
            locationStripStart = new ContextMenuStrip(components);
            evStrip = new ToolStripMenuItem();
            piusStrip = new ToolStripMenuItem();
            koStrip = new ToolStripMenuItem();
            leerfahrtStrip = new ToolStripMenuItem();
            fehlfahrtSlip = new ToolStripMenuItem();
            eNummerLabel = new MaterialSkin.Controls.MaterialLabel();
            eNummerBox = new MaterialSkin.Controls.MaterialTextBox2();
            fahrzeugLabel = new MaterialSkin.Controls.MaterialLabel();
            fahrzeugBox = new MaterialSkin.Controls.MaterialComboBox();
            statsLabel = new MaterialSkin.Controls.MaterialLabel();
            adminLabel = new MaterialSkin.Controls.MaterialLabel();
            materialCard1.SuspendLayout();
            locationStripEnd.SuspendLayout();
            locationStripStart.SuspendLayout();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(sendBttn);
            materialCard1.Controls.Add(notarztCheckbox);
            materialCard1.Controls.Add(fahrerBeifahrerLabel);
            materialCard1.Controls.Add(fahrerBeifahrerBox);
            materialCard1.Controls.Add(kilometerLabel);
            materialCard1.Controls.Add(kilometerBox);
            materialCard1.Controls.Add(endZeitLabel);
            materialCard1.Controls.Add(endZeitBox);
            materialCard1.Controls.Add(startZeitLabel);
            materialCard1.Controls.Add(startZeitBox);
            materialCard1.Controls.Add(endOrtLabel);
            materialCard1.Controls.Add(endOrtBox);
            materialCard1.Controls.Add(startOrtLabel);
            materialCard1.Controls.Add(startOrtBox);
            materialCard1.Controls.Add(eNummerLabel);
            materialCard1.Controls.Add(eNummerBox);
            materialCard1.Controls.Add(fahrzeugLabel);
            materialCard1.Controls.Add(fahrzeugBox);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 78);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(361, 805);
            materialCard1.TabIndex = 0;
            // 
            // sendBttn
            // 
            sendBttn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            sendBttn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            sendBttn.Depth = 0;
            sendBttn.HighEmphasis = true;
            sendBttn.Icon = null;
            sendBttn.Location = new Point(136, 749);
            sendBttn.Margin = new Padding(4, 6, 4, 6);
            sendBttn.MouseState = MaterialSkin.MouseState.HOVER;
            sendBttn.Name = "sendBttn";
            sendBttn.NoAccentTextColor = Color.Empty;
            sendBttn.Size = new Size(111, 36);
            sendBttn.TabIndex = 18;
            sendBttn.Text = "Abschicken";
            sendBttn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            sendBttn.UseAccentColor = false;
            sendBttn.UseVisualStyleBackColor = true;
            sendBttn.Click += sendBttn_Click;
            // 
            // notarztCheckbox
            // 
            notarztCheckbox.AutoSize = true;
            notarztCheckbox.Depth = 0;
            notarztCheckbox.Location = new Point(17, 688);
            notarztCheckbox.Margin = new Padding(0);
            notarztCheckbox.MouseLocation = new Point(-1, -1);
            notarztCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            notarztCheckbox.Name = "notarztCheckbox";
            notarztCheckbox.ReadOnly = false;
            notarztCheckbox.Ripple = true;
            notarztCheckbox.Size = new Size(165, 37);
            notarztCheckbox.TabIndex = 16;
            notarztCheckbox.Text = "Notarzt begleitung";
            notarztCheckbox.UseVisualStyleBackColor = true;
            // 
            // fahrerBeifahrerLabel
            // 
            fahrerBeifahrerLabel.AutoSize = true;
            fahrerBeifahrerLabel.Depth = 0;
            fahrerBeifahrerLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fahrerBeifahrerLabel.Location = new Point(17, 605);
            fahrerBeifahrerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            fahrerBeifahrerLabel.Name = "fahrerBeifahrerLabel";
            fahrerBeifahrerLabel.Size = new Size(117, 19);
            fahrerBeifahrerLabel.TabIndex = 15;
            fahrerBeifahrerLabel.Text = "Fahrer, Beifahrer";
            // 
            // fahrerBeifahrerBox
            // 
            fahrerBeifahrerBox.AnimateReadOnly = false;
            fahrerBeifahrerBox.BackgroundImageLayout = ImageLayout.None;
            fahrerBeifahrerBox.CharacterCasing = CharacterCasing.Normal;
            fahrerBeifahrerBox.Depth = 0;
            fahrerBeifahrerBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            fahrerBeifahrerBox.HideSelection = true;
            fahrerBeifahrerBox.LeadingIcon = null;
            fahrerBeifahrerBox.Location = new Point(17, 627);
            fahrerBeifahrerBox.MaxLength = 32767;
            fahrerBeifahrerBox.MouseState = MaterialSkin.MouseState.OUT;
            fahrerBeifahrerBox.Name = "fahrerBeifahrerBox";
            fahrerBeifahrerBox.PasswordChar = '\0';
            fahrerBeifahrerBox.PrefixSuffixText = null;
            fahrerBeifahrerBox.ReadOnly = false;
            fahrerBeifahrerBox.RightToLeft = RightToLeft.No;
            fahrerBeifahrerBox.SelectedText = "";
            fahrerBeifahrerBox.SelectionLength = 0;
            fahrerBeifahrerBox.SelectionStart = 0;
            fahrerBeifahrerBox.ShortcutsEnabled = true;
            fahrerBeifahrerBox.Size = new Size(327, 48);
            fahrerBeifahrerBox.TabIndex = 14;
            fahrerBeifahrerBox.TabStop = false;
            fahrerBeifahrerBox.TextAlign = HorizontalAlignment.Left;
            fahrerBeifahrerBox.TrailingIcon = null;
            fahrerBeifahrerBox.UseSystemPasswordChar = false;
            // 
            // kilometerLabel
            // 
            kilometerLabel.AutoSize = true;
            kilometerLabel.Depth = 0;
            kilometerLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            kilometerLabel.Location = new Point(17, 520);
            kilometerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            kilometerLabel.Name = "kilometerLabel";
            kilometerLabel.Size = new Size(68, 19);
            kilometerLabel.TabIndex = 13;
            kilometerLabel.Text = "Kilometer";
            // 
            // kilometerBox
            // 
            kilometerBox.AnimateReadOnly = false;
            kilometerBox.BackgroundImageLayout = ImageLayout.None;
            kilometerBox.CharacterCasing = CharacterCasing.Normal;
            kilometerBox.Depth = 0;
            kilometerBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            kilometerBox.HideSelection = true;
            kilometerBox.LeadingIcon = null;
            kilometerBox.Location = new Point(17, 542);
            kilometerBox.MaxLength = 10;
            kilometerBox.MouseState = MaterialSkin.MouseState.OUT;
            kilometerBox.Name = "kilometerBox";
            kilometerBox.PasswordChar = '\0';
            kilometerBox.PrefixSuffixText = null;
            kilometerBox.ReadOnly = false;
            kilometerBox.RightToLeft = RightToLeft.No;
            kilometerBox.SelectedText = "";
            kilometerBox.SelectionLength = 0;
            kilometerBox.SelectionStart = 0;
            kilometerBox.ShortcutsEnabled = true;
            kilometerBox.Size = new Size(327, 48);
            kilometerBox.TabIndex = 12;
            kilometerBox.TabStop = false;
            kilometerBox.TextAlign = HorizontalAlignment.Left;
            kilometerBox.TrailingIcon = null;
            kilometerBox.UseSystemPasswordChar = false;
            // 
            // endZeitLabel
            // 
            endZeitLabel.AutoSize = true;
            endZeitLabel.Depth = 0;
            endZeitLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endZeitLabel.Location = new Point(17, 436);
            endZeitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            endZeitLabel.Name = "endZeitLabel";
            endZeitLabel.Size = new Size(53, 19);
            endZeitLabel.TabIndex = 11;
            endZeitLabel.Text = "Endzeit";
            // 
            // endZeitBox
            // 
            endZeitBox.AnimateReadOnly = false;
            endZeitBox.BackgroundImageLayout = ImageLayout.None;
            endZeitBox.CharacterCasing = CharacterCasing.Normal;
            endZeitBox.Depth = 0;
            endZeitBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            endZeitBox.HideSelection = true;
            endZeitBox.LeadingIcon = null;
            endZeitBox.Location = new Point(17, 458);
            endZeitBox.MaxLength = 32767;
            endZeitBox.MouseState = MaterialSkin.MouseState.OUT;
            endZeitBox.Name = "endZeitBox";
            endZeitBox.PasswordChar = '\0';
            endZeitBox.PrefixSuffixText = null;
            endZeitBox.ReadOnly = false;
            endZeitBox.RightToLeft = RightToLeft.No;
            endZeitBox.SelectedText = "";
            endZeitBox.SelectionLength = 0;
            endZeitBox.SelectionStart = 0;
            endZeitBox.ShortcutsEnabled = true;
            endZeitBox.Size = new Size(327, 48);
            endZeitBox.TabIndex = 10;
            endZeitBox.TabStop = false;
            endZeitBox.TextAlign = HorizontalAlignment.Left;
            endZeitBox.TrailingIcon = null;
            endZeitBox.UseSystemPasswordChar = false;
            endZeitBox.TextChanged += endZeitBox_TextChanged;
            // 
            // startZeitLabel
            // 
            startZeitLabel.AutoSize = true;
            startZeitLabel.Depth = 0;
            startZeitLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startZeitLabel.Location = new Point(17, 353);
            startZeitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            startZeitLabel.Name = "startZeitLabel";
            startZeitLabel.Size = new Size(60, 19);
            startZeitLabel.TabIndex = 9;
            startZeitLabel.Text = "Startzeit";
            // 
            // startZeitBox
            // 
            startZeitBox.AnimateReadOnly = false;
            startZeitBox.BackgroundImageLayout = ImageLayout.None;
            startZeitBox.CharacterCasing = CharacterCasing.Normal;
            startZeitBox.Depth = 0;
            startZeitBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            startZeitBox.HideSelection = true;
            startZeitBox.LeadingIcon = null;
            startZeitBox.Location = new Point(17, 375);
            startZeitBox.MaxLength = 32767;
            startZeitBox.MouseState = MaterialSkin.MouseState.OUT;
            startZeitBox.Name = "startZeitBox";
            startZeitBox.PasswordChar = '\0';
            startZeitBox.PrefixSuffixText = null;
            startZeitBox.ReadOnly = false;
            startZeitBox.RightToLeft = RightToLeft.No;
            startZeitBox.SelectedText = "";
            startZeitBox.SelectionLength = 0;
            startZeitBox.SelectionStart = 0;
            startZeitBox.ShortcutsEnabled = true;
            startZeitBox.Size = new Size(327, 48);
            startZeitBox.TabIndex = 8;
            startZeitBox.TabStop = false;
            startZeitBox.TextAlign = HorizontalAlignment.Left;
            startZeitBox.TrailingIcon = null;
            startZeitBox.UseSystemPasswordChar = false;
            startZeitBox.TextChanged += startZeitBox_TextChanged;
            // 
            // endOrtLabel
            // 
            endOrtLabel.AutoSize = true;
            endOrtLabel.Depth = 0;
            endOrtLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            endOrtLabel.Location = new Point(17, 269);
            endOrtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            endOrtLabel.Name = "endOrtLabel";
            endOrtLabel.Size = new Size(47, 19);
            endOrtLabel.TabIndex = 7;
            endOrtLabel.Text = "Endort";
            // 
            // endOrtBox
            // 
            endOrtBox.AnimateReadOnly = false;
            endOrtBox.BackgroundImageLayout = ImageLayout.None;
            endOrtBox.CharacterCasing = CharacterCasing.Normal;
            endOrtBox.ContextMenuStrip = locationStripEnd;
            endOrtBox.Depth = 0;
            endOrtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            endOrtBox.HideSelection = true;
            endOrtBox.LeadingIcon = null;
            endOrtBox.Location = new Point(17, 291);
            endOrtBox.MaxLength = 32767;
            endOrtBox.MouseState = MaterialSkin.MouseState.OUT;
            endOrtBox.Name = "endOrtBox";
            endOrtBox.PasswordChar = '\0';
            endOrtBox.PrefixSuffixText = null;
            endOrtBox.ReadOnly = false;
            endOrtBox.RightToLeft = RightToLeft.No;
            endOrtBox.SelectedText = "";
            endOrtBox.SelectionLength = 0;
            endOrtBox.SelectionStart = 0;
            endOrtBox.ShortcutsEnabled = true;
            endOrtBox.Size = new Size(327, 48);
            endOrtBox.TabIndex = 6;
            endOrtBox.TabStop = false;
            endOrtBox.TextAlign = HorizontalAlignment.Left;
            endOrtBox.TrailingIcon = null;
            endOrtBox.UseSystemPasswordChar = false;
            // 
            // locationStripEnd
            // 
            locationStripEnd.Items.AddRange(new ToolStripItem[] { evStripEnd, piusStripEnd, klinikumStripEnd, leerfahrtStripEnd, fehlfahrtStripEnd });
            locationStripEnd.Name = "locationStripEnd";
            locationStripEnd.Size = new Size(215, 114);
            // 
            // evStripEnd
            // 
            evStripEnd.Name = "evStripEnd";
            evStripEnd.Size = new Size(214, 22);
            evStripEnd.Text = "EV";
            evStripEnd.Click += evStripEnd_Click;
            // 
            // piusStripEnd
            // 
            piusStripEnd.Name = "piusStripEnd";
            piusStripEnd.Size = new Size(214, 22);
            piusStripEnd.Text = "Pius";
            piusStripEnd.Click += piusStripEnd_Click;
            // 
            // klinikumStripEnd
            // 
            klinikumStripEnd.Name = "klinikumStripEnd";
            klinikumStripEnd.Size = new Size(214, 22);
            klinikumStripEnd.Text = "Klinikum OL";
            klinikumStripEnd.Click += koStripEnd_Click;
            // 
            // leerfahrtStripEnd
            // 
            leerfahrtStripEnd.Name = "leerfahrtStripEnd";
            leerfahrtStripEnd.Size = new Size(214, 22);
            leerfahrtStripEnd.Text = "Leerfahrt ( Ambulant )";
            leerfahrtStripEnd.Click += leerfahrtStripEnd_Click;
            // 
            // fehlfahrtStripEnd
            // 
            fehlfahrtStripEnd.Name = "fehlfahrtStripEnd";
            fehlfahrtStripEnd.Size = new Size(214, 22);
            fehlfahrtStripEnd.Text = "Fehlfahrt ( Kein Antreffen )";
            fehlfahrtStripEnd.Click += fehlfahrtStripEnd_Click;
            // 
            // startOrtLabel
            // 
            startOrtLabel.AutoSize = true;
            startOrtLabel.Depth = 0;
            startOrtLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            startOrtLabel.Location = new Point(17, 185);
            startOrtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            startOrtLabel.Name = "startOrtLabel";
            startOrtLabel.Size = new Size(54, 19);
            startOrtLabel.TabIndex = 5;
            startOrtLabel.Text = "Startort";
            // 
            // startOrtBox
            // 
            startOrtBox.AnimateReadOnly = false;
            startOrtBox.BackgroundImageLayout = ImageLayout.None;
            startOrtBox.CharacterCasing = CharacterCasing.Normal;
            startOrtBox.ContextMenuStrip = locationStripStart;
            startOrtBox.Depth = 0;
            startOrtBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            startOrtBox.HideSelection = true;
            startOrtBox.LeadingIcon = null;
            startOrtBox.Location = new Point(17, 207);
            startOrtBox.MaxLength = 32767;
            startOrtBox.MouseState = MaterialSkin.MouseState.OUT;
            startOrtBox.Name = "startOrtBox";
            startOrtBox.PasswordChar = '\0';
            startOrtBox.PrefixSuffixText = null;
            startOrtBox.ReadOnly = false;
            startOrtBox.RightToLeft = RightToLeft.No;
            startOrtBox.SelectedText = "";
            startOrtBox.SelectionLength = 0;
            startOrtBox.SelectionStart = 0;
            startOrtBox.ShortcutsEnabled = true;
            startOrtBox.Size = new Size(327, 48);
            startOrtBox.TabIndex = 4;
            startOrtBox.TabStop = false;
            startOrtBox.TextAlign = HorizontalAlignment.Left;
            startOrtBox.TrailingIcon = null;
            startOrtBox.UseSystemPasswordChar = false;
            // 
            // locationStripStart
            // 
            locationStripStart.Items.AddRange(new ToolStripItem[] { evStrip, piusStrip, koStrip, leerfahrtStrip, fehlfahrtSlip });
            locationStripStart.Name = "locationStrip";
            locationStripStart.Size = new Size(215, 114);
            // 
            // evStrip
            // 
            evStrip.Name = "evStrip";
            evStrip.Size = new Size(214, 22);
            evStrip.Text = "EV";
            evStrip.TextAlign = ContentAlignment.TopLeft;
            evStrip.Click += evStrip_Click;
            // 
            // piusStrip
            // 
            piusStrip.Name = "piusStrip";
            piusStrip.Size = new Size(214, 22);
            piusStrip.Text = "Pius";
            piusStrip.Click += piusStrip_Click;
            // 
            // koStrip
            // 
            koStrip.Name = "koStrip";
            koStrip.Size = new Size(214, 22);
            koStrip.Text = "Klinikum OL";
            koStrip.Click += koStrip_Click;
            // 
            // leerfahrtStrip
            // 
            leerfahrtStrip.Name = "leerfahrtStrip";
            leerfahrtStrip.Size = new Size(214, 22);
            leerfahrtStrip.Text = "Leerfahrt ( Ambulant )";
            leerfahrtStrip.Click += leerfahrtStrip_Click;
            // 
            // fehlfahrtSlip
            // 
            fehlfahrtSlip.Name = "fehlfahrtSlip";
            fehlfahrtSlip.Size = new Size(214, 22);
            fehlfahrtSlip.Text = "Fehlfahrt ( Kein Antreffen )";
            fehlfahrtSlip.Click += fehlfahrtStrip_Click;
            // 
            // eNummerLabel
            // 
            eNummerLabel.AutoSize = true;
            eNummerLabel.Depth = 0;
            eNummerLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            eNummerLabel.Location = new Point(17, 101);
            eNummerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            eNummerLabel.Name = "eNummerLabel";
            eNummerLabel.Size = new Size(75, 19);
            eNummerLabel.TabIndex = 3;
            eNummerLabel.Text = "E-Nummer";
            // 
            // eNummerBox
            // 
            eNummerBox.AnimateReadOnly = false;
            eNummerBox.BackgroundImageLayout = ImageLayout.None;
            eNummerBox.CharacterCasing = CharacterCasing.Normal;
            eNummerBox.Depth = 0;
            eNummerBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            eNummerBox.HideSelection = true;
            eNummerBox.LeadingIcon = null;
            eNummerBox.Location = new Point(17, 123);
            eNummerBox.MaxLength = 32767;
            eNummerBox.MouseState = MaterialSkin.MouseState.OUT;
            eNummerBox.Name = "eNummerBox";
            eNummerBox.PasswordChar = '\0';
            eNummerBox.PrefixSuffixText = null;
            eNummerBox.ReadOnly = false;
            eNummerBox.RightToLeft = RightToLeft.No;
            eNummerBox.SelectedText = "";
            eNummerBox.SelectionLength = 0;
            eNummerBox.SelectionStart = 0;
            eNummerBox.ShortcutsEnabled = true;
            eNummerBox.Size = new Size(327, 48);
            eNummerBox.TabIndex = 2;
            eNummerBox.TabStop = false;
            eNummerBox.TextAlign = HorizontalAlignment.Left;
            eNummerBox.TrailingIcon = null;
            eNummerBox.UseSystemPasswordChar = false;
            // 
            // fahrzeugLabel
            // 
            fahrzeugLabel.AutoSize = true;
            fahrzeugLabel.Depth = 0;
            fahrzeugLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            fahrzeugLabel.Location = new Point(17, 14);
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
            fahrzeugBox.Location = new Point(17, 42);
            fahrzeugBox.MaxDropDownItems = 4;
            fahrzeugBox.MouseState = MaterialSkin.MouseState.OUT;
            fahrzeugBox.Name = "fahrzeugBox";
            fahrzeugBox.Size = new Size(327, 49);
            fahrzeugBox.StartIndex = 0;
            fahrzeugBox.TabIndex = 0;
            // 
            // statsLabel
            // 
            statsLabel.AutoSize = true;
            statsLabel.Depth = 0;
            statsLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            statsLabel.Location = new Point(17, 897);
            statsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            statsLabel.Name = "statsLabel";
            statsLabel.Size = new Size(59, 19);
            statsLabel.TabIndex = 19;
            statsLabel.Text = "Statistik";
            statsLabel.Click += Stats_Click;
            // 
            // adminLabel
            // 
            adminLabel.AutoSize = true;
            adminLabel.Depth = 0;
            adminLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            adminLabel.Location = new Point(273, 897);
            adminLabel.MouseState = MaterialSkin.MouseState.HOVER;
            adminLabel.Name = "adminLabel";
            adminLabel.Size = new Size(105, 19);
            adminLabel.TabIndex = 20;
            adminLabel.Text = "Administration";
            adminLabel.Click += adminLabel_Click;
            // 
            // MainPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(395, 930);
            Controls.Add(adminLabel);
            Controls.Add(statsLabel);
            Controls.Add(materialCard1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainPanel";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Malteser Oldenburg | Einsatzspeicher";
            FormClosing += MainPanel_FormClosing;
            Load += MainPanel_Load;
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            locationStripEnd.ResumeLayout(false);
            locationStripStart.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCheckbox notarztCheckbox;
        private MaterialSkin.Controls.MaterialLabel fahrerBeifahrerLabel;
        private MaterialSkin.Controls.MaterialTextBox2 fahrerBeifahrerBox;
        private MaterialSkin.Controls.MaterialLabel kilometerLabel;
        private MaterialSkin.Controls.MaterialTextBox2 kilometerBox;
        private MaterialSkin.Controls.MaterialLabel endZeitLabel;
        private MaterialSkin.Controls.MaterialTextBox2 endZeitBox;
        private MaterialSkin.Controls.MaterialLabel startZeitLabel;
        private MaterialSkin.Controls.MaterialTextBox2 startZeitBox;
        private MaterialSkin.Controls.MaterialLabel endOrtLabel;
        private MaterialSkin.Controls.MaterialTextBox2 endOrtBox;
        private MaterialSkin.Controls.MaterialLabel startOrtLabel;
        private MaterialSkin.Controls.MaterialTextBox2 startOrtBox;
        private MaterialSkin.Controls.MaterialLabel eNummerLabel;
        private MaterialSkin.Controls.MaterialTextBox2 eNummerBox;
        private MaterialSkin.Controls.MaterialLabel fahrzeugLabel;
        private MaterialSkin.Controls.MaterialComboBox fahrzeugBox;
        private MaterialSkin.Controls.MaterialButton sendBttn;
        private MaterialSkin.Controls.MaterialLabel statsLabel;
        private MaterialSkin.Controls.MaterialLabel adminLabel;
        private ContextMenuStrip locationStripStart;
        private ToolStripMenuItem evStrip;
        private ToolStripMenuItem piusStrip;
        private ToolStripMenuItem koStrip;
        private ToolStripMenuItem leerfahrtStrip;
        private ToolStripMenuItem fehlfahrtSlip;
        private ContextMenuStrip locationStripEnd;
        private ToolStripMenuItem evStripEnd;
        private ToolStripMenuItem piusStripEnd;
        private ToolStripMenuItem klinikumStripEnd;
        private ToolStripMenuItem leerfahrtStripEnd;
        private ToolStripMenuItem fehlfahrtStripEnd;
    }
}