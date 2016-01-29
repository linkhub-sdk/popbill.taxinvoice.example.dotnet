﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Popbill.Closedown;

namespace Popbill.Closedown.Example.csharp
{
    public partial class frmExample : Form
    {
        //링크아이디
        private string LinkID = "TESTER";
        //비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        private ClosedownService closedownService;

        private const string CRLF = "\r\n";

        public frmExample()
        {
            InitializeComponent();
            //휴폐업조회 모듈 초기화
            closedownService = new ClosedownService(LinkID, SecretKey);

            //연동환경 설정값, 테스트용(true), 상업옹(false)
            closedownService.IsTest = true;
        }

        private void btnCheckIsMember_Click(object sender, EventArgs e)
        {
            try
            {
                //CheckIsMember(조회할 사업자번호, 링크아이디)
                Response response = closedownService.CheckIsMember(txtCorpNum.Text, LinkID);

                MessageBox.Show(response.code.ToString() + " | " + response.message);

            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnJoinMember_Click(object sender, EventArgs e)
        {
            JoinForm joinInfo = new JoinForm();

            joinInfo.LinkID = LinkID;                 //링크아이디
            joinInfo.CorpNum = "1231212312";          //사업자번호 "-" 제외
            joinInfo.CEOName = "대표자성명";
            joinInfo.CorpName = "상호";
            joinInfo.Addr = "주소";
            joinInfo.ZipCode = "500-100";
            joinInfo.BizType = "업태";
            joinInfo.BizClass = "업종";
            joinInfo.ID = "userid";                   //6자 이상 20자 미만
            joinInfo.PWD = "pwd_must_be_long_enough"; //6자 이상 20자 미만
            joinInfo.ContactName = "담당자명";
            joinInfo.ContactTEL = "02-999-9999";
            joinInfo.ContactHP = "010-1234-5678";
            joinInfo.ContactFAX = "02-999-9998";
            joinInfo.ContactEmail = "test@test.com";

            try
            {
                Response response = closedownService.JoinMember(joinInfo);

                MessageBox.Show(response.message);

            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = closedownService.GetBalance(txtCorpNum.Text);

                MessageBox.Show(remainPoint.ToString());

            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnUnitCost_Click(object sender, EventArgs e)
        {
            try
            {
                float unitCost = closedownService.GetUnitCost(txtCorpNum.Text);

                MessageBox.Show(unitCost.ToString());

            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnGetPopbillURL_LOGIN_Click(object sender, EventArgs e)
        {
            try
            {
                string url = closedownService.GetPopbillURL(txtCorpNum.Text, txtUserID.Text, "LOGIN");
                MessageBox.Show(url);
            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnGetPopbillURL_CHRG_Click(object sender, EventArgs e)
        {
            try
            {
                string url = closedownService.GetPopbillURL(txtCorpNum.Text, txtUserID.Text, "CHRG");
                MessageBox.Show(url);
            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnGetPartnerBalance_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = closedownService.GetPartnerBalance(txtCorpNum.Text);

                MessageBox.Show(remainPoint.ToString());

            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnCheckCorpNum_Click(object sender, EventArgs e)
        {
            String tmp = "";
            
            try
            {
                CorpState result = closedownService.checkCorpNum(txtCorpNum.Text, txtCheckCorpNum.Text);

                tmp += "* state (휴폐업상태) : null-알수없음, 0-등록되지 않은 사업자번호, 1-사업중, 2-폐업, 3-휴업\n";
                tmp += "* type (사업 유형) : null-알수없음, 1-일반과세자, 2-면세과세자, 3-간이과세자, 4-비영리법인, 국가기관\n\n";
                tmp += "corpNum(사업자번호) : " + result.corpNum +"\n";
                tmp += "state(휴폐업상태) : " + result.state + "\n";
                tmp += "type(사업유형) : " + result.type + "\n";
                tmp += "stateDate(휴폐업일자) : " + result.stateDate + "\n";
                tmp += "checkDate(국세청확인일자) : " + result.checkDate + "\n";

                MessageBox.Show(tmp);
            }

            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);

            }
        }

        private void btnCheckCorpNums_Click(object sender, EventArgs e)
        {
            String tmp = "";

            List<String> CorpNumList = new List<string>();

            //조회할 사업자번호 배열, 최대 1000건
            CorpNumList.Add("1234567890");
            CorpNumList.Add("4352343543");
            CorpNumList.Add("4108600477");

            try
            {

                List<CorpState> corpStateList = closedownService.checkCorpNums(txtCorpNum.Text, CorpNumList);

                tmp += "* state (휴폐업상태) : null-알수없음, 0-등록되지 않은 사업자번호, 1-사업중, 2-폐업, 3-휴업" + CRLF;
                tmp += "* type (사업 유형) : null-알수없음, 1-일반과세자, 2-면세과세자, 3-간이과세자, 4-비영리법인, 국가기관" + CRLF + CRLF;

                for (int i = 0; i < corpStateList.Count; i++)
                {
                    tmp += "corpNum : " + corpStateList[i].corpNum + CRLF;
                    tmp += "state : " + corpStateList[i].state + CRLF;
                    tmp += "type : " + corpStateList[i].type + CRLF;
                    tmp += "stateDate(휴폐업1일자) : " + corpStateList[i].stateDate + CRLF;
                    tmp += "checkDate(국세청확인일자) : " + corpStateList[i].checkDate + CRLF + CRLF;
                }

                MessageBox.Show(tmp);
                
            }
            catch (PopbillException ex)
            {
                MessageBox.Show(ex.code.ToString() + " | " + ex.Message);
            }

        }

        private void txtCheckCorpNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCheckCorpNum.PerformClick();
            }
        }

        
    }
}