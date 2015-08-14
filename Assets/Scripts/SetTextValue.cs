using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SetTextValue : MonoBehaviour {
    public Slider sliderBar;
    public Text text;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = sliderBar.value.ToString();
	}
}
