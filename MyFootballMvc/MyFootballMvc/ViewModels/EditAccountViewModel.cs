﻿using MyFootballMvc.Models;
using System.Collections.Generic;

namespace MyFootballMvc.ViewModels
{
  public class EditAccountViewModel : LayoutViewModel
  {
    public User User { get; set; }
    public Player Player { get; set; }
    public Staff Staff { get; set; }
    public Referee Referee { get; set; }
    public Landlord Landlord { get; set; }
    public Coach Coach { get; set; }
    public bool IsMember { get; set; }
    public List<Team> Teams { get; set; }

    public EditAccountViewModel() : base()
    {

    }

    public EditAccountViewModel(string token, string id) : base(token, id)
    {

    }

  }
}
