using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ButtonsManagement : MonoBehaviour
{
    private GameObject pointEnterSoundEffect;
    public AudioClip pointEnterSound;
    public GameObject canvasPrefab;
    void Start()
    {
        pointEnterSoundEffect = GameObject.FindGameObjectWithTag("hover");

        Instantiate(canvasPrefab);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void YeniOyun()
    {
        SceneManager.LoadScene("story");

    }
    public void HoverSound()
    {
        Debug.Log("Pointer Entered");
            pointEnterSoundEffect.GetComponent<AudioSource>().PlayOneShot(pointEnterSound);
    }


}
