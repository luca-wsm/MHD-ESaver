using System.Drawing;
using System.Windows.Forms;

namespace MHD_ESaver
{
    partial class AllEntriesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllEntriesForm));
            dataView = new MaterialSkin.Controls.MaterialListView();
            datumHeader = new ColumnHeader();
            fahrzeugHeader = new ColumnHeader();
            eNummerHeader = new ColumnHeader();
            startOrtHeader = new ColumnHeader();
            endortHeader = new ColumnHeader();
            startZeitHeader = new ColumnHeader();
            endZeitHeader = new ColumnHeader();
            kmHeader = new ColumnHeader();
            fahrerBeifahrerHeader = new ColumnHeader();
            arztHeader = new ColumnHeader();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AutoSizeTable = false;
            dataView.BackColor = Color.FromArgb(255, 255, 255);
            dataView.BorderStyle = BorderStyle.None;
            dataView.Columns.AddRange(new ColumnHeader[] { datumHeader, fahrzeugHeader, eNummerHeader, startOrtHeader, endortHeader, startZeitHeader, endZeitHeader, kmHeader, fahrerBeifahrerHeader, arztHeader });
            dataView.Depth = 0;
            dataView.FullRowSelect = true;
            dataView.Location = new Point(13, 74);
            dataView.Margin = new Padding(10);
            dataView.MinimumSize = new Size(200, 100);
            dataView.MouseLocation = new Point(-1, -1);
            dataView.MouseState = MaterialSkin.MouseState.OUT;
            dataView.MultiSelect = false;
            dataView.Name = "dataView";
            dataView.OwnerDraw = true;
            dataView.Size = new Size(1530, 928);
            dataView.TabIndex = 0;
            dataView.UseCompatibleStateImageBehavior = false;
            dataView.View = View.Details;
            // 
            // datumHeader
            // 
            datumHeader.Text = "Datum";
            datumHeader.Width = 190;
            // 
            // fahrzeugHeader
            // 
            fahrzeugHeader.Text = "Fahrzeug";
            fahrzeugHeader.Width = 100;
            // 
            // eNummerHeader
            // 
            eNummerHeader.Text = "E-Nummer";
            eNummerHeader.TextAlign = HorizontalAlignment.Center;
            eNummerHeader.Width = 220;
            // 
            // startOrtHeader
            // 
            startOrtHeader.Text = "Startort";
            startOrtHeader.Width = 220;
            // 
            // endortHeader
            // 
            endortHeader.Text = "Endort";
            endortHeader.Width = 220;
            // 
            // startZeitHeader
            // 
            startZeitHeader.Text = "Startzeit";
            startZeitHeader.Width = 100;
            // 
            // endZeitHeader
            // 
            endZeitHeader.Text = "Endzeit";
            endZeitHeader.TextAlign = HorizontalAlignment.Right;
            endZeitHeader.Width = 100;
            // 
            // kmHeader
            // 
            kmHeader.Text = "KM";
            kmHeader.TextAlign = HorizontalAlignment.Right;
            // 
            // fahrerBeifahrerHeader
            // 
            fahrerBeifahrerHeader.Text = "Fahrer, Beifahrer";
            fahrerBeifahrerHeader.Width = 220;
            // 
            // arztHeader
            // 
            arztHeader.Text = "Notarzt";
            arztHeader.Width = 100;
            // 
            // AllEntriesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1557, 1018);
            Controls.Add(dataView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AllEntriesForm";
            Sizable = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACP ESaver | Alle Einsätze";
            Load += AllEntriesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialListView dataView;
        private ColumnHeader datumHeader;
        private ColumnHeader fahrzeugHeader;
        private ColumnHeader eNummerHeader;
        private ColumnHeader startOrtHeader;
        private ColumnHeader endortHeader;
        private ColumnHeader startZeitHeader;
        private ColumnHeader endZeitHeader;
        private ColumnHeader fahrerBeifahrerHeader;
        private ColumnHeader kmHeader;
        private ColumnHeader arztHeader;
    }
}