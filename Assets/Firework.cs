using System.Collections;
using UnityEngine;

public class Firework : MonoBehaviour {

    [Header("Unity")]
    new public ParticleSystem particleSystem;
    public MeshRenderer gfx;
    public AudioSource sfx;
    [Header("Settings")]
    public Range launchForce = new Range(30f, 2f);
    public Range airTime = new Range(1.5f, .1f);
    Rigidbody rb;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
        Launch();
	}

    public void Launch()
    {
        StartCoroutine(launch());
    }

    IEnumerator launch()
    {
        Destroy(gameObject, airTime.Value + 10f);
        rb.isKinematic = false;
        rb.AddForce(Vector3.up * launchForce.GetRand(), ForceMode.Impulse);
        yield return new WaitForSeconds(airTime.GetRand());
        sfx.Play();
        gfx.enabled = false;
        particleSystem.Play();
        rb.isKinematic = true;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
