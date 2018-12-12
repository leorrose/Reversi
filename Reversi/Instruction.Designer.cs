namespace Reversi
{
    partial class Instruction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instruction));
            this.label1 = new System.Windows.Forms.Label();
            this.Bt_ins_continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(73, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(662, 378);
            this.label1.TabIndex = 0;
            this.label1.Text = "On your turn, you place one piece on the board with your color.";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // Bt_ins_continue
            // 
            this.Bt_ins_continue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Bt_ins_continue.BackgroundImage")));
            this.Bt_ins_continue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Bt_ins_continue.FlatAppearance.BorderSize = 0;
            this.Bt_ins_continue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bt_ins_continue.Location = new System.Drawing.Point(307, 470);
            this.Bt_ins_continue.Name = "Bt_ins_continue";
            this.Bt_ins_continue.Size = new System.Drawing.Size(225, 42);
            this.Bt_ins_continue.TabIndex = 1;
            this.Bt_ins_continue.UseVisualStyleBackColor = true;
            this.Bt_ins_continue.Click += new System.EventHandler(this.Bt_ins_continue_Click);
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Reversi.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.ControlBox = false;
            this.Controls.Add(this.Bt_ins_continue);
            this.Controls.Add(this.label1);
            this.Name = "Instruction";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instruction";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bt_ins_continue;
    }
}