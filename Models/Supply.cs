namespace ComputerShop.Models
{
    /// <summary>
    /// Поставка
    /// </summary>
    public class Supply
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Код поставки
        /// </summary>
        public string Code { get; set; } = string.Empty;

        /// <summary>
        /// Дата поставки
        /// </summary>
        public DateTime DateSupply { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        public Supplier Supplier { get; set; }
    }
}
