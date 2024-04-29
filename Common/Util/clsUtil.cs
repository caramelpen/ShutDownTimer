using System;
using System.Collections.Generic;
using System.Text;

namespace ShutDownTimer.Common.Util {
    public class clsUtil {
        public static void AppShutDown() {
            //使用法: shutdown [/i | /l | /s | /r | /a] [/f] [/m \\コンピュータ名] [/t xx] [/c "コメント"] [/d up:xx:yy]
            /*
            引数なし                このメッセージを表示します (/? と同じです)
            i                      GUI インターフェイスを表示します。このオプ
                                    ションは最初に指定する必要があります
            l                      ログオフ (/m オプションとは併用できません)
            s                      コンピュータをシャットダウンします
            r                      コンピュータをシャットダウンして再起動します
            a                      システム シャットダウンを中止します
            m \\コンピュータ名     シャットダウン/再起動/中止するリモート コン
                                    ピュータの名前です
            t xx                   シャットダウンのタイムアウトを xx 秒に設定
                                    します
            c "コメント"           シャットダウンのコメントです (127 文字まで)
            f                      実行中のアプリケーションを警告なしに閉じます
            d [u][p]:xx:yy         シャットダウンの理由コードです
                                    u = ユーザー コード
                                    p = 計画されたシャットダウンのコード
                                    xx = 重大な理由コード (255 以下の正の整数)
                                    yy = 重大ではない理由コード (65535 以下の正の整数)
            */

            //シャットダウン
            System.Diagnostics.ProcessStartInfo psi =
            new System.Diagnostics.ProcessStartInfo();
            psi.FileName = "shutdown.exe";
            //コマンドラインを指定
            psi.Arguments = "/s";
            //ウィンドウを表示しないようにする
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            //起動
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
        }
    }
}
