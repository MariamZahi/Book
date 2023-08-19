using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YourNamespace.Models; // Make sure to replace "YourNamespace" with the appropriate namespace.

public class BooksController : Controller
{
    private readonly AppDbContext _dbContext;

    public BooksController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    // GET: Books
    public IActionResult Index()
    {
        var books = _dbContext.Books.Include(b => b.Category).ToList();
        return View(books);
    }

    // GET: Books/Create
    public IActionResult Create()
    {
        // Implement your code to populate dropdown lists or other data if needed.
        return View();
    }

    // POST: Books/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Book book)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }

    // GET: Books/Edit/5
    public IActionResult Edit(int id)
    {
        var book = _dbContext.Books.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }

    // POST: Books/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Book book)
    {
        if (id != book.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _dbContext.Update(book);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(book);
    }

    // GET: Books/Delete/5
    public IActionResult Delete(int id)
    {
        var book = _dbContext.Books.Find(id);
        if (book == null)
        {
            return NotFound();
        }
        return View(book);
    }

    // POST: Books/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmed(int id)
    {
        var book = _dbContext.Books.Find(id);
        _dbContext.Books.Remove(book);
        _dbContext.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}