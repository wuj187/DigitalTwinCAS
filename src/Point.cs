
/*
 * Author: Digital Twin Forest Team
 * Purpose: A helper class of Circle
 */

public class Point
{
    private double x;
    private double y;

    public Point(double givenX, double givenY)
    {
        x = givenX;
        y = givenY;
    }

    public double getX() {return x;}

    public double getY() {return y;}

    public void setX(double newX){x = newX;}

    public void setY(double newY) {y = newY;}
}
