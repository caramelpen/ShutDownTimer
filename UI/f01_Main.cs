using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//手動追加
using ShutDownTimer.Common.Util;
using Microsoft.VisualBasic;

namespace ShutDownTimer.UI {
    public partial class f01_Main : Form {
        string strH;
        string strM;
        DateTime dt;
        DateTime dtTarget;
        string strStart = "開　始";
        string strEnd = "中　止";

        public f01_Main() {
            InitializeComponent();
            tim.Enabled = false;    //一応明示
            this.ShowInTaskbar = true;
        }

        #region 稼働ボタン押下
        private void cmdRunStop_Click(object sender, EventArgs e) {
            string strMsg ="";
            Boolean blnEnable = false;
            Boolean blnLblVisible;
            string strLblMsg;
            string strLblMsg2;
            string strRunStop;
            Boolean blnRunEnabled;
            string strThisTxt;
            Boolean blnTaskBar;

            tim.Enabled = false;    //一応明示

            try {
                //開始表記のボタンを押した
                if (cmdRunStop.Text == strStart) {

                    if (cmbH.Text == "" || cmbM.Text == "") {
                        strMsg = "指定してください。";
                        goto End_Sub;                    
                    }

                    //現在日時
                    dt = DateTime.Now;

                    // 時分だけを取得する
                    strH = dt.Hour.ToString();
                    strM = dt.Minute.ToString();

                    //経過時間
                    if (rdoPast.Checked == true) {

                        if (cmbH.Text == "0" && cmbM.Text == "0") {
                            strMsg = "0分は指定できません。";
                            goto End_Sub;
                        }

                        TimeSpan ts = new TimeSpan(0, int.Parse(cmbH.Text), int.Parse(cmbM.Text), 0);
                        //現在時分に経過時間を足す
                        dtTarget = DateTime.Parse(strH + ":" + strM) + ts;

                    //指定時刻
                    } else {
                        dtTarget = DateTime.Parse(cmbH.Text + ":" + cmbM.Text);
                        //もう過ぎた時刻なら明日の同時刻にしてしまう
                        if (dtTarget <= dt) {
                            TimeSpan ts1 = new TimeSpan(1, 0, 0, 0);
                            dtTarget = dtTarget + ts1;
                        }
                    }
                    blnLblVisible = true;
                    strLblMsg = dtTarget.ToString();
                    strLblMsg2 = "に強制シャットダウンします";

                    strRunStop = strEnd;

                    blnRunEnabled = false;

                    strThisTxt = "【稼働中】" + strLblMsg + Strings.Space(1) + "に強制シャットダウン";

                    blnTaskBar = false;
                    tim.Enabled = true;

                //中止表記のボタンを押した
                } else {

                    blnLblVisible = false;
                    strLblMsg = "";
                    strLblMsg2 = "";

                    strRunStop = strStart;

                    blnRunEnabled = true;
                    
                    blnEnable = true;
                    
                    strThisTxt = "【停止中】";
                    blnTaskBar = true;
                }
                lblBeep.Visible = blnLblVisible;
                lblMsg.Visible = blnLblVisible;
                lblMsg.Text = strLblMsg;
                lblMsg2.Visible = blnLblVisible;
                lblMsg2.Text = strLblMsg2;

                cmdRunStop.Text = strRunStop;
                cmdEnd.Enabled = blnRunEnabled;
                this.Text = strThisTxt;
                this.ShowInTaskbar = blnTaskBar;

End_Sub:

                if (strMsg.Length > 0) { }

            } catch (Exception ex)  {
                tim.Enabled = false;
                strMsg = ex.Message;

            } finally {

                if (strMsg.Length > 0) {
                    MessageBox.Show(this, strMsg, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                } else {

                    cmbH.Enabled = blnEnable;
                    cmbM.Enabled = blnEnable;
                }
            
            }

        }
        #endregion

        #region 終了ボタン押下
        private void cmdEnd_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        #endregion

        #region タイマー
        private void tim_Tick(object sender, EventArgs e) {
            Color col;

            if (lblBeep.ForeColor == Color.Lime) {
                col = Color.Red;
            } else {
                col = Color.Lime;
            }
            lblBeep.ForeColor = col;

            DateTime dtTim = DateTime.Now;
            //経過時間
            if (rdoPast.Checked == true) {
                // 時分だけを取得する
                string strHTim = dtTim.Hour.ToString();
                string strMTim = dtTim.Minute.ToString();

                if (DateTime.Parse(strHTim + ":" + strMTim) >= dtTarget) {
                    clsUtil.AppShutDown();
                }

                //指定時刻
            } else {
                if (dtTim >= dtTarget) {
                    clsUtil.AppShutDown();
                }
            }

        }
        #endregion

        #region 各ラジオボタン制御
        private void rdoPast_CheckedChanged(object sender, EventArgs e) {
            string strLblH = "";
            string strLblM = "";
            if (rdoPast.Checked == true) {
                strLblH = "時間";
                strLblM = "分後";
            } else {
                strLblH = "時";
                strLblM = "分";          
            }
            lblH.Text = strLblH;
            lblM.Text = strLblM;

            //未選択状態にする
            cmbH.SelectedIndex = -1;
            cmbM.SelectedIndex = -1;
        }

        private void rdoTime_CheckedChanged(object sender, EventArgs e) {
            string strLblH = "";
            string strLblM = "";
            if (rdoTime.Checked == true) {
                strLblH = "時";
                strLblM = "分";
            } else {
                strLblH = "時間";
                strLblM = "分後";
            }
            lblH.Text = strLblH;
            lblM.Text = strLblM;

            
            DateTime dt = DateTime.Now;

            // 時分だけを取得する
            string strH = dt.Hour.ToString();
            string strM = dt.Minute.ToString();
            //新設機能として、現在時刻+1分を選択状態にする
            cmbH.SelectedIndex = int.Parse(strH);
            cmbM.SelectedIndex = int.Parse(strM)+1;
        }
        #endregion

    }
}