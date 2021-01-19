
namespace TasksApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sch_url = new System.Windows.Forms.TextBox();
            this.sch_time = new System.Windows.Forms.TextBox();
            this.sch_check_btm = new System.Windows.Forms.Button();
            this.sch_config_btm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "今日のスケジュール設定画面";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(73, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "設定URL：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(73, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "実行時間：";
            // 
            // sch_url
            // 
            this.sch_url.Location = new System.Drawing.Point(207, 84);
            this.sch_url.Name = "sch_url";
            this.sch_url.PlaceholderText = "URLを入力してください";
            this.sch_url.Size = new System.Drawing.Size(349, 27);
            this.sch_url.TabIndex = 3;
            // 
            // sch_time
            // 
            this.sch_time.Location = new System.Drawing.Point(207, 130);
            this.sch_time.MaxLength = 5;
            this.sch_time.Name = "sch_time";
            this.sch_time.PlaceholderText = "HH:MM";
            this.sch_time.Size = new System.Drawing.Size(65, 27);
            this.sch_time.TabIndex = 4;
            // 
            // sch_check_btm
            // 
            this.sch_check_btm.Location = new System.Drawing.Point(266, 213);
            this.sch_check_btm.Name = "sch_check_btm";
            this.sch_check_btm.Size = new System.Drawing.Size(142, 41);
            this.sch_check_btm.TabIndex = 5;
            this.sch_check_btm.Text = "スケジュール確認";
            this.sch_check_btm.UseVisualStyleBackColor = true;
            // 
            // sch_config_btm
            // 
            this.sch_config_btm.Location = new System.Drawing.Point(414, 213);
            this.sch_config_btm.Name = "sch_config_btm";
            this.sch_config_btm.Size = new System.Drawing.Size(142, 41);
            this.sch_config_btm.TabIndex = 6;
            this.sch_config_btm.Text = "設定";
            this.sch_config_btm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.sch_config_btm);
            this.Controls.Add(this.sch_check_btm);
            this.Controls.Add(this.sch_time);
            this.Controls.Add(this.sch_url);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sch_url;
        private System.Windows.Forms.TextBox sch_time;
        private System.Windows.Forms.Button sch_check_btm;
        private System.Windows.Forms.Button sch_config_btm;
    }
}

