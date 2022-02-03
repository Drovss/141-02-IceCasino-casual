using System.Collections;
using UnityEngine;

public class DestroyParticle : MonoBehaviour
{
    IEnumerator Start()
    {
        yield return new WaitForSeconds(2f);
        Destroy();
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
