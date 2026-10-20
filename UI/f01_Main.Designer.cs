namespace ShutDownTimer.UI {
    partial class f01_Main {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f01_Main));
            this.cmdRunStop = new System.Windows.Forms.Button();
            this.cmdEnd = new System.Windows.Forms.Button();
            this.fraData = new System.Windows.Forms.GroupBox();
            this.rdoTime = new System.Windows.Forms.RadioButton();
            this.rdoPast = new System.Windows.Forms.RadioButton();
            this.cmbH = new System.Windows.Forms.ComboBox();
            this.cmbM = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.tim = new System.Windows.Forms.Timer(this.components);
            this.lblMsg = new System.Windows.Forms.Label();
            this.lblBeep = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.fraData.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdRunStop
            // 
            this.cmdRunStop.Location = new System.Drawing.Point(16, 238);
            this.cmdRunStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdRunStop.Name = "cmdRunStop";
            this.cmdRunStop.Size = new System.Drawing.Size(82, 51);
            this.cmdRunStop.TabIndex = 4;
            this.cmdRunStop.Text = "開　始";
            this.cmdRunStop.UseVisualStyleBackColor = true;
            this.cmdRunStop.Click += new System.EventHandler(this.cmdRunStop_Click);
            // 
            // cmdEnd
            // 
            this.cmdEnd.Location = new System.Drawing.Point(297, 238);
            this.cmdEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdEnd.Name = "cmdEnd";
            this.cmdEnd.Size = new System.Drawing.Size(82, 51);
            this.cmdEnd.TabIndex = 5;
            this.cmdEnd.Text = "終　了";
            this.cmdEnd.UseVisualStyleBackColor = true;
            this.cmdEnd.Click += new System.EventHandler(this.cmdEnd_Click);
            // 
            // fraData
            // 
            this.fraData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fraData.Controls.Add(this.rdoTime);
            this.fraData.Controls.Add(this.rdoPast);
            this.fraData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fraData.Location = new System.Drawing.Point(16, 90);
            this.fraData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fraData.Name = "fraData";
            this.fraData.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fraData.Size = new System.Drawing.Size(248, 67);
            this.fraData.TabIndex = 2;
            this.fraData.TabStop = false;
            // 
            // rdoTime
            // 
            this.rdoTime.AutoSize = true;
            this.rdoTime.Location = new System.Drawing.Point(150, 27);
            this.rdoTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoTime.Name = "rdoTime";
            this.rdoTime.Size = new System.Drawing.Size(74, 22);
            this.rdoTime.TabIndex = 1;
            this.rdoTime.Text = "指定時刻";
            this.rdoTime.UseVisualStyleBackColor = true;
            this.rdoTime.CheckedChanged += new System.EventHandler(this.rdoTime_CheckedChanged);
            // 
            // rdoPast
            // 
            this.rdoPast.AutoSize = true;
            this.rdoPast.Checked = true;
            this.rdoPast.Location = new System.Drawing.Point(16, 27);
            this.rdoPast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rdoPast.Name = "rdoPast";
            this.rdoPast.Size = new System.Drawing.Size(98, 22);
            this.rdoPast.TabIndex = 0;
            this.rdoPast.TabStop = true;
            this.rdoPast.Text = "指定経過時間";
            this.rdoPast.UseVisualStyleBackColor = true;
            this.rdoPast.CheckedChanged += new System.EventHandler(this.rdoPast_CheckedChanged);
            // 
            // cmbH
            // 
            this.cmbH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbH.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbH.FormattingEnabled = true;
            this.cmbH.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cmbH.Location = new System.Drawing.Point(21, 171);
            this.cmbH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbH.Name = "cmbH";
            this.cmbH.Size = new System.Drawing.Size(62, 36);
            this.cmbH.TabIndex = 2;
            // 
            // cmbM
            // 
            this.cmbM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbM.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbM.FormattingEnabled = true;
            this.cmbM.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cmbM.Location = new System.Drawing.Point(142, 171);
            this.cmbM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbM.Name = "cmbM";
            this.cmbM.Size = new System.Drawing.Size(62, 36);
            this.cmbM.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblInfo.Location = new System.Drawing.Point(252, 180);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(153, 40);
            this.lblInfo.TabIndex = 5;
            this.lblInfo.Text = "に強制シャットダウン";
            // 
            // lblH
            // 
            this.lblH.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblH.Location = new System.Drawing.Point(87, 180);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(49, 40);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "時間";
            // 
            // lblM
            // 
            this.lblM.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblM.Location = new System.Drawing.Point(209, 180);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(44, 40);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "分後";
            // 
            // tim
            // 
            this.tim.Interval = 1000;
            this.tim.Tick += new System.EventHandler(this.tim_Tick);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMsg.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg.Location = new System.Drawing.Point(22, 13);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(341, 40);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Visible = false;
            // 
            // lblBeep
            // 
            this.lblBeep.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblBeep.ForeColor = System.Drawing.Color.Lime;
            this.lblBeep.Location = new System.Drawing.Point(353, 10);
            this.lblBeep.Name = "lblBeep";
            this.lblBeep.Size = new System.Drawing.Size(36, 40);
            this.lblBeep.TabIndex = 9;
            this.lblBeep.Text = "●";
            this.lblBeep.Visible = false;
            // 
            // lblMsg2
            // 
            this.lblMsg2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMsg2.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg2.Location = new System.Drawing.Point(22, 48);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(268, 40);
            this.lblMsg2.TabIndex = 10;
            this.lblMsg2.Text = "に強制シャットダウンします";
            this.lblMsg2.Visible = false;
            // 
            // f01_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 307);
            this.ControlBox = false;
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblBeep);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cmbM);
            this.Controls.Add(this.cmbH);
            this.Controls.Add(this.fraData);
            this.Controls.Add(this.cmdEnd);
            this.Controls.Add(this.cmdRunStop);
            this.Controls.Add(this.lblMsg);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "f01_Main";
            this.Text = "【停止中】";
            this.fraData.ResumeLayout(false);
            this.fraData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdRunStop;
        private System.Windows.Forms.Button cmdEnd;
        private System.Windows.Forms.GroupBox fraData;
        private System.Windows.Forms.RadioButton rdoTime;
        private System.Windows.Forms.RadioButton rdoPast;
        private System.Windows.Forms.ComboBox cmbH;
        private System.Windows.Forms.ComboBox cmbM;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Timer tim;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblBeep;
        private System.Windows.Forms.Label lblMsg2;
    }
}

