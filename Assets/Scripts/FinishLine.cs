using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = .1f;
    [SerializeField] ParticleSystem finishEffect;
   void OnTriggerEnter2D(Collider2D other)
   {
    if(other.tag == "Player")
    {
      finishEffect.Play();
      Invoke("ReloadScene", loadDelay);
      
   }  
   
   }
   
   void ReloadScene()
   {
      Debug.Log("AlrightAlrightAlright ;)");
      SceneManager.LoadScene(0);
   }
}
