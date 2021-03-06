﻿/*
 * 팝빌 홈택스 현금영수증 연계 API DotNet SDK Example
 * 
 * - DotNet SDK 연동환경 설정방법 안내 : [개발가이드] - https://docs.popbill.com/htcashbill/tutorial/dotnet
 * - 업데이트 일자 : 2020-10-22
 * - 연동 기술지원 연락처 : 1600-9854 / 070-4304-2991
 * - 연동 기술지원 이메일 : code@linkhub.co.kr
 * 
 * <테스트 연동개발 준비사항>
 * 1) 32, 35 라인에 선언된 링크아이디(LinkID)와 비밀키(SecretKey)를 
 *    링크허브 가입시 메일로 발급받은 인증정보로 변경합니다.
 * 2) 팝빌 개발용 사이트(test.popbill.com)에 연동회원으로 가입합니다.
 * 3) 홈택스 인증 처리를 합니다. (부서사용자등록 / 공인인증서 등록)
 *    - 팝빌로그인 > [홈택스연동] > [환경설정] > [인증 관리] 메뉴
 *    - 홈택스연동 인증 관리 팝업 URL(GetCertificatePopUpURL API) 반환된 URL을 이용하여 홈택스 인증 처리를 합니다.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Popbill.HomeTax.Cashbill.Example.csharp
{
    public partial class frmExample : Form
    {
        //링크아이디
        private string LinkID = "TESTER";

        //비밀키
        private string SecretKey = "SwWxqU+0TErBXy/9TVjIPEnI0VTUMMSQZtJf3Ed8q3I=";

        private HTCashbillService htCashbillService;

        private const string CRLF = "\r\n";

        public frmExample()
        {
            InitializeComponent();

            // 홈택스 현금영수증 연계 서비서 모듈 초기화
            htCashbillService = new HTCashbillService(LinkID, SecretKey);

            // 연동환경 설정값, 개발용(true), 상업용(false)
            htCashbillService.IsTest = true;

            // 발급된 토큰에 대한 IP 제한기능 사용여부, 권장(True)
            htCashbillService.IPRestrictOnOff = true;

            // 로컬PC 시간 사용 여부 true(사용), false(기본값) - 미사용
            htCashbillService.UseLocalTimeYN = false;
        }

        /*
         * 현금영수증 매출/매입 내역 수집을 요청합니다
         * - https://docs.popbill.com/htcashbill/dotnet/api#RequestJob
         */
        private void btnRequestJob_Click(object sender, EventArgs e)
        {
            // 현금영수증 유형 SELL-매출, BUY-매입
            KeyType tiKeyType = KeyType.SELL;

            // 시작일자, 표시형식(yyyyMMdd)
            String SDate = "20190901";

            // 종료일자, 표시형식(yyyyMMdd)
            String EDate = "20190930";

            try
            {
                // 반환되는 작업아이디(jobID)의 유효시간은 1시간입니다.
                String jobID = htCashbillService.RequestJob(txtCorpNum.Text, tiKeyType, SDate, EDate);

                MessageBox.Show("작업아이디(jobID) : " + jobID, "수집 요청");

                txtJobID.Text = jobID;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "수집 요청");
            }
        }

        /*
         * 수집 요청 상태를 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetJobState
         */
        private void btnGetJobState_Click(object sender, EventArgs e)
        {
            try
            {
                HTCashbillJobState jobState = htCashbillService.GetJobState(txtCorpNum.Text, txtJobID.Text);

                String tmp = "jobID (작업아이디) : " + jobState.jobID + CRLF;
                tmp += "jobState (수집상태) : " + jobState.jobState.ToString() + CRLF;
                tmp += "queryType (수집유형) : " + jobState.queryType + CRLF;
                tmp += "queryDateType (일자유형) : " + jobState.queryDateType + CRLF;
                tmp += "queryStDate (시작일자) : " + jobState.queryStDate + CRLF;
                tmp += "queryEnDate (종료일자) : " + jobState.queryEnDate + CRLF;
                tmp += "errorCode (오류코드) : " + jobState.errorCode.ToString() + CRLF;
                tmp += "errorReason (오류메시지) : " + jobState.errorReason + CRLF;
                tmp += "jobStartDT (작업 시작일시) : " + jobState.jobStartDT + CRLF;
                tmp += "jobEndDT (작업 종료일시) : " + jobState.jobEndDT + CRLF;
                tmp += "collectCount (수집개수) : " + jobState.collectCount.ToString() + CRLF;
                tmp += "regDT (수집유형) : " + jobState.regDT + CRLF;

                MessageBox.Show(tmp, "수집 상태 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "수집 상태 확인");
            }
        }

        /*
         * 수집 요청건들에 대한 상태 목록을 확인합니다.
         * - 수집 요청 작업아이디(JobID)의 유효시간은 1시간 입니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#ListActiveJob
         */
        private void btnListActiveJob_Click(object sender, EventArgs e)
        {
            try
            {
                List<HTCashbillJobState> jobList = htCashbillService.ListActiveJob(txtCorpNum.Text);

                String tmp = "jobID(작업아이디) | jobState(수집상태) | queryType(수집유형) | queryDateType(일자유형) | queryStDate(시작일자) |";
                tmp += "queryEnDate(종료일자) | errorCode(오류코드) | errorReason(오류메시지) | jobStartDT(작업 시작일시) | jobEndDT(작업 종료일시) |";
                tmp += "collectCount(수집개수) | regDT(수집 요청일시) " + CRLF;

                for (int i = 0; i < jobList.Count; i++)
                {
                    tmp += jobList[i].jobID + " | ";
                    tmp += jobList[i].jobState.ToString() + " | ";
                    tmp += jobList[i].queryType + " | ";
                    tmp += jobList[i].queryDateType + " | ";
                    tmp += jobList[i].queryStDate + " | ";
                    tmp += jobList[i].queryEnDate + " | ";
                    tmp += jobList[i].errorCode.ToString() + " | ";
                    tmp += jobList[i].errorReason + " | ";
                    tmp += jobList[i].jobStartDT + " | ";
                    tmp += jobList[i].jobEndDT + " | ";
                    tmp += jobList[i].collectCount.ToString() + " | ";
                    tmp += jobList[i].regDT;

                    tmp += CRLF + CRLF;
                }

                if (jobList.Count > 0) txtJobID.Text = jobList[0].jobID;


                MessageBox.Show(tmp, "수집 목록 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "수집 목록 확인");
            }
        }

        /*
         * 현금영수증 매입/매출 내역의 수집 결과를 조회합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#Search
         */
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 현금영수증 형태 배열, N-일반 현금영수증, C-취소 현금영수증
            String[] TradeType = { "N", "C" };

            // 거래용도 배열, P-소득공제용, C-지출증빙용
            String[] TradeUsage = { "P", "C" };

            // 페이지번호
            int Page = 1;

            // 페이지당 목록개수, 최대 1000건
            int PerPage = 10;

            // 정렬방향 D-내림차순, A-오름차순
            String Order = "D";

            listBox1.Items.Clear();

            try
            {
                HTCashbillSearch searchInfo = htCashbillService.Search(txtCorpNum.Text, txtJobID.Text, TradeType,
                    TradeUsage, Page, PerPage, Order, txtUserId.Text);

                String tmp = "code (응답코드) : " + searchInfo.code.ToString() + CRLF;
                tmp += "message (응답메시지) : " + searchInfo.message + CRLF;
                tmp += "total (총 검색결과 건수) : " + searchInfo.total.ToString() + CRLF;
                tmp += "perPage (페이지당 검색개수) : " + searchInfo.perPage + CRLF;
                tmp += "pageNum (페이지 번호) : " + searchInfo.pageNum + CRLF;
                tmp += "pageCount (페이지 개수) : " + searchInfo.pageCount + CRLF;

                MessageBox.Show(tmp, "수집 결과 조회");

                string rowStr = "ntsconfirmNum(국세청승인번호) | tradeDate(거래일자) | tradeDT(거래일시) | tradeType(문서형태) | tradeUsage(거래구분) | totalAmount(거래금액) |";
                rowStr += "supplyCost(공급가액) | tax(부가세) | serviceFee(봉사료) | invoiceType(매입/매출) | franchiseCorpNum(발행자 사업자번호) | franchiseCorpName(발행자 상호) |  ";
                rowStr += "franchiseCorpType(발행자 사업자유형) | identityNum(식별번호) | identityNumType(식별변호유형) | customerName(고객명) | cardOwnerName(카드소유자명) | deductionType(공제유형)";

                listBox1.Items.Add(rowStr);

                // 현금영수증 항목에 대한 추가적인 정보는 [연동매뉴얼 4.1. 응답전문 구성] 를 참조하시기 바랍니다.
                for (int i = 0; i < searchInfo.list.Count; i++)
                {
                    rowStr = null;
                    rowStr += searchInfo.list[i].ntsconfirmNum + " | ";
                    rowStr += searchInfo.list[i].tradeDate + " | ";
                    rowStr += searchInfo.list[i].tradeDT + " | ";
                    rowStr += searchInfo.list[i].tradeType + " | ";
                    rowStr += searchInfo.list[i].tradeUsage + " | ";
                    rowStr += searchInfo.list[i].totalAmount + " | ";
                    rowStr += searchInfo.list[i].supplyCost + " | ";
                    rowStr += searchInfo.list[i].tax + " | ";
                    rowStr += searchInfo.list[i].serviceFee + " | ";
                    rowStr += searchInfo.list[i].invoiceType + " | ";
                    rowStr += searchInfo.list[i].franchiseCorpNum + " | ";
                    rowStr += searchInfo.list[i].franchiseCorpName + " | ";
                    rowStr += searchInfo.list[i].franchiseCorpType + " | ";
                    rowStr += searchInfo.list[i].identityNum + " | ";
                    rowStr += searchInfo.list[i].identityNumType + " | ";
                    rowStr += searchInfo.list[i].customerName + " | ";
                    rowStr += searchInfo.list[i].cardOwnerName + " | ";
                    rowStr += searchInfo.list[i].deductionType + " | ";


                    listBox1.Items.Add(rowStr);
                }
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "수집 결과 조회");
            }
        }

        /*
         * 현금영수증 매입/매출 내역의 수집 결과 요약정보를 조회합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#Summary
         */
        private void btnSummary_Click(object sender, EventArgs e)
        {
            // 현금영수증 형태 배열, N-일반 현금영수증, C-취소 현금영수증
            String[] TradeType = { "N", "C" };

            // 거래용도 배열, P-소득공제용, C-지출증빙용
            String[] TradeUsage = { "P", "C" };

            try
            {
                HTCashbillSummary summaryInfo =
                    htCashbillService.Summary(txtCorpNum.Text, txtJobID.Text, TradeType, TradeUsage);

                String tmp = "count (수집 결과 건수) : " + summaryInfo.count.ToString() + CRLF;
                tmp += "supplyCostTotal (공급가액 합계) : " + summaryInfo.supplyCostTotal.ToString() + CRLF;
                tmp += "taxTotal (세액 합계) : " + summaryInfo.taxTotal.ToString() + CRLF;
                tmp += "serviceFeeTotal (봉사료 합계) : " + summaryInfo.serviceFeeTotal.ToString() + CRLF;
                tmp += "amountTotal (합계 금액) : " + summaryInfo.amountTotal.ToString() + CRLF;

                MessageBox.Show(tmp, "수집 결과 요약정보 조회");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "수집 결과 요약정보 조회");
            }
        }

        /*
         * 홈택스연동 인증관리를 위한 URL을 반환합니다.
         * 인증방식에는 부서사용자/인증서 인증 방식이 있습니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetCertificatePopUpURL
         */
        private void btnGetCertificatePopUpURL_Click(object sender, EventArgs e)
        {
            try
            {
                String url = htCashbillService.GetCertificatePopUpURL(txtCorpNum.Text, txtUserId.Text);

                MessageBox.Show(url, "홈택스연동 인증관리 URL");
                textURL.Text = url;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "홈택스연동 인증관리 URL");
            }
        }

        /*
         * 팝빌에 등록된 홈택스 공인인증서의 만료일자를 반환합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetCertificateExpireDate
         */
        private void btnGetCertificateExpireDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime expiration = htCashbillService.GetCertificateExpireDate(txtCorpNum.Text);

                MessageBox.Show(expiration.ToString(), "공인인증서 만료일시 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "공인인증서 만료일시 확인");
            }
        }

        /*
         * 팝빌에 등록된 공인인증서의 홈택스 로그인을 테스트합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#CheckCertValidation
         */
        private void btnCheckCertValidation_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.CheckCertValidation(txtCorpNum.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "홈택스 공인인증서 로그인 테스트");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "홈택스 공인인증서 로그인 테스트");
            }
        }

        /*
         *  홈택스 현금영수증 부서사용자 계정을 등록한다.
         *  - https://docs.popbill.com/htcashbill/dotnet/api#RegistDeptUser
         */
        private void btnRegistDeptUser_Click(object sender, EventArgs e)
        {
            // 홈택스에서 생성한 현금영수증 부서사용자 아이디
            String deptUserID = "userid";

            // 홈택스에서 생성한 현금영수증 부서사용자 비밀번호
            String deptUserPWD = "passwd";

            try
            {
                Response response = htCashbillService.RegistDeptUser(txtCorpNum.Text, deptUserID, deptUserPWD);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "부서사용자 계정등록");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "부서사용자 계정등록");
            }
        }

        /*
         * 팝빌에 등록된 현금영수증 부서사용자 아이디를 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#CheckDeptUser
         */
        private void btnCheckDeptUser_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.CheckDeptUser(txtCorpNum.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "부서사용자 등록정보 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "부서사용자 등록정보 확인");
            }
        }

        /*
         * 팝빌에 등록된 현금영수증 부서사용자 계정정보를 이용하여 홈택스 로그인을 테스트한다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#CheckLoginDeptUser
         */
        private void btnCheckLoginDeptUser_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.CheckLoginDeptUser(txtCorpNum.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "부서사용자 로그인 테스트");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "부서사용자 로그인 테스트");
            }
        }

        /*
         *  팝빌에 등록된 현금영수증 부서사용자 계정정보를 삭제한다.
         *  - https://docs.popbill.com/htcashbill/dotnet/api#DeleteDeptUser
         */
        private void btnDeleteDeptUser_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.DeleteDeptUser(txtCorpNum.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "부서사용자 등록정보 삭제");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "부서사용자 등록정보 삭제");
            }
        }

        /*
         * 연동회원의 잔여포인트를 조회합니다.
         * - 파트너 과금 방식의 경우 파트너 잔여포인트 조회(GetPartnerBalance API) 기능을 사용하시기 바랍니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetBalance
         */
        private void btnGetBalance_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = htCashbillService.GetBalance(txtCorpNum.Text);

                MessageBox.Show("잔여포인트 : " + remainPoint.ToString(), "연동회원 잔여포인트 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "연동회원 잔여포인트 확인");
            }
        }

        /*
         * 팝빌 연동회원 포인트충전 팝업 URL을 반환합니다.
         * - 반환된 URL은 보안정책으로 인해 30초의 유효시간을 갖습니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetChargeURL
         */
        private void btnGetChargeURL_Click(object sender, EventArgs e)
        {
            try
            {
                string url = htCashbillService.GetChargeURL(txtCorpNum.Text, txtUserId.Text);

                MessageBox.Show(url, "포인트 충전 URL 확인");
                textURL.Text = url;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "포인트 충전 URL");
            }
        }

        /*
         * 파트너의 잔여포인트를 확인합니다.
         * - 과금방식이 연동과금인 경우 연동회원 잔여포인트(GetBalance API)를 이용하시기 바랍니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetPartnerBalance
         */
        private void btnGetPartnerBalance1_Click(object sender, EventArgs e)
        {
            try
            {
                double remainPoint = htCashbillService.GetPartnerBalance(txtCorpNum.Text);

                MessageBox.Show("파트너 잔여포인트 : " + remainPoint.ToString(), "파트너 잔여포인트 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "파트너 잔여포인트 확인");
            }
        }

        /*
         * 파트너 포인트 충전 팝업 URL을 반환합니다. 
         * - 반환된 URL은 보안정책상 30초의 유효시간을 갖습니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetPartnerURL
         */
        private void btnGetPartnerURL_CHRG_Click(object sender, EventArgs e)
        {
            try
            {
                string url = htCashbillService.GetPartnerURL(txtCorpNum.Text, "CHRG");

                MessageBox.Show(url, "파트너 포인트충전 URL");
                textURL.Text = url;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "파트너 포인트충전 URL");
            }
        }

        /*
         * 홈택스 현금영수증 연계 서비스 과금정보를 확인합니다. 
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetChargeInfo
         */
        private void btnGetChargeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                ChargeInfo chrgInf = htCashbillService.GetChargeInfo(txtCorpNum.Text);

                string tmp = null;
                tmp += "unitCost (단가-월정액요금) : " + chrgInf.unitCost + CRLF;
                tmp += "chargeMethod (과금유형) : " + chrgInf.chargeMethod + CRLF;
                tmp += "rateSystem (과금제도) : " + chrgInf.rateSystem + CRLF;

                MessageBox.Show(tmp, "과금정보 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "과금정보 확인");
            }
        }

        /*
         * 정액제 신청 팝업 URL을 반환합니다.
         * - 반환된 URL은 보안정책에 따라 30초의 유효시간을 갖습니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetFlatRatePopUpURL
         */
        private void btnGetFlatRatePopUpURL_Click(object sender, EventArgs e)
        {
            try
            {
                String url = htCashbillService.GetFlatRatePopUpURL(txtCorpNum.Text, txtUserId.Text);

                MessageBox.Show(url, "정액제 서비스 신청 URL");
                textURL.Text = url;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "정액제 서비스 신청 URL");
            }
        }

        /*
         * 연동회원의 정액제 서비스 상태를 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetFlatRateState
         */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HTFlatRate rateInfo = htCashbillService.GetFlatRateState(txtCorpNum.Text, txtUserId.Text);

                String tmp = "referenceID(사업자번호) : " + rateInfo.referenceID + CRLF;
                tmp += "contractDT(정액제 서비스 시작일시) : " + rateInfo.contractDT + CRLF;
                tmp += "useEndDate(정액제 서비스 종료일) : " + rateInfo.useEndDate + CRLF;
                tmp += "baseDate(자동연장 결제일) : " + rateInfo.baseDate.ToString() + CRLF;
                tmp += "state(정액제 서비스 상태) : " + rateInfo.state.ToString() + CRLF;
                tmp += "closeRequestYN(정액제 서비스 해지신청 여부) : " + rateInfo.closeRequestYN.ToString() + CRLF;
                tmp += "useRestrictYN(정액제 서비스 사용제한 여부) : " + rateInfo.useRestrictYN.ToString() + CRLF;
                tmp += "closeOnExpired(정액제 서비스 만료 시 해지 여부) : " + rateInfo.closeOnExpired.ToString() + CRLF;
                tmp += "unPaidYN(미수금 보유 여부) : " + rateInfo.unPaidYN.ToString() + CRLF;

                MessageBox.Show(tmp, "정액제 서비스 상태 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "정액제 서비스 상태 확인");
            }
        }

        /*
         * 해당 사업자의 파트너 연동회원 가입여부를 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#CheckIsMember
         */
        private void btnCheckIsMember_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.CheckIsMember(txtCorpNum.Text, LinkID);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "연동회원 가입여부 확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "연동회원 가입여부 확인");
            }
        }

        /*
         * 회원아이디 중복여부를 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#CheckID
         */
        private void btnCheckID_Click(object sender, EventArgs e)
        {
            try
            {
                Response response = htCashbillService.CheckID(txtUserId.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "ID 중복확인");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "ID 중복확인");
            }
        }

        /*
         * 파트너의 연동회원으로 신규가입 처리합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#JoinMember
         */
        private void btnJoinMember_Click(object sender, EventArgs e)
        {
            JoinForm joinInfo = new JoinForm();

            // 아이디, 6자이상 50자 미만
            joinInfo.ID = "userid";

            // 비밀번호, 6자이상 20자 미만
            joinInfo.PWD = "pwd_must_be_long_enough";

            // 링크아이디
            joinInfo.LinkID = LinkID;

            // 사업자번호 "-" 제외
            joinInfo.CorpNum = "1231212312";

            // 대표자명 (최대 100자)
            joinInfo.CEOName = "대표자성명";

            // 상호 (최대 200자)
            joinInfo.CorpName = "상호";

            // 사업장 주소 (최대 300자)
            joinInfo.Addr = "주소";

            // 업태 (최대 100자)
            joinInfo.BizType = "업태";

            // 종목 (최대 100자)
            joinInfo.BizClass = "종목";

            // 담당자 성명 (최대 100자)
            joinInfo.ContactName = "담당자명";

            // 담당자 이메일 (최대 20자)
            joinInfo.ContactEmail = "test@test.com";

            // 담당자 연락처 (최대 20자)
            joinInfo.ContactTEL = "070-4304-2991";

            // 담당자 휴대폰번호 (최대 20자)
            joinInfo.ContactHP = "010-111-222";

            // 담당자 팩스번호 (최대 20자)
            joinInfo.ContactFAX = "02-6442-9700";

            try
            {
                Response response = htCashbillService.JoinMember(joinInfo);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "연동회원 가입요청");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "연동회원 가입요청");
            }
        }


        /*
         * 팝빌에 로그인 상태로 접근할 수 있는 팝업 URL을 반환합니다.
         * - 반환된 URL은 보안정책으로 인해 30초의 유효시간을 갖습니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetAccessURL
         */
        private void btnGetAccessURL_Click(object sender, EventArgs e)
        {
            try
            {
                string url = htCashbillService.GetAccessURL(txtCorpNum.Text, txtUserId.Text);

                MessageBox.Show(url, "팝빌 로그인 URL 확인");
                textURL.Text = url;
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "팝빌 로그인 URL 확인");
            }
        }

        /*
         * 연동회원의 회사정보를 조회합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#GetCorpInfo
         */
        private void btnGetCorpInfo_Click(object sender, EventArgs e)
        {
            try
            {
                CorpInfo corpInfo = htCashbillService.GetCorpInfo(txtCorpNum.Text, txtUserId.Text);

                string tmp = null;
                tmp += "ceoname (대표자명) : " + corpInfo.ceoname + CRLF;
                tmp += "corpName (상호명) : " + corpInfo.corpName + CRLF;
                tmp += "addr (주소) : " + corpInfo.addr + CRLF;
                tmp += "bizType (업태) : " + corpInfo.bizType + CRLF;
                tmp += "bizClass (종목) : " + corpInfo.bizClass + CRLF;

                MessageBox.Show(tmp, "회사정보 조회");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "회사정보 조회");
            }
        }

        /*
         * 연동회원의 회사정보를 수정합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#UpdateCorpInfo
         */
        private void btnUpdateCorpInfo_Click(object sender, EventArgs e)
        {
            CorpInfo corpInfo = new CorpInfo();

            // 대표자성명 (최대 100자)
            corpInfo.ceoname = "대표자명 테스트";

            // 상호 (최대 200자)
            corpInfo.corpName = "업체명";

            // 주소 (최대 300자)
            corpInfo.addr = "주소정보 수정";

            // 업태 (최대 100자)
            corpInfo.bizType = "업태정보 수정";

            // 종목 (최대 100자)
            corpInfo.bizClass = "종목 수정";

            try
            {
                Response response = htCashbillService.UpdateCorpInfo(txtCorpNum.Text, corpInfo, txtUserId.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "회사정보 수정");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "회사정보 수정");
            }
        }

        /*
         * 연동회원의 담당자를 추가합니다. 
         * - https://docs.popbill.com/htcashbill/dotnet/api#RegistContact
         */
        private void btnRegistContact_Click(object sender, EventArgs e)
        {
            Contact contactInfo = new Contact();

            //담당자 아이디, 6자 이상 50자 미만
            contactInfo.id = "testkorea_20190110";

            //비밀번호, 6자 이상 20자 미만
            contactInfo.pwd = "user_password";

            //담당자 성명 (최대 100자) 
            contactInfo.personName = "담당자명";

            //담당자연락처 (최대 20자)
            contactInfo.tel = "070-4304-2991";

            //담당자 휴대폰번호 (최대 20자)
            contactInfo.hp = "010-111-222";

            //담당자 팩스번호 (최대 20자)
            contactInfo.fax = "070-4304-2991";

            //담당자 이메일 (최대 100자)
            contactInfo.email = "dev@linkhub.co.kr";

            // 회사조회 권한여부, true(회사조회), false(개인조회)
            contactInfo.searchAllAllowYN = true;

            // 관리자 권한여부 
            contactInfo.mgrYN = false;

            try
            {
                Response response = htCashbillService.RegistContact(txtCorpNum.Text, contactInfo, txtUserId.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "담당자 추가");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "담당자 추가");
            }
        }

        /*
         * 연동회원의 담당자 정보 목록을 확인합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#ListContact
         */
        private void btnListContact_Click(object sender, EventArgs e)
        {
            try
            {
                List<Contact> contactList = htCashbillService.ListContact(txtCorpNum.Text, txtUserId.Text);

                string tmp = null;

                foreach (Contact contactInfo in contactList)
                {
                    tmp += "id (담당자 아이디) : " + contactInfo.id + CRLF;
                    tmp += "personName (담당자명) : " + contactInfo.personName + CRLF;
                    tmp += "email (담당자 이메일) : " + contactInfo.email + CRLF;
                    tmp += "hp (휴대폰번호) : " + contactInfo.hp + CRLF;
                    tmp += "searchAllAllowYN (회사조회 여부) : " + contactInfo.searchAllAllowYN + CRLF;
                    tmp += "tel (연락처) : " + contactInfo.tel + CRLF;
                    tmp += "fax (팩스번호) : " + contactInfo.fax + CRLF;
                    tmp += "mgrYN (관리자 여부) : " + contactInfo.mgrYN + CRLF;
                    tmp += "regDT (등록일시) : " + contactInfo.regDT + CRLF;
                    tmp += "state (상태) : " + contactInfo.state + CRLF;
                    tmp += CRLF;
                }

                MessageBox.Show(tmp, "담당자 목록조회");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "담당자 목록조회");
            }
        }

        /*
         * 담당자 정보를 수정합니다.
         * - https://docs.popbill.com/htcashbill/dotnet/api#UpdateContact
         */
        private void btnUpdateContact_Click(object sender, EventArgs e)
        {
            Contact contactInfo = new Contact();

            // 담당자 아이디
            contactInfo.id = txtUserId.Text;

            // 담당자 성명 (최대 100자)
            contactInfo.personName = "담당자123";

            // 연락처 (최대 20자)
            contactInfo.tel = "070-4304-2991";

            // 휴대폰번호 (최대 20자)
            contactInfo.hp = "010-1234-1234";

            // 팩스번호 (최대 20자)
            contactInfo.fax = "02-6442-9700";

            // 이메일주소 (최대 100자)
            contactInfo.email = "dev@linkhub.co.kr";

            // 회사조회 권한여부, true(회사조회), false(개인조회)
            contactInfo.searchAllAllowYN = true;

            // 관리자 권한여부 
            contactInfo.mgrYN = false;

            try
            {
                Response response = htCashbillService.UpdateContact(txtCorpNum.Text, contactInfo, txtUserId.Text);

                MessageBox.Show("응답코드(code) : " + response.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + response.message, "담당자 정보 수정");
            }
            catch (PopbillException ex)
            {
                MessageBox.Show("응답코드(code) : " + ex.code.ToString() + "\r\n" +
                                "응답메시지(message) : " + ex.Message, "담당자 정보 수정");
            }
        }
    }
}