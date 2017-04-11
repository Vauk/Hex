namespace Hex
{
    partial class HexGameWindow
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
            this.tmrAppTimer = new System.Windows.Forms.Timer(this.components);
            this.mapEditPanel = new System.Windows.Forms.Panel();
            this.lblMouseCoor = new System.Windows.Forms.Label();
            this.btnRoad = new System.Windows.Forms.Button();
            this.btnLava = new System.Windows.Forms.Button();
            this.btnVolcano = new System.Windows.Forms.Button();
            this.btnMountain = new System.Windows.Forms.Button();
            this.btnForest = new System.Windows.Forms.Button();
            this.btnSwamp = new System.Windows.Forms.Button();
            this.btnPlains = new System.Windows.Forms.Button();
            this.btnDesert = new System.Windows.Forms.Button();
            this.mapEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrAppTimer
            // 
            this.tmrAppTimer.Enabled = true;
            this.tmrAppTimer.Tick += new System.EventHandler(this.tmrAppTimer_Tick);
            // 
            // mapEditPanel
            // 
            this.mapEditPanel.BackColor = System.Drawing.Color.Transparent;
            this.mapEditPanel.Controls.Add(this.lblMouseCoor);
            this.mapEditPanel.Controls.Add(this.btnRoad);
            this.mapEditPanel.Controls.Add(this.btnLava);
            this.mapEditPanel.Controls.Add(this.btnVolcano);
            this.mapEditPanel.Controls.Add(this.btnMountain);
            this.mapEditPanel.Controls.Add(this.btnForest);
            this.mapEditPanel.Controls.Add(this.btnSwamp);
            this.mapEditPanel.Controls.Add(this.btnPlains);
            this.mapEditPanel.Controls.Add(this.btnDesert);
            this.mapEditPanel.Location = new System.Drawing.Point(98, 123);
            this.mapEditPanel.Name = "mapEditPanel";
            this.mapEditPanel.Size = new System.Drawing.Size(75, 292);
            this.mapEditPanel.TabIndex = 0;
            // 
            // lblMouseCoor
            // 
            this.lblMouseCoor.AutoSize = true;
            this.lblMouseCoor.Location = new System.Drawing.Point(3, 269);
            this.lblMouseCoor.Name = "lblMouseCoor";
            this.lblMouseCoor.Size = new System.Drawing.Size(71, 13);
            this.lblMouseCoor.TabIndex = 1;
            this.lblMouseCoor.Text = "lblMouseCoor";
            // 
            // btnRoad
            // 
            this.btnRoad.Location = new System.Drawing.Point(0, 225);
            this.btnRoad.Name = "btnRoad";
            this.btnRoad.Size = new System.Drawing.Size(75, 23);
            this.btnRoad.TabIndex = 7;
            this.btnRoad.Text = "Road";
            this.btnRoad.UseVisualStyleBackColor = true;
            this.btnRoad.Click += new System.EventHandler(this.btnRoad_Click);
            // 
            // btnLava
            // 
            this.btnLava.Location = new System.Drawing.Point(0, 169);
            this.btnLava.Name = "btnLava";
            this.btnLava.Size = new System.Drawing.Size(75, 22);
            this.btnLava.TabIndex = 6;
            this.btnLava.Text = "Lava";
            this.btnLava.UseVisualStyleBackColor = true;
            this.btnLava.Click += new System.EventHandler(this.btnLava_Click);
            // 
            // btnVolcano
            // 
            this.btnVolcano.Location = new System.Drawing.Point(0, 141);
            this.btnVolcano.Name = "btnVolcano";
            this.btnVolcano.Size = new System.Drawing.Size(75, 22);
            this.btnVolcano.TabIndex = 5;
            this.btnVolcano.Text = "Volcano";
            this.btnVolcano.UseVisualStyleBackColor = true;
            this.btnVolcano.Click += new System.EventHandler(this.btnVolcano_Click);
            // 
            // btnMountain
            // 
            this.btnMountain.Location = new System.Drawing.Point(0, 113);
            this.btnMountain.Name = "btnMountain";
            this.btnMountain.Size = new System.Drawing.Size(75, 22);
            this.btnMountain.TabIndex = 4;
            this.btnMountain.Text = "Mountain";
            this.btnMountain.UseVisualStyleBackColor = true;
            this.btnMountain.Click += new System.EventHandler(this.btnMountain_Click);
            // 
            // btnForest
            // 
            this.btnForest.Location = new System.Drawing.Point(0, 85);
            this.btnForest.Name = "btnForest";
            this.btnForest.Size = new System.Drawing.Size(75, 22);
            this.btnForest.TabIndex = 3;
            this.btnForest.Text = "Forest";
            this.btnForest.UseVisualStyleBackColor = true;
            this.btnForest.Click += new System.EventHandler(this.btnForest_Click);
            // 
            // btnSwamp
            // 
            this.btnSwamp.Location = new System.Drawing.Point(0, 57);
            this.btnSwamp.Name = "btnSwamp";
            this.btnSwamp.Size = new System.Drawing.Size(75, 22);
            this.btnSwamp.TabIndex = 2;
            this.btnSwamp.Text = "Swamp";
            this.btnSwamp.UseVisualStyleBackColor = true;
            this.btnSwamp.Click += new System.EventHandler(this.btnSwamp_Click);
            // 
            // btnPlains
            // 
            this.btnPlains.Location = new System.Drawing.Point(0, 29);
            this.btnPlains.Name = "btnPlains";
            this.btnPlains.Size = new System.Drawing.Size(75, 22);
            this.btnPlains.TabIndex = 1;
            this.btnPlains.Text = "Plains";
            this.btnPlains.UseVisualStyleBackColor = true;
            this.btnPlains.Click += new System.EventHandler(this.btnPlains_Click);
            // 
            // btnDesert
            // 
            this.btnDesert.Location = new System.Drawing.Point(0, 0);
            this.btnDesert.Name = "btnDesert";
            this.btnDesert.Size = new System.Drawing.Size(75, 23);
            this.btnDesert.TabIndex = 0;
            this.btnDesert.Text = "Desert";
            this.btnDesert.UseVisualStyleBackColor = true;
            this.btnDesert.Click += new System.EventHandler(this.btnDesert_Click);
            // 
            // HexGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 691);
            this.Controls.Add(this.mapEditPanel);
            this.Name = "HexGameWindow";
            this.Text = "Hex Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HexGameWindow_FormClosing);
            this.Load += new System.EventHandler(this.HexGameWindow_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HexGameWindow_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HexGameWindow_MouseMove);
            this.mapEditPanel.ResumeLayout(false);
            this.mapEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrAppTimer;
        private System.Windows.Forms.Panel mapEditPanel;
        private System.Windows.Forms.Label lblMouseCoor;
        private System.Windows.Forms.Button btnRoad;
        private System.Windows.Forms.Button btnLava;
        private System.Windows.Forms.Button btnVolcano;
        private System.Windows.Forms.Button btnMountain;
        private System.Windows.Forms.Button btnForest;
        private System.Windows.Forms.Button btnSwamp;
        private System.Windows.Forms.Button btnPlains;
        private System.Windows.Forms.Button btnDesert;
    }
}