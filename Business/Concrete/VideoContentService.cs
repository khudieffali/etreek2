using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VideoContentService : IVideoContentService
    {
        IVideoContentDal _dal;

        public VideoContentService(IVideoContentDal dal)
        {
            _dal = dal;
        }

        public async Task<List<VideoContent>> GetVideoContents(int? courseId)
        {
            if(courseId == null)return null;
            return _dal.GetAll(x=>x.CourseId==courseId);
        }
    }
}
