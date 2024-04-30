using BeldYazilim.Application.Features.Mediator.Commands.ArticleCommands;
using BeldYazilim.Application.Features.Mediator.Handlers.ArticleHandlers;
using BeldYazilim.Application.Features.Mediator.Queries.ArticleQueries;
using BeldYazilim.Persistence.Context;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeldYazilim.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly BeldYazilimContext _context;
        //private readonly string _imageUploadDirectory = "wwwroot/images";
        private readonly string _imageUploadDirectory = "C:\\Users\\Hamza\\Desktop\\BeldYazilim\\FrontEnd\\BeldYazilim.WebUI\\wwwroot\\upload";


        public ArticleController(IMediator mediator, BeldYazilimContext context)
        {
            _mediator = mediator;

            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> ArticleList()
        {
            var values = await _mediator.Send(new GetArticleQuery());
            return Ok(values);
        }

        [HttpGet("ArticleListWithAuthors")]
        public async Task<IActionResult> ArticleListWithAuthors()
        {
            var values = await _mediator.Send(new GetAllArticleWithAuthorQuery());
            return Ok(values);
        }
        [HttpGet("ArticleListWithAuthorsAndCategory")]
        public async Task<IActionResult> ArticleListWithAuthorsAndCategory()
        {
            var values = await _mediator.Send(new GetAllArticleWithAuthorAndCategoryQuery());
            return Ok(values);
        }

        [HttpGet("GetTopRatedArticles")]
        public async Task<IActionResult> GetTopRatedArticles()
        {
            var values = await _mediator.Send(new GetTopRatedArticlesQuery());
            return Ok(values);
        }
        [HttpGet("GetLast4Articles")]
        public async Task<IActionResult> GetLast4Articles()
        {
            var values = await _mediator.Send(new GetLatestArticlesQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticle(int id)
        {
            var value = await _mediator.Send(new GetArticleByIdQuery(id));
            return Ok(value);
        }

        [HttpGet("article-with-author/{id}")] // İkinci endpoint
        public async Task<IActionResult> GetArticleWithAuthorById(int id)
        {
            var value = await _mediator.Send(new GetArticleWithAuthorsByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(CreateArticleCommand command)
        {

            await _mediator.Send(command);
            return Ok("Article başarıyla eklendi");

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveArticle(int id)
        {
            await _mediator.Send(new RemoveArticleCommand(id));
            return Ok("Article başarıyla silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateArticle(UpdateArticleCommand command)
        {
            await _mediator.Send(command);
            return Ok("Article başarıyla güncellendi");
        }

        //[HttpPost("UploadImage")]
        //[EnableCors("IzinVerilenKaynak")]
        //public async Task<IActionResult> UploadImage(IFormFile image)
        //{
        //    if (image == null || image.Length == 0)
        //        return BadRequest("Resim dosyası yüklenmedi.");

        //    try
        //    {
        //        // Resim dosyasını sunucuya kaydet
        //        var fileName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";
        //        var filePath = Path.Combine(_imageUploadDirectory, fileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            await image.CopyToAsync(stream);
        //        }

        //        // Resmin URL'sini döndür
        //        var imageUrl = $"{Request.Scheme}://{Request.Host}/images/{fileName}";
        //        return Ok(new { imageUrl });
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(500, $"Resim yüklenirken bir hata oluştu: {ex.Message}");
        //    }
        //}



        //[HttpPost("UploadCKEditorImage")]
        //public IActionResult UploadCKEditorImage()
        //{
        //    var files = Request.Form.Files;
        //    if (files.Count == 0)
        //    {
        //        var rError = new
        //        {
        //            uploaded = false,
        //            url = string.Empty
        //        };
        //        return BadRequest(rError);
        //    }

        //    var formFile = files[0];
        //    var upFileName = formFile.FileName;

        //    var fileName = Path.GetFileNameWithoutExtension(upFileName) +
        //        DateTime.Now.ToString("yyyyMMddHHmmss") + Path.GetExtension(upFileName);

        //    var saveDir = _imageUploadDirectory;
        //    var savePath = saveDir + fileName;
        //    var previewPath = "/upload/" + fileName;

        //    bool result = true;
        //    try
        //    {
        //        if (!Directory.Exists(saveDir))
        //        {
        //            Directory.CreateDirectory(saveDir);
        //        }
        //        using (FileStream fs = System.IO.File.Create(savePath))
        //        {
        //            formFile.CopyTo(fs);
        //            fs.Flush();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = false;
        //    }
        //    var rUpload = new
        //    {
        //        uploaded = result,
        //        url = result ? previewPath : string.Empty
        //    };
        //    return Ok(rUpload);
        //}
    }

    }

