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
            System.Windows.Forms.Label mealNameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.BtnAddMeal = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mealInstructionsTextBox = new System.Windows.Forms.TextBox();
            this.lblRecipeInstructions = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mealPicturePictureBox = new System.Windows.Forms.PictureBox();
            this.mealNameTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.mealIngredientsTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mealDatabaseDataSet1 = new GroceryListApplication.MealDatabaseDataSet();
            this.mealInformationTableAdapter1 = new GroceryListApplication.MealDatabaseDataSetTableAdapters.MealInformationTableAdapter();
            this.tableAdapterManager1 = new GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager();
            mealNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealPicturePictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // mealNameLabel
            // 
            mealNameLabel.AutoSize = true;
            mealNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            mealNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mealNameLabel.Location = new System.Drawing.Point(3, 8);
            mealNameLabel.Name = "mealNameLabel";
            mealNameLabel.Size = new System.Drawing.Size(83, 17);
            mealNameLabel.TabIndex = 2;
            mealNameLabel.Text = "Meal Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
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
            this.btnAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddImage.Location = new System.Drawing.Point(200, 0);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(99, 29);
            this.btnAddImage.TabIndex = 2;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // BtnAddMeal
            // 
            this.BtnAddMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnAddMeal.Enabled = false;
            this.BtnAddMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddMeal.Location = new System.Drawing.Point(386, 0);
            this.BtnAddMeal.Name = "BtnAddMeal";
            this.BtnAddMeal.Size = new System.Drawing.Size(109, 28);
            this.BtnAddMeal.TabIndex = 1;
            this.BtnAddMeal.Text = "Add Meal";
            this.BtnAddMeal.UseVisualStyleBackColor = false;
            this.BtnAddMeal.Click += new System.EventHandler(this.BtnAddMeal_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Location = new System.Drawing.Point(3, 0);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(99, 28);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "<-- Back";
            this.BtnBack.UseVisualStyleBackColor = false;
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
            // mealInstructionsTextBox
            // 
            this.mealInstructionsTextBox.BackColor = System.Drawing.Color.Silver;
            this.mealInstructionsTextBox.Enabled = false;
            this.mealInstructionsTextBox.Location = new System.Drawing.Point(3, 28);
            this.mealInstructionsTextBox.Multiline = true;
            this.mealInstructionsTextBox.Name = "mealInstructionsTextBox";
            this.mealInstructionsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealInstructionsTextBox.Size = new System.Drawing.Size(486, 174);
            this.mealInstructionsTextBox.TabIndex = 2;
            this.mealInstructionsTextBox.TextChanged += new System.EventHandler(this.mealInstructionsTextBox_TextChanged);
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
            this.panel3.Controls.Add(this.mealPicturePictureBox);
            this.panel3.Controls.Add(mealNameLabel);
            this.panel3.Controls.Add(this.mealNameTextBox);
            this.panel3.Location = new System.Drawing.Point(12, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 256);
            this.panel3.TabIndex = 2;
            // 
            // mealPicturePictureBox
            // 
            this.mealPicturePictureBox.Location = new System.Drawing.Point(6, 33);
            this.mealPicturePictureBox.Name = "mealPicturePictureBox";
            this.mealPicturePictureBox.Size = new System.Drawing.Size(240, 217);
            this.mealPicturePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mealPicturePictureBox.TabIndex = 4;
            this.mealPicturePictureBox.TabStop = false;
            // 
            // mealNameTextBox
            // 
            this.mealNameTextBox.BackColor = System.Drawing.Color.Silver;
            this.mealNameTextBox.Location = new System.Drawing.Point(92, 8);
            this.mealNameTextBox.Name = "mealNameTextBox";
            this.mealNameTextBox.Size = new System.Drawing.Size(151, 20);
            this.mealNameTextBox.TabIndex = 3;
            this.mealNameTextBox.TextChanged += new System.EventHandler(this.mealNameTextBox_TextChanged);
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
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(77, 6);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(89, 20);
            this.lblIngredients.TabIndex = 3;
            this.lblIngredients.Text = "Ingredients";
            this.lblIngredients.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mealIngredientsTextBox
            // 
            this.mealIngredientsTextBox.BackColor = System.Drawing.Color.Silver;
            this.mealIngredientsTextBox.Enabled = false;
            this.mealIngredientsTextBox.Location = new System.Drawing.Point(4, 33);
            this.mealIngredientsTextBox.Multiline = true;
            this.mealIngredientsTextBox.Name = "mealIngredientsTextBox";
            this.mealIngredientsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.mealIngredientsTextBox.Size = new System.Drawing.Size(230, 218);
            this.mealIngredientsTextBox.TabIndex = 2;
            this.mealIngredientsTextBox.TextChanged += new System.EventHandler(this.mealIngredientsTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mealDatabaseDataSet1
            // 
            this.mealDatabaseDataSet1.DataSetName = "MealDatabaseDataSet";
            this.mealDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mealInformationTableAdapter1
            // 
            this.mealInformationTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MealInformationTableAdapter = this.mealInformationTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = GroceryListApplication.MealDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // NewMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
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
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealPicturePictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mealDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAddMeal;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblRecipeInstructions;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.TextBox mealInstructionsTextBox;
        private System.Windows.Forms.TextBox mealNameTextBox;
        private System.Windows.Forms.TextBox mealIngredientsTextBox;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox mealPicturePictureBox;
        private MealDatabaseDataSet mealDatabaseDataSet1;
        private MealDatabaseDataSetTableAdapters.MealInformationTableAdapter mealInformationTableAdapter1;
        private MealDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}