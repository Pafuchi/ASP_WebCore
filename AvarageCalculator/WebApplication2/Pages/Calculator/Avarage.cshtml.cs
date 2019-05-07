using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication2.Pages
{
 public class AvarageModel : PageModel
 {
  public byte PocetCisel { get; set; }
  [BindProperty]
  public Dictionary<Byte, Decimal> Values { get; set; }
  public Decimal AvarageNum { get; set; }

  public void OnGet(Byte KolikCisel)
  {
   this.PocetCisel = KolikCisel;
  }

  public void OnPost()
  {
   AvarageNum = Values.Average(k => k.Value);
  }
 }
}