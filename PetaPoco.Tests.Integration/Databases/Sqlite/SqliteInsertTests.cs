﻿// <copyright company="PetaPoco - CollaboratingPlatypus">
//      Apache License, Version 2.0 https://github.com/CollaboratingPlatypus/PetaPoco/blob/master/LICENSE.txt
// </copyright>
// <author>PetaPoco - CollaboratingPlatypus</author>
// <date>2015/12/06</date>

using Xunit;

namespace PetaPoco.Tests.Integration.Databases.Sqlite
{
    [Collection("SqliteTests")]
    public class SqliteInsertTests : BaseInsertTests
    {
        public SqliteInsertTests()
            : base(new SqliteDBTestProvider())
        {
        }
    }
}