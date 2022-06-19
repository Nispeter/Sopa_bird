using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectionManager : MonoBehaviour
{
    public GameObject SelectionCanvas;

    void Start()
    {
        //characterList = new GameObject[transform.childCount];
        // fill array with models WIP
       // for(int i = 0; i < transform.GetChild(i).gameObject);
            //toggle off renderer
                //foreach(GameObject go in characterList)
            {
               // go.SetActive(false);
            }
        //toggle first index WIP
        //if (characterList[0])
            //chatacterList[0].setActive(true);   
    }


    void Update()
    {

    }
    public void back()
    {
        SceneManager.LoadScene(0);
    }
  

}
