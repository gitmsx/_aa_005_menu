
using UnityEngine;


public class JsonReader : MonoBehaviour
{

    private static JsonReader instance;


    private void Awake()
    {
        if (JsonReader.instance != null)
        {
            Debug.LogError("More 1 JsonReader instantiete in Programm. Abnormal programm termination ");
        }

        instance = this;
    }


    public TextAsset jsonFile;

    public EmployeeList MyemployeeList = new EmployeeList();

    void Start()
    {

        list11();


    }


    public void list11()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);

        foreach (Employee e in MyemployeeList.employees)
        {
            print(" firstName =" + e.firstName + " lastName " + e.lastName + " Age " + e.age.ToString());

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
}





