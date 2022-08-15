using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WissenDandR302DataAccessLayer;
using WissenDandR302EntityLayer.Models;
using WissenDandR302EntityLayer.ViewModels;

namespace WissenDandR302BusinessLayer.Implementations
{
    public class AuthorService:Service<AuthorViewModel,Author,int>, IAuthorService
    {
        public AuthorService(IMapper mapper,IAuthorRepo repo)
            :base(mapper,repo, "BookList")
        {

        }
    }
}
