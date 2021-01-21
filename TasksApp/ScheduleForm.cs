using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasksApp
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void SchCheckBtm_Click(object sender, EventArgs e)
        {
            String executeCommand = "control schedtasks"; // 実行コマンド
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + executeCommand);
            processStartInfo.CreateNoWindow = true; // コマンドプロンプトを表示
            processStartInfo.UseShellExecute = false; // シェル機能オフ
            Process.Start(processStartInfo);
        }

        private void SchConfigBtm_Click(object sender, EventArgs e)
        {
            /* システム日時取得
             * フォーマット:yyyyMMdd-HHmmss
             */

            DateTime dt = DateTime.Now;
            string dt_ = dt.ToString("yyyyMMdd-HHmmss");

           /* 実行コマンド
            * schtasks /create /tn [タスク名] /tr [実行内容] /sc [実行頻度] /st [実行時間]
            * schtasks /create /tn "%sch_name%" /tr "start %sch_url%" /sc once /st %sch_time%
            */

            String executeCommand =
                "schtasks /create /tn "
                + dt_
                + " /tr \"C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe " 
                + SchUrl.Text
                + "\" /sc once /st " 
                + SchTime.Text;

            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe", "/c " + executeCommand);
            processStartInfo.CreateNoWindow = true; // コマンドプロンプトを表示
            processStartInfo.UseShellExecute = false; // シェル機能オフ
            Process process_ = Process.Start(processStartInfo);

            process_.WaitForExit(); // 終了するまで待機する                              
            int exitCode = process_.ExitCode; // 終了コードを取得する

            if (process_.ExitCode == 0)
            {
                //メッセージボックスを表示する
                MessageBox.Show("タスクを登録しました",
                    "実行結果",
                    MessageBoxButtons.OK);
            }
            else
            {
                //メッセージボックスを表示する
                MessageBox.Show("入力値をご確認ください",
                    "実行結果",
                    MessageBoxButtons.OK);

            }
        }
    }
}
