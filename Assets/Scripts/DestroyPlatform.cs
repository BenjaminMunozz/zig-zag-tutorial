using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") 
        {
            transform.parent.GetComponent<Rigidbody>().useGravity = true;
            Invoke("Afterfallfinished" , 3f);
        }
    }

    void Afterfallfinished()
    {
        FindObjectOfType<PlatformSpawner>().DecreaseNumberPlatforms();
        Destroy(transform.parent.gameObject);
    }
}
