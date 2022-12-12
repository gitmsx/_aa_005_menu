using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonReader : MonoBehaviour
{





    public TextAsset jsonFile;

    void Start()
    {

        print(jsonFile.text);

        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);
        



    }

    public EmployeeList MyemployeeList = new EmployeeList();

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





