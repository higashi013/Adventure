using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class character_select : MonoBehaviour
{
    public static int character_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectNormal(){
        character_num = 1;
        SceneManager.LoadScene("game");
    }
    public void SelectOctone(){
        character_num = 2;
        SceneManager.LoadScene("game");
    }
    public void SelectPathfinder(){
        character_num = 3;
        SceneManager.LoadScene("game");
    }
    public static int getCN(){
        return character_num;
    }
}
