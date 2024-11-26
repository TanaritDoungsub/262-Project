using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    [SerializeField] DataContainer data;
    [SerializeField] TMPro.TextMeshProUGUI coinsCounText;

    public void Add(int count)
    {
        data.coins += count;
        coinsCounText.text = "Coins : " + data.coins.ToString();
    }
}
