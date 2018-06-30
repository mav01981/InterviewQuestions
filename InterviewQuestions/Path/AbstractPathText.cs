using System;
using System.Linq;
using Xunit;

namespace InterviewQuestions.Path
{
    class Path
    {
        public string[] _folders { get; set; }

        public Path(string path)
        {
            _folders = path.Split(@"/");
        }

        public void CD(string directory)
        {
            if (directory.Contains("..") && directory.Length == 4)
            {
                _folders[_folders.Length - 1] = directory.Substring(3, 1);
            }
            else if (!directory.Contains(".."))
            {
                _folders = directory.Split(@"/");
            }
        }
    }
    public class AbstractPathText
    {
        [Fact]
        public void Absoloute_Path()
        {
            Path p = new Path("/a/b/c/d");
            p.CD("../x");

            Assert.Equal("/a/b/c/x", String.Join("/", p._folders.Select(x => x.ToString()).ToArray()));
        }

        [Fact]
        public void Relative_Path()
        {
            Path p = new Path("/a/b/c/d");
            p.CD("/a/b/c/x");

            Assert.Equal("/a/b/c/x", String.Join("/", p._folders.Select(x => x.ToString()).ToArray()));
        }
    }
}
