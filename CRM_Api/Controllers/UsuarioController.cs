using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM_Api.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        string conexionBDmesa = "Server=DESKTOP-P804OHV;Database=CRM;Trusted_Connection=True;MultipleActiveResultSets=true;";
        string conexionBDportatil = "Server=DESKTOP-1H3OQ1O\\SQLEXPRESS;Database=CRM;Trusted_Connection=True;MultipleActiveResultSets=true;";



        // GET: api/<UsuarioController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<UsuarioController>/5
        //("{Email}")
        [HttpGet("{Email}/{Contraseña}")]
        public Usuario Get(string Email, string Contraseña)
        {
            Usuario usuario = null; 

            using (SqlConnection con = new SqlConnection(conexionBDportatil))
            {
                SqlCommand cmd = new SqlCommand("SELECT IdUsuario, Nombre, Apellidos, Email, Contraseña FROM Usuarios WHERE Email = @email AND Contraseña = @Contraseña", con);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while(dr.Read())
                {
                    int idUsuario = Convert.ToInt32(dr["IdUsuario"]);
                    string nombre = Convert.ToString(dr["Nombre"]);
                    string apellidos = Convert.ToString(dr["Apellidos"]);
                    string email = Convert.ToString(dr["Email"]);
                    string contraseña = Convert.ToString(dr["Contraseña"]);

                    Result<Usuario> resultado =  Usuario.Generar(nombre, apellidos, email, contraseña, idUsuario);

                    usuario = resultado.Value;

                }


            }

            return usuario;
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
