using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public static string teacher;

    public GameObject[] heisenbergs;
    public GameObject[] kadinHocalar;
  
    public TextMeshProUGUI dialogueText;
    private Dialogue dialogueSystem;

    public float timer;
    private bool timerCanChangable;
   [HideInInspector] public bool sleep;
    public GameObject sleepScreen;


    public GameObject playerCam;


    private bool degisken;
    void Start()
    {
        heisenbergs = GameObject.FindGameObjectsWithTag("heisenberg");
        kadinHocalar = GameObject.FindGameObjectsWithTag("kadin");
        teacher = "kadin";
        dialogueSystem=gameObject.GetComponent<Dialogue>();
        
        timerCanChangable =true;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (sleep == true)
        {
         if (degisken == false)
            {
                playerCam.GetComponent<Animator>().enabled = true;
            }
     
            if (timerCanChangable)
            {
                timer = 5f;
                timerCanChangable = false;
            }
            timer -= Time.deltaTime;

            if (timer < 0)
            {
                sleep = false;
                teacher = "heisenberg";
                dialogueSystem.lines[3] = "ali : gördüðüm heisenberg mi yoksa?";
                dialogueSystem.lines[4] = "ali : sanýrým rüyadayým.";

                dialogueSystem.lines[5] = "heisenberg : hayýr evlat, tam tersine uzun bir rüyadan uyanýyorsun...";

            }

            playerCam.GetComponent<CameraController>().canMove = false;
        }
        else
        {
            playerCam.GetComponent<CameraController>().canMove = true;

        }

        sleepScreen.GetComponent<Animator>().SetBool("sleep", sleep);

        playerCam.GetComponent<Animator>().SetBool("sleep", sleep);


        if (teacher == "heisenberg")
        {
            int heisenbergValue = 0;
            int kadinValue = 0;

            heisenbergs[heisenbergValue].SetActive(true);
            heisenbergValue = heisenbergValue + 1;



            kadinHocalar[kadinValue].SetActive(false);
            kadinValue = kadinValue + 1;
        }


        if (teacher == "kadin")
        {

            int kadinValue = 0;
            int heisenbergValue = 0;

           
            kadinHocalar[kadinValue].SetActive(true);
            kadinValue = kadinValue + 1;

            heisenbergs[heisenbergValue].SetActive(false);
            heisenbergValue = heisenbergValue + 1;

        }
    }



}

