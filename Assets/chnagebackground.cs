using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chnagebackground : MonoBehaviour
{
    private Camera mainCamera;
    private float timeElapsed = 0f;
    private float colorChangeInterval = 10f;
    private float colorChangeDuration = 0.5f;
    private Color originalColor;

    void Start()
    {
        mainCamera = Camera.main;
        originalColor = mainCamera.backgroundColor;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= colorChangeInterval)
        {
            timeElapsed = 0f;
            StartCoroutine(ChangeBackgroundColor());
        }
    }

    IEnumerator ChangeBackgroundColor()
    {
        mainCamera.backgroundColor = Color.white;

        yield return new WaitForSeconds(colorChangeDuration);

        mainCamera.backgroundColor = originalColor;
    }
}
