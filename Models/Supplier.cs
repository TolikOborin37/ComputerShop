namespace ComputerShop.Models
{
    /// <summary>
    /// Поставщик
    /// </summary>
    public class Supplier
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Код поставщика
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Наименование поставщика
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Представитель
        /// </summary>
        public Contact Representative { get; set; }

        /// <summary>
        /// Рабочий адрес
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Рабочий телефон
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// Рабочий email
        /// </summary>
        public string Email { get; set; } = string.Empty;
    }
}
