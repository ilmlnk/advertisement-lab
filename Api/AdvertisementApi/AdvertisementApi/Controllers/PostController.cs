using AdIntegration.Business.Services;
using AdIntegration.Data.Dto.PostDto;
using AdIntegration.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdIntegration.Api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class PostController : ControllerBase
{
    private readonly PostService _postService;

    public PostController(PostService postService)
    {
        _postService = postService;
    }

    [HttpGet("posts")]
    public IActionResult GetPosts()
    {
        var posts = _postService.GetPosts();
        return Ok(posts);
    }

    [HttpGet("post/{id}")]
    public IActionResult GetPostById(int id)
    {
        var post = _postService.GetPostById(id);
        return Ok(post);
    }

    [HttpPost("create")]
    public IActionResult CreatePost(CreatePostDto dto)
    {
        var createPost = new Post
        {
            Text = dto.Text,
            Photos = dto.Photos,
            CreatedByUser = dto.CreatedByUser,
            CreatedAt = dto.CreatedAt
        };

        var uploadPost = _postService.CreatePost(createPost);

        return Ok(uploadPost);
    }

    [HttpPut("update/{id}")]
    public IActionResult UpdatePostById(int id, UpdatePostDto dto)
    {
        var updatePost = new Post
        {
            Text = dto.Text,
            Photos = dto.Photos,
            CreatedByUser = dto.CreatedByUser,
            CreatedAt = dto.UpdatedAt
        };

        var uploadPost = _postService.UpdatePostById(id, updatePost);
        return Ok(uploadPost);
    }

}

