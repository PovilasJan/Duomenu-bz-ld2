namespace Org.Ktu.Isk.P175B602.Autonuoma.Repositories;

using Org.Ktu.Isk.P175B602.Autonuoma.Models;

/// <summary>
/// Database operations related to 'Klientas' entity.
/// </summary>
public class KlientasRepo : RepoBase
{
    public static List<Klientas> List()
    {
        var query = $@"SELECT * FROM `{Config.TblPrefix}klientas` ORDER BY asmens_kodas ASC";
        var drc = Sql.Query(query);

        var result = 
            Sql.MapAll<Klientas>(drc, (dre, t) => {
                t.AsmensKodas = dre.From<int>("asmens_kodas");
                t.Vardas = dre.From<string>("vardas");
                t.Pavarde = dre.From<string>("pavarde");
                t.Telefonas = dre.From<string>("tel_numeris");
                t.Epastas = dre.From<string>("el_pastas");
                t.Amzius = dre.From<int?>("amzius");
                t.RegistracijosData = dre.From<DateTime?>("registracijos_data");
                t.LojalumoTaskai = dre.From<int?>("lojalumo_taskai");
                t.Adresas = dre.From<string>("adresas");
            });

        return result;
    }

    public static Klientas Find(int asmensKodas)
    {
        var query = $@"SELECT * FROM `{Config.TblPrefix}klientas` WHERE asmens_kodas=?asmensKodas";

        var drc =
            Sql.Query(query, args => {
                args.Add("?asmensKodas", asmensKodas);
            });

        if (drc.Count > 0)
        {
            var result = 
                Sql.MapOne<Klientas>(drc, (dre, t) => {
                    t.AsmensKodas = dre.From<int>("asmens_kodas");
                    t.Vardas = dre.From<string>("vardas");
                    t.Pavarde = dre.From<string>("pavarde");
                    t.Telefonas = dre.From<string>("tel_numeris");
                    t.Epastas = dre.From<string>("el_pastas");
                    t.Amzius = dre.From<int?>("amzius");
                    t.RegistracijosData = dre.From<DateTime?>("registracijos_data");
                    t.LojalumoTaskai = dre.From<int?>("lojalumo_taskai");
                    t.Adresas = dre.From<string>("adresas");
                });

            return result;
        }

        return null;
    }

    public static void Insert(Klientas klientas)
    {
        var query =
            $@"INSERT INTO `{Config.TblPrefix}klientas`
            (
                asmens_kodas,
                vardas,
                pavarde,
                tel_numeris,
                el_pastas,
                amzius,
                registracijos_data,
                lojalumo_taskai,
                adresas
            )
            VALUES(
                ?asmensKodas,
                ?vardas,
                ?pavarde,
                ?telefonas,
                ?epastas,
                ?amzius,
                ?registracijosData,
                ?lojalumoTaskai,
                ?adresas
            )";

        Sql.Insert(query, args => {
            args.Add("?asmensKodas", klientas.AsmensKodas);
            args.Add("?vardas", klientas.Vardas);
            args.Add("?pavarde", klientas.Pavarde);
            args.Add("?telefonas", klientas.Telefonas);
            args.Add("?epastas", klientas.Epastas);
            args.Add("?amzius", klientas.Amzius);
            args.Add("?registracijosData", klientas.RegistracijosData);
            args.Add("?lojalumoTaskai", klientas.LojalumoTaskai);
            args.Add("?adresas", klientas.Adresas);
        });
    }

    public static void Update(Klientas klientas)
    {
        var query =
            $@"UPDATE `{Config.TblPrefix}klientas`
            SET
                vardas=?vardas,
                pavarde=?pavarde,
                tel_numeris=?telefonas,
                el_pastas=?epastas,
                amzius=?amzius,
                registracijos_data=?registracijosData,
                lojalumo_taskai=?lojalumoTaskai,
                adresas=?adresas
            WHERE
                asmens_kodas=?asmensKodas";

        Sql.Update(query, args => {
            args.Add("?asmensKodas", klientas.AsmensKodas);
            args.Add("?vardas", klientas.Vardas);
            args.Add("?pavarde", klientas.Pavarde);
            args.Add("?telefonas", klientas.Telefonas);
            args.Add("?epastas", klientas.Epastas);
            args.Add("?amzius", klientas.Amzius);
            args.Add("?registracijosData", klientas.RegistracijosData);
            args.Add("?lojalumoTaskai", klientas.LojalumoTaskai);
            args.Add("?adresas", klientas.Adresas);
        });
    }

    public static void Delete(int asmensKodas)
    {
        var query = $@"DELETE FROM `{Config.TblPrefix}klientas` WHERE asmens_kodas=?asmensKodas";
        Sql.Delete(query, args => {
            args.Add("?asmensKodas", asmensKodas);
        });
    }
}
