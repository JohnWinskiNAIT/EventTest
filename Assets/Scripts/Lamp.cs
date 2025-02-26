using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    [SerializeField]
    Material[] lightColors;

    int colorIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        MyEvents.ChangeColor.AddListener(ColorSwitch);
        MyEvents.ChangeColorIndex.AddListener(ColorChange);
        colorIndex = 0;
    }

    // Update is called once per frame
    void ToggleLight()
    {
        Light myLight;
        myLight = GetComponentInChildren<Light>();

        myLight.enabled = !myLight.enabled;
    }

    void ColorSwitch()
    {
        colorIndex++;
        if (colorIndex >= lightColors.Length)
        {
            colorIndex = 0;
        }

        GetComponentInChildren<Light>().color = lightColors[colorIndex].color;
    }

    void ColorChange(int index)
    {
        GetComponentInChildren<Light>().color = lightColors[index].color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            MyEvents.Activate.AddListener(ToggleLight);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            MyEvents.Activate.RemoveListener(ToggleLight);
        }
    }
}
