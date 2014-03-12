using MathHub.Core.Infrastructure;
using MathHub.Core.Interfaces.Blogs;
using MathHub.Core.Interfaces.Comments;
using MathHub.Core.Interfaces.Problems;
using MathHub.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MathHub.Web.Controllers
{
    public partial class BlogController : BaseController
    {
        private IBlogQueryService _blogQueryService;
        private IBlogCommandService _blogCommandService;
        private IProblemQueryService _problemQueryService;
        private IProblemCommandService _problemCommandService;
        private ICommentCommandService _commentCommandService;
        private IAuthenticationService _authenticationService;

        public BlogController(
            IProblemQueryService problemQueryService,
            ICommentCommandService commentCommandService,
            IProblemCommandService problemCommandService,
            IBlogQueryService blogQueryService,
            IBlogCommandService blogCommandService,
            IAuthenticationService authenticationService)
        {
            this._problemQueryService = problemQueryService;
            this._commentCommandService = commentCommandService;
            this._problemCommandService = problemCommandService;
            this._blogCommandService = blogCommandService;
            this._blogQueryService = blogQueryService;
            this._authenticationService = authenticationService;
        }
        
        // GET: /Blog/
        public ActionResult Index()
        {
            return null;
        }

    }
}
