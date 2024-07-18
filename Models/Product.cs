namespace ComputerShop.Models
{
    /// <summary>
    /// Продукт
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Идентификатор записи
        /// </summary>
        public Guid Id { get; set; } = new Guid();

        /// <summary>
        /// Наименование продукта
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
    }
}
