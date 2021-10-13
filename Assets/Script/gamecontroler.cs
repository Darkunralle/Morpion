using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroler : MonoBehaviour
{
    public enum Turnstate
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2
    };

    public Turnstate turn;
    public List<int> pOC;
    public List<int> pTC;


    // Start is called before the first frame update
    void Start()
    {
        turn = Turnstate.PlayerOne;
    }

    public void changeTurn(int _id)
    {
        if (turn == Turnstate.PlayerOne) { 
            turn = Turnstate.PlayerTwo;
            pOC.Add(_id);
        }
        else if (turn == Turnstate.PlayerTwo) {
            turn = Turnstate.PlayerOne;
            pTC.Add(_id);
        }

        check();
    }

    void check()
    {
        if ((pOC.Contains(1) && pOC.Contains(5) && pOC.Contains(9)) || (pOC.Contains(3) && pOC.Contains(5) && pOC.Contains(7)) || (pOC.Contains(1) && pOC.Contains(2) && pOC.Contains(3)) || (pOC.Contains(4) && pOC.Contains(5) && pOC.Contains(6)) || (pOC.Contains(7) && pOC.Contains(8) && pOC.Contains(9)) || (pOC.Contains(1) && pOC.Contains(4) && pOC.Contains(7)) || (pOC.Contains(2) && pOC.Contains(5) && pOC.Contains(8)) || (pOC.Contains(3) && pOC.Contains(6) && pOC.Contains(9)))
        {
            Debug.Log("P1 Win");
        }
        else if ((pTC.Contains(1) && pTC.Contains(5) && pTC.Contains(9)) || (pTC.Contains(3) && pTC.Contains(5) && pTC.Contains(7)) || (pTC.Contains(1) && pTC.Contains(2) && pTC.Contains(3)) || (pTC.Contains(4) && pTC.Contains(5) && pTC.Contains(6)) || (pTC.Contains(7) && pTC.Contains(8) && pTC.Contains(9)) || (pTC.Contains(1) && pTC.Contains(4) && pTC.Contains(7)) || (pTC.Contains(2) && pTC.Contains(5) && pTC.Contains(8)) || (pTC.Contains(3) && pTC.Contains(6) && pTC.Contains(9)))
        {
            Debug.Log("P2 Win");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
