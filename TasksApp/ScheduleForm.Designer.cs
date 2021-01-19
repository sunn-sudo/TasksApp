
namespace TasksApp
{
    partial class ScheduleForm
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
            this.SchUrl = new System.Windows.Forms.TextBox();
            this.SchTime = new System.Windows.Forms.TextBox();
            this.SchCheckBtm = new System.Windows.Forms.Button();
            this.SchConfigBtm = new System.Windows.Forms.Button();
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
            // SchUrl
            // 
            this.SchUrl.Location = new System.Drawing.Point(207, 84);
            this.SchUrl.Name = "SchUrl";
            this.SchUrl.PlaceholderText = "URLを入力してください";
            this.SchUrl.Size = new System.Drawing.Size(349, 27);
            this.SchUrl.TabIndex = 3;
            // 
            // SchTime
            // 
            this.SchTime.Location = new System.Drawing.Point(207, 130);
            this.SchTime.MaxLength = 5;
            this.SchTime.Name = "SchTime";
            this.SchTime.PlaceholderText = "HH:MM";
            this.SchTime.Size = new System.Drawing.Size(65, 27);
            this.SchTime.TabIndex = 4;
            // 
            // SchCheckBtm
            // 
            this.SchCheckBtm.Location = new System.Drawing.Point(266, 213);
            this.SchCheckBtm.Name = "SchCheckBtm";
            this.SchCheckBtm.Size = new System.Drawing.Size(142, 41);
            this.SchCheckBtm.TabIndex = 5;
            this.SchCheckBtm.Text = "スケジュール確認";
            this.SchCheckBtm.UseVisualStyleBackColor = true;
            this.SchCheckBtm.Click += new System.EventHandler(this.SchCheckBtm_Click);
            // 
            // SchConfigBtm
            // 
            this.SchConfigBtm.Location = new System.Drawing.Point(414, 213);
            this.SchConfigBtm.Name = "SchConfigBtm";
            this.SchConfigBtm.Size = new System.Drawing.Size(142, 41);
            this.SchConfigBtm.TabIndex = 6;
            this.SchConfigBtm.Text = "設定";
            this.SchConfigBtm.UseVisualStyleBackColor = true;
            this.SchConfigBtm.Click += new System.EventHandler(this.SchConfigBtm_Click);
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 281);
            this.Controls.Add(this.SchConfigBtm);
            this.Controls.Add(this.SchCheckBtm);
            this.Controls.Add(this.SchTime);
            this.Controls.Add(this.SchUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ScheduleForm";
            this.Text = "スケジュール設定アプリ(※今日のみ設定可能)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SchUrl;
        private System.Windows.Forms.TextBox SchTime;
        private System.Windows.Forms.Button SchCheckBtm;
        private System.Windows.Forms.Button SchConfigBtm;
    }
}

