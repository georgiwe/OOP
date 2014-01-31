using System;

[VersionAttribute(4, 13)]
public class SampleClass
{
    public SampleClass()
    {
    }

    public static string GetVersion()
    {
        string version = string.Empty;

        Type type = Type.GetType("SampleClass");

        foreach (var attr in type.CustomAttributes)
        {
            if (attr.AttributeType == typeof(VersionAttribute))
            {
                int major = (int)attr.ConstructorArguments[0].Value;
                int minor = (int)attr.ConstructorArguments[1].Value;

                version = string.Format("Version: {0}.{1}", major, minor);
            }
        }

        return version;
    }
}