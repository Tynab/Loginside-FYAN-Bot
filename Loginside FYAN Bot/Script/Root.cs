using System;
using System.Runtime.InteropServices;

namespace Loginside_FYAN_Bot.Script;

internal class Root
{
    // Fields
    private const byte SW_HIDE = 0;
    private const byte SW_SHOW = 5;

    // Get window
    [DllImport("kernel32.dll")]
    private static extern IntPtr GetConsoleWindow();

    // Show window
    [DllImport("user32.dll")]
    private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

    /// <summary>
    /// Hide window console.
    /// </summary>
    public static void HideConsole() => ShowWindow(GetConsoleWindow(), SW_HIDE);

    /// <summary>
    /// Show window console.
    /// </summary>
    public static void ShowConsole() => ShowWindow(GetConsoleWindow(), SW_SHOW);
}
