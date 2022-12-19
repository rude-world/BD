using DataBaseLib.Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseLib.Commands
{
    internal class Table2Commands : ITableEditorCommand
    {
        // ЕСЛИ нужна другая БД, просто меняем AccessDataBaseController
        // на нужную, например SQLiteDataBaseController
        // в следующей строке
        private AccessDataBaseController controller = new AccessDataBaseController();

        public void Select(string[] args)
        {

        }

        public void Insert(string[] args)
        {            
            string query = $"INSERT INTO [Покупатели] " +
                    $"([id], [name]," +
                    $"VALUES ({args[0]}, '{args[1]}')";
            controller.ExecuteCommand(query);
        }

        public void Update(string[] args)
        {
            string query = @$"UPDATE [Покупатели]
                    SET [name] = '{args[1]}'
                    WHERE [id] = {args[0]}";
            controller.ExecuteCommand(query);
        }

        public void Delete(string[] args)
        {
            string query = $"DELETE FROM [Покупатели] " +
                    $"WHERE [id] = {args[0]}";
            controller.ExecuteCommand(query);
        }


    }
}
