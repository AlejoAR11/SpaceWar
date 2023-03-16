namespace ñaam2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblEnemy = new System.Windows.Forms.Label();
            this.TmrTimer1 = new System.Windows.Forms.Timer(this.components);
            this.lblWallRigth = new System.Windows.Forms.Label();
            this.lblWallLeft = new System.Windows.Forms.Label();
            this.pbxHero = new System.Windows.Forms.PictureBox();
            this.btnGo = new MaterialSkin.Controls.MaterialButton();
            this.btnStop = new MaterialSkin.Controls.MaterialButton();
            this.pbxEnemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(226, 93);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(13, 13);
            this.lblEnemy.TabIndex = 0;
            this.lblEnemy.Text = "a";
            this.lblEnemy.Click += new System.EventHandler(this.lblEnemy_Click);
            // 
            // TmrTimer1
            // 
            this.TmrTimer1.Tick += new System.EventHandler(this.tmrFranchesco_Tick);
            // 
            // lblWallRigth
            // 
            this.lblWallRigth.AutoSize = true;
            this.lblWallRigth.Location = new System.Drawing.Point(756, 93);
            this.lblWallRigth.Name = "lblWallRigth";
            this.lblWallRigth.Size = new System.Drawing.Size(21, 13);
            this.lblWallRigth.TabIndex = 3;
            this.lblWallRigth.Text = "|||||||";
            // 
            // lblWallLeft
            // 
            this.lblWallLeft.AutoSize = true;
            this.lblWallLeft.Location = new System.Drawing.Point(6, 93);
            this.lblWallLeft.Name = "lblWallLeft";
            this.lblWallLeft.Size = new System.Drawing.Size(21, 13);
            this.lblWallLeft.TabIndex = 4;
            this.lblWallLeft.Text = "|||||||";
            // 
            // pbxHero
            // 
            this.pbxHero.BackColor = System.Drawing.SystemColors.Control;
            this.pbxHero.Image = ((System.Drawing.Image)(resources.GetObject("pbxHero.Image")));
            this.pbxHero.Location = new System.Drawing.Point(392, 405);
            this.pbxHero.Name = "pbxHero";
            this.pbxHero.Size = new System.Drawing.Size(95, 91);
            this.pbxHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxHero.TabIndex = 5;
            this.pbxHero.TabStop = false;
            // 
            // btnGo
            // 
            this.btnGo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGo.Depth = 0;
            this.btnGo.HighEmphasis = true;
            this.btnGo.Icon = null;
            this.btnGo.Location = new System.Drawing.Point(9, 471);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGo.Name = "btnGo";
            this.btnGo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGo.Size = new System.Drawing.Size(64, 36);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGo.UseAccentColor = false;
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnStop.Depth = 0;
            this.btnStop.HighEmphasis = true;
            this.btnStop.Icon = null;
            this.btnStop.Location = new System.Drawing.Point(90, 471);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStop.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStop.Name = "btnStop";
            this.btnStop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnStop.Size = new System.Drawing.Size(64, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnStop.UseAccentColor = false;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // pbxEnemy
            // 
            this.pbxEnemy.BackColor = System.Drawing.Color.Transparent;
            this.pbxEnemy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbxEnemy.Image = ((System.Drawing.Image)(resources.GetObject("pbxEnemy.Image")));
            this.pbxEnemy.Location = new System.Drawing.Point(33, 67);
            this.pbxEnemy.Name = "pbxEnemy";
            this.pbxEnemy.Size = new System.Drawing.Size(95, 91);
            this.pbxEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxEnemy.TabIndex = 9;
            this.pbxEnemy.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 516);
            this.Controls.Add(this.pbxEnemy);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pbxHero);
            this.Controls.Add(this.lblWallLeft);
            this.Controls.Add(this.lblWallRigth);
            this.Controls.Add(this.lblEnemy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Fiauuu";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Timer TmrTimer1;
        private System.Windows.Forms.Label lblWallRigth;
        private System.Windows.Forms.Label lblWallLeft;
        private System.Windows.Forms.PictureBox pbxHero;
        private MaterialSkin.Controls.MaterialButton btnGo;
        private MaterialSkin.Controls.MaterialButton btnStop;
        private System.Windows.Forms.PictureBox pbxEnemy;
    }
}

