namespace Snake
{
    partial class Highscores
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
            this.scoresDataSet = new Snake.scoresDataSet();
            this.scoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresTableAdapter = new Snake.scoresDataSetTableAdapters.scoresTableAdapter();
            this.tableAdapterManager = new Snake.scoresDataSetTableAdapters.TableAdapterManager();
            this.scoresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            this.Moeilijkheid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scoresDataSet
            // 
            this.scoresDataSet.DataSetName = "scoresDataSet";
            this.scoresDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scoresBindingSource
            // 
            this.scoresBindingSource.DataMember = "scores";
            this.scoresBindingSource.DataSource = this.scoresDataSet;
            // 
            // scoresTableAdapter
            // 
            this.scoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.scoresTableAdapter = this.scoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = Snake.scoresDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // scoresDataGridView
            // 
            this.scoresDataGridView.AllowUserToAddRows = false;
            this.scoresDataGridView.AllowUserToDeleteRows = false;
            this.scoresDataGridView.AllowUserToResizeColumns = false;
            this.scoresDataGridView.AllowUserToResizeRows = false;
            this.scoresDataGridView.AutoGenerateColumns = false;
            this.scoresDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.scoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.Moeilijkheid});
            this.scoresDataGridView.DataSource = this.scoresBindingSource;
            this.scoresDataGridView.Location = new System.Drawing.Point(1, 31);
            this.scoresDataGridView.Name = "scoresDataGridView";
            this.scoresDataGridView.RowHeadersVisible = false;
            this.scoresDataGridView.Size = new System.Drawing.Size(289, 245);
            this.scoresDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Naam";
            this.dataGridViewTextBoxColumn3.HeaderText = "Naam";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Highscore";
            this.dataGridViewTextBoxColumn2.HeaderText = "Highscore";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(289, 32);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Moeilijkheid
            // 
            this.Moeilijkheid.DataPropertyName = "Moeilijkheid";
            this.Moeilijkheid.HeaderText = "Moeilijkheid";
            this.Moeilijkheid.Name = "Moeilijkheid";
            // 
            // Highscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 278);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.scoresDataGridView);
            this.Name = "Highscores";
            this.Text = "Highscores";
            this.Load += new System.EventHandler(this.Highscores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private scoresDataSet scoresDataSet;
        private System.Windows.Forms.BindingSource scoresBindingSource;
        private scoresDataSetTableAdapters.scoresTableAdapter scoresTableAdapter;
        private scoresDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView scoresDataGridView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Moeilijkheid;
    }
}