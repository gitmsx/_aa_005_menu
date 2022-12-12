using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class JsonReaderArray : MonoBehaviour
{
    public TextAsset jsonFile;

    public EmployeeList MyemployeeList = new EmployeeList();

    void Start()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);

        foreach(Employee e in MyemployeeList.employees) {
            print(e.age);
        }


    }


    [System.Serializable]
    public class Employee
    {
        public string firstName;
        public string lastName;
        public int age;

    }
    [System.Serializable]
    public class EmployeeList
    {
        public Employee[] employees;

    }
}





