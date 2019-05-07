using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages.Calculator
{
 public class AdditionModel : PageModel
 {
  [BindProperty]
  public decimal VarA { get; set; }
  [BindProperty]
  public decimal VarB { get; set; }
  [BindProperty]
  public decimal Result { get; set; }

  public void OnGet()
  {

  }

  public void OnPost()
  {
   this.Result = this.VarA + this.VarB;
  }

 }
}