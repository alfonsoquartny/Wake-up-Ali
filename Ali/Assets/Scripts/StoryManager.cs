using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public static string teacher;

    public GameObject[] heisenbergs;
    public GameObject[] kadinHocalar;
  
    public TextMeshProUGUI dialogueText;




   [HideInInspector] public bool sleep;

    public GameObject sleepScreen;
    void Start()
    {
        teacher = "kadin";
    }

    // Update is called once per frame
    void Update()
    {
        if (sleep == true)
        {
            sleepScreen.SetActive(true);
        }
        else
        {
            sleepScreen.SetActive(false);
        }



        if (teacher == "heisenberg")
        {
            int heisenbergValue = 0;
            int kadinValue = 0;

            heisenbergs = GameObject.FindGameObjectsWithTag("heisenberg");
            kadinHocalar = GameObject.FindGameObjectsWithTag("kadin");
            heisenbergs[heisenbergValue].SetActive(true);
            heisenbergValue = heisenbergValue + 1;



            kadinHocalar[kadinValue].SetActive(false);
            kadinValue = kadinValue + 1;
        }


        if (teacher == "kadin")
        {

            int kadinValue = 0;
            int heisenbergValue = 0;

            heisenbergs = GameObject.FindGameObjectsWithTag("heisenberg");
            kadinHocalar = GameObject.FindGameObjectsWithTag("kadin");
            kadinHocalar[kadinValue].SetActive(true);
            kadinValue = kadinValue + 1;

            heisenbergs[heisenbergValue].SetActive(false);
            heisenbergValue = heisenbergValue + 1;

        }
    }
}

