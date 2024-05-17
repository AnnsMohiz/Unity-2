using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollitions : MonoBehaviour
{
    public int TotalScore ;
    
    // Start is called before the first frame update
    void Start()
    {
           
 }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
         PlayerScore();
        Destroy(gameObject);
        Destroy(other.gameObject);
        
   
}
void PlayerScore()
        {
         TotalScore = PlayerPrefs. GetInt ("Score", 0);
         TotalScore++;
        PlayerPrefs.SetInt ("Score", TotalScore);
        //PlayerPrefs. Save ();
          print("Score " + TotalScore. ToString());
           
           Destroy (gameObject);
        }
}

