/* math operators work the same as they do in math
the + adds the two operands together the - subtracts
the * multiplies the / devides. the = however is an asign function
*/
using UnityEngine;

public class mathOperators : MonoBehaviour {
    //length
    float length = 2.5f;
    //width
    int width = 3;
    //radius
    int radius = 5;
    //base
    int bottom = 4;
    //height
    int height = 2;
    float one = 1;
    float two = 2;
    float three = 3;
    float four = 4;
	// Use this for initialization
	void Start () {
        //diameter of circle
        float diameter = length * two;
        //print diameter
        print("the diameter is: " + diameter);
        //circumfrence of circle
        float circumfrence = two * Mathf.PI * radius;
        // print circumfrence
        print("the circumfrence of the circle is: "+ circumfrence);
        //area of a circle
        float areaOfCircle = Mathf.PI * Mathf.Pow(radius, two);
        // print area of circle
        print("the area of the circle is: " + areaOfCircle);
        //volume of a sphere
        double volume = (four / three) * Mathf.PI * Mathf.Pow(radius, three);
        // print volume
        print("the volume of the sphere is: " + volume);
        //perimiter of rectangle
        float perimiter = two * (length + width);
        //print perimetiter
        print("the perimiter of the rectangle is: " + perimiter);
        //area of rectangle
        float areaOfRectangle = length * width;
        //print area of rectangle
        print("the area of the rectangle is: " + areaOfRectangle);
        //area of triangle
        float areaOfTriangle = (one / two) * bottom * height;
        //print area of triangle
        print("the area of the triangle is: " + areaOfTriangle);
	}
	

}
