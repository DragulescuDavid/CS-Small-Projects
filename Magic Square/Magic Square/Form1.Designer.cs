
namespace Magic_Square
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Square)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LivesLabel
            // 
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LivesLabel.Location = new System.Drawing.Point(12, 26);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(78, 31);
            this.LivesLabel.TabIndex = 0;
            this.LivesLabel.Text = "Lives";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnCheck.Location = new System.Drawing.Point(17, 423);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(233, 64);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAnswer.Location = new System.Drawing.Point(17, 515);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(233, 64);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "Show Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // Square
            // 
            this.Square.AllowUserToAddRows = false;
            this.Square.AllowUserToDeleteRows = false;
            this.Square.AllowUserToResizeColumns = false;
            this.Square.AllowUserToResizeRows = false;
            this.Square.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Square.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Square.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.Square.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Square.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Square.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Square.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Square.ColumnHeadersVisible = false;
            this.Square.GridColor = System.Drawing.Color.White;
            this.Square.Location = new System.Drawing.Point(490, 14);
            this.Square.Name = "Square";
            this.Square.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Square.RowHeadersVisible = false;
            this.Square.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Square.ShowEditingIcon = false;
            this.Square.Size = new System.Drawing.Size(600, 600);
            this.Square.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Magic_Square.Properties.Resources._160px_Heart_corazón_svg;
            this.pictureBox1.Location = new System.Drawing.Point(41, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.LivesLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Square)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.DataGridView Square;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

