using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    public AudioSource Audio;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        this.transform.position = Vector2.zero;
        
        Close();
    }
    public void Show()
    {
        canvasGroup.alpha = 1f;
        canvasGroup.blocksRaycasts = true;
        Audio.Play();
    }

    public void Close()
    {
        canvasGroup.alpha = 0f;
        canvasGroup.blocksRaycasts = false;
    }
}
