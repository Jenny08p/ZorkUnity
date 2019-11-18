namespace Zork_Builder
{
    partial class Zork_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveCtrlSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel_Buttons = new System.Windows.Forms.FlowLayoutPanel();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.startingLocationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTab = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.eastNeighborControl = new Zork_Builder.NeighborControl();
            this.westNeighborControl = new Zork_Builder.NeighborControl();
            this.southNeighborControl = new Zork_Builder.NeighborControl();
            this.northNeighborControl = new Zork_Builder.NeighborControl();
            this.deleteRoomButton = new System.Windows.Forms.Button();
            this.addRoomButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.startingLocationComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.roomsListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.roomDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.roomNameTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.playToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(611, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorldToolStripMenuItem,
            this.openWorldToolStripMenuItem,
            this.closeWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveCtrlSToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(46, 24);
            this.FileMenu.Text = "File";
            // 
            // newWorldToolStripMenuItem
            // 
            this.newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            this.newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.newWorldToolStripMenuItem.Text = "New World";
            // 
            // openWorldToolStripMenuItem
            // 
            this.openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            this.openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.openWorldToolStripMenuItem.Text = "Open World";
            this.openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // closeWorldToolStripMenuItem
            // 
            this.closeWorldToolStripMenuItem.Name = "closeWorldToolStripMenuItem";
            this.closeWorldToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.closeWorldToolStripMenuItem.Text = "Close";
            this.closeWorldToolStripMenuItem.Click += new System.EventHandler(this.CloseWorldToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(261, 6);
            // 
            // saveCtrlSToolStripMenuItem
            // 
            this.saveCtrlSToolStripMenuItem.Name = "saveCtrlSToolStripMenuItem";
            this.saveCtrlSToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveCtrlSToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveCtrlSToolStripMenuItem.Text = "Save... ";
            this.saveCtrlSToolStripMenuItem.Click += new System.EventHandler(this.SaveCtrlSToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(264, 26);
            this.saveAsToolStripMenuItem.Text = "Save as...      ";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.playToolStripMenuItem.Text = "Play ";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Work Files (*json)|*.json";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(561, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(77, 24);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // flowLayoutPanel_Buttons
            // 
            this.flowLayoutPanel_Buttons.AutoSize = true;
            this.flowLayoutPanel_Buttons.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Buttons.Location = new System.Drawing.Point(0, 28);
            this.flowLayoutPanel_Buttons.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel_Buttons.Name = "flowLayoutPanel_Buttons";
            this.flowLayoutPanel_Buttons.Size = new System.Drawing.Size(611, 0);
            this.flowLayoutPanel_Buttons.TabIndex = 6;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataSource = typeof(Zork_Common.Room);
            // 
            // startingLocationsBindingSource
            // 
            this.startingLocationsBindingSource.DataMember = "StartingLocations";
            this.startingLocationsBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork_Builder.WorldViewModel);
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tabPage2);
            this.mainTab.Location = new System.Drawing.Point(0, 36);
            this.mainTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(597, 478);
            this.mainTab.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.eastNeighborControl);
            this.tabPage2.Controls.Add(this.westNeighborControl);
            this.tabPage2.Controls.Add(this.southNeighborControl);
            this.tabPage2.Controls.Add(this.northNeighborControl);
            this.tabPage2.Controls.Add(this.deleteRoomButton);
            this.tabPage2.Controls.Add(this.addRoomButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.startingLocationComboBox);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.roomsListBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.roomDescriptionTextBox);
            this.tabPage2.Controls.Add(this.roomNameTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(589, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rooms";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // eastNeighborControl
            // 
            this.eastNeighborControl.AllowDrop = true;
            this.eastNeighborControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.eastNeighborControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.eastNeighborControl.Direction = Zork_Common.Directions.East;
            this.eastNeighborControl.Location = new System.Drawing.Point(171, 306);
            this.eastNeighborControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eastNeighborControl.Name = "eastNeighborControl";
            this.eastNeighborControl.Neighbor = null;
            this.eastNeighborControl.Room = null;
            this.eastNeighborControl.Size = new System.Drawing.Size(160, 64);
            this.eastNeighborControl.TabIndex = 21;
            // 
            // westNeighborControl
            // 
            this.westNeighborControl.AllowDrop = true;
            this.westNeighborControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.westNeighborControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.westNeighborControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.westNeighborControl.Direction = Zork_Common.Directions.West;
            this.westNeighborControl.Location = new System.Drawing.Point(15, 306);
            this.westNeighborControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.westNeighborControl.Name = "westNeighborControl";
            this.westNeighborControl.Neighbor = null;
            this.westNeighborControl.Room = null;
            this.westNeighborControl.Size = new System.Drawing.Size(150, 64);
            this.westNeighborControl.TabIndex = 20;
            // 
            // southNeighborControl
            // 
            this.southNeighborControl.AllowDrop = true;
            this.southNeighborControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.southNeighborControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.southNeighborControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.southNeighborControl.Direction = Zork_Common.Directions.South;
            this.southNeighborControl.Location = new System.Drawing.Point(171, 236);
            this.southNeighborControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.southNeighborControl.Name = "southNeighborControl";
            this.southNeighborControl.Neighbor = null;
            this.southNeighborControl.Room = null;
            this.southNeighborControl.Size = new System.Drawing.Size(150, 66);
            this.southNeighborControl.TabIndex = 18;
            // 
            // northNeighborControl
            // 
            this.northNeighborControl.AllowDrop = true;
            this.northNeighborControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.northNeighborControl.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.northNeighborControl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.northNeighborControl.Direction = Zork_Common.Directions.North;
            this.northNeighborControl.Location = new System.Drawing.Point(15, 236);
            this.northNeighborControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.northNeighborControl.Name = "northNeighborControl";
            this.northNeighborControl.Neighbor = null;
            this.northNeighborControl.Room = null;
            this.northNeighborControl.Size = new System.Drawing.Size(150, 66);
            this.northNeighborControl.TabIndex = 17;
            // 
            // deleteRoomButton
            // 
            this.deleteRoomButton.Location = new System.Drawing.Point(434, 412);
            this.deleteRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteRoomButton.Name = "deleteRoomButton";
            this.deleteRoomButton.Size = new System.Drawing.Size(75, 23);
            this.deleteRoomButton.TabIndex = 16;
            this.deleteRoomButton.Text = "&Delete";
            this.deleteRoomButton.UseVisualStyleBackColor = true;
            this.deleteRoomButton.Click += new System.EventHandler(this.deleteRoomButton_Click);
            // 
            // addRoomButton
            // 
            this.addRoomButton.Location = new System.Drawing.Point(345, 412);
            this.addRoomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addRoomButton.Name = "addRoomButton";
            this.addRoomButton.Size = new System.Drawing.Size(75, 23);
            this.addRoomButton.TabIndex = 15;
            this.addRoomButton.Text = "&Add...";
            this.addRoomButton.UseVisualStyleBackColor = true;
            this.addRoomButton.Click += new System.EventHandler(this.addRoomButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Starting Location";
            // 
            // startingLocationComboBox
            // 
            this.startingLocationComboBox.FormattingEnabled = true;
            this.startingLocationComboBox.Location = new System.Drawing.Point(345, 53);
            this.startingLocationComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startingLocationComboBox.Name = "startingLocationComboBox";
            this.startingLocationComboBox.Size = new System.Drawing.Size(209, 24);
            this.startingLocationComboBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rooms";
            // 
            // roomsListBox
            // 
            this.roomsListBox.DataSource = this.roomsBindingSource;
            this.roomsListBox.DisplayMember = "Name";
            this.roomsListBox.FormattingEnabled = true;
            this.roomsListBox.ItemHeight = 16;
            this.roomsListBox.Location = new System.Drawing.Point(345, 100);
            this.roomsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsListBox.Name = "roomsListBox";
            this.roomsListBox.ScrollAlwaysVisible = true;
            this.roomsListBox.Size = new System.Drawing.Size(209, 308);
            this.roomsListBox.TabIndex = 10;
            this.roomsListBox.ValueMember = "Description";
            this.roomsListBox.SelectedIndexChanged += new System.EventHandler(this.RoomsListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // roomDescriptionTextBox
            // 
            this.roomDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.roomDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomDescriptionTextBox.Location = new System.Drawing.Point(15, 101);
            this.roomDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomDescriptionTextBox.Multiline = true;
            this.roomDescriptionTextBox.Name = "roomDescriptionTextBox";
            this.roomDescriptionTextBox.Size = new System.Drawing.Size(306, 131);
            this.roomDescriptionTextBox.TabIndex = 6;
            // 
            // roomNameTextBox
            // 
            this.roomNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roomsBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.roomNameTextBox.Location = new System.Drawing.Point(15, 57);
            this.roomNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.Size = new System.Drawing.Size(306, 22);
            this.roomNameTextBox.TabIndex = 5;
            this.roomNameTextBox.TextChanged += new System.EventHandler(this.roomNameTextBox_TextChanged);
            // 
            // Zork_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(611, 514);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.flowLayoutPanel_Buttons);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Zork_Form";
            this.Text = "Zork_Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startingLocationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeWorldToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveCtrlSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Buttons;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.BindingSource startingLocationsBindingSource;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private NeighborControl westNeighborControl;
        private NeighborControl southNeighborControl;
        private NeighborControl northNeighborControl;
        private System.Windows.Forms.Button deleteRoomButton;
        private System.Windows.Forms.Button addRoomButton;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox startingLocationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox roomsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox roomDescriptionTextBox;
        private System.Windows.Forms.TextBox roomNameTextBox;
        private NeighborControl eastNeighborControl;
    }
}

