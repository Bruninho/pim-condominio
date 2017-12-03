namespace Pim___Desktop
{
    partial class frmDependente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMoradorResp = new System.Windows.Forms.TextBox();
            this.cbGrauParentesco = new System.Windows.Forms.ComboBox();
            this.txtTelefoneDep = new System.Windows.Forms.TextBox();
            this.txtRgDep = new System.Windows.Forms.TextBox();
            this.txtNomeDep = new System.Windows.Forms.TextBox();
            this.txtCodigoDep = new System.Windows.Forms.TextBox();
            this.lblGrauParent = new System.Windows.Forms.Label();
            this.lblMorResp = new System.Windows.Forms.Label();
            this.lblTelefoneDep = new System.Windows.Forms.Label();
            this.lblRgDep = new System.Windows.Forms.Label();
            this.lblNomeDep = new System.Windows.Forms.Label();
            this.lblCodigoDep = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarDep = new System.Windows.Forms.Button();
            this.btnSalvarDep = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMoradorResp);
            this.panel1.Controls.Add(this.cbGrauParentesco);
            this.panel1.Controls.Add(this.txtTelefoneDep);
            this.panel1.Controls.Add(this.txtRgDep);
            this.panel1.Controls.Add(this.txtNomeDep);
            this.panel1.Controls.Add(this.txtCodigoDep);
            this.panel1.Controls.Add(this.lblGrauParent);
            this.panel1.Controls.Add(this.lblMorResp);
            this.panel1.Controls.Add(this.lblTelefoneDep);
            this.panel1.Controls.Add(this.lblRgDep);
            this.panel1.Controls.Add(this.lblNomeDep);
            this.panel1.Controls.Add(this.lblCodigoDep);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 397);
            this.panel1.TabIndex = 0;
            // 
            // txtMoradorResp
            // 
            this.txtMoradorResp.Location = new System.Drawing.Point(210, 271);
            this.txtMoradorResp.Name = "txtMoradorResp";
            this.txtMoradorResp.Size = new System.Drawing.Size(214, 22);
            this.txtMoradorResp.TabIndex = 11;
            // 
            // cbGrauParentesco
            // 
            this.cbGrauParentesco.FormattingEnabled = true;
            this.cbGrauParentesco.Items.AddRange(new object[] {
            "Filho(a)",
            "Mãe",
            "Pai",
            "Conjugê",
            "Tio(a)"});
            this.cbGrauParentesco.Location = new System.Drawing.Point(195, 330);
            this.cbGrauParentesco.Name = "cbGrauParentesco";
            this.cbGrauParentesco.Size = new System.Drawing.Size(166, 24);
            this.cbGrauParentesco.TabIndex = 10;
            // 
            // txtTelefoneDep
            // 
            this.txtTelefoneDep.Location = new System.Drawing.Point(123, 213);
            this.txtTelefoneDep.Name = "txtTelefoneDep";
            this.txtTelefoneDep.Size = new System.Drawing.Size(214, 22);
            this.txtTelefoneDep.TabIndex = 9;
            // 
            // txtRgDep
            // 
            this.txtRgDep.Location = new System.Drawing.Point(108, 152);
            this.txtRgDep.Name = "txtRgDep";
            this.txtRgDep.Size = new System.Drawing.Size(214, 22);
            this.txtRgDep.TabIndex = 8;
            // 
            // txtNomeDep
            // 
            this.txtNomeDep.Location = new System.Drawing.Point(108, 95);
            this.txtNomeDep.Name = "txtNomeDep";
            this.txtNomeDep.Size = new System.Drawing.Size(475, 22);
            this.txtNomeDep.TabIndex = 7;
            // 
            // txtCodigoDep
            // 
            this.txtCodigoDep.Location = new System.Drawing.Point(225, 38);
            this.txtCodigoDep.Name = "txtCodigoDep";
            this.txtCodigoDep.Size = new System.Drawing.Size(214, 22);
            this.txtCodigoDep.TabIndex = 6;
            // 
            // lblGrauParent
            // 
            this.lblGrauParent.AutoSize = true;
            this.lblGrauParent.Location = new System.Drawing.Point(49, 337);
            this.lblGrauParent.Name = "lblGrauParent";
            this.lblGrauParent.Size = new System.Drawing.Size(140, 17);
            this.lblGrauParent.TabIndex = 5;
            this.lblGrauParent.Text = "Grau de Parentesco:";
            // 
            // lblMorResp
            // 
            this.lblMorResp.AutoSize = true;
            this.lblMorResp.Location = new System.Drawing.Point(49, 276);
            this.lblMorResp.Name = "lblMorResp";
            this.lblMorResp.Size = new System.Drawing.Size(155, 17);
            this.lblMorResp.TabIndex = 4;
            this.lblMorResp.Text = "Morador Responsável: ";
            // 
            // lblTelefoneDep
            // 
            this.lblTelefoneDep.AutoSize = true;
            this.lblTelefoneDep.Location = new System.Drawing.Point(49, 218);
            this.lblTelefoneDep.Name = "lblTelefoneDep";
            this.lblTelefoneDep.Size = new System.Drawing.Size(68, 17);
            this.lblTelefoneDep.TabIndex = 3;
            this.lblTelefoneDep.Text = "Telefone:";
            // 
            // lblRgDep
            // 
            this.lblRgDep.AutoSize = true;
            this.lblRgDep.Location = new System.Drawing.Point(49, 157);
            this.lblRgDep.Name = "lblRgDep";
            this.lblRgDep.Size = new System.Drawing.Size(33, 17);
            this.lblRgDep.TabIndex = 2;
            this.lblRgDep.Text = "RG:";
            // 
            // lblNomeDep
            // 
            this.lblNomeDep.AutoSize = true;
            this.lblNomeDep.Location = new System.Drawing.Point(49, 100);
            this.lblNomeDep.Name = "lblNomeDep";
            this.lblNomeDep.Size = new System.Drawing.Size(53, 17);
            this.lblNomeDep.TabIndex = 1;
            this.lblNomeDep.Text = "Nome: ";
            // 
            // lblCodigoDep
            // 
            this.lblCodigoDep.AutoSize = true;
            this.lblCodigoDep.Location = new System.Drawing.Point(49, 44);
            this.lblCodigoDep.Name = "lblCodigoDep";
            this.lblCodigoDep.Size = new System.Drawing.Size(162, 17);
            this.lblCodigoDep.TabIndex = 0;
            this.lblCodigoDep.Text = "Código do Dependente: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCancelarDep);
            this.panel2.Controls.Add(this.btnSalvarDep);
            this.panel2.Location = new System.Drawing.Point(13, 417);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnCancelarDep
            // 
            this.btnCancelarDep.Location = new System.Drawing.Point(557, 36);
            this.btnCancelarDep.Name = "btnCancelarDep";
            this.btnCancelarDep.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarDep.TabIndex = 1;
            this.btnCancelarDep.Text = "Cancelar";
            this.btnCancelarDep.UseVisualStyleBackColor = true;
            // 
            // btnSalvarDep
            // 
            this.btnSalvarDep.Location = new System.Drawing.Point(108, 36);
            this.btnSalvarDep.Name = "btnSalvarDep";
            this.btnSalvarDep.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarDep.TabIndex = 0;
            this.btnSalvarDep.Text = "Salvar";
            this.btnSalvarDep.UseVisualStyleBackColor = true;
            // 
            // frmDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmDependente";
            this.Text = "Cadastro de Dependente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMoradorResp;
        private System.Windows.Forms.ComboBox cbGrauParentesco;
        private System.Windows.Forms.TextBox txtTelefoneDep;
        private System.Windows.Forms.TextBox txtRgDep;
        private System.Windows.Forms.TextBox txtNomeDep;
        private System.Windows.Forms.TextBox txtCodigoDep;
        private System.Windows.Forms.Label lblGrauParent;
        private System.Windows.Forms.Label lblMorResp;
        private System.Windows.Forms.Label lblTelefoneDep;
        private System.Windows.Forms.Label lblRgDep;
        private System.Windows.Forms.Label lblNomeDep;
        private System.Windows.Forms.Label lblCodigoDep;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalvarDep;
        private System.Windows.Forms.Button btnCancelarDep;
    }
}