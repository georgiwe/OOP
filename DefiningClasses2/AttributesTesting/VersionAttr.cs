using System;

[AttributeUsage(AttributeTargets.Class |
                AttributeTargets.Struct |
                AttributeTargets.Interface |
                AttributeTargets.Enum |
                AttributeTargets.Method,
                AllowMultiple = false)]
public sealed class VersionAttribute : Attribute
{
    public VersionAttribute(int major, int minor = 0)
    {
        this.Major = major;
        this.Minor = minor;
    }

    public int Major { get; set; }

    public int Minor { get; set; }
}