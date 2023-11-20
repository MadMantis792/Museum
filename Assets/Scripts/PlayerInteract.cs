using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    int mask = ~(1 << 2);
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 5f, mask);

            if (hit)
            {
                Interactible interactible;

                hitInfo.transform.TryGetComponent<Interactible>(out interactible);

                if (interactible != null)
                {
                    interactible.OnInteraction();
                }
                else
                {
                    Debug.Log("Not interactible!");
                }
            }
        }
    }
}
