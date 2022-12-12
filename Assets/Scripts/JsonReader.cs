using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonReader : MonoBehaviour
{





    public TextAsset jsonFile;

    void Start()
    {

        var json = "W:\\unity\\_aa_005_menu\\Assets\\Resources\\Employees.json";
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(json);




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





