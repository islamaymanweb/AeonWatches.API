﻿
using AeonWatches.API.Data.Repositories;
using AeonWatches.API.DTOs.OrderDTOs;
using AeonWatches.API.Entities.OrderEntities;
using AeonWatches.API.Entities.UserEntities;
using AeonWatches.API.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AeonWatches.API.Controllers;

[Authorize]
public class UserController : BaseApiController
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UserController(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _userRepository.GetUsers();
        
        return Ok(users);
    }
    
    //Admin
    [HttpGet("profile")]
    public async Task<ActionResult<AppUser>> GetUser()
    {
        try
        {
            var userId = User.GetUserId();
            
            var user = await _userRepository.GetUserById(userId);
        
            if (user == null) return NotFound("User not found");
            
            return Ok(user);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
    
    [HttpGet("details")]
    public async Task<ActionResult<CustomerDetailDto>> GetUsersCustomerDetails()
    {
        try
        {
            var userId = User.GetUserId();
            
            var user = await _userRepository.GetCustomerDetailByUserId(userId);
        
            if (user == null) return NotFound("User details not found");
            
            return Ok(user);

        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }

    [HttpPost("details")]
    public async Task<ActionResult<CustomerDetailDto>> CreateUserDetails(CustomerDetailDto customerDetailDto)
    {
        if (customerDetailDto == null) return BadRequest();
        
        try
        {
            var userId = User.GetUserId();
            
            var mappedCustomerDetail = _mapper.Map<CustomerDetail>(customerDetailDto);
            
            mappedCustomerDetail.AppUserId = userId;
            mappedCustomerDetail.IsMain = true;
            _userRepository.SetCustomerDetailIsMainToFalse(userId);

            _userRepository.AddCustomerDetail(mappedCustomerDetail, userId);

            if (await _userRepository.SaveAllAsync())
            {
                var customerDetail = await _userRepository.GetCustomerDetailByUserId(userId);
                return Ok(customerDetail);
            }
            
            return BadRequest("Failed to create customer detail");
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}