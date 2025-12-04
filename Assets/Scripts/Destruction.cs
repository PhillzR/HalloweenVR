using UnityEngine;

public class Destruction : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target")
            
        {
            Instantiate(prefab, this.transform.position, this.transform.rotation);
            this.gameObject.SetActive(false);
        }

    }
}
