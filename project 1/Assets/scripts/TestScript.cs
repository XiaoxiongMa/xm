using System;
using UnityEngine;

public class TestScript : MonoBehaviour
{
   public float MySum(float x, int y)
   {
       float sum;
       sum = x + y;
       return sum;
   }

   private void OnTransformChildrenChanged()
   {
       throw new NotImplementedException();
   }
}

    



