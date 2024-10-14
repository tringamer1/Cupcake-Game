using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toppings : MonoBehaviour
{
    public CupcakeBullshit cupcakeJunk; 
    public Button[] buttons;
    public Transform spawnPoint;
    public GameObject currentPrefab;

    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i; 
            buttons[i].onClick.AddListener(() => ChangeSprite(index));
        }
    }

    void ChangeSprite(int index)
    {
        if (index >= 0 && index < cupcakeJunk.toppings.Count)
        {
            if (currentPrefab != null)
            {
                Destroy(currentPrefab);
            }
            currentPrefab = Instantiate(cupcakeJunk.toppings[index]);
        }
    }
}
