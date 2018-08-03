namespace MyComparer
{
    using System.Collections.Generic;
    using MyList.DAL.Entities;

    public static class MyExtension
    {
        public static IEnumerable<File> Duplicates(
            this IEnumerable<File> files, 
            IMyEqualityComparer<File> comparer)
            => comparer.Duplicates(files);
    }
}