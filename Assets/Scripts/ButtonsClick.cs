
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ButtonsClick : MonoBehaviour
{
    //Make sure to attach these Buttons in the Inspector
    public Button Button0, Button1, Button2, Button3;
    [SerializeField] TextMeshProUGUI TextButton0, TextButton1, TextButton2, TextButton3;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        Button0.onClick.AddListener(TaskOnClick);
        Button1.onClick.AddListener(TaskOnClick);
        Button2.onClick.AddListener(delegate { TaskWithParameters("Hello"); });
        Button3.onClick.AddListener(() => ButtonClicked(42));

    }







    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
     // Debug.Log("You have clicked the button!");

        string[] stringsLevel = LevelLoad.ReadData(1, 1);

        
        string[] buttonsTextNew = new string[12];
        buttonsTextNew[0] = "";
        buttonsTextNew[1] = "";
        buttonsTextNew[2] = "";
        buttonsTextNew[3] = "";

        string[] buttonsSubStrSearch = new string[12];
        buttonsSubStrSearch[0] = "###1:";
        buttonsSubStrSearch[1] = "###2:";
        buttonsSubStrSearch[2] = "###3:";
        buttonsSubStrSearch[3] = "###4:";


        Button[] buttonsGO = new Button[12];
        buttonsGO[0] = Button0;
        buttonsGO[1] = Button1;
        buttonsGO[2] = Button2;
        buttonsGO[3] = Button3;


        TextMeshProUGUI[] TextBbuttonsGO = new TextMeshProUGUI[12];
        TextBbuttonsGO[0] = TextButton0;
        TextBbuttonsGO[1] = TextButton1;
        TextBbuttonsGO[2] = TextButton2;
        TextBbuttonsGO[3] = TextButton3;






        string substring ;
        print("stringsLevel.Length " + stringsLevel.Length.ToString());
        for (int i = 0; i < stringsLevel.Length; i++)
        {
      //      print(stringsLevel[i]);
            for (int j = 0; j < 4; j++)
            {
                
                if (stringsLevel[i].IndexOf(buttonsSubStrSearch[j]) > 0)
                {
                    TextBbuttonsGO[j].text = stringsLevel[i];
                    print(stringsLevel[i]);
                }
            }
        }
    }
    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
    }

    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);
    }
}



