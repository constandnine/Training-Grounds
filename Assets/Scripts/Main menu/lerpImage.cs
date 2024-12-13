using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpImage : MonoBehaviour
{
    public float lerpSpeed, start, end;
    private float lerpTime = 0;
    private bool isLerping;

    public void Update()
    {
        if (isLerping)
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
            }
        }
        
    }
    
    public void LerpScale()
    {
        isLerping = true;
    }
}
