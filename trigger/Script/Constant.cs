using static System.Environment;
using static System.Environment.SpecialFolder;
using static trigger.Properties.Resources;

namespace trigger.Script;

internal static class Constant
{
    internal static readonly string APP_ADR = $@"{GetFolderPath(ProgramFiles)}\{co_name}\{bot_name}\{app_name}.exe";
    internal static readonly string BOT_ADR = $@"{GetFolderPath(ProgramFiles)}\{co_name}\{bot_name}\{bot_name}.exe";
}
