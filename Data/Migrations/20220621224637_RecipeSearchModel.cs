using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Myeal.Data.Migrations
{
    public partial class RecipeSearchModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpoonacularSearchViewModel",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vegetarian = table.Column<bool>(type: "bit", nullable: false),
                    vegan = table.Column<bool>(type: "bit", nullable: false),
                    glutenFree = table.Column<bool>(type: "bit", nullable: false),
                    dairyFree = table.Column<bool>(type: "bit", nullable: false),
                    veryHealthy = table.Column<bool>(type: "bit", nullable: false),
                    cheap = table.Column<bool>(type: "bit", nullable: false),
                    veryPopular = table.Column<bool>(type: "bit", nullable: false),
                    sustainable = table.Column<bool>(type: "bit", nullable: false),
                    lowFodmap = table.Column<bool>(type: "bit", nullable: false),
                    weightWatcherSmartPoints = table.Column<int>(type: "int", nullable: false),
                    gaps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    preparationMinutes = table.Column<int>(type: "int", nullable: false),
                    cookingMinutes = table.Column<int>(type: "int", nullable: false),
                    aggregateLikes = table.Column<int>(type: "int", nullable: false),
                    healthScore = table.Column<int>(type: "int", nullable: false),
                    creditsText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    license = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sourceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pricePerServing = table.Column<double>(type: "float", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    readyInMinutes = table.Column<int>(type: "int", nullable: false),
                    servings = table.Column<int>(type: "int", nullable: false),
                    sourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    openLicense = table.Column<int>(type: "int", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    spoonacularSourceUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpoonacularSearchViewModel", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AnalyzedInstruction",
                columns: table => new
                {
                    AnalyzedInstructionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpoonacularSearchViewModelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnalyzedInstruction", x => x.AnalyzedInstructionID);
                    table.ForeignKey(
                        name: "FK_AnalyzedInstruction_SpoonacularSearchViewModel_SpoonacularSearchViewModelID",
                        column: x => x.SpoonacularSearchViewModelID,
                        principalTable: "SpoonacularSearchViewModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutrition",
                columns: table => new
                {
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpoonacularSearchViewModelID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrition", x => x.NutritionID);
                    table.ForeignKey(
                        name: "FK_Nutrition_SpoonacularSearchViewModel_SpoonacularSearchViewModelID",
                        column: x => x.SpoonacularSearchViewModelID,
                        principalTable: "SpoonacularSearchViewModel",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Step",
                columns: table => new
                {
                    StepID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    step = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnalyzedInstructionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Step", x => x.StepID);
                    table.ForeignKey(
                        name: "FK_Step_AnalyzedInstruction_AnalyzedInstructionID",
                        column: x => x.AnalyzedInstructionID,
                        principalTable: "AnalyzedInstruction",
                        principalColumn: "AnalyzedInstructionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CaloricBreakdown",
                columns: table => new
                {
                    CaloricBreakdownID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    percentProtein = table.Column<double>(type: "float", nullable: false),
                    percentFat = table.Column<double>(type: "float", nullable: false),
                    percentCarbs = table.Column<double>(type: "float", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaloricBreakdown", x => x.CaloricBreakdownID);
                    table.ForeignKey(
                        name: "FK_CaloricBreakdown_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flavonoid",
                columns: table => new
                {
                    FlavonoidID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutrutionID = table.Column<int>(type: "int", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavonoid", x => x.FlavonoidID);
                    table.ForeignKey(
                        name: "FK_Flavonoid_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Property_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeightPerServing",
                columns: table => new
                {
                    WeightPerServingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<int>(type: "int", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeightPerServing", x => x.WeightPerServingID);
                    table.ForeignKey(
                        name: "FK_WeightPerServing_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localizedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.id);
                    table.ForeignKey(
                        name: "FK_Equipment_Step_StepID",
                        column: x => x.StepID,
                        principalTable: "Step",
                        principalColumn: "StepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    localizedName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false),
                    StepID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ingredient_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredient_Step_StepID",
                        column: x => x.StepID,
                        principalTable: "Step",
                        principalColumn: "StepID");
                });

            migrationBuilder.CreateTable(
                name: "Length",
                columns: table => new
                {
                    LengthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(type: "int", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Length", x => x.LengthId);
                    table.ForeignKey(
                        name: "FK_Length_Step_StepId",
                        column: x => x.StepId,
                        principalTable: "Step",
                        principalColumn: "StepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Temperature",
                columns: table => new
                {
                    TemperatureID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquipmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Temperature", x => x.TemperatureID);
                    table.ForeignKey(
                        name: "FK_Temperature_Equipment_EquipmentID",
                        column: x => x.EquipmentID,
                        principalTable: "Equipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Nutrient",
                columns: table => new
                {
                    NutrientID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amount = table.Column<double>(type: "float", nullable: false),
                    unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    percentOfDailyNeeds = table.Column<double>(type: "float", nullable: false),
                    NutritionID = table.Column<int>(type: "int", nullable: false),
                    Ingredientid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutrient", x => x.NutrientID);
                    table.ForeignKey(
                        name: "FK_Nutrient_Ingredient_Ingredientid",
                        column: x => x.Ingredientid,
                        principalTable: "Ingredient",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Nutrient_Nutrition_NutritionID",
                        column: x => x.NutritionID,
                        principalTable: "Nutrition",
                        principalColumn: "NutritionID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnalyzedInstruction_SpoonacularSearchViewModelID",
                table: "AnalyzedInstruction",
                column: "SpoonacularSearchViewModelID");

            migrationBuilder.CreateIndex(
                name: "IX_CaloricBreakdown_NutritionID",
                table: "CaloricBreakdown",
                column: "NutritionID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_StepID",
                table: "Equipment",
                column: "StepID");

            migrationBuilder.CreateIndex(
                name: "IX_Flavonoid_NutritionID",
                table: "Flavonoid",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_NutritionID",
                table: "Ingredient",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_StepID",
                table: "Ingredient",
                column: "StepID");

            migrationBuilder.CreateIndex(
                name: "IX_Length_StepId",
                table: "Length",
                column: "StepId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Nutrient_Ingredientid",
                table: "Nutrient",
                column: "Ingredientid");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrient_NutritionID",
                table: "Nutrient",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_Nutrition_SpoonacularSearchViewModelID",
                table: "Nutrition",
                column: "SpoonacularSearchViewModelID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Property_NutritionID",
                table: "Property",
                column: "NutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_Step_AnalyzedInstructionID",
                table: "Step",
                column: "AnalyzedInstructionID");

            migrationBuilder.CreateIndex(
                name: "IX_Temperature_EquipmentID",
                table: "Temperature",
                column: "EquipmentID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeightPerServing_NutritionID",
                table: "WeightPerServing",
                column: "NutritionID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaloricBreakdown");

            migrationBuilder.DropTable(
                name: "Flavonoid");

            migrationBuilder.DropTable(
                name: "Length");

            migrationBuilder.DropTable(
                name: "Nutrient");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Temperature");

            migrationBuilder.DropTable(
                name: "WeightPerServing");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Nutrition");

            migrationBuilder.DropTable(
                name: "Step");

            migrationBuilder.DropTable(
                name: "AnalyzedInstruction");

            migrationBuilder.DropTable(
                name: "SpoonacularSearchViewModel");
        }
    }
}
