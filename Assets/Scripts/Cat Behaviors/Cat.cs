using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cat : MonoBehaviour
{

    //Cat Info
    public string CatName;

    //Cat Stats
    public float RunSpeed;
    public float ClimbSpeed;
    public float Hunger;
    public float JumpHeight;

    //Attached Objects
    public TextMeshProUGUI NameTextBox;

    void Start()
    {
       NameTextBox.text = CatName;
    }
    
}
