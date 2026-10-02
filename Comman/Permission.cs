using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    [Flags] //data anotation (decrator) => learn new behavior to calc
    public enum PermissionItem : byte // 0 : 255
    {
        write = 1,
        read = 2,
        update = 4,
        delete = 8,
        execute = 16,
        select = 32,
        select1 = 64,
        select2 = 128
    }

    public class Permission
    {
        public static void AddPermission(ref PermissionItem Current, params PermissionItem[] PermissionToAdd)
        {
            foreach (PermissionItem per in PermissionToAdd)
            {
                Current |= per; // => Current = Current | per;
            }
        }

        public static void RemovePermission(ref PermissionItem Current, params PermissionItem[] PermissionToRemove)
        {
            foreach (PermissionItem per in PermissionToRemove)
            {
                Current &= ~per; // => Current = Current & (~per);
            }
        }

        public static bool CheckPermission(PermissionItem Current, PermissionItem PermissionToCheck)
        {
            return (Current & PermissionToCheck) == PermissionToCheck;
        }
    }
}
