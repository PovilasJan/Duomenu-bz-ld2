namespace Org.Ktu.Isk.P175B602.Autonuoma.Repositories;

using Org.Ktu.Isk.P175B602.Autonuoma.Models;

/// <summary>
/// Database operations related to 'Darbuotojas' entity.
/// </summary>
public class DarbuotojasRepo : RepoBase
{
    public static List<Darbuotojas> List()
    {
        var query = $@"SELECT vardas, pavarde, asmens_kodas, el_pastas, tel_nr, pozicija, fk_elektronine_parduotuveid_elektronine_parduotuve
                       FROM `{Config.TblPrefix}darbuotojas`
                       ORDER BY asmens_kodas ASC";
        var drc = Sql.Query(query);

        var result =
            Sql.MapAll<Darbuotojas>(drc, (dre, t) => {
                t.Vardas = dre.From<string>("vardas");
                t.Pavarde = dre.From<string>("pavarde");
                t.AsmensKodas = dre.From<int>("asmens_kodas");
                t.ElPastas = dre.From<string>("el_pastas");
                t.TelNr = dre.From<string>("tel_nr");
                t.Pozicija = dre.From<string>("pozicija");
                t.FkElektronineParduotuveId = dre.From<int>("fk_elektronine_parduotuveid_elektronine_parduotuve");
            });

        return result;
    }

    public static Darbuotojas Find(int asmensKodas)
    {
        var query = $@"SELECT vardas, pavarde, asmens_kodas, el_pastas, tel_nr, pozicija, fk_elektronine_parduotuveid_elektronine_parduotuve
                       FROM `darbuotojas`
                       WHERE asmens_kodas=?asmensKodas";

        var drc = Sql.Query(query, args => {
            args.Add("?asmensKodas", asmensKodas);
        });

        if (drc.Count > 0)
        {
            var result =
                Sql.MapOne<Darbuotojas>(drc, (dre, t) => {
                    t.Vardas = dre.From<string>("vardas");
                    t.Pavarde = dre.From<string>("pavarde");
                    t.AsmensKodas = dre.From<int>("asmens_kodas");
                    t.ElPastas = dre.From<string>("el_pastas");
                    t.TelNr = dre.From<string>("tel_nr");
                    t.Pozicija = dre.From<string>("pozicija");
                    t.FkElektronineParduotuveId = dre.From<int>("fk_elektronine_parduotuveid_elektronine_parduotuve");
                });

            return result;
        }

        return null;
    }

    public static void Update(Darbuotojas darb)
    {
        var query =
            $@"UPDATE `{Config.TblPrefix}darbuotojas`
               SET vardas=?vardas, pavarde=?pavarde, el_pastas=?elPastas, tel_nr=?telNr, pozicija=?pozicija, fk_elektronine_parduotuveid_elektronine_parduotuve=?fkElektronineParduotuveId
               WHERE asmens_kodas=?asmensKodas";

        Sql.Update(query, args => {
            args.Add("?vardas", darb.Vardas);
            args.Add("?pavarde", darb.Pavarde);
            args.Add("?elPastas", darb.ElPastas);
            args.Add("?telNr", darb.TelNr);
            args.Add("?pozicija", darb.Pozicija);
            args.Add("?fkElektronineParduotuveId", darb.FkElektronineParduotuveId);
            args.Add("?asmensKodas", darb.AsmensKodas);
        });
    }

    public static void Insert(Darbuotojas darb)
    {
        var query =
            $@"INSERT INTO `{Config.TblPrefix}darbuotojas`
               (vardas, pavarde, asmens_kodas, el_pastas, tel_nr, pozicija, fk_elektronine_parduotuveid_elektronine_parduotuve)
               VALUES (?vardas, ?pavarde, ?asmensKodas, ?elPastas, ?telNr, ?pozicija, ?fkElektronineParduotuveId)";

        Sql.Insert(query, args => {
            args.Add("?vardas", darb.Vardas);
            args.Add("?pavarde", darb.Pavarde);
            args.Add("?asmensKodas", darb.AsmensKodas);
            args.Add("?elPastas", darb.ElPastas);
            args.Add("?telNr", darb.TelNr);
            args.Add("?pozicija", darb.Pozicija);
            args.Add("?fkElektronineParduotuveId", darb.FkElektronineParduotuveId);
        });
    }

    public static void Delete(int asmensKodas)
    {
        var query = $@"DELETE FROM `{Config.TblPrefix}darbuotojas` WHERE asmens_kodas=?asmensKodas";
        Sql.Delete(query, args => {
            args.Add("?asmensKodas", asmensKodas);
        });
    }
}
