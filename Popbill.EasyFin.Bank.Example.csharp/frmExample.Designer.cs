﻿namespace Popbill.EasyFin.Bank.Example.csharp
{
    partial class frmExample
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.btnGetPartnerBalance1 = new System.Windows.Forms.Button();
            this.btnGetPartnerURL_CHRG = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btnGetChargeURL = new System.Windows.Forms.Button();
            this.btnGetBalance = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateCorpInfo = new System.Windows.Forms.Button();
            this.btnGetCorpInfo = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGetChargeInfo = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCheckID = new System.Windows.Forms.Button();
            this.btnCheckIsMember = new System.Windows.Forms.Button();
            this.btnJoinMember = new System.Windows.Forms.Button();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUpdateContact = new System.Windows.Forms.Button();
            this.btnListContact = new System.Windows.Forms.Button();
            this.btnRegistContact = new System.Windows.Forms.Button();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.btnGetAccessURL = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCorpNum = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJobID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btnGetFlatRateState = new System.Windows.Forms.Button();
            this.btnGetFlatRatePopUpURL = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.btnListBankAccount = new System.Windows.Forms.Button();
            this.btnBankAccountMgtURL = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnSaveMemo = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnListActiveJob = new System.Windows.Forms.Button();
            this.btnGetJobState = new System.Windows.Forms.Button();
            this.btnRequestJob = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(368, 15);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(143, 21);
            this.txtUserId.TabIndex = 20;
            this.txtUserId.Text = "testkorea";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.groupBox13);
            this.GroupBox1.Controls.Add(this.groupBox12);
            this.GroupBox1.Controls.Add(this.groupBox4);
            this.GroupBox1.Controls.Add(this.GroupBox3);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.GroupBox6);
            this.GroupBox1.Controls.Add(this.GroupBox5);
            this.GroupBox1.Location = new System.Drawing.Point(13, 42);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(999, 145);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "팝빌 기본 API";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.btnGetPartnerBalance1);
            this.groupBox13.Controls.Add(this.btnGetPartnerURL_CHRG);
            this.groupBox13.Location = new System.Drawing.Point(431, 15);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(133, 118);
            this.groupBox13.TabIndex = 6;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "파트너과금 포인트";
            // 
            // btnGetPartnerBalance1
            // 
            this.btnGetPartnerBalance1.Location = new System.Drawing.Point(8, 19);
            this.btnGetPartnerBalance1.Name = "btnGetPartnerBalance1";
            this.btnGetPartnerBalance1.Size = new System.Drawing.Size(119, 29);
            this.btnGetPartnerBalance1.TabIndex = 4;
            this.btnGetPartnerBalance1.Text = "파트너포인트 확인";
            this.btnGetPartnerBalance1.UseVisualStyleBackColor = true;
            this.btnGetPartnerBalance1.Click += new System.EventHandler(this.btnGetPartnerBalance1_Click);
            // 
            // btnGetPartnerURL_CHRG
            // 
            this.btnGetPartnerURL_CHRG.Location = new System.Drawing.Point(8, 52);
            this.btnGetPartnerURL_CHRG.Name = "btnGetPartnerURL_CHRG";
            this.btnGetPartnerURL_CHRG.Size = new System.Drawing.Size(119, 29);
            this.btnGetPartnerURL_CHRG.TabIndex = 0;
            this.btnGetPartnerURL_CHRG.Text = "포인트 충전 URL";
            this.btnGetPartnerURL_CHRG.UseVisualStyleBackColor = true;
            this.btnGetPartnerURL_CHRG.Click += new System.EventHandler(this.btnGetPartnerURL_CHRG_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btnGetChargeURL);
            this.groupBox12.Controls.Add(this.btnGetBalance);
            this.groupBox12.Location = new System.Drawing.Point(291, 16);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(133, 118);
            this.groupBox12.TabIndex = 5;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "연동과금 포인트";
            // 
            // btnGetChargeURL
            // 
            this.btnGetChargeURL.Location = new System.Drawing.Point(8, 54);
            this.btnGetChargeURL.Name = "btnGetChargeURL";
            this.btnGetChargeURL.Size = new System.Drawing.Size(119, 29);
            this.btnGetChargeURL.TabIndex = 1;
            this.btnGetChargeURL.Text = "포인트 충전 URL";
            this.btnGetChargeURL.UseVisualStyleBackColor = true;
            this.btnGetChargeURL.Click += new System.EventHandler(this.btnGetChargeURL_Click);
            // 
            // btnGetBalance
            // 
            this.btnGetBalance.Location = new System.Drawing.Point(8, 19);
            this.btnGetBalance.Name = "btnGetBalance";
            this.btnGetBalance.Size = new System.Drawing.Size(119, 29);
            this.btnGetBalance.TabIndex = 2;
            this.btnGetBalance.Text = "잔여포인트 확인";
            this.btnGetBalance.UseVisualStyleBackColor = true;
            this.btnGetBalance.Click += new System.EventHandler(this.btnGetBalance_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdateCorpInfo);
            this.groupBox4.Controls.Add(this.btnGetCorpInfo);
            this.groupBox4.Location = new System.Drawing.Point(851, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(133, 118);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "회사정보 관련";
            // 
            // btnUpdateCorpInfo
            // 
            this.btnUpdateCorpInfo.Location = new System.Drawing.Point(7, 53);
            this.btnUpdateCorpInfo.Name = "btnUpdateCorpInfo";
            this.btnUpdateCorpInfo.Size = new System.Drawing.Size(119, 29);
            this.btnUpdateCorpInfo.TabIndex = 1;
            this.btnUpdateCorpInfo.Text = "회사정보 수정";
            this.btnUpdateCorpInfo.UseVisualStyleBackColor = true;
            this.btnUpdateCorpInfo.Click += new System.EventHandler(this.btnUpdateCorpInfo_Click);
            // 
            // btnGetCorpInfo
            // 
            this.btnGetCorpInfo.Location = new System.Drawing.Point(7, 20);
            this.btnGetCorpInfo.Name = "btnGetCorpInfo";
            this.btnGetCorpInfo.Size = new System.Drawing.Size(119, 29);
            this.btnGetCorpInfo.TabIndex = 0;
            this.btnGetCorpInfo.Text = "회사정보 조회";
            this.btnGetCorpInfo.UseVisualStyleBackColor = true;
            this.btnGetCorpInfo.Click += new System.EventHandler(this.btnGetCorpInfo_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.btnGetChargeInfo);
            this.GroupBox3.Location = new System.Drawing.Point(151, 15);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(133, 118);
            this.GroupBox3.TabIndex = 1;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "포인트 관련";
            // 
            // btnGetChargeInfo
            // 
            this.btnGetChargeInfo.Location = new System.Drawing.Point(6, 20);
            this.btnGetChargeInfo.Name = "btnGetChargeInfo";
            this.btnGetChargeInfo.Size = new System.Drawing.Size(119, 29);
            this.btnGetChargeInfo.TabIndex = 5;
            this.btnGetChargeInfo.Text = "과금정보 확인";
            this.btnGetChargeInfo.UseVisualStyleBackColor = true;
            this.btnGetChargeInfo.Click += new System.EventHandler(this.btnGetChargeInfo_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnCheckID);
            this.GroupBox2.Controls.Add(this.btnCheckIsMember);
            this.GroupBox2.Controls.Add(this.btnJoinMember);
            this.GroupBox2.Location = new System.Drawing.Point(11, 15);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(133, 118);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "회원 정보";
            // 
            // btnCheckID
            // 
            this.btnCheckID.Location = new System.Drawing.Point(6, 52);
            this.btnCheckID.Name = "btnCheckID";
            this.btnCheckID.Size = new System.Drawing.Size(119, 29);
            this.btnCheckID.TabIndex = 3;
            this.btnCheckID.Text = "ID 중복 확인";
            this.btnCheckID.UseVisualStyleBackColor = true;
            this.btnCheckID.Click += new System.EventHandler(this.btnCheckID_Click);
            // 
            // btnCheckIsMember
            // 
            this.btnCheckIsMember.Location = new System.Drawing.Point(6, 19);
            this.btnCheckIsMember.Name = "btnCheckIsMember";
            this.btnCheckIsMember.Size = new System.Drawing.Size(119, 29);
            this.btnCheckIsMember.TabIndex = 2;
            this.btnCheckIsMember.Text = "가입여부 확인";
            this.btnCheckIsMember.UseVisualStyleBackColor = true;
            this.btnCheckIsMember.Click += new System.EventHandler(this.btnCheckIsMember_Click);
            // 
            // btnJoinMember
            // 
            this.btnJoinMember.Location = new System.Drawing.Point(6, 84);
            this.btnJoinMember.Name = "btnJoinMember";
            this.btnJoinMember.Size = new System.Drawing.Size(119, 29);
            this.btnJoinMember.TabIndex = 1;
            this.btnJoinMember.Text = "회원 가입";
            this.btnJoinMember.UseVisualStyleBackColor = true;
            this.btnJoinMember.Click += new System.EventHandler(this.btnJoinMember_Click);
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.btnUpdateContact);
            this.GroupBox6.Controls.Add(this.btnListContact);
            this.GroupBox6.Controls.Add(this.btnRegistContact);
            this.GroupBox6.Location = new System.Drawing.Point(711, 14);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(133, 118);
            this.GroupBox6.TabIndex = 3;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "담당자 관련";
            // 
            // btnUpdateContact
            // 
            this.btnUpdateContact.Location = new System.Drawing.Point(6, 83);
            this.btnUpdateContact.Name = "btnUpdateContact";
            this.btnUpdateContact.Size = new System.Drawing.Size(119, 29);
            this.btnUpdateContact.TabIndex = 2;
            this.btnUpdateContact.Text = "담당자 정보 수정";
            this.btnUpdateContact.UseVisualStyleBackColor = true;
            this.btnUpdateContact.Click += new System.EventHandler(this.btnUpdateContact_Click);
            // 
            // btnListContact
            // 
            this.btnListContact.Location = new System.Drawing.Point(6, 51);
            this.btnListContact.Name = "btnListContact";
            this.btnListContact.Size = new System.Drawing.Size(119, 29);
            this.btnListContact.TabIndex = 1;
            this.btnListContact.Text = "담당자 목록 조회";
            this.btnListContact.UseVisualStyleBackColor = true;
            this.btnListContact.Click += new System.EventHandler(this.btnListContact_Click);
            // 
            // btnRegistContact
            // 
            this.btnRegistContact.Location = new System.Drawing.Point(6, 21);
            this.btnRegistContact.Name = "btnRegistContact";
            this.btnRegistContact.Size = new System.Drawing.Size(119, 29);
            this.btnRegistContact.TabIndex = 0;
            this.btnRegistContact.Text = "담당자 추가";
            this.btnRegistContact.UseVisualStyleBackColor = true;
            this.btnRegistContact.Click += new System.EventHandler(this.btnRegistContact_Click);
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.btnGetAccessURL);
            this.GroupBox5.Location = new System.Drawing.Point(571, 15);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(133, 118);
            this.GroupBox5.TabIndex = 2;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "팝빌 기본 URL";
            // 
            // btnGetAccessURL
            // 
            this.btnGetAccessURL.Location = new System.Drawing.Point(6, 19);
            this.btnGetAccessURL.Name = "btnGetAccessURL";
            this.btnGetAccessURL.Size = new System.Drawing.Size(119, 29);
            this.btnGetAccessURL.TabIndex = 0;
            this.btnGetAccessURL.Text = "팝빌 로그인 URL";
            this.btnGetAccessURL.UseVisualStyleBackColor = true;
            this.btnGetAccessURL.Click += new System.EventHandler(this.btnGetAccessURL_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(293, 18);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(73, 12);
            this.Label2.TabIndex = 19;
            this.Label2.Text = "팝빌아이디 :";
            // 
            // txtCorpNum
            // 
            this.txtCorpNum.Location = new System.Drawing.Point(137, 15);
            this.txtCorpNum.Name = "txtCorpNum";
            this.txtCorpNum.Size = new System.Drawing.Size(143, 21);
            this.txtCorpNum.TabIndex = 18;
            this.txtCorpNum.Text = "1234567890";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(129, 12);
            this.Label1.TabIndex = 17;
            this.Label1.Text = "팝빌회원 사업자번호 : ";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listBox1);
            this.groupBox7.Controls.Add(this.txtTID);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.txtJobID);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.groupBox11);
            this.groupBox7.Controls.Add(this.groupBox10);
            this.groupBox7.Controls.Add(this.groupBox9);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(14, 193);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(998, 449);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "계좌조회 API";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(21, 226);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(936, 196);
            this.listBox1.TabIndex = 8;
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(444, 181);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(251, 21);
            this.txtTID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "거래내역 아이디(TID) : ";
            // 
            // txtJobID
            // 
            this.txtJobID.Location = new System.Drawing.Point(97, 181);
            this.txtJobID.Name = "txtJobID";
            this.txtJobID.Size = new System.Drawing.Size(193, 21);
            this.txtJobID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "작업아이디 : ";
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btnGetFlatRateState);
            this.groupBox11.Controls.Add(this.btnGetFlatRatePopUpURL);
            this.groupBox11.Location = new System.Drawing.Point(576, 23);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(173, 142);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "정액제 관리";
            // 
            // btnGetFlatRateState
            // 
            this.btnGetFlatRateState.Location = new System.Drawing.Point(10, 60);
            this.btnGetFlatRateState.Name = "btnGetFlatRateState";
            this.btnGetFlatRateState.Size = new System.Drawing.Size(153, 32);
            this.btnGetFlatRateState.TabIndex = 3;
            this.btnGetFlatRateState.Text = "정액제 서비스 상태 확인";
            this.btnGetFlatRateState.UseVisualStyleBackColor = true;
            this.btnGetFlatRateState.Click += new System.EventHandler(this.btnGetFlatRateState_Click);
            // 
            // btnGetFlatRatePopUpURL
            // 
            this.btnGetFlatRatePopUpURL.Location = new System.Drawing.Point(10, 22);
            this.btnGetFlatRatePopUpURL.Name = "btnGetFlatRatePopUpURL";
            this.btnGetFlatRatePopUpURL.Size = new System.Drawing.Size(153, 32);
            this.btnGetFlatRatePopUpURL.TabIndex = 2;
            this.btnGetFlatRatePopUpURL.Text = "정액제 신청 팝업 URL";
            this.btnGetFlatRatePopUpURL.UseVisualStyleBackColor = true;
            this.btnGetFlatRatePopUpURL.Click += new System.EventHandler(this.btnGetFlatRatePopUpURL_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.btnListBankAccount);
            this.groupBox10.Controls.Add(this.btnBankAccountMgtURL);
            this.groupBox10.Location = new System.Drawing.Point(389, 23);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(174, 142);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "계좌 관리";
            // 
            // btnListBankAccount
            // 
            this.btnListBankAccount.Location = new System.Drawing.Point(11, 58);
            this.btnListBankAccount.Name = "btnListBankAccount";
            this.btnListBankAccount.Size = new System.Drawing.Size(153, 32);
            this.btnListBankAccount.TabIndex = 2;
            this.btnListBankAccount.Text = "계좌 목록 확인";
            this.btnListBankAccount.UseVisualStyleBackColor = true;
            this.btnListBankAccount.Click += new System.EventHandler(this.btnListBankAccount_Click);
            // 
            // btnBankAccountMgtURL
            // 
            this.btnBankAccountMgtURL.Location = new System.Drawing.Point(11, 20);
            this.btnBankAccountMgtURL.Name = "btnBankAccountMgtURL";
            this.btnBankAccountMgtURL.Size = new System.Drawing.Size(153, 32);
            this.btnBankAccountMgtURL.TabIndex = 1;
            this.btnBankAccountMgtURL.Text = "계좌 관리 팝업 URL";
            this.btnBankAccountMgtURL.UseVisualStyleBackColor = true;
            this.btnBankAccountMgtURL.Click += new System.EventHandler(this.btnBankAccountMgtURL_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnSaveMemo);
            this.groupBox9.Controls.Add(this.btnSummary);
            this.groupBox9.Controls.Add(this.btnSearch);
            this.groupBox9.Location = new System.Drawing.Point(198, 23);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(174, 142);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "거래내역 조회";
            // 
            // btnSaveMemo
            // 
            this.btnSaveMemo.Location = new System.Drawing.Point(10, 95);
            this.btnSaveMemo.Name = "btnSaveMemo";
            this.btnSaveMemo.Size = new System.Drawing.Size(153, 32);
            this.btnSaveMemo.TabIndex = 8;
            this.btnSaveMemo.Text = "거래 내역 메모 저장";
            this.btnSaveMemo.UseVisualStyleBackColor = true;
            this.btnSaveMemo.Click += new System.EventHandler(this.btnSaveMemo_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(10, 57);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(153, 32);
            this.btnSummary.TabIndex = 7;
            this.btnSummary.Text = "거래 내역 요약정보 조회";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(10, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(153, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "거래 내역 조회";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnListActiveJob);
            this.groupBox8.Controls.Add(this.btnGetJobState);
            this.groupBox8.Controls.Add(this.btnRequestJob);
            this.groupBox8.Location = new System.Drawing.Point(14, 23);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 142);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "거래내역 수집";
            // 
            // btnListActiveJob
            // 
            this.btnListActiveJob.Location = new System.Drawing.Point(13, 98);
            this.btnListActiveJob.Name = "btnListActiveJob";
            this.btnListActiveJob.Size = new System.Drawing.Size(139, 32);
            this.btnListActiveJob.TabIndex = 7;
            this.btnListActiveJob.Text = "수집 상태 목록 확인";
            this.btnListActiveJob.UseVisualStyleBackColor = true;
            this.btnListActiveJob.Click += new System.EventHandler(this.btnListActiveJob_Click);
            // 
            // btnGetJobState
            // 
            this.btnGetJobState.Location = new System.Drawing.Point(13, 60);
            this.btnGetJobState.Name = "btnGetJobState";
            this.btnGetJobState.Size = new System.Drawing.Size(139, 32);
            this.btnGetJobState.TabIndex = 6;
            this.btnGetJobState.Text = "수집 상태 확인";
            this.btnGetJobState.UseVisualStyleBackColor = true;
            this.btnGetJobState.Click += new System.EventHandler(this.btnGetJobState_Click);
            // 
            // btnRequestJob
            // 
            this.btnRequestJob.Location = new System.Drawing.Point(13, 22);
            this.btnRequestJob.Name = "btnRequestJob";
            this.btnRequestJob.Size = new System.Drawing.Size(139, 32);
            this.btnRequestJob.TabIndex = 5;
            this.btnRequestJob.Text = "수집 요청";
            this.btnRequestJob.UseVisualStyleBackColor = true;
            this.btnRequestJob.Click += new System.EventHandler(this.btnRequestJob_Click);
            // 
            // frmExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 683);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCorpNum);
            this.Controls.Add(this.Label1);
            this.Name = "frmExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "팝빌 계좌조회 API SDK Example";
            this.GroupBox1.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtUserId;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button btnGetPartnerBalance1;
        private System.Windows.Forms.Button btnGetPartnerURL_CHRG;
        private System.Windows.Forms.GroupBox groupBox12;
        internal System.Windows.Forms.Button btnGetChargeURL;
        internal System.Windows.Forms.Button btnGetBalance;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateCorpInfo;
        private System.Windows.Forms.Button btnGetCorpInfo;
        internal System.Windows.Forms.GroupBox GroupBox3;
        private System.Windows.Forms.Button btnGetChargeInfo;
        internal System.Windows.Forms.GroupBox GroupBox2;
        private System.Windows.Forms.Button btnCheckID;
        internal System.Windows.Forms.Button btnCheckIsMember;
        internal System.Windows.Forms.Button btnJoinMember;
        internal System.Windows.Forms.GroupBox GroupBox6;
        private System.Windows.Forms.Button btnUpdateContact;
        private System.Windows.Forms.Button btnListContact;
        private System.Windows.Forms.Button btnRegistContact;
        internal System.Windows.Forms.GroupBox GroupBox5;
        internal System.Windows.Forms.Button btnGetAccessURL;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCorpNum;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnBankAccountMgtURL;
        private System.Windows.Forms.Button btnListBankAccount;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button btnGetFlatRatePopUpURL;
        private System.Windows.Forms.Button btnGetFlatRateState;
        private System.Windows.Forms.Button btnListActiveJob;
        private System.Windows.Forms.Button btnGetJobState;
        private System.Windows.Forms.Button btnRequestJob;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnSaveMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJobID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.ListBox listBox1;
    }
}

