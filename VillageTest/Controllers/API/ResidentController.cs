using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VillageTest.Models;
using System.Data.Entity;

namespace VillageTest.Controllers.API
{
    public class ResidentController : ApiController
    {
        //VillageDataContext VillageDB = new VillageDataContext();
        VillageDataContext villageDataContext = new VillageDataContext();

        // GET: api/Resident
        public IHttpActionResult Get()
        {
            try
            {
                DbSet<Resident> allResidents = villageDataContext.residents;
                return Ok(allResidents);
            }
            catch (SqlException exception)
            {
                return BadRequest(exception.Message);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        // GET: api/Resident/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Resident resident =await  villageDataContext.residents.FindAsync(id);
                if (resident != null)
                {
                    return Ok(resident);
                }
                return NotFound();
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST: api/Resident
        public IHttpActionResult Post([FromBody] Resident newResident)
        {
            try
            {
                villageDataContext.residents.Add(newResident);
                villageDataContext.SaveChanges();
                return Ok("saved");
            }
            catch (SqlException exception)
            {
                return BadRequest(exception.Message);

            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

        // PUT: api/Resident/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Resident newResident)
        {
            try
            {
                Resident updateResident = villageDataContext.residents.Find(id);
                updateResident.FathersName = newResident.FathersName;
                updateResident.Gender = newResident.Gender;
                updateResident.IsBornInVillage = newResident.IsBornInVillage;
                updateResident.BirthDay = newResident.BirthDay;
                await villageDataContext.SaveChangesAsync();
                return Ok("updated");

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Resident/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Resident deleteResident = villageDataContext.residents.Find(id);
                villageDataContext.residents.Remove(deleteResident);
                await villageDataContext.SaveChangesAsync();
                return Ok();

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
