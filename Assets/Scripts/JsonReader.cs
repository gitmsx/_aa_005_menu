using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JsonReader : MonoBehaviour
{
    public TextAsset jsonFile;

    public EmployeeList MyemployeeList = new EmployeeList();

    void Start()
    {
        MyemployeeList = JsonUtility.FromJson<EmployeeList>(jsonFile.text);

        foreach (Employee e in MyemployeeList.employees)
        {
            print(" firstName ="+ e.firstName + " lastName " +e.lastName+" Age "+e.age.ToString());
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





