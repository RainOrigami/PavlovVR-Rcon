namespace PavlovVR_Rcon.Models.Pavlov;

/// <summary>
///     For use with SetLimitedAmmoTypeCommand
/// </summary>
public enum AmmoType
{
    Unlimited = 0,
    LimitedGeneric = 1,
    LimitedSpecific = 3,
    Custom = 3,
    LimitedSpecial = 4,
    BoxlessMode = 5,
}
