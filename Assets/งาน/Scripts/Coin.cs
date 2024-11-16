using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public int coinAcquired;
    [SerializeField] TMPro.TextMeshProUGUI coinsCounText;

    public void Add(int count)
    {
        coinAcquired += count;
        coinsCounText.text = "Coins : " + coinAcquired.ToString();
    }
}
