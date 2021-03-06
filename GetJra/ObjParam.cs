using System.Collections.Generic;

namespace jrascraping.GetJra
{
    public class ObjParam
    {
        public static string ObjParamCname(string arg)
        {
            var objParams = new Dictionary<string, string>
            {
                //JRA公式HP 過去レース結果検索内
{"0001","AD"},
{"0002","7B"},
{"0003","49"},
{"0004","17"},
{"0005","E5"},
{"0006","B3"},
{"0007","81"},
{"0008","4F"},
{"0009","1D"},
{"0010","8C"},
{"0011","5A"},
{"0012","28"},
{"0101","39"},
{"0102","07"},
{"0103","D5"},
{"0104","A3"},
{"0105","71"},
{"0106","3F"},
{"0107","0D"},
{"0108","DB"},
{"0109","A9"},
{"0110","18"},
{"0111","E6"},
{"0112","B4"},
{"0201","C5"},
{"0202","93"},
{"0203","61"},
{"0204","2F"},
{"0205","FD"},
{"0206","CB"},
{"0207","99"},
{"0208","67"},
{"0209","35"},
{"0210","A4"},
{"0211","72"},
{"0212","40"},
{"0301","51"},
{"0302","1F"},
{"0303","ED"},
{"0304","BB"},
{"0305","89"},
{"0306","57"},
{"0307","25"},
{"0308","F3"},
{"0309","C1"},
{"0310","30"},
{"0311","FE"},
{"0312","CC"},
{"0401","DD"},
{"0402","AB"},
{"0403","79"},
{"0404","47"},
{"0405","15"},
{"0406","E3"},
{"0407","B1"},
{"0408","7F"},
{"0409","4D"},
{"0410","BC"},
{"0411","8A"},
{"0412","58"},
{"0501","69"},
{"0502","37"},
{"0503","05"},
{"0504","D3"},
{"0505","A1"},
{"0506","6F"},
{"0507","3D"},
{"0508","0B"},
{"0509","D9"},
{"0510","48"},
{"0511","16"},
{"0512","E4"},
{"0601","F5"},
{"0602","C3"},
{"0603","91"},
{"0604","5F"},
{"0605","2D"},
{"0606","FB"},
{"0607","C9"},
{"0608","97"},
{"0609","65"},
{"0610","D4"},
{"0611","A2"},
{"0612","70"},
{"0701","81"},
{"0702","4F"},
{"0703","1D"},
{"0704","EB"},
{"0705","B9"},
{"0706","87"},
{"0707","55"},
{"0708","23"},
{"0709","F1"},
{"0710","60"},
{"0711","2E"},
{"0712","FC"},
{"0801","0D"},
{"0802","DB"},
{"0803","A9"},
{"0804","77"},
{"0805","45"},
{"0806","13"},
{"0807","E1"},
{"0808","AF"},
{"0809","7D"},
{"0810","EC"},
{"0811","BA"},
{"0812","88"},
{"0901","99"},
{"0902","67"},
{"0903","35"},
{"0904","03"},
{"0905","D1"},
{"0906","9F"},
{"0907","6D"},
{"0908","3B"},
{"0909","09"},
{"0910","78"},
{"0911","46"},
{"0912","14"},
{"1001","18"},
{"1002","E6"},
{"1003","B4"},
{"1004","82"},
{"1005","50"},
{"1006","1E"},
{"1007","EC"},
{"1008","BA"},
{"1009","88"},
{"1010","F7"},
{"1011","C5"},
{"1012","93"},
{"1101","A4"},
{"1102","72"},
{"1103","40"},
{"1104","0E"},
{"1105","DC"},
{"1106","AA"},
{"1107","78"},
{"1108","46"},
{"1109","14"},
{"1110","83"},
{"1111","51"},
{"1112","1F"},
{"1201","30"},
{"1202","FE"},
{"1203","CC"},
{"1204","9A"},
{"1205","68"},
{"1206","36"},
{"1207","04"},
{"1208","D2"},
{"1209","A0"},
{"1210","0F"},
{"1211","DD"},
{"1212","AB"},
{"1301","BC"},
{"1302","8A"},
{"1303","58"},
{"1304","26"},
{"1305","F4"},
{"1306","C2"},
{"1307","90"},
{"1308","5E"},
{"1309","2C"},
{"1310","9B"},
{"1311","69"},
{"1312","37"},
{"1401","48"},
{"1402","16"},
{"1403","E4"},
{"1404","B2"},
{"1405","80"},
{"1406","4E"},
{"1407","1C"},
{"1408","EA"},
{"1409","B8"},
{"1410","27"},
{"1411","F5"},
{"1412","C3"},
{"1501","D4"},
{"1502","A2"},
{"1503","70"},
{"1504","3E"},
{"1505","0C"},
{"1506","DA"},
{"1507","A8"},
{"1508","76"},
{"1509","44"},
{"1510","B3"},
{"1511","81"},
{"1512","4F"},
{"1601","60"},
{"1602","2E"},
{"1603","FC"},
{"1604","CA"},
{"1605","98"},
{"1606","66"},
{"1607","34"},
{"1608","02"},
{"1609","D0"},
{"1610","3F"},
{"1611","0D"},
{"1612","DB"},
{"1701","EC"},
{"1702","BA"},
{"1703","88"},
{"1704","56"},
{"1705","24"},
{"1706","F2"},
{"1707","C0"},
{"1708","8E"},
{"1709","5C"},
{"1710","CB"},
{"1711","99"},
{"1712","67"},
{"1801","78"},
{"1802","46"},
{"1803","14"},
{"1804","E2"},
{"1805","B0"},
{"1806","7E"},
{"1807","4C"},
{"1808","1A"},
{"1809","E8"},
{"1810","57"},
{"1811","25"},
{"1812","F3"},
{"1901","04"},
{"1902","D2"},
{"1903","A0"},
{"1904","6E"},
{"1905","3C"},
{"1906","0A"},
{"1907","D8"},
{"1908","A6"},
{"1909","74"},
{"1910","E3"},
{"1911","B1"},
{"1912","7F"},
{"2001","83"},
{"2002","51"},
{"2003","1F"},
{"2004","ED"},
{"2005","BB"},
{"2006","89"},
{"2007","57"},
{"2008","25"},
{"2009","F3"},
{"2010","62"},
{"2011","30"},
{"2012","FE"},
{"2101","0F"},
{"2102","DD"},
{"2103","AB"},
{"2104","79"},
{"2105","47"},
{"2106","15"},
{"2107","FC"},
{"2108","CA"},
{"2109","98"},
{"2110","07"},
{"2111","D5"},
{"2112","A3"}
            }; 
            return objParams[arg];
        }
    }
}
