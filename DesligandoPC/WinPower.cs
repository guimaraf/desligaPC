using System;
using System.Runtime.InteropServices;

namespace DesligandoPC
{
    public class WinPower
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long valueNumber;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        [DllImport("Powrprof.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);


        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        public enum PowerOption
        {
            //Logoff = 0,
            Reboot = 2,
            PowerOff = 8,
            PowerOffForce = 4,
            PowerOffForceIfHung = 10,

            Sleep = 100,
            Hibernate = 102
        }

        public static void Execute(PowerOption option)
        {
            if (option == PowerOption.Sleep)
            {
                SetSuspendState(false, true, true);
                return;
            }
            else if (option == PowerOption.Hibernate)
            {
                SetSuspendState(true, true, true);
                return;
            }
            else
            {
                bool confirm;
                TokPriv1Luid tokPrivilege;
                IntPtr hproc = GetCurrentProcess();
                IntPtr htok = IntPtr.Zero;
                confirm = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
                tokPrivilege.Count = 1;
                tokPrivilege.valueNumber = 0;
                tokPrivilege.Attr = SE_PRIVILEGE_ENABLED;
                confirm = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tokPrivilege.valueNumber);
                confirm = AdjustTokenPrivileges(htok, false, ref tokPrivilege, 0, IntPtr.Zero, IntPtr.Zero);
                confirm = ExitWindowsEx((int)option, 0);
            }
        }
    }
}
