using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fade : MonoBehaviour
{
    public void FadeMe(){
        StartCoroutine (DoFade());
    }

    IEnumerator DoFade (){
        Image image = GetComponent<Image>();
        var tempColor = image.color;
        while(image.color.a < 1){
            Debug.Log("nice");
            tempColor.a += Time.deltaTime *2;
            image.color = tempColor;
            yield return null;
        }

        Animator animator = GameObject.Find("BedtimePanel").GetComponent<Animator>();
        if(animator != null){
            animator.SetBool("Display", false);
        }

        TreeCount forest = GameObject.Find("Forest").GetComponent<TreeCount>();
        foreach(GameObject tree in forest.forest){
            tree.SetActive(true);
        }

        yield return new WaitForSeconds (1);

        

        while(image.color.a > 0){
            tempColor.a -= Time.deltaTime /2;
            image.color = tempColor;
            yield return null;
        }
        yield return null;
    }
}
