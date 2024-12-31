using System;

class PermissionsEnum
{
    [Flags]
    public enum Permissions
    {
        None = 0,
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    public void ManagePermissions()
    {
        Permissions userPermissions = Permissions.None;

       
        userPermissions |= Permissions.Read | Permissions.Write;
        Console.WriteLine($"Permissions after adding Read and Write: {userPermissions}");

        
        bool canExecute = userPermissions.HasFlag(Permissions.Execute);
        Console.WriteLine($"Does the user have Execute permission? {canExecute}");

        
        userPermissions &= ~Permissions.Write;
        Console.WriteLine($"Permissions after removing Write: {userPermissions}");

       
        bool canRead = userPermissions.HasFlag(Permissions.Read);
        Console.WriteLine($"Does the user have Read permission? {canRead}");
    }
}
