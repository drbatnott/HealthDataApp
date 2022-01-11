using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    //For testing purposes we will just write to the message Text
    public Text messageText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Add a method to be the button click response
    public void LoadDataEntryScene()
    {
        SceneManager.LoadScene("DataEntry");
        messageText.text = "Test Worked";
    }
    //Add a method to be the button click response
    public void LoadOpeningScene()
    {
        SceneManager.LoadScene("OpeningScene");
        messageText.text = "Back At the Start";
    }
}
