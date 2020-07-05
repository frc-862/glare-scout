﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Foundation;
using LightScout.Models;
using Newtonsoft.Json;
using UIKit;

namespace LightScout.iOS
{
    public class WriteNRead : DataStore
    {
        public void SaveDummyData(string filename)
        {
            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                System.IO.Directory.CreateDirectory(Path.Combine(docpath, "FRCLightScout"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            docpath = Path.Combine(docpath, "FRCLightScout");
            var data = "";
            var finalPath = Path.Combine(docpath, filename);
            var DummyDataMatches = new List<TeamMatch>();
            var match = new TeamMatch();
            match.MatchNumber = 1;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            match = new TeamMatch();
            match.MatchNumber = 2;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            match = new TeamMatch();
            match.MatchNumber = 3;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            match = new TeamMatch();
            match.MatchNumber = 4;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            match = new TeamMatch();
            match.MatchNumber = 5;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            match = new TeamMatch();
            match.MatchNumber = 6;
            match.TeamNumber = 862;
            match.PowerCellInner = new int[21];
            match.PowerCellOuter = new int[21];
            match.PowerCellLower = new int[21];
            match.PowerCellMissed = new int[21];
            DummyDataMatches.Add(match);
            data = JsonConvert.SerializeObject(DummyDataMatches);
            try
            {
                System.IO.File.WriteAllText(finalPath, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public void SaveData(string filename, TeamMatch modeldata)
        {
            //ADD FILE PARSING HERE
            var docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                System.IO.Directory.CreateDirectory(Path.Combine(docpath, "FRCLightScout"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            docpath = Path.Combine(docpath, "FRCLightScout");
            var data = "";
            var finalPath = Path.Combine(docpath, filename);

            try
            {
                var beforedata = File.ReadAllText(finalPath);
                var modelstochange = JsonConvert.DeserializeObject<List<TeamMatch>>(beforedata);
                var specificmodeltochange = modelstochange.Where(x => x.TeamNumber == modeldata.TeamNumber && x.MatchNumber == modeldata.MatchNumber).FirstOrDefault();

                specificmodeltochange.MatchNumber = modeldata.MatchNumber;
                specificmodeltochange.TeamNumber = modeldata.TeamNumber;

                modelstochange.Remove(modelstochange.Where(x => x.TeamNumber == modeldata.TeamNumber && x.MatchNumber == modeldata.MatchNumber).FirstOrDefault());
                modelstochange.Add(modeldata);
                modelstochange = modelstochange.OrderBy(x => x.MatchNumber).ToList();

                data = JsonConvert.SerializeObject(modelstochange);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot find specified match in file system. Aborting...");
            }

            try
            {
                System.IO.File.WriteAllText(finalPath, data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
        public string LoadData(string filename)
        {
            var docpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FRCLightScout");
            var finalPath = Path.Combine(docpath, filename);
            var result = File.ReadAllText(finalPath);
            return result;
        }
    }
}