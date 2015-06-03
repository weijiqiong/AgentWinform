using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgentWinform.Common
{
    public class TrueStrLength
    {
        public TrueStrLength()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        static public int trueLength(string str)
        {

            // str 字符串
            // return 字符串的字节长度
            int lenTotal = 0;
            int n = str.Length;
            string strWord = "";
            int asc;
            for (int i = 0; i < n; i++)
            {
                strWord = str.Substring(i, 1);
                asc = Convert.ToChar(strWord);
                if (asc < 0 || asc > 127)
                    lenTotal = lenTotal + 2;
                else
                    lenTotal = lenTotal + 1;
            }

            return lenTotal;
        }

        static public string cutTrueLength(string strOriginal,int minTrueLength, int maxTrueLength)
        {
            string strNew = string.Empty;
            int trueLen = trueLength(strOriginal);
            int min=0, max=0;
            for (int i = 0; i < strOriginal.Length; i++)
            {
                strNew = strOriginal.Substring(0, i);
               int count= trueLength(strNew);
                if (count<=minTrueLength)
                {
                    min = i;
                }
                else if (count<=maxTrueLength)
                {
                    max = i;
                }
            }
            if (max==0)
            {
                return strOriginal.Substring(min);
            }
            else
            {
                return strOriginal.Substring(min, max - min);
            }

            
        }

        static public string cutTrueLength(string strOriginal, int maxTrueLength, char chrPad, bool blnCutTail)
        {

            // strOriginal 原始字符串
            // maxTrueLength 需要返回的字符串的字节长度
            // chrPad 字符串不够时的填充字符
            // blnCutTail 字符串的字节长度超过maxTrueLength时是否截断多余字符
            // return 返回填充或截断后的字符串
            string strNew = strOriginal;

            if (strOriginal == null || maxTrueLength <= 0)
            {
                strNew = "";
                return strNew;
            }

            int trueLen = trueLength(strOriginal);
            if (trueLen > maxTrueLength)//超过maxTrueLength
            {
                if (blnCutTail)//截断
                {
                    for (int i = strOriginal.Length - 1; i > 0; i--)
                    {
                        strNew = strNew.Substring(0, i);
                        if (trueLength(strNew) == maxTrueLength)
                            break;
                        else if (trueLength(strNew) < maxTrueLength)
                        {
                            strNew += chrPad.ToString();
                            break;
                        }
                    }
                }
            }
            else//填充
            {
                for (int i = 0; i < maxTrueLength - trueLen; i++)
                {
                    strNew += chrPad.ToString();
                }
            }

            return strNew;
        }
    }
}
