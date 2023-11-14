using CheckList.Database;
using CheckList.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckList.Services
{
    internal class BoardService
    {
        private SQLiteBoardRepository _boardRepository;

        public BoardService(SQLiteBoardRepository sQLiteBoardRepository) 
        { 
            _boardRepository = sQLiteBoardRepository;
        }

        public async Task<Board> GetByIdAsync(int id)
        {
            return await _boardRepository.GetByIdAsync(id);
        }

        public void CreateAsync(Board board)
        {
            _boardRepository.CreateAsync(board);
        }

        //todo: Дописать сервис для работы с досками

    }
}
