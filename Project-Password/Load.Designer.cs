
namespace Project_Password
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxLOAD = new System.Windows.Forms.PictureBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOAD)).BeginInit();
            this.SuspendLayout();
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 250;
            this.loadingTimer.Tick += new System.EventHandler(this.OnLoadingTimerTick);
            // 
            // pictureBoxLOAD
            // 
            this.pictureBoxLOAD.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBoxLOAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLOAD.Image = global::Project_Password.Properties.Resources.pass;
            this.pictureBoxLOAD.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLOAD.Name = "pictureBoxLOAD";
            this.pictureBoxLOAD.Size = new System.Drawing.Size(954, 731);
            this.pictureBoxLOAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLOAD.TabIndex = 0;
            this.pictureBoxLOAD.TabStop = false;
            this.pictureBoxLOAD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMoveMouseDown);
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.BackColor = System.Drawing.Color.DimGray;
            this.loadingLabel.Location = new System.Drawing.Point(451, 357);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(69, 16);
            this.loadingLabel.TabIndex = 1;
            this.loadingLabel.Text = "Загрузка";
            // 
            // loadWorker
            // 
            this.loadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Loading);
            this.loadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OnLoadComplete);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(954, 731);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.pictureBoxLOAD);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(970, 770);
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLOAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.PictureBox pictureBoxLOAD;
        private System.Windows.Forms.Label loadingLabel;
        private System.ComponentModel.BackgroundWorker loadWorker;
    }
}