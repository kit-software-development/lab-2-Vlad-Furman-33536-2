using System;

namespace Practice.HR.Events
{
    /// <summary>
    ///     Обобщённое представление об аргументах события изменения некоторого свойства объекта.
    ///     Хранит значение, которое содержалось в ствойстве до изменения.
    /// </summary>
    /// <typeparam name="T">
    ///     Тип свойства, изменение которого обрабатывается событием.
    /// </typeparam>
    public class ValueChangeEventArgs<T> : EventArgs
    {
        /// <summary>
        ///     Старое значение свойства, которое изменилось.
        /// </summary>
        public T OldValue { get; }

        /// <summary>
        ///     Базовый конструктор. Принимает старое значение свойства.
        /// </summary>
        /// <param name="oldValue">
        ///     Значение свойства до изменения.
        /// </param>
        public ValueChangeEventArgs(T oldValue)
        {
            OldValue = oldValue;
        }
    }
}
