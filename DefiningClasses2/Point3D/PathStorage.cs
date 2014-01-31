using System;
using System.IO;
using System.Linq;

public static class PathStorage
{
    public static void StorePath(Path path, string fileName, bool overwrite = false)
    {
        var pth = path.PathOfPoints;

        using (StreamWriter writer = new StreamWriter(fileName, overwrite))
        {
            for (int i = 0; i < pth.Count; i++)
            {
                writer.WriteLine(pth[i].ToString());
            }
        }
    }

    public static Path LoadPath(string filename)
    {
        Path result = new Path();

        using (StreamReader reader = new StreamReader(filename))
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                line = line.Trim('(', ')');

                double[] coords = line
                    .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(d => double.Parse(d)).ToArray();

                result.AddPoint(new Point3D(coords[0], coords[1], coords[2]));

                line = reader.ReadLine();
            }
        }

        return result;
    }
}