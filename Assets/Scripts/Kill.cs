using UnityEngine;

public class Kill : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
            Destroy(this.gameObject);
    }
}
