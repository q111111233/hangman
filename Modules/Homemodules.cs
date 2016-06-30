using Nancy;
using System.Collections.Generic;
using Hangman;

namespace Hangman
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=>{
        return View["index.cshtml"];
      };
      Get["/play"]=_=>{
        Word givenWord = new Word("windows");
        char[] result = new char[givenWord.GetLetters().Length];
        for(int i=0; i<givenWord.GetLetters().Length; i++)
        {
          result[i] = '_';
        }
        givenWord.SetResult(result);
        var allLetters = givenWord.GetResult();
        return View["letters.cshtml", allLetters];
      };
      Post["/input"]=_=>{
        char letter = Request.Form["inputletter"];
        var allLetters = new Word("windows").GetLetters();
        var allResult = new Word("windows").GetResult();
        for(int i=0; i<allLetters.Length; i++)
        {
          if(letter == allLetters[i]){
            allResult[i] = allLetters[i];
          }
          // else
          // {
          //   allResult[i] = '_';
          // }
        }
        return View["letters.cshtml", allResult];
      };
      // Get["/cds/new"]=_=>{
      //   return View["Cd_form.cshtml"];
      // };
      // Post["/cds"]=_=>{
      //   var newCd = new Cd(Request.Form["cd-name"]);
      //   var allCds = Cd.GetAll();
      //   return View["cds.cshtml", allCds];
      // };
      // Get["/cds/{id}"]= parameters =>{
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   var selectedCd = Cd.Find(parameters.id);
      //   var cdArtists = selectedCd.GetArtists();
      //   model.Add("cd", selectedCd);
      //   model.Add("artists", cdArtists);
      //   return View["cd.cshtml", model];
      // };
      // Get["/cds/{id}/artists/new"]= parameters =>{
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   Cd selectedCd = Cd.Find(parameters.id);
      //   List<Artist> allArtists = selectedCd.GetArtists();
      //   model.Add("cd", selectedCd);
      //   model.Add("artists", allArtists);
      //   return View["cd_artist_form.cshtml", model];
      // };
      // Post["/artists"]=_=>{
      //   Dictionary<string, object> model = new Dictionary<string, object>();
      //   Cd selectedCd = Cd.Find(Request.Form["cd-id"]);
      //   List<Artist> cdArtists = selectedCd.GetArtists();
      //   string artistDescription = Request.Form["artistDescription"];
      //   Artist newArtist = new Artist(artistDescription);
      //   cdArtists.Add(newArtist);
      //   model.Add("artists", cdArtists);
      //   model.Add("cd", selectedCd);
      //   return View["cd.cshtml", model];
      // };
      // Post["/search-by-artist"]= _ =>{
      //   List<Cd> model = new List<Cd>();
      //   string artistName = Request.Form["search"];
      //   string result = "";
      //   List<Cd> allCDs = Cd.GetAll();
      //   List<Artist> cdArtists;
      //   foreach(Cd a in allCDs)
      //   {
      //     cdArtists = a.GetArtists();
      //     foreach(Artist b in cdArtists)
      //     {
      //       if(b.GetDescription().ToLower().Contains(artistName.ToLower())){
      //         model.Add(a);
      //       }
      //     }
      //   }
      //   return View["selectedCDs.cshtml", model];
      // };
    }
  }
}
