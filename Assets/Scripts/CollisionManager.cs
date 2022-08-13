using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class CollisionManager : MonoBehaviour
{   
    [SerializeField] private TMP_Text counterText;
    [SerializeField] private float timeRateSpeed;
    private float _counterValue;
    // Start is called before the first frame update
    void Start()
    {
        _counterValue = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(_counterValue <= 0f){
            StopAllCoroutines();
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionStay(Collision coll) {

        if(coll.gameObject.tag == "Player"){

            Debug.Log("Collision detected");
            StartCoroutine(Counter());
            
        }
    }

    IEnumerator Counter(){

        
        while(_counterValue >= 0){
           
            _counterValue-= Time.deltaTime * timeRateSpeed;
            Debug.Log(_counterValue);
            counterText.text = _counterValue.ToString();
            yield return new WaitForSeconds(0.1f);
        }
        
        
    }
}
