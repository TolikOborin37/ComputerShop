namespace ComputerShop.Models
{
    /// <summary>
    /// Клиент
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Код клиента
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Контакт
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
