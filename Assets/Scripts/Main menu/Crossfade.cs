using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crossfade : MonoBehaviour
{
    public GameObject[] cam;
    public GameObject crossfadePanel;
    public float fadeDuration;
    public float waitforSeconds;
    private int index;
    // Start is called before the first frame update
    void Start()
    {
        index = 1;
        StartCoroutine(FadeToBlackAndBack());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator FadeToBlackAndBack()
    {
        // cooldown
        yield return new WaitForSeconds(waitforSeconds);
        // Fade to black
        yield return StartCoroutine(Fade(Color.clear, Color.black));
        // Switch camera
        for (int i = 0; i < cam.Length; i++)
        {
            cam[i].SetActive(false);
            cam[index].SetActive(true);
        }
        // Fade back to clear
        yield return StartCoroutine(Fade(Color.black, Color.clear));
        index += 1;
        if (index > cam.Length -1)
        {
            index = 0;
        }
        StartCoroutine(FadeToBlackAndBack());
    }
    private IEnumerator Fade(Color startColor, Color endColor)
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;  
            float t = elapsed / fadeDuration;
            crossfadePanel.GetComponent<Image>().color = Color.Lerp(startColor, endColor, t);
            yield return null;
        }
        crossfadePanel.GetComponent<Image>().color = endColor;
    }
}
