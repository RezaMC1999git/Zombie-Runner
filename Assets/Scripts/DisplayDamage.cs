using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas impactCanvas;
    [SerializeField] float impacetDelay = 0.3f;
    private void Start()
    {
        impactCanvas.enabled = false;
    }
    public void ShowDamageImpcat()
    {
        StartCoroutine(ShowSplatter());
    }
    IEnumerator ShowSplatter()
    {
        impactCanvas.enabled = true;
        yield return new WaitForSeconds(impacetDelay);
        impactCanvas.enabled = false;
    }
}
