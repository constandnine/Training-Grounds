using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Camera[] mainMenuCamera;
    public Camera gameCamera;
    public float transitionSpeed = 2f;

    private bool isTransitioning = false;
    private bool isReturn = false;
    private float transitionProgress = 0f;


    public void StartTransition()
    {
        if (!isTransitioning)
        {
            isTransitioning = true;
            transitionProgress = 0f;
            gameCamera.enabled = true; // Enable game camera to render during transition
        }
    }

    void Update()
    {
        if (isTransitioning)
        {
            for (int i = 0; i < mainMenuCamera.Length; i++)
            {
                mainMenuCamera[i].enabled = true;
            }
            gameCamera.enabled = true;
            if (!isReturn)
            {
                transitionProgress += Time.deltaTime * transitionSpeed;
                float t = Mathf.Clamp01(transitionProgress);

                // Slide the cameras
                for (int i = 0; i < mainMenuCamera.Length; i++)
                {
                    mainMenuCamera[i].rect = new Rect(0, -t, 1, 1);
                }
                gameCamera.rect = new Rect(0, 1 -t, 1, 1);

                if (t >= 1f)
                {
                    // End of transition
                    isTransitioning = false;
                    isReturn = true;
                    for (int i = 0;i < mainMenuCamera.Length; i++)
                    {
                        mainMenuCamera[i].enabled = false;
                    }
                }
            }
            else
            {
                transitionProgress += Time.deltaTime * transitionSpeed;
                float t = Mathf.Clamp01(transitionProgress);

                // Slide the cameras
                for (int i = 0;i < mainMenuCamera.Length; i++)
                {
                    mainMenuCamera[i].rect = new Rect(0, 1 - t, 1, 1);

                }
                gameCamera.rect = new Rect(0, -t, 1, 1);

                if (t >= 1f)
                {
                    // End of transition
                    isTransitioning = false;
                    isReturn = false;
                    gameCamera.enabled = false;
                }
            }
            
        }
    }
}
