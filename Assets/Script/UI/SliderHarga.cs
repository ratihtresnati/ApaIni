using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SliderHarga : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI textSlider;


    [SerializeField] private int minValue; // Minimum value for the random range
    [SerializeField] private int maxValue;

    void Start()
    {
        slider.onValueChanged.AddListener((v) => {
            textSlider.text = "Rp " +  v.ToString("N0");
        });

        int randomValue = Random.Range(minValue, maxValue);
        slider.value = randomValue;
        textSlider.text = "Rp " + randomValue.ToString("N0");
    }

    void Update()
    {
        Debug.Log(slider.value);
    }

    public int NilaiSlider()
    {
        return (int)slider.value;
    }


}
