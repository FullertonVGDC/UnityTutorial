using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {

	#region data member
	Rigidbody2D rigid;
	public	Sprite left;
	public	Sprite right;
	SpriteRenderer render;
	#endregion

	#region Build-in Method
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		render = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		// move base on the horizontal left and right arrow
		rigid.AddForce(new Vector2(Input.GetAxis("Horizontal") * 20,0));
		// update the spite to look like
		if (Input.GetAxis ("Horizontal") > 0.2f) {
			render.sprite = left;
		} else if (Input.GetAxis ("Horizontal") < -0.2f)  {
			render.sprite = right;
				}
		// Jump if player press Ctrl or Left mouse
		if (Input.GetButtonDown("Fire1")) {
			rigid.AddForce(new Vector2(0,120));	
				}
	}
	#endregion
}
