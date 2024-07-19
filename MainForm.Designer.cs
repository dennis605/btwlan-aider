namespace Verwaltungsanwendung
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnPatientenVerwalten = new System.Windows.Forms.Button();
            this.btnBetreuerVerwalten = new System.Windows.Forms.Button();
            this.btnVeranstaltungenVerwalten = new System.Windows.Forms.Button();
            this.btnTagesplaeneVerwalten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatientenVerwalten
            // 
            this.btnPatientenVerwalten.Location = new System.Drawing.Point(12, 12);
            this.btnPatientenVerwalten.Name = "btnPatientenVerwalten";
            this.btnPatientenVerwalten.Size = new System.Drawing.Size(260, 23);
            this.btnPatientenVerwalten.TabIndex = 0;
            this.btnPatientenVerwalten.Text = "Patienten verwalten";
            this.btnPatientenVerwalten.UseVisualStyleBackColor = true;
            this.btnPatientenVerwalten.Click += new System.EventHandler(this.btnPatientenVerwalten_Click);
            // 
            // btnBetreuerVerwalten
            // 
            this.btnBetreuerVerwalten.Location = new System.Drawing.Point(12, 41);
            this.btnBetreuerVerwalten.Name = "btnBetreuerVerwalten";
            this.btnBetreuerVerwalten.Size = new System.Drawing.Size(260, 23);
            this.btnBetreuerVerwalten.TabIndex = 1;
            this.btnBetreuerVerwalten.Text = "Betreuer verwalten";
            this.btnBetreuerVerwalten.UseVisualStyleBackColor = true;
            this.btnBetreuerVerwalten.Click += new System.EventHandler(this.btnBetreuerVerwalten_Click);
            // 
            // btnVeranstaltungenVerwalten
            // 
            this.btnVeranstaltungenVerwalten.Location = new System.Drawing.Point(12, 70);
            this.btnVeranstaltungenVerwalten.Name = "btnVeranstaltungenVerwalten";
            this.btnVeranstaltungenVerwalten.Size = new System.Drawing.Size(260, 23);
            this.btnVeranstaltungenVerwalten.TabIndex = 2;
            this.btnVeranstaltungenVerwalten.Text = "Veranstaltungen verwalten";
            this.btnVeranstaltungenVerwalten.UseVisualStyleBackColor = true;
            this.btnVeranstaltungenVerwalten.Click += new System.EventHandler(this.btnVeranstaltungenVerwalten_Click);
            // 
            // btnTagesplaeneVerwalten
            // 
            this.btnTagesplaeneVerwalten.Location = new System.Drawing.Point(12, 99);
            this.btnTagesplaeneVerwalten.Name = "btnTagesplaeneVerwalten";
            this.btnTagesplaeneVerwalten.Size = new System.Drawing.Size(260, 23);
            this.btnTagesplaeneVerwalten.TabIndex = 3;
            this.btnTagesplaeneVerwalten.Text = "Tagespläne verwalten";
            this.btnTagesplaeneVerwalten.UseVisualStyleBackColor = true;
            this.btnTagesplaeneVerwalten.Click += new System.EventHandler(this.btnTagesplaeneVerwalten_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnTagesplaeneVerwalten);
            this.Controls.Add(this.btnVeranstaltungenVerwalten);
            this.Controls.Add(this.btnBetreuerVerwalten);
            this.Controls.Add(this.btnPatientenVerwalten);
            this.Name = "MainForm";
            this.Text = "Verwaltungsanwendung";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnPatientenVerwalten;
        private System.Windows.Forms.Button btnBetreuerVerwalten;
        private System.Windows.Forms.Button btnVeranstaltungenVerwalten;
        private System.Windows.Forms.Button btnTagesplaeneVerwalten;
    }
}
