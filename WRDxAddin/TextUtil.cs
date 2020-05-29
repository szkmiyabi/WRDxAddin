using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRDxAddin
{
    public class TextUtil
    {
        //全角数字を半角に変換
        public static string zentaku2hankaku(string val)
        {

            string[] hankakus =
            {
                "0","1","2","3","4","5","6","7","8","9",",","-",
            };

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < val.Length; i++)
            {
                char wd = val[i];
                string wd_str = wd.ToString();
                switch (wd_str)
                {
                    case "０":
                        sb.Append(hankakus[0]);
                        break;
                    case "１":
                        sb.Append(hankakus[1]);
                        break;
                    case "２":
                        sb.Append(hankakus[2]);
                        break;
                    case "３":
                        sb.Append(hankakus[3]);
                        break;
                    case "４":
                        sb.Append(hankakus[4]);
                        break;
                    case "５":
                        sb.Append(hankakus[5]);
                        break;
                    case "６":
                        sb.Append(hankakus[6]);
                        break;
                    case "７":
                        sb.Append(hankakus[7]);
                        break;
                    case "８":
                        sb.Append(hankakus[8]);
                        break;
                    case "９":
                        sb.Append(hankakus[9]);
                        break;
                    case "，":
                        sb.Append(hankakus[10]);
                        break;
                    case "－":
                        sb.Append(hankakus[11]);
                        break;
                }
            }
            return sb.ToString();
        }

        //半角数字を全角に変換
        public static string hankaku2zenkaku(string val)
        {

            string[] zenkakus =
            {
                "０","１","２","３","４","５","６","７","８","９","，","－",
            };

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < val.Length; i++)
            {
                char wd = val[i];
                string wd_str = wd.ToString();
                switch (wd_str)
                {
                    case "0":
                        sb.Append(zenkakus[0]);
                        break;
                    case "1":
                        sb.Append(zenkakus[1]);
                        break;
                    case "2":
                        sb.Append(zenkakus[2]);
                        break;
                    case "3":
                        sb.Append(zenkakus[3]);
                        break;
                    case "4":
                        sb.Append(zenkakus[4]);
                        break;
                    case "5":
                        sb.Append(zenkakus[5]);
                        break;
                    case "6":
                        sb.Append(zenkakus[6]);
                        break;
                    case "7":
                        sb.Append(zenkakus[7]);
                        break;
                    case "8":
                        sb.Append(zenkakus[8]);
                        break;
                    case "9":
                        sb.Append(zenkakus[9]);
                        break;
                    case ",":
                        sb.Append(zenkakus[10]);
                        break;
                    case "-":
                        sb.Append(zenkakus[11]);
                        break;
                }
            }
            return sb.ToString();
        }
    }
}
