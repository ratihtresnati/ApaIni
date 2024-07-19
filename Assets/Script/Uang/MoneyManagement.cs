using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyManagement : MonoBehaviour
{
    [SerializeField] private int money;
    [SerializeField] private TextMeshProUGUI textMoney;

    private SliderHarga sliderHarga;

    void Start()
    {
        textMoney.text = "Rp " + money.ToString("N0");

        sliderHarga = FindObjectOfType<SliderHarga>();
    }

    private void UpdateMoney()
    {
        textMoney.text = "Rp " + money.ToString("N0");
    }

    public void HargaPenawaran()
    {
        int harga = sliderHarga.NilaiSlider();
        Bertambah(harga);
    }

    public void Bertambah(int money)
    {
        Debug.Log("haii");
        this.money += money;
        UpdateMoney();
    }

    public void Berkurang()
    {
        Debug.Log("byee");
        money -= 1000;
        UpdateMoney();
    }

    public int GetMoney()
    {
        return money;
    }
}
