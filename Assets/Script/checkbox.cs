using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class checkbox : MonoBehaviour, IPointerClickHandler//, IPointerEnterHandler
{
    public gamecontroler game;
    public Sprite cross;
    public Sprite circle;
    public int id;
    public bool player = false;

    // Start is called before the first frame update
    void Start()
    {
        game = FindObjectOfType<gamecontroler>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(player == false)
        {
            if(game.turn == gamecontroler.Turnstate.PlayerOne)
            {
                GetComponent<Image>().sprite = cross;
                //GetComponent<Image>().color = Color.red;
                game.changeTurn(id);
            }else if(game.turn == gamecontroler.Turnstate.PlayerTwo)
            {
                GetComponent<Image>().sprite = circle;
                //GetComponent<Image>().color = Color.blue;
                game.changeTurn(id);
            }
            
            player = true;
        }else if(player == true)
        {
            Debug.Log("Déja jouer");
        }


        
    }

    

   /* public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Pleaseeee a MEDIC BAG");
    }*/

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
