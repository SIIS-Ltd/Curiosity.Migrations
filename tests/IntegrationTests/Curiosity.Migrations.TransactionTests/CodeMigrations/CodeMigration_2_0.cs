using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;

namespace Curiosity.Migrations.TransactionTests.CodeMigrations
{
    public class CodeMigration_2_0 : CodeMigration
    {
        public override DbVersion Version { get; } = new DbVersion(2, 0);

        public override string Comment { get; } = "Correct script via provider";
        
        public override async Task UpgradeAsync(DbTransaction? transaction = null, CancellationToken token = default)
        {
            await DbProvider.ExecuteScriptAsync("select 1;", token);
        }
    }
}