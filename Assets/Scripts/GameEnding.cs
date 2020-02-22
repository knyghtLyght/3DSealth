using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnding : MonoBehaviour
{

    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup exitBackgroundImageCanvasGroup;

    bool isPlayerAtExit;
    float quiteTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerAtExit = true;
        }
    }

    private void Update()
    {
        if (isPlayerAtExit)
        {
            EndLevel();
        }
    }

    void EndLevel()
    {
        quiteTimer += Time.deltaTime;
        exitBackgroundImageCanvasGroup.alpha = quiteTimer / fadeDuration;
        if (quiteTimer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}
