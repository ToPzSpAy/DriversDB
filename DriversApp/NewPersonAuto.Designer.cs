namespace DriversApp
{
    partial class NewPersonAuto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPersonAuto));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label vINLabel;
            System.Windows.Forms.Label manufacturerLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label yearLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label engine_TypeLabel;
            System.Windows.Forms.Label type_of_driveLabel;
            this.driversDataSetNew = new DriversApp.DriversDataSetNew();
            this.autoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autoTableAdapter = new DriversApp.DriversDataSetNewTableAdapters.autoTableAdapter();
            this.tableAdapterManager = new DriversApp.DriversDataSetNewTableAdapters.TableAdapterManager();
            this.autoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.autoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.vINTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerTextBox = new System.Windows.Forms.TextBox();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.engine_TypeTextBox = new System.Windows.Forms.TextBox();
            this.type_of_driveTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            vINLabel = new System.Windows.Forms.Label();
            manufacturerLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            engine_TypeLabel = new System.Windows.Forms.Label();
            type_of_driveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSetNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingNavigator)).BeginInit();
            this.autoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // driversDataSetNew
            // 
            this.driversDataSetNew.DataSetName = "DriversDataSetNew";
            this.driversDataSetNew.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autoBindingSource
            // 
            this.autoBindingSource.DataMember = "auto";
            this.autoBindingSource.DataSource = this.driversDataSetNew;
            // 
            // autoTableAdapter
            // 
            this.autoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AmogusTableAdapter = null;
            this.tableAdapterManager.autoTableAdapter = this.autoTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.driver_licenceTableAdapter = null;
            this.tableAdapterManager.Log_inTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DriversApp.DriversDataSetNewTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // autoBindingNavigator
            // 
            this.autoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.autoBindingNavigator.BindingSource = this.autoBindingSource;
            this.autoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.autoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.autoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.autoBindingNavigatorSaveItem});
            this.autoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.autoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.autoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.autoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.autoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.autoBindingNavigator.Name = "autoBindingNavigator";
            this.autoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.autoBindingNavigator.Size = new System.Drawing.Size(334, 25);
            this.autoBindingNavigator.TabIndex = 0;
            this.autoBindingNavigator.Text = "bindingNavigator1";
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
            // autoBindingNavigatorSaveItem
            // 
            this.autoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.autoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("autoBindingNavigatorSaveItem.Image")));
            this.autoBindingNavigatorSaveItem.Name = "autoBindingNavigatorSaveItem";
            this.autoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.autoBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.autoBindingNavigatorSaveItem.Click += new System.EventHandler(this.autoBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(12, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(91, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(221, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // vINLabel
            // 
            vINLabel.AutoSize = true;
            vINLabel.Location = new System.Drawing.Point(12, 63);
            vINLabel.Name = "vINLabel";
            vINLabel.Size = new System.Drawing.Size(28, 13);
            vINLabel.TabIndex = 3;
            vINLabel.Text = "VIN:";
            // 
            // vINTextBox
            // 
            this.vINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "VIN", true));
            this.vINTextBox.Location = new System.Drawing.Point(91, 60);
            this.vINTextBox.Name = "vINTextBox";
            this.vINTextBox.Size = new System.Drawing.Size(221, 20);
            this.vINTextBox.TabIndex = 4;
            // 
            // manufacturerLabel
            // 
            manufacturerLabel.AutoSize = true;
            manufacturerLabel.Location = new System.Drawing.Point(12, 89);
            manufacturerLabel.Name = "manufacturerLabel";
            manufacturerLabel.Size = new System.Drawing.Size(73, 13);
            manufacturerLabel.TabIndex = 5;
            manufacturerLabel.Text = "Manufacturer:";
            // 
            // manufacturerTextBox
            // 
            this.manufacturerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Manufacturer", true));
            this.manufacturerTextBox.Location = new System.Drawing.Point(91, 86);
            this.manufacturerTextBox.Name = "manufacturerTextBox";
            this.manufacturerTextBox.Size = new System.Drawing.Size(221, 20);
            this.manufacturerTextBox.TabIndex = 6;
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(12, 115);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 7;
            modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Model", true));
            this.modelTextBox.Location = new System.Drawing.Point(91, 112);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(221, 20);
            this.modelTextBox.TabIndex = 8;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(12, 141);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 9;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(91, 138);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(221, 20);
            this.yearTextBox.TabIndex = 10;
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(12, 167);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 11;
            weightLabel.Text = "Weight:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(91, 164);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(221, 20);
            this.weightTextBox.TabIndex = 12;
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 193);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(34, 13);
            colorLabel.TabIndex = 13;
            colorLabel.Text = "Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Color", true));
            this.colorTextBox.Location = new System.Drawing.Point(91, 190);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(221, 20);
            this.colorTextBox.TabIndex = 14;
            // 
            // engine_TypeLabel
            // 
            engine_TypeLabel.AutoSize = true;
            engine_TypeLabel.Location = new System.Drawing.Point(12, 219);
            engine_TypeLabel.Name = "engine_TypeLabel";
            engine_TypeLabel.Size = new System.Drawing.Size(70, 13);
            engine_TypeLabel.TabIndex = 15;
            engine_TypeLabel.Text = "Engine Type:";
            // 
            // engine_TypeTextBox
            // 
            this.engine_TypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "Engine_Type", true));
            this.engine_TypeTextBox.Location = new System.Drawing.Point(91, 216);
            this.engine_TypeTextBox.Name = "engine_TypeTextBox";
            this.engine_TypeTextBox.Size = new System.Drawing.Size(221, 20);
            this.engine_TypeTextBox.TabIndex = 16;
            // 
            // type_of_driveLabel
            // 
            type_of_driveLabel.AutoSize = true;
            type_of_driveLabel.Location = new System.Drawing.Point(12, 245);
            type_of_driveLabel.Name = "type_of_driveLabel";
            type_of_driveLabel.Size = new System.Drawing.Size(68, 13);
            type_of_driveLabel.TabIndex = 17;
            type_of_driveLabel.Text = "type of drive:";
            // 
            // type_of_driveTextBox
            // 
            this.type_of_driveTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.autoBindingSource, "type_of_drive", true));
            this.type_of_driveTextBox.Location = new System.Drawing.Point(91, 242);
            this.type_of_driveTextBox.Name = "type_of_driveTextBox";
            this.type_of_driveTextBox.Size = new System.Drawing.Size(221, 20);
            this.type_of_driveTextBox.TabIndex = 18;
            // 
            // NewPersonAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 275);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(vINLabel);
            this.Controls.Add(this.vINTextBox);
            this.Controls.Add(manufacturerLabel);
            this.Controls.Add(this.manufacturerTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(engine_TypeLabel);
            this.Controls.Add(this.engine_TypeTextBox);
            this.Controls.Add(type_of_driveLabel);
            this.Controls.Add(this.type_of_driveTextBox);
            this.Controls.Add(this.autoBindingNavigator);
            this.Name = "NewPersonAuto";
            this.Text = "NewPersonAuto";
            this.Load += new System.EventHandler(this.NewPersonAuto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driversDataSetNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoBindingNavigator)).EndInit();
            this.autoBindingNavigator.ResumeLayout(false);
            this.autoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DriversDataSetNew driversDataSetNew;
        private System.Windows.Forms.BindingSource autoBindingSource;
        private DriversDataSetNewTableAdapters.autoTableAdapter autoTableAdapter;
        private DriversDataSetNewTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator autoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton autoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox vINTextBox;
        private System.Windows.Forms.TextBox manufacturerTextBox;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox engine_TypeTextBox;
        private System.Windows.Forms.TextBox type_of_driveTextBox;
    }
}