
namespace DB4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelmotcle = new System.Windows.Forms.Label();
            this.textBoxmc = new System.Windows.Forms.TextBox();
            this.buttonchercher = new System.Windows.Forms.Button();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelmotcle
            // 
            this.labelmotcle.AutoSize = true;
            this.labelmotcle.Location = new System.Drawing.Point(71, 40);
            this.labelmotcle.Name = "labelmotcle";
            this.labelmotcle.Size = new System.Drawing.Size(43, 13);
            this.labelmotcle.TabIndex = 0;
            this.labelmotcle.Text = "Mot Clè";
            // 
            // textBoxmc
            // 
            this.textBoxmc.Location = new System.Drawing.Point(143, 35);
            this.textBoxmc.Name = "textBoxmc";
            this.textBoxmc.Size = new System.Drawing.Size(389, 20);
            this.textBoxmc.TabIndex = 1;
            // 
            // buttonchercher
            // 
            this.buttonchercher.Location = new System.Drawing.Point(559, 23);
            this.buttonchercher.Name = "buttonchercher";
            this.buttonchercher.Size = new System.Drawing.Size(167, 32);
            this.buttonchercher.TabIndex = 2;
            this.buttonchercher.Text = "Chercher";
            this.buttonchercher.UseVisualStyleBackColor = true;
            this.buttonchercher.Click += new System.EventHandler(this.buttonchercher_Click);
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Location = new System.Drawing.Point(68, 94);
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.Size = new System.Drawing.Size(669, 313);
            this.dataGridViewProduit.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewProduit);
            this.Controls.Add(this.buttonchercher);
            this.Controls.Add(this.textBoxmc);
            this.Controls.Add(this.labelmotcle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelmotcle;
        private System.Windows.Forms.TextBox textBoxmc;
        private System.Windows.Forms.Button buttonchercher;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
    }
}

