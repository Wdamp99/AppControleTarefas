namespace ControleTarefas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView = new DataGridView();
            gridTarefa = new DataGridViewTextBoxColumn();
            gridData = new DataGridViewTextBoxColumn();
            lblTarefa = new Label();
            txtTarefa = new TextBox();
            lblDataLimite = new Label();
            dateDataLimite = new DateTimePicker();
            btnAdd = new Button();
            btnResolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { gridTarefa, gridData });
            dataGridView.Location = new Point(0, 164);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(801, 216);
            dataGridView.TabIndex = 0;
            // 
            // gridTarefa
            // 
            gridTarefa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gridTarefa.HeaderText = "Tarefa";
            gridTarefa.Name = "gridTarefa";
            gridTarefa.Resizable = DataGridViewTriState.True;
            // 
            // gridData
            // 
            gridData.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            gridData.DefaultCellStyle = dataGridViewCellStyle1;
            gridData.HeaderText = "Data Limite";
            gridData.Name = "gridData";
            gridData.Resizable = DataGridViewTriState.True;
            // 
            // lblTarefa
            // 
            lblTarefa.AutoSize = true;
            lblTarefa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTarefa.Location = new Point(50, 91);
            lblTarefa.Name = "lblTarefa";
            lblTarefa.Size = new Size(63, 25);
            lblTarefa.TabIndex = 1;
            lblTarefa.Text = "Tarefa";
            // 
            // txtTarefa
            // 
            txtTarefa.Location = new Point(50, 119);
            txtTarefa.Name = "txtTarefa";
            txtTarefa.Size = new Size(200, 23);
            txtTarefa.TabIndex = 2;
            // 
            // lblDataLimite
            // 
            lblDataLimite.AutoSize = true;
            lblDataLimite.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDataLimite.Location = new Point(279, 91);
            lblDataLimite.Name = "lblDataLimite";
            lblDataLimite.Size = new Size(51, 25);
            lblDataLimite.TabIndex = 3;
            lblDataLimite.Text = "Data";
            // 
            // dateDataLimite
            // 
            dateDataLimite.Format = DateTimePickerFormat.Short;
            dateDataLimite.Location = new Point(279, 119);
            dateDataLimite.Name = "dateDataLimite";
            dateDataLimite.Size = new Size(107, 23);
            dateDataLimite.TabIndex = 5;
            dateDataLimite.Value = new DateTime(2023, 10, 21, 16, 13, 33, 0);
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(465, 101);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(86, 41);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.TextAlign = ContentAlignment.MiddleRight;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnResolver
            // 
            btnResolver.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnResolver.Image = (Image)resources.GetObject("btnResolver.Image");
            btnResolver.ImageAlign = ContentAlignment.MiddleLeft;
            btnResolver.Location = new Point(582, 101);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new Size(127, 41);
            btnResolver.TabIndex = 7;
            btnResolver.Text = "Resolver";
            btnResolver.TextAlign = ContentAlignment.MiddleRight;
            btnResolver.UseVisualStyleBackColor = true;
            btnResolver.Click += btnResolver_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnResolver);
            Controls.Add(btnAdd);
            Controls.Add(dateDataLimite);
            Controls.Add(lblDataLimite);
            Controls.Add(txtTarefa);
            Controls.Add(lblTarefa);
            Controls.Add(dataGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn gridTarefa;
        private DataGridViewTextBoxColumn gridData;
        private Label lblTarefa;
        private TextBox txtTarefa;
        private Label lblDataLimite;
        private DateTimePicker dateDataLimite;
        private Button btnAdd;
        private Button btnResolver;
    }
}