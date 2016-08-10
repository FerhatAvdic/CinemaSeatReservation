namespace CinemaSeatReservation
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.movies_L = new System.Windows.Forms.Label();
            this.projectionListBox = new System.Windows.Forms.ListBox();
            this.seatListBox = new System.Windows.Forms.ListBox();
            this.Projections_L = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancelB = new System.Windows.Forms.Button();
            this.reserveB = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.feedback_L = new System.Windows.Forms.Label();
            this.saveB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.Location = new System.Drawing.Point(41, 56);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(140, 290);
            this.movieListBox.TabIndex = 0;
            this.movieListBox.SelectedIndexChanged += new System.EventHandler(this.movieListBox_SelectedIndexChanged);
            // 
            // movies_L
            // 
            this.movies_L.AutoSize = true;
            this.movies_L.Location = new System.Drawing.Point(92, 27);
            this.movies_L.Name = "movies_L";
            this.movies_L.Size = new System.Drawing.Size(41, 13);
            this.movies_L.TabIndex = 1;
            this.movies_L.Text = "Movies";
            // 
            // projectionListBox
            // 
            this.projectionListBox.FormattingEnabled = true;
            this.projectionListBox.Location = new System.Drawing.Point(208, 56);
            this.projectionListBox.Name = "projectionListBox";
            this.projectionListBox.Size = new System.Drawing.Size(197, 199);
            this.projectionListBox.TabIndex = 2;
            this.projectionListBox.SelectedIndexChanged += new System.EventHandler(this.projectionListBox_SelectedIndexChanged);
            // 
            // seatListBox
            // 
            this.seatListBox.FormattingEnabled = true;
            this.seatListBox.Location = new System.Drawing.Point(449, 56);
            this.seatListBox.Name = "seatListBox";
            this.seatListBox.Size = new System.Drawing.Size(96, 199);
            this.seatListBox.TabIndex = 3;
            this.seatListBox.SelectedIndexChanged += new System.EventHandler(this.seatListBox_SelectedIndexChanged);
            // 
            // Projections_L
            // 
            this.Projections_L.AutoSize = true;
            this.Projections_L.Location = new System.Drawing.Point(273, 27);
            this.Projections_L.Name = "Projections_L";
            this.Projections_L.Size = new System.Drawing.Size(59, 13);
            this.Projections_L.TabIndex = 4;
            this.Projections_L.Text = "Projections";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Seats";
            // 
            // cancelB
            // 
            this.cancelB.Location = new System.Drawing.Point(434, 310);
            this.cancelB.Name = "cancelB";
            this.cancelB.Size = new System.Drawing.Size(111, 23);
            this.cancelB.TabIndex = 6;
            this.cancelB.Text = "Cancel Reservation";
            this.cancelB.UseVisualStyleBackColor = true;
            this.cancelB.Click += new System.EventHandler(this.cancelB_Click);
            // 
            // reserveB
            // 
            this.reserveB.Location = new System.Drawing.Point(434, 281);
            this.reserveB.Name = "reserveB";
            this.reserveB.Size = new System.Drawing.Size(111, 23);
            this.reserveB.TabIndex = 7;
            this.reserveB.Text = "Reserve Seat";
            this.reserveB.UseVisualStyleBackColor = true;
            this.reserveB.Click += new System.EventHandler(this.reserveB_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Make or Cancel a Reservation";
            // 
            // feedback_L
            // 
            this.feedback_L.AutoSize = true;
            this.feedback_L.Location = new System.Drawing.Point(205, 320);
            this.feedback_L.Name = "feedback_L";
            this.feedback_L.Size = new System.Drawing.Size(0, 13);
            this.feedback_L.TabIndex = 9;
            // 
            // saveB
            // 
            this.saveB.Location = new System.Drawing.Point(468, 339);
            this.saveB.Name = "saveB";
            this.saveB.Size = new System.Drawing.Size(77, 23);
            this.saveB.TabIndex = 10;
            this.saveB.Text = "Save Data";
            this.saveB.UseVisualStyleBackColor = true;
            this.saveB.Click += new System.EventHandler(this.saveB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 380);
            this.Controls.Add(this.saveB);
            this.Controls.Add(this.feedback_L);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reserveB);
            this.Controls.Add(this.cancelB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Projections_L);
            this.Controls.Add(this.seatListBox);
            this.Controls.Add(this.projectionListBox);
            this.Controls.Add(this.movies_L);
            this.Controls.Add(this.movieListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.Label movies_L;
        private System.Windows.Forms.ListBox projectionListBox;
        private System.Windows.Forms.ListBox seatListBox;
        private System.Windows.Forms.Label Projections_L;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cancelB;
        private System.Windows.Forms.Button reserveB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label feedback_L;
        private System.Windows.Forms.Button saveB;



    }
}

