namespace ComputerShop.Models
{
    /// <summary>
    /// Контакт
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// ФИО
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Адрес проживания
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Мобильный телефон
        /// </summary>

        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
