using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageSystem : MonoBehaviour
{
    public static MessageSystem instance;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] GameObject damageMessage;

    List<TMPro.TextMeshPro> messagePool;

    public void Populate()
    {
        GameObject go = Instantiate(damageMessage, transform);
        messagePool.Add(go.GetComponent<TMPro.TextMeshPro>());
    }

    public void PostMessage(string text, Vector3 worldPosition)
    {
        GameObject go = Instantiate(damageMessage, transform);
        go.transform.position = worldPosition;
        go.GetComponent<TMPro.TextMeshPro>().text = text;
    }
}
