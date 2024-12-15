using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Camera mainMenuCamera;
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
            if (!isReturn)
            {
                transitionProgress += Time.deltaTime * transitionSpeed;
                float t = Mathf.Clamp01(transitionProgress);

                // Slide the cameras
                mainMenuCamera.rect = new Rect(-t, 0, 1, 1);
                gameCamera.rect = new Rect(1 - t, 0, 1, 1);

                if (t >= 1f)
                {
                    // End of transition
                    isTransitioning = false;
                    isReturn = true;
                }
            }
            else
            {
                transitionProgress += Time.deltaTime * transitionSpeed;
                float t = Mathf.Clamp01(transitionProgress);

                // Slide the cameras
                mainMenuCamera.rect = new Rect(1 -t, 0, 1, 1);
                gameCamera.rect = new Rect(- t, 0, 1, 1);

                if (t >= 1f)
                {
                    // End of transition
                    isTransitioning = false;
                    isReturn = false;
                }
            }
            
        }
    }
}
