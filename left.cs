using System.Runtime.InteropServices;
using System;

class SwapMouse {
    [DllImport("user32.dll")]
    public static extern Int32 SwapMouseButton(Int32 bSwap);
    static void Main(string[] args) {
        SwapMouseButton(1);
    }
}
