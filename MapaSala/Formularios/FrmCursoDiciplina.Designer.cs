
namespace MapaSala.Formularios
{
    partial class FrmCursoDiciplina
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
            this.lsDiciplinas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cursos = new System.Windows.Forms.Label();
            this.cbxCursos = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lsDiciplinas
            // 
            this.lsDiciplinas.FormattingEnabled = true;
            this.lsDiciplinas.Items.AddRange(new object[] {
            "Matematica",
            "Geografia",
            "História ",
            "Ed. Física",
            "Biologia",
            "Física"});
            this.lsDiciplinas.Location = new System.Drawing.Point(46, 56);
            this.lsDiciplinas.Name = "lsDiciplinas";
            this.lsDiciplinas.Size = new System.Drawing.Size(101, 82);
            this.lsDiciplinas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Diciplinas";
            // 
            // Cursos
            // 
            this.Cursos.AutoSize = true;
            this.Cursos.Location = new System.Drawing.Point(231, 40);
            this.Cursos.Name = "Cursos";
            this.Cursos.Size = new System.Drawing.Size(39, 13);
            this.Cursos.TabIndex = 3;
            this.Cursos.Text = "Cursos";
            // 
            // cbxCursos
            // 
            this.cbxCursos.FormattingEnabled = true;
            this.cbxCursos.Items.AddRange(new object[] {
            "MTEC PI Desenvolvimento de sistemas",
            "MTEC PI Administração",
            "Itinerario formativo"});
            this.cbxCursos.Location = new System.Drawing.Point(234, 56);
            this.cbxCursos.Name = "cbxCursos";
            this.cbxCursos.Size = new System.Drawing.Size(121, 21);
            this.cbxCursos.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(153, 56);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 294);
            this.dataGridView1.TabIndex = 6;
            // 
            // FrmCursoDiciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.cbxCursos);
            this.Controls.Add(this.Cursos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsDiciplinas);
            this.Name = "FrmCursoDiciplina";
            this.Text = "FrmCursoDiciplina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsDiciplinas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cursos;
        private System.Windows.Forms.ComboBox cbxCursos;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}