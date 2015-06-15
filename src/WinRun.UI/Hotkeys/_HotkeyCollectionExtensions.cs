﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinRun.UI.Hotkeys
{
    public static class _HotkeyCollectionExtensions
    {
        public static IHotkeyCollection Add(this IHotkeyCollection collection, ModifierKeys modifier, Key key, Action<Hotkey> handler)
        {
            return collection.Add(new Hotkey(modifier, key), handler);
        }

        public static IHotkeyCollection Remove(this IHotkeyCollection collection, ModifierKeys modifier, Key key)
        {
            return collection.Remove(new Hotkey(modifier, key));
        }
    }
}
