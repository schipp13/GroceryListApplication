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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSubmitMeal = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.mealInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealDatabaseDataSet = new GroceryListApplication.MealDatabaseDataSet();
            this.mealInformationTableAdapter = new GroceryListApplication.MealDatabaseDataSetTableAdapters.MealInformationTableAdapter();
            this.tableAdapterManager = new GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.mealInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mealNameComboBox
            // 
            this.mealNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealInformationBindingSource, "MealName", true));
            this.mealNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mealInformationBindingSource, "MealName", true));
            this.mealNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mealNameComboBox.FormattingEnabled = true;
            this.mealNameComboBox.Location = new System.Drawing.Point(83, 49);
            this.mealNameComboBox.Name = "mealNameComboBox";
            this.mealNameComboBox.Size = new System.Drawing.Size(280, 33);
            this.mealNameComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select meal from drop down.";
            // 
            // BtnSubmitMeal
            // 
            this.BtnSubmitMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitMeal.Location = new System.Drawing.Point(83, 103);
            this.BtnSubmitMeal.Name = "BtnSubmitMeal";
            this.BtnSubmitMeal.Size = new System.Drawing.Size(112, 32);
            this.BtnSubmitMeal.TabIndex = 4;
            this.BtnSubmitMeal.Text = "Add Meal";
            this.BtnSubmitMeal.UseVisualStyleBackColor = true;
            this.BtnSubmitMeal.Click += new System.EventHandler(this.BtnSubmitMeal_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(249, 103);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(114, 32);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            // SelectMealMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 151);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnSubmitMeal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mealNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
    }
}