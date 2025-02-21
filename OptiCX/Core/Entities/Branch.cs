﻿namespace Core.Entities;

public class Branch
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Name { get; set; }
    public Address Address { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}