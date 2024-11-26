using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDestroy : MonoBehaviour
{
    [SerializeField] List<GameObject> dropItemPerfab;
    [SerializeField][Range(0f, 1f)] float chance = 1f;

    bool isQuitting = false;
    private void OnApplicationQuit()
    {
        isQuitting = true;
    }

    public void CheckDrop()
    {
        if (isQuitting) 
        { 
            return; 
        }

        if (dropItemPerfab.Count <= 0)
        {
            Debug.LogWarning("List of drop item is empty!");
            return;
        }

        if (Random.value < chance)
        {
            GameObject toDrop = dropItemPerfab[Random.Range(0, dropItemPerfab.Count)];

            if (toDrop == null)
            {
                Debug.LogWarning("DropOnDestroy, reference to dropped item is null! Check the prefab of the object which drops items on destroy!");
                return;
            }

            SpawnManager.instance.SpawnObject(transform.position, toDrop);
        }
        
    }
}
