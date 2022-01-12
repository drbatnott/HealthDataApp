using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class DataEntryFunctions : MonoBehaviour
{
    public Text heightInCm, weightInKg, bmi, age, personName;
    //public Text outputStart;
    //public TextMeshPro textMesh;
   // Transform outputT;
    public InputField nameIField,heightIField,weightIField,ageIField;
    List<string> dataList;
    // Start is called before the first frame update
    void Start()
    {
        dataList = new List<string>();
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CalculateBMI()
    {
        float heightInM = float.Parse(heightInCm.text) / 100;
        float weightKG = float.Parse(weightInKg.text);
        float theBMI = weightKG / (heightInM * heightInM);
        bmi.text = "BMI: " + theBMI;
    }
    public void NextData()
    {
        string s = personName.text + "," + age.text + "," + heightInCm.text + "," + bmi.text;
        dataList.Add(s);
        bmi.text = "";
        weightInKg.text = "";
        heightInCm.text = "";
        age.text = "";
        personName.text = "";
        nameIField.text = "";
        ageIField.text = "";
        weightIField.text = "";
        heightIField.text = "";
    }
    public void ListTheData()
    {
        TextWriter tw = new StreamWriter("C:/Users/peter/Desktop/MyData.csv");
        foreach(string s in dataList)
        {
            //textMesh.text += s;
            tw.WriteLine(s);
        }
        tw.Close();
    }
}
