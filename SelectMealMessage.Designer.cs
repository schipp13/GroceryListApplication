namespace GroceryListApplication
{
    partial class SelectMealMessage
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
            this.mealNameComboBox = new System.Windows.Forms.ComboBox();
            this.mealInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealDatabaseDataSet = new GroceryListApplication.MealDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmitMeal = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.mealInformationTableAdapter = new GroceryListApplication.MealDatabaseDataSetTableAdapters.MealInformationTableAdapter();
            this.tableAdapterManager = new GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager();
            this.mealDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.mealInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mealNameComboBox
            // 
            this.mealNameComboBox.BackColor = System.Drawing.Color.Gray;
            this.mealNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealInformationBindingSource, "MealName", true));
            this.mealNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mealInformationBindingSource, "MealName", true));
            this.mealNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameComboBox.FormattingEnabled = true;
            this.mealNameComboBox.Location = new System.Drawing.Point(90, 70);
            this.mealNameComboBox.Name = "mealNameComboBox";
            this.mealNameComboBox.Size = new System.Drawing.Size(280, 33);
            this.mealNameComboBox.TabIndex = 2;
            // 
            // mealInformationBindingSource
            // 
            this.mealInformationBindingSource.DataMember = "MealInformation";
            this.mealInformationBindingSource.DataSource = this.mealDatabaseDataSet;
            // 
            // mealDatabaseDataSet
            // 
            this.mealDatabaseDataSet.DataSetName = "MealDatabaseDataSet";
            this.mealDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select meal from drop down.";
            // 
            // BtnSubmitMeal
            // 
            this.BtnSubmitMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSubmitMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitMeal.Location = new System.Drawing.Point(90, 124);
            this.BtnSubmitMeal.Name = "BtnSubmitMeal";
            this.BtnSubmitMeal.Size = new System.Drawing.Size(112, 32);
            this.BtnSubmitMeal.TabIndex = 4;
            this.BtnSubmitMeal.Text = "Add Meal";
            this.BtnSubmitMeal.UseVisualStyleBackColor = false;
            this.BtnSubmitMeal.Click += new System.EventHandler(this.BtnSubmitMeal_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(256, 124);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 32);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // mealInformationTableAdapter
            // 
            this.mealInformationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MealInformationTableAdapter = this.mealInformationTableAdapter;
            this.tableAdapterManager.UpdateOrder = GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mealDateDateTimePicker
            // 
            this.mealDateDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.mealDateDateTimePicker.CalendarMonthBackground = System.Drawing.Color.Gray;
            this.mealDateDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mealDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.mealInformationBindingSource, "MealDate", true));
            this.mealDateDateTimePicker.Location = new System.Drawing.Point(90, 12);
            this.mealDateDateTimePicker.Name = "mealDateDateTimePicker";
            this.mealDateDateTimePicker.Size = new System.Drawing.Size(280, 20);
            this.mealDateDateTimePicker.TabIndex = 6;
            // 
            // SelectMealMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(446, 190);
            this.Controls.Add(this.mealDateDateTimePicker);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSubmitMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(462, 229);
            this.MinimumSize = new System.Drawing.Size(462, 229);
            this.Name = "SelectMealMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Meal";
            this.Load += new System.EventHandler(this.SelectMealMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mealInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MealDatabaseDataSet mealDatabaseDataSet;
        private System.Windows.Forms.BindingSource mealInformationBindingSource;
        private MealDatabaseDataSetTableAdapters.MealInformationTableAdapter mealInformationTableAdapter;
        private MealDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox mealNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnSubmitMeal;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.DateTimePicker mealDateDateTimePicker;
    }
}