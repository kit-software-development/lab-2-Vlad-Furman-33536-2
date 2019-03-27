namespace Practice.Organization
{
    /// <summary>
    ///     Абстрактное представление об отделе предприятия.
    ///     Тип, реализующий этот интерфейс, должен быть значащим типом.
    /// </summary>
    public interface IDepartment
    {
        /// <summary>
        ///     Название отдела
        /// </summary>
        string Name { get; }
    }
}
