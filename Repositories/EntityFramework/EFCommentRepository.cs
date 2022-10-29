using Entities.Models;
using Repositories.Concrete.Context;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityFramework
{
    public class EFCommentRepository : EFBaseRepository<Comment>,ICommentRepository
    {
        public EFCommentRepository(AppDbContext context) : base(context)
        {

        }
    }
}
