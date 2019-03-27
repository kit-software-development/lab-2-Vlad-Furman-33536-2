namespace Practice.Common
{
    /// <summary>
    ///     Скрытая реализация представления об имени человека.
    /// </summary>
    internal struct Name : IName
    {
        /*
         * TODO #1: Реализуйте интерфейс IName для структуры Name
         */
        public Name(string surname, string firstName, string patronymic)
        {
            this.Surname    = surname;
            this.FirstName  = firstName;
            this.Patronymic = patronymic;
            this.FullName   = GetFullName (surname, firstName, patronymic);
            this.ShortName  = GetShortName(surname, firstName, patronymic);
        }

        public Name(IName name)
        {
            this.FullName  = name.FullName;
            this.ShortName = name.ShortName;
            SplitFullName(this.FullName, out string surname, out string firstName, out string patronymic);
            this.Surname    = surname;
            this.FirstName  = firstName;
            this.Patronymic = patronymic;
        }


        public string FullName  { get; }
        public string ShortName { get; }

        /// <summary>
        ///     Фамилия.
        /// </summary>
        public string Surname { get; }

        /// <summary>
        ///     Имя.
        /// </summary>
        public string FirstName { get; }
        
        /// <summary>
        ///     Отчество.
        /// </summary>
        public string Patronymic { get; }


        private static string GetFullName(string surname, string firstName, string patronymic)
        {
            return $"{surname} {firstName} {patronymic}";
        }

        private static string InitialLetter(string namePart)
        {
            return namePart.ToUpper().Substring(0, 1);
        }

        private static string GetShortName(string surname, string firstName, string patronymic)
        {
            return $"{InitialLetter(surname)}.{InitialLetter(firstName)}.{patronymic}";
        }

        private static void SplitFullName(
                string fullName
        ,   out string surname
        ,   out string firstName
        ,   out string patronymic
        )
        {
            var split = fullName.Split(' ');
            surname    = split[0];
            firstName  = split[1];
            patronymic = split[2];
        }
        
    }
}
