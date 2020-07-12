namespace GroceryListApplication
{
    partial class NewMeal
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
            System.Windows.Forms.Label mealNameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.BtnAddMeal = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRecipeInstructions = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.mealDatabaseDataSet = new GroceryListApplication.MealDatabaseDataSet();
            this.mealInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealInformationTableAdapter = new GroceryListApplication.MealDatabaseDataSetTableAdapters.MealInformationTableAdapter();
            this.tableAdapterManager = new GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.mealIngredientsTextBox = new System.Windows.Forms.TextBox();
            this.mealInstructionsTextBox = new System.Windows.Forms.TextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            mealNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddImage);
            this.panel1.Controls.Add(this.BtnAddMeal);
            this.panel1.Controls.Add(this.BtnBack);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnAddImage
            // 
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddImage.Location = new System.Drawing.Point(200, 0);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(99, 29);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = true;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // BtnAddMeal
            // 
            this.BtnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMeal.Location = new System.Drawing.Point(386, 0);
            this.BtnAddMeal.Name = "BtnAddMeal";
            this.BtnAddMeal.Size = new System.Drawing.Size(109, 28);
            this.BtnAddMeal.TabIndex = 1;
            this.BtnAddMeal.Text = "Add Meal";
            this.BtnAddMeal.UseVisualStyleBackColor = true;
            this.BtnAddMeal.Click += new System.EventHandler(this.BtnAddMeal_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(3, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(99, 28);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<-- Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mealInstructionsTextBox);
            this.panel2.Controls.Add(this.lblRecipeInstructions);
            this.panel2.Location = new System.Drawing.Point(12, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 205);
            this.panel2.TabIndex = 1;
            // 
            // lblRecipeInstructions
            // 
            this.lblRecipeInstructions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecipeInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeInstructions.Location = new System.Drawing.Point(0, 0);
            this.lblRecipeInstructions.Name = "lblRecipeInstructions";
            this.lblRecipeInstructions.Size = new System.Drawing.Size(495, 25);
            this.lblRecipeInstructions.TabIndex = 0;
            this.lblRecipeInstructions.Text = "Recipe Instructions";
            this.lblRecipeInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(mealNameLabel);
            this.panel3.Controls.Add(this.mealNameTextBox);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(12, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(246, 256);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox1.Location = new System.Drawing.Point(3, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 218);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblIngredients);
            this.panel4.Controls.Add(this.mealIngredientsTextBox);
            this.panel4.Location = new System.Drawing.Point(264, 49);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 256);
            this.panel4.TabIndex = 3;
            // 
            // mealDatabaseDataSet
            // 
            this.mealDatabaseDataSet.DataSetName = "MealDatabaseDataSet";
            this.mealDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealInformationBindingSource
            // 
            this.mealInformationBindingSource.DataMember = "MealInformation";
            this.mealInformationBindingSource.DataSource = this.mealDatabaseDataSet;
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
            // mealNameLabel
            // 
            mealNameLabel.AutoSize = true;
            mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mealNameLabel.Location = new System.Drawing.Point(3, 8);
            mealNameLabel.Name = "mealNameLabel";
            mealNameLabel.Size = new System.Drawing.Size(83, 17);
            mealNameLabel.TabIndex = 2;
            mealNameLabel.Text = "Meal Name:";
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealInformationBindingSource, "MealName", true));
            this.mealNameTextBox.Location = new System.Drawing.Point(92, 8);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.mealNameTextBox.TabIndex = 3;
            // 
            // mealIngredientsTextBox
            // 
            this.mealIngredientsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealInformationBindingSource, "MealIngredients", true));
            this.mealIngredientsTextBox.Location = new System.Drawing.Point(4, 33);
            this.mealIngredientsTextBox.Multiline = true;
            this.mealIngredientsTextBox.Name = "mealIngredientsTextBox";
            this.mealIngredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealIngredientsTextBox.Size = new System.Drawing.Size(230, 218);
            this.mealIngredientsTextBox.TabIndex = 2;
            // 
            // mealInstructionsTextBox
            // 
            this.mealInstructionsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mealInformationBindingSource, "MealInstructions", true));
            this.mealInstructionsTextBox.Location = new System.Drawing.Point(3, 28);
            this.mealInstructionsTextBox.Multiline = true;
            this.mealInstructionsTextBox.Name = "mealInstructionsTextBox";
            this.mealInstructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealInstructionsTextBox.Size = new System.Drawing.Size(486, 174);
            this.mealInstructionsTextBox.TabIndex = 2;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(77, 6);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(89, 20);
            this.lblIngredients.TabIndex = 3;
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(518, 528);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(534, 567);
            this.MinimumSize = new System.Drawing.Size(534, 567);
            this.Name = "NewMeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMeal";
            this.Load += new System.EventHandler(this.NewMeal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealInformationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAddMeal;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecipeInstructions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddImage;
        private MealDatabaseDataSet mealDatabaseDataSet;
        private System.Windows.Forms.BindingSource mealInformationBindingSource;
        private MealDatabaseDataSetTableAdapters.MealInformationTableAdapter mealInformationTableAdapter;
        private System.Windows.Forms.TextBox mealInstructionsTextBox;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.TextBox mealIngredientsTextBox;
        private MealDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblIngredients;
    }
}