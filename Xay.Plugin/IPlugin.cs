﻿namespace Xay.Plugin
{
    /// <summary>
    ///     Plugin interface. Every xây plugin must implement this interface.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        ///     Plugin name.
        /// </summary>
        string Name { get; }

        /// <summary>
        ///     Plugin version.
        /// </summary>
        string Version { get; }

        /// <summary>
        ///     Plugin author.
        /// </summary>
        string Author { get; }

        bool Enabled => true;
    }
}