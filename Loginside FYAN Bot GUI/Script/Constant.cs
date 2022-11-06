using System.Media;
using static Loginside_FYAN_Bot_GUI.Properties.Resources;
using static System.AppDomain;
using static System.IO.Directory;

namespace Loginside_FYAN_Bot_GUI.Script
{
    internal static class Constant
    {
        // path
        internal static readonly string CONFIG_ADR = $@"{GetParent(CurrentDomain.BaseDirectory)}\{serv_name}.exe.config";

        // sound
        internal static readonly SoundPlayer SND_BACK = new(sBack);
        internal static readonly SoundPlayer SND_NEXT = new(sNext);
        internal static readonly SoundPlayer SND_HOV = new(sHover);
        internal static readonly SoundPlayer SND_PRS = new(sPress);
        internal static readonly SoundPlayer SND_CHG = new(sChange);

        // animator
        internal const float ANIMAT_SPD = 0.02f;

        // other
        internal const int TIME_OUT = 3000;
        internal static readonly char[] PWD_RULE = { '@', '#', '$', '%' };

        // service status
        internal enum ServSts
        {
            Started,
            Stoped,
            NotFd
        }
    }
}
