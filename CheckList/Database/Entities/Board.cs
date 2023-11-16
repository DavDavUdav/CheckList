namespace CheckList.Database.Entities;

internal class Board
{
    /// <summary>
    /// Id доски.
    /// </summary>
    public int Id { get; set; }
        
    /// <summary>
    /// Имя доски.
    /// </summary>
    public string? Name { get; set; }
        
    /// <summary>
    /// Описание.
    /// </summary>
    public string? Description { get; set; }
        
    /// <summary>
    /// Создатель доски.
    /// </summary>
    public int Creator {  get; set; }
}

