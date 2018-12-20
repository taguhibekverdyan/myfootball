﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFootballRestApi.Data;
using MyFootballRestApi.Models;

namespace MyFootballRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamsController : ControllerBase
    {

        private readonly IRepository<Team> _teamsRepository;

        public TeamsController()
        {
            _teamsRepository = new CouchbaseRepository<Team>();
        }

        #region GET
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var teams = await _teamsRepository.GetAll(typeof(Team));
                return Ok(teams);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTeamById([FromRoute]string id)
        {
            try
            {
                var team = await _teamsRepository.Get(id);
                if (team == null) { return NotFound(); }
                return Ok(team);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
        #endregion

        #region POST

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody]Team team)
        {
            try
            {
                string id = team.Id.ToString();
                var result = await _teamsRepository.Create(id,team);
                if (result == null) { return BadRequest(team); }
                return Created($"/api/Teams/{id}",result);
            }
            catch (Exception e)
            {
                return StatusCode(500,e);
            }
        }

        [HttpPost("Upsert")]
        public async Task<IActionResult> Upsert([FromBody] Team team)
        {
            try
            {
                string id = team.Id.ToString();
                var result = await _teamsRepository.Upsert(id, team);
                if (result == null) return BadRequest(team);
                return Created($"/api/teams/{id}", result);
            }
            catch (Exception e)
            {
                return StatusCode(500,e);
            }
        }

        #endregion

        #region PUT
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] Team team)
        {
            try
            {
                string id = team.Id.ToString();
                var result = await _teamsRepository.Update(id, team);
                if (result == null) return BadRequest(team);
                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
        #endregion

        #region DELETE

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {      
            try
            {
                await _teamsRepository.Delete(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return StatusCode(500,e);
            }
        }

        #endregion

    }
}