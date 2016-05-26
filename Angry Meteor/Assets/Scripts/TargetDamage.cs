using UnityEngine;
using System.Collections;

public class TargetDamage : MonoBehaviour {

    public int hitPoints = 2;
    public Sprite damagedSprite;
    public float damageImpactSpeed;

    private int currentHitPoints;
    private float damageImpactSpeedSqr;
    private SpriteRenderer _spriteRenderer;

	// Use this for initialization
	void Start () {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        currentHitPoints = hitPoints;
        damageImpactSpeedSqr = Mathf.Sqrt(damageImpactSpeed);
	}

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag != "Damager") {
            return;
        }

        if (collision.relativeVelocity.sqrMagnitude < damageImpactSpeedSqr) {
            return;
        }

        _spriteRenderer.sprite = damagedSprite;
        --currentHitPoints;

        if (currentHitPoints <= 0) {
            kill();
        }
    }

    void kill() {
        _spriteRenderer.enabled = false;
        GetComponent<Collider2D>().enabled = false;
        GetComponent<Rigidbody2D>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }
}
