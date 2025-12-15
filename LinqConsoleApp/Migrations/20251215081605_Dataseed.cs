using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LinqConsoleApp.Migrations
{
    /// <inheritdoc />
    public partial class Dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Voorbeelden",
                columns: new[] { "Id", "Count", "Description", "Name", "Role" },
                values: new object[,]
                {
                    { 1, 67, "Transform a collection of numbers using Select operator", "LINQ Select Query", 0 },
                    { 2, 13, "Filter a list of products based on price criteria", "LINQ Where Filter", 2 },
                    { 3, 17, "Sort employees by their salary in ascending order", "LINQ OrderBy Sorting", 1 },
                    { 4, 72, "Group customers by their country of residence", "LINQ GroupBy Operation", 2 },
                    { 5, 18, "Combine orders with customer information using Join", "LINQ Join Tables", 3 },
                    { 6, 24, "Calculate the total revenue from all sales", "LINQ Aggregate Sum", 1 },
                    { 7, 51, "Check if any student passed the exam", "LINQ Any Condition", 1 },
                    { 8, 38, "Verify that all products are in stock", "LINQ All Validation", 1 },
                    { 9, 52, "Get the first order placed by a customer", "LINQ First Element", 0 },
                    { 10, 81, "Implement pagination for a product list", "LINQ Skip and Take", 2 },
                    { 11, 40, "Insert a new customer into the database", "Entity Framework Add", 0 },
                    { 12, 9, "Modify existing product information", "Entity Framework Update", 3 },
                    { 13, 81, "Remove an obsolete record from inventory", "Entity Framework Delete", 2 },
                    { 14, 5, "Load related entities using eager loading", "Entity Framework Include", 3 },
                    { 15, 15, "Execute asynchronous database queries efficiently", "Async Query Pattern", 4 },
                    { 16, 69, "Filter data using multiple AND/OR conditions", "Complex Where Clause", 2 },
                    { 17, 19, "Flatten nested collections into a single sequence", "LINQ SelectMany Flatten", 0 },
                    { 18, 31, "Remove duplicate entries from a result set", "LINQ Distinct Values", 2 },
                    { 19, 82, "Count the number of active users in the system", "LINQ Count Records", 0 },
                    { 20, 54, "Calculate average product rating from reviews", "LINQ Average Calculation", 4 },
                    { 21, 75, "Find the highest and lowest temperatures recorded", "LINQ Max and Min", 1 },
                    { 22, 15, "Search for specific items in a collection", "LINQ Contains Search", 0 },
                    { 23, 6, "Find elements that exist in one set but not another", "LINQ Except Difference", 3 },
                    { 24, 63, "Merge two collections removing duplicates", "LINQ Union Combine", 0 },
                    { 25, 25, "Find common elements between two datasets", "LINQ Intersect Common", 3 },
                    { 26, 29, "Apply secondary sorting criteria to results", "LINQ ThenBy Sorting", 3 },
                    { 27, 15, "Reverse the order of elements in a sequence", "LINQ Reverse Order", 0 },
                    { 28, 60, "Retrieve exactly one record matching criteria", "LINQ Single Record", 2 },
                    { 29, 6, "Handle empty result sets with default values", "LINQ DefaultIfEmpty", 2 },
                    { 30, 70, "Filter elements by their specific type", "LINQ OfType Filtering", 3 },
                    { 31, 22, "Convert collection elements to a specific type", "LINQ Cast Conversion", 0 },
                    { 32, 37, "Combine two sequences element by element", "LINQ Zip Combine", 1 },
                    { 33, 7, "Generate a sequence of numbers within a range", "LINQ Range Generation", 3 },
                    { 34, 8, "Create a sequence with repeated values", "LINQ Repeat Elements", 2 },
                    { 35, 2, "Create an empty enumerable of a type", "LINQ Empty Collection", 3 },
                    { 36, 44, "Access related entities through navigation", "Navigation Properties", 2 },
                    { 37, 50, "Configure lazy loading for related data", "Lazy Loading Setup", 0 },
                    { 38, 83, "Track entity state changes in DbContext", "Change Tracking", 0 },
                    { 39, 1, "Manage database transactions with SaveChanges", "Transaction Handling", 0 },
                    { 40, 65, "Insert multiple records efficiently", "Bulk Insert Operation", 0 },
                    { 41, 91, "Optimize LINQ queries for better performance", "Query Performance", 4 },
                    { 42, 46, "Utilize database indexes in queries", "Index Usage", 1 },
                    { 43, 62, "Pre-compile frequently used queries", "Compiled Queries", 0 },
                    { 44, 37, "Project query results to DTOs or ViewModels", "Projection Mapping", 0 },
                    { 45, 44, "Perform string filtering and manipulation", "String Operations", 3 },
                    { 46, 53, "Filter records based on date ranges", "Date Filtering", 2 },
                    { 47, 30, "Handle nullable properties in LINQ queries", "Null Handling", 4 },
                    { 48, 59, "Implement conditional expressions in queries", "Conditional Logic", 3 },
                    { 49, 2, "Use subqueries within main queries", "Subquery Pattern", 4 },
                    { 50, 95, "Perform left outer joins between tables", "Left Join Implementation", 1 },
                    { 51, 71, "Combine grouping with join operations", "Group Join Pattern", 0 },
                    { 52, 11, "Introduce range variables in query syntax", "Let Clause Usage", 2 },
                    { 53, 33, "Continue queries after grouping or joining", "Into Continuation", 3 },
                    { 54, 15, "Compare query and method syntax approaches", "Query Syntax vs Method", 0 },
                    { 55, 22, "Understand lazy evaluation of LINQ queries", "Deferred Execution", 2 },
                    { 56, 51, "Force immediate query execution with ToList", "Immediate Execution", 4 },
                    { 57, 76, "Execute read-only queries without tracking", "AsNoTracking Query", 3 },
                    { 58, 71, "Retrieve entity by its primary key value", "Find by Primary Key", 1 },
                    { 59, 55, "Query the local DbContext cache", "Local Cache Access", 4 },
                    { 60, 65, "Attach existing entity to context for updates", "Attach Entity", 0 },
                    { 61, 35, "Access entity metadata and state information", "Entry Metadata", 4 },
                    { 62, 3, "Map complex types in entity models", "Complex Type Mapping", 1 },
                    { 63, 27, "Convert property values during persistence", "Value Conversion", 0 },
                    { 64, 22, "Use properties not in entity class definition", "Shadow Properties", 2 },
                    { 65, 42, "Configure backing fields for properties", "Backing Fields", 0 },
                    { 66, 99, "Handle concurrent updates with tokens", "Concurrency Tokens", 0 },
                    { 67, 11, "Implement logical deletion of records", "Soft Delete Pattern", 1 },
                    { 68, 33, "Apply automatic filters to all queries", "Global Query Filters", 3 },
                    { 69, 82, "Map multiple entities to single table", "Table Splitting", 0 },
                    { 70, 5, "Map single entity across multiple tables", "Entity Splitting", 4 },
                    { 71, 89, "Table-per-hierarchy inheritance mapping", "Inheritance TPH", 1 },
                    { 72, 92, "Table-per-type inheritance strategy", "Inheritance TPT", 4 },
                    { 73, 28, "Table-per-concrete-class mapping", "Inheritance TPC", 2 },
                    { 74, 63, "Configure many-to-many relationships", "Many-to-Many Relation", 3 },
                    { 75, 20, "Set up one-to-one entity relationships", "One-to-One Relation", 1 },
                    { 76, 19, "Configure one-to-many associations", "One-to-Many Relation", 0 },
                    { 77, 23, "Create self-referencing entity relationships", "Self Referencing", 4 },
                    { 78, 98, "Configure cascading delete behavior", "Cascade Delete", 3 },
                    { 79, 14, "Make navigation properties required", "Required Navigation", 4 },
                    { 80, 19, "Configure optional relationships", "Optional Navigation", 1 },
                    { 81, 56, "Define composite keys for entities", "Composite Primary Key", 2 },
                    { 82, 71, "Configure alternate unique keys", "Alternate Keys", 0 },
                    { 83, 60, "Create database indexes for performance", "Index Configuration", 1 },
                    { 84, 88, "Add unique constraints to properties", "Unique Constraints", 2 },
                    { 85, 35, "Define check constraints on tables", "Check Constraints", 4 },
                    { 86, 46, "Set default values for properties", "Default Values", 2 },
                    { 87, 94, "Configure computed column expressions", "Computed Columns", 4 },
                    { 88, 13, "Execute stored procedures from EF Core", "Stored Procedure Call", 0 },
                    { 89, 1, "Execute raw SQL queries safely", "Raw SQL Query", 0 },
                    { 90, 94, "Use interpolated strings in SQL queries", "SQL Interpolation", 3 },
                    { 91, 40, "Call database functions in LINQ", "Database Functions", 2 },
                    { 92, 40, "Map and use user-defined functions", "User-Defined Functions", 0 },
                    { 93, 91, "Map entities to database views", "View Mapping", 4 },
                    { 94, 89, "Work with SQL Server temporal tables", "Temporal Tables", 0 },
                    { 95, 34, "Configure owned entity types", "Owned Entity Types", 2 },
                    { 96, 61, "Define entities without primary keys", "Keyless Entity Types", 4 },
                    { 97, 82, "Add tags to queries for logging", "Query Tags", 3 },
                    { 98, 28, "Split complex queries for performance", "Split Queries", 1 },
                    { 99, 53, "Perform batch update operations", "Batch Updates", 4 },
                    { 100, 25, "Execute batch delete operations", "Batch Deletes", 4 }
                });

            migrationBuilder.InsertData(
                table: "Uitwerkingen",
                columns: new[] { "Id", "Owner", "Tries", "VoorbeeldId" },
                values: new object[,]
                {
                    { 1, "Andrew Wright", 4, 28 },
                    { 2, "Isabella Moore", 16, 65 },
                    { 3, "Sophia Davis", 8, 81 },
                    { 4, "Madison Mitchell", 15, 96 },
                    { 5, "Luna Roberts", 9, 90 },
                    { 6, "Steven Turner", 3, 59 },
                    { 7, "Robert Thomas", 13, 51 },
                    { 8, "Mark Hill", 3, 81 },
                    { 9, "Charlotte Martin", 10, 73 },
                    { 10, "Robert Thomas", 11, 79 },
                    { 11, "Emily Allen", 4, 94 },
                    { 12, "Michael Brown", 2, 22 },
                    { 13, "Richard Harris", 4, 30 },
                    { 14, "David Jackson", 17, 48 },
                    { 15, "Joseph Thompson", 9, 77 },
                    { 16, "Andrew Wright", 19, 36 },
                    { 17, "Brian Carter", 6, 19 },
                    { 18, "Luna Roberts", 12, 62 },
                    { 19, "Amelia Garcia", 19, 8 },
                    { 20, "Charles Rodriguez", 17, 32 },
                    { 21, "Kevin Perez", 17, 90 },
                    { 22, "John Smith", 6, 59 },
                    { 23, "John Smith", 17, 42 },
                    { 24, "Sofia Lopez", 13, 99 },
                    { 25, "Mia White", 18, 76 },
                    { 26, "Emma Johnson", 7, 66 },
                    { 27, "Emma Johnson", 14, 53 },
                    { 28, "Joseph Thompson", 7, 22 },
                    { 29, "Christopher Young", 13, 61 },
                    { 30, "Richard Harris", 13, 10 },
                    { 31, "Olivia Martinez", 17, 30 },
                    { 32, "Grace Phillips", 7, 1 },
                    { 33, "Emily Allen", 7, 16 },
                    { 34, "Ava Taylor", 13, 11 },
                    { 35, "Luna Roberts", 4, 66 },
                    { 36, "Ava Taylor", 13, 66 },
                    { 37, "Brian Carter", 7, 62 },
                    { 38, "Thomas Robinson", 9, 20 },
                    { 39, "Ella Adams", 11, 54 },
                    { 40, "Andrew Wright", 8, 66 },
                    { 41, "Steven Turner", 14, 23 },
                    { 42, "Richard Harris", 11, 82 },
                    { 43, "Sofia Lopez", 7, 59 },
                    { 44, "Joshua Green", 9, 99 },
                    { 45, "Daniel Lee", 17, 5 },
                    { 46, "Thomas Robinson", 8, 17 },
                    { 47, "Matthew Hall", 8, 1 },
                    { 48, "Steven Turner", 9, 31 },
                    { 49, "Evelyn Lewis", 14, 42 },
                    { 50, "Sophia Davis", 4, 80 },
                    { 51, "Charles Rodriguez", 18, 94 },
                    { 52, "Daniel Lee", 4, 95 },
                    { 53, "Madison Mitchell", 13, 64 },
                    { 54, "Scarlett Nelson", 10, 33 },
                    { 55, "Michael Brown", 3, 91 },
                    { 56, "Elizabeth King", 18, 57 },
                    { 57, "William Anderson", 8, 14 },
                    { 58, "Joseph Thompson", 3, 1 },
                    { 59, "Andrew Wright", 1, 24 },
                    { 60, "Kevin Perez", 16, 83 },
                    { 61, "Amelia Garcia", 12, 13 },
                    { 62, "Ella Adams", 6, 55 },
                    { 63, "Michael Brown", 1, 66 },
                    { 64, "Sophia Davis", 11, 79 },
                    { 65, "Daniel Lee", 14, 91 },
                    { 66, "Sofia Lopez", 17, 36 },
                    { 67, "Thomas Robinson", 17, 80 },
                    { 68, "Scarlett Nelson", 18, 82 },
                    { 69, "Andrew Wright", 2, 80 },
                    { 70, "Luna Roberts", 17, 19 },
                    { 71, "Mark Hill", 19, 81 },
                    { 72, "Ryan Baker", 9, 91 },
                    { 73, "Ava Taylor", 6, 83 },
                    { 74, "Joseph Thompson", 11, 92 },
                    { 75, "Kevin Perez", 2, 85 },
                    { 76, "Charlotte Martin", 17, 39 },
                    { 77, "James Wilson", 19, 14 },
                    { 78, "Madison Mitchell", 10, 97 },
                    { 79, "Emma Johnson", 11, 66 },
                    { 80, "Richard Harris", 3, 20 },
                    { 81, "Avery Scott", 3, 16 },
                    { 82, "Charles Rodriguez", 8, 57 },
                    { 83, "Grace Phillips", 14, 28 },
                    { 84, "Grace Phillips", 10, 62 },
                    { 85, "Abigail Walker", 1, 29 },
                    { 86, "Madison Mitchell", 18, 89 },
                    { 87, "Steven Turner", 6, 24 },
                    { 88, "Thomas Robinson", 16, 88 },
                    { 89, "Michael Brown", 16, 46 },
                    { 90, "Scarlett Nelson", 15, 89 },
                    { 91, "David Jackson", 17, 15 },
                    { 92, "Christopher Young", 12, 46 },
                    { 93, "Joshua Green", 9, 68 },
                    { 94, "Mia White", 7, 15 },
                    { 95, "James Wilson", 3, 50 },
                    { 96, "Daniel Lee", 7, 47 },
                    { 97, "Sofia Lopez", 3, 63 },
                    { 98, "Ella Adams", 7, 82 },
                    { 99, "Steven Turner", 7, 29 },
                    { 100, "Mia White", 8, 56 },
                    { 101, "James Wilson", 3, 93 },
                    { 102, "Amelia Garcia", 15, 61 },
                    { 103, "Evelyn Lewis", 18, 44 },
                    { 104, "Ryan Baker", 3, 48 },
                    { 105, "Robert Thomas", 13, 95 },
                    { 106, "Sophia Davis", 6, 73 },
                    { 107, "Amelia Garcia", 11, 48 },
                    { 108, "Grace Phillips", 3, 63 },
                    { 109, "David Jackson", 10, 53 },
                    { 110, "Charlotte Martin", 13, 28 },
                    { 111, "William Anderson", 10, 5 },
                    { 112, "James Wilson", 4, 23 },
                    { 113, "Robert Thomas", 14, 37 },
                    { 114, "Madison Mitchell", 1, 45 },
                    { 115, "Emma Johnson", 17, 5 },
                    { 116, "William Anderson", 11, 68 },
                    { 117, "Brian Carter", 17, 5 },
                    { 118, "Matthew Hall", 18, 87 },
                    { 119, "Sophia Davis", 3, 99 },
                    { 120, "Mia White", 3, 27 },
                    { 121, "Sophia Davis", 3, 25 },
                    { 122, "William Anderson", 13, 63 },
                    { 123, "Harper Clark", 2, 51 },
                    { 124, "Mark Hill", 17, 57 },
                    { 125, "Joseph Thompson", 10, 51 },
                    { 126, "Emma Johnson", 18, 30 },
                    { 127, "Emily Allen", 3, 91 },
                    { 128, "Brian Carter", 9, 81 },
                    { 129, "Isabella Moore", 12, 59 },
                    { 130, "Ava Taylor", 1, 5 },
                    { 131, "Isabella Moore", 18, 61 },
                    { 132, "Sophia Davis", 16, 89 },
                    { 133, "Ava Taylor", 17, 22 },
                    { 134, "Thomas Robinson", 14, 50 },
                    { 135, "William Anderson", 3, 98 },
                    { 136, "Evelyn Lewis", 4, 42 },
                    { 137, "Joseph Thompson", 1, 18 },
                    { 138, "Sofia Lopez", 14, 2 },
                    { 139, "Joseph Thompson", 5, 70 },
                    { 140, "Harper Clark", 18, 4 },
                    { 141, "Emma Johnson", 5, 4 },
                    { 142, "Charles Rodriguez", 10, 97 },
                    { 143, "Steven Turner", 5, 68 },
                    { 144, "Christopher Young", 17, 7 },
                    { 145, "Sophia Davis", 4, 39 },
                    { 146, "Thomas Robinson", 14, 32 },
                    { 147, "Ryan Baker", 15, 41 },
                    { 148, "William Anderson", 16, 1 },
                    { 149, "Brian Carter", 11, 21 },
                    { 150, "Emily Allen", 14, 59 },
                    { 151, "Ava Taylor", 15, 97 },
                    { 152, "William Anderson", 8, 48 },
                    { 153, "Charles Rodriguez", 14, 66 },
                    { 154, "John Smith", 10, 95 },
                    { 155, "Avery Scott", 15, 20 },
                    { 156, "James Wilson", 12, 54 },
                    { 157, "Elizabeth King", 19, 54 },
                    { 158, "Joseph Thompson", 12, 17 },
                    { 159, "Elizabeth King", 17, 44 },
                    { 160, "Emma Johnson", 12, 96 },
                    { 161, "Joshua Green", 8, 54 },
                    { 162, "Sophia Davis", 9, 10 },
                    { 163, "James Wilson", 18, 81 },
                    { 164, "Kevin Perez", 19, 99 },
                    { 165, "Andrew Wright", 16, 25 },
                    { 166, "Charles Rodriguez", 9, 8 },
                    { 167, "Ryan Baker", 15, 92 },
                    { 168, "Andrew Wright", 19, 78 },
                    { 169, "Michael Brown", 16, 12 },
                    { 170, "Ella Adams", 11, 49 },
                    { 171, "Emma Johnson", 9, 12 },
                    { 172, "Mark Hill", 5, 14 },
                    { 173, "Thomas Robinson", 13, 32 },
                    { 174, "Sophia Davis", 1, 72 },
                    { 175, "Avery Scott", 14, 100 },
                    { 176, "Abigail Walker", 14, 81 },
                    { 177, "Luna Roberts", 4, 46 },
                    { 178, "Joseph Thompson", 5, 84 },
                    { 179, "Emma Johnson", 2, 42 },
                    { 180, "Joshua Green", 1, 61 },
                    { 181, "Grace Phillips", 6, 37 },
                    { 182, "Richard Harris", 17, 53 },
                    { 183, "Madison Mitchell", 19, 57 },
                    { 184, "James Wilson", 1, 78 },
                    { 185, "Joshua Green", 14, 75 },
                    { 186, "Robert Thomas", 18, 24 },
                    { 187, "Ella Adams", 10, 12 },
                    { 188, "Richard Harris", 17, 37 },
                    { 189, "Emma Johnson", 13, 22 },
                    { 190, "Mia White", 13, 16 },
                    { 191, "Mark Hill", 13, 62 },
                    { 192, "Mark Hill", 3, 70 },
                    { 193, "Joseph Thompson", 9, 85 },
                    { 194, "Charles Rodriguez", 13, 75 },
                    { 195, "Isabella Moore", 16, 14 },
                    { 196, "Sofia Lopez", 12, 51 },
                    { 197, "Sophia Davis", 16, 16 },
                    { 198, "Ava Taylor", 19, 53 },
                    { 199, "Evelyn Lewis", 13, 45 },
                    { 200, "Grace Phillips", 6, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Uitwerkingen",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Voorbeelden",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
