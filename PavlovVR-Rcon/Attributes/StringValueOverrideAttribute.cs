namespace PavlovVR_Rcon.Attributes;

[AttributeUsage(AttributeTargets.Field)]
public class StringValueOverrideAttribute : Attribute
{
    public StringValueOverrideAttribute(string value)
    {
        this.Value = value;
    }

    public string Value { get; }
}
