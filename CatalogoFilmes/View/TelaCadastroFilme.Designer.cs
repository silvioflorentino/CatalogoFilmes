namespace CatalogoFilmes.View
{
    partial class TelaCadastroFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFilme));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txBoxFilme = new TextBox();
            txBoxEstreia = new TextBox();
            cBoxCategoria = new ComboBox();
            txBoxDuracao = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(328, 37);
            label1.TabIndex = 0;
            label1.Text = "Cadastro do Filme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(33, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 1;
            label2.Text = "Filme:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(33, 152);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 2;
            label3.Text = "Estreia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(237, 152);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 3;
            label4.Text = "Categoria:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(33, 222);
            label5.Name = "label5";
            label5.Size = new Size(89, 28);
            label5.TabIndex = 4;
            label5.Text = "Duração:";
            // 
            // txBoxFilme
            // 
            txBoxFilme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txBoxFilme.Location = new Point(33, 114);
            txBoxFilme.Name = "txBoxFilme";
            txBoxFilme.Size = new Size(357, 34);
            txBoxFilme.TabIndex = 5;
            // 
            // txBoxEstreia
            // 
            txBoxEstreia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txBoxEstreia.Location = new Point(33, 180);
            txBoxEstreia.Name = "txBoxEstreia";
            txBoxEstreia.Size = new Size(125, 34);
            txBoxEstreia.TabIndex = 6;
            // 
            // cBoxCategoria
            // 
            cBoxCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cBoxCategoria.FormattingEnabled = true;
            cBoxCategoria.Items.AddRange(new object[] { "Terror", "Romance", "Comédia", "Ficção", "Animação", "Ação", "Suspense", "Drama" });
            cBoxCategoria.Location = new Point(237, 181);
            cBoxCategoria.Name = "cBoxCategoria";
            cBoxCategoria.Size = new Size(151, 36);
            cBoxCategoria.TabIndex = 7;
            // 
            // txBoxDuracao
            // 
            txBoxDuracao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txBoxDuracao.Location = new Point(33, 248);
            txBoxDuracao.Name = "txBoxDuracao";
            txBoxDuracao.Size = new Size(125, 34);
            txBoxDuracao.TabIndex = 8;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(247, 248);
            button1.Name = "button1";
            button1.Size = new Size(114, 113);
            button1.TabIndex = 9;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaCadastroFilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 386);
            Controls.Add(button1);
            Controls.Add(txBoxDuracao);
            Controls.Add(cBoxCategoria);
            Controls.Add(txBoxEstreia);
            Controls.Add(txBoxFilme);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.InactiveCaptionText;
            MaximizeBox = false;
            Name = "TelaCadastroFilme";
            ShowIcon = false;
            Text = "Sistema de Catálogo de Filmes - SCF";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txBoxFilme;
        private TextBox txBoxEstreia;
        private ComboBox cBoxCategoria;
        private TextBox txBoxDuracao;
        private Button button1;
    }
}