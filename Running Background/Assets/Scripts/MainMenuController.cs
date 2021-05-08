using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void selectScene(){
        switch (this.gameObject.name)
        {
            case "ElementGame":
                SceneManager.LoadScene("ScrollingScene");
                break;
            
            case "OctetGame":
                SceneManager.LoadScene("OctetScene");
                break;
            default:
                break;
        }
        
    }

}
