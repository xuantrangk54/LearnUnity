using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySoundOnClick : MonoBehaviour
{

    public AudioClip clickSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (clickSound != null)
        {
            audioSource.clip = clickSound;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonClick()
    {
        Debug.Log("CLICK BUTTON PLAY SOUND");
        if (clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
        else
        {
            // Play the clip set in the AudioSource component
            audioSource.Play();
        }
    }
}
