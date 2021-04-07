namespace DriversApp
{
    partial class NewPersonDL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPersonDL));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label licence_dateLabel;
            System.Windows.Forms.Label expire_dateLabel;
            System.Windows.Forms.Label categoriesLabel;
            System.Windows.Forms.Label licence_seriesLabel;
            System.Windows.Forms.Label licence_numberLabel;
            System.Windows.Forms.Label statusLabel;
            this.driversDataSetNew = new DriversApp.DriversDataSetNew();
            this.driver_licenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.driver_licenceTableAdapter = new DriversApp.DriversDataSetNewTableAdapters.driver_licenceTableAdapter();
            this.tableAdapterManager = new DriversApp.DriversDataSetNewTableAdapters.TableAdapterManager();
            this.driver_licenceBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.driver_licenceBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.licence_dateTextBox = new System.Windows.Forms.TextBox();
            this.expire_dateTextBox = new System.Windows.Forms.TextBox();
            this.categoriesTextBox = new System.Windows.Forms.TextBox();
            this.licence_seriesTextBox = new System.Windows.Forms.TextBox();
            this.licence_numberTextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            licence_dateLabel = new System.Windows.Forms.Label();
            expire_dateLabel = new System.Windows.Forms.Label();
            categoriesLabel = new System.Windows.Forms.Label();
            licence_seriesLabel = new System.Windows.Forms.Label();
            licence_numberLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_licenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_licenceBindingNavigator)).BeginInit();
            this.driver_licenceBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // driversDataSetNew
            // 
            this.driversDataSetNew.DataSetName = "DriversDataSetNew";
            this.driversDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // driver_licenceBindingSource
            // 
            this.driver_licenceBindingSource.DataMember = "driver_licence";
            this.driver_licenceBindingSource.DataSource = this.driversDataSetNew;
            // 
            // driver_licenceTableAdapter
            // 
            this.driver_licenceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AmogusTableAdapter = null;
            this.tableAdapterManager.autoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.driver_licenceTableAdapter = this.driver_licenceTableAdapter;
            this.tableAdapterManager.Log_inTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DriversApp.DriversDataSetNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // driver_licenceBindingNavigator
            // 
            this.driver_licenceBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.driver_licenceBindingNavigator.BindingSource = this.driver_licenceBindingSource;
            this.driver_licenceBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.driver_licenceBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.driver_licenceBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.driver_licenceBindingNavigatorSaveItem});
            this.driver_licenceBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.driver_licenceBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.driver_licenceBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.driver_licenceBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.driver_licenceBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.driver_licenceBindingNavigator.Name = "driver_licenceBindingNavigator";
            this.driver_licenceBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.driver_licenceBindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.driver_licenceBindingNavigator.TabIndex = 0;
            this.driver_licenceBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // driver_licenceBindingNavigatorSaveItem
            // 
            this.driver_licenceBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.driver_licenceBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("driver_licenceBindingNavigatorSaveItem.Image")));
            this.driver_licenceBindingNavigatorSaveItem.Name = "driver_licenceBindingNavigatorSaveItem";
            this.driver_licenceBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.driver_licenceBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.driver_licenceBindingNavigatorSaveItem.Click += new System.EventHandler(this.driver_licenceBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(100, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(222, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // licence_dateLabel
            // 
            licence_dateLabel.AutoSize = true;
            licence_dateLabel.Location = new System.Drawing.Point(12, 66);
            licence_dateLabel.Name = "licence_dateLabel";
            licence_dateLabel.Size = new System.Drawing.Size(68, 13);
            licence_dateLabel.TabIndex = 3;
            licence_dateLabel.Text = "licence date:";
            // 
            // licence_dateTextBox
            // 
            this.licence_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "licence_date", true));
            this.licence_dateTextBox.Location = new System.Drawing.Point(100, 63);
            this.licence_dateTextBox.Name = "licence_dateTextBox";
            this.licence_dateTextBox.Size = new System.Drawing.Size(222, 20);
            this.licence_dateTextBox.TabIndex = 4;
            // 
            // expire_dateLabel
            // 
            expire_dateLabel.AutoSize = true;
            expire_dateLabel.Location = new System.Drawing.Point(12, 92);
            expire_dateLabel.Name = "expire_dateLabel";
            expire_dateLabel.Size = new System.Drawing.Size(62, 13);
            expire_dateLabel.TabIndex = 5;
            expire_dateLabel.Text = "expire date:";
            // 
            // expire_dateTextBox
            // 
            this.expire_dateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "expire_date", true));
            this.expire_dateTextBox.Location = new System.Drawing.Point(100, 89);
            this.expire_dateTextBox.Name = "expire_dateTextBox";
            this.expire_dateTextBox.Size = new System.Drawing.Size(222, 20);
            this.expire_dateTextBox.TabIndex = 6;
            // 
            // categoriesLabel
            // 
            categoriesLabel.AutoSize = true;
            categoriesLabel.Location = new System.Drawing.Point(12, 118);
            categoriesLabel.Name = "categoriesLabel";
            categoriesLabel.Size = new System.Drawing.Size(59, 13);
            categoriesLabel.TabIndex = 7;
            categoriesLabel.Text = "categories:";
            // 
            // categoriesTextBox
            // 
            this.categoriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "categories", true));
            this.categoriesTextBox.Location = new System.Drawing.Point(100, 115);
            this.categoriesTextBox.Name = "categoriesTextBox";
            this.categoriesTextBox.Size = new System.Drawing.Size(222, 20);
            this.categoriesTextBox.TabIndex = 8;
            // 
            // licence_seriesLabel
            // 
            licence_seriesLabel.AutoSize = true;
            licence_seriesLabel.Location = new System.Drawing.Point(12, 144);
            licence_seriesLabel.Name = "licence_seriesLabel";
            licence_seriesLabel.Size = new System.Drawing.Size(74, 13);
            licence_seriesLabel.TabIndex = 9;
            licence_seriesLabel.Text = "licence series:";
            // 
            // licence_seriesTextBox
            // 
            this.licence_seriesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "licence_series", true));
            this.licence_seriesTextBox.Location = new System.Drawing.Point(100, 141);
            this.licence_seriesTextBox.Name = "licence_seriesTextBox";
            this.licence_seriesTextBox.Size = new System.Drawing.Size(222, 20);
            this.licence_seriesTextBox.TabIndex = 10;
            // 
            // licence_numberLabel
            // 
            licence_numberLabel.AutoSize = true;
            licence_numberLabel.Location = new System.Drawing.Point(12, 170);
            licence_numberLabel.Name = "licence_numberLabel";
            licence_numberLabel.Size = new System.Drawing.Size(82, 13);
            licence_numberLabel.TabIndex = 11;
            licence_numberLabel.Text = "licence number:";
            // 
            // licence_numberTextBox
            // 
            this.licence_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "licence_number", true));
            this.licence_numberTextBox.Location = new System.Drawing.Point(100, 167);
            this.licence_numberTextBox.Name = "licence_numberTextBox";
            this.licence_numberTextBox.Size = new System.Drawing.Size(222, 20);
            this.licence_numberTextBox.TabIndex = 12;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(12, 196);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 13;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.driver_licenceBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(100, 193);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(222, 20);
            this.statusTextBox.TabIndex = 14;
            // 
            // NewPersonDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 224);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(licence_dateLabel);
            this.Controls.Add(this.licence_dateTextBox);
            this.Controls.Add(expire_dateLabel);
            this.Controls.Add(this.expire_dateTextBox);
            this.Controls.Add(categoriesLabel);
            this.Controls.Add(this.categoriesTextBox);
            this.Controls.Add(licence_seriesLabel);
            this.Controls.Add(this.licence_seriesTextBox);
            this.Controls.Add(licence_numberLabel);
            this.Controls.Add(this.licence_numberTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.driver_licenceBindingNavigator);
            this.Name = "NewPersonDL";
            this.Text = "NewPersonDL";
            this.Load += new System.EventHandler(this.NewPersonDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_licenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.driver_licenceBindingNavigator)).EndInit();
            this.driver_licenceBindingNavigator.ResumeLayout(false);
            this.driver_licenceBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DriversDataSetNew driversDataSetNew;
        private System.Windows.Forms.BindingSource driver_licenceBindingSource;
        private DriversDataSetNewTableAdapters.driver_licenceTableAdapter driver_licenceTableAdapter;
        private DriversDataSetNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator driver_licenceBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton driver_licenceBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox licence_dateTextBox;
        private System.Windows.Forms.TextBox expire_dateTextBox;
        private System.Windows.Forms.TextBox categoriesTextBox;
        private System.Windows.Forms.TextBox licence_seriesTextBox;
        private System.Windows.Forms.TextBox licence_numberTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}