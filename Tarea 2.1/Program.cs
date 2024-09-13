// Ruta del archivo CSV (las barras invertidas necesitan ser escapadas)
using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Tarea_2._1;

// Ruta del archivo CSV de entrada
string filePath = @"C:\Users\juans\Downloads\atp_matches_2015.csv";

// Configuración del lector CSV
var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
{
Delimiter = ",",
HasHeaderRecord = true,
};

// Se lee el archivo CSV mediante un reader.
using (var reader = new StreamReader(filePath))
using (var csv = new CsvReader(reader, csvConfig))
{
    // Variable que almacene todos los partidos leídos anteriormente.
    var partidos = csv.GetRecords<PartidoTenis>().ToList();

    // Mostrar el contenido por consola con tabulaciones como delimitador
    foreach (var partido in partidos)
    {
        Console.WriteLine($"{partido.tourney_id}\t{partido.tourney_name}\t{partido.surface}\t{partido.draw_size}\t" +
              $"{partido.tourney_level}\t{DateTime.ParseExact(partido.tourney_date, "yyyyMMdd", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd")}\t{partido.match_num}\t" +
              $"{partido.winner_id}\t{(partido.winner_seed.HasValue ? partido.winner_seed.ToString() : "")}\t" +
              $"{partido.winner_entry}\t{partido.winner_name}\t{partido.winner_hand}\t{partido.winner_ht}\t" +
              $"{partido.winner_ioc}\t{partido.winner_age}\t{partido.loser_id}\t" +
              $"{(partido.loser_seed.HasValue ? partido.loser_seed.ToString() : "")}\t{partido.loser_entry}\t" +
              $"{partido.loser_name}\t{partido.loser_hand}\t{partido.loser_ht}\t{partido.loser_ioc}\t" +
              $"{partido.loser_age}\t{partido.score}\t{partido.best_of}\t{partido.round}\t{partido.minutes}\t" +
              $"{partido.w_ace}\t{partido.w_df}\t{partido.w_svpt}\t{partido.w_1stIn}\t{partido.w_1stWon}\t" +
              $"{partido.w_2ndWon}\t{partido.w_SvGms}\t{partido.w_bpSaved}\t{partido.w_bpFaced}\t" +
              $"{partido.l_ace}\t{partido.l_df}\t{partido.l_svpt}\t{partido.l_1stIn}\t{partido.l_1stWon}\t" +
              $"{partido.l_2ndWon}\t{partido.l_SvGms}\t{partido.l_bpSaved}\t{partido.l_bpFaced}\t" +
              $"{partido.winner_rank}\t{partido.winner_rank_points}\t{partido.loser_rank}\t{partido.loser_rank_points}");
    }
}
