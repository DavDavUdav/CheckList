using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Database.Entities
{
    internal class Card
    {
        /// <summary>
        /// Id карточки.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование карточки.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание карточки.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Срок выполнения.
        /// </summary>
        public DateTime Term_of_execution { get; set; }

        /// <summary>
        /// Позиция в списке.
        /// </summary>
        public int Position { get; set; }

        /// <summary>
        /// Id списка к которому относится карточка.
        /// </summary>
        public int Id_List { get; set; }
    }
}