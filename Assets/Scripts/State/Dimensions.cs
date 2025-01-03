using UnityEngine;

namespace State {
  public class Dimensions : AttributeVector3 {
    [field:SerializeField]
    public override Vector3 Base { get; set; }

    void OnDrawGizmosSelected() {
      var dimensions = Value;
      var center = dimensions.y/2 * Vector3.up + transform.position;
      Gizmos.color = Color.grey;
      Gizmos.DrawWireCube(center, dimensions);
    }
  }
}