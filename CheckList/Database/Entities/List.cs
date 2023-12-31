﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Database.Entities
{
    internal class List
    {
        /// <summary>
        /// Id списка.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование списка.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Id доски к которой относится.
        /// </summary>
        public int Id_Board { get; set; }
    }
}
