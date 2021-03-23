using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class paradisana : MonoBehaviour
{
    public GameObject krekls;
    public GameObject bikses;
    public GameObject cepures;
    public GameObject attelsmainas;
    public GameObject slider1;
    public GameObject slider2;
    public Sprite[] masivs;
    public AudioSource skanasAvots;
    public AudioClip skana;
    public void kreklson(bool ok){
        krekls.SetActive(ok);
    }
    public void bikseson(bool ok) {
        bikses.SetActive(ok);
    }
    public void cepureon(bool ok) {
        cepures.SetActive(ok);
    }
    public void dropdown(int skaitlis){
        if(skaitlis == 0)
        {
            attelsmainas.GetComponent<Image>().sprite = masivs[0];
        }
        else if(skaitlis == 1)
        {
            attelsmainas.GetComponent<Image>().sprite = masivs[1];
        }
        else if(skaitlis == 2)
        {
            attelsmainas.GetComponent<Image>().sprite = masivs[2];
        }
    }
  public void Lielums1(){
      float vert1=slider1.GetComponent<Slider>().value;
      attelsmainas.transform.localScale = new Vector2(1F*vert1, 1);
  }
  public void Lielums2(){
      float vert2=slider2.GetComponent<Slider>().value;
      attelsmainas.transform.localScale = new Vector2(1, 1F*vert2);
  }
  public void uzattela(){
      skanasAvots.PlayOneShot(skana);
  }
  public void noattela(){
      skanasAvots.Stop();
  }
        
 }

