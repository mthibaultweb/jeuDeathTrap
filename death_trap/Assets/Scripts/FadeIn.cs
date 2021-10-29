using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    Image fadeInImage = null;

    // Start is called before the first frame update
    void Start()
    {
        fadeInImage = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FadeInEffect()
    {
        StartCoroutine(FadeInCoroutine());
    }

    IEnumerator FadeInCoroutine()
    {
        fadeInImage.color = new Color(fadeInImage.color.r, fadeInImage.color.g, fadeInImage.color.b, 1);
        yield return null;

        while (fadeInImage.color.a > 0)
        {
            fadeInImage.color = new Color(fadeInImage.color.r, fadeInImage.color.g, fadeInImage.color.b, fadeInImage.color.a - 0.1f * Time.deltaTime);
            yield return null;
        }

        fadeInImage.color = new Color(fadeInImage.color.r, fadeInImage.color.g, fadeInImage.color.b, 0);
        yield return null;
    }
}
