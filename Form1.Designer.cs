namespace Rock_Paper_Scissors_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scrissor = new System.Windows.Forms.PictureBox();
            this.paper = new System.Windows.Forms.PictureBox();
            this.rock = new System.Windows.Forms.PictureBox();
            this.playerbox = new System.Windows.Forms.PictureBox();
            this.combox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scrissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox)).BeginInit();
            this.SuspendLayout();
            // 
            // scrissor
            // 
            this.scrissor.BackColor = System.Drawing.Color.Violet;
            this.scrissor.Image = ((System.Drawing.Image)(resources.GetObject("scrissor.Image")));
            this.scrissor.Location = new System.Drawing.Point(328, 39);
            this.scrissor.Name = "scrissor";
            this.scrissor.Size = new System.Drawing.Size(113, 88);
            this.scrissor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scrissor.TabIndex = 1;
            this.scrissor.TabStop = false;
            this.scrissor.Click += new System.EventHandler(this.scrissor_Click);
            // 
            // paper
            // 
            this.paper.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.paper.Image = ((System.Drawing.Image)(resources.GetObject("paper.Image")));
            this.paper.Location = new System.Drawing.Point(519, 39);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(113, 88);
            this.paper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper.TabIndex = 2;
            this.paper.TabStop = false;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // rock
            // 
            this.rock.BackColor = System.Drawing.Color.PaleTurquoise;
            this.rock.Image = ((System.Drawing.Image)(resources.GetObject("rock.Image")));
            this.rock.Location = new System.Drawing.Point(133, 39);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(113, 88);
            this.rock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock.TabIndex = 3;
            this.rock.TabStop = false;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // playerbox
            // 
            this.playerbox.Location = new System.Drawing.Point(210, 164);
            this.playerbox.Name = "playerbox";
            this.playerbox.Size = new System.Drawing.Size(110, 95);
            this.playerbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerbox.TabIndex = 4;
            this.playerbox.TabStop = false;
            // 
            // combox
            // 
            this.combox.Location = new System.Drawing.Point(450, 164);
            this.combox.Name = "combox";
            this.combox.Size = new System.Drawing.Size(110, 95);
            this.combox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.combox.TabIndex = 5;
            this.combox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(358, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(227, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(471, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "COM";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.result.Location = new System.Drawing.Point(346, 349);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(82, 29);
            this.result.TabIndex = 9;
            this.result.Text = "Ready";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combox);
            this.Controls.Add(this.playerbox);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.scrissor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.scrissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scrissor;
        private System.Windows.Forms.PictureBox paper;
        private System.Windows.Forms.PictureBox rock;
        private System.Windows.Forms.PictureBox playerbox;
        private System.Windows.Forms.PictureBox combox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label result;
    }
}

