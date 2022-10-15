namespace NoteTaking
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.picDragoon = new System.Windows.Forms.PictureBox();
            this.timrDragon = new System.Windows.Forms.Timer(this.components);
            this.picMadara = new System.Windows.Forms.PictureBox();
            this.pcMadara = new System.Windows.Forms.PictureBox();
            this.tmrMadara = new System.Windows.Forms.Timer(this.components);
            this.timeMadara = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picDragoon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMadara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMadara)).BeginInit();
            this.SuspendLayout();
            // 
            // picDragoon
            // 
            this.picDragoon.BackColor = System.Drawing.Color.Transparent;
            this.picDragoon.Image = ((System.Drawing.Image)(resources.GetObject("picDragoon.Image")));
            this.picDragoon.Location = new System.Drawing.Point(669, 12);
            this.picDragoon.Name = "picDragoon";
            this.picDragoon.Size = new System.Drawing.Size(134, 92);
            this.picDragoon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDragoon.TabIndex = 0;
            this.picDragoon.TabStop = false;
            // 
            // timrDragon
            // 
            this.timrDragon.Interval = 10;
            this.timrDragon.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picMadara
            // 
            this.picMadara.BackColor = System.Drawing.Color.Transparent;
            this.picMadara.Image = ((System.Drawing.Image)(resources.GetObject("picMadara.Image")));
            this.picMadara.Location = new System.Drawing.Point(657, 110);
            this.picMadara.Name = "picMadara";
            this.picMadara.Size = new System.Drawing.Size(146, 206);
            this.picMadara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMadara.TabIndex = 1;
            this.picMadara.TabStop = false;
            // 
            // pcMadara
            // 
            this.pcMadara.BackColor = System.Drawing.Color.Transparent;
            this.pcMadara.Image = ((System.Drawing.Image)(resources.GetObject("pcMadara.Image")));
            this.pcMadara.Location = new System.Drawing.Point(701, 322);
            this.pcMadara.Name = "pcMadara";
            this.pcMadara.Size = new System.Drawing.Size(102, 128);
            this.pcMadara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMadara.TabIndex = 2;
            this.pcMadara.TabStop = false;
            // 
            // tmrMadara
            // 
            this.tmrMadara.Interval = 10;
            this.tmrMadara.Tick += new System.EventHandler(this.tmrMadara_Tick);
            // 
            // timeMadara
            // 
            this.timeMadara.Interval = 9;
            this.timeMadara.Tick += new System.EventHandler(this.timeMadara_Tick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcMadara);
            this.Controls.Add(this.picMadara);
            this.Controls.Add(this.picDragoon);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDragoon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMadara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMadara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDragoon;
        private System.Windows.Forms.Timer timrDragon;
        private System.Windows.Forms.PictureBox picMadara;
        private System.Windows.Forms.PictureBox pcMadara;
        private System.Windows.Forms.Timer tmrMadara;
        private System.Windows.Forms.Timer timeMadara;
    }
}