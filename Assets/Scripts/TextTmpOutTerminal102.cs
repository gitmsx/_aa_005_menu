using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class TextTmpOutTerminal102: MonoBehaviour
{

    [SerializeField] TextMeshProUGUI textOut;

    private Coroutine CourutineWork;
    public float SpeedText = 0.1f;
    public float SpeedText2 = 0.9f;



    int QueueAllStrings = 0;
    int CurrentElementQueueAllStrings = 0;


    [SerializeField] string[] str = new string[7];
    [SerializeField] string[] strTM = new string[7];

    private void OnValidate()
    {
        textOut.text += "Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "2Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "3Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "4Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "5Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
        textOut.text += "6Переведено с английского языка.-Ползунок или полоса дорожки — это графический элемент управления, с помощью которого пользователь может установить значение, перемещая индикатор, обычно горизонтально. В некоторых случаях пользователь может также щелкнуть точку на ползунке, чтобы изменить настройку.";
    }

    // Start is called before the first frame update
    void Start()
    {
        textOut.text = "";











        str[0] = "Computer1<#800000>23science is the study12<#FFFF00>34 of computation,1123<#0000FF>45678 automation, and information.[1]<";
        str[1] = "\nМассив <#FFFF00> представляет набор <#800000>однотипных данных i <#FF00FF>and Computer <#7FFF00>science spans theoretical disciplines (such as algorithms, theory of computation, ";
        str[2] = "\nТе, 1<#00FF00>2кто просил больше информации3<#FF00FF>4 о хоббитах, в конце концов получили ее, но им пришлось ждать долго";
        str[3] = "\nсоздание <#FFD700>«Властелина Колец»<#FFFF00> заняло время с 1936 - го по 1949<#F4A460> год.В этот период у меня было множество обязанностей,";
        str[4] = "\nкоторыми я <#00008B>не мог пренебречь, и мои собственные интересы <#00FFFF>в качестве преподавателя и <#C0C0C0>лектора поглощали меня.";
        str[5] = "\nС тех пор как десять лет назад «Властелин Колец» был напечатан впервые, его прочитали многие; и мне хочется здесь выразить свое отношение к многочисленным отзывам, высказанным по поводу этой повести, ее героев и побудительных мотивов автора.Главным побудительным мотивом было желание сказочника испробовать свои силы в действительно длинной сказке, которая захватила бы внимание читателей, развлекла их и доставила им радость, а иногда, может быть, и тронула.Проводником мне служило лишь мое собственное чутье, а такой проводник подчас ненадежен.";

        CourutineWork = null;
        QueueAllStrings = str.Length;
        CurrentElementQueueAllStrings = 0;
        for (int i = 0; i < QueueAllStrings; i++)
            CourutineWork = StartCoroutine(printtext22(i, str[i]));


        // CourutineWork = StartCoroutine(printline());



        // StartCoroutine(printline());


    }


    IEnumerator printtext(int i, string strT)
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        foreach (char c in strT)
        {
            textOut.text += c;
            yield return new WaitForSeconds(SpeedText);
        }
        CourutineWork = null;
        yield break;
    }



    IEnumerator printtext22(int i, string strT)
    {


        while (CurrentElementQueueAllStrings != i)
            yield return new WaitForSeconds(0.2f);
        
        //while (CourutineWork != null)
        //    yield return new WaitForSeconds(0.2f);
        char c;

        for (int j = 0; j < strT.Length; j++)
        {
            c = strT[j];

            if ((strT[j] == '<') && (j + 1 < strT.Length) && strT[j + 1] == '#')
            {
                for (int k = j; k < j + 10; k++)
                    textOut.text += strT[k];
                j += 9;
            }
            else
            {
                textOut.text += c;
                yield return new WaitForSeconds(SpeedText);
            }
        }
        CourutineWork = null;
        CurrentElementQueueAllStrings ++;
        yield break;
    }



    IEnumerator printline()
    {
        while (CourutineWork != null)
            yield return new WaitForSeconds(0.2f);
        for (int i = 1; i < str.Length; i++)
        {
            textOut.text += str[i];
            yield return new WaitForSeconds(SpeedText2);
        }

    }


}
