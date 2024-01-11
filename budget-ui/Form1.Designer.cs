namespace budget_ui
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            listBox1 = new ListBox();
            splitContainer2 = new SplitContainer();
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            itemDateGroup = new GroupBox();
            itemDate = new DateTimePicker();
            itemSourceGroup = new GroupBox();
            itemSourceCombo = new ComboBox();
            itemAmountGroup = new GroupBox();
            splitContainer3 = new SplitContainer();
            itemAmountNumberField = new TextBox();
            itemAmountCurrencyCombo = new ComboBox();
            itemDestinationGroup = new GroupBox();
            itemDestinationCombo = new ComboBox();
            itemDestinationAmountGroup = new GroupBox();
            splitContainer4 = new SplitContainer();
            itemDestinationAmountNumberField = new TextBox();
            itemDestinationAmountCurrencyCombo = new ComboBox();
            itemCategoryGroup = new GroupBox();
            itemCategoryCombo = new ComboBox();
            itemNotesGroup = new GroupBox();
            itemNotesField = new TextBox();
            itemSaveButton = new Button();
            itemCancelButton = new Button();
            toolStrip1 = new ToolStrip();
            newItemButton = new ToolStripButton();
            updateItemButton = new ToolStripButton();
            deleteItemButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            itemDateGroup.SuspendLayout();
            itemSourceGroup.SuspendLayout();
            itemAmountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            itemDestinationGroup.SuspendLayout();
            itemDestinationAmountGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            itemCategoryGroup.SuspendLayout();
            itemNotesGroup.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Panel2.Controls.Add(toolStrip1);
            splitContainer1.Size = new Size(1069, 628);
            splitContainer1.SplitterDistance = 200;
            splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Fill;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "(PH) Home", "(PH) Assets & Liabilities", "(PH) Categories", "(PH) Sources & Sinks", "Incomes", "Expenses", "Transfers", "Exchanges", "Allocations" });
            listBox1.Location = new Point(0, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 628);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 25);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(865, 603);
            splitContainer2.SplitterDistance = 640;
            splitContainer2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(640, 603);
            dataGridView1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(itemDateGroup);
            flowLayoutPanel1.Controls.Add(itemSourceGroup);
            flowLayoutPanel1.Controls.Add(itemAmountGroup);
            flowLayoutPanel1.Controls.Add(itemDestinationGroup);
            flowLayoutPanel1.Controls.Add(itemDestinationAmountGroup);
            flowLayoutPanel1.Controls.Add(itemCategoryGroup);
            flowLayoutPanel1.Controls.Add(itemNotesGroup);
            flowLayoutPanel1.Controls.Add(itemSaveButton);
            flowLayoutPanel1.Controls.Add(itemCancelButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(221, 603);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // itemDateGroup
            // 
            itemDateGroup.Controls.Add(itemDate);
            itemDateGroup.Location = new Point(3, 3);
            itemDateGroup.Name = "itemDateGroup";
            itemDateGroup.Size = new Size(200, 50);
            itemDateGroup.TabIndex = 0;
            itemDateGroup.TabStop = false;
            itemDateGroup.Text = "Date";
            // 
            // itemDate
            // 
            itemDate.Dock = DockStyle.Fill;
            itemDate.Format = DateTimePickerFormat.Short;
            itemDate.Location = new Point(3, 19);
            itemDate.Name = "itemDate";
            itemDate.Size = new Size(194, 23);
            itemDate.TabIndex = 0;
            // 
            // itemSourceGroup
            // 
            itemSourceGroup.Controls.Add(itemSourceCombo);
            itemSourceGroup.Location = new Point(3, 59);
            itemSourceGroup.Name = "itemSourceGroup";
            itemSourceGroup.Size = new Size(200, 50);
            itemSourceGroup.TabIndex = 1;
            itemSourceGroup.TabStop = false;
            itemSourceGroup.Text = "Source";
            // 
            // itemSourceCombo
            // 
            itemSourceCombo.Dock = DockStyle.Fill;
            itemSourceCombo.FormattingEnabled = true;
            itemSourceCombo.Location = new Point(3, 19);
            itemSourceCombo.Name = "itemSourceCombo";
            itemSourceCombo.Size = new Size(194, 23);
            itemSourceCombo.TabIndex = 0;
            // 
            // itemAmountGroup
            // 
            itemAmountGroup.Controls.Add(splitContainer3);
            itemAmountGroup.Location = new Point(3, 115);
            itemAmountGroup.Name = "itemAmountGroup";
            itemAmountGroup.Size = new Size(200, 50);
            itemAmountGroup.TabIndex = 2;
            itemAmountGroup.TabStop = false;
            itemAmountGroup.Text = "Amount";
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 19);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(itemAmountNumberField);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(itemAmountCurrencyCombo);
            splitContainer3.Size = new Size(194, 28);
            splitContainer3.SplitterDistance = 146;
            splitContainer3.TabIndex = 0;
            splitContainer3.SplitterMoved += splitContainer3_SplitterMoved;
            // 
            // itemAmountNumberField
            // 
            itemAmountNumberField.Dock = DockStyle.Fill;
            itemAmountNumberField.Location = new Point(0, 0);
            itemAmountNumberField.Name = "itemAmountNumberField";
            itemAmountNumberField.Size = new Size(146, 23);
            itemAmountNumberField.TabIndex = 0;
            // 
            // itemAmountCurrencyCombo
            // 
            itemAmountCurrencyCombo.Dock = DockStyle.Fill;
            itemAmountCurrencyCombo.FormattingEnabled = true;
            itemAmountCurrencyCombo.Location = new Point(0, 0);
            itemAmountCurrencyCombo.Name = "itemAmountCurrencyCombo";
            itemAmountCurrencyCombo.Size = new Size(44, 23);
            itemAmountCurrencyCombo.TabIndex = 0;
            // 
            // itemDestinationGroup
            // 
            itemDestinationGroup.Controls.Add(itemDestinationCombo);
            itemDestinationGroup.Location = new Point(3, 171);
            itemDestinationGroup.Name = "itemDestinationGroup";
            itemDestinationGroup.Size = new Size(200, 50);
            itemDestinationGroup.TabIndex = 3;
            itemDestinationGroup.TabStop = false;
            itemDestinationGroup.Text = "Destination";
            // 
            // itemDestinationCombo
            // 
            itemDestinationCombo.Dock = DockStyle.Fill;
            itemDestinationCombo.FormattingEnabled = true;
            itemDestinationCombo.Location = new Point(3, 19);
            itemDestinationCombo.Name = "itemDestinationCombo";
            itemDestinationCombo.Size = new Size(194, 23);
            itemDestinationCombo.TabIndex = 0;
            // 
            // itemDestinationAmountGroup
            // 
            itemDestinationAmountGroup.Controls.Add(splitContainer4);
            itemDestinationAmountGroup.Location = new Point(3, 227);
            itemDestinationAmountGroup.Name = "itemDestinationAmountGroup";
            itemDestinationAmountGroup.Size = new Size(200, 50);
            itemDestinationAmountGroup.TabIndex = 4;
            itemDestinationAmountGroup.TabStop = false;
            itemDestinationAmountGroup.Text = "Destination Amount";
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(3, 19);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(itemDestinationAmountNumberField);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(itemDestinationAmountCurrencyCombo);
            splitContainer4.Size = new Size(194, 28);
            splitContainer4.SplitterDistance = 146;
            splitContainer4.TabIndex = 0;
            // 
            // itemDestinationAmountNumberField
            // 
            itemDestinationAmountNumberField.Dock = DockStyle.Fill;
            itemDestinationAmountNumberField.Location = new Point(0, 0);
            itemDestinationAmountNumberField.Name = "itemDestinationAmountNumberField";
            itemDestinationAmountNumberField.Size = new Size(146, 23);
            itemDestinationAmountNumberField.TabIndex = 0;
            // 
            // itemDestinationAmountCurrencyCombo
            // 
            itemDestinationAmountCurrencyCombo.Dock = DockStyle.Fill;
            itemDestinationAmountCurrencyCombo.FormattingEnabled = true;
            itemDestinationAmountCurrencyCombo.Location = new Point(0, 0);
            itemDestinationAmountCurrencyCombo.Name = "itemDestinationAmountCurrencyCombo";
            itemDestinationAmountCurrencyCombo.Size = new Size(44, 23);
            itemDestinationAmountCurrencyCombo.TabIndex = 0;
            // 
            // itemCategoryGroup
            // 
            itemCategoryGroup.Controls.Add(itemCategoryCombo);
            itemCategoryGroup.Location = new Point(3, 283);
            itemCategoryGroup.Name = "itemCategoryGroup";
            itemCategoryGroup.Size = new Size(200, 50);
            itemCategoryGroup.TabIndex = 5;
            itemCategoryGroup.TabStop = false;
            itemCategoryGroup.Text = "Category";
            // 
            // itemCategoryCombo
            // 
            itemCategoryCombo.Dock = DockStyle.Fill;
            itemCategoryCombo.FormattingEnabled = true;
            itemCategoryCombo.Location = new Point(3, 19);
            itemCategoryCombo.Name = "itemCategoryCombo";
            itemCategoryCombo.Size = new Size(194, 23);
            itemCategoryCombo.TabIndex = 0;
            // 
            // itemNotesGroup
            // 
            itemNotesGroup.Controls.Add(itemNotesField);
            itemNotesGroup.Location = new Point(3, 339);
            itemNotesGroup.Name = "itemNotesGroup";
            itemNotesGroup.Size = new Size(200, 50);
            itemNotesGroup.TabIndex = 6;
            itemNotesGroup.TabStop = false;
            itemNotesGroup.Text = "Notes";
            // 
            // itemNotesField
            // 
            itemNotesField.Dock = DockStyle.Fill;
            itemNotesField.Location = new Point(3, 19);
            itemNotesField.Name = "itemNotesField";
            itemNotesField.Size = new Size(194, 23);
            itemNotesField.TabIndex = 0;
            // 
            // itemSaveButton
            // 
            itemSaveButton.Location = new Point(3, 395);
            itemSaveButton.Name = "itemSaveButton";
            itemSaveButton.Size = new Size(75, 23);
            itemSaveButton.TabIndex = 7;
            itemSaveButton.Text = "Save";
            itemSaveButton.UseVisualStyleBackColor = true;
            // 
            // itemCancelButton
            // 
            itemCancelButton.Location = new Point(84, 395);
            itemCancelButton.Name = "itemCancelButton";
            itemCancelButton.Size = new Size(75, 23);
            itemCancelButton.TabIndex = 8;
            itemCancelButton.Text = "Cancel";
            itemCancelButton.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { newItemButton, updateItemButton, deleteItemButton });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(865, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // newItemButton
            // 
            newItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            newItemButton.Image = (Image)resources.GetObject("newItemButton.Image");
            newItemButton.ImageTransparentColor = Color.Magenta;
            newItemButton.Name = "newItemButton";
            newItemButton.Size = new Size(23, 22);
            newItemButton.Text = "newItemButton";
            newItemButton.ToolTipText = "Create entry";
            // 
            // updateItemButton
            // 
            updateItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            updateItemButton.Image = (Image)resources.GetObject("updateItemButton.Image");
            updateItemButton.ImageTransparentColor = Color.Magenta;
            updateItemButton.Name = "updateItemButton";
            updateItemButton.Size = new Size(23, 22);
            updateItemButton.Text = "updateItemButton";
            updateItemButton.ToolTipText = "Update selected entry";
            // 
            // deleteItemButton
            // 
            deleteItemButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteItemButton.Image = (Image)resources.GetObject("deleteItemButton.Image");
            deleteItemButton.ImageTransparentColor = Color.Magenta;
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(23, 22);
            deleteItemButton.Text = "deleteItemButton";
            deleteItemButton.ToolTipText = "Delete selected entry";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 628);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            itemDateGroup.ResumeLayout(false);
            itemSourceGroup.ResumeLayout(false);
            itemAmountGroup.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            itemDestinationGroup.ResumeLayout(false);
            itemDestinationAmountGroup.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            itemCategoryGroup.ResumeLayout(false);
            itemNotesGroup.ResumeLayout(false);
            itemNotesGroup.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ListBox listBox1;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton newItemButton;
        private ToolStripButton updateItemButton;
        private ToolStripButton deleteItemButton;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox itemDateGroup;
        private DateTimePicker itemDate;
        private GroupBox itemAmountGroup;
        private SplitContainer splitContainer3;
        private TextBox itemAmountNumberField;
        private GroupBox itemCategoryGroup;
        private ComboBox itemCategoryCombo;
        private GroupBox itemSourceGroup;
        private ComboBox itemSourceCombo;
        private GroupBox itemDestinationGroup;
        private ComboBox itemDestinationCombo;
        private GroupBox itemDestinationAmountGroup;
        private SplitContainer splitContainer4;
        private TextBox itemDestinationAmountNumberField;
        private ComboBox itemAmountCurrencyCombo;
        private ComboBox itemDestinationAmountCurrencyCombo;
        private GroupBox itemNotesGroup;
        private TextBox itemNotesField;
        private Button itemSaveButton;
        private Button itemCancelButton;
    }
}
