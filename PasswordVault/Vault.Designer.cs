namespace PasswordVaultNS
{
    partial class Vault
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
            System.Windows.Forms.Label userEmailLabel;
            System.Windows.Forms.Label userNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vault));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.userTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vaultDBDataSet = new PasswordVaultNS.VaultDBDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.userTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userEmailTextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.vaultTableDataGridView = new System.Windows.Forms.DataGridView();
            this.onlineAccountNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnlineAccountURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastChangeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaultTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NewAccountButton = new System.Windows.Forms.Button();
            this.RemoveAccountButton = new System.Windows.Forms.Button();
            this.SaveEditButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.searchNameToolStrip = new System.Windows.Forms.ToolStrip();
            this.onlineAccountNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.userTableTableAdapter = new PasswordVaultNS.VaultDBDataSetTableAdapters.UserTableTableAdapter();
            this.tableAdapterManager = new PasswordVaultNS.VaultDBDataSetTableAdapters.TableAdapterManager();
            this.vaultTableTableAdapter = new PasswordVaultNS.VaultDBDataSetTableAdapters.VaultTableTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.refreshDataButton = new System.Windows.Forms.Button();
            userEmailLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingNavigator)).BeginInit();
            this.userTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTableBindingSource)).BeginInit();
            this.searchNameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // userEmailLabel
            // 
            userEmailLabel.AutoSize = true;
            userEmailLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userEmailLabel.Location = new System.Drawing.Point(49, 217);
            userEmailLabel.Name = "userEmailLabel";
            userEmailLabel.Size = new System.Drawing.Size(172, 34);
            userEmailLabel.TabIndex = 8;
            userEmailLabel.Text = "User Email:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            userNameLabel.Location = new System.Drawing.Point(49, 164);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(165, 34);
            userNameLabel.TabIndex = 10;
            userNameLabel.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Password Vault! ";
            // 
            // userTableBindingNavigator
            // 
            this.userTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userTableBindingNavigator.BindingSource = this.userTableBindingSource;
            this.userTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userTableBindingNavigator.Enabled = false;
            this.userTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.userTableBindingNavigatorSaveItem});
            this.userTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userTableBindingNavigator.Name = "userTableBindingNavigator";
            this.userTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userTableBindingNavigator.Size = new System.Drawing.Size(1573, 39);
            this.userTableBindingNavigator.TabIndex = 1;
            this.userTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "UserTable";
            this.userTableBindingSource.DataSource = this.vaultDBDataSet;
            // 
            // vaultDBDataSet
            // 
            this.vaultDBDataSet.DataSetName = "VaultDBDataSet";
            this.vaultDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // userTableBindingNavigatorSaveItem
            // 
            this.userTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userTableBindingNavigatorSaveItem.Image")));
            this.userTableBindingNavigatorSaveItem.Name = "userTableBindingNavigatorSaveItem";
            this.userTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 36);
            this.userTableBindingNavigatorSaveItem.Text = "Save Data";
            this.userTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.userTableBindingNavigatorSaveItem_Click);
            // 
            // userEmailTextBox
            // 
            this.userEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource, "UserEmail", true));
            this.userEmailTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEmailTextBox.Location = new System.Drawing.Point(239, 211);
            this.userEmailTextBox.Name = "userEmailTextBox";
            this.userEmailTextBox.Size = new System.Drawing.Size(309, 42);
            this.userEmailTextBox.TabIndex = 9;
            this.userEmailTextBox.TextChanged += new System.EventHandler(this.userEmailTextBox_TextChanged);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userTableBindingSource, "UserName", true));
            this.userNameTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(239, 163);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(309, 42);
            this.userNameTextBox.TabIndex = 11;
            // 
            // vaultTableDataGridView
            // 
            this.vaultTableDataGridView.AutoGenerateColumns = false;
            this.vaultTableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vaultTableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vaultTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vaultTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.onlineAccountNameDataGridViewTextBoxColumn,
            this.OnlineAccountURL,
            this.passwordDataGridViewTextBoxColumn,
            this.LastChangeDate,
            this.groupIDDataGridViewTextBoxColumn});
            this.vaultTableDataGridView.DataSource = this.vaultTableBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vaultTableDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.vaultTableDataGridView.Location = new System.Drawing.Point(39, 357);
            this.vaultTableDataGridView.Name = "vaultTableDataGridView";
            this.vaultTableDataGridView.RowTemplate.Height = 33;
            this.vaultTableDataGridView.Size = new System.Drawing.Size(1534, 566);
            this.vaultTableDataGridView.TabIndex = 11;
            this.vaultTableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vaultTableDataGridView_CellContentClick);
            // 
            // onlineAccountNameDataGridViewTextBoxColumn
            // 
            this.onlineAccountNameDataGridViewTextBoxColumn.DataPropertyName = "OnlineAccountName";
            this.onlineAccountNameDataGridViewTextBoxColumn.HeaderText = "Account Name";
            this.onlineAccountNameDataGridViewTextBoxColumn.Name = "onlineAccountNameDataGridViewTextBoxColumn";
            this.onlineAccountNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // OnlineAccountURL
            // 
            this.OnlineAccountURL.DataPropertyName = "OnlineAccountURL";
            this.OnlineAccountURL.HeaderText = "Account URL";
            this.OnlineAccountURL.Name = "OnlineAccountURL";
            this.OnlineAccountURL.Width = 200;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // LastChangeDate
            // 
            this.LastChangeDate.DataPropertyName = "LastChangeDate";
            this.LastChangeDate.FillWeight = 200F;
            this.LastChangeDate.HeaderText = "Last Change Date";
            this.LastChangeDate.Name = "LastChangeDate";
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            // 
            // vaultTableBindingSource
            // 
            this.vaultTableBindingSource.DataMember = "FK_VaultTable_ToTable";
            this.vaultTableBindingSource.DataSource = this.userTableBindingSource;
            // 
            // NewAccountButton
            // 
            this.NewAccountButton.Location = new System.Drawing.Point(39, 283);
            this.NewAccountButton.Name = "NewAccountButton";
            this.NewAccountButton.Size = new System.Drawing.Size(198, 73);
            this.NewAccountButton.TabIndex = 12;
            this.NewAccountButton.Text = "New Account";
            this.NewAccountButton.UseVisualStyleBackColor = true;
            this.NewAccountButton.Click += new System.EventHandler(this.newAccountButton_Click);
            // 
            // RemoveAccountButton
            // 
            this.RemoveAccountButton.Location = new System.Drawing.Point(240, 283);
            this.RemoveAccountButton.Name = "RemoveAccountButton";
            this.RemoveAccountButton.Size = new System.Drawing.Size(211, 73);
            this.RemoveAccountButton.TabIndex = 13;
            this.RemoveAccountButton.Text = "Remove Selected Account";
            this.RemoveAccountButton.UseVisualStyleBackColor = true;
            this.RemoveAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // SaveEditButton
            // 
            this.SaveEditButton.Location = new System.Drawing.Point(456, 283);
            this.SaveEditButton.Name = "SaveEditButton";
            this.SaveEditButton.Size = new System.Drawing.Size(214, 73);
            this.SaveEditButton.TabIndex = 14;
            this.SaveEditButton.Text = "Save Edited Account";
            this.SaveEditButton.UseVisualStyleBackColor = true;
            this.SaveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(919, 304);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(293, 42);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.toolstripTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Enter Account Name Search";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // searchNameToolStrip
            // 
            this.searchNameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onlineAccountNameToolStripTextBox});
            this.searchNameToolStrip.Location = new System.Drawing.Point(0, 39);
            this.searchNameToolStrip.Name = "searchNameToolStrip";
            this.searchNameToolStrip.Size = new System.Drawing.Size(1573, 39);
            this.searchNameToolStrip.TabIndex = 17;
            this.searchNameToolStrip.Text = "searchNameToolStrip";
            // 
            // onlineAccountNameToolStripTextBox
            // 
            this.onlineAccountNameToolStripTextBox.Name = "onlineAccountNameToolStripTextBox";
            this.onlineAccountNameToolStripTextBox.Size = new System.Drawing.Size(100, 39);
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PasswordVaultNS.VaultDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableTableAdapter = this.userTableTableAdapter;
            this.tableAdapterManager.VaultTableTableAdapter = this.vaultTableTableAdapter;
            // 
            // vaultTableTableAdapter
            // 
            this.vaultTableTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1218, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 52);
            this.button1.TabIndex = 18;
            this.button1.Text = "SEARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.Location = new System.Drawing.Point(677, 283);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(171, 73);
            this.refreshDataButton.TabIndex = 19;
            this.refreshDataButton.Text = "Refresh Data";
            this.refreshDataButton.UseVisualStyleBackColor = true;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // Vault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1573, 943);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchNameToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SaveEditButton);
            this.Controls.Add(this.RemoveAccountButton);
            this.Controls.Add(this.NewAccountButton);
            this.Controls.Add(this.vaultTableDataGridView);
            this.Controls.Add(userEmailLabel);
            this.Controls.Add(this.userEmailTextBox);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.userTableBindingNavigator);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Vault";
            this.Text = "Password Vault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingNavigator)).EndInit();
            this.userTableBindingNavigator.ResumeLayout(false);
            this.userTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vaultTableBindingSource)).EndInit();
            this.searchNameToolStrip.ResumeLayout(false);
            this.searchNameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private VaultDBDataSet vaultDBDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private VaultDBDataSetTableAdapters.UserTableTableAdapter userTableTableAdapter;
        private VaultDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton userTableBindingNavigatorSaveItem;
        private VaultDBDataSetTableAdapters.VaultTableTableAdapter vaultTableTableAdapter;
        private System.Windows.Forms.TextBox userEmailTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.BindingSource vaultTableBindingSource;
        private System.Windows.Forms.DataGridView vaultTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineAccountURLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastChangeDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button NewAccountButton;
        private System.Windows.Forms.Button RemoveAccountButton;
        private System.Windows.Forms.Button SaveEditButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip searchNameToolStrip;
        private System.Windows.Forms.ToolStripTextBox onlineAccountNameToolStripTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn onlineAccountNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnlineAccountURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastChangeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button refreshDataButton;
    }
}