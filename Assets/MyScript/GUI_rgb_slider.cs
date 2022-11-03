using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI_rgb_slider : MonoBehaviour
{
    [SerializeField] private float mySlider = 1.0f;
    public Color myColor;
    public MeshRenderer GameObj;
    private void OnGUI()
    {
        mySlider = LabelSlider(new Rect(10, 100, 200, 20), mySlider, 5.0f, 0.0f, "MySlider");
        myColor = RGBSlider(new Rect(10, 130, 200, 20), myColor);
        GameObj.material.color = myColor;
    }
    float LabelSlider(Rect screenRect, float sliderValue, float sliderMaxValue, float sliderMinValue, string labelText)
    {
        Rect labelRect = new Rect(screenRect.x, screenRect.y, screenRect.width / 2, screenRect.height);
        GUI.Label(labelRect, labelText);
        Rect sliderRect = new Rect(screenRect.x + screenRect.width / 2, screenRect.y, screenRect.width / 2, screenRect.height);
        sliderValue = GUI.HorizontalSlider(sliderRect, sliderValue, 0.0f, sliderMaxValue);
        return sliderValue;
    }
    Color RGBSlider(Rect screenRect, Color rgb)
    {
        rgb.r = LabelSlider(screenRect, rgb.r, 1.0f, 0.0f, "Red");
        screenRect.y += 20;
        rgb.g = LabelSlider(screenRect, rgb.g, 1.0f, 0.0f, "Green");
        screenRect.y += 20;
        rgb.b = LabelSlider(screenRect, rgb.b, 1.0f, 0.0f, "Blue");
        screenRect.y += 20;
        rgb.a = LabelSlider(screenRect, rgb.a, 1.0f, 0.0f, "Alpha");

        if (GUI.Button(new Rect(110, 205, 100, 20), "minValueAlpha"))
        {
            rgb.a = 0;
        }
        return rgb;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
