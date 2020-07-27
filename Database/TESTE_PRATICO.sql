CREATE TABLE "configuration" (
	"id"	INTEGER,
	"max_spans_distance"	NUMERIC NOT NULL,
	"min_total_distance"	NUMERIC NOT NULL,
	"max_distance_reinforced_base"	NUMERIC NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "processing" (
	"id"	INTEGER,
	"total_distance"	NUMERIC NOT NULL,
	"processed"	INTEGER NOT NULL DEFAULT 0,
	"configuration_id"	INTEGER,
	FOREIGN KEY("configuration_id") REFERENCES "configuration"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "result" (
	"id"	INTEGER,
	"number_pillars"	INTEGER NOT NULL,
	"spans_distance"	NUMERIC NOT NULL,
	"number_reinforced_bases"	INTEGER NOT NULL,
	"processing_id"	INTEGER NOT NULL,
	"viewed"	INTEGER NOT NULL DEFAULT 0,
	FOREIGN KEY("processing_id") REFERENCES "processing"("id"),
	PRIMARY KEY("id" AUTOINCREMENT)
);

CREATE TABLE "reinforced_pillar" (
	"id"	INTEGER,
	"result_id"	INTEGER NOT NULL,
	"number"	INTEGER NOT NULL,
	PRIMARY KEY("id" AUTOINCREMENT),
	FOREIGN KEY("result_id") REFERENCES "result"("id")
);

--Tabela criada pelo gerenciador
--CREATE TABLE "sqlite_sequence" (
--	"name"	,
--	"seq"	
--);