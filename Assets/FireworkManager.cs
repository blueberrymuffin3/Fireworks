using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireworkManager : MonoBehaviour {
    [System.Serializable]
    public class Launch : IComparer<Launch>
    {
        public float time;
        public float launchForce;
        public float airTime;
        public void launch()
        {

        }

        public int Compare(Launch x, Launch y)
        {
            return x.time.CompareTo(y.time);
        }
    }
    
    List<Launch> launches;

    private void Start()
    {
        StartCoroutine(Courutine());
    }

    IEnumerator Courutine()
    {
        yield return null;
    }
}
