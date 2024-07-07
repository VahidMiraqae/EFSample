using EFSample.EntityModels;
using Microsoft.EntityFrameworkCore;

using var db = new ChinookContext();

var allArtists = db.Artists.Include(a => a.Albums).ThenInclude(a => a.Tracks).AsSplitQuery();
var query = allArtists.ToQueryString();
var result = allArtists.ToList();

Console.Read();