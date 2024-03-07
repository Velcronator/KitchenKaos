using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : BaseCounter
{
    [SerializeField] private KitchenObjectSO kitchenObjectSO; 

    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {// Counter Empty
            if (player.HasKitchenObject())
            {// Player has stuff hand it over
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {// Player and counter doesn't have stuff do nothing

            }
        }
        else
        {// Stuff already there
            if(player.HasKitchenObject())
            {// player has stuff then do nothing

            }
            else
            {// player doesn't have stuff.
                GetKitchenObject().SetKitchenObjectParent(player);
            }
        }
    }
}
