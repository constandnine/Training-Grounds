using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpImage : MonoBehaviour
{
    public float lerpSpeed, start, end;
    private float lerpTime = 0;
    private bool isLerping, isLerpingBack;

    public void Update()
    {
        if (isLerping)
        {
            if (!isLerpingBack)
            {
                if (lerpTime <= 1f)
                {
                    lerpTime += Time.deltaTime * lerpSpeed;
                    Vector3 scale = gameObject.transform.localScale;
                    scale.y = Mathf.Lerp(start, end, lerpTime);
                    gameObject.transform.localScale = scale;
                }
                else
                {
                    isLerping = false;
                    lerpTime = 0;
                    isLerpingBack = true;
                }
            }
            else
            {
                if (lerpTime <= 1f)
                {
                    lerpTime += Time.deltaTime * lerpSpeed;
                    Vector3 scale = gameObject.transform.localScale;
                    scale.y = Mathf.Lerp(end, start, lerpTime);
                    gameObject.transform.localScale = scale;
                }
                else
                {
                    isLerping = false;
                    lerpTime = 0;
                    isLerpingBack = false;
                }
            }
            
        }
        
    }
    
    public void LerpScale()
    {
        isLerping = true;
    }

}
