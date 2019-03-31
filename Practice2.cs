using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sex1 = Convert.ToString(sex); //"M"

            char place = '3';//to int
			string placeStr = (Convert.ToChar(Convert.ToInt16(place))).ToString(); //"3"(string)
			int placeInt = Convert.ToInt16(placeStr);//"3"(int)

			
			char hasFingerPrints = '0';//to boolean
			int hasFingerPrintsInt = Convert.ToInt16(hasFingerPrints);//"48"
			bool hasFingerPrintsBool = Convert.ToBoolean(hasFingerPrintsInt);//"True"
			
			//2. STRING CONVERSION           
			string hasPhotoString = "True";//to bolean
			bool hasPhotoStringBoll = Convert.ToBoolean(hasPhotoString);//"True"
			
			string flatNumber = "34";//to int
			int flatNumberint = Convert.ToInt16(flatNumber);//"34"
			
			string visaPriceString = "34,23";//to float
			float visaPriceStringf = Convert.ToSingle(visaPriceString);//"34,23"

			string photoPriceString = "7.23";//to float
			photoPriceString = photoPriceString.Replace('.', ',');// "7,23"
			float photoPriceStringf = Convert.ToSingle(photoPriceString);//"7,23"
			
			//3. BOOL CONVERSION
			bool hasFree2Pages = false;//to string, to char, to int
			string hasFree2PagesStr = hasFree2Pages.ToString();//"False"
			int hasFree2PagesInt = Convert.ToInt16(hasFree2Pages);//"0"
			char hasFree2PagesChar = Convert.ToChar(hasFree2PagesInt);//" "
			
			//4. DECIMAL CONVERSION
			double visaPrice = 60;//to int, to string
			int visaPriceInt = (int)visaPrice;//"60"
			string visaPriceStr = Convert.ToString(visaPrice);//"60"
			
			double finterPrintsPrice = 55.2;//to int, to string
			int finterPrintsPriceInt = (int)finterPrintsPrice;//"55"
			string finterPrintsPriceStr = Convert.ToString(finterPrintsPrice);//"55,2"
			
			//4. INT CONVERSION
			int birthYear = 2000;//to string, to double, to char
			string birthYearStr = Convert.ToString(birthYear);//'2000'
			double birthYearDb = Convert.ToDouble(birthYear);//'2000'
			char birhtYearChar = Convert.ToChar(birthYear);//"?'
			
			int hasPhotoInt = 1;//to boolean
			bool hasPhotoStr = Convert.ToBoolean(hasPhotoInt);//"False"
			
		}
    }
}
