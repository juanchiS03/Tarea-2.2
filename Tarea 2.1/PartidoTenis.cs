using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_2._1
{
    internal class PartidoTenis
    {
        // Torneo
        public string tourney_id { get; set; }
        public string tourney_name { get; set; }
        public string surface { get; set; }
        public int? draw_size { get; set; }
        public string tourney_level { get; set; }
        public string tourney_date { get; set; }

        // Partido
        public int match_num { get; set; }

        // Ganador
        public int? winner_id { get; set; }
        public int? winner_seed { get; set; }
        public string winner_entry { get; set; }
        public string winner_name { get; set; }
        public string winner_hand { get; set; }
        public int? winner_ht { get; set; }
        public string winner_ioc { get; set; }
        public double winner_age { get; set; }

        // Perdedor
        public int? loser_id { get; set; }
        public int? loser_seed { get; set; }
        public string loser_entry { get; set; }
        public string loser_name { get; set; }
        public string loser_hand { get; set; }
        public int? loser_ht { get; set; }
        public string loser_ioc { get; set; }
        public double loser_age { get; set; }

        // Otros detalles del partido
        public string score { get; set; }
        public int? best_of { get; set; }
        public string round { get; set; }
        public int? minutes { get; set; }

        // Estadísticas del ganador
        public int? w_ace { get; set; }
        public int? w_df { get; set; }
        public int? w_svpt { get; set; }
        public int? w_1stIn { get; set; }
        public int? w_1stWon { get; set; }
        public int? w_2ndWon { get; set; }
        public int? w_SvGms { get; set; }
        public int? w_bpSaved { get; set; }
        public int? w_bpFaced { get; set; }

        // Estadísticas del perdedor
        public int? l_ace { get; set; }
        public int? l_df { get; set; }
        public int? l_svpt { get; set; }
        public int? l_1stIn { get; set; }
        public int? l_1stWon { get; set; }
        public int? l_2ndWon { get; set; }
        public int? l_SvGms { get; set; }
        public int? l_bpSaved { get; set; }
        public int? l_bpFaced { get; set; }

        // Ranking
        public int? winner_rank { get; set; }
        public int? winner_rank_points { get; set; }
        public int? loser_rank { get; set; }
        public int? loser_rank_points { get; set; }

    }
}
