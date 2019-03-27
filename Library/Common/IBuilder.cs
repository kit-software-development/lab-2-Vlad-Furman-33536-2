namespace Practice.Common
{
    /// <summary>
    ///     Абстрактное представление об эталоне проектирования "Строитель".
    /// </summary>
    /// <typeparam name="T">
    ///    Тип экземпляров, создаваемых строителем.
    /// </typeparam>
    public interface IBuilder<T>
    {
        /// <summary>
        ///     Возвращает экземпляр типа, описанного параметром T.
        /// </summary>
        /// <returns>Экземпляр типа T.</returns>
        T Build();
    }
}