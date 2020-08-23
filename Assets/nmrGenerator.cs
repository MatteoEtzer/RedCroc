using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nmrGenerator : MonoBehaviour
{
    public GameObject TextBox;
    public int Number1;
    public int Number2;
    public int Number3;
    public int Number4;
    public int Number5;
    public int Number6;
    public int Number7;
    public int Number8;

    public void GenerateOnClick() 
    {
        Number1 = Random.Range(0, 10);
        Number2 = Random.Range(0, 10);
        Number3 = Random.Range(0, 10);
        Number4 = Random.Range(0, 10);
        Number5 = Random.Range(0, 10);
        Number6 = Random.Range(0, 10);
        Number7 = Random.Range(0, 10);
        Number8 = Random.Range(0, 10);
        TextBox.GetComponent<Text>().text = "" + Number1 + Number2 + Number3 + Number4 + Number5 + Number6 + Number7 + Number8;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
