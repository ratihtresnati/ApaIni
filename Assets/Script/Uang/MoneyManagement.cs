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

    private ItemsManagement itemsManage;

    void Start()
    {
        textMoney.text = "Rp " + money.ToString("N0");

        sliderHarga = FindObjectOfType<SliderHarga>();
        itemsManage = FindObjectOfType<ItemsManagement>();
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

    public void UangBerkurang(int items)
    {
        // Debug.Log("byee");
        // money -= items;
        // UpdateMoney();
        int a = itemsManage.HargaItemsBeli(items);

        money -= a;
        UpdateMoney();
        Debug.Log("aku auuu");

    }

    public int UangBertambah(int items)
    {
        int a = itemsManage.HargaItems(items);

        return a;
        // Bertambah(money);
    }

    public int GetMoney()
    {
        return money;
    }
}
