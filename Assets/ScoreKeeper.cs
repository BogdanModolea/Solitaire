using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public Selectable[] topStacks;
    public GameObject highScrorePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (HasWon())
        {
            Win();
        }
    }

    public bool HasWon()
    {
        int i = 0;
        foreach(Selectable topstacks in topStacks)
        {
            i += topstacks.value;
        }
        if(i >= 52)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    void Win()
    {
        highScrorePanel.SetActive(true);
        print("Ai castigat!");
    }
}
