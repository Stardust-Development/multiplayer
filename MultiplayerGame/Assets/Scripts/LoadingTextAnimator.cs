using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadingTextAnimator : MonoBehaviour
{
    public TMP_Text text;
    public float delay = 1f;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        // Loop();
        StartCoroutine(UpdateUI());
    }

    void Loop()
    {

    }

    IEnumerator UpdateUI()
    {
        text.text = "Loading .";
        yield return new WaitForSeconds(delay);
        text.text = "Loading . .";
        yield return new WaitForSeconds(delay);
        text.text = "Loading";
        StartCoroutine(UpdateUI());
    }
}
