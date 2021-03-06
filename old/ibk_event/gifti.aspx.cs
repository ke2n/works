﻿using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data.SqlClient;
using System.Xml;
using System.IO;
using System.Net;
using System.Text;

public partial class gifti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Response.Write("OVER");
        /*string source = @"Server=10.107.1.20;uid=DM_User;pwd=P@ssw0rd10;database=TAGTV";
        string input_name = Request.Form["name"];
        string input_phone = Request.Form["phone"];

        SqlConnection conn = new SqlConnection(source);
        conn.Open();
        
        //폰넘버 중북검사를 위한 쿼리
        string sql = "select * from IBK_GIFTI_LOG where phone = '" + input_phone + "'";
        
        SqlCommand cmd = new SqlCommand(sql, conn);
        SqlDataReader reader = cmd.ExecuteReader();

        bool isexist = reader.Read();
        reader.Close();
        
        //하루 초과량 검사를 위한 쿼리
        string sql2 = "select count(no) from IBK_GIFTI_LOG where day = '" + DateTime.Now.AddHours(-8).ToString("dd") + "' and month = '" + DateTime.Now.AddHours(-8).ToString("MM") + "'";

        SqlCommand cmd2 = new SqlCommand(sql2, conn);
        SqlDataReader reader2 = cmd2.ExecuteReader();

        reader2.Read();
        int count_today = int.Parse(reader2[0].ToString());
        reader2.Close();

        if (count_today < 100)
        {
            if (!isexist && input_name != null && input_phone != null)
            {
                Random r = new Random();
                int rand1 = r.Next(1, 10);
                int rand2 = r.Next(10, 100);
                //1~3:(IBK 영문 고유값), 4:(한자리랜덤난수), 5~14:(월일분시의 순서값), 15~16:(두자리랜덤난수)
                string order_num = "IBK" + rand1 + DateTime.Now.ToString("MMddhhmmss") + rand2;

                string gifti_param = "CAMP_ID=M1003561";//캠페인ID
                      gifti_param += "&PRD_TYPE=N";//상품구분(고정값)
                      gifti_param += "&PRD_ID=S0003148";//상품ID
                      gifti_param += "&PRD_QTY=1";//상품수량
                      gifti_param += "&USER_MDN=" + input_phone;//수신자 폰NUM
                      gifti_param += "&SMS_MSG=" + HttpUtility.UrlEncode("『IBK기업은행』스마트모닝 이벤트 기프티콘선물도착!", System.Text.Encoding.GetEncoding("euc-kr"));//기프티콘선물도착 메시지
                      gifti_param += "&MB_INFO=0";//무선안내페이지 번호(고정값)
                      gifti_param += "&GF_NUM=";//기프티콘꾸미기 이미지
                      gifti_param += "&GF_MSG=" + HttpUtility.UrlEncode("『IBK기업은행』스마트모닝 이벤트 기프티콘선물도착!", System.Text.Encoding.GetEncoding("euc-kr"));//기프티콘꾸미기 메시지
                      gifti_param += "&USER_ID=";//고객식별 ID
                      gifti_param += "&CB_PHONE=15662566";//발신자 폰NUM
                      gifti_param += "&TR_ID=" + order_num;//고객사 고유ID
                      gifti_param += "&SMS_SEND=Y";//SMS보내기

                string gifti_result = getXml(gifti_param);
                string [] arrText = gifti_result.Split(':');

                //1. 성공적인 전송인지 구분하려면 구분자를 이용한 판별이 필요하며,
                //2. 기프티콘전송이 성공적으로 완료되면 이어서 DB에 저장하는 로직구성해야함
                if (arrText[0] == "[CHECK CODE]0")
                {
                    sql = "insert into IBK_GIFTI_LOG(order_num, order_id, name, phone, year, month, day, date)";
                    sql+= "values ('" + order_num + "',";
					sql+= "'" + arrText[2] + "',";
					sql+= "'" + input_name + "',";
					sql+= "'" + input_phone + "',";
					sql+= "'" + DateTime.Now.AddHours(-8).ToString("yyyy") + "',";
					sql+= "'" + DateTime.Now.AddHours(-8).ToString("MM") + "',";
					sql+= "'" + DateTime.Now.AddHours(-8).ToString("dd") + "',";
					sql+= "'" + DateTime.Now.ToString() + "')";

                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();

                    Response.Write("OK");
                }
                else
                {
                    Response.Write(arrText[0]);
                }
            }
            else
            {
                Response.Write("RE");
            }
        }else{
            Response.Write("OVER");
        }
        conn.Close();*/
    }

    public string getXml(string query)
    {
        //http : // 아이피:포트 / 파일명
        string url = "http://cm.gifticon.com/ncmSend.gc";
        //쿼리를 꼭 인코딩 해주자. jsp: URLEncoder.encode, ASP: Server.URLEncode
        //PHP iconv
        //url = url + "?" + HttpUtility.UrlEncode(query);
        url = url + "?" + query;
        string getXmlData = getHtmls(url);
        return getXmlData;
    }

    /**
     * 웹서버로 부터 xml 결과값을 가져온다
     * @param reciverURL 웹서버 주소
     * @return 웹서버로터의 결과 xml 값
     */
    private string getHtmls(string receiverURL)
    {
        //JSP: URLConnection, ASP MSXML2.serverXMLHTTP,
        // PHP fsockopen
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(receiverURL);
        //xml값을 확인하기 위해 선언
        request.ContentType = "text/xml";
        request.Method = "GET";
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream receiveStream = response.GetResponseStream();
        //넘어오는값에 따라 인코딩 해주어야 한다.
        StreamReader readStream =
                     new StreamReader(receiveStream, Encoding.GetEncoding("euc-kr"));
        string xmlResult = readStream.ReadToEnd().Trim();
        response.Close();
        readStream.Close();
        return xmlResult;
    }
}
