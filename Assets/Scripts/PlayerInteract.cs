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
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 50f, mask);

            if (hit)
            {
                Interactible interactible;
                SceneManager sceneManager;

                hitInfo.transform.TryGetComponent<Interactible>(out interactible);

                if (interactible != null)
                {
                    interactible.OnInteraction();
                    //h�r f�rs�kte jag se om jag kunde f� texten att st�nga av sig sj�lv efter 10 sekunder
                    
                }
                else
                {
                    Debug.Log("Not interactible!");
                }

                Debug.Log(hitInfo.transform.gameObject.name);

                hitInfo.transform.TryGetComponent<SceneManager>(out sceneManager);

                if (sceneManager != null)
                {
                    sceneManager.PreviousScene();
                   

                }
                else
                {
                    Debug.Log("Not the door!");
                }

                Debug.Log(hitInfo.transform.gameObject.name);
            }
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(transform.position, transform.forward, out hitInfo, 50f, mask);

            if (hit)
            {
                Interactible interactible;

                hitInfo.transform.TryGetComponent<Interactible>(out interactible);

                if (interactible != null)
                {
                    interactible.OffInteraction();
                    //h�r f�rs�kte jag se om jag kunde f� texten att st�nga av sig sj�lv efter 10 sekunder

                }
                else
                {
                    Debug.Log("Not interactible!");
                }

                Debug.Log(hitInfo.transform.gameObject.name);
            }
        }
    }
}
