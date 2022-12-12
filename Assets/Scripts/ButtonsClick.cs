

using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;


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






 
    //    print("stringsLevel.Length " + stringsLevel.Length.ToString());
        for (int i = 0; i < stringsLevel.Length; i++)
        {
         //    print(stringsLevel[i]);
            for (int j = 0; j < 4; j++)
            {
                
                if (stringsLevel[i].IndexOf(buttonsSubStrSearch[j]) !=-1)
                {
                    TextBbuttonsGO[j].text = stringsLevel[i];
              //      print(stringsLevel[i]);
                }
            }
        }
    }
    void TaskWithParameters(string message)
    {
        //Output this to console when the Button2 is clicked
        Debug.Log(message);
        list11();

    }


    public TextAsset jsonFile;
    public EmployeeList MyemployeeList = new EmployeeList();

    public void list11()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);

        TextMeshProUGUI[] TextBbuttonsGO = new TextMeshProUGUI[12];
        TextBbuttonsGO[0] = TextButton0;
        TextBbuttonsGO[1] = TextButton1;
        TextBbuttonsGO[2] = TextButton2;
        TextBbuttonsGO[3] = TextButton3;

        int ii = 0;
        foreach (Employee e in MyemployeeList.employees)
        {
            
            if (ii< 4)
            {
                TextBbuttonsGO[ii].text = " firstName =" + e.firstName + " lastName " + e.lastName + " Age " + e.age.ToString();
            }
            print(" firstName =" + e.firstName + " lastName " + e.lastName + " Age " + e.age.ToString());
            ii++;
        }
    }


    [System.Serializable]
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;

    }

    public class EmployeeList
    {
        public Employee[] employees;

    }


    void ButtonClicked(int buttonNo)
    {
        //Output this to console when the Button3 is clicked
        Debug.Log("Button clicked = " + buttonNo);

        string path = "Assets/Resources/Employees.json";
        if (FileExists(path))
        {
            JsonReader2 jsonReader2 = new JsonReader2();
            jsonReader2.list11(path);

        }


        foreach (Employee e in MyemployeeList.employees)
        {
            Debug.Log(e.lastName);
            Debug.Log(e);
            Debug.Log(e.age);
            Debug.Log(e.firstName);
            Debug.Log("************ 77777777777777777777777777 ********");


        }






    }


    bool FileExists(string FileName)
    {


        if (FileName == null || FileName.Length == 0)
            return false;
        //{
        //    throw new ArgumentNullException("FileName");
        //}

        // Check to see if the file exists.
        FileInfo fInfo = new FileInfo(FileName);

        // You can throw a personalized exception if
        // the file does not exist.
        if (!fInfo.Exists)
            return false;

        //{
        //    throw new FileNotFoundException("The file was not found.", FileName);
        //}
        return true;


    }
}



