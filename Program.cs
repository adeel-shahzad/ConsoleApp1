using System;

Console.WriteLine("Adeel Shahzad");
var workflowName = "snhp_rs_my2022_ect_CacheDB_Cloud__40d7ed54-b41d-4ca7-b789-2dd8abfb5af7";
var guid = Guid.Parse(workflowName.Substring(workflowName.IndexOf("_CacheDB_Cloud__") + 16));
Console.WriteLine(guid);