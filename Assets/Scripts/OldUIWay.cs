using UnityEngine;
using System.Collections;

public class OldUIWay : MonoBehaviour {
    // This is Case Sensitive.
	void OnGUI(){
        // Background Box
        GUI.Box(new Rect(10, 10, 100, 90), "OnGui Script Background Box");
        // Button 1
        if(GUI.Button(new Rect(20, 40, 80, 20), "button 1")) {
            Debug.Log("Button 1 <b>clicked</b>.");
        }
        // Button 2
        if( GUI.Button(new Rect(20, 70, 80, 20), "button2 ")) {
            Debug.Log("Button 2 <color=cyan>clicked</color>");
        }

    }
}
