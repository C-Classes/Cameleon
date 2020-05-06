namespace Cameleon
{
    partial class MainForm
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
            this.mainPicture = new System.Windows.Forms.PictureBox();
            this.cameleon = new System.Windows.Forms.PictureBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.ids = new System.Windows.Forms.Label();
            this.showProgress = new System.Windows.Forms.Button();
            this.progressPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameleon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPicture
            // 
            this.mainPicture.AccessibleDescription = "";
            this.mainPicture.Image = global::Cameleon.Properties.Resources.images;
            this.mainPicture.Location = new System.Drawing.Point(0, 0);
            this.mainPicture.Name = "mainPicture";
            this.mainPicture.Size = new System.Drawing.Size(500, 500);
            this.mainPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPicture.TabIndex = 0;
            this.mainPicture.TabStop = false;
            // 
            // cameleon
            // 
            this.cameleon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cameleon.Location = new System.Drawing.Point(450, 450);
            this.cameleon.Name = "cameleon";
            this.cameleon.Size = new System.Drawing.Size(50, 50);
            this.cameleon.TabIndex = 1;
            this.cameleon.TabStop = false;
            this.cameleon.Click += new System.EventHandler(this.Cameleon_Click);
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(574, 40);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 2;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(574, 91);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(75, 23);
            this.stop_btn.TabIndex = 3;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = false;
            this.stop_btn.Click += new System.EventHandler(this.Stop_btn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.score.Location = new System.Drawing.Point(589, 160);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(13, 13);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // ids
            // 
            this.ids.AutoSize = true;
            this.ids.Location = new System.Drawing.Point(589, 208);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(13, 13);
            this.ids.TabIndex = 5;
            this.ids.Text = "0";
            // 
            // showProgress
            // 
            this.showProgress.Location = new System.Drawing.Point(574, 278);
            this.showProgress.Name = "showProgress";
            this.showProgress.Size = new System.Drawing.Size(75, 54);
            this.showProgress.TabIndex = 6;
            this.showProgress.Text = "Show Progress";
            this.showProgress.UseVisualStyleBackColor = true;
            this.showProgress.Click += new System.EventHandler(this.ShowProgress_Click);
            // 
            // progressPicture
            // 
            this.progressPicture.AccessibleDescription = "";
            this.progressPicture.Image = global::Cameleon.Properties.Resources.images;
            this.progressPicture.Location = new System.Drawing.Point(0, 0);
            this.progressPicture.Name = "progressPicture";
            this.progressPicture.Size = new System.Drawing.Size(500, 500);
            this.progressPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.progressPicture.TabIndex = 7;
            this.progressPicture.TabStop = false;
            this.progressPicture.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 625);
            this.Controls.Add(this.progressPicture);
            this.Controls.Add(this.showProgress);
            this.Controls.Add(this.ids);
            this.Controls.Add(this.score);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.cameleon);
            this.Controls.Add(this.mainPicture);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameleon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPicture;
        private System.Windows.Forms.PictureBox cameleon;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label ids;
        private System.Windows.Forms.Button showProgress;
        private System.Windows.Forms.PictureBox progressPicture;
    }
}

