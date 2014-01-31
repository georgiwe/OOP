using System;
using System.Collections.Generic;

public class Path
{
    private List<Point3D> path;

    public Path()
    {
        this.path = new List<Point3D>();
    }

    public Path(params Point3D[] points) : this()
    {
        for (int i = 0; i < points.Length; i++)
        {
            this.path.Add(points[i]);
        }
    }

    public List<Point3D> PathOfPoints
    {
        get { return new List<Point3D>(this.path); }
    }

    public void AddPoint(Point3D point)
    {
        this.path.Add(point);
    }
}