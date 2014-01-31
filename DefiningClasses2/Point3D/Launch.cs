using System;

public class Program
{
    public static void Main()
    {
        Point3D point1 = new Point3D(2, 3, 4);
        Point3D point2 = new Point3D(4, 5, 6);
        
        double distance = Distance.Distance3D(point1, point2);
        Console.WriteLine(distance.ToString("F2"));

        Path path = new Path(point1, point2, new Point3D(2.11, 3.11, 4.11));

        PathStorage.StorePath(path);

        Path loadedPath = PathStorage.LoadPath("StoredPath.txt");
    }
}