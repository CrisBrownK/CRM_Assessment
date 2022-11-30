using Aplicacion.dtos;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data.SqlClient;


//Server={_DevServer};Database={DbName};Trusted_Connection=True;MultipleActiveResultSets=true;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRM_Api.Controllers
{
    [Route("api/oportunidad")]
    [ApiController]
    public class OportunidadesController : ControllerBase
    {


        // GET: api/<OportunidadesController>
        [HttpGet]
        public List<Oportunidad> Get()
        {
            //Mostrar lista de oportunidades
            //return new string[] { "value1", "value2" };
            //return Ok(oportunidades);

            List<Oportunidad> oportunidades = new List<Oportunidad>();

            //DESKTOP-P804OHV
            //DESKTOP-1H3OQ1O\\SQLEXPRESS


            using (SqlConnection con = new SqlConnection("Server=DESKTOP-P804OHV;Database=CRM;Trusted_Connection=True;MultipleActiveResultSets=true;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdOportunidad, IdCliente, Nombre, PrimerApellido, SegundoApellido, Dni, Telefono, Email, IdMotivo, Contratado FROM Oportunidades", con);
                SqlDataReader dr = cmd.ExecuteReader();
                //con.Close(); No haria falta ponerlo ya que una vez salga del 'using' lo cierra de igual forma

                while (dr.Read())
                {
                    int idOportunidad = Convert.ToInt32(dr["IdOportunidad"]);
                    int? idCliente = null; 
                    if(dr["IdCliente"] != DBNull.Value)
                    {
                        idCliente = Convert.ToInt32(dr["IdCliente"]);
                    }
                    string nombre = Convert.ToString(dr["Nombre"]);
                    string primerApellido = Convert.ToString(dr["PrimerApellido"]);
                    string segundoApellido = Convert.ToString(dr["SegundoApellido"]);
                    string dni = Convert.ToString(dr["Dni"]);
                    string telefono = Convert.ToString(dr["Telefono"]);
                    string email = Convert.ToString(dr["Email"]);
                    int idMotivo = Convert.ToInt32(dr["IdMotivo"]);
                    bool contratado = Convert.ToBoolean(dr["Contratado"]);

                    Result<Oportunidad> resultado =  Oportunidad.Generar(nombre, primerApellido, dni, telefono, email, idMotivo, contratado, idCliente, segundoApellido, idOportunidad);

                    Oportunidad oportunidad = resultado.Value;

                    oportunidades.Add(oportunidad);

                }


            }

               
            return oportunidades;
        }



        // GET api/<OportunidadesController>/5
        [HttpGet("{id}")]
        public Oportunidad Get(int id)
        {
            //Mostrar oportunidad por Id

            Oportunidad oportunidad = null;


            using (SqlConnection con = new SqlConnection("Server=DESKTOP-P804OHV;Database=CRM;Trusted_Connection=True;MultipleActiveResultSets=true;"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdOportunidad, IdCliente, Nombre, PrimerApellido, SegundoApellido, Dni, Telefono, Email, IdMotivo, Contratado FROM Oportunidades WHERE IdOportunidad = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);

                SqlDataReader dr = cmd.ExecuteReader();

                //con.Close(); No haria falta ponerlo ya que una vez salga del 'using' lo cierra de igual forma

                while (dr.Read())
                {
                    int idOportunidad = Convert.ToInt32(dr["IdOportunidad"]);
                    int? idCliente = null;
                    if (dr["IdCliente"] != DBNull.Value)
                    {
                        idCliente = Convert.ToInt32(dr["IdCliente"]);
                    }
                    string nombre = Convert.ToString(dr["Nombre"]);
                    string primerApellido = Convert.ToString(dr["PrimerApellido"]);
                    string segundoApellido = Convert.ToString(dr["SegundoApellido"]);
                    string dni = Convert.ToString(dr["Dni"]);
                    string telefono = Convert.ToString(dr["Telefono"]);
                    string email = Convert.ToString(dr["Email"]);
                    int idMotivo = Convert.ToInt32(dr["IdMotivo"]);
                    bool contratado = Convert.ToBoolean(dr["Contratado"]);

                    Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, telefono, email, idMotivo, contratado, idCliente, segundoApellido, idOportunidad);

                    oportunidad = resultado.Value;

                }

            }

            return oportunidad;
        }


        // POST api/<OportunidadesController>
        [HttpPost]
        public void Post([FromBody] OportunidadPostDTO oportunidad)
        {
            Result<Oportunidad> resultado = Oportunidad.Generar(oportunidad.Nombre, oportunidad.PrimerApellido, oportunidad.Dni, oportunidad.Telefono, oportunidad.Email, oportunidad.IdMotivo, oportunidad.Contratado, oportunidad.IdCliente, oportunidad.SegundoApellido);

            if (resultado.IsFailure)
            {
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Server=DESKTOP-P804OHV;Database=CRM;Trusted_Connection=True;MultipleActiveResultSets=true;"))
                {

                    con.Open();

                    SqlCommand cmdValidar = new SqlCommand("SELECT Count(*) FROM Oportunidades WHERE Dni = @dni AND IdMotivo = @idMotivo", con);
                    cmdValidar.Parameters.AddWithValue("@dni", oportunidad.Dni);
                    cmdValidar.Parameters.AddWithValue("@idMotivo", oportunidad.IdMotivo);
                    int count = Convert.ToInt32(cmdValidar.ExecuteScalar());

                    if (count > 0) return; 

                    SqlCommand cmd = new SqlCommand("INSERT INTO Oportunidades (IdCliente ,Nombre ,PrimerApellido ,SegundoApellido ,Dni ,Telefono ,Email ,IdMotivo ,Contratado) VALUES (@IdCliente, @Nombre, @PrimerApellido, @SegundoApellido, @Dni, @Telefono, @Email, @IdMotivo, @Contratado)", con);

                    if (oportunidad.IdCliente == null)
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@IdCliente", oportunidad.IdCliente);
                    }

                    cmd.Parameters.AddWithValue("@Nombre", oportunidad.Nombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", oportunidad.PrimerApellido);

                    if (oportunidad.SegundoApellido == null)
                    {
                        cmd.Parameters.AddWithValue("@SegundoApellido", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@SegundoApellido", oportunidad.SegundoApellido);
                    }

                    cmd.Parameters.AddWithValue("@Dni", oportunidad.Dni);
                    cmd.Parameters.AddWithValue("@Telefono", oportunidad.Telefono);
                    cmd.Parameters.AddWithValue("@Email", oportunidad.Email);
                    cmd.Parameters.AddWithValue("@IdMotivo", oportunidad.IdMotivo);
                    cmd.Parameters.AddWithValue("@Contratado", oportunidad.Contratado);



                    cmd.ExecuteNonQuery();


                }

            }
            catch (Exception ex)
            {

            }



        }

        // PUT api/<OportunidadesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //Cambiar estado a contratado
        }


    }
}
