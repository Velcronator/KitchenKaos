using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryCounter : BaseCounter
{
    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            if (player.GetKitchenObject().TryGetPlate(out PlateKitchenObject plateKitchenObject))
            {
                // Only Accepts plates
                player.GetKitchenObject().DestroySelf();
            }
        }

    }

    public override void InteractAlternate(Player player)
    {
        Debug.Log("DeliveryCounter: InteractAlternate");
    }
}
