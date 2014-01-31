using System;

public struct Point3D
{
    public static readonly Point3D Start = new Point3D(0, 0, 0);

    private double x;
    private double y;
    private double z;

    public Point3D(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public double X
    {
        get { return this.x; }
    }

    public double Y
    {
        get { return this.y; }
    }

    public double Z
    {
        get { return this.z; }
    }

    public override string ToString()
    {
        return string.Format("({0}, {1}, {2})", this.x, this.y, this.z);
    }
}