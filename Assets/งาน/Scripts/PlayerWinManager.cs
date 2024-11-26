using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWinManager : MonoBehaviour
{
    [SerializeField] GameObject winMessagePanel;
    PauseManager PauseManager;
    [SerializeField] DataContainer dataContainer;

    private void Start()
    {
        PauseManager = GetComponent<PauseManager>();
    }

    public void Win()
    {
        winMessagePanel.SetActive(true);
        PauseManager.PauseGame();
        dataContainer.StageComplete(0);
    }
}
