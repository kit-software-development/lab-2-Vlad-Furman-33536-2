using Practice.Common;

namespace Practice.HR
{
    /// <summary>
    ///     Абстрактное представление о клиенте.
    /// </summary>
    public interface IClient : IPerson
    {
        /// <summary>
        ///     Значение скидки в процентах.
        /// </summary>
        float Discount { get; set; }
    }

    /// <summary>
    ///     Абстрактное представление о реализации эталона
    ///     проектирования "Строитель" для типа данных IClient.
    /// </summary>
    public interface IClientBuilder : IBuilder<IClient>
    {
        /// <summary>
        ///     Настраивает значение имени для будущего экземпляра типа IClient.
        /// </summary>
        /// <param name="name">имя сотрудника</param>
        /// <returns>
        ///     Текущий экземпляр "Строителя".
        /// </returns>
        IClientBuilder Name(IName name);

        /// <summary>
        ///     Настраивает значение имени для будущего экземпляра типа IClient.
        /// </summary>
        /// <param name="name">имя</param>
        /// <param name="surname">фамилия</param>
        /// <param name="patronymic">отчество</param>
        /// <returns>
        ///     Текущий экземпляр "Строителя".
        /// </returns>
        IClientBuilder Name(string name, string surname, string patronymic);

        /// <summary>
        ///     Настраивает значение скидки для будущего экземпляра типа IClient.
        /// </summary>
        /// <param name="discount">значение скидки</param>
        /// <returns>Текущий экземпляр "Строителя"</returns>
        IClientBuilder Discount(float discount);
    }
}
