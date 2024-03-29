﻿namespace HuduAPI.Endpoints.Commands
{
    /// <summary>
    /// This interface is used to implement the Command Pattern that is used by all endpoints that
    /// have a return object.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of the result expected to be generated by the command.
    /// </typeparam>
    internal interface ICommand<TResult>
    {
        /// <summary>
        /// Executes the command implemented in the implementor class.
        /// </summary>
        /// <returns>
        /// Returns a generic object of type TResult
        /// </returns>
        public TResult Execute();
    }

    /// <summary>
    /// This interface is used to implement the Command Pattern that is used by all endpoints that
    /// have no return type.
    /// </summary>
    internal interface ICommand
    {
        /// <summary>
        /// Executes the command implemented in the implementor class.
        /// </summary>
        /// <returns>
        /// Returns a generic object of type TResult
        /// </returns>
        public void Execute();
    }
}