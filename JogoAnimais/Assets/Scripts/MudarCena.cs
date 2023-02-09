using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MudarCena : MonoBehaviour
{

    public string nomeDaCena;


    public void Cenas()
    {
        SceneManager.LoadScene(nomeDaCena);
    }

}
    
   /* void Update()
    {
        if(DragDrop.colouCerto == true)
        {
            CarregarNovaCena();
        }
    }

    private void CarregarNovaCena()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
}
   */