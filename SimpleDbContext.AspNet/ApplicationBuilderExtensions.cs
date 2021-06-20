using System;
using Microsoft.AspNetCore.Builder;

namespace SimpleDbContext.AspNetCore
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseDbContext(this IApplicationBuilder builder, Action<DbContextBuilder> configure)
        {

            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            if (configure == null)
            {
                throw new ArgumentNullException(nameof(configure));
            }

            DbContextBuilder dbContextBuilder = builder.ApplicationServices.GetService(typeof(DbContextBuilder)) as DbContextBuilder;

            if (dbContextBuilder == null)
            {
                throw new ArgumentNullException(nameof(dbContextBuilder));
            }

            configure(dbContextBuilder);

            return builder;

        }
    }
}
