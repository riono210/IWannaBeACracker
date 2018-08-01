using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class textTest : MonoBehaviour {

    public GameObject text;

	// Use this for initialization
	void Start () {
        text.GetComponent<TextMeshProUGUI>().text = "sucsess";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
