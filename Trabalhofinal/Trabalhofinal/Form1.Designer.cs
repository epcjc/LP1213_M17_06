namespace Trabalhofinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.database1DataSet = new Trabalhofinal.Database1DataSet();
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorTableAdapter = new Trabalhofinal.Database1DataSetTableAdapters.JogadorTableAdapter();
            this.tableAdapterManager = new Trabalhofinal.Database1DataSetTableAdapters.TableAdapterManager();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.jogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estatísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarJogadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirObjectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarObjectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarObjectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostarResultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 205);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(288, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Registar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(250, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Data Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome jogador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nick:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(113, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(250, 20);
            this.textBox2.TabIndex = 21;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataMember = "Jogador";
            this.jogadorBindingSource.DataSource = this.database1DataSet;
            // 
            // jogadorTableAdapter
            // 
            this.jogadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ApostaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JogadasTableAdapter = null;
            this.tableAdapterManager.Jogador_jogoTableAdapter = null;
            this.tableAdapterManager.JogadorTableAdapter = this.jogadorTableAdapter;
            this.tableAdapterManager.JogoTableAdapter = null;
            this.tableAdapterManager.ObjectoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Trabalhofinal.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jogadorToolStripMenuItem,
            this.objectoToolStripMenuItem,
            this.estatísticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(721, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // jogadorToolStripMenuItem
            // 
            this.jogadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirJogadorToolStripMenuItem,
            this.eliminarJogadorToolStripMenuItem,
            this.editarJogadorToolStripMenuItem});
            this.jogadorToolStripMenuItem.Name = "jogadorToolStripMenuItem";
            this.jogadorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.jogadorToolStripMenuItem.Text = "Jogador";
            // 
            // objectoToolStripMenuItem
            // 
            this.objectoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirObjectoToolStripMenuItem,
            this.eliminarObjectoToolStripMenuItem,
            this.editarObjectoToolStripMenuItem});
            this.objectoToolStripMenuItem.Name = "objectoToolStripMenuItem";
            this.objectoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.objectoToolStripMenuItem.Text = "Objecto";
            // 
            // estatísticaToolStripMenuItem
            // 
            this.estatísticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostarResultadosToolStripMenuItem});
            this.estatísticaToolStripMenuItem.Name = "estatísticaToolStripMenuItem";
            this.estatísticaToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.estatísticaToolStripMenuItem.Text = "Estatística";
            // 
            // inserirJogadorToolStripMenuItem
            // 
            this.inserirJogadorToolStripMenuItem.Name = "inserirJogadorToolStripMenuItem";
            this.inserirJogadorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inserirJogadorToolStripMenuItem.Text = "Inserir Jogador";
            // 
            // eliminarJogadorToolStripMenuItem
            // 
            this.eliminarJogadorToolStripMenuItem.Name = "eliminarJogadorToolStripMenuItem";
            this.eliminarJogadorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.eliminarJogadorToolStripMenuItem.Text = "Eliminar Jogador";
            // 
            // editarJogadorToolStripMenuItem
            // 
            this.editarJogadorToolStripMenuItem.Name = "editarJogadorToolStripMenuItem";
            this.editarJogadorToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarJogadorToolStripMenuItem.Text = "Editar Jogador";
            // 
            // inserirObjectoToolStripMenuItem
            // 
            this.inserirObjectoToolStripMenuItem.Name = "inserirObjectoToolStripMenuItem";
            this.inserirObjectoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.inserirObjectoToolStripMenuItem.Text = "Inserir Objecto";
            // 
            // eliminarObjectoToolStripMenuItem
            // 
            this.eliminarObjectoToolStripMenuItem.Name = "eliminarObjectoToolStripMenuItem";
            this.eliminarObjectoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.eliminarObjectoToolStripMenuItem.Text = "Eliminar Objecto";
            // 
            // editarObjectoToolStripMenuItem
            // 
            this.editarObjectoToolStripMenuItem.Name = "editarObjectoToolStripMenuItem";
            this.editarObjectoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editarObjectoToolStripMenuItem.Text = "Editar Objecto";
            // 
            // mostarResultadosToolStripMenuItem
            // 
            this.mostarResultadosToolStripMenuItem.Name = "mostarResultadosToolStripMenuItem";
            this.mostarResultadosToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mostarResultadosToolStripMenuItem.Text = "Mostar Resultados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 277);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private Database1DataSetTableAdapters.JogadorTableAdapter jogadorTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarJogadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirObjectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarObjectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarObjectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estatísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostarResultadosToolStripMenuItem;

    }
}

