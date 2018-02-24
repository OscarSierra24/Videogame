using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goomba : MonoBehaviour {

    public Node[] path;
    public float threshold;
    private Node currNode;
    private int currNodeIndex;
    private Animator a;

    // Use this for initialization
    void Start () {
        a = GetComponent<Animator>();
        currNodeIndex = 0;
        currNode = path[currNodeIndex];
    }

    // Update is called once per frame
    void Update() {
        //transform.Translate(Vector3.right * Time.deltaTime*.7f);
        if (Vector3.Distance(transform.position, currNode.transform.position) < threshold) {
            if (currNodeIndex + 1 < path.Length)
            {
                currNodeIndex++;
                a.SetBool("direction", false);

            }
            else {
                currNodeIndex = 0;
                a.SetBool("direction", true);
            }
            currNode = path[currNodeIndex];
        }

        /*Vector3 patrolPointDir = currNode.transform.position - transform.position;
        float angle = Mathf.Atan2(patrolPointDir.x, patrolPointDir.y) * Mathf.Rad2Deg-90f;

        Quaternion q = Quaternion.AngleAxis(angle, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, 90f);*/
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), currNode.transform.position, 0.7f * Time.deltaTime);

    }

}
