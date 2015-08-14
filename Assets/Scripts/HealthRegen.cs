using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthRegen : MonoBehaviour {
    // Reference to the slider
    public Slider healthSlider;

    // Update is called once per frame
    void Update() {
        // move the value toward the right.
        healthSlider.value = Mathf.MoveTowards(healthSlider.value, healthSlider.maxValue, 0.05f);
    }

    public void Method() {
        Debug.Log("Test=");
    }
}
