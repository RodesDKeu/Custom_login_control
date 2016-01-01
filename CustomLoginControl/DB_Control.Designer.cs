namespace CustomLoginControl
{
    partial class DB_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DB_Control));
            this._UserDBDataSet = new CustomLoginControl._UserDBDataSet();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userInfoTableAdapter = new CustomLoginControl._UserDBDataSetTableAdapters.UserInfoTableAdapter();
            this.tableAdapterManager = new CustomLoginControl._UserDBDataSetTableAdapters.TableAdapterManager();
            this.userInfoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.userInfoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.userInfoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchUsernameToolStrip = new System.Windows.Forms.ToolStrip();
            this.userNameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userNameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchUsernameToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._UserDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingNavigator)).BeginInit();
            this.userInfoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataGridView)).BeginInit();
            this.searchUsernameToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // _UserDBDataSet
            // 
            this._UserDBDataSet.DataSetName = "_UserDBDataSet";
            this._UserDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this._UserDBDataSet;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = CustomLoginControl._UserDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserInfoTableAdapter = this.userInfoTableAdapter;
            // 
            // userInfoBindingNavigator
            // 
            this.userInfoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.userInfoBindingNavigator.BindingSource = this.userInfoBindingSource;
            this.userInfoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.userInfoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.userInfoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.userInfoBindingNavigatorSaveItem});
            this.userInfoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.userInfoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.userInfoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.userInfoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.userInfoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.userInfoBindingNavigator.Name = "userInfoBindingNavigator";
            this.userInfoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.userInfoBindingNavigator.Size = new System.Drawing.Size(728, 25);
            this.userInfoBindingNavigator.TabIndex = 0;
            this.userInfoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // userInfoBindingNavigatorSaveItem
            // 
            this.userInfoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.userInfoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("userInfoBindingNavigatorSaveItem.Image")));
            this.userInfoBindingNavigatorSaveItem.Name = "userInfoBindingNavigatorSaveItem";
            this.userInfoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.userInfoBindingNavigatorSaveItem.Text = "Save Data";
            this.userInfoBindingNavigatorSaveItem.Click += new System.EventHandler(this.userInfoBindingNavigatorSaveItem_Click);
            // 
            // userInfoDataGridView
            // 
            this.userInfoDataGridView.AutoGenerateColumns = false;
            this.userInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.userInfoDataGridView.DataSource = this.userInfoBindingSource;
            this.userInfoDataGridView.Location = new System.Drawing.Point(263, 194);
            this.userInfoDataGridView.Name = "userInfoDataGridView";
            this.userInfoDataGridView.Size = new System.Drawing.Size(445, 220);
            this.userInfoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
            this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn3.HeaderText = "Password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn4.HeaderText = "Email";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // searchUsernameToolStrip
            // 
            this.searchUsernameToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userNameToolStripLabel,
            this.userNameToolStripTextBox,
            this.searchUsernameToolStripButton});
            this.searchUsernameToolStrip.Location = new System.Drawing.Point(0, 25);
            this.searchUsernameToolStrip.Name = "searchUsernameToolStrip";
            this.searchUsernameToolStrip.Size = new System.Drawing.Size(728, 25);
            this.searchUsernameToolStrip.TabIndex = 2;
            this.searchUsernameToolStrip.Text = "searchUsernameToolStrip";
            // 
            // userNameToolStripLabel
            // 
            this.userNameToolStripLabel.Name = "userNameToolStripLabel";
            this.userNameToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.userNameToolStripLabel.Text = "UserName:";
            // 
            // userNameToolStripTextBox
            // 
            this.userNameToolStripTextBox.Name = "userNameToolStripTextBox";
            this.userNameToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // searchUsernameToolStripButton
            // 
            this.searchUsernameToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.searchUsernameToolStripButton.Name = "searchUsernameToolStripButton";
            this.searchUsernameToolStripButton.Size = new System.Drawing.Size(99, 19);
            this.searchUsernameToolStripButton.Text = "SearchUsername";
            this.searchUsernameToolStripButton.Click += new System.EventHandler(this.searchUsernameToolStripButton_Click);
            // 
            // DB_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 434);
            this.Controls.Add(this.searchUsernameToolStrip);
            this.Controls.Add(this.userInfoDataGridView);
            this.Controls.Add(this.userInfoBindingNavigator);
            this.Name = "DB_Control";
            this.Text = "DB_Control";
            this.Load += new System.EventHandler(this.DB_Control_Load);
            ((System.ComponentModel.ISupportInitialize)(this._UserDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingNavigator)).EndInit();
            this.userInfoBindingNavigator.ResumeLayout(false);
            this.userInfoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDataGridView)).EndInit();
            this.searchUsernameToolStrip.ResumeLayout(false);
            this.searchUsernameToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _UserDBDataSet _UserDBDataSet;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private _UserDBDataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private _UserDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator userInfoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton userInfoBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView userInfoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStrip searchUsernameToolStrip;
        private System.Windows.Forms.ToolStripLabel userNameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userNameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton searchUsernameToolStripButton;

    }
}