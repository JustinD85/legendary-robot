using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Audio",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    opus = table.Column<string>(nullable: true),
                    aac = table.Column<string>(nullable: true),
                    ogg = table.Column<string>(nullable: true),
                    mp3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audio", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kunyomi",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    romaji = table.Column<string>(nullable: true),
                    hiragana = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunyomi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meaning",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    english = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meaning", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    hiragana = table.Column<string>(nullable: true),
                    romaji = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Onyomi",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    romaji = table.Column<string>(nullable: true),
                    katakana = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Onyomi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pawns",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    AC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pawns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Position",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    hiragana = table.Column<string>(nullable: true),
                    romaji = table.Column<string>(nullable: true),
                    icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Position", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "References",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    grade = table.Column<short>(nullable: false),
                    kodansha = table.Column<short>(nullable: false),
                    classicNelson = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_References", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Strokes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strokes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Values",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Values", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Video",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    poster = table.Column<string>(nullable: true),
                    mp4 = table.Column<string>(nullable: true),
                    webm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Video", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    PawnId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Pawns_PawnId",
                        column: x => x.PawnId,
                        principalTable: "Pawns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Radical",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    character = table.Column<string>(nullable: true),
                    strokes = table.Column<int>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    positionId = table.Column<Guid>(nullable: true),
                    nameId = table.Column<Guid>(nullable: true),
                    meaningId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Radical", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Radical_Meaning_meaningId",
                        column: x => x.meaningId,
                        principalTable: "Meaning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Radical_Name_nameId",
                        column: x => x.nameId,
                        principalTable: "Name",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Radical_Position_positionId",
                        column: x => x.positionId,
                        principalTable: "Position",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    image = table.Column<string>(nullable: true),
                    StrokesId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Strokes_StrokesId",
                        column: x => x.StrokesId,
                        principalTable: "Strokes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Timing",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    time = table.Column<string>(nullable: true),
                    StrokesId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Timing", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Timing_Strokes_StrokesId",
                        column: x => x.StrokesId,
                        principalTable: "Strokes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kanji1",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    character = table.Column<string>(nullable: true),
                    meaningId = table.Column<Guid>(nullable: true),
                    strokesId = table.Column<Guid>(nullable: true),
                    onyomiId = table.Column<Guid>(nullable: true),
                    kunyomiId = table.Column<Guid>(nullable: true),
                    videoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanji1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kanji1_Kunyomi_kunyomiId",
                        column: x => x.kunyomiId,
                        principalTable: "Kunyomi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji1_Meaning_meaningId",
                        column: x => x.meaningId,
                        principalTable: "Meaning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji1_Onyomi_onyomiId",
                        column: x => x.onyomiId,
                        principalTable: "Onyomi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji1_Strokes_strokesId",
                        column: x => x.strokesId,
                        principalTable: "Strokes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji1_Video_videoId",
                        column: x => x.videoId,
                        principalTable: "Video",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animation",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    animation = table.Column<string>(nullable: true),
                    RadicalId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animation_Radical_RadicalId",
                        column: x => x.RadicalId,
                        principalTable: "Radical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Kanji",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    KanjiId = table.Column<Guid>(nullable: true),
                    RadicalId = table.Column<Guid>(nullable: true),
                    ReferencesId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kanji", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kanji_Kanji1_KanjiId",
                        column: x => x.KanjiId,
                        principalTable: "Kanji1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji_Radical_RadicalId",
                        column: x => x.RadicalId,
                        principalTable: "Radical",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kanji_References_ReferencesId",
                        column: x => x.ReferencesId,
                        principalTable: "References",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Example",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Japanese = table.Column<string>(nullable: true),
                    MeaningId = table.Column<Guid>(nullable: true),
                    AudioId = table.Column<Guid>(nullable: true),
                    KanjiAliveAPIId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Example", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Example_Audio_AudioId",
                        column: x => x.AudioId,
                        principalTable: "Audio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Example_Kanji_KanjiAliveAPIId",
                        column: x => x.KanjiAliveAPIId,
                        principalTable: "Kanji",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Example_Meaning_MeaningId",
                        column: x => x.MeaningId,
                        principalTable: "Meaning",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animation_RadicalId",
                table: "Animation",
                column: "RadicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Example_AudioId",
                table: "Example",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Example_KanjiAliveAPIId",
                table: "Example",
                column: "KanjiAliveAPIId");

            migrationBuilder.CreateIndex(
                name: "IX_Example_MeaningId",
                table: "Example",
                column: "MeaningId");

            migrationBuilder.CreateIndex(
                name: "IX_Image_StrokesId",
                table: "Image",
                column: "StrokesId");

            migrationBuilder.CreateIndex(
                name: "IX_Items_PawnId",
                table: "Items",
                column: "PawnId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji_KanjiId",
                table: "Kanji",
                column: "KanjiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji_RadicalId",
                table: "Kanji",
                column: "RadicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji_ReferencesId",
                table: "Kanji",
                column: "ReferencesId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji1_kunyomiId",
                table: "Kanji1",
                column: "kunyomiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji1_meaningId",
                table: "Kanji1",
                column: "meaningId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji1_onyomiId",
                table: "Kanji1",
                column: "onyomiId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji1_strokesId",
                table: "Kanji1",
                column: "strokesId");

            migrationBuilder.CreateIndex(
                name: "IX_Kanji1_videoId",
                table: "Kanji1",
                column: "videoId");

            migrationBuilder.CreateIndex(
                name: "IX_Radical_meaningId",
                table: "Radical",
                column: "meaningId");

            migrationBuilder.CreateIndex(
                name: "IX_Radical_nameId",
                table: "Radical",
                column: "nameId");

            migrationBuilder.CreateIndex(
                name: "IX_Radical_positionId",
                table: "Radical",
                column: "positionId");

            migrationBuilder.CreateIndex(
                name: "IX_Timing_StrokesId",
                table: "Timing",
                column: "StrokesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animation");

            migrationBuilder.DropTable(
                name: "Example");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Timing");

            migrationBuilder.DropTable(
                name: "Values");

            migrationBuilder.DropTable(
                name: "Audio");

            migrationBuilder.DropTable(
                name: "Kanji");

            migrationBuilder.DropTable(
                name: "Pawns");

            migrationBuilder.DropTable(
                name: "Kanji1");

            migrationBuilder.DropTable(
                name: "Radical");

            migrationBuilder.DropTable(
                name: "References");

            migrationBuilder.DropTable(
                name: "Kunyomi");

            migrationBuilder.DropTable(
                name: "Onyomi");

            migrationBuilder.DropTable(
                name: "Strokes");

            migrationBuilder.DropTable(
                name: "Video");

            migrationBuilder.DropTable(
                name: "Meaning");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "Position");
        }
    }
}
