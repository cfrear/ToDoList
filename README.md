This was my first time using SQLite. A friend was telling me about it recently and I thought this task sounded like it would be a good application for it.
For an program this small it works fine, but for anything bigger I think I'd still prefer to use a proper database with EntityFramework and LINQ.

Given more time, I would make the following improvements:
- Fix filtering by date. 
 (I'm having an issue where I can't get the SQL query to match on the DueDate, even thought it is identical in the string.
  I expect it's either because I'm using DateOnly, or a SQLite issue.)
- Add Dark Mode (using MudThemes?)
- Everything is currently thrown into one class, I would like to split methods into appropriate classes
- Better error handling and input validation
- UI could be better
- More filter options
