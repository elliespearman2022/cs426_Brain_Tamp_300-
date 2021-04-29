using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class showTemp : MonoBehaviour
{
    public GameObject textField;
    public int hudTemp;
    // Start is called before the first frame update
    void Start()
    {
        textField.GetComponent<Text>().text = "Get those temps!";

    }

    // Update is called once per frame
    void Update()
    {

    }
}
