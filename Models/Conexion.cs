using Microsoft.EntityFrameworkCore;
namespace api_db.Models{
    class Conexion : DbContext{
        public Conexion(DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Clientes> Clientes { get; set; }
    }

    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306;database=net_core_api_db;userid=jimdev;pwd=27965949";
        public static Conexion ConectarBaseDatos(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var ct = new Conexion(constructor.Options);
            return ct;
        }
    }
}